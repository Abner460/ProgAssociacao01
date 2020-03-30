using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAssociacao01
{
    class Funcionario
    {
        private string nome;
        private string rg;
        private Departamento departamento;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public Departamento getDepartamento()
        {
            return this.departamento;
        }

        public void setDepartamento(Departamento d)
        {
            this.departamento = d;
        }
    }
}
