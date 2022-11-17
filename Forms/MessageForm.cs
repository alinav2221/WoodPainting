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
    public partial class MessageForm : Form
    {
        public MessageForm(string first = "", string second = "", string third = "")
        {
            InitializeComponent();
            //задание текста кнопкам
            firstButton.Text = first;
            secondButton.Text = second;
            thirdButton.Text = third;
            if (second == "") secondButton.Visible = false;
            questionLabel.Text = "В этом районе зародились несколько росписей.\nВыберите одну из них.";
        }

        private void FirstButtonOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = firstButton.Text;
            Properties.Settings.Default.Save();
            //отображение формы с теорией о выбранной росписи
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
            this.Close();
        }

        private void SecondButtonOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = secondButton.Text;
            Properties.Settings.Default.Save();
            ////отображение формы с теорией о выбранной росписи
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
            this.Close();
        }

        private void ThirdButtonOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = thirdButton.Text;
            Properties.Settings.Default.Save();
            //отображение формы с теорией о выбранной росписи
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
            this.Close();
        }

        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            //закрытие формы
            this.Close();
        }
    }
}
