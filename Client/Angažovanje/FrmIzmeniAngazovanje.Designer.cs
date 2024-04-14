using System.Windows.Forms;

namespace Client
{
    partial class FrmIzmeniAngazovanje
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
            this.btnIzmeniAngazovanje = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAngazovanja = new System.Windows.Forms.Label();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.dgvCenovnik = new System.Windows.Forms.DataGridView();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.dgvStavkeA = new System.Windows.Forms.DataGridView();
            this.txtDekoracija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPretragaCenovnika = new System.Windows.Forms.Button();
            this.txtPdv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtImeRadnika = new System.Windows.Forms.TextBox();
            this.lblPretraziRadnike = new System.Windows.Forms.Label();
            this.dgvAngazovanja = new System.Windows.Forms.DataGridView();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenovnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzmeniAngazovanje
            // 
            this.btnIzmeniAngazovanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniAngazovanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniAngazovanje.Location = new System.Drawing.Point(409, 764);
            this.btnIzmeniAngazovanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniAngazovanje.Name = "btnIzmeniAngazovanje";
            this.btnIzmeniAngazovanje.Size = new System.Drawing.Size(225, 42);
            this.btnIzmeniAngazovanje.TabIndex = 60;
            this.btnIzmeniAngazovanje.Text = "Sacuvaj angažovanje";
            this.btnIzmeniAngazovanje.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUkupanIznos);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblAngazovanja);
            this.panel3.Controls.Add(this.btnObrisiStavku);
            this.panel3.Controls.Add(this.dgvCenovnik);
            this.panel3.Controls.Add(this.txtKolicina);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnDodajStavku);
            this.panel3.Controls.Add(this.dgvStavkeA);
            this.panel3.Controls.Add(this.txtDekoracija);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnPretragaCenovnika);
            this.panel3.Controls.Add(this.txtPdv);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(18, 450);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 284);
            this.panel3.TabIndex = 59;
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUkupanIznos.Location = new System.Drawing.Point(639, 248);
            this.txtUkupanIznos.Margin = new System.Windows.Forms.Padding(4);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.ReadOnly = true;
            this.txtUkupanIznos.Size = new System.Drawing.Size(132, 22);
            this.txtUkupanIznos.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Ukupan iznos:";
            // 
            // lblAngazovanja
            // 
            this.lblAngazovanja.AutoSize = true;
            this.lblAngazovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngazovanja.Location = new System.Drawing.Point(271, -98);
            this.lblAngazovanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngazovanja.Name = "lblAngazovanja";
            this.lblAngazovanja.Size = new System.Drawing.Size(138, 25);
            this.lblAngazovanja.TabIndex = 6;
            this.lblAngazovanja.Text = "Angažovanja";
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiStavku.Location = new System.Drawing.Point(841, 204);
            this.btnObrisiStavku.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(186, 28);
            this.btnObrisiStavku.TabIndex = 30;
            this.btnObrisiStavku.Text = "Obrisi selektovanu stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            // 
            // dgvCenovnik
            // 
            this.dgvCenovnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCenovnik.Location = new System.Drawing.Point(639, 17);
            this.dgvCenovnik.Name = "dgvCenovnik";
            this.dgvCenovnik.RowHeadersWidth = 51;
            this.dgvCenovnik.RowTemplate.Height = 24;
            this.dgvCenovnik.Size = new System.Drawing.Size(388, 115);
            this.dgvCenovnik.TabIndex = 53;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolicina.Location = new System.Drawing.Point(443, 60);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(132, 22);
            this.txtKolicina.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Količina:";
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.Location = new System.Drawing.Point(850, 139);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(177, 42);
            this.btnDodajStavku.TabIndex = 49;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // dgvStavkeA
            // 
            this.dgvStavkeA.AllowUserToAddRows = false;
            this.dgvStavkeA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeA.Location = new System.Drawing.Point(18, 93);
            this.dgvStavkeA.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStavkeA.MultiSelect = false;
            this.dgvStavkeA.Name = "dgvStavkeA";
            this.dgvStavkeA.RowHeadersWidth = 51;
            this.dgvStavkeA.Size = new System.Drawing.Size(598, 177);
            this.dgvStavkeA.TabIndex = 30;
            // 
            // txtDekoracija
            // 
            this.txtDekoracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDekoracija.Location = new System.Drawing.Point(215, 20);
            this.txtDekoracija.Margin = new System.Windows.Forms.Padding(4);
            this.txtDekoracija.Name = "txtDekoracija";
            this.txtDekoracija.Size = new System.Drawing.Size(132, 22);
            this.txtDekoracija.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Dekoracija:";
            // 
            // btnPretragaCenovnika
            // 
            this.btnPretragaCenovnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretragaCenovnika.Location = new System.Drawing.Point(381, 17);
            this.btnPretragaCenovnika.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretragaCenovnika.Name = "btnPretragaCenovnika";
            this.btnPretragaCenovnika.Size = new System.Drawing.Size(100, 28);
            this.btnPretragaCenovnika.TabIndex = 41;
            this.btnPretragaCenovnika.Text = "Pretrazi";
            this.btnPretragaCenovnika.UseVisualStyleBackColor = true;
            // 
            // txtPdv
            // 
            this.txtPdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPdv.Location = new System.Drawing.Point(215, 60);
            this.txtPdv.Margin = new System.Windows.Forms.Padding(4);
            this.txtPdv.Name = "txtPdv";
            this.txtPdv.Size = new System.Drawing.Size(132, 22);
            this.txtPdv.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cena sa PDV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 409);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Dodavanje nove stavke";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretraga.Location = new System.Drawing.Point(295, 27);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(100, 28);
            this.btnPretraga.TabIndex = 54;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // txtImeRadnika
            // 
            this.txtImeRadnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImeRadnika.Location = new System.Drawing.Point(122, 33);
            this.txtImeRadnika.Margin = new System.Windows.Forms.Padding(4);
            this.txtImeRadnika.Name = "txtImeRadnika";
            this.txtImeRadnika.Size = new System.Drawing.Size(132, 22);
            this.txtImeRadnika.TabIndex = 53;
            // 
            // lblPretraziRadnike
            // 
            this.lblPretraziRadnike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraziRadnike.AutoSize = true;
            this.lblPretraziRadnike.Location = new System.Drawing.Point(19, 39);
            this.lblPretraziRadnike.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPretraziRadnike.Name = "lblPretraziRadnike";
            this.lblPretraziRadnike.Size = new System.Drawing.Size(80, 16);
            this.lblPretraziRadnike.TabIndex = 52;
            this.lblPretraziRadnike.Text = "Ime radnika:";
            // 
            // dgvAngazovanja
            // 
            this.dgvAngazovanja.AllowUserToAddRows = false;
            this.dgvAngazovanja.AllowUserToDeleteRows = false;
            this.dgvAngazovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngazovanja.Location = new System.Drawing.Point(22, 72);
            this.dgvAngazovanja.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAngazovanja.MultiSelect = false;
            this.dgvAngazovanja.Name = "dgvAngazovanja";
            this.dgvAngazovanja.RowHeadersWidth = 51;
            this.dgvAngazovanja.Size = new System.Drawing.Size(529, 187);
            this.dgvAngazovanja.TabIndex = 3;
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatum.Location = new System.Drawing.Point(696, 72);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(132, 22);
            this.txtDatum.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Datum:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtVreme
            // 
            this.txtVreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVreme.Location = new System.Drawing.Point(696, 129);
            this.txtVreme.Margin = new System.Windows.Forms.Padding(4);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(132, 22);
            this.txtVreme.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Vreme:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tip angažovanja:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(707, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 69;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzaberi.Location = new System.Drawing.Point(223, 292);
            this.btnIzaberi.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(142, 41);
            this.btnIzaberi.TabIndex = 70;
            this.btnIzaberi.Text = "Izaberi angazovanje";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(652, 409);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 25);
            this.label10.TabIndex = 71;
            this.label10.Text = "Cenovnik";
            // 
            // FrmIzmeniAngazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 819);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVreme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzmeniAngazovanje);
            this.Controls.Add(this.dgvAngazovanja);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtImeRadnika);
            this.Controls.Add(this.lblPretraziRadnike);
            this.Name = "FrmIzmeniAngazovanje";
            this.Text = "IzmeniAngazovanje";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenovnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIzmeniAngazovanje;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.DataGridView dgvStavkeA;
        private System.Windows.Forms.TextBox txtDekoracija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPretragaCenovnika;
        private System.Windows.Forms.TextBox txtPdv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtImeRadnika;
        private System.Windows.Forms.Label lblPretraziRadnike;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCenovnik;
        private System.Windows.Forms.Label lblAngazovanja;
        private System.Windows.Forms.DataGridView dgvAngazovanja;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private Button btnIzaberi;
        private TextBox txtUkupanIznos;
        private Label label9;
        private Label label10;

        public Button BtnIzmeniAngazovanje { get => btnIzmeniAngazovanje; set => btnIzmeniAngazovanje = value; }
        public Panel Panel3 { get => panel3; set => panel3 = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public DataGridView DgvStavkeA { get => dgvStavkeA; set => dgvStavkeA = value; }
        public TextBox TxtDekoracija { get => txtDekoracija; set => txtDekoracija = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Button BtnPretragaCenovnika { get => btnPretragaCenovnika; set => btnPretragaCenovnika = value; }
        public TextBox TxtPdv { get => txtPdv; set => txtPdv = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnObrisiStavku { get => btnObrisiStavku; set => btnObrisiStavku = value; }
        public Button BtnPretraga { get => btnPretraga; set => btnPretraga = value; }
        public TextBox TxtImeRadnika { get => txtImeRadnika; set => txtImeRadnika = value; }
        public Label LblPretraziRadnike { get => lblPretraziRadnike; set => lblPretraziRadnike = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public DataGridView DgvCenovnik { get => dgvCenovnik; set => dgvCenovnik = value; }
        public Label LblAngazovanja { get => lblAngazovanja; set => lblAngazovanja = value; }
        public DataGridView DgvAngazovanja { get => dgvAngazovanja; set => dgvAngazovanja = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtVreme { get => txtVreme; set => txtVreme = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public ComboBox ComboBox1 { get => comboBox1; set => comboBox1 = value; }
        public Button BtnIzaberi { get => btnIzaberi; set => btnIzaberi = value; }
        public TextBox TxtUkupanIznos { get => txtUkupanIznos; set => txtUkupanIznos = value; }
        public Label Label9 { get => label9; set => label9 = value; }
    }
}