﻿
namespace gcp.view
{
    partial class DialogoBusca
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bSelecionar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bSelecionar
            // 
            this.bSelecionar.Location = new System.Drawing.Point(355, 283);
            this.bSelecionar.Name = "bSelecionar";
            this.bSelecionar.Size = new System.Drawing.Size(75, 23);
            this.bSelecionar.TabIndex = 3;
            this.bSelecionar.Text = "Selecionar";
            this.bSelecionar.UseVisualStyleBackColor = true;
            this.bSelecionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 238);
            this.listBox1.TabIndex = 4;
            // 
            // DialogoBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 318);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bSelecionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DialogoBusca";
            this.Text = "DialogoBusca";
            this.Load += new System.EventHandler(this.DialogoBusca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bSelecionar;
        private System.Windows.Forms.ListBox listBox1;
    }
}