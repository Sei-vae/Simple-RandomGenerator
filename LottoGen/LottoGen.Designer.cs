namespace LottoGen
{
    partial class LottoGen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbAktZiehung = new System.Windows.Forms.GroupBox();
            this.lblZiehungWerte = new System.Windows.Forms.Label();
            this.gpbHaeufigkeit = new System.Windows.Forms.GroupBox();
            this.txtHaufig = new System.Windows.Forms.TextBox();
            this.btnZiehen = new System.Windows.Forms.Button();
            this.lblDopp = new System.Windows.Forms.Label();
            this.gpbAktZiehung.SuspendLayout();
            this.gpbHaeufigkeit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAktZiehung
            // 
            this.gpbAktZiehung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAktZiehung.Controls.Add(this.lblZiehungWerte);
            this.gpbAktZiehung.Location = new System.Drawing.Point(20, 19);
            this.gpbAktZiehung.Name = "gpbAktZiehung";
            this.gpbAktZiehung.Size = new System.Drawing.Size(244, 49);
            this.gpbAktZiehung.TabIndex = 2;
            this.gpbAktZiehung.TabStop = false;
            this.gpbAktZiehung.Text = "Aktuelle Ziehung ";
            // 
            // lblZiehungWerte
            // 
            this.lblZiehungWerte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZiehungWerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZiehungWerte.Location = new System.Drawing.Point(3, 16);
            this.lblZiehungWerte.Name = "lblZiehungWerte";
            this.lblZiehungWerte.Size = new System.Drawing.Size(238, 30);
            this.lblZiehungWerte.TabIndex = 1;
            this.lblZiehungWerte.Text = "xx-xx-xx-xx-xx-xx";
            this.lblZiehungWerte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbHaeufigkeit
            // 
            this.gpbHaeufigkeit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbHaeufigkeit.Controls.Add(this.txtHaufig);
            this.gpbHaeufigkeit.Location = new System.Drawing.Point(20, 77);
            this.gpbHaeufigkeit.Name = "gpbHaeufigkeit";
            this.gpbHaeufigkeit.Size = new System.Drawing.Size(244, 339);
            this.gpbHaeufigkeit.TabIndex = 3;
            this.gpbHaeufigkeit.TabStop = false;
            this.gpbHaeufigkeit.Text = "Häufigkeit";
            // 
            // txtHaufig
            // 
            this.txtHaufig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHaufig.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHaufig.Location = new System.Drawing.Point(3, 16);
            this.txtHaufig.Multiline = true;
            this.txtHaufig.Name = "txtHaufig";
            this.txtHaufig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHaufig.Size = new System.Drawing.Size(238, 320);
            this.txtHaufig.TabIndex = 2;
            // 
            // btnZiehen
            // 
            this.btnZiehen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZiehen.Location = new System.Drawing.Point(20, 428);
            this.btnZiehen.Name = "btnZiehen";
            this.btnZiehen.Size = new System.Drawing.Size(240, 43);
            this.btnZiehen.TabIndex = 4;
            this.btnZiehen.Text = "Ziehen";
            this.btnZiehen.UseVisualStyleBackColor = true;
            this.btnZiehen.Click += new System.EventHandler(this.btnZiehen_Click);
            // 
            // lblDopp
            // 
            this.lblDopp.AutoSize = true;
            this.lblDopp.Location = new System.Drawing.Point(195, 16);
            this.lblDopp.Name = "lblDopp";
            this.lblDopp.Size = new System.Drawing.Size(60, 13);
            this.lblDopp.TabIndex = 5;
            this.lblDopp.Text = "Doppler: xx";
            // 
            // LottoGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 487);
            this.Controls.Add(this.lblDopp);
            this.Controls.Add(this.btnZiehen);
            this.Controls.Add(this.gpbHaeufigkeit);
            this.Controls.Add(this.gpbAktZiehung);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(298, 525);
            this.Name = "LottoGen";
            this.Text = "Lotto-Generator";
            this.gpbAktZiehung.ResumeLayout(false);
            this.gpbHaeufigkeit.ResumeLayout(false);
            this.gpbHaeufigkeit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAktZiehung;
        private System.Windows.Forms.Label lblZiehungWerte;
        private System.Windows.Forms.GroupBox gpbHaeufigkeit;
        private System.Windows.Forms.TextBox txtHaufig;
        private System.Windows.Forms.Button btnZiehen;
        private System.Windows.Forms.Label lblDopp;
    }
}

