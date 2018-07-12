using System;

namespace ParsingTXT
{
     partial class Form1
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
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SearchedResultTextBox = new System.Windows.Forms.TextBox();
            this.SaveSentencesButton = new System.Windows.Forms.Button();
            this.PastResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(610, 23);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(160, 34);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "open file";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(27, 23);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(523, 34);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SearchedResultTextBox
            // 
            this.SearchedResultTextBox.Location = new System.Drawing.Point(27, 75);
            this.SearchedResultTextBox.Multiline = true;
            this.SearchedResultTextBox.Name = "SearchedResultTextBox";
            this.SearchedResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SearchedResultTextBox.Size = new System.Drawing.Size(523, 106);
            this.SearchedResultTextBox.TabIndex = 3;
            // 
            // SaveSentencesButton
            // 
            this.SaveSentencesButton.Location = new System.Drawing.Point(610, 95);
            this.SaveSentencesButton.Name = "SaveSentencesButton";
            this.SaveSentencesButton.Size = new System.Drawing.Size(160, 34);
            this.SaveSentencesButton.TabIndex = 4;
            this.SaveSentencesButton.Text = "save sentences";
            this.SaveSentencesButton.UseVisualStyleBackColor = true;
            // 
            // PastResultsTextBox
            // 
            this.PastResultsTextBox.Location = new System.Drawing.Point(27, 202);
            this.PastResultsTextBox.Multiline = true;
            this.PastResultsTextBox.Name = "PastResultsTextBox";
            this.PastResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PastResultsTextBox.Size = new System.Drawing.Size(523, 236);
            this.PastResultsTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PastResultsTextBox);
            this.Controls.Add(this.SaveSentencesButton);
            this.Controls.Add(this.SearchedResultTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox SearchedResultTextBox;
        private System.Windows.Forms.Button SaveSentencesButton;
        private System.Windows.Forms.TextBox PastResultsTextBox;
    }
}

