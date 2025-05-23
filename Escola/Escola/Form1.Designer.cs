namespace Escola
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(198, 58);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(169, 20);
            this.tbxUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(198, 111);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(169, 20);
            this.tbxSenha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Perfil";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Diretor"});
            this.cbxPerfil.Location = new System.Drawing.Point(198, 166);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(169, 21);
            this.cbxPerfil.TabIndex = 5;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(244, 213);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.cbxPerfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(546, 300);
            this.MinimumSize = new System.Drawing.Size(546, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.Button btnEntrar;
    }
}

