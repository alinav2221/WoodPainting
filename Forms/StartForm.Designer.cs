
namespace WoodPainting2
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.startWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.loadTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.startWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // startWindowsMediaPlayer
            // 
            this.startWindowsMediaPlayer.Enabled = true;
            this.startWindowsMediaPlayer.Location = new System.Drawing.Point(0, -2);
            this.startWindowsMediaPlayer.Name = "startWindowsMediaPlayer";
            this.startWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("startWindowsMediaPlayer.OcxState")));
            this.startWindowsMediaPlayer.Size = new System.Drawing.Size(607, 435);
            this.startWindowsMediaPlayer.TabIndex = 0;
            this.startWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.StartWindowsMediaPlayerOnPlayStateChange);
            // 
            // loadTimer
            // 
            this.loadTimer.Tick += new System.EventHandler(this.LoadTimerOnTick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 430);
            this.Controls.Add(this.startWindowsMediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartFormOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.startWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer startWindowsMediaPlayer;
        private System.Windows.Forms.Timer loadTimer;
    }
}