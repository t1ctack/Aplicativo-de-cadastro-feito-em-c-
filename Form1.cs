using CadastroBiblioteca;
using System.Windows.Forms;

namespace DecimoPrimeiroProjeto
{
    public partial class Form1 : Form
    {
        BaseDeDados baseDeDados;
        public Form1()
        {
            InitializeComponent();
            baseDeDados = new BaseDeDados("BaseDeDados.xml");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa(textBoxNomeCompleto.Text, textBoxNumeroDoDocumento.Text, DateTime.Parse(textBoxDataNascimento.Text), textBoxNomeRua.Text, int.Parse(textBoxNumeroCasa.Text));
            baseDeDados.AdicionarPessoa(cadastroPessoa);
            MessageBox.Show("Usuário cadastrado com sucesso", "Cadastro concluido");
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.PesquisaPessoaPorDoc(textBoxBuscaNumeroDocumento.Text);
            if(listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNomeCompleto.Text = listaPessoas[0].Nome;
                labelDataNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelNomeRua.Text = listaPessoas[0].NomeDaRua;
                labelNumeroCasa.Text = listaPessoas[0].NumeroDaCasa.ToString();
            }
            else
            {
                MessageBox.Show("Usuário não localizado", "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.RemoverPessoaPorDoc(textBoxBuscaNumeroDocumento.Text);
            if(listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNomeCompleto.Text = listaPessoas[0].Nome;
                labelDataNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelNomeRua.Text = listaPessoas[0].NomeDaRua;
                labelNumeroCasa.Text = listaPessoas[0].NumeroDaCasa.ToString();
                MessageBox.Show("Usuário excluido com sucesso", "Exclusão concluida", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuário não localizado", "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
