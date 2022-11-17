namespace WoodPainting2
{
    partial class PaintingForm
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
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.referencePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(63, 98);
            this.contentPanel.Size = new System.Drawing.Size(1496, 870);
            this.contentPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintingFormOnMouseDown);
            this.contentPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintingFormOnMouseMove);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.Location = new System.Drawing.Point(66, 49);
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
            this.exitPictureBox.Location = new System.Drawing.Point(1520, 42);
            this.exitPictureBox.Visible = false;
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.Location = new System.Drawing.Point(1475, 42);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Location = new System.Drawing.Point(1430, 42);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = global::WoodPainting2.Properties.Resources.free_icon_close_window_6583137;
            this.closePictureBox.Location = new System.Drawing.Point(1520, 42);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(39, 39);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 52;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.ClosePictureBoxOnClick);
            // 
            // referencePictureBox
            // 
            this.referencePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.referencePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.referencePictureBox.Image = global::WoodPainting2.Properties.Resources.premium_icon_question_3156235;
            this.referencePictureBox.Location = new System.Drawing.Point(1385, 42);
            this.referencePictureBox.Name = "referencePictureBox";
            this.referencePictureBox.Size = new System.Drawing.Size(39, 39);
            this.referencePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.referencePictureBox.TabIndex = 54;
            this.referencePictureBox.TabStop = false;
            this.referencePictureBox.Click += new System.EventHandler(this.ReferencePictureBoxOnClick);
            // 
            // PaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1617, 1013);
            this.Controls.Add(this.referencePictureBox);
            this.Controls.Add(this.closePictureBox);
            this.Name = "PaintingForm";
            this.Text = "Рисование";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintingFormOnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintingFormOnMouseMove);
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
            this.Controls.SetChildIndex(this.referencePictureBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox referencePictureBox;
    }
}
