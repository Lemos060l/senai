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

        public override void PagarImposto (float rendimento) { }

        // float , utilizado para dinheiro.
        // override sobrescreve.

        public bool ValidarCNPJ (string cnpj){
            if(cnpj.Length >= 14 && cnpj.Substring(cnpj.Length - 4) == "0001"){
                return true;
            }else{
                return false;
            }
        }

    }
}