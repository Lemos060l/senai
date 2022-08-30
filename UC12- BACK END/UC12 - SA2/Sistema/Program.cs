namespace Sistema
{
    public class Program
    {

        static void Main(string[] args)
        {

            PessoaJuridica PJ = new PessoaJuridica();

            Endereco end = new Endereco();
            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "Bairro Novo";
            end.enderecoComercial = true;

            PJ.endereco = end;
            PJ.CNPJ = "11111111110001";
            PJ.razaoSocial = "Pessoa Jurídica";
            
            if (PJ.ValidarCNPJ(PJ.CNPJ)){
                Console.WriteLine("cnpj valido");
            }else{
                Console.WriteLine("cnpj invalido");
            }
            
        
/*

            PessoaFisica PF = new PessoaFisica();

            PF.endereco = end;
            PF.nome = "Matheus";
            PF.CPF = "999.999.999-07";
            PF.dataNascimento = new DateTime(2002, 07, 08);

            //interpolação
            Console.WriteLine($"O {PF.nome} mora na {PF.endereco.logradouro} Nº {PF.endereco.numero}");

            // // concatenação
            // Console.WriteLine("O" + PF.nome + "mora na" + PF.endereco.logradouro + PF.endereco.numero);

            bool idadeValida = PF.ValidarDataNascimento(PF.dataNascimento);

            // bool ( true ou false )

            if (idadeValida == true) {

                System.Console.WriteLine("Cadastro Aprovado");
            }else{
                Console.WriteLine("Cadastro Negado");
            }
*/
        }


    }

}




