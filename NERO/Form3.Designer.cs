namespace NERO
{
    partial class Form_AdAnalise
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
            this.l_Analise = new System.Windows.Forms.Label();
            this.tb_AdAnalise = new System.Windows.Forms.TextBox();
            this.l_Obs = new System.Windows.Forms.Label();
            this.btn_AdItem = new System.Windows.Forms.Button();
            this.btn_AdOk = new System.Windows.Forms.Button();
            this.l_ItemAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_Analise
            // 
            this.l_Analise.AutoSize = true;
            this.l_Analise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Analise.Location = new System.Drawing.Point(13, 13);
            this.l_Analise.Name = "l_Analise";
            this.l_Analise.Size = new System.Drawing.Size(315, 30);
            this.l_Analise.TabIndex = 0;
            this.l_Analise.Text = "Digite abaixo o texto do novo item e clique em Adicionar.\r\nQuando terminar, cliqu" +
                "e em OK";
            // 
            // tb_AdAnalise
            // 
            this.tb_AdAnalise.Location = new System.Drawing.Point(16, 74);
            this.tb_AdAnalise.MaxLength = 255;
            this.tb_AdAnalise.Multiline = true;
            this.tb_AdAnalise.Name = "tb_AdAnalise";
            this.tb_AdAnalise.Size = new System.Drawing.Size(357, 87);
            this.tb_AdAnalise.TabIndex = 1;
            // 
            // l_Obs
            // 
            this.l_Obs.AutoSize = true;
            this.l_Obs.Location = new System.Drawing.Point(13, 58);
            this.l_Obs.Name = "l_Obs";
            this.l_Obs.Size = new System.Drawing.Size(106, 13);
            this.l_Obs.TabIndex = 2;
            this.l_Obs.Text = "(max 255 caracteres)";
            // 
            // btn_AdItem
            // 
            this.btn_AdItem.Location = new System.Drawing.Point(105, 199);
            this.btn_AdItem.Name = "btn_AdItem";
            this.btn_AdItem.Size = new System.Drawing.Size(75, 23);
            this.btn_AdItem.TabIndex = 3;
            this.btn_AdItem.Text = "Adicionar";
            this.btn_AdItem.UseVisualStyleBackColor = true;
            this.btn_AdItem.Click += new System.EventHandler(this.btn_AdItem_Click);
            // 
            // btn_AdOk
            // 
            this.btn_AdOk.Location = new System.Drawing.Point(209, 199);
            this.btn_AdOk.Name = "btn_AdOk";
            this.btn_AdOk.Size = new System.Drawing.Size(75, 23);
            this.btn_AdOk.TabIndex = 4;
            this.btn_AdOk.Text = "OK";
            this.btn_AdOk.UseVisualStyleBackColor = true;
            this.btn_AdOk.Click += new System.EventHandler(this.btn_AdOk_Click);
            // 
            // l_ItemAd
            // 
            this.l_ItemAd.AutoSize = true;
            this.l_ItemAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ItemAd.ForeColor = System.Drawing.Color.Green;
            this.l_ItemAd.Location = new System.Drawing.Point(13, 164);
            this.l_ItemAd.Name = "l_ItemAd";
            this.l_ItemAd.Size = new System.Drawing.Size(47, 15);
            this.l_ItemAd.TabIndex = 5;
            this.l_ItemAd.Text = "label1";
            // 
            // Form_AdAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 234);
            this.Controls.Add(this.l_ItemAd);
            this.Controls.Add(this.btn_AdOk);
            this.Controls.Add(this.btn_AdItem);
            this.Controls.Add(this.l_Obs);
            this.Controls.Add(this.tb_AdAnalise);
            this.Controls.Add(this.l_Analise);
            this.Name = "Form_AdAnalise";
            this.Text = "Adicionar analise";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Icon = NERO.Properties.Resources.Tooth;

        }

        #endregion

        private System.Windows.Forms.Label l_Analise;
        private System.Windows.Forms.TextBox tb_AdAnalise;
        private System.Windows.Forms.Label l_Obs;
        private System.Windows.Forms.Button btn_AdItem;
        private System.Windows.Forms.Button btn_AdOk;
        private System.Windows.Forms.Label l_ItemAd;
    }
}