namespace NERO
{
    partial class Form_IdPac
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
            this.l_Nome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.l_Indicacao = new System.Windows.Forms.Label();
            this.cbb_Indicacao = new System.Windows.Forms.ComboBox();
            this.l_Idade = new System.Windows.Forms.Label();
            this.tb_Idade = new System.Windows.Forms.TextBox();
            this.l_Data = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.l_TRadiografia = new System.Windows.Forms.Label();
            this.cbb_TRadiografia = new System.Windows.Forms.ComboBox();
            this.l_TRadiog_validation = new System.Windows.Forms.Label();
            this.btn_IdOk = new System.Windows.Forms.Button();
            this.cbb_Dentistas = new System.Windows.Forms.ComboBox();
            this.btn_AddDentista = new System.Windows.Forms.Button();
            this.l_Dentista_Validation = new System.Windows.Forms.Label();
            this.btn_DelDentista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Nome
            // 
            this.l_Nome.AutoSize = true;
            this.l_Nome.Location = new System.Drawing.Point(13, 13);
            this.l_Nome.Name = "l_Nome";
            this.l_Nome.Size = new System.Drawing.Size(35, 13);
            this.l_Nome.TabIndex = 0;
            this.l_Nome.Text = "Nome";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(16, 30);
            this.tb_Nome.MaxLength = 255;
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(562, 20);
            this.tb_Nome.TabIndex = 1;
            // 
            // l_Indicacao
            // 
            this.l_Indicacao.AutoSize = true;
            this.l_Indicacao.Location = new System.Drawing.Point(13, 67);
            this.l_Indicacao.Name = "l_Indicacao";
            this.l_Indicacao.Size = new System.Drawing.Size(54, 13);
            this.l_Indicacao.TabIndex = 2;
            this.l_Indicacao.Text = "Indicação";
            // 
            // cbb_Indicacao
            // 
            this.cbb_Indicacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Indicacao.FormattingEnabled = true;
            this.cbb_Indicacao.Items.AddRange(new object[] {
            "Dr.",
            "Dra."});
            this.cbb_Indicacao.Location = new System.Drawing.Point(16, 83);
            this.cbb_Indicacao.Name = "cbb_Indicacao";
            this.cbb_Indicacao.Size = new System.Drawing.Size(40, 21);
            this.cbb_Indicacao.TabIndex = 3;
            // 
            // l_Idade
            // 
            this.l_Idade.AutoSize = true;
            this.l_Idade.Location = new System.Drawing.Point(13, 126);
            this.l_Idade.Name = "l_Idade";
            this.l_Idade.Size = new System.Drawing.Size(34, 13);
            this.l_Idade.TabIndex = 5;
            this.l_Idade.Text = "Idade";
            // 
            // tb_Idade
            // 
            this.tb_Idade.Location = new System.Drawing.Point(16, 142);
            this.tb_Idade.MaxLength = 100;
            this.tb_Idade.Name = "tb_Idade";
            this.tb_Idade.Size = new System.Drawing.Size(134, 20);
            this.tb_Idade.TabIndex = 6;
            // 
            // l_Data
            // 
            this.l_Data.AutoSize = true;
            this.l_Data.Location = new System.Drawing.Point(190, 125);
            this.l_Data.Name = "l_Data";
            this.l_Data.Size = new System.Drawing.Size(30, 13);
            this.l_Data.TabIndex = 7;
            this.l_Data.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // l_TRadiografia
            // 
            this.l_TRadiografia.AutoSize = true;
            this.l_TRadiografia.Location = new System.Drawing.Point(361, 127);
            this.l_TRadiografia.Name = "l_TRadiografia";
            this.l_TRadiografia.Size = new System.Drawing.Size(95, 13);
            this.l_TRadiografia.TabIndex = 9;
            this.l_TRadiografia.Text = "Tipo de radiografia";
            // 
            // cbb_TRadiografia
            // 
            this.cbb_TRadiografia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TRadiografia.FormattingEnabled = true;
            this.cbb_TRadiografia.Items.AddRange(new object[] {
            "-- Selecione --",
            "Panorâmica",
            "Periapical",
            "Interproximal",
            "ATM"});
            this.cbb_TRadiografia.Location = new System.Drawing.Point(364, 142);
            this.cbb_TRadiografia.Name = "cbb_TRadiografia";
            this.cbb_TRadiografia.Size = new System.Drawing.Size(214, 21);
            this.cbb_TRadiografia.TabIndex = 10;
            this.cbb_TRadiografia.SelectedIndexChanged += new System.EventHandler(this.cbb_TRadiografia_SelectedIndexChanged);
            // 
            // l_TRadiog_validation
            // 
            this.l_TRadiog_validation.AutoSize = true;
            this.l_TRadiog_validation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.l_TRadiog_validation.Location = new System.Drawing.Point(361, 166);
            this.l_TRadiog_validation.Name = "l_TRadiog_validation";
            this.l_TRadiog_validation.Size = new System.Drawing.Size(35, 13);
            this.l_TRadiog_validation.TabIndex = 11;
            this.l_TRadiog_validation.Text = "label1";
            // 
            // btn_IdOk
            // 
            this.btn_IdOk.Location = new System.Drawing.Point(250, 191);
            this.btn_IdOk.Name = "btn_IdOk";
            this.btn_IdOk.Size = new System.Drawing.Size(75, 23);
            this.btn_IdOk.TabIndex = 12;
            this.btn_IdOk.Text = "OK";
            this.btn_IdOk.UseVisualStyleBackColor = true;
            this.btn_IdOk.Click += new System.EventHandler(this.btn_IdOk_Click);
            // 
            // cbb_Dentistas
            // 
            this.cbb_Dentistas.FormattingEnabled = true;
            this.cbb_Dentistas.Location = new System.Drawing.Point(62, 83);
            this.cbb_Dentistas.Name = "cbb_Dentistas";
            this.cbb_Dentistas.Size = new System.Drawing.Size(382, 21);
            this.cbb_Dentistas.TabIndex = 13;
            this.cbb_Dentistas.SelectedIndexChanged += new System.EventHandler(this.cbb_Dentistas_SelectedIndexChanged);
            this.cbb_Dentistas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbb_Dentistas_MouseClick);
            // 
            // btn_AddDentista
            // 
            this.btn_AddDentista.Location = new System.Drawing.Point(450, 83);
            this.btn_AddDentista.Name = "btn_AddDentista";
            this.btn_AddDentista.Size = new System.Drawing.Size(61, 23);
            this.btn_AddDentista.TabIndex = 14;
            this.btn_AddDentista.Text = "Adicionar";
            this.btn_AddDentista.UseVisualStyleBackColor = true;
            this.btn_AddDentista.Click += new System.EventHandler(this.btn_AddDentista_Click);
            // 
            // l_Dentista_Validation
            // 
            this.l_Dentista_Validation.AutoSize = true;
            this.l_Dentista_Validation.Location = new System.Drawing.Point(59, 107);
            this.l_Dentista_Validation.Name = "l_Dentista_Validation";
            this.l_Dentista_Validation.Size = new System.Drawing.Size(35, 13);
            this.l_Dentista_Validation.TabIndex = 15;
            this.l_Dentista_Validation.Text = "label1";
            // 
            // btn_DelDentista
            // 
            this.btn_DelDentista.Location = new System.Drawing.Point(517, 83);
            this.btn_DelDentista.Name = "btn_DelDentista";
            this.btn_DelDentista.Size = new System.Drawing.Size(61, 23);
            this.btn_DelDentista.TabIndex = 16;
            this.btn_DelDentista.Text = "Remover";
            this.btn_DelDentista.UseVisualStyleBackColor = true;
            this.btn_DelDentista.Click += new System.EventHandler(this.btn_DelDentista_Click);
            // 
            // Form_IdPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 226);
            this.Controls.Add(this.btn_DelDentista);
            this.Controls.Add(this.l_Dentista_Validation);
            this.Controls.Add(this.btn_AddDentista);
            this.Controls.Add(this.cbb_Dentistas);
            this.Controls.Add(this.btn_IdOk);
            this.Controls.Add(this.l_TRadiog_validation);
            this.Controls.Add(this.cbb_TRadiografia);
            this.Controls.Add(this.l_TRadiografia);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.l_Data);
            this.Controls.Add(this.tb_Idade);
            this.Controls.Add(this.l_Idade);
            this.Controls.Add(this.cbb_Indicacao);
            this.Controls.Add(this.l_Indicacao);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.l_Nome);
            this.Name = "Form_IdPac";
            this.Text = "Identificação do paciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_IdPac_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Icon = NERO.Properties.Resources.Tooth;

        }

        #endregion

        private System.Windows.Forms.Label l_Nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label l_Indicacao;
        private System.Windows.Forms.ComboBox cbb_Indicacao;
        private System.Windows.Forms.Label l_Idade;
        private System.Windows.Forms.TextBox tb_Idade;
        private System.Windows.Forms.Label l_Data;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label l_TRadiografia;
        private System.Windows.Forms.ComboBox cbb_TRadiografia;
        private System.Windows.Forms.Label l_TRadiog_validation;
        private System.Windows.Forms.Button btn_IdOk;
        private System.Windows.Forms.ComboBox cbb_Dentistas;
        private System.Windows.Forms.Button btn_AddDentista;
        private System.Windows.Forms.Label l_Dentista_Validation;
        private System.Windows.Forms.Button btn_DelDentista;
    }
}