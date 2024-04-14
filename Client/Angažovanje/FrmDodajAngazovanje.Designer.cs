using System.Windows.Forms;

namespace Client
{
    partial class FrmDodajAngazovanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPretragaCenovnik = new System.Windows.Forms.Button();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeko = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip angažovanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lokal";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(616, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(409, 150);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radnik";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUkupanIznos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnPretragaCenovnik);
            this.groupBox1.Controls.Add(this.buttonSacuvaj);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.btnObrisiStavku);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDeko);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(53, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 374);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke angažovanja";
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Location = new System.Drawing.Point(622, 349);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.ReadOnly = true;
            this.txtUkupanIznos.Size = new System.Drawing.Size(152, 22);
            this.txtUkupanIznos.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(620, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ukupan iznos za naplatu:";
            // 
            // btnPretragaCenovnik
            // 
            this.btnPretragaCenovnik.Location = new System.Drawing.Point(295, 50);
            this.btnPretragaCenovnik.Name = "btnPretragaCenovnik";
            this.btnPretragaCenovnik.Size = new System.Drawing.Size(156, 29);
            this.btnPretragaCenovnik.TabIndex = 21;
            this.btnPretragaCenovnik.Text = "Pretraga cenovnika";
            this.btnPretragaCenovnik.UseVisualStyleBackColor = true;
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(836, 320);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(136, 52);
            this.buttonSacuvaj.TabIndex = 20;
            this.buttonSacuvaj.Text = "Sačuvaj angažovanje";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(459, 50);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(513, 118);
            this.dataGridView4.TabIndex = 19;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(622, 251);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(152, 30);
            this.btnObrisiStavku.TabIndex = 18;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 200);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(600, 172);
            this.dataGridView3.TabIndex = 12;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(622, 200);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(152, 30);
            this.btnDodajStavku.TabIndex = 17;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(117, 146);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 22);
            this.txtCena.TabIndex = 16;
            this.txtCena.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cena sa PDV";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(117, 101);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtKolicina.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Količina";
            // 
            // txtDeko
            // 
            this.txtDeko.Location = new System.Drawing.Point(117, 55);
            this.txtDeko.Name = "txtDeko";
            this.txtDeko.Size = new System.Drawing.Size(172, 22);
            this.txtDeko.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dekoracija";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(706, 263);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(110, 22);
            this.txtDatum.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(847, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vreme:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(916, 263);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(109, 22);
            this.txtVreme.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cenovnik";
            // 
            // FrmDodajAngazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 708);
            this.Controls.Add(this.txtVreme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajAngazovanje";
            this.Text = "FrmDodajAngazovanje";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;

        public Button BtnIzmeniStavku { get; private set; }
        public Button BtnPretragaCenovnik { get; private set; }

        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeko;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVreme;
        private Button btnPretragaCenovnik;
        private DataGridView dataGridView4;
        private Button buttonSacuvaj;
        private TextBox txtUkupanIznos;
        private Label label9;
        private Label label10;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public DataGridView DataGridView2 { get => dataGridView2; set => dataGridView2 = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public ComboBox ComboBox1 { get => comboBox1; set => comboBox1 = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Button BtnObrisiStavku { get => btnObrisiStavku; set => btnObrisiStavku = value; }
        public DataGridView DataGridView3 { get => dataGridView3; set => dataGridView3 = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtDeko { get => txtDeko; set => txtDeko = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public TextBox TxtVreme { get => txtVreme; set => txtVreme = value; }
        public DataGridView DataGridView4 { get => dataGridView4; set => dataGridView4 = value; }
        public Button ButtonSacuvaj { get => buttonSacuvaj; set => buttonSacuvaj = value; }

        public Button BtnPretragaCenovnik1 { get => btnPretragaCenovnik; set => btnPretragaCenovnik = value; }
        public TextBox TxtUkupanIznos { get => txtUkupanIznos; set => txtUkupanIznos = value; }
    }
}