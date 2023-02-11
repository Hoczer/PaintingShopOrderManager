namespace ZleceniaMalarnia
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.klientButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaJmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumaVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrZleceniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.malarniaDBDataSet = new ZleceniaMalarnia.MalarniaDBDataSet();
            this.nazwaPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iloscBox = new System.Windows.Forms.TextBox();
            this.JmCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kolorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cenaJmBox = new System.Windows.Forms.TextBox();
            this.dodajButt = new System.Windows.Forms.Button();
            this.edytujButt = new System.Windows.Forms.Button();
            this.usunButt = new System.Windows.Forms.Button();
            this.produktyTableAdapter = new ZleceniaMalarnia.MalarniaDBDataSetTableAdapters.ProduktyTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.imieLabel = new System.Windows.Forms.Label();
            this.nipLabel = new System.Windows.Forms.Label();
            this.firmaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malarniaDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // klientButton
            // 
            this.klientButton.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klientButton.Location = new System.Drawing.Point(25, 12);
            this.klientButton.Name = "klientButton";
            this.klientButton.Size = new System.Drawing.Size(161, 84);
            this.klientButton.TabIndex = 0;
            this.klientButton.Text = "Klient";
            this.klientButton.UseVisualStyleBackColor = true;
            this.klientButton.Click += new System.EventHandler(this.klientButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduktuDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.jmDataGridViewTextBoxColumn,
            this.kolorDataGridViewTextBoxColumn,
            this.cenaJmDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.SumaVAT,
            this.nrZleceniaDataGridViewTextBoxColumn,
            this.klientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(856, 318);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybranoWierszCellClick);
            // 
            // idProduktuDataGridViewTextBoxColumn
            // 
            this.idProduktuDataGridViewTextBoxColumn.DataPropertyName = "IdProduktu";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idProduktuDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idProduktuDataGridViewTextBoxColumn.HeaderText = "IdProduktu";
            this.idProduktuDataGridViewTextBoxColumn.Name = "idProduktuDataGridViewTextBoxColumn";
            this.idProduktuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProduktuDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            // 
            // jmDataGridViewTextBoxColumn
            // 
            this.jmDataGridViewTextBoxColumn.DataPropertyName = "Jm";
            this.jmDataGridViewTextBoxColumn.HeaderText = "J.m.";
            this.jmDataGridViewTextBoxColumn.Name = "jmDataGridViewTextBoxColumn";
            // 
            // kolorDataGridViewTextBoxColumn
            // 
            this.kolorDataGridViewTextBoxColumn.DataPropertyName = "Kolor";
            this.kolorDataGridViewTextBoxColumn.HeaderText = "Kolor";
            this.kolorDataGridViewTextBoxColumn.Name = "kolorDataGridViewTextBoxColumn";
            // 
            // cenaJmDataGridViewTextBoxColumn
            // 
            this.cenaJmDataGridViewTextBoxColumn.DataPropertyName = "CenaJm";
            this.cenaJmDataGridViewTextBoxColumn.HeaderText = "Cena/Jm.";
            this.cenaJmDataGridViewTextBoxColumn.Name = "cenaJmDataGridViewTextBoxColumn";
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            // 
            // SumaVAT
            // 
            this.SumaVAT.DataPropertyName = "SumaVAT";
            this.SumaVAT.HeaderText = "Cena z VAT";
            this.SumaVAT.Name = "SumaVAT";
            // 
            // nrZleceniaDataGridViewTextBoxColumn
            // 
            this.nrZleceniaDataGridViewTextBoxColumn.DataPropertyName = "nrZlecenia";
            this.nrZleceniaDataGridViewTextBoxColumn.HeaderText = "nrZlecenia";
            this.nrZleceniaDataGridViewTextBoxColumn.Name = "nrZleceniaDataGridViewTextBoxColumn";
            this.nrZleceniaDataGridViewTextBoxColumn.Visible = false;
            // 
            // klientIDDataGridViewTextBoxColumn
            // 
            this.klientIDDataGridViewTextBoxColumn.DataPropertyName = "KlientID";
            this.klientIDDataGridViewTextBoxColumn.HeaderText = "KlientID";
            this.klientIDDataGridViewTextBoxColumn.Name = "klientIDDataGridViewTextBoxColumn";
            this.klientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.malarniaDBDataSet;
            // 
            // malarniaDBDataSet
            // 
            this.malarniaDBDataSet.DataSetName = "MalarniaDBDataSet";
            this.malarniaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazwaPBox
            // 
            this.nazwaPBox.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaPBox.Location = new System.Drawing.Point(22, 133);
            this.nazwaPBox.Name = "nazwaPBox";
            this.nazwaPBox.Size = new System.Drawing.Size(237, 24);
            this.nazwaPBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(273, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ilość";
            // 
            // iloscBox
            // 
            this.iloscBox.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscBox.Location = new System.Drawing.Point(276, 133);
            this.iloscBox.Name = "iloscBox";
            this.iloscBox.Size = new System.Drawing.Size(42, 24);
            this.iloscBox.TabIndex = 4;
            // 
            // JmCombo
            // 
            this.JmCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JmCombo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JmCombo.FormattingEnabled = true;
            this.JmCombo.Items.AddRange(new object[] {
            "szt.",
            "mb.",
            "kg.",
            "m2."});
            this.JmCombo.Location = new System.Drawing.Point(333, 132);
            this.JmCombo.Name = "JmCombo";
            this.JmCombo.Size = new System.Drawing.Size(93, 25);
            this.JmCombo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "J.m.";
            // 
            // kolorBox
            // 
            this.kolorBox.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolorBox.Location = new System.Drawing.Point(441, 133);
            this.kolorBox.Name = "kolorBox";
            this.kolorBox.Size = new System.Drawing.Size(147, 24);
            this.kolorBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(438, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kolor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(591, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cena/J.m";
            // 
            // cenaJmBox
            // 
            this.cenaJmBox.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cenaJmBox.Location = new System.Drawing.Point(594, 133);
            this.cenaJmBox.Name = "cenaJmBox";
            this.cenaJmBox.Size = new System.Drawing.Size(100, 24);
            this.cenaJmBox.TabIndex = 12;
            // 
            // dodajButt
            // 
            this.dodajButt.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajButt.Location = new System.Drawing.Point(700, 130);
            this.dodajButt.Name = "dodajButt";
            this.dodajButt.Size = new System.Drawing.Size(75, 27);
            this.dodajButt.TabIndex = 14;
            this.dodajButt.Text = "Dodaj";
            this.dodajButt.UseVisualStyleBackColor = true;
            this.dodajButt.Click += new System.EventHandler(this.dodajButt_Click);
            // 
            // edytujButt
            // 
            this.edytujButt.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujButt.Location = new System.Drawing.Point(793, 130);
            this.edytujButt.Name = "edytujButt";
            this.edytujButt.Size = new System.Drawing.Size(75, 27);
            this.edytujButt.TabIndex = 15;
            this.edytujButt.Text = "Edytuj";
            this.edytujButt.UseVisualStyleBackColor = true;
            this.edytujButt.Click += new System.EventHandler(this.edytujButt_Click);
            // 
            // usunButt
            // 
            this.usunButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usunButt.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunButt.Location = new System.Drawing.Point(12, 493);
            this.usunButt.Name = "usunButt";
            this.usunButt.Size = new System.Drawing.Size(75, 35);
            this.usunButt.TabIndex = 16;
            this.usunButt.Text = "Usuń";
            this.usunButt.UseVisualStyleBackColor = true;
            this.usunButt.Click += new System.EventHandler(this.usunButt_Click);
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefonLabel);
            this.groupBox1.Controls.Add(this.imieLabel);
            this.groupBox1.Controls.Add(this.nipLabel);
            this.groupBox1.Controls.Add(this.firmaLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(192, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klient:";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.telefonLabel.Location = new System.Drawing.Point(333, 46);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(74, 19);
            this.telefonLabel.TabIndex = 4;
            this.telefonLabel.Text = "Telefon: ";
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imieLabel.Location = new System.Drawing.Point(6, 24);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(126, 18);
            this.imieLabel.TabIndex = 1;
            this.imieLabel.Text = "Imię i nazwisko: ";
            // 
            // nipLabel
            // 
            this.nipLabel.AutoSize = true;
            this.nipLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nipLabel.Location = new System.Drawing.Point(6, 47);
            this.nipLabel.Name = "nipLabel";
            this.nipLabel.Size = new System.Drawing.Size(46, 19);
            this.nipLabel.TabIndex = 3;
            this.nipLabel.Text = "NIP: ";
            // 
            // firmaLabel
            // 
            this.firmaLabel.AutoSize = true;
            this.firmaLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firmaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.firmaLabel.Location = new System.Drawing.Point(333, 23);
            this.firmaLabel.Name = "firmaLabel";
            this.firmaLabel.Size = new System.Drawing.Size(63, 19);
            this.firmaLabel.TabIndex = 2;
            this.firmaLabel.Text = "Firma: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usunButt);
            this.Controls.Add(this.edytujButt);
            this.Controls.Add(this.dodajButt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cenaJmBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kolorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JmCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iloscBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazwaPBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.klientButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 579);
            this.Name = "Form2";
            this.Text = "Nowe Zlecenie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malarniaDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button klientButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MalarniaDBDataSet malarniaDBDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private MalarniaDBDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.TextBox nazwaPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iloscBox;
        private System.Windows.Forms.ComboBox JmCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kolorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cenaJmBox;
        private System.Windows.Forms.Button dodajButt;
        private System.Windows.Forms.Button edytujButt;
        private System.Windows.Forms.Button usunButt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Label nipLabel;
        private System.Windows.Forms.Label firmaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaJmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumaVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZleceniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientIDDataGridViewTextBoxColumn;
    }
}