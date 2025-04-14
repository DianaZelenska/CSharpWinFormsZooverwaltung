namespace Zoo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnKontNeu = new Button();
            btnDelKontinent = new Button();
            btnKontSpeichern = new Button();
            lbKontinent = new ListBox();
            tbKontinent = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnGehegeNeu = new Button();
            btnGehegeLoeschen = new Button();
            dgvGehege = new DataGridView();
            btnGehegeSpeichern = new Button();
            tbGehege = new TextBox();
            cbGehegeKontinent = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            tabPage3 = new TabPage();
            label9 = new Label();
            btnTierartNeu = new Button();
            btnTierartLoeschen = new Button();
            btnTierartSpeichern = new Button();
            lbTierart = new ListBox();
            tbTierart = new TextBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            btnTierToCSV = new Button();
            btnTierNeu = new Button();
            btnTierLoeschen = new Button();
            btnTierSpeichern = new Button();
            dgvTiere = new DataGridView();
            colTierName = new DataGridViewTextBoxColumn();
            colTierGebJahr = new DataGridViewTextBoxColumn();
            colTierGehege = new DataGridViewTextBoxColumn();
            colTierTierart = new DataGridViewTextBoxColumn();
            cbTierTierart = new ComboBox();
            cbTierGehege = new ComboBox();
            tbTierGeb = new TextBox();
            tbTierName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabPage5 = new TabPage();
            dgvGehegeMitTieren = new DataGridView();
            colGehege = new DataGridViewTextBoxColumn();
            colTier = new DataGridViewTextBoxColumn();
            label10 = new Label();
            tabPage6 = new TabPage();
            btnPflegerNeu = new Button();
            btnPflegerLoeschen = new Button();
            btnPflegerSpeichern = new Button();
            dgvPfleger = new DataGridView();
            colPflegerVorname = new DataGridViewTextBoxColumn();
            colPflegerNachname = new DataGridViewTextBoxColumn();
            tbPflegerNachn = new TextBox();
            tbPflegerVorn = new TextBox();
            label12 = new Label();
            label11 = new Label();
            tabPage7 = new TabPage();
            btnGehegePflegerLoeschen = new Button();
            btnGehegePflegerNeu = new Button();
            dgvGehegePfleger = new DataGridView();
            colGehegeGP = new DataGridViewTextBoxColumn();
            colPflegerVornameGP = new DataGridViewTextBoxColumn();
            colPflegerNachnameGP = new DataGridViewTextBoxColumn();
            colHauptpfleger = new DataGridViewTextBoxColumn();
            btnGehPflSpeichern = new Button();
            rbHauptpflegerNein = new RadioButton();
            rbHauptpflegerJa = new RadioButton();
            label15 = new Label();
            cbPflNachname = new ComboBox();
            cbGehege = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            colGehegeName = new DataGridViewTextBoxColumn();
            colGehegeKontinent = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGehege).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiere).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGehegeMitTieren).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPfleger).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGehegePfleger).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(11, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 436);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnKontNeu);
            tabPage1.Controls.Add(btnDelKontinent);
            tabPage1.Controls.Add(btnKontSpeichern);
            tabPage1.Controls.Add(lbKontinent);
            tabPage1.Controls.Add(tbKontinent);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(781, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kontinente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnKontNeu
            // 
            btnKontNeu.Location = new Point(190, 320);
            btnKontNeu.Name = "btnKontNeu";
            btnKontNeu.Size = new Size(94, 29);
            btnKontNeu.TabIndex = 5;
            btnKontNeu.Text = "Neu";
            btnKontNeu.UseVisualStyleBackColor = true;
            btnKontNeu.Click += btnKontNeu_Click;
            // 
            // btnDelKontinent
            // 
            btnDelKontinent.Location = new Point(190, 252);
            btnDelKontinent.Name = "btnDelKontinent";
            btnDelKontinent.Size = new Size(94, 29);
            btnDelKontinent.TabIndex = 4;
            btnDelKontinent.Text = "Löschen";
            btnDelKontinent.UseVisualStyleBackColor = true;
            btnDelKontinent.Click += btnDelKontinent_Click;
            // 
            // btnKontSpeichern
            // 
            btnKontSpeichern.Location = new Point(190, 179);
            btnKontSpeichern.Name = "btnKontSpeichern";
            btnKontSpeichern.Size = new Size(94, 29);
            btnKontSpeichern.TabIndex = 3;
            btnKontSpeichern.Text = "Speichern";
            btnKontSpeichern.UseVisualStyleBackColor = true;
            btnKontSpeichern.Click += btnKontSpeichern_Click;
            // 
            // lbKontinent
            // 
            lbKontinent.FormattingEnabled = true;
            lbKontinent.Location = new Point(462, 85);
            lbKontinent.Name = "lbKontinent";
            lbKontinent.Size = new Size(150, 264);
            lbKontinent.TabIndex = 2;
            lbKontinent.SelectedIndexChanged += lbKontinent_SelectedIndexChanged;
            // 
            // tbKontinent
            // 
            tbKontinent.Location = new Point(173, 85);
            tbKontinent.Name = "tbKontinent";
            tbKontinent.Size = new Size(125, 27);
            tbKontinent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 88);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnGehegeNeu);
            tabPage2.Controls.Add(btnGehegeLoeschen);
            tabPage2.Controls.Add(dgvGehege);
            tabPage2.Controls.Add(btnGehegeSpeichern);
            tabPage2.Controls.Add(tbGehege);
            tabPage2.Controls.Add(cbGehegeKontinent);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(781, 403);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gehege";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGehegeNeu
            // 
            btnGehegeNeu.Location = new Point(306, 235);
            btnGehegeNeu.Margin = new Padding(3, 4, 3, 4);
            btnGehegeNeu.Name = "btnGehegeNeu";
            btnGehegeNeu.Size = new Size(86, 31);
            btnGehegeNeu.TabIndex = 8;
            btnGehegeNeu.Text = "Neu";
            btnGehegeNeu.UseVisualStyleBackColor = true;
            btnGehegeNeu.Click += btnGehegeNeu_Click;
            // 
            // btnGehegeLoeschen
            // 
            btnGehegeLoeschen.Location = new Point(141, 288);
            btnGehegeLoeschen.Margin = new Padding(3, 4, 3, 4);
            btnGehegeLoeschen.Name = "btnGehegeLoeschen";
            btnGehegeLoeschen.Size = new Size(86, 31);
            btnGehegeLoeschen.TabIndex = 7;
            btnGehegeLoeschen.Text = "Löschen";
            btnGehegeLoeschen.UseVisualStyleBackColor = true;
            btnGehegeLoeschen.Click += btnGehegeLoeschen_Click;
            // 
            // dgvGehege
            // 
            dgvGehege.AllowUserToAddRows = false;
            dgvGehege.AllowUserToDeleteRows = false;
            dgvGehege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGehege.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGehege.Columns.AddRange(new DataGridViewColumn[] { colGehegeName, colGehegeKontinent });
            dgvGehege.Location = new Point(490, 52);
            dgvGehege.Margin = new Padding(3, 4, 3, 4);
            dgvGehege.Name = "dgvGehege";
            dgvGehege.ReadOnly = true;
            dgvGehege.RowHeadersWidth = 51;
            dgvGehege.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGehege.Size = new Size(274, 200);
            dgvGehege.TabIndex = 6;
            dgvGehege.SelectionChanged += dgvGehege_SelectionChanged;
            // 
            // btnGehegeSpeichern
            // 
            btnGehegeSpeichern.Location = new Point(141, 235);
            btnGehegeSpeichern.Margin = new Padding(3, 4, 3, 4);
            btnGehegeSpeichern.Name = "btnGehegeSpeichern";
            btnGehegeSpeichern.Size = new Size(86, 31);
            btnGehegeSpeichern.TabIndex = 4;
            btnGehegeSpeichern.Text = "Speichern";
            btnGehegeSpeichern.UseVisualStyleBackColor = true;
            btnGehegeSpeichern.Click += btnGehegeSpeichern_Click;
            // 
            // tbGehege
            // 
            tbGehege.Location = new Point(289, 67);
            tbGehege.Margin = new Padding(3, 4, 3, 4);
            tbGehege.Name = "tbGehege";
            tbGehege.Size = new Size(114, 27);
            tbGehege.TabIndex = 3;
            // 
            // cbGehegeKontinent
            // 
            cbGehegeKontinent.FormattingEnabled = true;
            cbGehegeKontinent.Location = new Point(289, 161);
            cbGehegeKontinent.Margin = new Padding(3, 4, 3, 4);
            cbGehegeKontinent.Name = "cbGehegeKontinent";
            cbGehegeKontinent.Size = new Size(138, 28);
            cbGehegeKontinent.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 172);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "GehegeKontinent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 71);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "GehegeName";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(btnTierartNeu);
            tabPage3.Controls.Add(btnTierartLoeschen);
            tabPage3.Controls.Add(btnTierartSpeichern);
            tabPage3.Controls.Add(lbTierart);
            tabPage3.Controls.Add(tbTierart);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(781, 403);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tierarten";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 331);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 6;
            label9.Text = "label9";
            // 
            // btnTierartNeu
            // 
            btnTierartNeu.Location = new Point(256, 265);
            btnTierartNeu.Margin = new Padding(3, 4, 3, 4);
            btnTierartNeu.Name = "btnTierartNeu";
            btnTierartNeu.Size = new Size(86, 31);
            btnTierartNeu.TabIndex = 5;
            btnTierartNeu.Text = "Neu";
            btnTierartNeu.UseVisualStyleBackColor = true;
            btnTierartNeu.Click += btnTierartNeu_Click;
            // 
            // btnTierartLoeschen
            // 
            btnTierartLoeschen.Location = new Point(256, 209);
            btnTierartLoeschen.Margin = new Padding(3, 4, 3, 4);
            btnTierartLoeschen.Name = "btnTierartLoeschen";
            btnTierartLoeschen.Size = new Size(86, 31);
            btnTierartLoeschen.TabIndex = 4;
            btnTierartLoeschen.Text = "Löschen";
            btnTierartLoeschen.UseVisualStyleBackColor = true;
            btnTierartLoeschen.Click += btnTierartLoeschen_Click;
            // 
            // btnTierartSpeichern
            // 
            btnTierartSpeichern.Location = new Point(256, 157);
            btnTierartSpeichern.Name = "btnTierartSpeichern";
            btnTierartSpeichern.Size = new Size(94, 29);
            btnTierartSpeichern.TabIndex = 3;
            btnTierartSpeichern.Text = "Speichern";
            btnTierartSpeichern.UseVisualStyleBackColor = true;
            btnTierartSpeichern.Click += btnTierartSpeichern_Click;
            // 
            // lbTierart
            // 
            lbTierart.FormattingEnabled = true;
            lbTierart.Location = new Point(482, 71);
            lbTierart.Name = "lbTierart";
            lbTierart.Size = new Size(150, 244);
            lbTierart.TabIndex = 2;
            lbTierart.SelectedIndexChanged += lbTierart_SelectedIndexChanged;
            // 
            // tbTierart
            // 
            tbTierart.Location = new Point(241, 71);
            tbTierart.Name = "tbTierart";
            tbTierart.Size = new Size(125, 27);
            tbTierart.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 75);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Tierart";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnTierToCSV);
            tabPage4.Controls.Add(btnTierNeu);
            tabPage4.Controls.Add(btnTierLoeschen);
            tabPage4.Controls.Add(btnTierSpeichern);
            tabPage4.Controls.Add(dgvTiere);
            tabPage4.Controls.Add(cbTierTierart);
            tabPage4.Controls.Add(cbTierGehege);
            tabPage4.Controls.Add(tbTierGeb);
            tabPage4.Controls.Add(tbTierName);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(781, 403);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tiere";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnTierToCSV
            // 
            btnTierToCSV.Location = new Point(598, 35);
            btnTierToCSV.Margin = new Padding(3, 4, 3, 4);
            btnTierToCSV.Name = "btnTierToCSV";
            btnTierToCSV.Size = new Size(86, 31);
            btnTierToCSV.TabIndex = 12;
            btnTierToCSV.Text = "To CSV";
            btnTierToCSV.UseVisualStyleBackColor = true;
            btnTierToCSV.Click += btnTierToCSV_Click;
            // 
            // btnTierNeu
            // 
            btnTierNeu.Location = new Point(423, 149);
            btnTierNeu.Name = "btnTierNeu";
            btnTierNeu.Size = new Size(94, 29);
            btnTierNeu.TabIndex = 11;
            btnTierNeu.Text = "Neu";
            btnTierNeu.UseVisualStyleBackColor = true;
            btnTierNeu.Click += btnTierNeu_Click;
            // 
            // btnTierLoeschen
            // 
            btnTierLoeschen.Location = new Point(423, 89);
            btnTierLoeschen.Name = "btnTierLoeschen";
            btnTierLoeschen.Size = new Size(94, 29);
            btnTierLoeschen.TabIndex = 10;
            btnTierLoeschen.Text = "Löschen";
            btnTierLoeschen.UseVisualStyleBackColor = true;
            btnTierLoeschen.Click += btnTierLoeschen_Click;
            // 
            // btnTierSpeichern
            // 
            btnTierSpeichern.Location = new Point(423, 35);
            btnTierSpeichern.Name = "btnTierSpeichern";
            btnTierSpeichern.Size = new Size(94, 29);
            btnTierSpeichern.TabIndex = 9;
            btnTierSpeichern.Text = "Speichern";
            btnTierSpeichern.UseVisualStyleBackColor = true;
            btnTierSpeichern.Click += btnTierSpeichern_Click;
            // 
            // dgvTiere
            // 
            dgvTiere.AllowUserToAddRows = false;
            dgvTiere.AllowUserToDeleteRows = false;
            dgvTiere.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiere.Columns.AddRange(new DataGridViewColumn[] { colTierName, colTierGebJahr, colTierGehege, colTierTierart });
            dgvTiere.Location = new Point(24, 211);
            dgvTiere.Name = "dgvTiere";
            dgvTiere.ReadOnly = true;
            dgvTiere.RowHeadersWidth = 51;
            dgvTiere.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTiere.Size = new Size(631, 188);
            dgvTiere.TabIndex = 8;
            dgvTiere.SelectionChanged += dgvTiere_SelectionChanged;
            // 
            // colTierName
            // 
            colTierName.HeaderText = "Tier";
            colTierName.MinimumWidth = 6;
            colTierName.Name = "colTierName";
            colTierName.ReadOnly = true;
            colTierName.Width = 125;
            // 
            // colTierGebJahr
            // 
            colTierGebJahr.HeaderText = "Geburtsjahr";
            colTierGebJahr.MinimumWidth = 6;
            colTierGebJahr.Name = "colTierGebJahr";
            colTierGebJahr.ReadOnly = true;
            colTierGebJahr.Width = 125;
            // 
            // colTierGehege
            // 
            colTierGehege.HeaderText = "Gehege";
            colTierGehege.MinimumWidth = 6;
            colTierGehege.Name = "colTierGehege";
            colTierGehege.ReadOnly = true;
            colTierGehege.Width = 125;
            // 
            // colTierTierart
            // 
            colTierTierart.HeaderText = "Tierart";
            colTierTierart.MinimumWidth = 6;
            colTierTierart.Name = "colTierTierart";
            colTierTierart.ReadOnly = true;
            colTierTierart.Width = 125;
            // 
            // cbTierTierart
            // 
            cbTierTierart.FormattingEnabled = true;
            cbTierTierart.Location = new Point(159, 157);
            cbTierTierart.Name = "cbTierTierart";
            cbTierTierart.Size = new Size(151, 28);
            cbTierTierart.TabIndex = 7;
            // 
            // cbTierGehege
            // 
            cbTierGehege.FormattingEnabled = true;
            cbTierGehege.Location = new Point(159, 116);
            cbTierGehege.Name = "cbTierGehege";
            cbTierGehege.Size = new Size(151, 28);
            cbTierGehege.TabIndex = 6;
            // 
            // tbTierGeb
            // 
            tbTierGeb.Location = new Point(159, 69);
            tbTierGeb.Name = "tbTierGeb";
            tbTierGeb.Size = new Size(125, 27);
            tbTierGeb.TabIndex = 5;
            // 
            // tbTierName
            // 
            tbTierName.Location = new Point(159, 25);
            tbTierName.Name = "tbTierName";
            tbTierName.Size = new Size(125, 27);
            tbTierName.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 157);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 3;
            label8.Text = "TierTierart";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 116);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 2;
            label7.Text = "TierGehege";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 76);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 1;
            label6.Text = "TierGebJahr";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 28);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 0;
            label5.Text = "TierName";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvGehegeMitTieren);
            tabPage5.Controls.Add(label10);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 4, 3, 4);
            tabPage5.Size = new Size(781, 403);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Statistik";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvGehegeMitTieren
            // 
            dgvGehegeMitTieren.AllowUserToAddRows = false;
            dgvGehegeMitTieren.AllowUserToDeleteRows = false;
            dgvGehegeMitTieren.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGehegeMitTieren.Columns.AddRange(new DataGridViewColumn[] { colGehege, colTier });
            dgvGehegeMitTieren.Location = new Point(99, 115);
            dgvGehegeMitTieren.Margin = new Padding(3, 4, 3, 4);
            dgvGehegeMitTieren.Name = "dgvGehegeMitTieren";
            dgvGehegeMitTieren.ReadOnly = true;
            dgvGehegeMitTieren.RowHeadersWidth = 51;
            dgvGehegeMitTieren.Size = new Size(274, 200);
            dgvGehegeMitTieren.TabIndex = 1;
            // 
            // colGehege
            // 
            colGehege.HeaderText = "Gehege";
            colGehege.MinimumWidth = 6;
            colGehege.Name = "colGehege";
            colGehege.ReadOnly = true;
            colGehege.Width = 125;
            // 
            // colTier
            // 
            colTier.HeaderText = "Tier";
            colTier.MinimumWidth = 6;
            colTier.Name = "colTier";
            colTier.ReadOnly = true;
            colTier.Width = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 59);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 0;
            label10.Text = "TiereInGehege";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(btnPflegerNeu);
            tabPage6.Controls.Add(btnPflegerLoeschen);
            tabPage6.Controls.Add(btnPflegerSpeichern);
            tabPage6.Controls.Add(dgvPfleger);
            tabPage6.Controls.Add(tbPflegerNachn);
            tabPage6.Controls.Add(tbPflegerVorn);
            tabPage6.Controls.Add(label12);
            tabPage6.Controls.Add(label11);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(781, 403);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Pfleger";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnPflegerNeu
            // 
            btnPflegerNeu.Location = new Point(215, 189);
            btnPflegerNeu.Name = "btnPflegerNeu";
            btnPflegerNeu.Size = new Size(94, 29);
            btnPflegerNeu.TabIndex = 7;
            btnPflegerNeu.Text = "Neu";
            btnPflegerNeu.UseVisualStyleBackColor = true;
            btnPflegerNeu.Click += btnPflegerNeu_Click;
            // 
            // btnPflegerLoeschen
            // 
            btnPflegerLoeschen.Location = new Point(81, 244);
            btnPflegerLoeschen.Name = "btnPflegerLoeschen";
            btnPflegerLoeschen.Size = new Size(94, 29);
            btnPflegerLoeschen.TabIndex = 6;
            btnPflegerLoeschen.Text = "Löschen";
            btnPflegerLoeschen.UseVisualStyleBackColor = true;
            btnPflegerLoeschen.Click += btnPflegerLoeschen_Click;
            // 
            // btnPflegerSpeichern
            // 
            btnPflegerSpeichern.Location = new Point(81, 189);
            btnPflegerSpeichern.Name = "btnPflegerSpeichern";
            btnPflegerSpeichern.Size = new Size(94, 29);
            btnPflegerSpeichern.TabIndex = 5;
            btnPflegerSpeichern.Text = "Speichern";
            btnPflegerSpeichern.UseVisualStyleBackColor = true;
            btnPflegerSpeichern.Click += btnPflegerSpeichern_Click;
            // 
            // dgvPfleger
            // 
            dgvPfleger.AllowUserToAddRows = false;
            dgvPfleger.AllowUserToDeleteRows = false;
            dgvPfleger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPfleger.Columns.AddRange(new DataGridViewColumn[] { colPflegerVorname, colPflegerNachname });
            dgvPfleger.Location = new Point(435, 43);
            dgvPfleger.Name = "dgvPfleger";
            dgvPfleger.ReadOnly = true;
            dgvPfleger.RowHeadersWidth = 51;
            dgvPfleger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPfleger.Size = new Size(299, 188);
            dgvPfleger.TabIndex = 4;
            dgvPfleger.SelectionChanged += dgvPfleger_SelectionChanged;
            // 
            // colPflegerVorname
            // 
            colPflegerVorname.HeaderText = "Vorname";
            colPflegerVorname.MinimumWidth = 6;
            colPflegerVorname.Name = "colPflegerVorname";
            colPflegerVorname.ReadOnly = true;
            colPflegerVorname.Width = 125;
            // 
            // colPflegerNachname
            // 
            colPflegerNachname.HeaderText = "Nachname";
            colPflegerNachname.MinimumWidth = 6;
            colPflegerNachname.Name = "colPflegerNachname";
            colPflegerNachname.ReadOnly = true;
            colPflegerNachname.Width = 125;
            // 
            // tbPflegerNachn
            // 
            tbPflegerNachn.Location = new Point(250, 119);
            tbPflegerNachn.Name = "tbPflegerNachn";
            tbPflegerNachn.Size = new Size(125, 27);
            tbPflegerNachn.TabIndex = 3;
            // 
            // tbPflegerVorn
            // 
            tbPflegerVorn.Location = new Point(250, 55);
            tbPflegerVorn.Name = "tbPflegerVorn";
            tbPflegerVorn.Size = new Size(125, 27);
            tbPflegerVorn.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(81, 123);
            label12.Name = "label12";
            label12.Size = new Size(127, 20);
            label12.TabIndex = 1;
            label12.Text = "PflegerNachname";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(81, 59);
            label11.Name = "label11";
            label11.Size = new Size(115, 20);
            label11.TabIndex = 0;
            label11.Text = "PflegerVorname";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(btnGehegePflegerLoeschen);
            tabPage7.Controls.Add(btnGehegePflegerNeu);
            tabPage7.Controls.Add(dgvGehegePfleger);
            tabPage7.Controls.Add(btnGehPflSpeichern);
            tabPage7.Controls.Add(rbHauptpflegerNein);
            tabPage7.Controls.Add(rbHauptpflegerJa);
            tabPage7.Controls.Add(label15);
            tabPage7.Controls.Add(cbPflNachname);
            tabPage7.Controls.Add(cbGehege);
            tabPage7.Controls.Add(label14);
            tabPage7.Controls.Add(label13);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Margin = new Padding(3, 4, 3, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(781, 403);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "GehegePfleger";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnGehegePflegerLoeschen
            // 
            btnGehegePflegerLoeschen.Location = new Point(154, 273);
            btnGehegePflegerLoeschen.Margin = new Padding(3, 4, 3, 4);
            btnGehegePflegerLoeschen.Name = "btnGehegePflegerLoeschen";
            btnGehegePflegerLoeschen.Size = new Size(86, 31);
            btnGehegePflegerLoeschen.TabIndex = 10;
            btnGehegePflegerLoeschen.Text = "Löschen";
            btnGehegePflegerLoeschen.UseVisualStyleBackColor = true;
            btnGehegePflegerLoeschen.Click += btnGehegePflegerLoeschen_Click;
            // 
            // btnGehegePflegerNeu
            // 
            btnGehegePflegerNeu.Location = new Point(33, 328);
            btnGehegePflegerNeu.Margin = new Padding(3, 4, 3, 4);
            btnGehegePflegerNeu.Name = "btnGehegePflegerNeu";
            btnGehegePflegerNeu.Size = new Size(86, 31);
            btnGehegePflegerNeu.TabIndex = 9;
            btnGehegePflegerNeu.Text = "Neu";
            btnGehegePflegerNeu.UseVisualStyleBackColor = true;
            btnGehegePflegerNeu.Click += btnGehegePflegerNeu_Click;
            // 
            // dgvGehegePfleger
            // 
            dgvGehegePfleger.AllowUserToAddRows = false;
            dgvGehegePfleger.AllowUserToDeleteRows = false;
            dgvGehegePfleger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGehegePfleger.Columns.AddRange(new DataGridViewColumn[] { colGehegeGP, colPflegerVornameGP, colPflegerNachnameGP, colHauptpfleger });
            dgvGehegePfleger.Location = new Point(339, 49);
            dgvGehegePfleger.Margin = new Padding(3, 4, 3, 4);
            dgvGehegePfleger.Name = "dgvGehegePfleger";
            dgvGehegePfleger.ReadOnly = true;
            dgvGehegePfleger.RowHeadersWidth = 51;
            dgvGehegePfleger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGehegePfleger.Size = new Size(414, 200);
            dgvGehegePfleger.TabIndex = 8;
            dgvGehegePfleger.SelectionChanged += dgvGehegePfleger_SelectionChanged;
            // 
            // colGehegeGP
            // 
            colGehegeGP.HeaderText = "Gehege";
            colGehegeGP.MinimumWidth = 6;
            colGehegeGP.Name = "colGehegeGP";
            colGehegeGP.ReadOnly = true;
            colGehegeGP.Width = 125;
            // 
            // colPflegerVornameGP
            // 
            colPflegerVornameGP.HeaderText = "PflegerVorname";
            colPflegerVornameGP.MinimumWidth = 6;
            colPflegerVornameGP.Name = "colPflegerVornameGP";
            colPflegerVornameGP.ReadOnly = true;
            colPflegerVornameGP.Width = 125;
            // 
            // colPflegerNachnameGP
            // 
            colPflegerNachnameGP.HeaderText = "PflegerNachname";
            colPflegerNachnameGP.MinimumWidth = 6;
            colPflegerNachnameGP.Name = "colPflegerNachnameGP";
            colPflegerNachnameGP.ReadOnly = true;
            colPflegerNachnameGP.Width = 125;
            // 
            // colHauptpfleger
            // 
            colHauptpfleger.HeaderText = "Hauptpfleger";
            colHauptpfleger.MinimumWidth = 6;
            colHauptpfleger.Name = "colHauptpfleger";
            colHauptpfleger.ReadOnly = true;
            colHauptpfleger.Width = 125;
            // 
            // btnGehPflSpeichern
            // 
            btnGehPflSpeichern.Location = new Point(35, 273);
            btnGehPflSpeichern.Margin = new Padding(3, 4, 3, 4);
            btnGehPflSpeichern.Name = "btnGehPflSpeichern";
            btnGehPflSpeichern.Size = new Size(86, 31);
            btnGehPflSpeichern.TabIndex = 7;
            btnGehPflSpeichern.Text = "Speichern";
            btnGehPflSpeichern.UseVisualStyleBackColor = true;
            btnGehPflSpeichern.Click += btnGehPflSpeichern_Click;
            // 
            // rbHauptpflegerNein
            // 
            rbHauptpflegerNein.AutoSize = true;
            rbHauptpflegerNein.Location = new Point(256, 200);
            rbHauptpflegerNein.Margin = new Padding(3, 4, 3, 4);
            rbHauptpflegerNein.Name = "rbHauptpflegerNein";
            rbHauptpflegerNein.Size = new Size(61, 24);
            rbHauptpflegerNein.TabIndex = 6;
            rbHauptpflegerNein.TabStop = true;
            rbHauptpflegerNein.Text = "Nein";
            rbHauptpflegerNein.UseVisualStyleBackColor = true;
            // 
            // rbHauptpflegerJa
            // 
            rbHauptpflegerJa.AutoSize = true;
            rbHauptpflegerJa.Location = new Point(183, 200);
            rbHauptpflegerJa.Margin = new Padding(3, 4, 3, 4);
            rbHauptpflegerJa.Name = "rbHauptpflegerJa";
            rbHauptpflegerJa.Size = new Size(43, 24);
            rbHauptpflegerJa.TabIndex = 5;
            rbHauptpflegerJa.TabStop = true;
            rbHauptpflegerJa.Text = "Ja";
            rbHauptpflegerJa.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 200);
            label15.Name = "label15";
            label15.Size = new Size(98, 20);
            label15.TabIndex = 4;
            label15.Text = "Hauptpfleger";
            // 
            // cbPflNachname
            // 
            cbPflNachname.FormattingEnabled = true;
            cbPflNachname.Location = new Point(183, 115);
            cbPflNachname.Margin = new Padding(3, 4, 3, 4);
            cbPflNachname.Name = "cbPflNachname";
            cbPflNachname.Size = new Size(138, 28);
            cbPflNachname.TabIndex = 3;
            // 
            // cbGehege
            // 
            cbGehege.FormattingEnabled = true;
            cbGehege.Location = new Point(183, 49);
            cbGehege.Margin = new Padding(3, 4, 3, 4);
            cbGehege.Name = "cbGehege";
            cbGehege.Size = new Size(138, 28);
            cbGehege.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 119);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 1;
            label14.Text = "PflegerNachname";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 53);
            label13.Name = "label13";
            label13.Size = new Size(60, 20);
            label13.TabIndex = 0;
            label13.Text = "Gehege";
            // 
            // colGehegeName
            // 
            colGehegeName.HeaderText = "Gehege";
            colGehegeName.MinimumWidth = 6;
            colGehegeName.Name = "colGehegeName";
            colGehegeName.ReadOnly = true;
            // 
            // colGehegeKontinent
            // 
            colGehegeKontinent.HeaderText = "Kontinent";
            colGehegeKontinent.MinimumWidth = 6;
            colGehegeKontinent.Name = "colGehegeKontinent";
            colGehegeKontinent.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGehege).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiere).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGehegeMitTieren).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPfleger).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGehegePfleger).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListBox lbKontinent;
        private TextBox tbKontinent;
        private Label label1;
        private Button btnDelKontinent;
        private Button btnKontSpeichern;
        private Button btnKontNeu;
        private Label label2;
        private Button btnTierartSpeichern;
        private ListBox lbTierart;
        private TextBox tbTierart;
        private Button btnTierartLoeschen;
        private TextBox tbGehege;
        private ComboBox cbGehegeKontinent;
        private Label label4;
        private Label label3;
        private Button btnGehegeSpeichern;
        private DataGridView dgvGehege;
        private Button btnTierartNeu;
        private Button btnGehegeNeu;
        private Button btnGehegeLoeschen;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgvTiere;
        private ComboBox cbTierTierart;
        private ComboBox cbTierGehege;
        private TextBox tbTierGeb;
        private TextBox tbTierName;
        private Button btnTierNeu;
        private Button btnTierLoeschen;
        private Button btnTierSpeichern;
        private Label label9;
        private DataGridViewTextBoxColumn colTierName;
        private DataGridViewTextBoxColumn colTierGebJahr;
        private DataGridViewTextBoxColumn colTierGehege;
        private DataGridViewTextBoxColumn colTierTierart;
        private TabPage tabPage5;
        private DataGridView dgvGehegeMitTieren;
        private DataGridViewTextBoxColumn colGehege;
        private DataGridViewTextBoxColumn colTier;
        private Label label10;
        private TabPage tabPage6;
        private DataGridView dgvPfleger;
        private DataGridViewTextBoxColumn colPflegerVorname;
        private DataGridViewTextBoxColumn colPflegerNachname;
        private TextBox tbPflegerNachn;
        private TextBox tbPflegerVorn;
        private Label label12;
        private Label label11;
        private Button btnPflegerNeu;
        private Button btnPflegerLoeschen;
        private Button btnPflegerSpeichern;
        private Button btnTierToCSV;
        private TabPage tabPage7;
        private RadioButton rbHauptpflegerJa;
        private Label label15;
        private ComboBox cbPflNachname;
        private ComboBox cbGehege;
        private Label label14;
        private Label label13;
        private Button btnGehPflSpeichern;
        private RadioButton rbHauptpflegerNein;
        private DataGridView dgvGehegePfleger;
        private DataGridViewTextBoxColumn colGehegeGP;
        private DataGridViewTextBoxColumn colPflegerVornameGP;
        private DataGridViewTextBoxColumn colPflegerNachnameGP;
        private DataGridViewTextBoxColumn colHauptpfleger;
        private Button btnGehegePflegerNeu;
        private Button btnGehegePflegerLoeschen;
        private DataGridViewTextBoxColumn colGehegeName;
        private DataGridViewTextBoxColumn colGehegeKontinent;
    }
}
