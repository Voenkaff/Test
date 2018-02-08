namespace Client.Forms
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.LoadingStatusLabel = new System.Windows.Forms.Label();
            this.LoadingStatusProgressBar = new System.Windows.Forms.ProgressBar();
            this.StartLoadingButton = new System.Windows.Forms.Button();
            this.LoadingTestBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // LoadingStatusLabel
            // 
            resources.ApplyResources(this.LoadingStatusLabel, "LoadingStatusLabel");
            this.LoadingStatusLabel.Name = "LoadingStatusLabel";
            // 
            // LoadingStatusProgressBar
            // 
            resources.ApplyResources(this.LoadingStatusProgressBar, "LoadingStatusProgressBar");
            this.LoadingStatusProgressBar.Name = "LoadingStatusProgressBar";
            // 
            // StartLoadingButton
            // 
            resources.ApplyResources(this.StartLoadingButton, "StartLoadingButton");
            this.StartLoadingButton.Name = "StartLoadingButton";
            this.StartLoadingButton.UseVisualStyleBackColor = true;
            this.StartLoadingButton.Click += new System.EventHandler(this.StartLoadingButton_Click);
            // 
            // LoadingTestBackgroundWorker
            // 
            this.LoadingTestBackgroundWorker.WorkerReportsProgress = true;
            this.LoadingTestBackgroundWorker.WorkerSupportsCancellation = true;
            this.LoadingTestBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadingTestBackgroundWorker_DoWork);
            this.LoadingTestBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.LoadingTestBackgroundWorker_ProgressChanged);
            this.LoadingTestBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoadingTestBackgroundWorker_RunWorkerCompleted);
            // 
            // LoadingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartLoadingButton);
            this.Controls.Add(this.LoadingStatusProgressBar);
            this.Controls.Add(this.LoadingStatusLabel);
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoadingStatusLabel;
        private System.Windows.Forms.ProgressBar LoadingStatusProgressBar;
        private System.Windows.Forms.Button StartLoadingButton;
        private System.ComponentModel.BackgroundWorker LoadingTestBackgroundWorker;
    }
}

