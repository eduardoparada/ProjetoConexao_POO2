namespace Aula_1_POO_2
{
    partial class TelaPrincipal
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
            this.pl_Principal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_produto_principal = new System.Windows.Forms.Button();
            this.btn_fornecedor_principal = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_Principal
            // 
            this.pl_Principal.Location = new System.Drawing.Point(157, 12);
            this.pl_Principal.Name = "pl_Principal";
            this.pl_Principal.Size = new System.Drawing.Size(631, 374);
            this.pl_Principal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_produto_principal);
            this.panel2.Controls.Add(this.btn_fornecedor_principal);
            this.panel2.Controls.Add(this.btn_cliente);
            this.panel2.Location = new System.Drawing.Point(5, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 374);
            this.panel2.TabIndex = 1;
            // 
            // btn_produto_principal
            // 
            this.btn_produto_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto_principal.Location = new System.Drawing.Point(7, 252);
            this.btn_produto_principal.Name = "btn_produto_principal";
            this.btn_produto_principal.Size = new System.Drawing.Size(132, 90);
            this.btn_produto_principal.TabIndex = 2;
            this.btn_produto_principal.Text = "Produto";
            this.btn_produto_principal.UseVisualStyleBackColor = true;
            this.btn_produto_principal.Click += new System.EventHandler(this.btn_produto_principal_Click);
            // 
            // btn_fornecedor_principal
            // 
            this.btn_fornecedor_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fornecedor_principal.Location = new System.Drawing.Point(6, 136);
            this.btn_fornecedor_principal.Name = "btn_fornecedor_principal";
            this.btn_fornecedor_principal.Size = new System.Drawing.Size(133, 90);
            this.btn_fornecedor_principal.TabIndex = 1;
            this.btn_fornecedor_principal.Text = "Fornecedor";
            this.btn_fornecedor_principal.UseVisualStyleBackColor = true;
            this.btn_fornecedor_principal.Click += new System.EventHandler(this.btn_fornecedor_principal_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Location = new System.Drawing.Point(7, 26);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(132, 90);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pl_Principal);
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_Principal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_produto_principal;
        private System.Windows.Forms.Button btn_fornecedor_principal;
        private System.Windows.Forms.Button btn_cliente;
    }
}

