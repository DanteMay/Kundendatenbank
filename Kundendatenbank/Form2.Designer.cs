namespace Kundendatenbank
{
    partial class newcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newcustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbvorname = new System.Windows.Forms.TextBox();
            this.tbnummer = new System.Windows.Forms.TextBox();
            this.tbnachname = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loutput = new System.Windows.Forms.Label();
            this.kundenTableAdapter1 = new Kundendatenbank.KundendatenbankDataSetTableAdapters.KundenTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kundennummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vorname";
            // 
            // tbvorname
            // 
            this.tbvorname.Location = new System.Drawing.Point(130, 109);
            this.tbvorname.Name = "tbvorname";
            this.tbvorname.Size = new System.Drawing.Size(217, 20);
            this.tbvorname.TabIndex = 3;
            // 
            // tbnummer
            // 
            this.tbnummer.Location = new System.Drawing.Point(130, 56);
            this.tbnummer.Name = "tbnummer";
            this.tbnummer.ReadOnly = true;
            this.tbnummer.Size = new System.Drawing.Size(217, 20);
            this.tbnummer.TabIndex = 4;
            this.tbnummer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbnachname
            // 
            this.tbnachname.Location = new System.Drawing.Point(130, 81);
            this.tbnachname.Name = "tbnachname";
            this.tbnachname.Size = new System.Drawing.Size(217, 20);
            this.tbnachname.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(35, 155);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Speichern";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(272, 155);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Abbrechen";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Neuen Kunden hinzufügen";
            // 
            // loutput
            // 
            this.loutput.AutoSize = true;
            this.loutput.Location = new System.Drawing.Point(150, 160);
            this.loutput.Name = "loutput";
            this.loutput.Size = new System.Drawing.Size(35, 13);
            this.loutput.TabIndex = 9;
            this.loutput.Text = "label5";
            // 
            // kundenTableAdapter1
            // 
            this.kundenTableAdapter1.ClearBeforeFill = true;
            // 
            // newcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 212);
            this.Controls.Add(this.loutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tbnachname);
            this.Controls.Add(this.tbnummer);
            this.Controls.Add(this.tbvorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newcustomer";
            this.Text = "Neuen Kunden hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbvorname;
        private System.Windows.Forms.TextBox tbnummer;
        private System.Windows.Forms.TextBox tbnachname;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loutput;
        private KundendatenbankDataSetTableAdapters.KundenTableAdapter kundenTableAdapter1;
    }
}