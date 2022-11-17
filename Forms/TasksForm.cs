using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WoodPainting2
{
    public partial class TasksForm : WoodPainting2.StyleForm
    {
        string painting;
        List<string> imageElementName, imageCompositionName;
        List<Image> elementsImagesList, compositionImageList;
        List<Panel> selectedPanel = new List<Panel>();

        protected int[] numbersRandomAnswers;   //массив с номерами вопросов
        int numberRandomAnswer;
        Random random;
        private Point mPoint;
        int deltaX, deltaY; // Значения дельта - некоторая условная разность координат курсора относительно экрана и позиции объекта (лейбла) относительно границ формы-владельца

        public TasksForm()
        {
            InitializeComponent();
            painting = Properties.Settings.Default.namePaint;
            nameLabel.Text = painting;
        }

        private void TasksFormOnLoad(object sender, EventArgs e)
        {
            taskTabControl.Appearance = TabAppearance.FlatButtons;
            taskTabControl.ItemSize = new Size(0, 1);
            taskTabControl.SizeMode = TabSizeMode.Fixed;
            MoveTaskButtonOnClick(sender, e);
        }

        private void TestPictureBoxOnClick(object sender, EventArgs e)
        {
            Close();
            Form form2 = Application.OpenForms[1];
            form2.Close();
            QuestionForm questionForm = new QuestionForm();
            questionForm.Show();
        }

        int restFiles = 0;
        private void MoveTaskButtonOnClick(object sender, EventArgs e)
        {
            taskTabControl.SelectedTab = firstTaskTabPage;
            imageElementName = new List<string>();
            elementsImagesList = new List<Image>();
            numbersRandomAnswers = new int[8];
            int countFiles = 0, restWithoutFiles = 8;
            random = new Random();
            DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + "/" + painting + "/Элементы/");
            restFiles = directoryInfo.GetFiles().Length > 8 ? 8 : directoryInfo.GetFiles().Length;
            foreach (var file in directoryInfo.GetFiles())
            {
                countFiles++;
                if (countFiles <= 8)
                {
                    if (Path.GetExtension(file.FullName) == ".jpg" || Path.GetExtension(file.FullName) == ".png")
                    {
                        elementsImagesList.Add(Image.FromFile(file.FullName));
                        imageElementName.Add(file.Name.Remove(file.Name.LastIndexOf('.')));
                    }
                }
                else
                {
                    break;
                }
            }
            if (directoryInfo.GetFiles().Length < 8)
            {
                restWithoutFiles -= directoryInfo.GetFiles().Length;
                while (restWithoutFiles > 0)
                {
                    elementsImagesList.Add(null);
                    imageElementName.Add(null);
                    restWithoutFiles--;
                }
            }

            for (int i = 0; i < imageElementName.Count; i++)
            {
                //генерация числа
                numberRandomAnswer = random.Next(1, 9);
                //если сгенерированное число не содержится в массиве
                if (!numbersRandomAnswers.Contains(numberRandomAnswer))
                {
                    numbersRandomAnswers[i] = numberRandomAnswer;
                }
                //иначе возвращаемся на предыдущий шаг для нового значения
                else
                {
                    i--;
                }
            }
            firstElementPictureBox.Image = elementsImagesList[0] == null ? Properties.Resources.Нет_фото : elementsImagesList[0];
            firstNameElementLabel.Text = imageElementName[numbersRandomAnswers[0] - 1] == null ? "" : imageElementName[numbersRandomAnswers[0] - 1];
            secondElementPictureBox.Image = elementsImagesList[1] == null ? Properties.Resources.Нет_фото : elementsImagesList[1];
            secondNameElementLabel.Text = imageElementName[numbersRandomAnswers[1] - 1] == null ? "" : imageElementName[numbersRandomAnswers[1] - 1];
            thirdElementPictureBox.Image = elementsImagesList[2] == null ? Properties.Resources.Нет_фото : elementsImagesList[2];
            thirdNameElementLabel.Text = imageElementName[numbersRandomAnswers[2] - 1] == null ? "" : imageElementName[numbersRandomAnswers[2] - 1];
            fourthElementPictureBox.Image = elementsImagesList[3] == null ? Properties.Resources.Нет_фото : elementsImagesList[3];
            fourthNameElementLabel.Text = imageElementName[numbersRandomAnswers[3] - 1] == null ? "" : imageElementName[numbersRandomAnswers[3] - 1];
            fifthElementPictureBox.Image = elementsImagesList[4] == null ? Properties.Resources.Нет_фото : elementsImagesList[4];
            fifthNameElementLabel.Text = imageElementName[numbersRandomAnswers[4] - 1] == null ? "" : imageElementName[numbersRandomAnswers[4] - 1];
            sixthElementPictureBox.Image = elementsImagesList[5] == null ? Properties.Resources.Нет_фото : elementsImagesList[5];
            sixthNameElementLabel.Text = imageElementName[numbersRandomAnswers[5] - 1] == null ? "" : imageElementName[numbersRandomAnswers[5] - 1];
            seventhElementPictureBox.Image = elementsImagesList[6] == null ? Properties.Resources.Нет_фото : elementsImagesList[6];
            seventhNameElementLabel.Text = imageElementName[numbersRandomAnswers[6] - 1] == null ? "" : imageElementName[numbersRandomAnswers[6] - 1];
            eighthElementPictureBox.Image = elementsImagesList[7] == null ? Properties.Resources.Нет_фото : elementsImagesList[7];
            eighthNameElementLabel.Text = imageElementName[numbersRandomAnswers[7] - 1] == null ? "" : imageElementName[numbersRandomAnswers[7] - 1];
        }

        private void NameElementLabelOnMouseMove(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;

            if (e.Button == MouseButtons.Left)
            {
                label.Left = Cursor.Position.X - deltaX; //устанавливаем лейбл в новом месте относительно нового положения курсора экрана
                label.Top = Cursor.Position.Y - deltaY;
            }
        }

        private void NameElementLabelOnMouseUp(object sender, MouseEventArgs e)
        {
            deltaX = 0;// Сбрасываем значения дельта
            deltaY = 0;

            if (sender != null && sender.GetType() == typeof(Label))
            {
                if (e.Button == MouseButtons.Left)
                {
                    Label answer = (Label)sender;
                    if (answer.Location.X > firstNamePaintPanel.Location.X && answer.Location.Y > firstNamePaintPanel.Location.Y)
                    {
                        if (answer.Location.X + answer.Width > firstNamePaintPanel.Location.X)
                        {
                            if ((answer.Location.X + answer.Width) < firstNamePaintPanel.Location.X + firstNamePaintPanel.Width
                                && (answer.Location.Y + answer.Height) < firstNamePaintPanel.Location.Y + firstNamePaintPanel.Height)
                            {
                                if (answer.Text == imageElementName[0])
                                {
                                    firstNamePaintPanel.BackColor = Color.Green;
                                    firstNamePaintPanel.Controls.Add(answer);
                                    answer.Enabled = false;
                                    selectedPanel.Add(firstNamePaintPanel);
                                }
                                else
                                {
                                    if (!selectedPanel.Contains(firstNamePaintPanel))
                                    {
                                        firstNamePaintPanel.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    if (answer.Location.X > secondNamePaintPanel.Location.X && answer.Location.Y > secondNamePaintPanel.Location.Y)
                    {
                        if (answer.Location.X + answer.Width > secondNamePaintPanel.Location.X)
                        {
                            if ((answer.Location.X + answer.Width) < secondNamePaintPanel.Location.X + secondNamePaintPanel.Width
                                && (answer.Location.Y + answer.Height) < secondNamePaintPanel.Location.Y + secondNamePaintPanel.Height)
                            {
                                //answer.Location = secondNamePaintPanel.Location;
                                if (answer.Text == imageElementName[1])
                                {
                                    secondNamePaintPanel.BackColor = Color.Green;
                                    answer.Enabled = false;
                                    secondNamePaintPanel.Controls.Add(answer);
                                    selectedPanel.Add(secondNamePaintPanel);
                                }
                                else
                                {
                                    if (!selectedPanel.Contains(secondNamePaintPanel))
                                    {
                                        secondNamePaintPanel.BackColor = Color.Red;
                                    }
                                }

                            }
                        }
                    }
                    if (answer.Location.X > thirdNamePaintPanel.Location.X && answer.Location.Y > thirdNamePaintPanel.Location.Y)
                    {
                        if (answer.Location.X + answer.Width > thirdNamePaintPanel.Location.X)
                        {
                            if ((answer.Location.X + answer.Width) < thirdNamePaintPanel.Location.X + thirdNamePaintPanel.Width
                                && (answer.Location.Y + answer.Height) < thirdNamePaintPanel.Location.Y + thirdNamePaintPanel.Height)
                            {
                                if (answer.Text == imageElementName[2])
                                {
                                    thirdNamePaintPanel.BackColor = Color.Green;
                                    answer.Enabled = false;
                                    thirdNamePaintPanel.Controls.Add(answer);
                                    selectedPanel.Add(thirdNamePaintPanel);
                                }
                                else
                                {
                                    if (!selectedPanel.Contains(thirdNamePaintPanel))
                                    {
                                        thirdNamePaintPanel.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    if (answer.Location.X > fourthNamePaintPanel.Location.X && answer.Location.Y > fourthNamePaintPanel.Location.Y)
                    {
                        if (answer.Location.X + answer.Width > fourthNamePaintPanel.Location.X)
                        {
                            if ((answer.Location.X + answer.Width) < fourthNamePaintPanel.Location.X + fourthNamePaintPanel.Width
                                && (answer.Location.Y + answer.Height) < fourthNamePaintPanel.Location.Y + fourthNamePaintPanel.Height)
                            {
                                if (answer.Text == imageElementName[3])
                                {
                                    fourthNamePaintPanel.BackColor = Color.Green;
                                    answer.Enabled = false;
                                    fourthNamePaintPanel.Controls.Add(answer);
                                    selectedPanel.Add(fourthNamePaintPanel);
                                }
                                else
                                {
                                    if (!selectedPanel.Contains(fourthNamePaintPanel))
                                    {
                                        fourthNamePaintPanel.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    if (answer.Location.X > fivthNamePaintPanel.Location.X && answer.Location.Y > fivthNamePaintPanel.Location.Y)
                    {
                        if (answer.Location.X + answer.Width > fivthNamePaintPanel.Location.X)
                        {
                            if ((answer.Location.X + answer.Width) < fivthNamePaintPanel.Location.X + fivthNamePaintPanel.Width
                                && (answer.Location.Y + answer.Height) < fivthNamePaintPanel.Location.Y + fivthNamePaintPanel.Height)
                            {
                                if (answer.Text == imageElementName[4])
                                {
                                    fivthNamePaintPanel.BackColor = Color.Green;
                                    answer.Enabled = false;
                                    fivthNamePaintPanel.Controls.Add(answer);
                                    selectedPanel.Add(fivthNamePaintPanel);
                                }
                                else
                                {
                                    if (!selectedPanel.Contains(fivthNamePaintPanel))
                                    {
                                        fivthNamePaintPanel.BackColor = Color.Red;
                                    }
                                }
                            }
                                
                        }
                    }
                    if (answer.Location.X > sixthNamePaintPanel.Location.X && answer.Location.Y > sixthNamePaintPanel.Location.Y)
                    {
                        if (answer.Location.X + answer.Width > sixthNamePaintPanel.Location.X)
                        {
                            if ((answer.Location.X + answer.Width) < sixthNamePaintPanel.Location.X + sixthNamePaintPanel.Width
                                && (answer.Location.Y + answer.Height) < sixthNamePaintPanel.Location.Y + sixthNamePaintPanel.Height)

                            {
                                if (answer.Text == imageElementName[5])
                                {
                                    sixthNamePaintPanel.BackColor = Color.Green;
                                    answer.Enabled = false;
                                    sixthNamePaintPanel.Controls.Add(answer);
                                    selectedPanel.Add(sixthNamePaintPanel);
                                }
                                else
                                {
                                    if (!selectedPanel.Contains(sixthNamePaintPanel))
                                    {
                                        sixthNamePaintPanel.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    if (answer.Location.X > seventhNamePaintPanel.Location.X && answer.Location.Y > seventhNamePaintPanel.Location.Y)
                    {
                        if (answer.Location.X + answer.Width > seventhNamePaintPanel.Location.X)
                        {
                            if ((answer.Location.X + answer.Width) < seventhNamePaintPanel.Location.X + seventhNamePaintPanel.Width
                                && (answer.Location.Y + answer.Height) < seventhNamePaintPanel.Location.Y + seventhNamePaintPanel.Height)
                            {
                                if (answer.Text == imageElementName[6])
                                {
                                    seventhNamePaintPanel.BackColor = Color.Green;
                                    answer.Enabled = false;
                                    seventhNamePaintPanel.Controls.Add(answer);
                                    selectedPanel.Add(seventhNamePaintPanel);
                                }
                                else
                                {
                                    if (!selectedPanel.Contains(seventhNamePaintPanel))
                                    {
                                        seventhNamePaintPanel.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    if (answer.Location.X > eigthNamePaintPanel.Location.X && answer.Location.Y > eigthNamePaintPanel.Location.Y)
                    {
                        if (answer.Location.X + answer.Width > eigthNamePaintPanel.Location.X)
                        {
                            if ((answer.Location.X + answer.Width) < eigthNamePaintPanel.Location.X + eigthNamePaintPanel.Width
                                && (answer.Location.Y + answer.Height) < eigthNamePaintPanel.Location.Y + eigthNamePaintPanel.Height)
                            {
                                if (answer.Text == imageElementName[7])
                                {
                                    eigthNamePaintPanel.BackColor = Color.Green;
                                    answer.Enabled = false;
                                    eigthNamePaintPanel.Controls.Add(answer);
                                    selectedPanel.Add(eigthNamePaintPanel);
                                }
                                else
                                {
                                    if (!selectedPanel.Contains(eigthNamePaintPanel))
                                    {
                                        eigthNamePaintPanel.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    if(selectedPanel.Count == restFiles)
                    {
                        moveTaskButton.Enabled = true;
                        ResultsForm resultsForm = new ResultsForm("task", 0, 0);
                        resultsForm.infoLabel.Text = "Результат";
                        resultsForm.quantityLabel.Visible = false;
                        resultsForm.resultLabel.Text = "Все верно! Вы молодцы!";
                        resultsForm.okButton.Click += OkButtonOnClick;
                        resultsForm.ShowDialog();
                    }
                }
            }
        }

        private void OkButtonOnClick(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm("task", 0, 0);
            resultsForm.Close();
        }

        private void NamePaintPanelOnDragDrop(object sender, DragEventArgs e)
        {
            Panel panel = (Panel)sender;
            Control control = e.Data.GetData(e.Data.GetFormats()[0]) as Control;

            if (control != null)
            {
                control.Location = panel.PointToClient(new Point(e.X, e.Y));
                panel.Controls.Add(control);
            }
        }

        private void ExitPictureBoxOnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void MaximizedPictureBoxOnClick(object sender, EventArgs e)
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void ReferencePictureBoxOnClick(object sender, EventArgs e)
        {
            Forms.ManualForm manualForm = new Forms.ManualForm();
            manualForm.Show();
        }

        private void NamePaintPanelOnDragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void NameElementLabelOnMouseDown(object sender, MouseEventArgs e)
        {
            moveTaskButton.Enabled = false;
            mPoint = new Point(e.X, e.Y);
            Label label = (Label)sender;

            if (e.Button == MouseButtons.Left)
            {
                deltaX = Cursor.Position.X - label.Location.X; //Запоминаем значения дельта
                deltaY = Cursor.Position.Y - label.Location.Y;
            }
        }

        private void PaintTaskButtonOnClick(object sender, EventArgs e)
        {
            taskTabControl.SelectedTab = secondTaskTabPage;

            imageCompositionName = new List<string>();
            compositionImageList = new List<Image>();
            int restWithoutFiles = 3;

            DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + "/" + painting + "/Дорисовать композиции/");

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                compositionImageList.Add(Image.FromFile(file.FullName));
                imageCompositionName.Add(file.Name.Remove(file.Name.LastIndexOf('.')));
            }
            if (directoryInfo.GetFiles().Length < 3)
            {
                restWithoutFiles -= directoryInfo.GetFiles().Length;
                while (restWithoutFiles > 0)
                {
                    elementsImagesList.Add(null);
                    imageElementName.Add(null);
                    restWithoutFiles--;
                }
            }
            firstPaintPictureBox.Image = compositionImageList[0] == null ? Properties.Resources.Нет_фото : compositionImageList[0];
            nameFirstPictureLabel.Text = imageCompositionName[0] == null ? "" : imageCompositionName[0];
            secondPaintPictureBox.Image = compositionImageList[1] == null ? Properties.Resources.Нет_фото : compositionImageList[1];
            nameSecondPictureLabel.Text = imageCompositionName[1] == null ? "" : imageCompositionName[1];
            thirdPaintPictureBox.Image = compositionImageList[2] == null ? Properties.Resources.Нет_фото : compositionImageList[2];
            nameThirdPictureLabel.Text = imageCompositionName[2] == null ? "" : imageCompositionName[2];

        }
        private void TasksFormOnMouseMove(object sender, MouseEventArgs e)
        {
            //если пользователь передвигает форму левой клавишей мыши
            if (e.Button == MouseButtons.Left)
            {

                //изменение местоположения формы
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void TasksFormOnMouseDown(object sender, MouseEventArgs e)
        {
            //инициализация класса с заданием координат формы
            mPoint = new Point(e.X, e.Y);
        }
    }
}
