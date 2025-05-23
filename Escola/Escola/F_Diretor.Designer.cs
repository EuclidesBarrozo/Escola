namespace Escola
{
    partial class F_Diretor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciarProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosEEstatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarProfessoresToolStripMenuItem,
            this.relatóriosEEstatísticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarProfessoresToolStripMenuItem
            // 
            this.gerenciarProfessoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.gerenciarProfessoresToolStripMenuItem.Name = "gerenciarProfessoresToolStripMenuItem";
            this.gerenciarProfessoresToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.gerenciarProfessoresToolStripMenuItem.Text = "Gerenciar Professores";
            // 
            // relatóriosEEstatísticasToolStripMenuItem
            // 
            this.relatóriosEEstatísticasToolStripMenuItem.Name = "relatóriosEEstatísticasToolStripMenuItem";
            this.relatóriosEEstatísticasToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.relatóriosEEstatísticasToolStripMenuItem.Text = "Relatórios e Estatísticas";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            // 
            // F_Diretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Diretor";
            this.Text = "F_Diretor";
            this.Load += new System.EventHandler(this.F_Diretor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosEEstatísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
    }
}