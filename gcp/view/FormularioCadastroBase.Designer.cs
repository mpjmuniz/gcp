namespace gcp.view
{
    partial class FormularioCadastroBase
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "FormularioCadastroBase";

            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bImprimir = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.bAlterar = new System.Windows.Forms.Button();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();

            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bImprimir);
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
            // bImprimir
            // 
            this.bImprimir.Location = new System.Drawing.Point(13, 184);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(75, 23);
            this.bImprimir.TabIndex = 6;
            this.bImprimir.Text = "Inscrever";
            this.bImprimir.UseVisualStyleBackColor = true;
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
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(13, 124);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(75, 23);
            this.bEditar.TabIndex = 4;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
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
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(13, 64);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 2;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
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
            // bNovo
            // 
            this.bNovo.Location = new System.Drawing.Point(13, 4);
            this.bNovo.Name = "bNovo";
            this.bNovo.Size = new System.Drawing.Size(75, 23);
            this.bNovo.TabIndex = 0;
            this.bNovo.Text = "Novo";
            this.bNovo.UseVisualStyleBackColor = true;

            this.Controls.Add(this.splitContainer1);

            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.Button bNovo;
        protected System.Windows.Forms.Button bImprimir;
        protected System.Windows.Forms.Button bCancelar;
        protected System.Windows.Forms.Button bEditar;
        protected System.Windows.Forms.Button bExcluir;
        protected System.Windows.Forms.Button bAlterar;
        protected System.Windows.Forms.Button bCadastrar;
    }
}