using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

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
    public partial class Form_IdPac : Form
    {
        Form_Principal principalForm;
        //Flag para saber se a lista de dentistas teve alguma mudança (foi adicionado um item)
        public bool hasChanged;

        /// <summary>
        /// Inicia o form de identificação do paciente e seta os valores default dos comboBox
        /// </summary>
        /// <param name="f"></param>
        public Form_IdPac(Form_Principal f)
        {
            InitializeComponent();
            cbb_Dentistas_Fill();
            this.cbb_Dentistas.SelectedIndex = 0;
            this.cbb_Indicacao.SelectedIndex = 0;
            this.cbb_TRadiografia.SelectedIndex = 0;
            this.l_TRadiog_validation.Visible = false;
            this.l_Dentista_Validation.Visible = false;
            this.principalForm = f;
            this.hasChanged = false;
        }

        /// <summary>
        /// Valida se o tipo de radiografia foi selecionado
        /// Se sim, monta a string de identificação do paciente a ser colocada como cabeçalho
        /// do laudo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_IdOk_Click(object sender, EventArgs e)
        {
            if (this.cbb_Dentistas.SelectedIndex == 0 || string.IsNullOrEmpty(this.cbb_Dentistas.Text))
            {
                this.l_Dentista_Validation.Text = "Favor selecionar um dentista";
                this.l_Dentista_Validation.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
                this.l_Dentista_Validation.Visible = true;
            }
            else if (this.cbb_TRadiografia.SelectedIndex == 0)
            {
                this.l_TRadiog_validation.Text = "Favor marcar o tipo da radiografia";
                this.l_TRadiog_validation.Visible = true;
            }
            else
            {
                //nome
                string identification = this.tb_Nome.Text;
                if (identification.Length < 45)
                    identification += "\t\t\t\t\t";
                else if (identification.Length < 90)
                    identification += "\t\t\t\t";
                else
                    identification += "\t\t\t";
                //idade
                identification += this.tb_Idade.Text + System.Environment.NewLine;
                //dentista
                identification += this.cbb_Indicacao.SelectedItem + " " + this.cbb_Dentistas.Text + System.Environment.NewLine;
                //Comentado em 21/09/2013
                //identification += this.cbb_Indicacao.SelectedItem + " " + this.tb_Indicacao.Text + System.Environment.NewLine;

                //tipo de radiografia
                identification += this.cbb_TRadiografia.SelectedItem + "\t\t\t\t\t\t\t";
                //data
                //03/12/2013
                //adicionado a string date, a fim de formata-la depois para ser usada para compor o nome do laudo
                string date = this.dateTimePicker1.Value.ToString("d", CultureInfo.CreateSpecificCulture("pt-BR"));
                identification += date + System.Environment.NewLine;

                //03/12/2013 Nova composição do nome do laudo = nome_paciente + data
                string fileName = this.tb_Nome + "_" + date.Replace("/", "");

                principalForm.UpdateIdentification(identification, fileName);
                this.l_TRadiog_validation.Visible = false;
                this.Close();
            }
        }

        /// <summary>
        /// Ao mudar o valor do comboBox de tipo de radiografia,
        /// valida se o tipo selecionado é diferente de "-- Selecione --"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_TRadiografia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbb_TRadiografia.SelectedIndex != 0)
                this.l_TRadiog_validation.Visible = false;
            else
            {
                this.l_TRadiog_validation.Text = "Favor marcar o tipo da radiografia";
                this.l_TRadiog_validation.Visible = true;
            }
        }

        /// <summary>
        /// Preenche o comboBox com o nome dos dentistas
        /// </summary>
        private void cbb_Dentistas_Fill()
        {
            string strPathFile = @"C:\Documents and Settings\Marcílio\Meus documentos\Laudos_Nero\Programa\Laudo\Settings\ListaDentistas.txt";
            //NOVO 03/12
            //string strPathFile = @"C:\Users\Laura\Laudo\ListaDentistas.txt";

            List<string> items = new List<string>();

            using (FileStream fs = File.Open(strPathFile, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        items.Add(line);
                        line = "";
                    }
                }
            }

            //ordena a lista alfabeticamente
            var sortedList = (from string s in items select s).OrderBy(s => s).ToArray();
            cbb_Dentistas.Items.AddRange(sortedList);
        }

        /// <summary>
        /// Ao se fechar o form, verifica se houve alguma inclusão na lista de dentistas
        /// se sim, resalva a lista com suas alterações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_IdPac_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChanged)
            {
                string strPathFile = @"C:\Documents and Settings\Marcílio\Meus documentos\Laudos_Nero\Programa\Laudo\Settings\ListaDentistas.txt";
                //NOVO 03/12
                //string strPathFile = @"C:\Users\Laura\Laudo\ListaDentistas.txt";
                using (FileStream fs = File.Create(strPathFile))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //Uso o método Write para escrever algo em nosso arquivo texto
                        //sw.Write("Texto adicionado ao exemplo!");

                        foreach (Object c in cbb_Dentistas.Items)
                        {
                            sw.WriteLine(c.ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Adiciona um novo dentista à lista de dentistas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddDentista_Click(object sender, EventArgs e)
        {
            string dentista = cbb_Dentistas.Text;
            if (!string.IsNullOrEmpty(dentista))
            {
                if(!Dentist_Already_Added(dentista))
                {
                    cbb_Dentistas.Items.Insert(1, dentista);
                    hasChanged = true;

                    //label de validação
                    this.l_Dentista_Validation.Text = "Novo dentista inserido!";
                    this.l_Dentista_Validation.ForeColor = Color.Green;
                    this.l_Dentista_Validation.Visible = true;
                }
                else
                {
                    //label de validação
                    this.l_Dentista_Validation.Text = "Dentista já existente na lista!";
                    this.l_Dentista_Validation.ForeColor = Color.Blue;
                    this.l_Dentista_Validation.Visible = true;
                }
            }
            else
                cbb_Dentistas.SelectedIndex = 0;

        }

        /// <summary>
        /// Ao mudar o valor do comboBox dos dentistas,
        /// valida se o tipo selecionado é diferente de "-- Selecione --"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_Dentistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbb_Dentistas.SelectedIndex != 0)
                this.l_Dentista_Validation.Visible = false;
            else
            {
                this.l_Dentista_Validation.Text = "Favor selecionar um dentista";
                this.l_Dentista_Validation.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
                this.l_Dentista_Validation.Visible = true;
            }
        }

        private void cbb_Dentistas_MouseClick(object sender, MouseEventArgs e)
        {
            this.l_Dentista_Validation.Visible = false;
        }

        /// <summary>
        /// Remove o dentista selecionado da lista atual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DelDentista_Click(object sender, EventArgs e)
        {
            string dentista = cbb_Dentistas.Text;
            if (!string.IsNullOrEmpty(dentista))
            {
                cbb_Dentistas.Items.Remove(dentista);
                hasChanged = true;

                //label de validação
                this.l_Dentista_Validation.Text = "Dentista removido da lista!";
                this.l_Dentista_Validation.ForeColor = Color.Green;
                this.l_Dentista_Validation.Visible = true;
            }

            cbb_Dentistas.SelectedIndex = 0;
        }

        /// <summary>
        /// Verifica se o dentista já foi inserido na lista, a fim de evitar duplicações
        /// </summary>
        /// <param name="dentist"></param>
        /// <returns></returns>
        private bool Dentist_Already_Added(string dentist)
        {
            foreach (String str in cbb_Dentistas.Items)
            {
                if (string.Equals(dentist, str))
                    return true;
            }
            return false;
        }

    }
}
