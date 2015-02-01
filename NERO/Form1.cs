using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;

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
    public partial class Form_Principal : Form
    {
        #region Variables

        private string reportsName;
        private List<int> clicksOrder;
        //Flag para saber se a lista de analise teve alguma mudança (foi adicionado um item)
        public bool hasChanged;
        string path = System.Environment.GetEnvironmentVariable("homepath");

        private const string InstallPath = "C:\Documents and Settings\Marcílio\Meus documentos\Laudos_Nero";
        private const string SettingsPath = "\Programa\Laudo\Settings\";
        private const string LaudoPath = "\Programa\Laudo\";

        #endregion

        #region Public Methods

        public Form_Principal()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            hasChanged = false;
        }

        /// <summary>
        /// Atualiza a identificação do paciente
        /// </summary>
        /// <param name="identificationData">String com todos os dados do paciente</param>
        /// <param name="name">Nome do paciente para salvar o laudo</param>
        public void UpdateIdentification(string identificationData, string name)
        {
            tb_DadosPac.Text = "";
            tb_DadosPac.Text = identificationData;
            this.reportsName = name;
        }

        //Insere um novo item na lista de analises
        public void InsertCheckBoxItem(string textItem)
        {
            clb_ListaLaudo.Items.Add(textItem);
            hasChanged = true;
        }

        #endregion

        #region Private Methods

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            //string strPathFile = @"InstallPath\Programa\Laudo\Settings\ListaLaudo.txt";
            //NOVO 03/12
            string strPathFile = path + @"\Laudo\ListaLaudo.txt";
            strPathFile = Properties.Resources.ListaLaudo.;
            List<string> items = new List<string>();

            using (FileStream fs = File.Open(strPathFile, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        //clb_ListaLaudo.Items.Add(line);
                        items.Add(line);
                        line = "";
                    }
                }
            }

            //ordena a lista alfabeticamente
            var sortedList = (from string s in items select s).OrderBy(s => s).ToArray();
            clb_ListaLaudo.Items.AddRange(sortedList);

            this.SendToBack();
            this.reportsName = "";
            this.clicksOrder = new List<int>();
        }

        /// <summary>
        /// Assim que o form principal termina de carregar, chama o form de Identificação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Principal_Shown(object sender, EventArgs e)
        {
            btn_MudarDados_Click(sender, e);
        }

        /// <summary>
        /// Chama o form para inserir os dados de identificação do paciente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MudarDados_Click(object sender, EventArgs e)
        {
            Form_IdPac fIdentificacao = new Form_IdPac(this);
            fIdentificacao.WindowState = FormWindowState.Normal;
            fIdentificacao.BringToFront();
            fIdentificacao.StartPosition = FormStartPosition.CenterScreen;
            fIdentificacao.Show();
        }

        /// <summary>
        /// Insere os dados dos itens selecionados em uma lista de checkbox
        /// que representa o laudo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            string numbers = "";
            string report = "";

            //insere os numeros dos dentes
            for (int i = 0; i < clb_Dentes.Items.Count; i++)
                if (clb_Dentes.GetItemChecked(i))
                    numbers += (string)clb_Dentes.Items[i] + ",";

            //insere a analise feita na ordem clicada
            for (int j = 0; j < clicksOrder.Count; j++)
            {
                report += (string)clb_ListaLaudo.Items[clicksOrder[j]];
                if (j == clicksOrder.Count - 1)
                    report += ";";
                else
                    report += ", ";
            }

            //limpa a lista de cliques
            clicksOrder.Clear();

            if (numbers != "" && report != "")
            {
                numbers = numbers.Remove(numbers.Length - 1);
                numbers += " - " + report;
                clb_Laudo.Items.Add(numbers);

                UndoSelection();
            }
            else
                MessageBox.Show("Está faltando informação! Para inserir a análise é necessário marcar os dentes e as descrições", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Desfaz a seleção dos itens da lista de dentes e análise
        /// </summary>
        private void UndoSelection()
        {
            //dentes
            for (int i = 0; i < clb_Dentes.Items.Count; i++)
                if (clb_Dentes.GetItemChecked(i))
                    clb_Dentes.SetItemCheckState(i, CheckState.Unchecked);

            //analise
            for (int i = 0; i < clb_ListaLaudo.Items.Count; i++)
                if (clb_ListaLaudo.GetItemChecked(i))
                    clb_ListaLaudo.SetItemCheckState(i, CheckState.Unchecked);
        }

        /// <summary>
        /// Remove os elementos selecionados da lista do laudo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_Laudo.Items.Count; i++)
                if (clb_Laudo.GetItemChecked(i))
                    clb_Laudo.Items.Remove(clb_Laudo.Items[i]);
        }

        private void btn_AdItemAnalise_Click(object sender, EventArgs e)
        {
            Form_AdAnalise fAnalise = new Form_AdAnalise(this);
            fAnalise.StartPosition = FormStartPosition.CenterScreen;
            fAnalise.Show();
        }

        private void btn_LimparLaudo_Click(object sender, EventArgs e)
        {
            clb_Laudo.Items.Clear();
        }

        private void Form_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChanged)
            {
                string strPathFile = @ + InstallPath + SettingsPath + "ListaLaudo.txt";
                //NOVO 03/12
                //string strPathFile = path + @"\Laudo\ListaLaudo.txt";
                using (FileStream fs = File.Create(strPathFile))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //Uso o método Write para escrever algo em nosso arquivo texto
                        //sw.Write("Texto adicionado ao exemplo!");

                        foreach (Object c in clb_ListaLaudo.Items)
                        {
                            sw.WriteLine(c.ToString());
                        }
                    }
                }
            }
        }

        private void btn_SalvarLaudo_Click(object sender, EventArgs e)
        {
            if (clb_Laudo.Items.Count == 0)
            {
                if (MessageBox.Show("O laudo atual não contém informações. Tem certeza que deseja salvá-lo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    savesWordReport();
                    MessageBox.Show("Laudo gerado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_NovoLaudo_Click(sender, e);
                }
            }
            else
            {
                savesWordReport();
                MessageBox.Show("Laudo gerado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_NovoLaudo_Click(sender, e);

            }
        }

        //Mounts a word document with the report
        private void savesWordReport()
        {
            #region Word

            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;
            object fileToSave;
            object template = InstallPath + SettingsPath + @"LaudoNERO.dotx";
            if (reportsName != "")
                fileToSave = InstallPath + LaudoPath + @"" + reportsName + ".doc";
            else
                fileToSave = InstallPath + LaudoPath + @"LaudoTemp.doc";

            Microsoft.Office.Interop.Word.ApplicationClass oWordApp = new Microsoft.Office.Interop.Word.ApplicationClass();

            //Usando template
            Microsoft.Office.Interop.Word.Document oWordDoc = oWordApp.Documents.Add(ref template,
                                       ref missing, ref missing, ref missing);

            //Funcionando antes do template
            //Microsoft.Office.Interop.Word.Document oWordDoc = oWordApp.Documents.Add(ref missing,
            //                           ref missing, ref missing, ref missing);

            oWordDoc.Activate();
            //removes the space after a paragraph
            oWordDoc.Paragraphs.SpaceAfter = 0;
            //make the aligment justify
            //oWordDoc.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            oWordDoc.ActiveWindow.Selection.Font.Name = "Times New Roman";
            oWordDoc.ActiveWindow.Selection.Font.Size = (float)12;

            //insert text into document
            oWordApp.Selection.TypeText(tb_DadosPac.Text);
            oWordApp.Selection.TypeParagraph();
            oWordApp.Selection.TypeParagraph();

            oWordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            oWordApp.Selection.TypeText("LAUDO RADIOGRAFICO");
            oWordApp.Selection.TypeParagraph();
            oWordApp.Selection.TypeParagraph();
            oWordApp.Selection.TypeText("Radiograficamente as imagens analisadas sugerem:");
            oWordApp.Selection.TypeParagraph();
            oWordApp.Selection.TypeParagraph();

            //make the aligment justify
            //oWordDoc.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            oWordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            //texto do laudo em si
            for (int i = 0; i < clb_Laudo.Items.Count; i++)
            {
                if (i == clb_Laudo.Items.Count - 1)
                {
                    string texto = (string)clb_Laudo.Items[i];
                    oWordApp.Selection.TypeText(texto.Remove(texto.Length - 1) + ".");
                }
                else
                    oWordApp.Selection.TypeText((string)clb_Laudo.Items[i]);

                oWordApp.Selection.TypeParagraph();
            }

            //se houver alguma observação escrita, inclui no laudo
            if (tb_Observacao.Text != "")
            {
                oWordApp.Selection.TypeParagraph();
                oWordApp.Selection.TypeParagraph();
                oWordApp.Selection.TypeText(tb_Observacao.Text);
            }

            //saves the document
            oWordDoc.SaveAs(ref fileToSave, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            oWordDoc.Close(ref missing, ref missing, ref missing);
            oWordApp.Quit(ref missing, ref missing, ref missing);

            #endregion
        }

        /// <summary>
        /// Limpa todas as atuais informações para iniciar um novo laudo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NovoLaudo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja iniciar um novo laudo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tb_DadosPac.Text = "";
                tb_Observacao.Text = "";
                UndoSelection();
                clb_Laudo.Items.Clear();
                btn_MudarDados_Click(sender, e);
            }

        }


        /// <summary>
        /// Se o item for selecionado, guarda o indice dele para imprimir na ordem de cliques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clb_ListaLaudo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                this.clicksOrder.Add(e.Index);
            else
                this.clicksOrder.Remove(e.Index);
        }

        #endregion

        /// <summary>
        /// Este botão será usado para alterar o texto de algum elemento selecionado na lista de analises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AlterText_Click(object sender, EventArgs e)
        {
            //clb_ListaLaudo.MouseDoubleClick += new MouseEventHandler(sender, e);

            //private void ReceiveCheckedChanged(object sender, EventArgs e)
            //{
            //   CheckBox chk = sender as CheckBox;
            //   if(chk.Checked)
            //       this.label1.Text = "Checked";
            //   else
            //       this.label1.Text = "UnChecked";
            //}
        }

        private void ConfigureFolderPath() 
        {
            //configurar o caminho de pasta de instalação?
            //como fazer isso na hora de instalar e pegar o caminho correto?

        }
    }
}
