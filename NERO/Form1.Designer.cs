namespace NERO
{
    partial class Form_Principal
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
            this.btn_MudarDados = new System.Windows.Forms.Button();
            this.tb_DadosPac = new System.Windows.Forms.TextBox();
            this.l_DadosPac = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_Dentes = new System.Windows.Forms.Label();
            this.clb_Dentes = new System.Windows.Forms.CheckedListBox();
            this.clb_ListaLaudo = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.l_Analise = new System.Windows.Forms.Label();
            this.btn_AdItemAnalise = new System.Windows.Forms.Button();
            this.btn_LimparLaudo = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.l_Laudo = new System.Windows.Forms.Label();
            this.clb_Laudo = new System.Windows.Forms.CheckedListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_Observacao = new System.Windows.Forms.TextBox();
            this.l_Observacoes = new System.Windows.Forms.Label();
            this.btn_SalvarLaudo = new System.Windows.Forms.Button();
            this.btn_NovoLaudo = new System.Windows.Forms.Button();
            this.btn_AlterText = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_MudarDados);
            this.panel1.Controls.Add(this.tb_DadosPac);
            this.panel1.Controls.Add(this.l_DadosPac);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 135);
            this.panel1.TabIndex = 0;
            // 
            // btn_MudarDados
            // 
            this.btn_MudarDados.Location = new System.Drawing.Point(6, 106);
            this.btn_MudarDados.Name = "btn_MudarDados";
            this.btn_MudarDados.Size = new System.Drawing.Size(94, 23);
            this.btn_MudarDados.TabIndex = 2;
            this.btn_MudarDados.Text = "Mudar os dados";
            this.btn_MudarDados.UseVisualStyleBackColor = true;
            this.btn_MudarDados.Click += new System.EventHandler(this.btn_MudarDados_Click);
            // 
            // tb_DadosPac
            // 
            this.tb_DadosPac.Location = new System.Drawing.Point(6, 23);
            this.tb_DadosPac.Multiline = true;
            this.tb_DadosPac.Name = "tb_DadosPac";
            this.tb_DadosPac.ReadOnly = true;
            this.tb_DadosPac.Size = new System.Drawing.Size(353, 77);
            this.tb_DadosPac.TabIndex = 1;
            // 
            // l_DadosPac
            // 
            this.l_DadosPac.AutoSize = true;
            this.l_DadosPac.Location = new System.Drawing.Point(3, 7);
            this.l_DadosPac.Name = "l_DadosPac";
            this.l_DadosPac.Size = new System.Drawing.Size(97, 13);
            this.l_DadosPac.TabIndex = 0;
            this.l_DadosPac.Text = "Dados do paciente";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.l_Dentes);
            this.panel2.Controls.Add(this.clb_Dentes);
            this.panel2.Location = new System.Drawing.Point(4, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 217);
            this.panel2.TabIndex = 1;
            // 
            // l_Dentes
            // 
            this.l_Dentes.AutoSize = true;
            this.l_Dentes.Location = new System.Drawing.Point(6, 4);
            this.l_Dentes.Name = "l_Dentes";
            this.l_Dentes.Size = new System.Drawing.Size(41, 13);
            this.l_Dentes.TabIndex = 1;
            this.l_Dentes.Text = "Dentes";
            // 
            // clb_Dentes
            // 
            this.clb_Dentes.ColumnWidth = 50;
            this.clb_Dentes.FormattingEnabled = true;
            this.clb_Dentes.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "51",
            "52",
            "53",
            "54",
            "55",
            "61",
            "62",
            "63",
            "64",
            "65",
            "71",
            "72",
            "73",
            "74",
            "75",
            "81",
            "82",
            "83",
            "84",
            "85"});
            this.clb_Dentes.Location = new System.Drawing.Point(9, 20);
            this.clb_Dentes.Margin = new System.Windows.Forms.Padding(10);
            this.clb_Dentes.MultiColumn = true;
            this.clb_Dentes.Name = "clb_Dentes";
            this.clb_Dentes.Size = new System.Drawing.Size(350, 184);
            this.clb_Dentes.TabIndex = 0;
            // 
            // clb_ListaLaudo
            // 
            this.clb_ListaLaudo.FormattingEnabled = true;
            this.clb_ListaLaudo.Location = new System.Drawing.Point(0, 25);
            this.clb_ListaLaudo.Name = "clb_ListaLaudo";
            this.clb_ListaLaudo.Size = new System.Drawing.Size(242, 319);
            this.clb_ListaLaudo.TabIndex = 0;
            this.clb_ListaLaudo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_ListaLaudo_ItemCheck);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_AlterText);
            this.panel3.Controls.Add(this.l_Analise);
            this.panel3.Controls.Add(this.clb_ListaLaudo);
            this.panel3.Controls.Add(this.btn_AdItemAnalise);
            this.panel3.Location = new System.Drawing.Point(376, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 358);
            this.panel3.TabIndex = 2;
            // 
            // l_Analise
            // 
            this.l_Analise.AutoSize = true;
            this.l_Analise.Location = new System.Drawing.Point(-3, 7);
            this.l_Analise.Name = "l_Analise";
            this.l_Analise.Size = new System.Drawing.Size(41, 13);
            this.l_Analise.TabIndex = 1;
            this.l_Analise.Text = "Analise";
            // 
            // btn_AdItemAnalise
            // 
            this.btn_AdItemAnalise.AutoSize = true;
            this.btn_AdItemAnalise.Location = new System.Drawing.Point(143, 0);
            this.btn_AdItemAnalise.Name = "btn_AdItemAnalise";
            this.btn_AdItemAnalise.Size = new System.Drawing.Size(99, 23);
            this.btn_AdItemAnalise.TabIndex = 6;
            this.btn_AdItemAnalise.Text = "Adicionar dados";
            this.btn_AdItemAnalise.UseVisualStyleBackColor = true;
            this.btn_AdItemAnalise.Click += new System.EventHandler(this.btn_AdItemAnalise_Click);
            // 
            // btn_LimparLaudo
            // 
            this.btn_LimparLaudo.Location = new System.Drawing.Point(529, 431);
            this.btn_LimparLaudo.Name = "btn_LimparLaudo";
            this.btn_LimparLaudo.Size = new System.Drawing.Size(95, 29);
            this.btn_LimparLaudo.TabIndex = 7;
            this.btn_LimparLaudo.Text = "Limpar laudo";
            this.btn_LimparLaudo.UseVisualStyleBackColor = true;
            this.btn_LimparLaudo.Click += new System.EventHandler(this.btn_LimparLaudo_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.AutoSize = true;
            this.btn_Inserir.Location = new System.Drawing.Point(529, 361);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(95, 29);
            this.btn_Inserir.TabIndex = 4;
            this.btn_Inserir.Text = "Inserir no laudo";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.AutoSize = true;
            this.btn_Deletar.ForeColor = System.Drawing.Color.Black;
            this.btn_Deletar.Location = new System.Drawing.Point(529, 396);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(95, 29);
            this.btn_Deletar.TabIndex = 5;
            this.btn_Deletar.Text = "Deletar do laudo";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.l_Laudo);
            this.panel4.Controls.Add(this.clb_Laudo);
            this.panel4.Location = new System.Drawing.Point(645, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 536);
            this.panel4.TabIndex = 3;
            // 
            // l_Laudo
            // 
            this.l_Laudo.AutoSize = true;
            this.l_Laudo.Location = new System.Drawing.Point(-3, 7);
            this.l_Laudo.Name = "l_Laudo";
            this.l_Laudo.Size = new System.Drawing.Size(37, 13);
            this.l_Laudo.TabIndex = 1;
            this.l_Laudo.Text = "Laudo";
            // 
            // clb_Laudo
            // 
            this.clb_Laudo.FormattingEnabled = true;
            this.clb_Laudo.Location = new System.Drawing.Point(0, 25);
            this.clb_Laudo.Name = "clb_Laudo";
            this.clb_Laudo.Size = new System.Drawing.Size(342, 499);
            this.clb_Laudo.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tb_Observacao);
            this.panel5.Controls.Add(this.l_Observacoes);
            this.panel5.Location = new System.Drawing.Point(4, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(501, 172);
            this.panel5.TabIndex = 8;
            // 
            // tb_Observacao
            // 
            this.tb_Observacao.Location = new System.Drawing.Point(9, 26);
            this.tb_Observacao.MaxLength = 10000;
            this.tb_Observacao.Multiline = true;
            this.tb_Observacao.Name = "tb_Observacao";
            this.tb_Observacao.Size = new System.Drawing.Size(489, 133);
            this.tb_Observacao.TabIndex = 1;
            // 
            // l_Observacoes
            // 
            this.l_Observacoes.AutoSize = true;
            this.l_Observacoes.Location = new System.Drawing.Point(6, 9);
            this.l_Observacoes.Name = "l_Observacoes";
            this.l_Observacoes.Size = new System.Drawing.Size(70, 13);
            this.l_Observacoes.TabIndex = 0;
            this.l_Observacoes.Text = "Observações";
            // 
            // btn_SalvarLaudo
            // 
            this.btn_SalvarLaudo.Location = new System.Drawing.Point(529, 506);
            this.btn_SalvarLaudo.Name = "btn_SalvarLaudo";
            this.btn_SalvarLaudo.Size = new System.Drawing.Size(95, 34);
            this.btn_SalvarLaudo.TabIndex = 9;
            this.btn_SalvarLaudo.Text = "Salvar laudo";
            this.btn_SalvarLaudo.UseVisualStyleBackColor = true;
            this.btn_SalvarLaudo.Click += new System.EventHandler(this.btn_SalvarLaudo_Click);
            // 
            // btn_NovoLaudo
            // 
            this.btn_NovoLaudo.Location = new System.Drawing.Point(529, 466);
            this.btn_NovoLaudo.Name = "btn_NovoLaudo";
            this.btn_NovoLaudo.Size = new System.Drawing.Size(95, 26);
            this.btn_NovoLaudo.TabIndex = 10;
            this.btn_NovoLaudo.Text = "Novo laudo";
            this.btn_NovoLaudo.UseVisualStyleBackColor = true;
            this.btn_NovoLaudo.Click += new System.EventHandler(this.btn_NovoLaudo_Click);
            // 
            // btn_AlterText
            // 
            this.btn_AlterText.Location = new System.Drawing.Point(73, 0);
            this.btn_AlterText.Name = "btn_AlterText";
            this.btn_AlterText.Size = new System.Drawing.Size(99, 23);
            this.btn_AlterText.TabIndex = 7;
            this.btn_AlterText.Text = "Alterar texto";
            this.btn_AlterText.UseVisualStyleBackColor = true;
            this.btn_AlterText.Visible = false;
            this.btn_AlterText.Click += new System.EventHandler(this.btn_AlterText_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1002, 552);
            this.Controls.Add(this.btn_NovoLaudo);
            this.Controls.Add(this.btn_LimparLaudo);
            this.Controls.Add(this.btn_SalvarLaudo);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = global::NERO.Properties.Resources.Tooth;
            this.Name = "Form_Principal";
            this.Text = "Laudo Radiografico - NERO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.Shown += new System.EventHandler(this.Form_Principal_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_MudarDados;
        private System.Windows.Forms.TextBox tb_DadosPac;
        private System.Windows.Forms.Label l_DadosPac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label l_Dentes;
        private System.Windows.Forms.CheckedListBox clb_Dentes;
        private System.Windows.Forms.CheckedListBox clb_ListaLaudo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label l_Analise;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label l_Laudo;
        private System.Windows.Forms.CheckedListBox clb_Laudo;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_AdItemAnalise;
        private System.Windows.Forms.Button btn_LimparLaudo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_Observacao;
        private System.Windows.Forms.Label l_Observacoes;
        private System.Windows.Forms.Button btn_SalvarLaudo;
        private System.Windows.Forms.Button btn_NovoLaudo;
        private System.Windows.Forms.Button btn_AlterText;
    }
}

