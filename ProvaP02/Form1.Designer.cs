namespace ProvaP02
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
            this.label2 = new System.Windows.Forms.Label();
            this.tx_matricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_cadastro = new System.Windows.Forms.Button();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_cancelar = new System.Windows.Forms.Button();
            this.lb_confirm = new System.Windows.Forms.Label();
            this.lb_confirm2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Mono CLM", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(128, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FUNCIONARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(114, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tx_matricula
            // 
            this.tx_matricula.Location = new System.Drawing.Point(202, 136);
            this.tx_matricula.Name = "tx_matricula";
            this.tx_matricula.Size = new System.Drawing.Size(100, 20);
            this.tx_matricula.TabIndex = 2;
            this.tx_matricula.TextChanged += new System.EventHandler(this.tx_matricula_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(381, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cpf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(114, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(202, 195);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(219, 20);
            this.tx_nome.TabIndex = 5;
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(433, 136);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(100, 20);
            this.tx_cpf.TabIndex = 6;
            this.tx_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_cpf_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(114, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Função";
            // 
            // tx_cadastro
            // 
            this.tx_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cadastro.ForeColor = System.Drawing.Color.Black;
            this.tx_cadastro.Location = new System.Drawing.Point(52, 397);
            this.tx_cadastro.Name = "tx_cadastro";
            this.tx_cadastro.Size = new System.Drawing.Size(90, 29);
            this.tx_cadastro.TabIndex = 8;
            this.tx_cadastro.Text = "Cadastrar";
            this.tx_cadastro.UseVisualStyleBackColor = true;
            this.tx_cadastro.Click += new System.EventHandler(this.tx_cadastro_Click);
            // 
            // tx_funcao
            // 
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Médico ",
            "Técnico em informatica",
            "Administrativo"});
            this.tx_funcao.Location = new System.Drawing.Point(202, 255);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(121, 21);
            this.tx_funcao.TabIndex = 9;
            this.tx_funcao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(114, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sálario";
            // 
            // tx_salario
            // 
            this.tx_salario.Location = new System.Drawing.Point(202, 309);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(100, 20);
            this.tx_salario.TabIndex = 11;
            this.tx_salario.TextChanged += new System.EventHandler(this.tx_salario_TextChanged);
            // 
            // tx_cancelar
            // 
            this.tx_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cancelar.ForeColor = System.Drawing.Color.Black;
            this.tx_cancelar.Location = new System.Drawing.Point(674, 397);
            this.tx_cancelar.Name = "tx_cancelar";
            this.tx_cancelar.Size = new System.Drawing.Size(91, 29);
            this.tx_cancelar.TabIndex = 12;
            this.tx_cancelar.Text = "Cancelar";
            this.tx_cancelar.UseVisualStyleBackColor = true;
            this.tx_cancelar.Click += new System.EventHandler(this.tx_cancelar_Click);
            // 
            // lb_confirm
            // 
            this.lb_confirm.AutoSize = true;
            this.lb_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirm.ForeColor = System.Drawing.Color.Black;
            this.lb_confirm.Location = new System.Drawing.Point(199, 359);
            this.lb_confirm.Name = "lb_confirm";
            this.lb_confirm.Size = new System.Drawing.Size(53, 16);
            this.lb_confirm.TabIndex = 13;
            this.lb_confirm.Text = "Salário:";
            // 
            // lb_confirm2
            // 
            this.lb_confirm2.AutoSize = true;
            this.lb_confirm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirm2.ForeColor = System.Drawing.Color.Black;
            this.lb_confirm2.Location = new System.Drawing.Point(552, 359);
            this.lb_confirm2.Name = "lb_confirm2";
            this.lb_confirm2.Size = new System.Drawing.Size(44, 16);
            this.lb_confirm2.TabIndex = 14;
            this.lb_confirm2.Text = "JRPF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_confirm2);
            this.Controls.Add(this.lb_confirm);
            this.Controls.Add(this.tx_cancelar);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.tx_cadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_matricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tx_cadastro;
        private System.Windows.Forms.ComboBox tx_funcao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.Button tx_cancelar;
        private System.Windows.Forms.Label lb_confirm;
        private System.Windows.Forms.Label lb_confirm2;
    }
}

