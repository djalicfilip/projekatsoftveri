using System.Windows.Forms;

namespace Client.Radnik
{
    partial class FrmIzmenaRadnika
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImePretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Adresa ";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(173, 426);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(344, 22);
            this.txtAdresa.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Broj telefona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Datum rodjenja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 328);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ime";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIzmena
            // 
            this.btnIzmena.Location = new System.Drawing.Point(218, 535);
            this.btnIzmena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(227, 30);
            this.btnIzmena.TabIndex = 27;
            this.btnIzmena.Text = "Sačuvaj izmene";
            this.btnIzmena.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 482);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(173, 379);
            this.txtBroj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(344, 22);
            this.txtBroj.TabIndex = 25;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(173, 325);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(344, 22);
            this.txtPrezime.TabIndex = 24;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(173, 273);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(344, 22);
            this.txtIme.TabIndex = 23;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(564, 301);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(356, 147);
            this.dataGridView2.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Pretraga po imenu:";
            // 
            // txtImePretraga
            // 
            this.txtImePretraga.Location = new System.Drawing.Point(213, 20);
            this.txtImePretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImePretraga.Name = "txtImePretraga";
            this.txtImePretraga.Size = new System.Drawing.Size(216, 22);
            this.txtImePretraga.TabIndex = 38;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(442, 15);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(136, 30);
            this.btnPretraga.TabIndex = 37;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(520, 189);
            this.dataGridView1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Grad";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmIzmenaRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 582);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtImePretraga);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzmena);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "FrmIzmenaRadnika";
            this.Text = "FrmIzmenaRadnika";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImePretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label7;

        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtAdresa { get => txtAdresa; set => txtAdresa = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnIzmena { get => btnIzmena; set => btnIzmena = value; }
        public DateTimePicker DateTimePicker1 { get => dateTimePicker1; set => dateTimePicker1 = value; }
        public TextBox TxtBroj { get => txtBroj; set => txtBroj = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public DataGridView DataGridView2 { get => dataGridView2; set => dataGridView2 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtImePretraga { get => txtImePretraga; set => txtImePretraga = value; }
        public Button BtnPretraga { get => btnPretraga; set => btnPretraga = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
    }
}