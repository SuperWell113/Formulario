using static Formulario.Dal.DalClientes;
using Formulario.Dal;
using Formulario.Formularios;
using System.Data;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeClientesT(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.ShowDialog();
        }

        private void agendamentoDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento agd = new Agendamento();
            agd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void visualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
            }

            DalClientes dal = new DalClientes();
            DataTable data = dal.ListarTodos("");

            dataGridView1.DataSource = data;
        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void balançoDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DalServicos dal = new DalServicos();
            DataTable data = dal.ListarTodos();

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = data;
            dataGridView1.Visible = true;
            dataGridView1.Refresh();
        }

        private void TelaInicial_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void cadastroDeClientes_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.ShowDialog();
        }

        private void visualizarClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
            }

            DalClientes dal = new DalClientes();
            DataTable data = dal.ListarTodos("");

            dataGridView1.DataSource = data;
        }

        private void agendamentoDeServiçosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Agendamento agd = new Agendamento();
            agd.ShowDialog();
        }

        private void balançoDeServiçosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DalServicos dal = new DalServicos();
            DataTable data = dal.ListarTodos();

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = data;
            dataGridView1.Visible = true;
            dataGridView1.Refresh();
        }
    }
}
