namespace WoodPainting2
{
    partial class StyleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleForm));
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.taskPictureBox = new System.Windows.Forms.PictureBox();
            this.paintPictureBox = new System.Windows.Forms.PictureBox();
            this.testPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backPictureBox
            // 
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPictureBox.Image = global::WoodPainting2.Properties.Resources.icons8_стрелка__указывающая_влево_48;
            this.backPictureBox.Location = new System.Drawing.Point(46, 48);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(48, 44);
            this.backPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPictureBox.TabIndex = 49;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.BackPictureBoxOnClick);
            // 
            // taskPictureBox
            // 
            this.taskPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskPictureBox.Image = global::WoodPainting2.Properties.Resources.icons8_задача_64;
            this.taskPictureBox.Location = new System.Drawing.Point(154, 48);
            this.taskPictureBox.Name = "taskPictureBox";
            this.taskPictureBox.Size = new System.Drawing.Size(48, 44);
            this.taskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.taskPictureBox.TabIndex = 48;
            this.taskPictureBox.TabStop = false;
            this.taskPictureBox.Click += new System.EventHandler(this.TaskPictureBoxOnClick);
            // 
            // paintPictureBox
            // 
            this.paintPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paintPictureBox.Image = global::WoodPainting2.Properties.Resources.icons8_палитра_64;
            this.paintPictureBox.Location = new System.Drawing.Point(100, 48);
            this.paintPictureBox.Name = "paintPictureBox";
            this.paintPictureBox.Size = new System.Drawing.Size(48, 44);
            this.paintPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paintPictureBox.TabIndex = 47;
            this.paintPictureBox.TabStop = false;
            this.paintPictureBox.Click += new System.EventHandler(this.PaintPictureBoxOnClick);
            // 
            // testPictureBox
            // 
            this.testPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testPictureBox.Image = global::WoodPainting2.Properties.Resources.icons8_тест_частично_пройден_50;
            this.testPictureBox.Location = new System.Drawing.Point(208, 48);
            this.testPictureBox.Name = "testPictureBox";
            this.testPictureBox.Size = new System.Drawing.Size(48, 44);
            this.testPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.testPictureBox.TabIndex = 46;
            this.testPictureBox.TabStop = false;
            this.testPictureBox.Click += new System.EventHandler(this.TestPictureBoxOnClick);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPictureBox.Image = global::WoodPainting2.Properties.Resources.free_icon_close_window_6583137;
            this.exitPictureBox.Location = new System.Drawing.Point(1252, 42);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(39, 39);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPictureBox.TabIndex = 45;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.ExitPictureBoxOnClick);
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Image = global::WoodPainting2.Properties.Resources.free_icon_expand_window_6583139;
            this.maximizePictureBox.Location = new System.Drawing.Point(1207, 42);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Size = new System.Drawing.Size(39, 39);
            this.maximizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizePictureBox.TabIndex = 44;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Click += new System.EventHandler(this.MaximizePictureBoxOnClick);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Image = global::WoodPainting2.Properties.Resources.icons8_свернуть_окно_64;
            this.minimizePictureBox.Location = new System.Drawing.Point(1162, 42);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(39, 39);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizePictureBox.TabIndex = 43;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBoxOnClick);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(493, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(156, 43);
            this.nameLabel.TabIndex = 42;
            this.nameLabel.Text = "Роспись...";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentPanel.Location = new System.Drawing.Point(46, 98);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1265, 699);
            this.contentPanel.TabIndex = 50;
            // 
            // StyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(37)))));
            this.BackgroundImage = global::WoodPainting2.Properties.Resources.g2623;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 839);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.taskPictureBox);
            this.Controls.Add(this.paintPictureBox);
            this.Controls.Add(this.testPictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.maximizePictureBox);
            this.Controls.Add(this.minimizePictureBox);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StyleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel contentPanel;
        protected System.Windows.Forms.Label nameLabel;
        protected System.Windows.Forms.PictureBox backPictureBox;
        protected System.Windows.Forms.PictureBox taskPictureBox;
        protected System.Windows.Forms.PictureBox paintPictureBox;
        protected System.Windows.Forms.PictureBox testPictureBox;
        protected System.Windows.Forms.PictureBox exitPictureBox;
        protected System.Windows.Forms.PictureBox maximizePictureBox;
        protected System.Windows.Forms.PictureBox minimizePictureBox;
    }
}