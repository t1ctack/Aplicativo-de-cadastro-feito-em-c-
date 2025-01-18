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
            buttonCadastrar = new Button();
            textBoxNumeroCasa = new TextBox();
            textBoxNomeRua = new TextBox();
            textBoxDataNascimento = new TextBox();
            textBoxNumeroDoDocumento = new TextBox();
            textBoxNomeCompleto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            buttonExcluir = new Button();
            buttonBusca = new Button();
            textBoxBuscaNumeroDocumento = new TextBox();
            labelNumeroCasa = new Label();
            labelNomeRua = new Label();
            labelDataNascimento = new Label();
            labelNomeCompleto = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabPage1.Controls.Add(buttonCadastrar);
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
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(6, 183);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(79, 31);
            buttonCadastrar.TabIndex = 10;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxNumeroCasa
            // 
            textBoxNumeroCasa.Location = new Point(108, 135);
            textBoxNumeroCasa.Name = "textBoxNumeroCasa";
            textBoxNumeroCasa.Size = new Size(34, 23);
            textBoxNumeroCasa.TabIndex = 9;
            // 
            // textBoxNomeRua
            // 
            textBoxNomeRua.Location = new Point(91, 109);
            textBoxNomeRua.Name = "textBoxNomeRua";
            textBoxNomeRua.Size = new Size(265, 23);
            textBoxNomeRua.TabIndex = 8;
            // 
            // textBoxDataNascimento
            // 
            textBoxDataNascimento.Location = new Point(127, 84);
            textBoxDataNascimento.Name = "textBoxDataNascimento";
            textBoxDataNascimento.Size = new Size(229, 23);
            textBoxDataNascimento.TabIndex = 7;
            // 
            // textBoxNumeroDoDocumento
            // 
            textBoxNumeroDoDocumento.Location = new Point(148, 59);
            textBoxNumeroDoDocumento.Name = "textBoxNumeroDoDocumento";
            textBoxNumeroDoDocumento.Size = new Size(208, 23);
            textBoxNumeroDoDocumento.TabIndex = 6;
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Location = new Point(109, 33);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(247, 23);
            textBoxNomeCompleto.TabIndex = 5;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome da rua:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 1;
            label2.Text = "Número do documento:";
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
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonExcluir);
            tabPage2.Controls.Add(buttonBusca);
            tabPage2.Controls.Add(textBoxBuscaNumeroDocumento);
            tabPage2.Controls.Add(labelNumeroCasa);
            tabPage2.Controls.Add(labelNomeRua);
            tabPage2.Controls.Add(labelDataNascimento);
            tabPage2.Controls.Add(labelNomeCompleto);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(505, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(130, 186);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(97, 35);
            buttonExcluir.TabIndex = 17;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonBusca
            // 
            buttonBusca.Location = new Point(6, 186);
            buttonBusca.Name = "buttonBusca";
            buttonBusca.Size = new Size(97, 35);
            buttonBusca.TabIndex = 16;
            buttonBusca.Text = "Buscar";
            buttonBusca.UseVisualStyleBackColor = true;
            buttonBusca.Click += buttonBusca_Click;
            // 
            // textBoxBuscaNumeroDocumento
            // 
            textBoxBuscaNumeroDocumento.Location = new Point(148, 63);
            textBoxBuscaNumeroDocumento.Name = "textBoxBuscaNumeroDocumento";
            textBoxBuscaNumeroDocumento.Size = new Size(209, 23);
            textBoxBuscaNumeroDocumento.TabIndex = 15;
            // 
            // labelNumeroCasa
            // 
            labelNumeroCasa.AutoSize = true;
            labelNumeroCasa.Location = new Point(108, 147);
            labelNumeroCasa.Name = "labelNumeroCasa";
            labelNumeroCasa.Size = new Size(12, 15);
            labelNumeroCasa.TabIndex = 14;
            labelNumeroCasa.Text = "-";
            // 
            // labelNomeRua
            // 
            labelNomeRua.AutoSize = true;
            labelNomeRua.Location = new Point(91, 121);
            labelNomeRua.Name = "labelNomeRua";
            labelNomeRua.Size = new Size(12, 15);
            labelNomeRua.TabIndex = 13;
            labelNomeRua.Text = "-";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(130, 96);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(12, 15);
            labelDataNascimento.TabIndex = 12;
            labelDataNascimento.Text = "-";
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Location = new Point(108, 45);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new Size(12, 15);
            labelNomeCompleto.TabIndex = 10;
            labelNomeCompleto.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 147);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 9;
            label6.Text = "Número da casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 121);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 8;
            label7.Text = "Nome da rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 96);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 7;
            label8.Text = "Data de nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 71);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 6;
            label9.Text = "Número do documento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 45);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 5;
            label10.Text = "Nome completo:";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Button buttonCadastrar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelNomeCompleto;
        private Label labelNumeroCasa;
        private Label labelNomeRua;
        private Label labelDataNascimento;
        private TextBox textBoxBuscaNumeroDocumento;
        private Button buttonExcluir;
        private Button buttonBusca;
    }
}
