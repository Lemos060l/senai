using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public abstract class Pessoa
    {

        // prop pra criar já pronto e só modificar
        public string nome { get; set; }
        public string endereco { get; set; }

        public bool enderecoComercial { get; set; }


        public void PagarImposto() {}

        // () siginfica método


    }

    // get : acessar
    // O sinal de interrogação após a string significada obrigação de nome sem o código não é necessário.
}