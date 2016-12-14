namespace Kundendatenbank
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvmain = new System.Windows.Forms.DataGridView();
            this.kundenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbsuchen = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnummer = new System.Windows.Forms.TextBox();
            this.tbnachname = new System.Windows.Forms.TextBox();
            this.tbvorname = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kundendatenbankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundendatenbankDataSet = new Kundendatenbank.KundendatenbankDataSet();
            this.kundennummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundenTableAdapter = new Kundendatenbank.KundendatenbankDataSetTableAdapters.KundenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundendatenbankDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundendatenbankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmain
            // 
            this.dgvmain.AllowUserToOrderColumns = true;
            this.dgvmain.AutoGenerateColumns = false;
            this.dgvmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kundennummerDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn});
            this.dgvmain.DataSource = this.kundenBindingSource;
            this.dgvmain.Location = new System.Drawing.Point(12, 264);
            this.dgvmain.Name = "dgvmain";
            this.dgvmain.ReadOnly = true;
            this.dgvmain.RowHeadersVisible = false;
            this.dgvmain.Size = new System.Drawing.Size(358, 431);
            this.dgvmain.TabIndex = 0;
            this.dgvmain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmain_CellClick);
            this.dgvmain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmain_CellContentDoubleClick);
            // 
            // kundenBindingSource
            // 
            this.kundenBindingSource.DataMember = "Kunden";
            this.kundenBindingSource.DataSource = this.kundendatenbankDataSetBindingSource;
            // 
            // tbsuchen
            // 
            this.tbsuchen.Location = new System.Drawing.Point(12, 239);
            this.tbsuchen.Name = "tbsuchen";
            this.tbsuchen.Size = new System.Drawing.Size(141, 20);
            this.tbsuchen.TabIndex = 1;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(16, 119);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(141, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Bearbeiten";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(16, 148);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(141, 23);
            this.btnnew.TabIndex = 3;
            this.btnnew.Text = "Neuer Kunde";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(229, 763);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(141, 23);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Schließen";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsuchen
            // 
            this.btnsuchen.Location = new System.Drawing.Point(159, 237);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(141, 23);
            this.btnsuchen.TabIndex = 5;
            this.btnsuchen.Text = "Suchen";
            this.btnsuchen.UseVisualStyleBackColor = true;
            this.btnsuchen.Click += new System.EventHandler(this.btnsuchen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kundennr.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vorname";
            // 
            // tbnummer
            // 
            this.tbnummer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundenBindingSource, "Kundennummer", true));
            this.tbnummer.Location = new System.Drawing.Point(86, 14);
            this.tbnummer.Name = "tbnummer";
            this.tbnummer.Size = new System.Drawing.Size(166, 20);
            this.tbnummer.TabIndex = 6;
            // 
            // tbnachname
            // 
            this.tbnachname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundenBindingSource, "Nachname", true));
            this.tbnachname.Location = new System.Drawing.Point(86, 40);
            this.tbnachname.Name = "tbnachname";
            this.tbnachname.Size = new System.Drawing.Size(166, 20);
            this.tbnachname.TabIndex = 7;
            // 
            // tbvorname
            // 
            this.tbvorname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundenBindingSource, "Vorname", true));
            this.tbvorname.Location = new System.Drawing.Point(86, 66);
            this.tbvorname.Name = "tbvorname";
            this.tbvorname.Size = new System.Drawing.Size(166, 20);
            this.tbvorname.TabIndex = 8;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(16, 177);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(141, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Kunde löschen";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // kundendatenbankDataSetBindingSource
            // 
            this.kundendatenbankDataSetBindingSource.DataSource = this.kundendatenbankDataSet;
            this.kundendatenbankDataSetBindingSource.Position = 0;
            // 
            // kundendatenbankDataSet
            // 
            this.kundendatenbankDataSet.DataSetName = "KundendatenbankDataSet";
            this.kundendatenbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundennummerDataGridViewTextBoxColumn
            // 
            this.kundennummerDataGridViewTextBoxColumn.DataPropertyName = "Kundennummer";
            this.kundennummerDataGridViewTextBoxColumn.HeaderText = "Kundennummer";
            this.kundennummerDataGridViewTextBoxColumn.Name = "kundennummerDataGridViewTextBoxColumn";
            this.kundennummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            this.nachnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundenTableAdapter
            // 
            this.kundenTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 806);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.tbvorname);
            this.Controls.Add(this.tbnachname);
            this.Controls.Add(this.tbnummer);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbsuchen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvmain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hauptdingens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundendatenbankDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundendatenbankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmain;
        private System.Windows.Forms.TextBox tbsuchen;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnummer;
        private System.Windows.Forms.TextBox tbnachname;
        private System.Windows.Forms.TextBox tbvorname;
        private System.Windows.Forms.BindingSource kundendatenbankDataSetBindingSource;
        private KundendatenbankDataSet kundendatenbankDataSet;
        private System.Windows.Forms.BindingSource kundenBindingSource;
        private KundendatenbankDataSetTableAdapters.KundenTableAdapter kundenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundennummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label4;
    }
}

