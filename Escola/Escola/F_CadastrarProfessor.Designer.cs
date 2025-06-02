namespace Escola
{
    partial class F_CadastrarProfessor
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
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSegmento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(148, 106);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(155, 20);
            this.tbxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // tbxCPF
            // 
            this.tbxCPF.Location = new System.Drawing.Point(148, 152);
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(155, 20);
            this.tbxCPF.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário:";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(148, 200);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(155, 20);
            this.tbxUsuario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(148, 250);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(155, 20);
            this.tbxSenha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de Adminissão:";
            // 
            // dtpDataAdmissao
            // 
            this.dtpDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissao.Location = new System.Drawing.Point(148, 299);
            this.dtpDataAdmissao.Name = "dtpDataAdmissao";
            this.dtpDataAdmissao.Size = new System.Drawing.Size(155, 20);
            this.dtpDataAdmissao.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Segmento:";
            // 
            // cbxSegmento
            // 
            this.cbxSegmento.FormattingEnabled = true;
            this.cbxSegmento.Items.AddRange(new object[] {
            "Beleza",
            "Gastronomia",
            "Gestão",
            "Tecnologia da Informação"});
            this.cbxSegmento.Location = new System.Drawing.Point(148, 349);
            this.cbxSegmento.Name = "cbxSegmento";
            this.cbxSegmento.Size = new System.Drawing.Size(155, 21);
            this.cbxSegmento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cadastrar Professor";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(185, 404);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // F_CadastrarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 459);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxSegmento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataAdmissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label1);
            this.Name = "F_CadastrarProfessor";
            this.Text = "F_CadastrarProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSegmento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastrar;
    }
}