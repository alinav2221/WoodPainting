using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Xml;

namespace WoodPainting2
{
    public partial class QuestionForm : Form
    {
        protected XmlDocument xmlDoc = new XmlDocument();
        XmlElement xmlRoot;

        private Point mPoint;

        private string resultRadioButton = "";   //ответ для вопраса с одиночным выбором ответа
        private string resultTextBox = "";       //ответ для вопраса с свободным ответом
        protected string curDir = Directory.GetCurrentDirectory();    //путь к папке debug
        protected string paintingQuestion;  //раздел для тестирования
        protected string type;     //тип вопроса

        protected int numberRandomQuestion;  //случайный номер вопроса
        protected int numberRandomAnswer;    //случайный номер ответа
        protected int quantityQuestion = 0;  //счетчик для количества вопросов
        protected int quantityQuestions; // количество вопросов
        public int score = 0;      //количество правильных ответов
        private int timeMax = 0;   //максивальное время для таймера

        protected int[] numbers;   //массив с номерами вопросов
        protected char[] answer = new char[4] { 'a', 'b', 'c', 'd'};  //массив с вариантами ответа 

        protected Random random = new Random();       //экземпляр класса рандом

        public List<string> answerButton = new List<string>();    //лист для отображения ответов на форме
        private List<string> results = new List<string>();    //список с правильными ответами
        private List<string> resultsCheckBox = new List<string>();   //список выбранных пользователем нескольких ответов

        public QuestionForm()
        {
            InitializeComponent();
            paintingQuestion = Properties.Settings.Default.namePaint;
            xmlDoc.Load(String.Format("file:///{0}/{1}/Questions.xml", curDir, paintingQuestion)); //загрузка xml-документа
            xmlRoot = xmlDoc.DocumentElement;  //корневой тэг документа
            quantityQuestions = NumberQuestions();
            //numbers = new int[quantityQuestions];   //массив с номерами вопросов

        }
        public int[] ArrayRandomNumbers(int quantityArray)
        {
            random = new Random();
            int[] numbers = new int[quantityArray];
            for (int i = 0; i < numbers.Length; i++)
            {
                //генерация числа
                numberRandomQuestion = random.Next(1, quantityArray + 1);
                //если сгенерированное число не содержится в массиве
                if (!numbers.Contains(numberRandomQuestion))
                {
                    numbers[i] = numberRandomQuestion;
                }
                //иначе возвращаемся на предыдущий шаг для нового значения
                else
                {
                    i--;
                }
            }
            return numbers;
        }
        private void QuestionFormOnLoad(object sender, EventArgs e)
        {
            furtherButton.Visible = true;
            timeLabel.Visible = false;
            timeProgressBar.Visible = false;
            answerGroupBox.Visible = false;
            questionLabel.Visible = false;
            numbers = ArrayRandomNumbers(quantityQuestions);
        }

        private void FurtherButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                descriptionLabel.Visible = false;
                //если поле ответа не заполнены
                if (type == "one" && resultRadioButton == "")
                {
                    questionTimer.Stop();    //остановка таймера
                    MessageBox.Show("Не все поля заполнены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вывод предупреждения
                    questionTimer.Start();     //возобновление работы таймера
                }
                else if (type == "multi" && resultsCheckBox.Count == 0)
                {
                    questionTimer.Stop();    //остановка таймера
                    MessageBox.Show("Не все поля заполнены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вывод предупреждения
                    questionTimer.Start();     //возобновление работы таймера
                }
                else if (type == "write" && resultTextBox == "")
                {
                    questionTimer.Stop();    //остановка таймера
                    MessageBox.Show("Поле не заполнено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вывод предупреждения
                    questionTimer.Start();     //возобновление работы таймера
                }
                else
                {
                    //если ответ записан 
                    if (resultRadioButton != "")
                    {
                        //если ответ пользователя совпадает с правильным ответом
                        if (resultRadioButton == results.First())
                        {
                            //прибавление к счетчику правильных ответов единицу
                            score++;
                            //очищение переменной
                            resultRadioButton = "";
                        }
                    }
                    //если ответы выбраны
                    else if (resultsCheckBox.Count > 0)
                    {
                        //выявление разницы между ответами пользователя и правильными ответами
                        var superfluous = resultsCheckBox.Except(results);
                        //если разницы нет
                        if (superfluous == null || !superfluous.Any())
                        {
                            //прибавление к счетчику правильных ответов единицу
                            score++;
                        }
                    }
                    //если есть ответ, введенный пользователем 
                    else if (resultTextBox != "")
                    {
                        //если ответы совпадают в нижнем регистре
                        if (resultTextBox.ToLower() == results.First().ToLower())
                        {
                            //прибавление к счетчику правильных ответов единицу
                            score++;
                            //очищение переменной
                            resultTextBox = "";
                        }
                    }
                    timeLabel.Visible = true;
                    timeProgressBar.Visible = true;
                    remainingTimeLabel.Visible = true;
                    questionNumberLabel.Visible = true;
                    questionLabel.Visible = true;
                    answerGroupBox.Visible = true;
                    firstRadioButton.Checked = false;
                    secondRadioButton.Checked = false;
                    thirdRadioButton.Checked = false;
                    fourthRadioButton.Checked = false;
                    firstCheckBox.Checked = false;
                    secondCheckBox.Checked = false;
                    thirdCheckBox.Checked = false;
                    fourthCheckBox.Checked = false;


                    timeProgressBar.Value = 0;     //значение Progress Bar

                    answerTextBox.Text = "";    //очищение поля ввода
                    //очищение списков
                    results.Clear();  
                    resultsCheckBox.Clear();
                    answerButton.Clear();

                    //если последующий вопрос меньше всех вопросов
                    if (quantityQuestion < quantityQuestions)
                    {
                        //генерация массива с случайными вариантами ответов
                        for (int i = answer.Length - 1; i >= 0; i--)
                        {
                            int j = random.Next(i + 1);

                            char tmp = answer[j];
                            answer[j] = answer[i];
                            answer[i] = tmp;
                        }
                         //вызов функции, выводящей вопрос с вариантами ответа из xml-документа на форму
                        RandomQuestion(numbers[quantityQuestion], answer);
                        quantityQuestion++;      //прибаление количества вопросов
                        questionNumberLabel.Text = quantityQuestion.ToString() + $@"\{quantityQuestions} вопросов.";
                    }
                    else
                    {
                        questionTimer.Stop();    //остановка таймера
                        //вывод формы с результатом тестирования
                        ResultsForm resultsForm = new ResultsForm("test", score, quantityQuestions);
                        //resultsForm.infoLabel.Text = "Результат тестирования";
                        //resultsForm.quantityLabel.Visible = true;
                        //resultsForm.resultLabel.Text = "Ваша оценка";
                        //resultsForm.okButton.Click += OkButtonOnClick;
                        resultsForm.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int NumberQuestions()
        {
            int quantity = 0;
            foreach (XmlNode xnode in xmlRoot)
            {
                quantity++;
            }
            return quantity;
        }

        private void RandomQuestion(int number, char[] answers)
        {
            try
            {
                //для каждого узла с вопросом и ответами
                foreach (XmlNode xnode in xmlRoot)
                {
                    XmlNode attrPicture = xnode.Attributes.GetNamedItem("picture");    //значение атрибута с наличием изображения
                    XmlNode attrNumber = xnode.Attributes.GetNamedItem("number");   //значение атрибута номера вопроса
                    XmlNode attrType = xnode.Attributes.GetNamedItem("type");       //значение атрибута типа вопроса
                    //если вопрос совпадает с номером вопроса
                    if (attrNumber.Value == number.ToString())
                    {
                        type = attrType.Value;     //значение атрибута типа вопроса
                        //цикл для выбора вариантов ответа
                        for (int i = 0; i < answers.Length; i++)
                        {
                            //для каждого тэга с вариантом ответа
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                XmlNode answer;
                                //если тип вопроса с одиночным ответом
                                if (attrType.Value == "one")
                                {
                                    answerGroupBox.Text = "Выбор варианта ответа";
                                    firstCheckBox.Visible = false;
                                    secondCheckBox.Visible = false;
                                    thirdCheckBox.Visible = false;
                                    fourthCheckBox.Visible = false;
                                    answerTextBox.Visible = false;
                                    //вывод текст вопроса
                                    if (childnode.Name == "qu")
                                    {
                                        questionLabel.Text = childnode.InnerText;
                                    }
                                    timeMax = 600; //определение времени для вопроса
                                    seconds = timeMax / 10;
                                    answer = childnode.Attributes.GetNamedItem("right"); //значение атрибута обозначения правильный ответ или нет
                                    //если имя тэга с ответом совпадает с элементом массива
                                    if (childnode.Name == answers[i].ToString())
                                    {
                                        //запись варианта ответа в список 
                                        answerButton.Add(childnode.InnerText);

                                        if (answer.Value == "true")
                                        {
                                            //запись правильного варианта ответа в список 
                                            results.Add(childnode.InnerText);
                                        }
                                        break;
                                    }
                                }
                                //если тип вопроса с выбором нескольких вариантов ответов
                                if (attrType.Value == "multi")
                                {
                                    answerGroupBox.Text = "Выбор нескольких вариантов ответа";
                                    firstRadioButton.Visible = false;
                                    secondRadioButton.Visible = false;
                                    thirdRadioButton.Visible = false;
                                    fourthRadioButton.Visible = false;
                                    answerTextBox.Visible = false;
                                    if (childnode.Name == "qu")    //вывод текст вопроса
                                    {
                                        questionLabel.Text = childnode.InnerText;
                                    }
                                    answer = childnode.Attributes.GetNamedItem("right");
                                    timeMax = 900; seconds = timeMax / 10;
                                    if (childnode.Name == answers[i].ToString())
                                    {
                                        answerButton.Add(childnode.InnerText);
                                        if (answer.Value == "true")
                                        {
                                            results.Add(childnode.InnerText);
                                        }
                                        break;
                                    }
                                }
                                //если тип вопроса со свободным ответом
                                if (attrType.Value == "write")
                                {
                                    answerGroupBox.Text = "Ввод ответа";
                                    if (childnode.Name == "qu") //вывод текст вопроса
                                    {
                                        questionLabel.Text = childnode.InnerText;
                                    }
                                    timeMax = 900; seconds = timeMax / 10;
                                    if (childnode.Name == "answer")
                                    {
                                        answerTextBox.Visible = true;
                                        firstRadioButton.Visible = false;
                                        secondRadioButton.Visible = false;
                                        thirdRadioButton.Visible = false;
                                        fourthRadioButton.Visible = false;
                                        firstCheckBox.Visible = false;
                                        secondCheckBox.Visible = false;
                                        thirdCheckBox.Visible = false;
                                        fourthCheckBox.Visible = false;
                                        results.Add(childnode.InnerText);    //запись правильного варианта ответа в список 
                                        break; //выход из цикла
                                    }
                                }
                            }
                        }

                       //отображение вариантов ответов на форме
                        int k = 0;
                        if (attrType.Value == "one")
                        {
                            firstRadioButton.Visible = true;
                            firstRadioButton.Text = answerButton[k];
                            secondRadioButton.Visible = true;
                            secondRadioButton.Text = answerButton[k + 1];
                            thirdRadioButton.Visible = true;
                            thirdRadioButton.Text = answerButton[k + 2];
                            fourthRadioButton.Visible = true;
                            fourthRadioButton.Text = answerButton[k + 3];
                        }
                        else if (attrType.Value == "multi")
                        {
                            firstCheckBox.Visible = true;
                            firstCheckBox.Text = answerButton[k];
                            secondCheckBox.Visible = true;
                            secondCheckBox.Text = answerButton[k + 1];
                            thirdCheckBox.Visible = true;
                            thirdCheckBox.Text = answerButton[k + 2];
                            fourthCheckBox.Visible = true;
                            fourthCheckBox.Text = answerButton[k + 3];
                        }
                    }
                }
                questionTimer.Start();   //запуск таймера
                timeProgressBar.Maximum = seconds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        int seconds = 0;
        private void QuestionTimerOnTick(object sender, EventArgs e)
        {
            try
            {
                seconds--;
                remainingTimeLabel.BackColor = Color.White;
                timeProgressBar.Increment(1);      //задание шага Progress Bar
                remainingTimeLabel.Text = TimeSpan.FromSeconds(seconds).ToString("mm\\:ss");
                //если значение ProgressBar достигает максимума
                if (timeProgressBar.Value == timeProgressBar.Maximum)
                {
                    questionTimer.Stop();  //остановка таймера
                    type = "";   //очищение переменной
                    FurtherButtonOnClick(sender, e);//нажатие на кнопку "Далее"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AnswerTextBoxOnTextChanged(object sender, EventArgs e)
        {
            //получение ответа пользователя из поля ввода
            TextBox textBox = (TextBox)sender;
            if(textBox.Text != "")
            { 
                resultTextBox = textBox.Text;
            }
        }

        private void AnswerRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            //получения ответа пользователя из радио-кнопки
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                resultRadioButton = radio.Text;
            }
        }

        private void AnswerCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            //получение ответов пользователя из выбранных флажков
            CheckBox checkBox = (CheckBox)sender;
            if(checkBox.Checked) 
            { 
                resultsCheckBox.Add(checkBox.Text);
            }
            else
            {
                resultsCheckBox.Remove(checkBox.Text);
            }
        }


        private void QuestionFormOnMouseDown(object sender, MouseEventArgs e)
        {
            //задание координат формы при нажатии кнопки мыши
            mPoint = new Point(e.X, e.Y);
        }

        private void QuestionFormOnMouseMove(object sender, MouseEventArgs e)
        {
            //перемещение формы пользователем
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void InfoButtonOnClick(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        private void ExitPictureBoxOnClick(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Вы хотите перейти к окну изучения теории?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                TheoryForm theoryForm = new TheoryForm();
                theoryForm.Show();
                this.Close();
            }
        }

        private void MaximizePictureBoxOnClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimizePictureBoxOnClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReferencePictureBoxOnClick(object sender, EventArgs e)
        {
            Forms.ManualForm manualForm = new Forms.ManualForm();
            manualForm.Show();
        }
    }
}
