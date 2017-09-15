using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gcp.view
{
    public partial class AbaFuncionario : TabPage//AbaCadastrosBase
    {
        public AbaFuncionario()
        {
            InitializeComponent();
        }

        
        private void bNovo_Click(object sender, EventArgs e)
        {
            /*
            // TODO: implementar caso de uso para cadastro
            this.lElementos.getSelectionModel().clearSelection();
		
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
            /*
             TODO: implementar verificação de validade dos dados na tela
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
        
            salvo();
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
        
            cancelado();
        }

        private void bImprimir_Click(object sender, EventArgs e){
            // TODO: implementar impressão
        }
        
        private void novo()
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Enabled = true;
            }

            bNovo.Enabled = false;
            bCadastrar.Enabled = true;
            bEditar.Enabled = false;
            bAlterar.Enabled = false;
            bExcluir.Enabled = false;
            bCancelar.Enabled = true;
            bImprimir.Enabled = false;
        }

        private void salvo() {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Enabled = false;
            }

            bNovo.Enabled = true;
            bCadastrar.Enabled = false;
            bEditar.Enabled = true;
            bAlterar.Enabled = false;
            bExcluir.Enabled = true;
            bCancelar.Enabled = false;
            bImprimir.Enabled = true;
        }

        public void editavel() {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Enabled = false;
            }

		    bNovo.Enabled = false;
            bCadastrar.Enabled = false;
		    bEditar.Enabled = false;
		    bAlterar.Enabled = true;
		    bExcluir.Enabled = false;
		    bCancelar.Enabled = true;
		    bImprimir.Enabled = false;
	    }

        public void cancelado() {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Enabled = false;
            }
		
		    //TODO: pensar em como implementar: this.lCampos.limpar();
		
		    bNovo.Enabled = true;
		    bCadastrar.Enabled = false;
		    bEditar.Enabled = true;
		    bAlterar.Enabled = false;
		    bExcluir.Enabled = true;
		    bCancelar.Enabled = false;
		    bImprimir.Enabled = true;
	    }
        
    }
}
