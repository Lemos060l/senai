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

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";

        public override float PagarImposto(float rendimento)
        {

            float imposto = 0;

            // float , utilizado para dinheiro.
            // override sobrescreve.

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

        public void Inserir(PessoaJuridica PJ)
        {
            VerificarPastaArquivo(caminho);

            string[] PJstring = { $"{PJ.nome}, {PJ.CNPJ}, {PJ.razaoSocial}" };

            File.AppendAllLines(caminho, PJstring);

        }

        public List<PessoaJuridica> Ler()
        {

            List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPJ = new PessoaJuridica();

                cadaPJ.nome = atributos[0];
                cadaPJ.CNPJ = atributos[1];
                cadaPJ.razaoSocial = atributos[2];

                listaPJ.Add(cadaPJ);
            }

            return listaPJ;
        }
    }





}

