using ProgramacaoVisual.Dominio;
using ProgramacaoVisual.InfraEstrutura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacaoVisual
{
    public partial class FrmConsAluno : Form
    {
        private AlunoNegocio AlunoNegocio { get; set; }

        public FrmConsAluno()
        {
            InitializeComponent();
        }

        private void FrmConsAluno_Load(object sender, EventArgs e)
        {
            AlunoNegocio = new AlunoNegocio();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            var retorno = AlunoNegocio.BuscaAlunos(txtPesquisa.Text);
            MontaGrid(retorno);
        }

        private void MontaGrid(List<Aluno> lista)
        {
            lstAlunos.BeginUpdate();
            lstAlunos.Items.Clear();
            foreach(var aluno in lista)
            {
                var item = lstAlunos.Items.Add(aluno.Matricula);
                item.SubItems.Add(aluno.Nome);
                item.SubItems.Add(aluno.Celular);
                item.SubItems.Add(aluno.Nascimento.ToString("dd/MM/yy"));
                item.Tag = aluno;
            }
            lstAlunos.EndUpdate();

            if (lista.Count.Equals(0))
            {
                MessageBox.Show("Nenhum Registro Encontrado");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (var f = new FrmCadAluno())
            {
                f.ShowDialog();
            }
        }

        private void lstAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAlunos.SelectedItems.Count > 0)
            {
                var aluno = (Aluno)lstAlunos.SelectedItems[0].Tag;
                using (var f = new FrmCadAluno())
                {
                    f.Edicao = aluno;
                    f.ShowDialog();
                }
            }
        }
    }
}
