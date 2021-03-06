﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gcp.view
{

    /*TODO: implementar botão "buscar"
     *      implementar botão "imprimir"
            */

    public partial class FormularioFuncionario : FormularioCadastroBase
    {
        private enum Estado
        {
            Vazio,
            Novo,
            Salvo,
            Editavel
        }

        private Estado estadoAtual;


        private DialogoBusca dBusca;

        public FormularioFuncionario()
        {
            InitializeComponent();

            vazio();



        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmissao = new System.Windows.Forms.DateTimePicker();
            this.tbRG = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbCarteiraDeTrabalho = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.cbInstrucao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbInstrucao);
            this.splitContainer1.Panel2.Controls.Add(this.tbTelefone);
            this.splitContainer1.Panel2.Controls.Add(this.tbEndereco);
            this.splitContainer1.Panel2.Controls.Add(this.tbCarteiraDeTrabalho);
            this.splitContainer1.Panel2.Controls.Add(this.tbTitulo);
            this.splitContainer1.Panel2.Controls.Add(this.tbCPF);
            this.splitContainer1.Panel2.Controls.Add(this.tbRG);
            this.splitContainer1.Panel2.Controls.Add(this.dtpAdmissao);
            this.splitContainer1.Panel2.Controls.Add(this.dtpNascimento);
            this.splitContainer1.Panel2.Controls.Add(this.cbSexo);
            this.splitContainer1.Panel2.Controls.Add(this.tbNome);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.titulo);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(784, 562);
            this.splitContainer1.SplitterDistance = 259;
            // 
            // bNovo
            // 
            this.bNovo.Click += new System.EventHandler(this.bNovo_Click);
            // 
            // bImprimir
            // 
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bEditar
            // 
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bExcluir
            // 
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // bAlterar
            // 
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // bCadastrar
            // 
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Admissão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(34, 181);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(35, 13);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "Título";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Carteira de Trabalho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Instrução";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(190, 13);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 11;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(190, 41);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 12;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(190, 69);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpNascimento.TabIndex = 13;
            // 
            // dtpAdmissao
            // 
            this.dtpAdmissao.Location = new System.Drawing.Point(190, 97);
            this.dtpAdmissao.Name = "dtpAdmissao";
            this.dtpAdmissao.Size = new System.Drawing.Size(200, 20);
            this.dtpAdmissao.TabIndex = 14;
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(190, 125);
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(100, 20);
            this.tbRG.TabIndex = 15;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(190, 153);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 20);
            this.tbCPF.TabIndex = 16;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(190, 181);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(100, 20);
            this.tbTitulo.TabIndex = 17;
            // 
            // tbCarteiraDeTrabalho
            // 
            this.tbCarteiraDeTrabalho.Location = new System.Drawing.Point(190, 209);
            this.tbCarteiraDeTrabalho.Name = "tbCarteiraDeTrabalho";
            this.tbCarteiraDeTrabalho.Size = new System.Drawing.Size(100, 20);
            this.tbCarteiraDeTrabalho.TabIndex = 18;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(190, 237);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(100, 20);
            this.tbEndereco.TabIndex = 19;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(190, 265);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 20);
            this.tbTelefone.TabIndex = 20;
            // 
            // cbInstrucao
            // 
            this.cbInstrucao.FormattingEnabled = true;
            this.cbInstrucao.Location = new System.Drawing.Point(190, 293);
            this.cbInstrucao.Name = "cbInstrucao";
            this.cbInstrucao.Size = new System.Drawing.Size(121, 21);
            this.cbInstrucao.TabIndex = 21;
            // 
            // FormularioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "FormularioFuncionario";
            this.Text = "Formulario de Funcionarios";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void bNovo_Click(object sender, EventArgs e)
        {
            // TODO: implementar caso de uso para cadastro
            /* this.lElementos.getSelectionModel().clearSelection();
		
		    this.lCampos.limpar();
		
		    lCampos.construirObjeto();
		
		    T objeto = lCampos.obterObjeto();
		
		    try {
			    objeto.getClass().getMethod("setNome", String.class).invoke(objeto, "[Novo]");
			
		    } catch (IllegalAccessException | 
				     IllegalArgumentException | 
				     InvocationTargetException | 
				     NoSuchMethodException	| 
				     SecurityException e) {
			
			    e.printStackTrace();
		    }
		
		    lElementos.getItems().add(objeto);
		
		    lElementos.getSelectionModel().select(objeto);
		    */
		    novo();
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            /* TODO: implementar verificação de validade dos dados na tela
             * 
             * if (lCampos.dadosEstaoValidos())
            {

                lCampos.construirObjeto();

                T objeto = lCampos.obterObjeto();

                cadastrar(objeto);

            }
            else
            {

                ajuda.set("Problema no cadastro: Alguns dos dados estão inválidos");
            } */
            salvo();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            // TODO: implementar caso de uso de alteração

            //lElementos.getItems().set(lElementos.getItems().indexOf(anterior), posterior);

            //this.remover(anterior);
            //this.persistir(posterior);

            //lElementos.refresh();

            //lCampos.definirObjeto(null);

            salvo();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            /* TODO: implementar consulta de registros
             * 
             * if (lElementos.getSelectionModel().isEmpty())
            {
                ajuda.set("Selecione o que será removido.");
                return;
            }

            this.deletar(lElementos.getSelectionModel().getSelectedItem());

            this.lElementos.getItems().remove(lElementos.getSelectionModel().getSelectedItem());

             * */

            // Limpar campos digitados

            vazio();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            /* TODO: Implementar consulta para seleção do objeto
             * 
             * if (lElementos.getSelectionModel().isEmpty())
            {
                ajuda.set("Selecione o que será editado.");
                return;
            }*/

            editavel();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            /*  TODO: verificar necessidade de estado
             * 
             * if (estado.equals(Estado.Novo))
            {
                lElementos.getItems().remove(lCampos.obterObjeto());
            } */

            if (estadoAtual == Estado.Novo)
                vazio();
            else
                salvo();

        }

        private void bImprimir_Click(object sender, EventArgs e){
            // TODO: implementar impressão
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            dBusca = new DialogoBusca();
            dBusca.MdiParent = this.MdiParent;
            this.Enabled = false;

            dBusca.FormClosing += new FormClosingEventHandler(tuplaSelecionada);
            dBusca.Show();
        }

        private void tuplaSelecionada(object sender, EventArgs e)
        {
            //var query = from f in dadoscpDataSet.Funcionario where f.id == dBusca.getFuncionario() select f;

            //var funcionario = query.First();

            this.Enabled = true;

           /* funcionario = null;

            if (funcionario == null)
            {
                vazio();
            }
            else {
                salvo();
            }*/
            
        }

        private void camposHabilitados(bool habilitar){
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Enabled = habilitar;
            }
        }

        private void vazio() {
            estadoAtual = Estado.Vazio;

            camposHabilitados(false);

            bNovo.Enabled = true;
            bBuscar.Enabled = true;
            bCadastrar.Enabled = false;
            bEditar.Enabled = false;
            bAlterar.Enabled = false;
            bExcluir.Enabled = false;
            bCancelar.Enabled = false;
            bImprimir.Enabled = false;
        }

        private void novo()
        {
            estadoAtual = Estado.Novo;
            
            camposHabilitados(true);

            bNovo.Enabled = false;
            bBuscar.Enabled = false;
            bCadastrar.Enabled = true;
            bEditar.Enabled = false;
            bAlterar.Enabled = false;
            bExcluir.Enabled = false;
            bCancelar.Enabled = true;
            bImprimir.Enabled = false;
        }

        private void salvo() {
            estadoAtual = Estado.Salvo;

            camposHabilitados(false);

            bNovo.Enabled = true;
            bBuscar.Enabled = true;
            bCadastrar.Enabled = false;
            bEditar.Enabled = true;
            bAlterar.Enabled = false;
            bExcluir.Enabled = true;
            bCancelar.Enabled = false;
            bImprimir.Enabled = true;
        }

        public void editavel() {
            estadoAtual = Estado.Editavel;

            camposHabilitados(false);

		    bNovo.Enabled = false;
            bCadastrar.Enabled = false;
            bBuscar.Enabled = false;
		    bEditar.Enabled = false;
		    bAlterar.Enabled = true;
		    bExcluir.Enabled = false;
		    bCancelar.Enabled = true;
		    bImprimir.Enabled = false;
	    }

        
    }
}
