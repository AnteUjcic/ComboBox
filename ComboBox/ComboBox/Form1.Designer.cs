namespace ComboBox
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
            this.cmdIzbornik = new System.Windows.Forms.ComboBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnPoruka = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdIzbornik
            // 
            this.cmdIzbornik.FormattingEnabled = true;
            this.cmdIzbornik.Items.AddRange(new object[] {
            "Peugeot 305 1976",
            " Renault 8",
            "Yugo 45",
            "Golf II",
            "Ford Tarnus 1974.",
            "¸"});
            this.cmdIzbornik.Location = new System.Drawing.Point(65, 61);
            this.cmdIzbornik.Name = "cmdIzbornik";
            this.cmdIzbornik.Size = new System.Drawing.Size(121, 21);
            this.cmdIzbornik.TabIndex = 0;
            this.cmdIzbornik.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(55, 180);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(242, 20);
            this.txtIspis.TabIndex = 1;
            this.txtIspis.TextChanged += new System.EventHandler(this.TxtIspis_TextChanged);
            // 
            // btnPoruka
            // 
            this.btnPoruka.Location = new System.Drawing.Point(610, 343);
            this.btnPoruka.Name = "btnPoruka";
            this.btnPoruka.Size = new System.Drawing.Size(122, 63);
            this.btnPoruka.TabIndex = 2;
            this.btnPoruka.Text = "prikazi poruku";
            this.btnPoruka.UseVisualStyleBackColor = true;
            this.btnPoruka.Click += new System.EventHandler(this.BtnPoruka_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(403, 363);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(107, 43);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbrisi poruku";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPoruka);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.cmdIzbornik);
            this.Name = "Form1";
            this.Text = "ComboBoxVjezba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdIzbornik;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnPoruka;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}

