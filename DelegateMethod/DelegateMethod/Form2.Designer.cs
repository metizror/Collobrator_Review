﻿namespace DelegateMethod
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxShowStdRet = new System.Windows.Forms.TextBox();
            this.textBoxShowErrRet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(705, 103);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxShowStdRet
            // 
            this.textBoxShowStdRet.Location = new System.Drawing.Point(12, 145);
            this.textBoxShowStdRet.Multiline = true;
            this.textBoxShowStdRet.Name = "textBoxShowStdRet";
            this.textBoxShowStdRet.Size = new System.Drawing.Size(705, 103);
            this.textBoxShowStdRet.TabIndex = 1;
            // 
            // textBoxShowErrRet
            // 
            this.textBoxShowErrRet.Location = new System.Drawing.Point(12, 284);
            this.textBoxShowErrRet.Multiline = true;
            this.textBoxShowErrRet.Name = "textBoxShowErrRet";
            this.textBoxShowErrRet.Size = new System.Drawing.Size(705, 103);
            this.textBoxShowErrRet.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 467);
            this.Controls.Add(this.textBoxShowErrRet);
            this.Controls.Add(this.textBoxShowStdRet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxShowStdRet;
        private System.Windows.Forms.TextBox textBoxShowErrRet;
    }
}