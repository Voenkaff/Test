namespace Editor.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PlatoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddTestButton = new System.Windows.Forms.Button();
            this.SubjectFilterComboBox = new System.Windows.Forms.ComboBox();
            this.SubjectFilterLabel = new System.Windows.Forms.Label();
            this.ClearSubjectFilterButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlatoonToolStripMenuItem,
            this.SubjectToolStripMenuItem,
            this.SettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PlatoonToolStripMenuItem
            // 
            this.PlatoonToolStripMenuItem.Name = "PlatoonToolStripMenuItem";
            this.PlatoonToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.PlatoonToolStripMenuItem.Text = "Взвода";
            this.PlatoonToolStripMenuItem.Click += new System.EventHandler(this.PlatoonToolStripMenuItem_Click);
            // 
            // SubjectToolStripMenuItem
            // 
            this.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem";
            this.SubjectToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.SubjectToolStripMenuItem.Text = "Предметы";
            this.SubjectToolStripMenuItem.Click += new System.EventHandler(this.SubjectToolStripMenuItem_Click);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingToolStripMenuItem.Text = "Настройки";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(797, 402);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AddTestButton
            // 
            this.AddTestButton.Location = new System.Drawing.Point(686, 27);
            this.AddTestButton.Name = "AddTestButton";
            this.AddTestButton.Size = new System.Drawing.Size(123, 39);
            this.AddTestButton.TabIndex = 0;
            this.AddTestButton.Text = "Добавить тест";
            this.AddTestButton.UseVisualStyleBackColor = true;
            this.AddTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // SubjectFilterComboBox
            // 
            this.SubjectFilterComboBox.FormattingEnabled = true;
            this.SubjectFilterComboBox.Location = new System.Drawing.Point(140, 37);
            this.SubjectFilterComboBox.Name = "SubjectFilterComboBox";
            this.SubjectFilterComboBox.Size = new System.Drawing.Size(201, 21);
            this.SubjectFilterComboBox.TabIndex = 2;
            // 
            // SubjectFilterLabel
            // 
            this.SubjectFilterLabel.AutoSize = true;
            this.SubjectFilterLabel.Location = new System.Drawing.Point(12, 40);
            this.SubjectFilterLabel.Name = "SubjectFilterLabel";
            this.SubjectFilterLabel.Size = new System.Drawing.Size(122, 13);
            this.SubjectFilterLabel.TabIndex = 3;
            this.SubjectFilterLabel.Text = "Фильтр по предметам";
            // 
            // ClearSubjectFilterButton
            // 
            this.ClearSubjectFilterButton.Location = new System.Drawing.Point(347, 37);
            this.ClearSubjectFilterButton.Name = "ClearSubjectFilterButton";
            this.ClearSubjectFilterButton.Size = new System.Drawing.Size(110, 21);
            this.ClearSubjectFilterButton.TabIndex = 4;
            this.ClearSubjectFilterButton.Text = "Сбросить";
            this.ClearSubjectFilterButton.UseVisualStyleBackColor = true;
            this.ClearSubjectFilterButton.Click += new System.EventHandler(this.ClearSubjectFilterButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 488);
            this.Controls.Add(this.ClearSubjectFilterButton);
            this.Controls.Add(this.SubjectFilterLabel);
            this.Controls.Add(this.SubjectFilterComboBox);
            this.Controls.Add(this.AddTestButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PlatoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddTestButton;
        private System.Windows.Forms.ComboBox SubjectFilterComboBox;
        private System.Windows.Forms.Label SubjectFilterLabel;
        private System.Windows.Forms.Button ClearSubjectFilterButton;
    }
}