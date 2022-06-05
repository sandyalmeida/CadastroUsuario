using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class usuario
    {
        public string nome { get; set; }   
        public string telefone { get; set; }
        public string CPF { get; set; }
        public string login { get; set; }   
        public string senha { get; set; }
        public bool status { get; set; }
        public string tipo { get; set; }
        public usuario (string nome, string telefone, string CPF, string login, string senha, bool status, string tipo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.CPF = CPF;
            this.login = login;
            this.senha = senha;
            this.status = status;
            this.tipo = tipo;
        
        }
    }
}
