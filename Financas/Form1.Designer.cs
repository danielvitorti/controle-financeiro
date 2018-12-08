namespace Financas
{
    partial class frmLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentos));
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label_tag_currentbalance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tag_Date = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label_tag_Memo = new System.Windows.Forms.Label();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.nupValor = new System.Windows.Forms.NumericUpDown();
            this.lbTransacoes = new System.Windows.Forms.ListBox();
            this.label_tag_Transactions = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.LightGreen;
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(246, 35);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(421, 40);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "0";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tag_currentbalance
            // 
            this.label_tag_currentbalance.AutoSize = true;
            this.label_tag_currentbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tag_currentbalance.Location = new System.Drawing.Point(242, 12);
            this.label_tag_currentbalance.Name = "label_tag_currentbalance";
            this.label_tag_currentbalance.Size = new System.Drawing.Size(99, 20);
            this.label_tag_currentbalance.TabIndex = 1;
            this.label_tag_currentbalance.Text = "Saldo Atual :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_tag_Date);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.txtMemo);
            this.groupBox1.Controls.Add(this.label_tag_Memo);
            this.groupBox1.Controls.Add(this.rdbDeposito);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.rdbDebito);
            this.groupBox1.Controls.Add(this.nupValor);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 418);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Conta Fixa - Água/Luz/Telefone/Internet",
            "Pagamento de Mensalidade",
            "Pagamento de Seguro",
            "Pagamento de prestação",
            "Fatura de cartão de crédito",
            "Transferência bancária",
            "Outros"});
            this.cmbTipo.Location = new System.Drawing.Point(15, 111);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(166, 21);
            this.cmbTipo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor:";
            // 
            // label_tag_Date
            // 
            this.label_tag_Date.AutoSize = true;
            this.label_tag_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tag_Date.Location = new System.Drawing.Point(11, 357);
            this.label_tag_Date.Name = "label_tag_Date";
            this.label_tag_Date.Size = new System.Drawing.Size(48, 20);
            this.label_tag_Date.TabIndex = 10;
            this.label_tag_Date.Text = "Data:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(15, 380);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(166, 26);
            this.dtpDate.TabIndex = 9;
            // 
            // txtMemo
            // 
            this.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemo.Location = new System.Drawing.Point(15, 158);
            this.txtMemo.MaxLength = 100;
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(166, 122);
            this.txtMemo.TabIndex = 6;
            this.txtMemo.WordWrap = false;
            // 
            // label_tag_Memo
            // 
            this.label_tag_Memo.AutoSize = true;
            this.label_tag_Memo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tag_Memo.Location = new System.Drawing.Point(11, 135);
            this.label_tag_Memo.Name = "label_tag_Memo";
            this.label_tag_Memo.Size = new System.Drawing.Size(80, 20);
            this.label_tag_Memo.TabIndex = 8;
            this.label_tag_Memo.Text = "Descrição\r\n";
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Checked = true;
            this.rdbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDeposito.Location = new System.Drawing.Point(15, 19);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(91, 24);
            this.rdbDeposito.TabIndex = 6;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Depósito";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(106, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 44);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Lançar";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDebito.Location = new System.Drawing.Point(15, 49);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(74, 24);
            this.rdbDebito.TabIndex = 7;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            // 
            // nupValor
            // 
            this.nupValor.BackColor = System.Drawing.Color.White;
            this.nupValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupValor.DecimalPlaces = 2;
            this.nupValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupValor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupValor.Location = new System.Drawing.Point(15, 319);
            this.nupValor.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nupValor.Name = "nupValor";
            this.nupValor.Size = new System.Drawing.Size(166, 26);
            this.nupValor.TabIndex = 5;
            this.nupValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupValor.ThousandsSeparator = true;
            this.nupValor.ValueChanged += new System.EventHandler(this.nupValor_ValueChanged);
            // 
            // lbTransacoes
            // 
            this.lbTransacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTransacoes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransacoes.FormattingEnabled = true;
            this.lbTransacoes.HorizontalScrollbar = true;
            this.lbTransacoes.ItemHeight = 16;
            this.lbTransacoes.Location = new System.Drawing.Point(246, 110);
            this.lbTransacoes.Name = "lbTransacoes";
            this.lbTransacoes.Size = new System.Drawing.Size(421, 322);
            this.lbTransacoes.TabIndex = 6;
            // 
            // label_tag_Transactions
            // 
            this.label_tag_Transactions.AutoSize = true;
            this.label_tag_Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tag_Transactions.Location = new System.Drawing.Point(242, 87);
            this.label_tag_Transactions.Name = "label_tag_Transactions";
            this.label_tag_Transactions.Size = new System.Drawing.Size(64, 20);
            this.label_tag_Transactions.TabIndex = 11;
            this.label_tag_Transactions.Text = "Extrato:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Yellow;
            this.btnImprimir.Location = new System.Drawing.Point(517, 84);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(436, 84);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Exportar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(592, 84);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // frmLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 444);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label_tag_Transactions);
            this.Controls.Add(this.lbTransacoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_tag_currentbalance);
            this.Controls.Add(this.lblSaldo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lançamentos - Controle Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label_tag_currentbalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.NumericUpDown nupValor;
        private System.Windows.Forms.Label label_tag_Date;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label_tag_Memo;
        private System.Windows.Forms.ListBox lbTransacoes;
        private System.Windows.Forms.Label label_tag_Transactions;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnFechar;
    }
}

