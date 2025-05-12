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
            this.ListaAlunos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroRegistos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdAluno = new System.Windows.Forms.Label();
            this.NumeroProcesso = new System.Windows.Forms.Label();
            this.NumeroAluno = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Morada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CodigoPostal = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListaAlunos
            // 
            this.ListaAlunos.HideSelection = false;
            this.ListaAlunos.Location = new System.Drawing.Point(27, 84);
            this.ListaAlunos.Name = "ListaAlunos";
            this.ListaAlunos.Size = new System.Drawing.Size(333, 312);
            this.ListaAlunos.TabIndex = 1;
            this.ListaAlunos.UseCompatibleStateImageBehavior = false;
            this.ListaAlunos.SelectedIndexChanged += new System.EventHandler(this.ListaAlunos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão da Escola";
            // 
            // NumeroRegistos
            // 
            this.NumeroRegistos.AutoSize = true;
            this.NumeroRegistos.Location = new System.Drawing.Point(24, 399);
            this.NumeroRegistos.Name = "NumeroRegistos";
            this.NumeroRegistos.Size = new System.Drawing.Size(38, 13);
            this.NumeroRegistos.TabIndex = 2;
            this.NumeroRegistos.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de Processo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de Aluno:";
            // 
            // IdAluno
            // 
            this.IdAluno.AutoSize = true;
            this.IdAluno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdAluno.Location = new System.Drawing.Point(395, 92);
            this.IdAluno.Name = "IdAluno";
            this.IdAluno.Size = new System.Drawing.Size(38, 13);
            this.IdAluno.TabIndex = 4;
            this.IdAluno.Text = "label5";
            // 
            // NumeroProcesso
            // 
            this.NumeroProcesso.AutoSize = true;
            this.NumeroProcesso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroProcesso.Location = new System.Drawing.Point(566, 92);
            this.NumeroProcesso.Name = "NumeroProcesso";
            this.NumeroProcesso.Size = new System.Drawing.Size(38, 13);
            this.NumeroProcesso.TabIndex = 6;
            this.NumeroProcesso.Text = "label6";
            // 
            // NumeroAluno
            // 
            this.NumeroAluno.AutoSize = true;
            this.NumeroAluno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroAluno.Location = new System.Drawing.Point(726, 92);
            this.NumeroAluno.Name = "NumeroAluno";
            this.NumeroAluno.Size = new System.Drawing.Size(38, 13);
            this.NumeroAluno.TabIndex = 8;
            this.NumeroAluno.Text = "label7";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(380, 143);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(395, 22);
            this.Nome.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "&Nome:";
            // 
            // Morada
            // 
            this.Morada.Location = new System.Drawing.Point(380, 206);
            this.Morada.Multiline = true;
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(242, 80);
            this.Morada.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "&Morada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "&Código Postal:";
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.Location = new System.Drawing.Point(644, 206);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(112, 22);
            this.CodigoPostal.TabIndex = 14;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(380, 317);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(391, 22);
            this.Email.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "&Email:";
            // 
            // DataNascimento
            // 
            this.DataNascimento.Location = new System.Drawing.Point(383, 374);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(200, 22);
            this.DataNascimento.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "&Data de Nascimento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CodigoPostal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.NumeroAluno);
            this.Controls.Add(this.NumeroProcesso);
            this.Controls.Add(this.IdAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroRegistos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaAlunos);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumeroRegistos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IdAluno;
        private System.Windows.Forms.Label NumeroProcesso;
        private System.Windows.Forms.Label NumeroAluno;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Morada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CodigoPostal;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DataNascimento;
        private System.Windows.Forms.Label label9;
    }
}

