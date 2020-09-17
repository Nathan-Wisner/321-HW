namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.downloadButton = new System.Windows.Forms.Button();
            this.URLBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.URLResult = new System.Windows.Forms.TextBox();
            this.URLText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.singleThreadLabel = new System.Windows.Forms.Label();
            this.normalTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(485, 148);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(361, 31);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download URL";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // URLBox
            // 
            this.URLBox.Location = new System.Drawing.Point(485, 75);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(361, 26);
            this.URLBox.TabIndex = 1;
            this.URLBox.TextChanged += new System.EventHandler(this.URLBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // URLResult
            // 
            this.URLResult.Location = new System.Drawing.Point(485, 221);
            this.URLResult.Multiline = true;
            this.URLResult.Name = "URLResult";
            this.URLResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.URLResult.Size = new System.Drawing.Size(361, 261);
            this.URLResult.TabIndex = 3;
            // 
            // URLText
            // 
            this.URLText.AutoSize = true;
            this.URLText.Location = new System.Drawing.Point(481, 34);
            this.URLText.Name = "URLText";
            this.URLText.Size = new System.Drawing.Size(75, 20);
            this.URLText.TabIndex = 4;
            this.URLText.Text = "URL Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // singleThreadLabel
            // 
            this.singleThreadLabel.AutoSize = true;
            this.singleThreadLabel.Location = new System.Drawing.Point(21, 81);
            this.singleThreadLabel.Name = "singleThreadLabel";
            this.singleThreadLabel.Size = new System.Drawing.Size(137, 20);
            this.singleThreadLabel.TabIndex = 6;
            this.singleThreadLabel.Text = "Single thread time";
            // 
            // normalTime
            // 
            this.normalTime.AutoSize = true;
            this.normalTime.Location = new System.Drawing.Point(25, 123);
            this.normalTime.Name = "normalTime";
            this.normalTime.Size = new System.Drawing.Size(144, 20);
            this.normalTime.TabIndex = 7;
            this.normalTime.Text = "Multithreaded time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 587);
            this.Controls.Add(this.normalTime);
            this.Controls.Add(this.singleThreadLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLText);
            this.Controls.Add(this.URLResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.downloadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox URLResult;
        private System.Windows.Forms.Label URLText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label singleThreadLabel;
        private System.Windows.Forms.Label normalTime;
    }
}

