namespace Sistema
{
    public class Program
    {

        static void Main(string[] args)
        {

            Endereco end = new Endereco();
            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "Bairro Novo";
            end.enderecoComercial = false;

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

        }


    }

}




