namespace gcp.view
{
    partial class Base
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
        protected void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auxiliaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBase = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.auxiliaresToolStripMenuItem,
            this.funcionarioToolStripMenuItem1,
            this.turmaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Professor";
            // 
            // auxiliaresToolStripMenuItem
            // 
            this.auxiliaresToolStripMenuItem.Name = "auxiliaresToolStripMenuItem";
            this.auxiliaresToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.auxiliaresToolStripMenuItem.Text = "Auxiliar";
            // 
            // funcionarioToolStripMenuItem1
            // 
            this.funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            this.funcionarioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.funcionarioToolStripMenuItem1.Text = "Funcionario";
            this.funcionarioToolStripMenuItem1.Click += new System.EventHandler(this.funcionarioToolStripMenuItem1_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // tabBase
            // 
            this.tabBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBase.Location = new System.Drawing.Point(0, 24);
            this.tabBase.Name = "tabBase";
            this.tabBase.SelectedIndex = 0;
            this.tabBase.Size = new System.Drawing.Size(284, 238);
            this.tabBase.TabIndex = 1;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabBase);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Base";
            this.Text = "Formulario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem auxiliaresToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        protected System.Windows.Forms.TabControl tabBase;
    }
}