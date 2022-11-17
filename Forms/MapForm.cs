using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WoodPainting2
{
    public partial class MapForm : WoodPainting2.StyleForm
    {
        private Point mPoint;
        private List<Point> flags = new List<Point>();
        private List<PictureBox> flagBoxes = new List<PictureBox>();
        private Size mapSize;

        public MapForm()
        {
            InitializeComponent();
            nameLabel.Text = "Электронное пособие \"Северная роспись по дереву\"";

            flagBoxes = new List<PictureBox>()
            {
                krasnoborskPictureBox,
                mezenPictureBox,
                onegaPictureBox,
                pigemskyPictureBox,
                shenkurskPictureBox,
                verhnetoemskyPictureBox,
                vinogradovskyPictureBox,
            };

            mapSize = new Size(
                backgroundPictureBox.Image.Width * backgroundPictureBox.Height / backgroundPictureBox.Image.Height,
                backgroundPictureBox.Height);
            int a = (backgroundPictureBox.Width - mapSize.Width) / 2;

            for (int i = 0; i < flagBoxes.Count; i++)
            {
                flags.Add(new Point(flagBoxes[i].Location.X - a, flagBoxes[i].Location.Y));
            }            
        }

        private void ShenkurskPictureBoxOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = "Шенкурская роспись";
            Properties.Settings.Default.Save();
            //отображение теории для Шенкурского района
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
        }

        private void PigemskyPictureBoxOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = "Пижемская роспись";
            Properties.Settings.Default.Save();
            //отображение теории для Пижемской росписи
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
        }

        private void MezenPictureBoxOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = "Мезенская роспись";
            Properties.Settings.Default.Save();
            //отображение теории для Мезенского района
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
        }

        private void OnegaPictureBoxOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = "Онежская роспись";
            Properties.Settings.Default.Save();
            //отображение теории для Онежского района
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
        }

        private void KargopolPictureBoxOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = "Каргопольская роспись";
            Properties.Settings.Default.Save();
            //отображение теории для Каргопольского района
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
        }

        private void KrasnoborskPictureBoxOnClick(object sender, EventArgs e)
        {
            //отображение теории для Красноборского района
            MessageForm messageForm = new MessageForm("Пермогорская роспись", "Уфтюжская роспись", "Ракульская роспись");
            messageForm.Show();
        }

        private void VerhnetoemskyPictureBoxOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = "Пучужская роспись";
            Properties.Settings.Default.Save();
            //переход к выбору росписи Виноградовского района
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
        }


        private void VinogradovskyPictureBoxOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.namePaint = "Борецкая роспись";
            Properties.Settings.Default.Save();
            //отображение теории для Виноградовского района
            TheoryForm theoryForm = new TheoryForm();
            theoryForm.Show();
        }

        private void AboutBoxLabelOnClick(object sender, EventArgs e)
        {
            //переход к форме "О программе"
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void MainFormOnMouseMove(object sender, MouseEventArgs e)
        {
            //если пользователь передвигает форму левой клавишей мыши
            if (e.Button == MouseButtons.Left)
            {
                //изменение местоположения формы
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void MainFormOnMouseDown(object sender, MouseEventArgs e)
        {
            //инициализация класса с заданием координат формы
            mPoint = new Point(e.X, e.Y);
        }

        private void MapFormOnLoad(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Hide();
        }

        private void AboutPictureBoxOnClick(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void ReferencePictureBoxOnClick(object sender, EventArgs e)
        {
            Forms.ManualForm manualForm = new Forms.ManualForm();
            manualForm.Show();
        }

        private void MapFormResize(object sender, EventArgs e)
        {
            Size size = new Size(
                backgroundPictureBox.Image.Width * backgroundPictureBox.Height / backgroundPictureBox.Image.Height,
                backgroundPictureBox.Height);
            int a = (backgroundPictureBox.Width - size.Width) / 2;

            for (int i = 0; i < flagBoxes.Count; i++)
            {
                int x = flags[i].X * size.Width / mapSize.Width + a;
                int y = flags[i].Y * size.Height / mapSize.Height;
                flagBoxes[i].Location = new Point(x, y);
            }
        }
    }
}
