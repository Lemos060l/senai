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
    }
}