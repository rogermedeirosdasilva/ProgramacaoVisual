using ProgramcaoVisual.InfraEstrutura;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FrmConsAluno());
        }

        private void AbrirFormNoPanel(Form filho)
        {
            filho.ShowDialog();
        }
    }
}