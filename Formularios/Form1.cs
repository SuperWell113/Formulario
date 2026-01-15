using Formulario.Formularios;

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



        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
