namespace _17_WinFormsApp_SerializadorJSON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nomePaciente = new System.Windows.Forms.TextBox();
            this.textBox_dataNascimento = new System.Windows.Forms.TextBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_serializar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_conteudoArquivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // textBox_nomePaciente
            // 
            this.textBox_nomePaciente.Location = new System.Drawing.Point(123, 6);
            this.textBox_nomePaciente.Name = "textBox_nomePaciente";
            this.textBox_nomePaciente.Size = new System.Drawing.Size(308, 23);
            this.textBox_nomePaciente.TabIndex = 3;
            // 
            // textBox_dataNascimento
            // 
            this.textBox_dataNascimento.Location = new System.Drawing.Point(123, 37);
            this.textBox_dataNascimento.Name = "textBox_dataNascimento";
            this.textBox_dataNascimento.Size = new System.Drawing.Size(308, 23);
            this.textBox_dataNascimento.TabIndex = 4;
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.Location = new System.Drawing.Point(123, 69);
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(308, 23);
            this.textBox_cpf.TabIndex = 5;
            // 
            // button_gravar
            // 
            this.button_gravar.Location = new System.Drawing.Point(123, 115);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 6;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = true;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_serializar
            // 
            this.button_serializar.Location = new System.Drawing.Point(227, 115);
            this.button_serializar.Name = "button_serializar";
            this.button_serializar.Size = new System.Drawing.Size(75, 23);
            this.button_serializar.TabIndex = 7;
            this.button_serializar.Text = "Serializar";
            this.button_serializar.UseVisualStyleBackColor = true;
            this.button_serializar.Click += new System.EventHandler(this.button_serializar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Deserializar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_conteudoArquivo
            // 
            this.textBox_conteudoArquivo.Enabled = false;
            this.textBox_conteudoArquivo.Location = new System.Drawing.Point(12, 153);
            this.textBox_conteudoArquivo.Multiline = true;
            this.textBox_conteudoArquivo.Name = "textBox_conteudoArquivo";
            this.textBox_conteudoArquivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_conteudoArquivo.Size = new System.Drawing.Size(419, 231);
            this.textBox_conteudoArquivo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 396);
            this.Controls.Add(this.textBox_conteudoArquivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_serializar);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.textBox_cpf);
            this.Controls.Add(this.textBox_dataNascimento);
            this.Controls.Add(this.textBox_nomePaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serialização JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_nomePaciente;
        private TextBox textBox_dataNascimento;
        private TextBox textBox_cpf;
        private Button button_gravar;
        private Button button_serializar;
        private Button button1;
        private TextBox textBox_conteudoArquivo;
    }
}