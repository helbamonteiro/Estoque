namespace Estoque
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.mtbDocuments = new System.Windows.Forms.MaskedTextBox();
            this.bsPeople = new System.Windows.Forms.BindingSource(this.components);
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtdate = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlList = new System.Windows.Forms.Panel();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeople)).BeginInit();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(524, 57);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadastro de cliente";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.mtbDocuments);
            this.pnlMain.Controls.Add(this.dtpBirthday);
            this.pnlMain.Controls.Add(this.txtdate);
            this.pnlMain.Controls.Add(this.txtTelefone);
            this.pnlMain.Controls.Add(this.textBox2);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.textBox1);
            this.pnlMain.Controls.Add(this.txtSobrenome);
            this.pnlMain.Controls.Add(this.txtNome);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.listBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(524, 285);
            this.pnlMain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtbDocuments
            // 
            this.mtbDocuments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeople, "Phone", true));
            this.mtbDocuments.Location = new System.Drawing.Point(221, 145);
            this.mtbDocuments.Mask = "(99) 00000-0000";
            this.mtbDocuments.Name = "mtbDocuments";
            this.mtbDocuments.Size = new System.Drawing.Size(200, 20);
            this.mtbDocuments.TabIndex = 3;
            // 
            // bsPeople
            // 
            this.bsPeople.DataSource = typeof(Estoque.CadastroRepository.Person);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPeople, "Birthday", true));
            this.dtpBirthday.Location = new System.Drawing.Point(221, 192);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 2;
            // 
            // txtdate
            // 
            this.txtdate.AutoSize = true;
            this.txtdate.Location = new System.Drawing.Point(218, 176);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(102, 13);
            this.txtdate.TabIndex = 1;
            this.txtdate.Text = "Data de nascimento";
            // 
            // txtTelefone
            // 
            this.txtTelefone.AutoSize = true;
            this.txtTelefone.Location = new System.Drawing.Point(218, 129);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(49, 13);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.Text = "Telefone";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeople, "Email", true));
            this.textBox2.Location = new System.Drawing.Point(219, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(216, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(35, 13);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "E-mail";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeople, "Surname", true));
            this.textBox1.Location = new System.Drawing.Point(219, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.AutoSize = true;
            this.txtSobrenome.Location = new System.Drawing.Point(216, 50);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(61, 13);
            this.txtSobrenome.TabIndex = 1;
            this.txtSobrenome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeople, "Name", true));
            this.txtNome.Location = new System.Drawing.Point(219, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.listProdutos);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlList.Location = new System.Drawing.Point(0, 57);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(200, 285);
            this.pnlList.TabIndex = 0;
            // 
            // listProdutos
            // 
            this.listProdutos.DataSource = this.bsPeople;
            this.listProdutos.DisplayMember = "Name";
            this.listProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.Location = new System.Drawing.Point(0, 0);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(200, 285);
            this.listProdutos.TabIndex = 0;
            this.listProdutos.ValueMember = "Id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 342);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeople)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Label txtTelefone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbDocuments;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}