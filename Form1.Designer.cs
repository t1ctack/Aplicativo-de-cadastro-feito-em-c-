namespace DecimoPrimeiroProjeto
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxNomeCompleto = new TextBox();
            textBoxNumeroDoDocumento = new TextBox();
            textBoxDataNascimento = new TextBox();
            textBoxNomeRua = new TextBox();
            textBoxNumeroCasa = new TextBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(513, 353);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBoxNumeroCasa);
            tabPage1.Controls.Add(textBoxNomeRua);
            tabPage1.Controls.Add(textBoxDataNascimento);
            tabPage1.Controls.Add(textBoxNumeroDoDocumento);
            tabPage1.Controls.Add(textBoxNomeCompleto);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(505, 325);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(505, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 1;
            label2.Text = "Número do documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome da rua:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "Número da casa:";
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Location = new Point(109, 33);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(247, 23);
            textBoxNomeCompleto.TabIndex = 5;
            // 
            // textBoxNumeroDoDocumento
            // 
            textBoxNumeroDoDocumento.Location = new Point(148, 59);
            textBoxNumeroDoDocumento.Name = "textBoxNumeroDoDocumento";
            textBoxNumeroDoDocumento.Size = new Size(208, 23);
            textBoxNumeroDoDocumento.TabIndex = 6;
            // 
            // textBoxDataNascimento
            // 
            textBoxDataNascimento.Location = new Point(127, 84);
            textBoxDataNascimento.Name = "textBoxDataNascimento";
            textBoxDataNascimento.Size = new Size(229, 23);
            textBoxDataNascimento.TabIndex = 7;
            // 
            // textBoxNomeRua
            // 
            textBoxNomeRua.Location = new Point(91, 109);
            textBoxNomeRua.Name = "textBoxNomeRua";
            textBoxNomeRua.Size = new Size(265, 23);
            textBoxNomeRua.TabIndex = 8;
            // 
            // textBoxNumeroCasa
            // 
            textBoxNumeroCasa.Location = new Point(108, 135);
            textBoxNumeroCasa.Name = "textBoxNumeroCasa";
            textBoxNumeroCasa.Size = new Size(34, 23);
            textBoxNumeroCasa.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(6, 183);
            button1.Name = "button1";
            button1.Size = new Size(79, 31);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 377);
            Controls.Add(tabControl1);
            MaximumSize = new Size(551, 416);
            MinimumSize = new Size(551, 416);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxNumeroCasa;
        private TextBox textBoxNomeRua;
        private TextBox textBoxDataNascimento;
        private TextBox textBoxNumeroDoDocumento;
        private TextBox textBoxNomeCompleto;
        private Button button1;
    }
}
