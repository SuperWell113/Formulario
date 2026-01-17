using Formulario.Dal;
using Formulario.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulario.Formularios
{
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void Agendamento_Load(object sender, EventArgs e)
        {

        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void visualizarInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void agendamentoDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento Agd = new Agendamento();
            Agd.ShowDialog();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ModelServicos servicos = new ModelServicos();
                servicos.Servico = comboBox1.Text;
                servicos.Preco = int.Parse(textBox2.Text);

                MoldelAgendamento agd = new MoldelAgendamento();
                agd.Id_cliente = int.Parse(textBox1.Text);
                agd.Dia_Horario = dateTimePicker1.Value;

                DalServicos dal = new DalServicos();
                dal.Adicionar(servicos);

                DalAgendamento dalAgd = new DalAgendamento();
                dalAgd.Adicionar(agd);

                MessageBox.Show("Agendamento e serviço cadastrados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            DalServicos dal = new DalServicos();
            dal.Deletar(id);

            MessageBox.Show("Serviço deletado com sucesso!");

        }

        private void button4_Click(object sender, EventArgs e)
        {

            ModelServicos servicos = new ModelServicos();
            servicos.Id = int.Parse(textBox1.Text);
            servicos.Servico = comboBox1.Text;
            servicos.Preco = int.Parse(textBox2.Text);

            DalServicos dal = new DalServicos();
            dal.Atualizar(servicos);

            MessageBox.Show("Serviço atualizado com sucesso!");
        }
    }
}


