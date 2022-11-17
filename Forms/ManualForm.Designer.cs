namespace WoodPainting2.Forms
{
    partial class ManualForm
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
            this.tasksButton = new System.Windows.Forms.Button();
            this.theoryButton = new System.Windows.Forms.Button();
            this.questionsButton = new System.Windows.Forms.Button();
            this.mapButton = new System.Windows.Forms.Button();
            this.informationWebBrowser = new System.Windows.Forms.WebBrowser();
            this.paintingButton = new System.Windows.Forms.Button();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.paintingButton);
            this.contentPanel.Controls.Add(this.tasksButton);
            this.contentPanel.Controls.Add(this.mapButton);
            this.contentPanel.Controls.Add(this.theoryButton);
            this.contentPanel.Controls.Add(this.informationWebBrowser);
            this.contentPanel.Controls.Add(this.questionsButton);
            this.contentPanel.Size = new System.Drawing.Size(1256, 699);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(515, 48);
            // 
            // backPictureBox
            // 
            this.backPictureBox.Visible = false;
            // 
            // taskPictureBox
            // 
            this.taskPictureBox.Visible = false;
            // 
            // paintPictureBox
            // 
            this.paintPictureBox.Visible = false;
            // 
            // testPictureBox
            // 
            this.testPictureBox.Visible = false;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Visible = false;
            // 
            // tasksButton
            // 
            this.tasksButton.BackColor = System.Drawing.Color.White;
            this.tasksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasksButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasksButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.tasksButton.Location = new System.Drawing.Point(3, 292);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(135, 78);
            this.tasksButton.TabIndex = 55;
            this.tasksButton.Text = "Упражнения";
            this.tasksButton.UseVisualStyleBackColor = false;
            this.tasksButton.Click += new System.EventHandler(this.TasksButtonOnClick);
            // 
            // theoryButton
            // 
            this.theoryButton.BackColor = System.Drawing.Color.White;
            this.theoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.theoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theoryButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.theoryButton.Location = new System.Drawing.Point(3, 95);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(135, 82);
            this.theoryButton.TabIndex = 54;
            this.theoryButton.Text = "Изучение теории";
            this.theoryButton.UseVisualStyleBackColor = false;
            this.theoryButton.Click += new System.EventHandler(this.TheoryButtonOnClick);
            // 
            // questionsButton
            // 
            this.questionsButton.BackColor = System.Drawing.Color.White;
            this.questionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionsButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionsButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.questionsButton.Location = new System.Drawing.Point(3, 193);
            this.questionsButton.Name = "questionsButton";
            this.questionsButton.Size = new System.Drawing.Size(135, 80);
            this.questionsButton.TabIndex = 53;
            this.questionsButton.Text = "Тестирование";
            this.questionsButton.UseVisualStyleBackColor = false;
            this.questionsButton.Click += new System.EventHandler(this.QuestionsButtonOnClick);
            // 
            // mapButton
            // 
            this.mapButton.BackColor = System.Drawing.Color.White;
            this.mapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.mapButton.Location = new System.Drawing.Point(3, 3);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(135, 77);
            this.mapButton.TabIndex = 52;
            this.mapButton.Text = "Выбор темы";
            this.mapButton.UseVisualStyleBackColor = false;
            this.mapButton.Click += new System.EventHandler(this.MapButtonOnClick);
            // 
            // informationWebBrowser
            // 
            this.informationWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationWebBrowser.Location = new System.Drawing.Point(144, 3);
            this.informationWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.informationWebBrowser.Name = "informationWebBrowser";
            this.informationWebBrowser.Size = new System.Drawing.Size(1099, 680);
            this.informationWebBrowser.TabIndex = 51;
            // 
            // paintingButton
            // 
            this.paintingButton.BackColor = System.Drawing.Color.White;
            this.paintingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paintingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paintingButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paintingButton.Image = global::WoodPainting2.Properties.Resources.g8635;
            this.paintingButton.Location = new System.Drawing.Point(3, 388);
            this.paintingButton.Name = "paintingButton";
            this.paintingButton.Size = new System.Drawing.Size(135, 78);
            this.paintingButton.TabIndex = 56;
            this.paintingButton.Text = "Графический редактор";
            this.paintingButton.UseVisualStyleBackColor = false;
            this.paintingButton.Click += new System.EventHandler(this.PaintingButtonOnClick);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = global::WoodPainting2.Properties.Resources.free_icon_close_window_6583137;
            this.closePictureBox.Location = new System.Drawing.Point(1252, 42);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(39, 39);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 51;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.ClosePictureBoxOnClick);
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1349, 839);
            this.Controls.Add(this.closePictureBox);
            this.Name = "ManualForm";
            this.Text = "Руководство пользователя";
            this.Load += new System.EventHandler(this.ManualFormOnLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManuaFormOnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ManualFormOnMouseMove);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.minimizePictureBox, 0);
            this.Controls.SetChildIndex(this.maximizePictureBox, 0);
            this.Controls.SetChildIndex(this.exitPictureBox, 0);
            this.Controls.SetChildIndex(this.testPictureBox, 0);
            this.Controls.SetChildIndex(this.paintPictureBox, 0);
            this.Controls.SetChildIndex(this.taskPictureBox, 0);
            this.Controls.SetChildIndex(this.backPictureBox, 0);
            this.Controls.SetChildIndex(this.contentPanel, 0);
            this.Controls.SetChildIndex(this.closePictureBox, 0);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.Button theoryButton;
        private System.Windows.Forms.WebBrowser informationWebBrowser;
        private System.Windows.Forms.Button questionsButton;
        private System.Windows.Forms.Button paintingButton;
        protected System.Windows.Forms.PictureBox closePictureBox;
    }
}
