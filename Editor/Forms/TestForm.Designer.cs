namespace Editor.Forms
{
    partial class TestForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveTest = new System.Windows.Forms.SaveFileDialog();
            this.panelTaskStart = new System.Windows.Forms.Panel();
            this.TestCreatorPanel = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.InsertTextButton = new System.Windows.Forms.Button();
            this.InsertImageButton = new System.Windows.Forms.Button();
            this.InsertAnswerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HideLabelButton = new System.Windows.Forms.Button();
            this.groupBoxShowTBLabels = new System.Windows.Forms.GroupBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.TaskListPanel = new System.Windows.Forms.Panel();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.panelTaskStart.SuspendLayout();
            this.groupBoxShowTBLabels.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.TaskListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTaskStart
            // 
            this.panelTaskStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTaskStart.Controls.Add(this.TestCreatorPanel);
            this.panelTaskStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaskStart.Location = new System.Drawing.Point(165, 0);
            this.panelTaskStart.Margin = new System.Windows.Forms.Padding(10);
            this.panelTaskStart.Name = "panelTaskStart";
            this.panelTaskStart.Padding = new System.Windows.Forms.Padding(5);
            this.panelTaskStart.Size = new System.Drawing.Size(1014, 642);
            this.panelTaskStart.TabIndex = 10;
            // 
            // TestCreatorPanel
            // 
            this.TestCreatorPanel.AutoScroll = true;
            this.TestCreatorPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TestCreatorPanel.Location = new System.Drawing.Point(5, 5);
            this.TestCreatorPanel.Name = "TestCreatorPanel";
            this.TestCreatorPanel.Size = new System.Drawing.Size(1001, 634);
            this.TestCreatorPanel.TabIndex = 1;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.White;
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(165, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(1014, 642);
            this.panelMiddle.TabIndex = 11;
            // 
            // InsertTextButton
            // 
            this.InsertTextButton.FlatAppearance.BorderSize = 2;
            this.InsertTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertTextButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.InsertTextButton.ForeColor = System.Drawing.Color.Black;
            this.InsertTextButton.Location = new System.Drawing.Point(3, 12);
            this.InsertTextButton.Name = "InsertTextButton";
            this.InsertTextButton.Size = new System.Drawing.Size(139, 75);
            this.InsertTextButton.TabIndex = 2;
            this.InsertTextButton.Text = "Вставить текст задания";
            this.InsertTextButton.UseVisualStyleBackColor = true;
            this.InsertTextButton.Click += new System.EventHandler(this.InsertTextButton_Click);
            // 
            // InsertImageButton
            // 
            this.InsertImageButton.FlatAppearance.BorderSize = 2;
            this.InsertImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertImageButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.InsertImageButton.ForeColor = System.Drawing.Color.Black;
            this.InsertImageButton.Location = new System.Drawing.Point(3, 93);
            this.InsertImageButton.Name = "InsertImageButton";
            this.InsertImageButton.Size = new System.Drawing.Size(139, 75);
            this.InsertImageButton.TabIndex = 1;
            this.InsertImageButton.Text = "Добавить изображение";
            this.InsertImageButton.UseVisualStyleBackColor = true;
            this.InsertImageButton.Click += new System.EventHandler(this.InsertImageButton_Click);
            // 
            // InsertAnswerButton
            // 
            this.InsertAnswerButton.FlatAppearance.BorderSize = 2;
            this.InsertAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertAnswerButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.InsertAnswerButton.ForeColor = System.Drawing.Color.Black;
            this.InsertAnswerButton.Location = new System.Drawing.Point(3, 174);
            this.InsertAnswerButton.Name = "InsertAnswerButton";
            this.InsertAnswerButton.Size = new System.Drawing.Size(139, 75);
            this.InsertAnswerButton.TabIndex = 0;
            this.InsertAnswerButton.Text = "Вставить поле для ответа";
            this.InsertAnswerButton.UseVisualStyleBackColor = true;
            this.InsertAnswerButton.Click += new System.EventHandler(this.InsertAnswerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номера ответов";
            // 
            // HideLabelButton
            // 
            this.HideLabelButton.BackColor = System.Drawing.Color.LightBlue;
            this.HideLabelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideLabelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.HideLabelButton.Location = new System.Drawing.Point(7, 40);
            this.HideLabelButton.Name = "HideLabelButton";
            this.HideLabelButton.Size = new System.Drawing.Size(120, 64);
            this.HideLabelButton.TabIndex = 0;
            this.HideLabelButton.Text = "Сделать невидимыми";
            this.HideLabelButton.UseVisualStyleBackColor = false;
            this.HideLabelButton.Click += new System.EventHandler(this.HideLabelButton_Click);
            // 
            // groupBoxShowTBLabels
            // 
            this.groupBoxShowTBLabels.Controls.Add(this.label1);
            this.groupBoxShowTBLabels.Controls.Add(this.HideLabelButton);
            this.groupBoxShowTBLabels.Location = new System.Drawing.Point(6, 255);
            this.groupBoxShowTBLabels.Name = "groupBoxShowTBLabels";
            this.groupBoxShowTBLabels.Size = new System.Drawing.Size(136, 112);
            this.groupBoxShowTBLabels.TabIndex = 3;
            this.groupBoxShowTBLabels.TabStop = false;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlPanel.Controls.Add(this.SaveAndCloseButton);
            this.ControlPanel.Controls.Add(this.groupBoxShowTBLabels);
            this.ControlPanel.Controls.Add(this.InsertTextButton);
            this.ControlPanel.Controls.Add(this.InsertImageButton);
            this.ControlPanel.Controls.Add(this.InsertAnswerButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(1179, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(145, 642);
            this.ControlPanel.TabIndex = 8;
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateTaskButton.FlatAppearance.BorderSize = 2;
            this.CreateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CreateTaskButton.ForeColor = System.Drawing.Color.Black;
            this.CreateTaskButton.Location = new System.Drawing.Point(24, 12);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(116, 75);
            this.CreateTaskButton.TabIndex = 1;
            this.CreateTaskButton.Text = "Новое задание";
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // TaskListPanel
            // 
            this.TaskListPanel.AutoScroll = true;
            this.TaskListPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TaskListPanel.Controls.Add(this.CreateTaskButton);
            this.TaskListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TaskListPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskListPanel.Name = "TaskListPanel";
            this.TaskListPanel.Size = new System.Drawing.Size(165, 642);
            this.TaskListPanel.TabIndex = 9;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.SaveAndCloseButton.Location = new System.Drawing.Point(14, 561);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(119, 57);
            this.SaveAndCloseButton.TabIndex = 4;
            this.SaveAndCloseButton.Text = "Сохранить и закрыть";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 642);
            this.Controls.Add(this.panelTaskStart);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.TaskListPanel);
            this.MaximumSize = new System.Drawing.Size(1340, 681);
            this.MinimumSize = new System.Drawing.Size(1340, 681);
            this.Name = "TestForm";
            this.Text = "Тест";
            this.panelTaskStart.ResumeLayout(false);
            this.groupBoxShowTBLabels.ResumeLayout(false);
            this.groupBoxShowTBLabels.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.TaskListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveTest;
        private System.Windows.Forms.Panel panelTaskStart;
        private System.Windows.Forms.Panel TestCreatorPanel;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Button InsertTextButton;
        private System.Windows.Forms.Button InsertImageButton;
        private System.Windows.Forms.Button InsertAnswerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HideLabelButton;
        private System.Windows.Forms.GroupBox groupBoxShowTBLabels;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Panel TaskListPanel;
        private System.Windows.Forms.Button SaveAndCloseButton;
    }
}