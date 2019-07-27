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
            if (panel_conteudo.Tag != null && panel_conteudo.Tag.ToString().Equals(filho.Name))
                return;

            if (panel_conteudo.Controls.Count > 0)
            {
                panel_conteudo.Controls.RemoveAt(0);
            }
            filho.TopLevel = false;
            filho.BackColor = panel_conteudo.BackColor;
            filho.Dock = DockStyle.Fill;
            filho.FormBorderStyle = FormBorderStyle.None;

            this.panel_conteudo.Controls.Add(filho);
            this.panel_conteudo.Tag = filho.Name;
            filho.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            cboCor.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 60)
            {
                panelMenu.Width = 265;
            }
            else
            {
                panelMenu.Width = 60;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FrmCadAluno());
        }

        private void btnAlunos_Click_1(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FrmConsAluno());
        }

        private void cboCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboCor.SelectedIndex)
            {
                case 0:
                    {
                        panelTopo.BackColor = Color.FromArgb(30, 30, 46);
                        break;
                    }
                case 1:
                    {
                        panelTopo.BackColor = Color.Purple;
                        break;
                    }
                case 2:
                    {
                        panelTopo.BackColor = Color.LawnGreen;
                        break;
                    }
            }

            panelMenu.BackColor = panelTopo.BackColor;
            //MessageBox.Show(cboCor.Text);
        }

        private void TrocaCor()
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                panelTopo.BackColor = colorDialog1.Color;
                panelMenu.BackColor = panelTopo.BackColor;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cboCor.Visible = checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (var i = 0; i < openFileDialog1.FileNames.Count(); i++)
                {
                    MessageBox.Show(openFileDialog1.FileNames[i].ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrocaCor();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("é hora");
            timer1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}