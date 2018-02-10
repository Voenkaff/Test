namespace Editor.Forms
{
    partial class SettingForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.SavePathLabel = new System.Windows.Forms.Label();
            this.SavePathTextBox = new System.Windows.Forms.TextBox();
            this.SavePathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(521, 48);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 30);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SavePathLabel
            // 
            this.SavePathLabel.AutoSize = true;
            this.SavePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavePathLabel.Location = new System.Drawing.Point(11, 9);
            this.SavePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SavePathLabel.Name = "SavePathLabel";
            this.SavePathLabel.Size = new System.Drawing.Size(143, 15);
            this.SavePathLabel.TabIndex = 4;
            this.SavePathLabel.Text = "Директория с тестами:";
            // 
            // SavePathTextBox
            // 
            this.SavePathTextBox.Location = new System.Drawing.Point(175, 9);
            this.SavePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SavePathTextBox.Name = "SavePathTextBox";
            this.SavePathTextBox.Size = new System.Drawing.Size(368, 20);
            this.SavePathTextBox.TabIndex = 3;
            this.SavePathTextBox.Text = "D:\\\\";
            // 
            // OpenFileDialogButton
            // 
            this.OpenFileDialogButton.Location = new System.Drawing.Point(548, 7);
            this.OpenFileDialogButton.Name = "OpenFileDialogButton";
            this.OpenFileDialogButton.Size = new System.Drawing.Size(86, 23);
            this.OpenFileDialogButton.TabIndex = 6;
            this.OpenFileDialogButton.Text = "Обозреватель";
            this.OpenFileDialogButton.UseVisualStyleBackColor = true;
            this.OpenFileDialogButton.Click += new System.EventHandler(this.OpenFileDialogButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 89);
            this.Controls.Add(this.OpenFileDialogButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SavePathLabel);
            this.Controls.Add(this.SavePathTextBox);
            this.MaximumSize = new System.Drawing.Size(657, 128);
            this.MinimumSize = new System.Drawing.Size(657, 128);
            this.Name = "SettingForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SavePathLabel;
        private System.Windows.Forms.TextBox SavePathTextBox;
        private System.Windows.Forms.FolderBrowserDialog SavePathFolderBrowserDialog;
        private System.Windows.Forms.Button OpenFileDialogButton;
    }
}