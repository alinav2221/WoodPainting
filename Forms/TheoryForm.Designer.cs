namespace WoodPainting2
{
    partial class TheoryForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.modernButton = new System.Windows.Forms.Button();
            this.mastersButton = new System.Windows.Forms.Button();
            this.compositionButton = new System.Windows.Forms.Button();
            this.synbolismButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.informationWebBrowser = new System.Windows.Forms.WebBrowser();
            this.referencePictureBox = new System.Windows.Forms.PictureBox();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.modernButton);
            this.contentPanel.Controls.Add(this.mastersButton);
            this.contentPanel.Controls.Add(this.compositionButton);
            this.contentPanel.Controls.Add(this.synbolismButton);
            this.contentPanel.Controls.Add(this.historyButton);
            this.contentPanel.Controls.Add(this.informationWebBrowser);
            this.contentPanel.Size = new System.Drawing.Size(1270, 665);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(500, 47);
            // 
            // backPictureBox
            // 
            this.backPictureBox.Location = new System.Drawing.Point(51, 48);
            // 
            // taskPictureBox
            // 
            this.taskPictureBox.Location = new System.Drawing.Point(213, 50);
            // 
            // paintPictureBox
            // 
            this.paintPictureBox.Location = new System.Drawing.Point(105, 50);
            // 
            // testPictureBox
            // 
            this.testPictureBox.Location = new System.Drawing.Point(159, 50);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Location = new System.Drawing.Point(1264, 48);
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.Location = new System.Drawing.Point(1219, 48);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Location = new System.Drawing.Point(1174, 48);
            // 
            // modernButton
            // 
            this.modernButton.BackColor = System.Drawing.Color.White;
            this.modernButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modernButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modernButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.modernButton.Location = new System.Drawing.Point(5, 425);
            this.modernButton.Name = "modernButton";
            this.modernButton.Size = new System.Drawing.Size(135, 78);
            this.modernButton.TabIndex = 39;
            this.modernButton.Text = "Применение сейчас";
            this.modernButton.UseVisualStyleBackColor = false;
            this.modernButton.Click += new System.EventHandler(this.ModernButtonOnClick);
            // 
            // mastersButton
            // 
            this.mastersButton.BackColor = System.Drawing.Color.White;
            this.mastersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mastersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mastersButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.mastersButton.Location = new System.Drawing.Point(5, 319);
            this.mastersButton.Name = "mastersButton";
            this.mastersButton.Size = new System.Drawing.Size(135, 82);
            this.mastersButton.TabIndex = 38;
            this.mastersButton.Text = "Мастера";
            this.mastersButton.UseVisualStyleBackColor = false;
            this.mastersButton.Click += new System.EventHandler(this.MasterLabelOnClick);
            // 
            // compositionButton
            // 
            this.compositionButton.BackColor = System.Drawing.Color.White;
            this.compositionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compositionButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compositionButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.compositionButton.Location = new System.Drawing.Point(5, 217);
            this.compositionButton.Name = "compositionButton";
            this.compositionButton.Size = new System.Drawing.Size(135, 80);
            this.compositionButton.TabIndex = 37;
            this.compositionButton.Text = "Композиции\r\nросписи";
            this.compositionButton.UseVisualStyleBackColor = false;
            this.compositionButton.Click += new System.EventHandler(this.CompositionButtonOnClick);
            // 
            // synbolismButton
            // 
            this.synbolismButton.BackColor = System.Drawing.Color.White;
            this.synbolismButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.synbolismButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.synbolismButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.synbolismButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.synbolismButton.Location = new System.Drawing.Point(5, 115);
            this.synbolismButton.Name = "synbolismButton";
            this.synbolismButton.Size = new System.Drawing.Size(135, 77);
            this.synbolismButton.TabIndex = 36;
            this.synbolismButton.Text = "Элементы\r\nросписи\r\n";
            this.synbolismButton.UseVisualStyleBackColor = false;
            this.synbolismButton.Click += new System.EventHandler(this.SymbolismLabelOnClick);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.White;
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.historyButton.Location = new System.Drawing.Point(5, 11);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(135, 82);
            this.historyButton.TabIndex = 35;
            this.historyButton.Text = "Зарождение\r\nросписи";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.HistoryLabelOnClick);
            // 
            // informationWebBrowser
            // 
            this.informationWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationWebBrowser.Location = new System.Drawing.Point(146, 11);
            this.informationWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.informationWebBrowser.Name = "informationWebBrowser";
            this.informationWebBrowser.Size = new System.Drawing.Size(1115, 647);
            this.informationWebBrowser.TabIndex = 34;
            this.informationWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.InformationWebBrowserOnDocumentCompleted);
            // 
            // referencePictureBox
            // 
            this.referencePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.referencePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.referencePictureBox.Image = global::WoodPainting2.Properties.Resources.premium_icon_question_3156235;
            this.referencePictureBox.Location = new System.Drawing.Point(1129, 48);
            this.referencePictureBox.Name = "referencePictureBox";
            this.referencePictureBox.Size = new System.Drawing.Size(39, 39);
            this.referencePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.referencePictureBox.TabIndex = 54;
            this.referencePictureBox.TabStop = false;
            this.referencePictureBox.Click += new System.EventHandler(this.ReferencePictureBoxOnClick);
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1363, 802);
            this.Controls.Add(this.referencePictureBox);
            this.Name = "TheoryForm";
            this.Text = "Теоретический материал";
            this.Load += new System.EventHandler(this.TheoryFormOnLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TheoryFormOnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TheoryFormOnMouseMove);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.minimizePictureBox, 0);
            this.Controls.SetChildIndex(this.maximizePictureBox, 0);
            this.Controls.SetChildIndex(this.exitPictureBox, 0);
            this.Controls.SetChildIndex(this.testPictureBox, 0);
            this.Controls.SetChildIndex(this.paintPictureBox, 0);
            this.Controls.SetChildIndex(this.taskPictureBox, 0);
            this.Controls.SetChildIndex(this.backPictureBox, 0);
            this.Controls.SetChildIndex(this.contentPanel, 0);
            this.Controls.SetChildIndex(this.referencePictureBox, 0);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modernButton;
        private System.Windows.Forms.Button mastersButton;
        private System.Windows.Forms.Button compositionButton;
        private System.Windows.Forms.Button synbolismButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.WebBrowser informationWebBrowser;
        private System.Windows.Forms.PictureBox referencePictureBox;
    }
}
