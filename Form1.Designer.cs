namespace FormularioComBD
{
    partial class sla
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.rua = new System.Windows.Forms.TextBox();
            this.rua2 = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.botao = new System.Windows.Forms.Button();
            this.associado = new System.Windows.Forms.TextBox();
            this.telefone2 = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDRO CYRINO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Location = new System.Drawing.Point(468, 116);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(53, 13);
            this.labell.TabIndex = 4;
            this.labell.Text = "Associate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(24, 132);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(210, 20);
            this.nome.TabIndex = 6;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(24, 176);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(210, 20);
            this.telefone.TabIndex = 7;
            // 
            // rua
            // 
            this.rua.Location = new System.Drawing.Point(24, 215);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(210, 20);
            this.rua.TabIndex = 8;
            // 
            // rua2
            // 
            this.rua2.Location = new System.Drawing.Point(24, 241);
            this.rua2.Name = "rua2";
            this.rua2.Size = new System.Drawing.Size(210, 20);
            this.rua2.TabIndex = 9;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(24, 276);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(178, 20);
            this.cidade.TabIndex = 10;
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(24, 311);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(210, 23);
            this.botao.TabIndex = 11;
            this.botao.Text = "ENVIAR FORMULÁIO";
            this.botao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // associado
            // 
            this.associado.Location = new System.Drawing.Point(471, 132);
            this.associado.Name = "associado";
            this.associado.Size = new System.Drawing.Size(210, 20);
            this.associado.TabIndex = 12;
            // 
            // telefone2
            // 
            this.telefone2.Location = new System.Drawing.Point(471, 176);
            this.telefone2.Name = "telefone2";
            this.telefone2.Size = new System.Drawing.Size(210, 20);
            this.telefone2.TabIndex = 13;
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.estado.Location = new System.Drawing.Point(208, 275);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(121, 21);
            this.estado.TabIndex = 14;
            this.estado.Text = "Escolha seu Estado";
            // 
            // sla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.telefone2);
            this.Controls.Add(this.associado);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.rua2);
            this.Controls.Add(this.rua);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "sla";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefone2;
        private System.Windows.Forms.TextBox associado;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox rua2;
        private System.Windows.Forms.TextBox rua;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox estado;
    }
}

