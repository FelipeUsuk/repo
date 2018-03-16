using Fiap.PlataformaNet.Avaliacao_44334.Data.Repository;
using Fiap.PlataformaNet.Avaliacao_44334.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiap.PlataformaNet.Avaliacao_44334
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluirPaciente_Click(object sender, EventArgs e)
        {
            var repositorio = new PacienteRepository();
            var paciente = new Paciente()
            {
                Nome = txtBoxNome.Text,
                Telefone = txtBoxTelefone.Text
            };
            try
            {
                repositorio.CadastrarPaciente(paciente);
                MessageBox.Show("Paciente cadastrado com sucesso !");
            }catch(Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar o paciente !" + ex.Message);
            }

        }

        private void cboBoxPaciente_Enter(object sender, EventArgs e)
        {
            var repositorio = new PacienteRepository();
            var pacientes = repositorio.ConsultarTodosPacientes();

            cboBoxPaciente.DataSource = pacientes;
            cboBoxPaciente.ValueMember = "Id";
            cboBoxPaciente.DisplayMember = "Nome";
        }

        private void btnIncluirTratamento_Click(object sender, EventArgs e)
        {

            if (!ValidaTratamento())
                return;

            var repositorio = new TratamentoRepository();

            var tratamento = new Tratamento()
            {
                IdPaciente = (int)cboBoxPaciente.SelectedValue,
                Descricao = txtBoxDescricao.Text,
                Preco = (decimal)nupdPreco.Value
            };
            try
            {
                repositorio.IncluirTratamento(tratamento);
                MessageBox.Show("Tratamento cadastrado com sucesso !");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar o tratamento !" + ex.Message);
            }

        }

        public bool ValidaTratamento()
        {
            if (cboBoxPaciente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um paciente.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxDescricao.Text))
            {
                MessageBox.Show("Favor preencher a descrição do tratamento.");
                return false;
            }

            return true;
        }

        private void btnListarTratamentoPaciente_Click(object sender, EventArgs e)
        {
            if (cboBoxPaciente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }
            var paciente = (Paciente)cboBoxPaciente.SelectedItem;

            var repositorio = new TratamentoRepository();
           var tratamentos = repositorio.ListasTratamentoPorPacientes(paciente.Id);

            listBoxRelatorios.Items.Add($"Tratamentos do cliente : {paciente.Nome} \r\n");
            
            foreach (var tratamento in tratamentos)
            {
                listBoxRelatorios.Items.Add(tratamento.Descricao);
            }
            listBoxRelatorios.Items.Add($"============");
        }

        private async void btnListarTodosTratamentos_ClickAsync(object sender, EventArgs e)
        {
            await PreencherTodosOsTratamentos();
        }

        private async Task PreencherTodosOsTratamentos()
        {
            var repositorio = new TratamentoRepository();
            var tratamentos = repositorio.ConsultarTodosTratamentos();

            listBoxRelatorios.Items.Add($"Todos os Tratamentos \r\n");
            var quantidade = tratamentos.Count();
            var contador = 1;
            foreach (var tratamento in tratamentos)
            {
                listBoxRelatorios.Items.Add(tratamento.Descricao);
                var progresso = (contador * 100) / quantidade;
                progressBar1.Value = progresso;
                contador++;
                await Task.Delay(2000);
            }
            listBoxRelatorios.Items.Add($"============");
        }
    }
}
