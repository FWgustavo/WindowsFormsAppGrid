using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //adiciona o conteudo das caixas de texto nas colunas correspondentes 
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);
            //limpa as caixas de texto
            txtNome.Clear();
            txtCurso.Clear();
            //Exibe uma mensagem ao usuario de inclusão com sucesso!
            MessageBox.Show("Aluno incluido com sucesso", "Inclusão", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Exibe na label o contador de linhas do GridView atualizado após a inserção 
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Verifica a existencia de linhas no grid
            if (dgvAlunos.RowCount > 0)
            {
                //remove a linha selecionada do Grid
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                //exibe uma mensagem ao usuario de exclusão com sucesso!
                MessageBox.Show("Aluno Excluido com sucesso", "Exclusão" ,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                //Exibe na label o contador de linhas GridView atualizado após a remoção
                lblTotal.Text = dgvAlunos.RowCount.ToString() ;
            }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica a existencia de linhas no Grid
            if (dgvAlunos.RowCount > 0)
            {
                //move o conteudo da primeira celula da linha selecionada para a caixa de texto
                txtAlteracao.Text = dgvAlunos.CurrentRow.Cells["nome"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtAlteracao.Text != "")
            {
                //move o novo valor da caixa de texto Alteração  para a celula selecionada
                dgvAlunos.CurrentRow.Cells["nome"].Value = txtAlteracao.Text;
                //Exibe a mensagem de alteração com sucesso
                MessageBox.Show("Aluno Alterado com sucesso", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //zera as linhas do grid, removendo as existentes
            dgvAlunos.RowCount = 0;
            
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
