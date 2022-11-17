
namespace WoodPainting2
{
    partial class QuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.timeToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.answerGroupBox = new System.Windows.Forms.GroupBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.fourthCheckBox = new System.Windows.Forms.CheckBox();
            this.thirdCheckBox = new System.Windows.Forms.CheckBox();
            this.secondCheckBox = new System.Windows.Forms.CheckBox();
            this.firstCheckBox = new System.Windows.Forms.CheckBox();
            this.fourthRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdRadioButton = new System.Windows.Forms.RadioButton();
            this.secondRadioButton = new System.Windows.Forms.RadioButton();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.timeLabel = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.questionLabel = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.descriptionLabel = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.furtherButton = new System.Windows.Forms.Button();
            this.referencePictureBox = new System.Windows.Forms.PictureBox();
            this.timeProgressBar = new VisualPlus.Toolkit.Controls.DataVisualization.VisualProgressBar();
            this.answerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timeToolStripProgressBar
            // 
            this.timeToolStripProgressBar.Name = "timeToolStripProgressBar";
            this.timeToolStripProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // timeToolStripLabel
            // 
            this.timeToolStripLabel.Name = "timeToolStripLabel";
            this.timeToolStripLabel.Size = new System.Drawing.Size(111, 22);
            this.timeToolStripLabel.Text = "Оставшееся время";
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionNumberLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberLabel.Location = new System.Drawing.Point(52, 42);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(51, 16);
            this.questionNumberLabel.TabIndex = 2;
            this.questionNumberLabel.Text = "label2";
            this.questionNumberLabel.Visible = false;
            // 
            // answerGroupBox
            // 
            this.answerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.answerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.answerGroupBox.Controls.Add(this.answerTextBox);
            this.answerGroupBox.Controls.Add(this.fourthCheckBox);
            this.answerGroupBox.Controls.Add(this.thirdCheckBox);
            this.answerGroupBox.Controls.Add(this.secondCheckBox);
            this.answerGroupBox.Controls.Add(this.firstCheckBox);
            this.answerGroupBox.Controls.Add(this.fourthRadioButton);
            this.answerGroupBox.Controls.Add(this.thirdRadioButton);
            this.answerGroupBox.Controls.Add(this.secondRadioButton);
            this.answerGroupBox.Controls.Add(this.firstRadioButton);
            this.answerGroupBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerGroupBox.Location = new System.Drawing.Point(55, 209);
            this.answerGroupBox.Name = "answerGroupBox";
            this.answerGroupBox.Size = new System.Drawing.Size(850, 181);
            this.answerGroupBox.TabIndex = 5;
            this.answerGroupBox.TabStop = false;
            this.answerGroupBox.Text = "Варианты ответов";
            this.answerGroupBox.Visible = false;
            // 
            // answerTextBox
            // 
            this.answerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.answerTextBox.Location = new System.Drawing.Point(132, 90);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(493, 29);
            this.answerTextBox.TabIndex = 8;
            this.answerTextBox.TextChanged += new System.EventHandler(this.AnswerTextBoxOnTextChanged);
            // 
            // fourthCheckBox
            // 
            this.fourthCheckBox.AutoSize = true;
            this.fourthCheckBox.Location = new System.Drawing.Point(7, 134);
            this.fourthCheckBox.Name = "fourthCheckBox";
            this.fourthCheckBox.Size = new System.Drawing.Size(120, 27);
            this.fourthCheckBox.TabIndex = 7;
            this.fourthCheckBox.Text = "checkBox4";
            this.fourthCheckBox.UseVisualStyleBackColor = true;
            this.fourthCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBoxOnCheckedChanged);
            // 
            // thirdCheckBox
            // 
            this.thirdCheckBox.AutoSize = true;
            this.thirdCheckBox.Location = new System.Drawing.Point(7, 107);
            this.thirdCheckBox.Name = "thirdCheckBox";
            this.thirdCheckBox.Size = new System.Drawing.Size(119, 27);
            this.thirdCheckBox.TabIndex = 6;
            this.thirdCheckBox.Text = "checkBox3";
            this.thirdCheckBox.UseVisualStyleBackColor = true;
            this.thirdCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBoxOnCheckedChanged);
            // 
            // secondCheckBox
            // 
            this.secondCheckBox.AutoSize = true;
            this.secondCheckBox.Location = new System.Drawing.Point(7, 79);
            this.secondCheckBox.Name = "secondCheckBox";
            this.secondCheckBox.Size = new System.Drawing.Size(120, 27);
            this.secondCheckBox.TabIndex = 5;
            this.secondCheckBox.Text = "checkBox2";
            this.secondCheckBox.UseVisualStyleBackColor = true;
            this.secondCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBoxOnCheckedChanged);
            // 
            // firstCheckBox
            // 
            this.firstCheckBox.AutoSize = true;
            this.firstCheckBox.Location = new System.Drawing.Point(7, 50);
            this.firstCheckBox.Name = "firstCheckBox";
            this.firstCheckBox.Size = new System.Drawing.Size(117, 27);
            this.firstCheckBox.TabIndex = 4;
            this.firstCheckBox.Text = "checkBox1";
            this.firstCheckBox.UseVisualStyleBackColor = true;
            this.firstCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBoxOnCheckedChanged);
            // 
            // fourthRadioButton
            // 
            this.fourthRadioButton.AutoSize = true;
            this.fourthRadioButton.Location = new System.Drawing.Point(7, 134);
            this.fourthRadioButton.Name = "fourthRadioButton";
            this.fourthRadioButton.Size = new System.Drawing.Size(142, 27);
            this.fourthRadioButton.TabIndex = 3;
            this.fourthRadioButton.TabStop = true;
            this.fourthRadioButton.Text = "radioButton4";
            this.fourthRadioButton.UseVisualStyleBackColor = true;
            this.fourthRadioButton.CheckedChanged += new System.EventHandler(this.AnswerRadioButtonOnCheckedChanged);
            // 
            // thirdRadioButton
            // 
            this.thirdRadioButton.AutoSize = true;
            this.thirdRadioButton.Location = new System.Drawing.Point(7, 106);
            this.thirdRadioButton.Name = "thirdRadioButton";
            this.thirdRadioButton.Size = new System.Drawing.Size(141, 27);
            this.thirdRadioButton.TabIndex = 2;
            this.thirdRadioButton.TabStop = true;
            this.thirdRadioButton.Text = "radioButton3";
            this.thirdRadioButton.UseVisualStyleBackColor = true;
            this.thirdRadioButton.CheckedChanged += new System.EventHandler(this.AnswerRadioButtonOnCheckedChanged);
            // 
            // secondRadioButton
            // 
            this.secondRadioButton.AutoSize = true;
            this.secondRadioButton.Location = new System.Drawing.Point(7, 78);
            this.secondRadioButton.Name = "secondRadioButton";
            this.secondRadioButton.Size = new System.Drawing.Size(142, 27);
            this.secondRadioButton.TabIndex = 1;
            this.secondRadioButton.TabStop = true;
            this.secondRadioButton.Text = "radioButton2";
            this.secondRadioButton.UseVisualStyleBackColor = true;
            this.secondRadioButton.CheckedChanged += new System.EventHandler(this.AnswerRadioButtonOnCheckedChanged);
            // 
            // firstRadioButton
            // 
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.Location = new System.Drawing.Point(7, 50);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(139, 27);
            this.firstRadioButton.TabIndex = 0;
            this.firstRadioButton.TabStop = true;
            this.firstRadioButton.Text = "radioButton1";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            this.firstRadioButton.CheckedChanged += new System.EventHandler(this.AnswerRadioButtonOnCheckedChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.Location = new System.Drawing.Point(101, 496);
            this.timeLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.timeLabel.Outline = false;
            this.timeLabel.OutlineColor = System.Drawing.Color.Red;
            this.timeLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.timeLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.ReflectionSpacing = 0;
            this.timeLabel.ShadowColor = System.Drawing.Color.Black;
            this.timeLabel.ShadowDirection = 315;
            this.timeLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.timeLabel.ShadowOpacity = 100;
            this.timeLabel.Size = new System.Drawing.Size(147, 23);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Осталось времени:";
            this.timeLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            this.timeLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.timeLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.timeLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.timeLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.timeLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 1000;
            this.questionTimer.Tick += new System.EventHandler(this.QuestionTimerOnTick);
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionLabel.Location = new System.Drawing.Point(55, 81);
            this.questionLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.questionLabel.Outline = false;
            this.questionLabel.OutlineColor = System.Drawing.Color.Red;
            this.questionLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.questionLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionLabel.ReflectionSpacing = 0;
            this.questionLabel.ShadowColor = System.Drawing.Color.Black;
            this.questionLabel.ShadowDirection = 315;
            this.questionLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.questionLabel.ShadowOpacity = 100;
            this.questionLabel.Size = new System.Drawing.Size(850, 87);
            this.questionLabel.TabIndex = 9;
            this.questionLabel.Text = "visualLabel1";
            this.questionLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            this.questionLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.questionLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.questionLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.questionLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.questionLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.BackColor = System.Drawing.Color.White;
            this.descriptionLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.Location = new System.Drawing.Point(31, 63);
            this.descriptionLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.descriptionLabel.Outline = false;
            this.descriptionLabel.OutlineColor = System.Drawing.Color.Red;
            this.descriptionLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.descriptionLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.ReflectionSpacing = 0;
            this.descriptionLabel.ShadowColor = System.Drawing.Color.Black;
            this.descriptionLabel.ShadowDirection = 315;
            this.descriptionLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.descriptionLabel.ShadowOpacity = 100;
            this.descriptionLabel.Size = new System.Drawing.Size(906, 407);
            this.descriptionLabel.TabIndex = 22;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            this.descriptionLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.descriptionLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.descriptionLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.descriptionLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.descriptionLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.descriptionLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.descriptionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuestionFormOnMouseDown);
            this.descriptionLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QuestionFormOnMouseMove);
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.BackColor = System.Drawing.Color.White;
            this.remainingTimeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.remainingTimeLabel.Location = new System.Drawing.Point(297, 499);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(52, 16);
            this.remainingTimeLabel.TabIndex = 23;
            this.remainingTimeLabel.Text = "00:00";
            this.remainingTimeLabel.Visible = false;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPictureBox.Image = global::WoodPainting2.Properties.Resources.free_icon_close_window_6583137;
            this.exitPictureBox.Location = new System.Drawing.Point(892, 25);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(33, 33);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPictureBox.TabIndex = 40;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.ExitPictureBoxOnClick);
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.maximizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizePictureBox.Image = global::WoodPainting2.Properties.Resources.free_icon_expand_window_6583139;
            this.maximizePictureBox.Location = new System.Drawing.Point(853, 25);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Size = new System.Drawing.Size(33, 33);
            this.maximizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizePictureBox.TabIndex = 39;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Visible = false;
            this.maximizePictureBox.Click += new System.EventHandler(this.MaximizePictureBoxOnClick);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Image = global::WoodPainting2.Properties.Resources.icons8_свернуть_окно_64;
            this.minimizePictureBox.Location = new System.Drawing.Point(853, 25);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(33, 33);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizePictureBox.TabIndex = 38;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBoxOnClick);
            // 
            // furtherButton
            // 
            this.furtherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.furtherButton.BackgroundImage = global::WoodPainting2.Properties.Resources.g8635;
            this.furtherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.furtherButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.furtherButton.Location = new System.Drawing.Point(816, 475);
            this.furtherButton.Name = "furtherButton";
            this.furtherButton.Size = new System.Drawing.Size(121, 66);
            this.furtherButton.TabIndex = 41;
            this.furtherButton.Text = "Далее";
            this.furtherButton.UseVisualStyleBackColor = true;
            this.furtherButton.Click += new System.EventHandler(this.FurtherButtonOnClick);
            // 
            // referencePictureBox
            // 
            this.referencePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.referencePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.referencePictureBox.Image = global::WoodPainting2.Properties.Resources.premium_icon_question_3156235;
            this.referencePictureBox.Location = new System.Drawing.Point(808, 26);
            this.referencePictureBox.Name = "referencePictureBox";
            this.referencePictureBox.Size = new System.Drawing.Size(39, 32);
            this.referencePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.referencePictureBox.TabIndex = 54;
            this.referencePictureBox.TabStop = false;
            this.referencePictureBox.Click += new System.EventHandler(this.ReferencePictureBoxOnClick);
            // 
            // timeProgressBar
            // 
            this.timeProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeProgressBar.BackColorState.Disabled = System.Drawing.Color.White;
            this.timeProgressBar.BackColorState.Enabled = System.Drawing.Color.White;
            this.timeProgressBar.Border.Color = System.Drawing.Color.Black;
            this.timeProgressBar.Border.HoverColor = System.Drawing.Color.Red;
            this.timeProgressBar.Border.HoverVisible = true;
            this.timeProgressBar.Border.Rounding = 10;
            this.timeProgressBar.Border.Thickness = 1;
            this.timeProgressBar.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.timeProgressBar.Border.Visible = true;
            this.timeProgressBar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeProgressBar.Hatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeProgressBar.Hatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeProgressBar.Hatch.Size = new System.Drawing.Size(2, 2);
            this.timeProgressBar.Hatch.Style = System.Drawing.Drawing2D.HatchStyle.Divot;
            this.timeProgressBar.Hatch.Visible = true;
            this.timeProgressBar.LargeChange = 5;
            this.timeProgressBar.Location = new System.Drawing.Point(254, 496);
            this.timeProgressBar.MarqueeWidth = 20;
            this.timeProgressBar.Maximum = 100;
            this.timeProgressBar.Minimum = 0;
            this.timeProgressBar.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.timeProgressBar.Name = "timeProgressBar";
            this.timeProgressBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.timeProgressBar.ProgressColor = System.Drawing.Color.Lime;
            this.timeProgressBar.ProgressImage = null;
            this.timeProgressBar.Size = new System.Drawing.Size(137, 23);
            this.timeProgressBar.SmallChange = 10;
            this.timeProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.timeProgressBar.TabIndex = 8;
            this.timeProgressBar.Text = "visualProgressBar1";
            this.timeProgressBar.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.timeProgressBar.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeProgressBar.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeProgressBar.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeProgressBar.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.timeProgressBar.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.timeProgressBar.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.timeProgressBar.Value = 0;
            this.timeProgressBar.ValueAlignment = System.Drawing.StringAlignment.Center;
            this.timeProgressBar.Visible = false;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WoodPainting2.Properties.Resources.g2623;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 575);
            this.Controls.Add(this.referencePictureBox);
            this.Controls.Add(this.furtherButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.maximizePictureBox);
            this.Controls.Add(this.minimizePictureBox);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.remainingTimeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeProgressBar);
            this.Controls.Add(this.answerGroupBox);
            this.Controls.Add(this.questionLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.QuestionFormOnLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuestionFormOnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QuestionFormOnMouseMove);
            this.answerGroupBox.ResumeLayout(false);
            this.answerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripProgressBar timeToolStripProgressBar;
        private System.Windows.Forms.ToolStripLabel timeToolStripLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.GroupBox answerGroupBox;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel timeLabel;
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.RadioButton fourthRadioButton;
        private System.Windows.Forms.RadioButton thirdRadioButton;
        private System.Windows.Forms.RadioButton secondRadioButton;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.CheckBox fourthCheckBox;
        private System.Windows.Forms.CheckBox thirdCheckBox;
        private System.Windows.Forms.CheckBox secondCheckBox;
        private System.Windows.Forms.CheckBox firstCheckBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel questionLabel;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel descriptionLabel;
        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox maximizePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.Button furtherButton;
        private System.Windows.Forms.PictureBox referencePictureBox;
        private VisualPlus.Toolkit.Controls.DataVisualization.VisualProgressBar timeProgressBar;
    }
}