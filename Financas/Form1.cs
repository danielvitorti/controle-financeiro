using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Financas
{
    public partial class frmLancamentos : Form
    {
        public frmLancamentos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Desabilita o botão OK
            DesabilitarBotaoOK();
            // Abre os arquivos e le os dados no formulario
            ImportarDados();

            
            
        }

        private void ImportarDados()
        {
            try
            {
                // Importa os dado sdo arquivo transacoes.mac
                using (StreamReader r = new StreamReader("transacoes.mac"))
                {
                    string linha;
                    while ((linha = r.ReadLine()) != null)
                    {
                        lbTransacoes.Items.Add(linha);
                    }
                    r.Close();
                }
                // Importa o saldo atual do arquivo saldo.mac
                using (StreamReader b = new StreamReader("saldo.mac"))
                {
                    string saldo;
                    {
                        saldo = b.ReadToEnd();
                        lblSaldo.Text = saldo;
                    }
                }
            }
            catch
            {
                // se os arquivos não existem cria-os
                File.Create("transacoes.mac").Dispose();
                File.Create("saldo.mac").Dispose();
            }
        }

        private void nupValor_ValueChanged(object sender, EventArgs e)
        {
            // Desabilita o botão OK se for zero
            decimal valor = nupValor.Value;
            if (valor <= 0)
                DesabilitarBotaoOK();
            else
                HabilitarBotaoOK();
        }

        private void HabilitarBotaoOK()
        {
            btnOK.BackColor = Color.LightGreen;
            btnOK.Enabled = true;
        }

        private void DesabilitarBotaoOK()
        {
            btnOK.BackColor = Color.LightGray;
            btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // verifica se é deposito ou debito
            if (rdbDeposito.Checked == true)
                Depositar();
            else
                Debitar();
        }

        private void Depositar()
        {
            double saldoAtual = 0;
            // Adiciona o deposito no saldo atual
            if (!string.IsNullOrEmpty(lblSaldo.Text))
            {
                saldoAtual = Convert.ToDouble(lblSaldo.Text);
            }
            else
            { 
                saldoAtual = Convert.ToDouble(lblSaldo.Text);
            }
            saldoAtual = (saldoAtual + (Convert.ToDouble(nupValor.Value)));
                // atualiza o saldo atual
            lblSaldo.Text = saldoAtual.ToString("0.##");
                // Adiciona a transacao
            lbTransacoes.Items.Add(dtpDate.Value.ToShortDateString() + ",|| DEPOSITO || " + txtMemo.Text + ", " + nupValor.Value.ToString());
                // salva os dados no arquivo
            AtualizaArquivos();
                // limpa o formulario
            Limpa();
        }

        private void AtualizaArquivos()
        {
            // atualiza os arquivos de saldo e transacoes
            using (TextWriter tw = new StreamWriter("transacoes.mac"))
            {
                foreach (String s in lbTransacoes.Items)
                    tw.WriteLine(s);
            }
            using (TextWriter saldoAtualStream = new StreamWriter("saldo.mac"))
            {
                string saldoAtual = lblSaldo.Text.ToString();
                saldoAtualStream.WriteLine(saldoAtual);
            }
        }

        private void Debitar()
        {
            // Subtrai o debito do saldo atual
            double saldoAtual = Convert.ToDouble(lblSaldo.Text);
            saldoAtual = (saldoAtual - (Convert.ToDouble(nupValor.Value)));
            // Atualiza o saldo atual
            lblSaldo.Text = saldoAtual.ToString("0.##");
            // Adiciona a transacao
            lbTransacoes.Items.Add(dtpDate.Value.ToShortDateString() + "||, (( DEBITO )) " + txtMemo.Text + ", " + nupValor.Value.ToString());
            // Salva os dados no arquivo 
            AtualizaArquivos();
            // limpa os dados
            Limpa();
        }

        private void Limpa()
        {
            // Reseta o formulario
            nupValor.Value = 0;
            DesabilitarBotaoOK();
            txtMemo.Text = "";
            nupValor.Focus();
        }


        //Cria instância de PrintDocument
        private PrintDocument document = new PrintDocument();

        //evento Click
        private void btnImprimir_Click(object sender, EventArgs e)
        {

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = document;
            ppd.Document.DocumentName = "RelatorioFinanceiro";
            document.PrintPage += document_PrintPage;
            ppd.ShowDialog();
        }

        //imprime o relatorio
        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            int espacamento = 2;
            int margemEsquerda = 5;
            int margemTopo = 15;
            string titulo = "Relatório Financeiro - " + DateTime.Now.ToString();

            // alguma formatação básica
            StringFormat FmtRight = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat FmtLeft = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat FmtCenter = new StringFormat() { Alignment = StringAlignment.Near };

            StringFormat formatacao = FmtRight;

            using (Font font = new Font("Arial Narrow", 12f))
            {
                SizeF sz = e.Graphics.MeasureString("_|", Font);
                float h = sz.Height + espacamento;

                e.Graphics.DrawString(titulo, font, Brushes.Black, margemEsquerda , margemTopo - 10, formatacao);

                for (int i = 0; i < lbTransacoes.Items.Count; i++)
                {
                    e.Graphics.DrawString(lbTransacoes.Items[i].ToString(), font, Brushes.Black, margemEsquerda, margemTopo + h * i, formatacao);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           // folderBrowserDialog.ShowDialog();
            //openFileDialog.


            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                //var strfilename = openFileDialog.InitialDirectory + openFileDialog.FileName;
                var strPath = folderBrowserDialog.SelectedPath;

                //MsgBox.Show()
                //MessageBox.Show(strPath + "transacoes.mac");

                using (TextWriter tw = new StreamWriter(strPath+@"\transacoes.mac"))
                {
                    foreach (String s in lbTransacoes.Items)
                        tw.WriteLine(s);
                }
                using (TextWriter saldoAtualStream = new StreamWriter(strPath+@"\saldo.mac"))
                {
                    string saldoAtual = lblSaldo.Text.ToString();
                    saldoAtualStream.WriteLine(saldoAtual);
                }

                MessageBox.Show("Dados exportados com sucesso!");

            }

            /*
                    
             using (TextWriter tw = new StreamWriter("transacoes.mac"))
            {
                foreach (String s in lbTransacoes.Items)
                    tw.WriteLine(s);
            }
            using (TextWriter saldoAtualStream = new StreamWriter("saldo.mac"))
            {
                string saldoAtual = lblSaldo.Text.ToString();
                saldoAtualStream.WriteLine(saldoAtual);
            }
             
             
             */
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbTransacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbTransacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }
    }
}
