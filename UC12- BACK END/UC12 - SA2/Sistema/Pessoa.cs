using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public abstract class Pessoa
    {

        // prop pra criar já pronto e só modificar
        // Atributos 
        public string nome { get; set; }
        public Endereco endereco { get; set; }

        //Método
        public abstract float PagarImposto (float rendimento);

        // nesse caso , o abtract emprega uma regra , tornando obrigação.

        // () siginfica método


    }

    // O sinal de ? após a string significada não obrigação do atributo.
}