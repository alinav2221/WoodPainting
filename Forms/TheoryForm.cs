using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WoodPainting2
{
    public partial class TheoryForm : StyleForm
    {
        private Point mPoint;
        public string painting;
        public string section;
        public HtmlElementCollection htmlElements;
        public HtmlDocument htmlDocument;

        public TheoryForm()
        {
            InitializeComponent();
            painting = Properties.Settings.Default.namePaint;
        }

        public void Theory(string nameButton)
        {
            var documentText = Properties.Resources.ResourceManager.GetString(nameButton);
            var path = Environment.CurrentDirectory + $"\\{painting}\\images\\";
            Regex regex = new Regex("(img src\\s*=\\s*)\"?([а-яА-ЯёЁ0-9a-zA-Z-., ]+)[.](\\w+?)\\b\"?");

            documentText = regex.Replace(documentText, $"$1\"{path}$2.$3\"");

            informationWebBrowser.DocumentText = documentText;
            informationWebBrowser.ScrollBarsEnabled = true;
        }

        private void TheoryFormOnLoad(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[1];
            form.Close();

            Theory(painting + " История");
        }

        private void MasterLabelOnClick(object sender, EventArgs e)
        {
            Theory(painting + " Мастера");
        }

        private void SymbolismLabelOnClick(object sender, EventArgs e)
        {
            Theory(painting + " Элементы");
        }

        private void CompositionButtonOnClick(object sender, EventArgs e)
        {
            Theory(painting + " Композиции");
        }

        private void HistoryLabelOnClick(object sender, EventArgs e)
        {
            Theory(painting + " История");
        }

        private void ModernButtonOnClick(object sender, EventArgs e)
        {
            Theory(painting + " Сейчас");
        }

        private void InformationWebBrowserOnDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                //вывод названия росписи
                nameLabel.Text = painting;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TheoryFormOnMouseDown(object sender, MouseEventArgs e)
        {
            //установка координат формы
            mPoint = new Point(e.X, e.Y);
        }

        private void TheoryFormOnMouseMove(object sender, MouseEventArgs e)
        {
            //перемещение формы
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        private void ReferencePictureBoxOnClick(object sender, EventArgs e)
        {
            Forms.ManualForm manualForm = new Forms.ManualForm();
            manualForm.Show();
        }
    }
}
