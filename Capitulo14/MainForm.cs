using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capitulo14.Model;

namespace Capitulo14
{
    public partial class MainForm : Form
    {
        public List<Pessoa> PessoasCadastradas;
        public List<string> ListaEstadoCivil = new List<string>() { "Casado(a)", "Solteiro(a)", "Divorciado(a)" };

        public MainForm()
        {
            InitializeComponent();
            PessoasCadastradas = new List<Pessoa>();
            foreach (var estadoCivil in ListaEstadoCivil)
                ComboBoxEstadoCivil.Items.Add(estadoCivil);
            ComboBoxEstadoCivil.SelectedIndex = 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            char sexo = ' ';
            var index = PessoasCadastradas.IndexOf(
                PessoasCadastradas.FirstOrDefault(
                    p => p.Nome.Equals(TextNome.Text)
                ));
            if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("Preencha o campo nome.");
                TextNome.Focus();
                return;
            }

            if (string.IsNullOrEmpty(MaskedTextBoxTelefone.Text) || MaskedTextBoxTelefone.Text.Equals("(  )      -"))
            {
                MessageBox.Show("Preencha o campo telefone");
                MaskedTextBoxTelefone.Focus();
                return;
            }

            if (RadioButtonMasc.Checked)
                sexo = 'M';
            if (RadioButtonFem.Checked)
                sexo = 'F';
            if (RadioButtonOutro.Checked)
                sexo = 'O';

            Pessoa novaPessoa = new Pessoa()
            {
                Nome = TextNome.Text,
                EstadoCivil = ComboBoxEstadoCivil.SelectedItem.ToString(),
                Sexo = sexo,
                DataNascimento = DateTimePickerDataNascimento.Text,
                Telefone = MaskedTextBoxTelefone.Text,
                VeiculoProprio = CheckBoxVeiculoProprio.Checked,
                CasaPropria = CheckBoxCasaPropria.Checked
            };
            if (index < 0)
                PessoasCadastradas.Add(novaPessoa);
            else
                PessoasCadastradas[index] = novaPessoa;
            BtnLimpar_Click(BtnLimpar ,EventArgs.Empty);
            Listar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            PessoasCadastradas.RemoveAt(ListBoxResult.SelectedIndex);
            Listar();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TextNome.Text = string.Empty;
            MaskedTextBoxTelefone.Text = string.Empty;
            DateTimePickerDataNascimento.Text = string.Empty;
            ComboBoxEstadoCivil.SelectedIndex = 1;
            CheckBoxCasaPropria.Checked = false;
            CheckBoxVeiculoProprio.Checked = false;
            RadioButtonFem.Checked = false;
            RadioButtonMasc.Checked = false;
            RadioButtonOutro.Checked = false;
            TextNome.Focus();
        }

        private void Listar()
        {
            ListBoxResult.Items.Clear();
            foreach (var pessoa in PessoasCadastradas)
            {
                ListBoxResult.Items.Add(pessoa.Nome);
            }
        }

        private void ListBoxResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pessoa p = PessoasCadastradas[ListBoxResult.SelectedIndex];
            TextNome.Text = p.Nome;
            DateTimePickerDataNascimento.Text = p.DataNascimento;
            ComboBoxEstadoCivil.SelectedItem = p.EstadoCivil;
            MaskedTextBoxTelefone.Text = p.Telefone;
            CheckBoxVeiculoProprio.Checked = p.VeiculoProprio;
            CheckBoxCasaPropria.Checked = p.CasaPropria;
            var defineSexo = new Dictionary<char, Action>()
            {
                { 'M', () => RadioButtonMasc.Checked = true },
                { 'F', () => RadioButtonFem.Checked = true },
                { 'O', () => RadioButtonOutro.Checked = true },
            };
            defineSexo[p.Sexo].Invoke();
        }
    }
}