namespace Aula_1_POO_2
{
    partial class TelaCliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.cpf_txt = new System.Windows.Forms.MaskedTextBox();
            this.tel_txt = new System.Windows.Forms.MaskedTextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(102, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(319, 20);
            this.txt_id.TabIndex = 4;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(102, 41);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(319, 20);
            this.nome_txt.TabIndex = 5;
            // 
            // cpf_txt
            // 
            this.cpf_txt.Location = new System.Drawing.Point(102, 71);
            this.cpf_txt.Mask = "000.000.000-00";
            this.cpf_txt.Name = "cpf_txt";
            this.cpf_txt.Size = new System.Drawing.Size(319, 20);
            this.cpf_txt.TabIndex = 8;
            // 
            // tel_txt
            // 
            this.tel_txt.Location = new System.Drawing.Point(102, 101);
            this.tel_txt.Mask = "(99) 00000-0000";
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(319, 20);
            this.tel_txt.TabIndex = 9;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(15, 154);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(114, 45);
            this.btn_gravar.TabIndex = 10;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(307, 154);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(114, 45);
            this.btn_excluir.TabIndex = 11;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(159, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.tel_txt);
            this.Controls.Add(this.cpf_txt);
            this.Controls.Add(this.nome_txt);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCliente";
            this.Text = "Tela Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.MaskedTextBox cpf_txt;
        private System.Windows.Forms.MaskedTextBox tel_txt;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button button1;
    }
}