namespace ZleceniaMalarnia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noweZlButton = new System.Windows.Forms.Button();
            this.usunButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WZButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.szukajCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rachunekButton = new System.Windows.Forms.Button();
            this.raportButton = new System.Windows.Forms.Button();
            this.fakturaButton = new System.Windows.Forms.Button();
            this.SzukajNiezaplaconychButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trwaButton = new System.Windows.Forms.Button();
            this.zakonczButton = new System.Windows.Forms.Button();
            this.MojToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.zleceniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.malarniaDBDataSet = new ZleceniaMalarnia.MalarniaDBDataSet();
            this.zleceniaTableAdapter = new ZleceniaMalarnia.MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrzyjeciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZakonczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrZlecenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zleceniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malarniaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.klientDataGridViewTextBoxColumn,
            this.dataPrzyjeciaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.CenaVAT,
            this.statusDataGridViewTextBoxColumn,
            this.idKlientaDataGridViewTextBoxColumn,
            this.dataZakonczeniaDataGridViewTextBoxColumn,
            this.NrZlecenia});
            this.dataGridView1.DataSource = this.zleceniaBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(28, 132);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(922, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EdytujZlecenieDoubleCellClickEvent);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // noweZlButton
            // 
            this.noweZlButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noweZlButton.Location = new System.Drawing.Point(28, 23);
            this.noweZlButton.Name = "noweZlButton";
            this.noweZlButton.Size = new System.Drawing.Size(160, 36);
            this.noweZlButton.TabIndex = 1;
            this.noweZlButton.Text = "Nowe Zlecenie";
            this.MojToolTip.SetToolTip(this.noweZlButton, "Tworzy nowe zlecenie");
            this.noweZlButton.UseVisualStyleBackColor = true;
            this.noweZlButton.Click += new System.EventHandler(this.noweZlButton_Click);
            // 
            // usunButton
            // 
            this.usunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usunButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunButton.Location = new System.Drawing.Point(875, 478);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(75, 23);
            this.usunButton.TabIndex = 2;
            this.usunButton.Text = "Usuń";
            this.MojToolTip.SetToolTip(this.usunButton, "Całkowicie usuwa wybrane zlecenie.");
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(228, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lista Klientów";
            this.MojToolTip.SetToolTip(this.button1, "Wyswietla i pozwala edytować listę zapisanych klientów");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WZButton
            // 
            this.WZButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WZButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WZButton.Location = new System.Drawing.Point(722, 23);
            this.WZButton.Name = "WZButton";
            this.WZButton.Size = new System.Drawing.Size(216, 36);
            this.WZButton.TabIndex = 6;
            this.WZButton.Text = "Rachunek";
            this.MojToolTip.SetToolTip(this.WZButton, "Tworzy i pozwala wydrukować rachunek");
            this.WZButton.UseVisualStyleBackColor = true;
            this.WZButton.Click += new System.EventHandler(this.WZButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(608, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Program by © Bartosz Orzechowski";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(608, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "v1.6 - 2021";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.szukajCBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rachunekButton);
            this.panel2.Location = new System.Drawing.Point(28, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 61);
            this.panel2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(226, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 23);
            this.textBox1.TabIndex = 2;
            this.MojToolTip.SetToolTip(this.textBox1, "Okno wyszukiwania");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // szukajCBox
            // 
            this.szukajCBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Klient",
            "Firma",
            "NIP",
            "Telefon",
            "ID",
            "Nr Zlecenia"});
            this.szukajCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.szukajCBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szukajCBox.Items.AddRange(new object[] {
            "Klient",
            "Data Przyjęcia",
            "Data Zakończenia",
            "ID",
            "Nr Zlecenia"});
            this.szukajCBox.Location = new System.Drawing.Point(89, 19);
            this.szukajCBox.Name = "szukajCBox";
            this.szukajCBox.Size = new System.Drawing.Size(121, 23);
            this.szukajCBox.TabIndex = 1;
            this.MojToolTip.SetToolTip(this.szukajCBox, "Pozwala wybrać kryteria wyszukiwania");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Szukaj w:";
            // 
            // rachunekButton
            // 
            this.rachunekButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rachunekButton.Enabled = false;
            this.rachunekButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rachunekButton.Location = new System.Drawing.Point(777, 10);
            this.rachunekButton.Name = "rachunekButton";
            this.rachunekButton.Size = new System.Drawing.Size(133, 36);
            this.rachunekButton.TabIndex = 15;
            this.rachunekButton.Text = "RNieaktywny";
            this.MojToolTip.SetToolTip(this.rachunekButton, "Tworzy i pozwala wydrukować Rachunek dla klienta");
            this.rachunekButton.UseVisualStyleBackColor = true;
            this.rachunekButton.Visible = false;
            this.rachunekButton.Click += new System.EventHandler(this.rachunekButton_Click);
            // 
            // raportButton
            // 
            this.raportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.raportButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.raportButton.Location = new System.Drawing.Point(311, 481);
            this.raportButton.Name = "raportButton";
            this.raportButton.Size = new System.Drawing.Size(75, 23);
            this.raportButton.TabIndex = 19;
            this.raportButton.Text = "Raport";
            this.MojToolTip.SetToolTip(this.raportButton, "Generuje i pozwala wydrukować raport, sumy netto zleceń widocznych w oknie zleceń" +
        ".");
            this.raportButton.UseVisualStyleBackColor = true;
            this.raportButton.Click += new System.EventHandler(this.raportButton_Click);
            // 
            // fakturaButton
            // 
            this.fakturaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fakturaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fakturaButton.Image = ((System.Drawing.Image)(resources.GetObject("fakturaButton.Image")));
            this.fakturaButton.Location = new System.Drawing.Point(79, 474);
            this.fakturaButton.Name = "fakturaButton";
            this.fakturaButton.Size = new System.Drawing.Size(36, 36);
            this.fakturaButton.TabIndex = 18;
            this.MojToolTip.SetToolTip(this.fakturaButton, "Oznacza wystawienie faktury i oczekiwanie na zapłatę wybranego zlecenia");
            this.fakturaButton.UseVisualStyleBackColor = true;
            this.fakturaButton.Click += new System.EventHandler(this.fakturaButton_Click);
            // 
            // SzukajNiezaplaconychButton
            // 
            this.SzukajNiezaplaconychButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SzukajNiezaplaconychButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SzukajNiezaplaconychButton.Image = global::ZleceniaMalarnia.Properties.Resources.szukajOff;
            this.SzukajNiezaplaconychButton.Location = new System.Drawing.Point(216, 474);
            this.SzukajNiezaplaconychButton.Name = "SzukajNiezaplaconychButton";
            this.SzukajNiezaplaconychButton.Size = new System.Drawing.Size(36, 36);
            this.SzukajNiezaplaconychButton.TabIndex = 17;
            this.MojToolTip.SetToolTip(this.SzukajNiezaplaconychButton, "Sortuje liste zleceń, nie zapłacone od góry");
            this.SzukajNiezaplaconychButton.UseVisualStyleBackColor = true;
            this.SzukajNiezaplaconychButton.Click += new System.EventHandler(this.SzukajNiezaplaconychButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Image = global::ZleceniaMalarnia.Properties.Resources.footer_logo2;
            this.label1.Location = new System.Drawing.Point(392, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 7;
            // 
            // trwaButton
            // 
            this.trwaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trwaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trwaButton.Image = global::ZleceniaMalarnia.Properties.Resources.ikonacross;
            this.trwaButton.Location = new System.Drawing.Point(142, 474);
            this.trwaButton.Name = "trwaButton";
            this.trwaButton.Size = new System.Drawing.Size(36, 36);
            this.trwaButton.TabIndex = 5;
            this.MojToolTip.SetToolTip(this.trwaButton, "Oznacza jako nie zakończone wybrane zlecenie.");
            this.trwaButton.UseVisualStyleBackColor = true;
            this.trwaButton.Click += new System.EventHandler(this.trwaButton_Click);
            // 
            // zakonczButton
            // 
            this.zakonczButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zakonczButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zakonczButton.Image = global::ZleceniaMalarnia.Properties.Resources.ikona_ok;
            this.zakonczButton.Location = new System.Drawing.Point(28, 474);
            this.zakonczButton.Name = "zakonczButton";
            this.zakonczButton.Size = new System.Drawing.Size(36, 36);
            this.zakonczButton.TabIndex = 4;
            this.MojToolTip.SetToolTip(this.zakonczButton, "Potwierdza otrzymanie zapłaty i zakańcza wybrane zlecenie");
            this.zakonczButton.UseVisualStyleBackColor = true;
            this.zakonczButton.Click += new System.EventHandler(this.zakonczButton_Click);
            // 
            // zleceniaBindingSource
            // 
            this.zleceniaBindingSource.DataMember = "Zlecenia";
            this.zleceniaBindingSource.DataSource = this.malarniaDBDataSet;
            // 
            // malarniaDBDataSet
            // 
            this.malarniaDBDataSet.DataSetName = "MalarniaDBDataSet";
            this.malarniaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zleceniaTableAdapter
            // 
            this.zleceniaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 47;
            // 
            // klientDataGridViewTextBoxColumn
            // 
            this.klientDataGridViewTextBoxColumn.DataPropertyName = "Klient";
            this.klientDataGridViewTextBoxColumn.HeaderText = "Klient";
            this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
            // 
            // dataPrzyjeciaDataGridViewTextBoxColumn
            // 
            this.dataPrzyjeciaDataGridViewTextBoxColumn.DataPropertyName = "DataPrzyjecia";
            this.dataPrzyjeciaDataGridViewTextBoxColumn.HeaderText = "Data Przyjecia";
            this.dataPrzyjeciaDataGridViewTextBoxColumn.Name = "dataPrzyjeciaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // CenaVAT
            // 
            this.CenaVAT.DataPropertyName = "CenaVAT";
            this.CenaVAT.HeaderText = "Cena z VAT";
            this.CenaVAT.Name = "CenaVAT";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // idKlientaDataGridViewTextBoxColumn
            // 
            this.idKlientaDataGridViewTextBoxColumn.DataPropertyName = "idKlienta";
            this.idKlientaDataGridViewTextBoxColumn.HeaderText = "idKlienta";
            this.idKlientaDataGridViewTextBoxColumn.Name = "idKlientaDataGridViewTextBoxColumn";
            this.idKlientaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataZakonczeniaDataGridViewTextBoxColumn
            // 
            this.dataZakonczeniaDataGridViewTextBoxColumn.DataPropertyName = "DataZakonczenia";
            this.dataZakonczeniaDataGridViewTextBoxColumn.HeaderText = "Data Zakonczenia";
            this.dataZakonczeniaDataGridViewTextBoxColumn.Name = "dataZakonczeniaDataGridViewTextBoxColumn";
            // 
            // NrZlecenia
            // 
            this.NrZlecenia.DataPropertyName = "NrZlecenia";
            this.NrZlecenia.HeaderText = "Nr Zlecenia";
            this.NrZlecenia.Name = "NrZlecenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(985, 525);
            this.Controls.Add(this.raportButton);
            this.Controls.Add(this.fakturaButton);
            this.Controls.Add(this.SzukajNiezaplaconychButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WZButton);
            this.Controls.Add(this.trwaButton);
            this.Controls.Add(this.zakonczButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usunButton);
            this.Controls.Add(this.noweZlButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1001, 564);
            this.Name = "Form1";
            this.Text = "Malarnia Proszkowa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zleceniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malarniaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZleceniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button noweZlButton;
        private System.Windows.Forms.Button usunButton;
        private MalarniaDBDataSet malarniaDBDataSet;
        private System.Windows.Forms.BindingSource zleceniaBindingSource;
        private MalarniaDBDataSetTableAdapters.ZleceniaTableAdapter zleceniaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button zakonczButton;
        private System.Windows.Forms.Button trwaButton;
        private System.Windows.Forms.Button WZButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox szukajCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rachunekButton;
        private System.Windows.Forms.Button SzukajNiezaplaconychButton;
        private System.Windows.Forms.Button fakturaButton;
        private System.Windows.Forms.Button raportButton;
        private System.Windows.Forms.ToolTip MojToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrzyjeciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZakonczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrZlecenia;
    }
}

