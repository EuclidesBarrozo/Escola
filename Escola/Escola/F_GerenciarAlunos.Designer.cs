namespace Escola
{
    partial class F_GerenciarAlunos
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
            this.dgvListaAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAlunos
            // 
            this.dgvListaAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAlunos.Location = new System.Drawing.Point(12, 65);
            this.dgvListaAlunos.Name = "dgvListaAlunos";
            this.dgvListaAlunos.ReadOnly = true;
            this.dgvListaAlunos.RowHeadersVisible = false;
            this.dgvListaAlunos.Size = new System.Drawing.Size(502, 353);
            this.dgvListaAlunos.TabIndex = 0;
            this.dgvListaAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAlunos_CellContentClick);
            // 
            // F_GerenciarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaAlunos);
            this.Name = "F_GerenciarAlunos";
            this.Text = "F_GerenciarAlunoscs";
            this.Load += new System.EventHandler(this.F_GerenciarAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAlunos;
    }
}