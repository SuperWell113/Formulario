using Formulario.Dal;
using Formulario.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Formulario.Formularios
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ModelClientes cliente = new ModelClientes();

                cliente.Cliente = textBox3.Text;
                cliente.CPF = textBox7.Text;
                cliente.Contato = textBox5.Text;
                cliente.Email = textBox8.Text;
                cliente.CEP = textBox6.Text;
                cliente.Endereco = textBox4.Text;
                cliente.Datadenascimento = DateTime.ParseExact(textBox1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                cliente.Ativo = comboBox1.Text;

                Dalservicos dal = new Dalservicos();
                dal.Adicionar(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.ShowDialog();
        }

        private void agendamentoDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento a = new Agendamento();
            a.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id;

                if (!int.TryParse(textBox2.Text, out id))
                {
                    MessageBox.Show("ID inválido!");
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "Deseja realmente excluir este cliente?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (r == DialogResult.Yes)
                {
                    Dalservicos dal = new Dalservicos();
                    dal.Deletar(id);

                    MessageBox.Show("Cliente excluído com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id;

                if (!int.TryParse(textBox2.Text, out id))
                {
                    MessageBox.Show("ID inválido!");
                    return;
                }

                DateTime data;
                if (!DateTime.TryParseExact(
                  textBox1.Text,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out data))
                {
                    MessageBox.Show("Data inválida (dd/MM/yyyy)");
                    return;
                }

                ModelClientes cliente = new ModelClientes();
                cliente.Id = id;
                cliente.Cliente = textBox3.Text;
                cliente.CPF = textBox7.Text;
                cliente.Contato = textBox5.Text;
                cliente.Email = textBox8.Text;
                cliente.CEP = textBox6.Text;
                cliente.Endereco = textBox4.Text;
                cliente.Datadenascimento = DateTime.ParseExact(textBox1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                cliente.Ativo = comboBox1.Text;

                Dalservicos dal = new Dalservicos();
                dal.Atualizar(cliente);

                MessageBox.Show("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}


