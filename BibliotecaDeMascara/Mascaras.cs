using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeMascara
{
    public static class Mascaras
    {
        public static void Menu()
        {
            Console.WriteLine("\n -----------------------------------------------");
            Console.WriteLine("| -> 1 Remover máscara do número de telefone    |");
            Console.WriteLine("| -> 2 Adicionar máscara do número de telefone  |");
            Console.WriteLine("| -> 3 Remover máscara no CPF                   |");
            Console.WriteLine("| -> 4 Adicionar máscara no CPF                 |");
            Console.WriteLine("| -> 5 Remover máscara de um CEP                |");
            Console.WriteLine("| -> 6 Adicionar máscara de um CEP              |");
            Console.WriteLine("| -> 7 para sair do programa                    |");
            Console.WriteLine(" -----------------------------------------------\n");

        }
        public static string RemoverMascaraTel(string telefoneMsk)
        {
            string dddMsk = telefoneMsk.Substring(1, 2);
            string num1Msk = telefoneMsk.Substring(5, 5);
            string num2Msk = telefoneMsk.Substring(11, 4);
            string semMask = dddMsk + num1Msk + num2Msk;

            return semMask;
        }
        public static string AdicionarMascaraTel(string telefone)
        {
            //69999502431
            string ddd = telefone.Substring(0, 2);
            string num1 = telefone.Substring(2, 5);
            string num2 = telefone.Substring(7, 4);
            string msk = $"({ddd})-{num1}-{num2}";

            return msk;
        }
        public static string RemoverMascaraCPF(string CpfMsk)
        {
            //332.200.116-44
            string num1 = CpfMsk.Substring(0,3);
            string num2 = CpfMsk.Substring(4,3);
            string num3 = CpfMsk.Substring(8,3);
            string num4 = CpfMsk.Substring(12,2);

            string cpfSemMask = num1 + num2 + num3 + num4;

            return cpfSemMask;
        }
        public static string AdicionarMascaraCPF(string Cpf)
        {
            //021|118|952|96
            string num1 = Cpf.Substring(0, 3);
            string num2 = Cpf.Substring(3, 3);
            string num3 = Cpf.Substring(6, 3);
            string num4 = Cpf.Substring(9, 2);

            return $"{num1}.{num2}.{num3}-{num4}";
        }
        public static string RemoverMascaraCEP(string CepMsk)
        {
            //68902-335
            string num1 = CepMsk.Substring(0, 5);
            string num2 = CepMsk.Substring(6, 3);

            return $"{num1}{num2}";
        }  
        public static string AdicionarMascaraCEP(string Cep)
        {
            //68902335
            string num1 = Cep.Substring(0, 5);
            string num2 = Cep.Substring(5, 3);

            return $"{num1}-{num2}";
        }
    }
}
