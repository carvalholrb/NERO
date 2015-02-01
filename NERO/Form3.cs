using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/************************************
 * 21/09/2013 - Nero Laudo Radiográfico v1.5
 * Por: Laura Carvalho
 * Inclusão no form de Identificação do paciente o comboBox com a lista dos dentisdas disponíveis
 * a serem selecionados
 * e funçoes e validações necessárias para o funcionamento desta funcionalidade
*************************************/
/************************************
 * 17/06/2014 - Nero Laudo Radiográfico v1.7
 * Por: Laura Carvalho
 * Inclusão da função para evitar duplicação de cadastro de dentistas
 * Inclusão do icone
*************************************/

namespace NERO
{
    public partial class Form_AdAnalise : Form
    {
        Form_Principal principalF;

        public Form_AdAnalise(Form_Principal fp)
        {
            InitializeComponent();
            principalF = fp;
            l_ItemAd.Text = "";
            this.tb_AdAnalise.GotFocus += new EventHandler(tb_AdAnalise_GotFocus);
        }

        /// <summary>
        /// Limpa a mensagem de item adicionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tb_AdAnalise_GotFocus(object sender, EventArgs e)
        {
            l_ItemAd.Text = "";
        }

        /// <summary>
        /// Fecha o form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Recupera o valor do textbox e chama a função para adicionar o item na lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AdItem_Click(object sender, EventArgs e)
        {
            this.principalF.InsertCheckBoxItem(tb_AdAnalise.Text);
            //MessageBox.Show("Item added!");
            l_ItemAd.Text = "Item adicionado";
            tb_AdAnalise.Text = "";
        }
    }
}
