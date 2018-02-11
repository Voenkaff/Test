namespace Client.Forms
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel = new System.Windows.Forms.Panel();
            this.ChoiceSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.ChoiceSubjectLabel = new System.Windows.Forms.Label();
            this.ChoiceStudentComboBox = new System.Windows.Forms.ComboBox();
            this.ChoicePlatoonComboBox = new System.Windows.Forms.ComboBox();
            this.ChoiceTestComboBox = new System.Windows.Forms.ComboBox();
            this.ChoiceStudentLabel = new System.Windows.Forms.Label();
            this.ChoicePlatoonLabel = new System.Windows.Forms.Label();
            this.ChoiceTestLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowInstractionButton = new System.Windows.Forms.Button();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.SelectModeGroupBox = new System.Windows.Forms.GroupBox();
            this.TrainingModeRadioButton = new System.Windows.Forms.RadioButton();
            this.TestingModeRadioButton = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuStrip.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SelectModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.UpdateTestsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(796, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingToolStripMenuItem.Text = "Настройки";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // UpdateTestsToolStripMenuItem
            // 
            this.UpdateTestsToolStripMenuItem.Name = "UpdateTestsToolStripMenuItem";
            this.UpdateTestsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.UpdateTestsToolStripMenuItem.Text = "Обновить тесты";
            this.UpdateTestsToolStripMenuItem.Click += new System.EventHandler(this.UpdateTestsToolStripMenuItem_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.ChoiceSubjectComboBox);
            this.Panel.Controls.Add(this.ChoiceSubjectLabel);
            this.Panel.Controls.Add(this.ChoiceStudentComboBox);
            this.Panel.Controls.Add(this.ChoicePlatoonComboBox);
            this.Panel.Controls.Add(this.ChoiceTestComboBox);
            this.Panel.Controls.Add(this.ChoiceStudentLabel);
            this.Panel.Controls.Add(this.ChoicePlatoonLabel);
            this.Panel.Controls.Add(this.ChoiceTestLabel);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.ShowInstractionButton);
            this.Panel.Controls.Add(this.StartTestButton);
            this.Panel.Controls.Add(this.SelectModeGroupBox);
            this.Panel.Location = new System.Drawing.Point(13, 37);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(771, 330);
            this.Panel.TabIndex = 1;
            // 
            // ChoiceSubjectComboBox
            // 
            this.ChoiceSubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceSubjectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceSubjectComboBox.FormattingEnabled = true;
            this.ChoiceSubjectComboBox.Location = new System.Drawing.Point(15, 104);
            this.ChoiceSubjectComboBox.Name = "ChoiceSubjectComboBox";
            this.ChoiceSubjectComboBox.Size = new System.Drawing.Size(180, 21);
            this.ChoiceSubjectComboBox.TabIndex = 22;
            // 
            // ChoiceSubjectLabel
            // 
            this.ChoiceSubjectLabel.AutoSize = true;
            this.ChoiceSubjectLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ChoiceSubjectLabel.Location = new System.Drawing.Point(32, 81);
            this.ChoiceSubjectLabel.Name = "ChoiceSubjectLabel";
            this.ChoiceSubjectLabel.Size = new System.Drawing.Size(154, 20);
            this.ChoiceSubjectLabel.TabIndex = 23;
            this.ChoiceSubjectLabel.Text = "Выберите предмет";
            // 
            // ChoiceStudentComboBox
            // 
            this.ChoiceStudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceStudentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceStudentComboBox.FormattingEnabled = true;
            this.ChoiceStudentComboBox.Location = new System.Drawing.Point(575, 104);
            this.ChoiceStudentComboBox.Name = "ChoiceStudentComboBox";
            this.ChoiceStudentComboBox.Size = new System.Drawing.Size(180, 21);
            this.ChoiceStudentComboBox.TabIndex = 17;
            // 
            // ChoicePlatoonComboBox
            // 
            this.ChoicePlatoonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoicePlatoonComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoicePlatoonComboBox.FormattingEnabled = true;
            this.ChoicePlatoonComboBox.Location = new System.Drawing.Point(389, 104);
            this.ChoicePlatoonComboBox.Name = "ChoicePlatoonComboBox";
            this.ChoicePlatoonComboBox.Size = new System.Drawing.Size(180, 21);
            this.ChoicePlatoonComboBox.TabIndex = 15;
            // 
            // ChoiceTestComboBox
            // 
            this.ChoiceTestComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChoiceTestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceTestComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceTestComboBox.FormattingEnabled = true;
            this.ChoiceTestComboBox.Location = new System.Drawing.Point(203, 104);
            this.ChoiceTestComboBox.Name = "ChoiceTestComboBox";
            this.ChoiceTestComboBox.Size = new System.Drawing.Size(180, 21);
            this.ChoiceTestComboBox.TabIndex = 13;
            // 
            // ChoiceStudentLabel
            // 
            this.ChoiceStudentLabel.AutoSize = true;
            this.ChoiceStudentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ChoiceStudentLabel.Location = new System.Drawing.Point(580, 81);
            this.ChoiceStudentLabel.Name = "ChoiceStudentLabel";
            this.ChoiceStudentLabel.Size = new System.Drawing.Size(155, 20);
            this.ChoiceStudentLabel.TabIndex = 18;
            this.ChoiceStudentLabel.Text = "Выберите студента";
            // 
            // ChoicePlatoonLabel
            // 
            this.ChoicePlatoonLabel.AutoSize = true;
            this.ChoicePlatoonLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ChoicePlatoonLabel.Location = new System.Drawing.Point(415, 81);
            this.ChoicePlatoonLabel.Name = "ChoicePlatoonLabel";
            this.ChoicePlatoonLabel.Size = new System.Drawing.Size(126, 20);
            this.ChoicePlatoonLabel.TabIndex = 16;
            this.ChoicePlatoonLabel.Text = "Выберите взвод";
            // 
            // ChoiceTestLabel
            // 
            this.ChoiceTestLabel.AutoSize = true;
            this.ChoiceTestLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ChoiceTestLabel.Location = new System.Drawing.Point(233, 81);
            this.ChoiceTestLabel.Name = "ChoiceTestLabel";
            this.ChoiceTestLabel.Size = new System.Drawing.Size(119, 20);
            this.ChoiceTestLabel.TabIndex = 14;
            this.ChoiceTestLabel.Text = "Выберите тест";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Тестирование знаний";
            // 
            // ShowInstractionButton
            // 
            this.ShowInstractionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowInstractionButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ShowInstractionButton.Location = new System.Drawing.Point(328, 271);
            this.ShowInstractionButton.Name = "ShowInstractionButton";
            this.ShowInstractionButton.Size = new System.Drawing.Size(124, 38);
            this.ShowInstractionButton.TabIndex = 21;
            this.ShowInstractionButton.Text = "Инструкция";
            this.ShowInstractionButton.UseVisualStyleBackColor = true;
            this.ShowInstractionButton.Click += new System.EventHandler(this.ShowInstractionButton_Click);
            // 
            // StartTestButton
            // 
            this.StartTestButton.Enabled = false;
            this.StartTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTestButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.StartTestButton.Location = new System.Drawing.Point(307, 220);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(162, 45);
            this.StartTestButton.TabIndex = 20;
            this.StartTestButton.Text = "Начать тест";
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // SelectModeGroupBox
            // 
            this.SelectModeGroupBox.Controls.Add(this.TrainingModeRadioButton);
            this.SelectModeGroupBox.Controls.Add(this.TestingModeRadioButton);
            this.SelectModeGroupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.SelectModeGroupBox.Location = new System.Drawing.Point(258, 132);
            this.SelectModeGroupBox.Name = "SelectModeGroupBox";
            this.SelectModeGroupBox.Size = new System.Drawing.Size(250, 82);
            this.SelectModeGroupBox.TabIndex = 19;
            this.SelectModeGroupBox.TabStop = false;
            // 
            // TrainingModeRadioButton
            // 
            this.TrainingModeRadioButton.AutoSize = true;
            this.TrainingModeRadioButton.Checked = true;
            this.TrainingModeRadioButton.Location = new System.Drawing.Point(41, 22);
            this.TrainingModeRadioButton.Name = "TrainingModeRadioButton";
            this.TrainingModeRadioButton.Size = new System.Drawing.Size(153, 24);
            this.TrainingModeRadioButton.TabIndex = 1;
            this.TrainingModeRadioButton.TabStop = true;
            this.TrainingModeRadioButton.Text = "Режим обучения";
            this.TrainingModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // TestingModeRadioButton
            // 
            this.TestingModeRadioButton.AutoSize = true;
            this.TestingModeRadioButton.Location = new System.Drawing.Point(41, 52);
            this.TestingModeRadioButton.Name = "TestingModeRadioButton";
            this.TestingModeRadioButton.Size = new System.Drawing.Size(186, 24);
            this.TestingModeRadioButton.TabIndex = 0;
            this.TestingModeRadioButton.Text = "Режим тестирования";
            this.TestingModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 379);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.SelectModeGroupBox.ResumeLayout(false);
            this.SelectModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ComboBox ChoiceSubjectComboBox;
        private System.Windows.Forms.Label ChoiceSubjectLabel;
        private System.Windows.Forms.ComboBox ChoiceStudentComboBox;
        private System.Windows.Forms.ComboBox ChoicePlatoonComboBox;
        private System.Windows.Forms.ComboBox ChoiceTestComboBox;
        private System.Windows.Forms.Label ChoiceStudentLabel;
        private System.Windows.Forms.Label ChoicePlatoonLabel;
        private System.Windows.Forms.Label ChoiceTestLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowInstractionButton;
        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.GroupBox SelectModeGroupBox;
        private System.Windows.Forms.RadioButton TrainingModeRadioButton;
        private System.Windows.Forms.RadioButton TestingModeRadioButton;
        private System.Windows.Forms.ToolStripMenuItem UpdateTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}