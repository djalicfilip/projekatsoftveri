using System.Windows.Forms;

namespace Client.Dekoracija
{
    partial class FrmIzmenaDekoracije
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvajDekoraciju = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(166, 438);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 384);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "PDV stopa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 392);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kategorija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Naziv";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSacuvajDekoraciju
            // 
            this.btnSacuvajDekoraciju.Location = new System.Drawing.Point(203, 488);
            this.btnSacuvajDekoraciju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSacuvajDekoraciju.Name = "btnSacuvajDekoraciju";
            this.btnSacuvajDekoraciju.Size = new System.Drawing.Size(227, 30);
            this.btnSacuvajDekoraciju.TabIndex = 39;
            this.btnSacuvajDekoraciju.Text = "Sačuvaj dekoraciju";
            this.btnSacuvajDekoraciju.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(166, 295);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(264, 22);
            this.txtNaziv.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Pretraga po kategoriji:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(175, 41);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(216, 22);
            this.txtPretraga.TabIndex = 47;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(404, 41);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(136, 22);
            this.btnPretraga.TabIndex = 46;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(520, 189);
            this.dataGridView1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Šifra";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(166, 338);
            this.txtSifra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(264, 22);
            this.txtSifra.TabIndex = 49;
            // 
            // FrmIzmenaDekoracije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvajDekoraciju);
            this.Controls.Add(this.txtNaziv);
            this.Name = "FrmIzmenaDekoracije";
            this.Text = "FrmIzmenaDekoracije";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvajDekoraciju;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label3;
        private TextBox txtSifra;

        public ComboBox ComboBox2 { get => comboBox2; set => comboBox2 = value; }
        public ComboBox ComboBox1 { get => comboBox1; set => comboBox1 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnSacuvajDekoraciju { get => btnSacuvajDekoraciju; set => btnSacuvajDekoraciju = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Button BtnPretraga { get => btnPretraga; set => btnPretraga = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtSifra { get => txtSifra; set => txtSifra = value; }
    }
}