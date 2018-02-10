namespace Editor.Forms
{
    partial class SubjectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SavedSubjectLabel = new System.Windows.Forms.Label();
            this.SaveSubjectButton = new System.Windows.Forms.Button();
            this.ClearSubjectButton = new System.Windows.Forms.Button();
            this.RemoveSubjectButton = new System.Windows.Forms.Button();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.AddSubjectTextBox = new System.Windows.Forms.TextBox();
            this.SubjectListBox = new System.Windows.Forms.ListBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.SavedSubjectLabel);
            this.panel1.Controls.Add(this.SaveSubjectButton);
            this.panel1.Controls.Add(this.ClearSubjectButton);
            this.panel1.Controls.Add(this.RemoveSubjectButton);
            this.panel1.Controls.Add(this.AddSubjectButton);
            this.panel1.Controls.Add(this.AddSubjectTextBox);
            this.panel1.Controls.Add(this.SubjectListBox);
            this.panel1.Controls.Add(this.SubjectLabel);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 497);
            this.panel1.TabIndex = 1;
            // 
            // SavedSubjectLabel
            // 
            this.SavedSubjectLabel.AutoSize = true;
            this.SavedSubjectLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.SavedSubjectLabel.ForeColor = System.Drawing.Color.Green;
            this.SavedSubjectLabel.Location = new System.Drawing.Point(191, 465);
            this.SavedSubjectLabel.Name = "SavedSubjectLabel";
            this.SavedSubjectLabel.Size = new System.Drawing.Size(109, 21);
            this.SavedSubjectLabel.TabIndex = 18;
            this.SavedSubjectLabel.Text = "Сохранено";
            this.SavedSubjectLabel.Visible = false;
            // 
            // SaveSubjectButton
            // 
            this.SaveSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSubjectButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.SaveSubjectButton.Location = new System.Drawing.Point(154, 417);
            this.SaveSubjectButton.Name = "SaveSubjectButton";
            this.SaveSubjectButton.Size = new System.Drawing.Size(176, 45);
            this.SaveSubjectButton.TabIndex = 16;
            this.SaveSubjectButton.Text = "Сохранить";
            this.SaveSubjectButton.UseVisualStyleBackColor = true;
            this.SaveSubjectButton.Click += new System.EventHandler(this.SaveSubjectButton_Click);
            // 
            // ClearSubjectButton
            // 
            this.ClearSubjectButton.Enabled = false;
            this.ClearSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSubjectButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ClearSubjectButton.Location = new System.Drawing.Point(3, 144);
            this.ClearSubjectButton.Name = "ClearSubjectButton";
            this.ClearSubjectButton.Size = new System.Drawing.Size(174, 35);
            this.ClearSubjectButton.TabIndex = 11;
            this.ClearSubjectButton.Text = "Очистить";
            this.ClearSubjectButton.UseVisualStyleBackColor = true;
            this.ClearSubjectButton.Click += new System.EventHandler(this.ClearSubjectButton_Click);
            // 
            // RemoveSubjectButton
            // 
            this.RemoveSubjectButton.Enabled = false;
            this.RemoveSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSubjectButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.RemoveSubjectButton.Location = new System.Drawing.Point(3, 103);
            this.RemoveSubjectButton.Name = "RemoveSubjectButton";
            this.RemoveSubjectButton.Size = new System.Drawing.Size(174, 35);
            this.RemoveSubjectButton.TabIndex = 10;
            this.RemoveSubjectButton.Text = "Удалить";
            this.RemoveSubjectButton.UseVisualStyleBackColor = true;
            this.RemoveSubjectButton.Click += new System.EventHandler(this.RemoveSubjectButton_Click);
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Enabled = false;
            this.AddSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSubjectButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.AddSubjectButton.Location = new System.Drawing.Point(3, 62);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(174, 35);
            this.AddSubjectButton.TabIndex = 9;
            this.AddSubjectButton.Text = "Добавить";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // AddSubjectTextBox
            // 
            this.AddSubjectTextBox.Location = new System.Drawing.Point(184, 62);
            this.AddSubjectTextBox.Name = "AddSubjectTextBox";
            this.AddSubjectTextBox.Size = new System.Drawing.Size(300, 20);
            this.AddSubjectTextBox.TabIndex = 8;
            this.AddSubjectTextBox.TextChanged += new System.EventHandler(this.AddSubjectTextBox_TextChanged);
            // 
            // SubjectListBox
            // 
            this.SubjectListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.SubjectListBox.FormattingEnabled = true;
            this.SubjectListBox.HorizontalScrollbar = true;
            this.SubjectListBox.ItemHeight = 20;
            this.SubjectListBox.Location = new System.Drawing.Point(183, 88);
            this.SubjectListBox.Name = "SubjectListBox";
            this.SubjectListBox.Size = new System.Drawing.Size(301, 302);
            this.SubjectListBox.Sorted = true;
            this.SubjectListBox.TabIndex = 7;
            this.SubjectListBox.SelectedIndexChanged += new System.EventHandler(this.SubjectListBox_SelectedIndexChanged);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Century Gothic", 17.75F);
            this.SubjectLabel.Location = new System.Drawing.Point(171, 20);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(138, 30);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "Предметы";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 519);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(522, 558);
            this.MinimumSize = new System.Drawing.Size(522, 558);
            this.Name = "SubjectForm";
            this.Text = "Предметы";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SavedSubjectLabel;
        private System.Windows.Forms.Button SaveSubjectButton;
        private System.Windows.Forms.Button ClearSubjectButton;
        private System.Windows.Forms.Button RemoveSubjectButton;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.TextBox AddSubjectTextBox;
        private System.Windows.Forms.ListBox SubjectListBox;
        private System.Windows.Forms.Label SubjectLabel;
    }
}