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
using static System.Runtime.InteropServices.JavaScript.JSType;
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
                MoldelAgendamento agd = new MoldelAgendamento();
                agd.Id_cliente = int.Parse(textBox1.Text);
                agd.Dia_Horario = dateTimePicker1.Value;

                DalAgendamento dalAgd = new DalAgendamento();
                dalAgd.Adicionar(agd);

                ModelServicos servicos = new ModelServicos();
                servicos.Servico = comboBox1.Text;
                servicos.Preco = int.Parse(textBox2.Text);

                DalServicos dalServ = new DalServicos();
                dalServ.Adicionar(servicos);

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
            }

            DalAgendamento dal = new DalAgendamento();
            DataTable data = dal.ListarTodos();

            dataGridView1.DataSource = data;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.ShowUpDown = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void telaInicialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void agendamentoDeServiçosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Agendamento Agd = new Agendamento();
            Agd.ShowDialog();
        }

        private void cadastroDeClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
            }

            DalAgendamento dal = new DalAgendamento();
            DataTable data = dal.ListarTodos();

            dataGridView1.DataSource = data;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.ShowUpDown = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        
        {
            if (!int.TryParse(textBox3.Text, out int id))
            {
                MessageBox.Show("ID inválido");
                return;
            }

            MoldelAgendamento agd = new MoldelAgendamento();
            agd.Id = id;
            agd.Id_cliente = int.Parse(textBox1.Text);
            agd.Dia_Horario = dateTimePicker1.Value;

            DalAgendamento dal = new DalAgendamento();
            dal.Atualizar(agd);

            MessageBox.Show("Agendamento atualizado com sucesso!");
        }


        

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox3.Text, out int id))
            {
                MessageBox.Show("ID inválido");
                return;
            }

            DalAgendamento dal = new DalAgendamento();
            dal.Deletar(id);

            MessageBox.Show("Agendamento deletado com sucesso!");
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    if (!int.TryParse(textBox1.Text, out int idCliente))
                    {
                        MessageBox.Show("ID do cliente inválido");
                        return;
                    }

                    if (!int.TryParse(textBox2.Text, out int preco))
                    {
                        MessageBox.Show("Preço inválido");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(comboBox1.Text))
                    {
                        MessageBox.Show("Selecione um serviço");
                        return;
                    }

                    MoldelAgendamento agd = new MoldelAgendamento();
                    agd.Id_cliente = idCliente;
                    agd.Dia_Horario = dateTimePicker1.Value;

                    DalAgendamento dalAgd = new DalAgendamento();
                    dalAgd.Adicionar(agd);

                    ModelServicos servicos = new ModelServicos();
                    servicos.Servico = comboBox1.Text;
                    servicos.Preco = preco;

                    DalServicos dalServ = new DalServicos();
                    dalServ.Adicionar(servicos);

                    MessageBox.Show("Agendamento e serviço cadastrados com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
