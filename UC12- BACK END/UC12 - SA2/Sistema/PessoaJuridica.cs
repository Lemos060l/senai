using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaJuridica : Pessoa


    // : siginifca estar dentro de ou seja PessoaFisica dentro de Pessoa
    {
        public string CNPJ { get; set; }

        public string razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {

            float imposto = 0;

            if (rendimento <= 5000)
            {
                imposto = rendimento * 6 / 100;
            }
            else if (rendimento > 5000 && rendimento <= 10000)
            {
                imposto = rendimento * 8 / 100;
            }
            else if (rendimento > 10000)
            {
                imposto = rendimento * 10 / 100;
            }
            return imposto;
        }
        public bool ValidarCNPJ(string CNPJ)
        {
            if (CNPJ.Length >= 14 && (CNPJ.Substring(CNPJ.Length - 4)) == "0001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // float , utilizado para dinheiro.
    // override sobrescreve.




}

