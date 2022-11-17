using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodPainting2
{
    public partial class ResultsForm : Form
    {
        public int scr, countQustions;
        public string modeShow;
        public ResultsForm(string mode = "test", int score = 0, int countQuestion = 0)
        {
            InitializeComponent();
            scr = score;  //запись количества правильных ответов
            countQustions = countQuestion;
            modeShow = mode;
        }

        private void OkButtonOnClick(object sender, EventArgs e)
        {
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
            this.Close();
        }

        private void ResultsFormOnLoad(object sender, EventArgs e)
        {
            if (modeShow == "test")
            {
                int mark;
                quantityLabel.Text = "Количество правильных ответов: " + scr.ToString();
                scr = scr * 100 / countQustions; //формула расчета процента правильных ответов
                                                 //выставление оценки по заданным критериям оценивания
                if (scr <= 60)
                {
                    mark = 2;
                }
                else if (scr <= 75)
                {
                    mark = 3;
                }
                else if (scr <= 85)
                {
                    mark = 4;
                }
                else
                {
                    mark = 5;
                }
                resultLabel.Text = "Ваша оценка: " + mark.ToString();
            }
        }
    }
}
