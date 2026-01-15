using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void visualizarInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
