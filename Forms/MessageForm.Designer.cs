
namespace WoodPainting2
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.questionLabel = new System.Windows.Forms.Label();
            this.firstButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.thirdButton = new System.Windows.Forms.Button();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(106, 89);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(58, 23);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstButton
            // 
            this.firstButton.BackColor = System.Drawing.Color.White;
            this.firstButton.BackgroundImage = global::WoodPainting2.Properties.Resources.g8635;
            this.firstButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.firstButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstButton.Location = new System.Drawing.Point(48, 163);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(229, 104);
            this.firstButton.TabIndex = 1;
            this.firstButton.Text = "button1";
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.FirstButtonOnClick);
            // 
            // secondButton
            // 
            this.secondButton.BackColor = System.Drawing.Color.White;
            this.secondButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondButton.BackgroundImage")));
            this.secondButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondButton.Location = new System.Drawing.Point(200, 284);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(229, 104);
            this.secondButton.TabIndex = 2;
            this.secondButton.Text = "button2";
            this.secondButton.UseVisualStyleBackColor = false;
            this.secondButton.Click += new System.EventHandler(this.SecondButtonOnClick);
            // 
            // thirdButton
            // 
            this.thirdButton.BackColor = System.Drawing.Color.White;
            this.thirdButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdButton.BackgroundImage")));
            this.thirdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thirdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thirdButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thirdButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdButton.Location = new System.Drawing.Point(350, 163);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(229, 104);
            this.thirdButton.TabIndex = 3;
            this.thirdButton.Text = "button3";
            this.thirdButton.UseVisualStyleBackColor = false;
            this.thirdButton.Click += new System.EventHandler(this.ThirdButtonOnClick);
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.closePictureBox.Image = global::WoodPainting2.Properties.Resources.free_icon_close_window_6583137;
            this.closePictureBox.Location = new System.Drawing.Point(575, 24);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(37, 35);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 5;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.CloseButtonOnClick);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WoodPainting2.Properties.Resources.g2623;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 416);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.thirdButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.questionLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button thirdButton;
        private System.Windows.Forms.PictureBox closePictureBox;
    }
}