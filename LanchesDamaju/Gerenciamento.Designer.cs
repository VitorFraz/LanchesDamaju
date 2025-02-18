namespace LanchesDamaju
{
    partial class Gerenciamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciamento));
            this.dgvLanches = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNomeLanche = new System.Windows.Forms.TextBox();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomeCli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonPesquisarNoCardapio = new System.Windows.Forms.Button();
            this.buttonExcluirDoCardapio = new System.Windows.Forms.Button();
            this.buttonCadClientes = new System.Windows.Forms.Button();
            this.buttonExcluirCli = new System.Windows.Forms.Button();
            this.buttonPesquisarCli = new System.Windows.Forms.Button();
            this.LimparCamposClientes = new System.Windows.Forms.Button();
            this.LimparCamposLanches = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.buttonCadLanches = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBoxLanche = new System.Windows.Forms.PictureBox();
            this.pictureBoxCli = new System.Windows.Forms.PictureBox();
            this.buttonInserirImgLanche = new System.Windows.Forms.Button();
            this.buttonInserirImgCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLanches
            // 
            this.dgvLanches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLanches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLanches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanches.Location = new System.Drawing.Point(45, 40);
            this.dgvLanches.Name = "dgvLanches";
            this.dgvLanches.Size = new System.Drawing.Size(481, 487);
            this.dgvLanches.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(218, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lanches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(830, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(42, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(42, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(40, 685);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Categoria";
            // 
            // textBoxNomeLanche
            // 
            this.textBoxNomeLanche.Location = new System.Drawing.Point(95, 546);
            this.textBoxNomeLanche.Name = "textBoxNomeLanche";
            this.textBoxNomeLanche.Size = new System.Drawing.Size(132, 20);
            this.textBoxNomeLanche.TabIndex = 10;
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(88, 571);
            this.maskedTextBoxValor.Mask = "$ 000,000.00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(79, 20);
            this.maskedTextBoxValor.TabIndex = 11;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(43, 614);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(184, 66);
            this.richTextBoxDesc.TabIndex = 12;
            this.richTextBoxDesc.Text = "";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Salgado",
            "Frito",
            "Assado",
            "Empanado"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(127, 685);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(640, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nome";
            // 
            // textBoxNomeCli
            // 
            this.textBoxNomeCli.Location = new System.Drawing.Point(695, 545);
            this.textBoxNomeCli.Name = "textBoxNomeCli";
            this.textBoxNomeCli.Size = new System.Drawing.Size(157, 20);
            this.textBoxNomeCli.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(640, 571);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Senha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(640, 595);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(640, 622);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "CPF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(640, 648);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "CEP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(640, 671);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Numero";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(640, 696);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Telefone";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(685, 621);
            this.maskedTextBoxCPF.Mask = "000,000,000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBoxCPF.TabIndex = 24;
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(685, 648);
            this.maskedTextBoxCEP.Mask = "0000 00";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(49, 20);
            this.maskedTextBoxCEP.TabIndex = 25;
            // 
            // maskedTextBoxNum
            // 
            this.maskedTextBoxNum.Location = new System.Drawing.Point(708, 672);
            this.maskedTextBoxNum.Mask = "00000";
            this.maskedTextBoxNum.Name = "maskedTextBoxNum";
            this.maskedTextBoxNum.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBoxNum.TabIndex = 26;
            this.maskedTextBoxNum.ValidatingType = typeof(int);
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(714, 696);
            this.maskedTextBoxTel.Mask = "(99) 0000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBoxTel.TabIndex = 27;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(696, 570);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(156, 20);
            this.textBoxSenha.TabIndex = 28;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(690, 597);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 20);
            this.textBoxEmail.TabIndex = 29;
            // 
            // buttonPesquisarNoCardapio
            // 
            this.buttonPesquisarNoCardapio.BackColor = System.Drawing.Color.Salmon;
            this.buttonPesquisarNoCardapio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarNoCardapio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPesquisarNoCardapio.Location = new System.Drawing.Point(269, 720);
            this.buttonPesquisarNoCardapio.Name = "buttonPesquisarNoCardapio";
            this.buttonPesquisarNoCardapio.Size = new System.Drawing.Size(87, 47);
            this.buttonPesquisarNoCardapio.TabIndex = 30;
            this.buttonPesquisarNoCardapio.Text = "Pesquisar no Cardapio";
            this.buttonPesquisarNoCardapio.UseVisualStyleBackColor = false;
            this.buttonPesquisarNoCardapio.Click += new System.EventHandler(this.buttonPesquisarNoCardapio_Click);
            // 
            // buttonExcluirDoCardapio
            // 
            this.buttonExcluirDoCardapio.BackColor = System.Drawing.Color.Salmon;
            this.buttonExcluirDoCardapio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirDoCardapio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExcluirDoCardapio.Location = new System.Drawing.Point(83, 719);
            this.buttonExcluirDoCardapio.Name = "buttonExcluirDoCardapio";
            this.buttonExcluirDoCardapio.Size = new System.Drawing.Size(87, 48);
            this.buttonExcluirDoCardapio.TabIndex = 31;
            this.buttonExcluirDoCardapio.Text = "Excluir do Cardapio";
            this.buttonExcluirDoCardapio.UseVisualStyleBackColor = false;
            this.buttonExcluirDoCardapio.Click += new System.EventHandler(this.buttonExcluirDoCardapio_Click);
            // 
            // buttonCadClientes
            // 
            this.buttonCadClientes.BackColor = System.Drawing.Color.Coral;
            this.buttonCadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCadClientes.Location = new System.Drawing.Point(828, 683);
            this.buttonCadClientes.Name = "buttonCadClientes";
            this.buttonCadClientes.Size = new System.Drawing.Size(87, 42);
            this.buttonCadClientes.TabIndex = 32;
            this.buttonCadClientes.Text = "Cadastrar Cliente";
            this.buttonCadClientes.UseVisualStyleBackColor = false;
            this.buttonCadClientes.Click += new System.EventHandler(this.buttonCadClientes_Click);
            // 
            // buttonExcluirCli
            // 
            this.buttonExcluirCli.BackColor = System.Drawing.Color.Coral;
            this.buttonExcluirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirCli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExcluirCli.Location = new System.Drawing.Point(828, 731);
            this.buttonExcluirCli.Name = "buttonExcluirCli";
            this.buttonExcluirCli.Size = new System.Drawing.Size(87, 42);
            this.buttonExcluirCli.TabIndex = 33;
            this.buttonExcluirCli.Text = "Excluir Cliente";
            this.buttonExcluirCli.UseVisualStyleBackColor = false;
            this.buttonExcluirCli.Click += new System.EventHandler(this.buttonExcluirCli_Click);
            // 
            // buttonPesquisarCli
            // 
            this.buttonPesquisarCli.BackColor = System.Drawing.Color.Coral;
            this.buttonPesquisarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarCli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPesquisarCli.Location = new System.Drawing.Point(642, 731);
            this.buttonPesquisarCli.Name = "buttonPesquisarCli";
            this.buttonPesquisarCli.Size = new System.Drawing.Size(87, 42);
            this.buttonPesquisarCli.TabIndex = 34;
            this.buttonPesquisarCli.Text = "Pesquisar Cliente";
            this.buttonPesquisarCli.UseVisualStyleBackColor = false;
            this.buttonPesquisarCli.Click += new System.EventHandler(this.buttonPesquisarCli_Click);
            // 
            // LimparCamposClientes
            // 
            this.LimparCamposClientes.BackColor = System.Drawing.Color.Coral;
            this.LimparCamposClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparCamposClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LimparCamposClientes.Location = new System.Drawing.Point(735, 731);
            this.LimparCamposClientes.Name = "LimparCamposClientes";
            this.LimparCamposClientes.Size = new System.Drawing.Size(87, 42);
            this.LimparCamposClientes.TabIndex = 35;
            this.LimparCamposClientes.Text = "Limpar Campos";
            this.LimparCamposClientes.UseVisualStyleBackColor = false;
            this.LimparCamposClientes.Click += new System.EventHandler(this.LimparCamposClientes_Click);
            // 
            // LimparCamposLanches
            // 
            this.LimparCamposLanches.BackColor = System.Drawing.Color.Salmon;
            this.LimparCamposLanches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparCamposLanches.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LimparCamposLanches.Location = new System.Drawing.Point(176, 719);
            this.LimparCamposLanches.Name = "LimparCamposLanches";
            this.LimparCamposLanches.Size = new System.Drawing.Size(87, 48);
            this.LimparCamposLanches.TabIndex = 36;
            this.LimparCamposLanches.Text = "Limpar Campos";
            this.LimparCamposLanches.UseVisualStyleBackColor = false;
            this.LimparCamposLanches.Click += new System.EventHandler(this.LimparCamposLanches_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(606, 40);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClientes.Size = new System.Drawing.Size(481, 487);
            this.dgvClientes.TabIndex = 37;
            // 
            // buttonCadLanches
            // 
            this.buttonCadLanches.BackColor = System.Drawing.Color.Salmon;
            this.buttonCadLanches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadLanches.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCadLanches.Location = new System.Drawing.Point(269, 667);
            this.buttonCadLanches.Name = "buttonCadLanches";
            this.buttonCadLanches.Size = new System.Drawing.Size(87, 47);
            this.buttonCadLanches.TabIndex = 39;
            this.buttonCadLanches.Text = "Cadastrar no Cardapio";
            this.buttonCadLanches.UseVisualStyleBackColor = false;
            this.buttonCadLanches.Click += new System.EventHandler(this.buttonCadLanches_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(355, 540);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 24);
            this.label15.TabIndex = 40;
            this.label15.Text = "Imagem (Lanche)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(933, 540);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 24);
            this.label16.TabIndex = 41;
            this.label16.Text = "Imagem (Cliente)";
            // 
            // pictureBoxLanche
            // 
            this.pictureBoxLanche.BackColor = System.Drawing.Color.Sienna;
            this.pictureBoxLanche.Location = new System.Drawing.Point(372, 570);
            this.pictureBoxLanche.Name = "pictureBoxLanche";
            this.pictureBoxLanche.Size = new System.Drawing.Size(140, 132);
            this.pictureBoxLanche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLanche.TabIndex = 42;
            this.pictureBoxLanche.TabStop = false;
            // 
            // pictureBoxCli
            // 
            this.pictureBoxCli.BackColor = System.Drawing.Color.Sienna;
            this.pictureBoxCli.Location = new System.Drawing.Point(947, 571);
            this.pictureBoxCli.Name = "pictureBoxCli";
            this.pictureBoxCli.Size = new System.Drawing.Size(140, 132);
            this.pictureBoxCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCli.TabIndex = 43;
            this.pictureBoxCli.TabStop = false;
            // 
            // buttonInserirImgLanche
            // 
            this.buttonInserirImgLanche.BackColor = System.Drawing.Color.Salmon;
            this.buttonInserirImgLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirImgLanche.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInserirImgLanche.Location = new System.Drawing.Point(406, 708);
            this.buttonInserirImgLanche.Name = "buttonInserirImgLanche";
            this.buttonInserirImgLanche.Size = new System.Drawing.Size(77, 52);
            this.buttonInserirImgLanche.TabIndex = 44;
            this.buttonInserirImgLanche.Text = "Inserir Imagem";
            this.buttonInserirImgLanche.UseVisualStyleBackColor = false;
            this.buttonInserirImgLanche.Click += new System.EventHandler(this.buttonInserirImgLanche_Click);
            // 
            // buttonInserirImgCli
            // 
            this.buttonInserirImgCli.BackColor = System.Drawing.Color.Coral;
            this.buttonInserirImgCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirImgCli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInserirImgCli.Location = new System.Drawing.Point(979, 709);
            this.buttonInserirImgCli.Name = "buttonInserirImgCli";
            this.buttonInserirImgCli.Size = new System.Drawing.Size(76, 52);
            this.buttonInserirImgCli.TabIndex = 45;
            this.buttonInserirImgCli.Text = "Inserir Imagem";
            this.buttonInserirImgCli.UseVisualStyleBackColor = false;
            this.buttonInserirImgCli.Click += new System.EventHandler(this.buttonInserirImgCli_Click);
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 782);
            this.Controls.Add(this.buttonInserirImgCli);
            this.Controls.Add(this.buttonInserirImgLanche);
            this.Controls.Add(this.pictureBoxCli);
            this.Controls.Add(this.pictureBoxLanche);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonCadLanches);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.LimparCamposLanches);
            this.Controls.Add(this.LimparCamposClientes);
            this.Controls.Add(this.buttonPesquisarCli);
            this.Controls.Add(this.buttonExcluirCli);
            this.Controls.Add(this.buttonCadClientes);
            this.Controls.Add(this.buttonExcluirDoCardapio);
            this.Controls.Add(this.buttonPesquisarNoCardapio);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.maskedTextBoxNum);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNomeCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.textBoxNomeLanche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLanches);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gerenciamento";
            this.Text = "Lanches Damaju (Gerenciamento de Lanches e Clientes)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLanches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNomeLanche;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNomeCli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNum;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonPesquisarNoCardapio;
        private System.Windows.Forms.Button buttonExcluirDoCardapio;
        private System.Windows.Forms.Button buttonCadClientes;
        private System.Windows.Forms.Button buttonExcluirCli;
        private System.Windows.Forms.Button buttonPesquisarCli;
        private System.Windows.Forms.Button LimparCamposClientes;
        private System.Windows.Forms.Button LimparCamposLanches;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button buttonCadLanches;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBoxLanche;
        private System.Windows.Forms.PictureBox pictureBoxCli;
        private System.Windows.Forms.Button buttonInserirImgLanche;
        private System.Windows.Forms.Button buttonInserirImgCli;
    }
}

