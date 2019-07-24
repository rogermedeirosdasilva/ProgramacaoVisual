namespace ProgramacaoVisual
{
    partial class FrmConsAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lstAlunos = new System.Windows.Forms.ListView();
            this.matricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.celular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.lblPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(396, 41);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(93, 23);
            this.btnPesquisa.TabIndex = 5;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(21, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(351, 20);
            this.txtPesquisa.TabIndex = 4;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(18, 24);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisa.TabIndex = 3;
            this.lblPesquisa.Text = "Pesquisar";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(525, 41);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(93, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lstAlunos
            // 
            this.lstAlunos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAlunos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matricula,
            this.nome,
            this.celular,
            this.Nascimento});
            this.lstAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAlunos.FullRowSelect = true;
            this.lstAlunos.GridLines = true;
            this.lstAlunos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstAlunos.Location = new System.Drawing.Point(0, 86);
            this.lstAlunos.MultiSelect = false;
            this.lstAlunos.Name = "lstAlunos";
            this.lstAlunos.Size = new System.Drawing.Size(960, 466);
            this.lstAlunos.TabIndex = 1;
            this.lstAlunos.UseCompatibleStateImageBehavior = false;
            this.lstAlunos.View = System.Windows.Forms.View.Details;
            this.lstAlunos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAlunos_MouseDoubleClick);
            // 
            // matricula
            // 
            this.matricula.Text = "Matrícula";
            this.matricula.Width = 150;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 400;
            // 
            // Nascimento
            // 
            this.Nascimento.DisplayIndex = 2;
            this.Nascimento.Text = "Nascimento";
            this.Nascimento.Width = 100;
            // 
            // celular
            // 
            this.celular.DisplayIndex = 3;
            this.celular.Text = "Celular";
            this.celular.Width = 120;
            // 
            // FrmConsAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 552);
            this.Controls.Add(this.lstAlunos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsAluno";
            this.Text = "FrmConsAluno";
            this.Load += new System.EventHandler(this.FrmConsAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.ListView lstAlunos;
        private System.Windows.Forms.ColumnHeader matricula;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader Nascimento;
        private System.Windows.Forms.ColumnHeader celular;
    }
}