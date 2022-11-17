using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace WoodPainting2
{
    public partial class PaintingForm : WoodPainting2.StyleForm
    {
        private Point mPoint;

        public PaintingForm()
        {
            InitializeComponent();
            nameLabel.Text = "Графический редактор";
            ElementHost elementHost = new ElementHost();
            elementHost.Dock = DockStyle.Fill;
            PaintOnWPF paintOnWPF = new PaintOnWPF();
            elementHost.Child = paintOnWPF;
            contentPanel.Controls.Add(elementHost);
        }

        private void ClosePictureBoxOnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ReferencePictureBoxOnClick(object sender, EventArgs e)
        {
            Forms.ManualForm manualForm = new Forms.ManualForm();
            manualForm.Show();
        }
        private void PaintingFormOnMouseMove(object sender, MouseEventArgs e)
        {
            //если пользователь передвигает форму левой клавишей мыши
            if (e.Button == MouseButtons.Left)
            {

                //изменение местоположения формы
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void PaintingFormOnMouseDown(object sender, MouseEventArgs e)
        {
            //инициализация класса с заданием координат формы
            mPoint = new Point(e.X, e.Y);
        }
    }
}
