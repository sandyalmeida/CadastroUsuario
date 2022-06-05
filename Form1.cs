using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ativo;

            if (cmbStatus.Text == "Ativo")
                ativo = true;
            else
                ativo = false;

            usuario Gente = new usuario(txtNome.Text,
                txtTelefone.Text, 
                txtCPF.Text, 
                txtLogin.Text, 
                txtSenha.Text, 
                ativo, 
                cmbTipo.Text) ;
           
            string genteStatus;
            if (Gente.status)
                genteStatus = "Ativo";
            else
                genteStatus = "Inativo";

                MessageBox.Show(Gente.nome
                    + "\n" + Gente.telefone
                    + "\n" + Gente.CPF
                    + "\n" + Gente.login
                    + "\n" + Gente.senha
                    + "\n" + genteStatus
                    + "\n" + Gente.tipo
                    );
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            //txtCPF.Mask = @"/*000\.000\.000\-00*/";
        }
    }
}
