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
    public partial class StyleForm : Form
    {
        public StyleForm()
        {
            InitializeComponent();
        }

        private void TaskPictureBoxOnClick(object sender, EventArgs e)
        {
            TasksForm form3 = new TasksForm();
            form3.Show();
        }

        private void PaintPictureBoxOnClick(object sender, EventArgs e)
        {
            PaintingForm containerForPaintForm = new PaintingForm();
            containerForPaintForm.Show();
        }

        private void TestPictureBoxOnClick(object sender, EventArgs e)
        {
            this.Visible = false;
            QuestionForm questionsForm = new QuestionForm();
            questionsForm.ShowDialog();
            Close();
            //this.Visible = true;
        }

        private void MinimizePictureBoxOnClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizePictureBoxOnClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void ExitPictureBoxOnClick(object sender, EventArgs e)
        {
            //закрытие приложения
            var exit = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BackPictureBoxOnClick(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm();    
            mapForm.Show();
            Close();
        }
    }
}
