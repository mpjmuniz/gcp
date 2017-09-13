﻿namespace gcp.view
{
    partial class FormularioBase
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
            this.menuStrip1.SuspendLayout();

            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bNovo = new System.Windows.Forms.Button();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bAlterar = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bInscrever = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();

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
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionarioToolStripMenuItem.Text = "Professor";
            // 
            // auxiliaresToolStripMenuItem
            // 
            this.auxiliaresToolStripMenuItem.Name = "auxiliaresToolStripMenuItem";
            this.auxiliaresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.auxiliaresToolStripMenuItem.Text = "Auxiliar";
            // 
            // funcionarioToolStripMenuItem1
            // 
            this.funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            this.funcionarioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.funcionarioToolStripMenuItem1.Text = "Funcionario";
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestor das Creches Paroquial";
            this.Text = "Gestor das Creches Paroquial";
            this.Load += new System.EventHandler(this.FormularioBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();

            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bInscrever);
            this.splitContainer1.Panel1.Controls.Add(this.bCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.bEditar);
            this.splitContainer1.Panel1.Controls.Add(this.bExcluir);
            this.splitContainer1.Panel1.Controls.Add(this.bAlterar);
            this.splitContainer1.Panel1.Controls.Add(this.bCadastrar);
            this.splitContainer1.Panel1.Controls.Add(this.bNovo);
            this.splitContainer1.Size = new System.Drawing.Size(284, 238);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 1;
            // 
            // bNovo
            // 
            this.bNovo.Location = new System.Drawing.Point(13, 4);
            this.bNovo.Name = "bNovo";
            this.bNovo.Size = new System.Drawing.Size(75, 23);
            this.bNovo.TabIndex = 0;
            this.bNovo.Text = "Novo";
            this.bNovo.UseVisualStyleBackColor = true;
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(13, 34);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 1;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(13, 64);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 2;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            // 
            // bExcluir
            // 
            this.bExcluir.Location = new System.Drawing.Point(13, 94);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 3;
            this.bExcluir.Text = "Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(13, 124);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(75, 23);
            this.bEditar.TabIndex = 4;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(13, 154);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bInscrever
            // 
            this.bInscrever.Location = new System.Drawing.Point(13, 184);
            this.bInscrever.Name = "bInscrever";
            this.bInscrever.Size = new System.Drawing.Size(75, 23);
            this.bInscrever.TabIndex = 6;
            this.bInscrever.Text = "Inscrever";
            this.bInscrever.UseVisualStyleBackColor = true;
            // 
            // FormularioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormularioFuncionario";
            this.Text = "FormularioFuncionario";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);


            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auxiliaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bNovo;
        private System.Windows.Forms.Button bInscrever;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bExcluir;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Button bCadastrar;
    }
}
