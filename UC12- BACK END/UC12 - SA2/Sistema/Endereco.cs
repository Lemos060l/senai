using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class Endereco
    {

        //prop , para repetir
        public string logradouro { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public bool enderecoComercial { get; set; }
    }
}