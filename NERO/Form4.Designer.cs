namespace NERO
{
    partial class Form4
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
            this.l_TRadiog_validation = new System.Windows.Forms.Label();
            this.cbb_TRadiografia = new System.Windows.Forms.ComboBox();
            this.l_TRadiografia = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.l_Data = new System.Windows.Forms.Label();
            this.tb_Idade = new System.Windows.Forms.TextBox();
            this.l_Idade = new System.Windows.Forms.Label();
            this.tb_Indicacao = new System.Windows.Forms.TextBox();
            this.cbb_Indicacao = new System.Windows.Forms.ComboBox();
            this.l_Indicacao = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.l_Nome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_Dentes = new System.Windows.Forms.Label();
            this.clb_Dentes = new System.Windows.Forms.CheckedListBox();
            this.l_Analise = new System.Windows.Forms.Label();
            this.clb_ListaLaudo = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_TRadiog_validation
            // 
            this.l_TRadiog_validation.AutoSize = true;
            this.l_TRadiog_validation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.l_TRadiog_validation.Location = new System.Drawing.Point(296, 137);
            this.l_TRadiog_validation.Name = "l_TRadiog_validation";
            this.l_TRadiog_validation.Size = new System.Drawing.Size(35, 13);
            this.l_TRadiog_validation.TabIndex = 23;
            this.l_TRadiog_validation.Text = "label1";
            // 
            // cbb_TRadiografia
            // 
            this.cbb_TRadiografia.FormattingEnabled = true;
            this.cbb_TRadiografia.Items.AddRange(new object[] {
            "-- Selecione --",
            "Panorâmica",
            "Periapical",
            "ATM"});
            this.cbb_TRadiografia.Location = new System.Drawing.Point(299, 113);
            this.cbb_TRadiografia.Name = "cbb_TRadiografia";
            this.cbb_TRadiografia.Size = new System.Drawing.Size(177, 21);
            this.cbb_TRadiografia.TabIndex = 22;
            // 
            // l_TRadiografia
            // 
            this.l_TRadiografia.AutoSize = true;
            this.l_TRadiografia.Location = new System.Drawing.Point(296, 94);
            this.l_TRadiografia.Name = "l_TRadiografia";
            this.l_TRadiografia.Size = new System.Drawing.Size(95, 13);
            this.l_TRadiografia.TabIndex = 21;
            this.l_TRadiografia.Text = "Tipo de radiografia";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // l_Data
            // 
            this.l_Data.AutoSize = true;
            this.l_Data.Location = new System.Drawing.Point(148, 94);
            this.l_Data.Name = "l_Data";
            this.l_Data.Size = new System.Drawing.Size(30, 13);
            this.l_Data.TabIndex = 19;
            this.l_Data.Text = "Data";
            // 
            // tb_Idade
            // 
            this.tb_Idade.Location = new System.Drawing.Point(5, 110);
            this.tb_Idade.MaxLength = 100;
            this.tb_Idade.Name = "tb_Idade";
            this.tb_Idade.Size = new System.Drawing.Size(105, 20);
            this.tb_Idade.TabIndex = 18;
            // 
            // l_Idade
            // 
            this.l_Idade.AutoSize = true;
            this.l_Idade.Location = new System.Drawing.Point(2, 94);
            this.l_Idade.Name = "l_Idade";
            this.l_Idade.Size = new System.Drawing.Size(34, 13);
            this.l_Idade.TabIndex = 17;
            this.l_Idade.Text = "Idade";
            // 
            // tb_Indicacao
            // 
            this.tb_Indicacao.Location = new System.Drawing.Point(65, 68);
            this.tb_Indicacao.MaxLength = 255;
            this.tb_Indicacao.Name = "tb_Indicacao";
            this.tb_Indicacao.Size = new System.Drawing.Size(411, 20);
            this.tb_Indicacao.TabIndex = 16;
            // 
            // cbb_Indicacao
            // 
            this.cbb_Indicacao.FormattingEnabled = true;
            this.cbb_Indicacao.Items.AddRange(new object[] {
            "Dr.",
            "Dra."});
            this.cbb_Indicacao.Location = new System.Drawing.Point(5, 67);
            this.cbb_Indicacao.Name = "cbb_Indicacao";
            this.cbb_Indicacao.Size = new System.Drawing.Size(54, 21);
            this.cbb_Indicacao.TabIndex = 15;
            // 
            // l_Indicacao
            // 
            this.l_Indicacao.AutoSize = true;
            this.l_Indicacao.Location = new System.Drawing.Point(2, 51);
            this.l_Indicacao.Name = "l_Indicacao";
            this.l_Indicacao.Size = new System.Drawing.Size(54, 13);
            this.l_Indicacao.TabIndex = 14;
            this.l_Indicacao.Text = "Indicação";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(5, 25);
            this.tb_Nome.MaxLength = 255;
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(471, 20);
            this.tb_Nome.TabIndex = 13;
            // 
            // l_Nome
            // 
            this.l_Nome.AutoSize = true;
            this.l_Nome.Location = new System.Drawing.Point(2, 9);
            this.l_Nome.Name = "l_Nome";
            this.l_Nome.Size = new System.Drawing.Size(35, 13);
            this.l_Nome.TabIndex = 12;
            this.l_Nome.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.l_Analise);
            this.panel1.Controls.Add(this.clb_ListaLaudo);
            this.panel1.Controls.Add(this.l_Dentes);
            this.panel1.Controls.Add(this.clb_Dentes);
            this.panel1.Location = new System.Drawing.Point(5, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 306);
            this.panel1.TabIndex = 24;
            // 
            // l_Dentes
            // 
            this.l_Dentes.AutoSize = true;
            this.l_Dentes.Location = new System.Drawing.Point(3, 0);
            this.l_Dentes.Name = "l_Dentes";
            this.l_Dentes.Size = new System.Drawing.Size(41, 13);
            this.l_Dentes.TabIndex = 3;
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
            this.clb_Dentes.Location = new System.Drawing.Point(0, 17);
            this.clb_Dentes.Margin = new System.Windows.Forms.Padding(10);
            this.clb_Dentes.MultiColumn = true;
            this.clb_Dentes.Name = "clb_Dentes";
            this.clb_Dentes.Size = new System.Drawing.Size(160, 289);
            this.clb_Dentes.TabIndex = 2;
            // 
            // l_Analise
            // 
            this.l_Analise.AutoSize = true;
            this.l_Analise.Location = new System.Drawing.Point(182, -1);
            this.l_Analise.Name = "l_Analise";
            this.l_Analise.Size = new System.Drawing.Size(41, 13);
            this.l_Analise.TabIndex = 5;
            this.l_Analise.Text = "Analise";
            // 
            // clb_ListaLaudo
            // 
            this.clb_ListaLaudo.FormattingEnabled = true;
            this.clb_ListaLaudo.Location = new System.Drawing.Point(185, 17);
            this.clb_ListaLaudo.Name = "clb_ListaLaudo";
            this.clb_ListaLaudo.Size = new System.Drawing.Size(272, 289);
            this.clb_ListaLaudo.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l_TRadiog_validation);
            this.Controls.Add(this.cbb_TRadiografia);
            this.Controls.Add(this.l_TRadiografia);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.l_Data);
            this.Controls.Add(this.tb_Idade);
            this.Controls.Add(this.l_Idade);
            this.Controls.Add(this.tb_Indicacao);
            this.Controls.Add(this.cbb_Indicacao);
            this.Controls.Add(this.l_Indicacao);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.l_Nome);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_TRadiog_validation;
        private System.Windows.Forms.ComboBox cbb_TRadiografia;
        private System.Windows.Forms.Label l_TRadiografia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label l_Data;
        private System.Windows.Forms.TextBox tb_Idade;
        private System.Windows.Forms.Label l_Idade;
        private System.Windows.Forms.TextBox tb_Indicacao;
        private System.Windows.Forms.ComboBox cbb_Indicacao;
        private System.Windows.Forms.Label l_Indicacao;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label l_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_Dentes;
        private System.Windows.Forms.CheckedListBox clb_Dentes;
        private System.Windows.Forms.Label l_Analise;
        private System.Windows.Forms.CheckedListBox clb_ListaLaudo;
    }
}