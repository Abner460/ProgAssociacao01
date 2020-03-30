using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAssociacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFunc1 = "";
            string rgFunc1 = "";

            Console.WriteLine("Digite o nome de um funcionário: ");
            nomeFunc1 = Console.ReadLine();
            Console.WriteLine("Digite o RG do funcionário: ");
            rgFunc1 = Console.ReadLine();

            Funcionario Func1 = new Funcionario();
            Func1.Nome = nomeFunc1;
            Func1.Rg = rgFunc1;

            string nomeFunc2 = "";
            string rgFunc2 = "";

            Console.WriteLine("Digite o nome de um funcionário: ");
            nomeFunc2 = Console.ReadLine();
            Console.WriteLine("Digite o RG do funcionário: ");
            rgFunc2 = Console.ReadLine();

            Funcionario Func2 = new Funcionario();
            Func2.Nome = nomeFunc2;
            Func2.Rg = rgFunc2;

            string nomeFunc3 = "";
            string rgFunc3 = "";

            Console.WriteLine("Digite o nome de um funcionário: ");
            nomeFunc3 = Console.ReadLine();
            Console.WriteLine("Digite o RG do funcionário: ");
            rgFunc3 = Console.ReadLine();

            Funcionario Func3 = new Funcionario();
            Func3.Nome = nomeFunc3;
            Func3.Rg = rgFunc3;

            Departamento dep1 = new Departamento();
            dep1.Nome = "Recursos humanos";
            dep1.Sigla = "RH";
            dep1.contratarFunc(Func1);


            Departamento dep2 = new Departamento();
            dep2.Nome = "Produção";
            dep2.Sigla = "Prod.";
            dep2.contratarFunc(Func2);
            dep2.contratarFunc(Func3);

            Console.WriteLine("O funcionário " + Func1.Nome + " está no departamento " + Func1.getDepartamento().Nome);

            Console.WriteLine("O funcionário " + Func2.Nome + " está no departamento " + Func2.getDepartamento().Nome);

            Console.WriteLine("O funcionário " + Func3.Nome + " está no departamento " + Func3.getDepartamento().Nome);

            dep2.demitirFunc(Func2);

            Console.WriteLine("O funcionário " + Func2.Nome + " foi demitido do departamento de " + Func2.getDepartamento().Nome);
            Console.WriteLine("RG do funcionário demitido: " + Func2.Rg);


            Console.ReadKey();
        }
    }
}
