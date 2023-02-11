namespace ZleceniaMalarnia
{
    partial class ListaKlientowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaKlientowForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.malarniaDBDataSet = new ZleceniaMalarnia.MalarniaDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.klientBox = new System.Windows.Forms.TextBox();
            this.firmaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telefonBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nipBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zapiszButt = new System.Windows.Forms.Button();
            this.zmienButt = new System.Windows.Forms.Button();
            this.usuńButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adresText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.szukajCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.klienciTableAdapter = new ZleceniaMalarnia.MalarniaDBDataSetTableAdapters.KlienciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malarniaDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.idKlientaDataGridViewTextBoxColumn,
            this.klientDataGridViewTextBoxColumn,
            this.firmaDataGridViewTextBoxColumn,
            this.Adres,
            this.nIPDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klienciBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(634, 319);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybranoKlientaEvent);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybranoKlientaEvent);
            // 
            // idKlientaDataGridViewTextBoxColumn
            // 
            this.idKlientaDataGridViewTextBoxColumn.DataPropertyName = "IdKlienta";
            this.idKlientaDataGridViewTextBoxColumn.HeaderText = "IdKlienta";
            this.idKlientaDataGridViewTextBoxColumn.Name = "idKlientaDataGridViewTextBoxColumn";
            this.idKlientaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKlientaDataGridViewTextBoxColumn.Visible = false;
            // 
            // klientDataGridViewTextBoxColumn
            // 
            this.klientDataGridViewTextBoxColumn.DataPropertyName = "Klient";
            this.klientDataGridViewTextBoxColumn.HeaderText = "Klient";
            this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
            this.klientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "Firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "Firma";
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            this.firmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            this.nIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.malarniaDBDataSet;
            // 
            // malarniaDBDataSet
            // 
            this.malarniaDBDataSet.DataSetName = "MalarniaDBDataSet";
            this.malarniaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię i nazwisko";
            // 
            // klientBox
            // 
            this.klientBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klientBox.Location = new System.Drawing.Point(123, 15);
            this.klientBox.Name = "klientBox";
            this.klientBox.Size = new System.Drawing.Size(208, 23);
            this.klientBox.TabIndex = 2;
            // 
            // firmaBox
            // 
            this.firmaBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firmaBox.Location = new System.Drawing.Point(123, 41);
            this.firmaBox.Name = "firmaBox";
            this.firmaBox.Size = new System.Drawing.Size(208, 23);
            this.firmaBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(72, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firma";
            // 
            // telefonBox
            // 
            this.telefonBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonBox.Location = new System.Drawing.Point(403, 65);
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(208, 23);
            this.telefonBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(350, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // nipBox
            // 
            this.nipBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nipBox.Location = new System.Drawing.Point(123, 69);
            this.nipBox.Name = "nipBox";
            this.nipBox.Size = new System.Drawing.Size(208, 23);
            this.nipBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(86, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "NIP";
            // 
            // zapiszButt
            // 
            this.zapiszButt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapiszButt.Location = new System.Drawing.Point(255, 111);
            this.zapiszButt.Name = "zapiszButt";
            this.zapiszButt.Size = new System.Drawing.Size(75, 23);
            this.zapiszButt.TabIndex = 7;
            this.zapiszButt.Text = "Dodaj";
            this.zapiszButt.UseVisualStyleBackColor = true;
            this.zapiszButt.Click += new System.EventHandler(this.zapiszButt_Click);
            // 
            // zmienButt
            // 
            this.zmienButt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zmienButt.Location = new System.Drawing.Point(348, 111);
            this.zmienButt.Name = "zmienButt";
            this.zmienButt.Size = new System.Drawing.Size(75, 23);
            this.zmienButt.TabIndex = 8;
            this.zmienButt.Text = "Zmień";
            this.zmienButt.UseVisualStyleBackColor = true;
            this.zmienButt.Click += new System.EventHandler(this.zmienButt_Click);
            // 
            // usuńButton
            // 
            this.usuńButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usuńButton.Location = new System.Drawing.Point(443, 111);
            this.usuńButton.Name = "usuńButton";
            this.usuńButton.Size = new System.Drawing.Size(75, 23);
            this.usuńButton.TabIndex = 9;
            this.usuńButton.Text = "Usuń";
            this.usuńButton.UseVisualStyleBackColor = true;
            this.usuńButton.Click += new System.EventHandler(this.usuńButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adresText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.klientBox);
            this.panel1.Controls.Add(this.usuńButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.zmienButt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.zapiszButt);
            this.panel1.Controls.Add(this.firmaBox);
            this.panel1.Controls.Add(this.telefonBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nipBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 153);
            this.panel1.TabIndex = 12;
            // 
            // adresText
            // 
            this.adresText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adresText.Location = new System.Drawing.Point(403, 11);
            this.adresText.Multiline = true;
            this.adresText.Name = "adresText";
            this.adresText.Size = new System.Drawing.Size(208, 46);
            this.adresText.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(350, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adres";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.szukajCBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(14, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 64);
            this.panel2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(223, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // szukajCBox
            // 
            this.szukajCBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Klient",
            "Firma",
            "NIP",
            "Telefon"});
            this.szukajCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.szukajCBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szukajCBox.FormattingEnabled = true;
            this.szukajCBox.Items.AddRange(new object[] {
            "Klient",
            "Firma",
            "NIP",
            "Telefon"});
            this.szukajCBox.Location = new System.Drawing.Point(88, 17);
            this.szukajCBox.Name = "szukajCBox";
            this.szukajCBox.Size = new System.Drawing.Size(121, 23);
            this.szukajCBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Szukaj w:";
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // ListaKlientowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(661, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(677, 611);
            this.Name = "ListaKlientowForm";
            this.Text = "Lista Klientów";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malarniaDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MalarniaDBDataSet malarniaDBDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private MalarniaDBDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox klientBox;
        private System.Windows.Forms.TextBox firmaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telefonBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nipBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button zapiszButt;
        private System.Windows.Forms.Button zmienButt;
        private System.Windows.Forms.Button usuńButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox szukajCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adresText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}