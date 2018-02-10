namespace Editor.Forms
{
    partial class PlatoonsForm
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
            this.SavePlatoonsButton = new System.Windows.Forms.Button();
            this.AddFewStudentButton = new System.Windows.Forms.Button();
            this.SortStudentButton = new System.Windows.Forms.Button();
            this.ClearStudentButton = new System.Windows.Forms.Button();
            this.RemoveStudentButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.StudentsTextBox = new System.Windows.Forms.TextBox();
            this.StudentsLabel = new System.Windows.Forms.Label();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.ClearPlatoonButton = new System.Windows.Forms.Button();
            this.RemovePlatoonButton = new System.Windows.Forms.Button();
            this.AddPlatoonButton = new System.Windows.Forms.Button();
            this.PlatoonTextBox = new System.Windows.Forms.TextBox();
            this.PlatoonsLabel = new System.Windows.Forms.Label();
            this.PlatoonsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SavePlatoonsButton
            // 
            this.SavePlatoonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePlatoonsButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.SavePlatoonsButton.Location = new System.Drawing.Point(353, 379);
            this.SavePlatoonsButton.Name = "SavePlatoonsButton";
            this.SavePlatoonsButton.Size = new System.Drawing.Size(140, 45);
            this.SavePlatoonsButton.TabIndex = 15;
            this.SavePlatoonsButton.Text = "Сохранить";
            this.SavePlatoonsButton.UseVisualStyleBackColor = true;
            this.SavePlatoonsButton.Click += new System.EventHandler(this.SavePlatoonsButton_Click);
            // 
            // AddFewStudentButton
            // 
            this.AddFewStudentButton.Enabled = false;
            this.AddFewStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFewStudentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.AddFewStudentButton.Location = new System.Drawing.Point(651, 315);
            this.AddFewStudentButton.Name = "AddFewStudentButton";
            this.AddFewStudentButton.Size = new System.Drawing.Size(132, 58);
            this.AddFewStudentButton.TabIndex = 14;
            this.AddFewStudentButton.Text = "Добавить несколько";
            this.AddFewStudentButton.UseVisualStyleBackColor = true;
            this.AddFewStudentButton.Click += new System.EventHandler(this.AddFewStudentButton_Click);
            // 
            // SortStudentButton
            // 
            this.SortStudentButton.Enabled = false;
            this.SortStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortStudentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.SortStudentButton.Location = new System.Drawing.Point(651, 168);
            this.SortStudentButton.Name = "SortStudentButton";
            this.SortStudentButton.Size = new System.Drawing.Size(132, 35);
            this.SortStudentButton.TabIndex = 13;
            this.SortStudentButton.Text = "Сортировать";
            this.SortStudentButton.UseVisualStyleBackColor = true;
            this.SortStudentButton.Click += new System.EventHandler(this.SortStudentButton_Click);
            // 
            // ClearStudentButton
            // 
            this.ClearStudentButton.Enabled = false;
            this.ClearStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearStudentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ClearStudentButton.Location = new System.Drawing.Point(651, 127);
            this.ClearStudentButton.Name = "ClearStudentButton";
            this.ClearStudentButton.Size = new System.Drawing.Size(132, 35);
            this.ClearStudentButton.TabIndex = 12;
            this.ClearStudentButton.Text = "Очистить";
            this.ClearStudentButton.UseVisualStyleBackColor = true;
            this.ClearStudentButton.Click += new System.EventHandler(this.ClearStudentButton_Click);
            // 
            // RemoveStudentButton
            // 
            this.RemoveStudentButton.Enabled = false;
            this.RemoveStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveStudentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.RemoveStudentButton.Location = new System.Drawing.Point(651, 86);
            this.RemoveStudentButton.Name = "RemoveStudentButton";
            this.RemoveStudentButton.Size = new System.Drawing.Size(132, 35);
            this.RemoveStudentButton.TabIndex = 11;
            this.RemoveStudentButton.Text = "Удалить";
            this.RemoveStudentButton.UseVisualStyleBackColor = true;
            this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Enabled = false;
            this.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.AddStudentButton.Location = new System.Drawing.Point(651, 45);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(132, 35);
            this.AddStudentButton.TabIndex = 10;
            this.AddStudentButton.Text = "Добавить";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // StudentsTextBox
            // 
            this.StudentsTextBox.Enabled = false;
            this.StudentsTextBox.Location = new System.Drawing.Point(299, 45);
            this.StudentsTextBox.Name = "StudentsTextBox";
            this.StudentsTextBox.Size = new System.Drawing.Size(346, 20);
            this.StudentsTextBox.TabIndex = 9;
            this.StudentsTextBox.TextChanged += new System.EventHandler(this.StudentsTextBox_TextChanged);
            this.StudentsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentsTextBox_KeyPress);
            // 
            // StudentsLabel
            // 
            this.StudentsLabel.AutoSize = true;
            this.StudentsLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.StudentsLabel.Location = new System.Drawing.Point(395, 18);
            this.StudentsLabel.Name = "StudentsLabel";
            this.StudentsLabel.Size = new System.Drawing.Size(168, 24);
            this.StudentsLabel.TabIndex = 8;
            this.StudentsLabel.Text = "Личный состав";
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentsListBox.Enabled = false;
            this.StudentsListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.HorizontalScrollbar = true;
            this.StudentsListBox.ItemHeight = 20;
            this.StudentsListBox.Location = new System.Drawing.Point(299, 71);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(346, 302);
            this.StudentsListBox.TabIndex = 7;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsListBox_SelectedIndexChanged);
            // 
            // ClearPlatoonButton
            // 
            this.ClearPlatoonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearPlatoonButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ClearPlatoonButton.Location = new System.Drawing.Point(3, 127);
            this.ClearPlatoonButton.Name = "ClearPlatoonButton";
            this.ClearPlatoonButton.Size = new System.Drawing.Size(125, 35);
            this.ClearPlatoonButton.TabIndex = 5;
            this.ClearPlatoonButton.Text = "Очистить";
            this.ClearPlatoonButton.UseVisualStyleBackColor = true;
            this.ClearPlatoonButton.Click += new System.EventHandler(this.ClearPlatoonButton_Click);
            // 
            // RemovePlatoonButton
            // 
            this.RemovePlatoonButton.Enabled = false;
            this.RemovePlatoonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlatoonButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.RemovePlatoonButton.Location = new System.Drawing.Point(3, 86);
            this.RemovePlatoonButton.Name = "RemovePlatoonButton";
            this.RemovePlatoonButton.Size = new System.Drawing.Size(125, 35);
            this.RemovePlatoonButton.TabIndex = 4;
            this.RemovePlatoonButton.Text = "Удалить";
            this.RemovePlatoonButton.UseVisualStyleBackColor = true;
            this.RemovePlatoonButton.Click += new System.EventHandler(this.RemovePlatoonButton_Click);
            // 
            // AddPlatoonButton
            // 
            this.AddPlatoonButton.Enabled = false;
            this.AddPlatoonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPlatoonButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.AddPlatoonButton.Location = new System.Drawing.Point(3, 45);
            this.AddPlatoonButton.Name = "AddPlatoonButton";
            this.AddPlatoonButton.Size = new System.Drawing.Size(125, 35);
            this.AddPlatoonButton.TabIndex = 3;
            this.AddPlatoonButton.Text = "Добавить";
            this.AddPlatoonButton.UseVisualStyleBackColor = true;
            this.AddPlatoonButton.Click += new System.EventHandler(this.AddPlatoonButton_Click);
            // 
            // PlatoonTextBox
            // 
            this.PlatoonTextBox.Location = new System.Drawing.Point(134, 45);
            this.PlatoonTextBox.Name = "PlatoonTextBox";
            this.PlatoonTextBox.Size = new System.Drawing.Size(159, 20);
            this.PlatoonTextBox.TabIndex = 2;
            this.PlatoonTextBox.TextChanged += new System.EventHandler(this.PlatoonTextBox_TextChanged);
            this.PlatoonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlatoonTextBox_KeyPress);
            // 
            // PlatoonsLabel
            // 
            this.PlatoonsLabel.AutoSize = true;
            this.PlatoonsLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PlatoonsLabel.Location = new System.Drawing.Point(176, 18);
            this.PlatoonsLabel.Name = "PlatoonsLabel";
            this.PlatoonsLabel.Size = new System.Drawing.Size(82, 24);
            this.PlatoonsLabel.TabIndex = 1;
            this.PlatoonsLabel.Text = "Взвода";
            // 
            // PlatoonsListBox
            // 
            this.PlatoonsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlatoonsListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.PlatoonsListBox.FormattingEnabled = true;
            this.PlatoonsListBox.ItemHeight = 20;
            this.PlatoonsListBox.Location = new System.Drawing.Point(134, 71);
            this.PlatoonsListBox.Name = "PlatoonsListBox";
            this.PlatoonsListBox.Size = new System.Drawing.Size(159, 302);
            this.PlatoonsListBox.TabIndex = 0;
            this.PlatoonsListBox.SelectedIndexChanged += new System.EventHandler(this.PlattonsListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.SavePlatoonsButton);
            this.panel1.Controls.Add(this.AddFewStudentButton);
            this.panel1.Controls.Add(this.SortStudentButton);
            this.panel1.Controls.Add(this.ClearStudentButton);
            this.panel1.Controls.Add(this.RemoveStudentButton);
            this.panel1.Controls.Add(this.AddStudentButton);
            this.panel1.Controls.Add(this.StudentsTextBox);
            this.panel1.Controls.Add(this.StudentsLabel);
            this.panel1.Controls.Add(this.StudentsListBox);
            this.panel1.Controls.Add(this.ClearPlatoonButton);
            this.panel1.Controls.Add(this.RemovePlatoonButton);
            this.panel1.Controls.Add(this.AddPlatoonButton);
            this.panel1.Controls.Add(this.PlatoonTextBox);
            this.panel1.Controls.Add(this.PlatoonsLabel);
            this.panel1.Controls.Add(this.PlatoonsListBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 444);
            this.panel1.TabIndex = 1;
            // 
            // PlatoonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 468);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(831, 507);
            this.MinimumSize = new System.Drawing.Size(831, 507);
            this.Name = "PlatoonsForm";
            this.Text = "Взвода";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SavePlatoonsButton;
        private System.Windows.Forms.Button AddFewStudentButton;
        private System.Windows.Forms.Button SortStudentButton;
        private System.Windows.Forms.Button ClearStudentButton;
        private System.Windows.Forms.Button RemoveStudentButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.TextBox StudentsTextBox;
        private System.Windows.Forms.Label StudentsLabel;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.Button ClearPlatoonButton;
        private System.Windows.Forms.Button RemovePlatoonButton;
        private System.Windows.Forms.Button AddPlatoonButton;
        private System.Windows.Forms.TextBox PlatoonTextBox;
        private System.Windows.Forms.Label PlatoonsLabel;
        private System.Windows.Forms.ListBox PlatoonsListBox;
        private System.Windows.Forms.Panel panel1;
    }
}