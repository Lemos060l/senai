using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFisica : Pessoa


    // : siginifca estar dentro de ou seja PessoaFisica dentro de Pessoa
    {
        public string CPF { get; set; }

        public DateTime dataNascimento { get; set; }

        public float salario { get; set; }

        public override float PagarImposto(float salario)
        {
            if (salario <= 1500)
            {
                return 0;
            }
            else if (salario > 1500 && salario <= 5000)
            {
                return salario * 3 / 100;
            }
            else if (salario > 5000)
            {
                return salario * 5 / 100;
            } else {
                return 0;
            }
        }

        // float , utilizado para dinheiro.
        // override sobrescreve.

        public bool ValidarDataNascimento(DateTime dataNascimenti)
        {
            DateTime dataAtual = DateTime.Today;

            // double poderia ser substituido por int , double é maior.

            double anos = (dataAtual - dataNascimento).TotalDays / 365;
            if (anos >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}


