using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WoodPainting2.Forms
{
    public partial class ManualForm : WoodPainting2.StyleForm
    {
        private Point mPoint;

        public ManualForm()
        {
            InitializeComponent();
        }

        public void Manual(string nameButton)
        {
            var documentText = Properties.Resources.ResourceManager.GetString(nameButton);
            var path = Environment.CurrentDirectory + "\\Руководство\\images\\";
            Regex regex = new Regex("(img src\\s*=\\s*)\"?(\\w+?)[.](\\w+?)\\b\"?");
            documentText = regex.Replace(documentText, $"$1\"{path}$2.$3\"");
            //MessageBox.Show(documentText);
            informationWebBrowser.DocumentText = documentText;
            informationWebBrowser.Visible = true;
            informationWebBrowser.ScrollBarsEnabled = true;
        }

        private void TheoryButtonOnClick(object sender, EventArgs e)
        {
            Manual("TheoryForm");
        }

        private void MapButtonOnClick(object sender, EventArgs e)
        {
            Manual("MapForm");
        }

        private void QuestionsButtonOnClick(object sender, EventArgs e)
        {
            Manual("QuestionsForm");
        }

        private void TasksButtonOnClick(object sender, EventArgs e)
        {
            Manual("TasksForm");
        }

        private void PaintingButtonOnClick(object sender, EventArgs e)
        {
            Manual("PaintingForm");
        }

        private void ClosePictureBoxOnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ManualFormOnLoad(object sender, EventArgs e)
        {
            nameLabel.Text = "Руководство пользователя";
        }

        private void ManualFormOnMouseMove(object sender, MouseEventArgs e)
        {
            //если пользователь передвигает форму левой клавишей мыши
            if (e.Button == MouseButtons.Left)
            {

                //изменение местоположения формы
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void ManuaFormOnMouseDown(object sender, MouseEventArgs e)
        {
            //инициализация класса с заданием координат формы
            mPoint = new Point(e.X, e.Y);
        }

    }
}
