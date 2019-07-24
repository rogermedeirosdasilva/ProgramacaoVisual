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
    public partial class FrmCadAluno : Form
    {
        private Aluno aluno;

        public Aluno Edicao
        {
            get
            {
                return aluno;
            }
            set
            {
                aluno = value;
                txtMatricula.Text = aluno.Matricula;
                txtNome.Text = aluno.Nome;
                txtCelular.Text = aluno.Celular;
                txtNascimento.Value = aluno.Nascimento;

                txtMatricula.Enabled = false;
            }
        }

        public FrmCadAluno()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var retorno = string.Empty;

            if (aluno == null)
            {
                var novo = new Aluno
                {
                    Matricula = txtMatricula.Text,
                    Nome = txtNome.Text,
                    Celular = txtCelular.Text,
                    Nascimento = txtNascimento.Value
                };

                retorno = new AlunoNegocio().AdicionarAluno(novo);
            }
            else
            {
                aluno.Nome = txtNome.Text;
                aluno.Nascimento = txtNascimento.Value;
                aluno.Celular = txtCelular.Text;
                retorno = new AlunoNegocio().SalvarAluno(aluno);
            }

            if (retorno.Equals("OK"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(retorno);
            }
        }
    }
}
