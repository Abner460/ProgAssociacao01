using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAssociacao01
{
    class Departamento : AcaoEmpresa
    {
        private string nome;
        private string sigla;
        private List<Funcionario> funcionario = new List<Funcionario>();

        // métodos

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        private void addFunc(Funcionario F)
        {
            F.setDepartamento(this);
            this.funcionario.Add(F);
        }

        private bool removeFunc(Funcionario F)
        {
            int buscaFunc = this.funcionario.IndexOf(F);
            if( buscaFunc >= 0 && buscaFunc != -1)
            {
                this.funcionario.RemoveAt(buscaFunc);
                return true;
            }
            return false;
        }

        public void contratarFunc(Funcionario F)
        {
            this.addFunc(F);
        }

        public void demitirFunc(Funcionario F)
        {
            if( ! this.removeFunc(F))
            {
                Console.WriteLine("Não foi possível demitir funcionário: " + F.Nome);
            }
            else
            {
                Console.WriteLine("Funcionário " + F.Nome + "demitido");
            }
        }
    }

}
