namespace Sistema
{
    public class Program
    {

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"

            ========================================
            !            Bem Vindo!                !
            !         Sistema de Cadastro,         !
            !       Pessoa Física e Jurídica       !
            ========================================
            ");
            Console.Write("Iniciando!!");
            Thread.Sleep(800);

            for (var contador = 0; contador < 10; contador++)
                Console.Write("#");
            Console.Clear();

            string opcao;

            do
            {

                Console.WriteLine(@$"
            ========================================
            !      Escolha uma das opção abaixo    !
            ========================================
            !         1 - Pessoa Física            !
            !         2 - Pessoa Jurídica          !
            !                                      !
            !         0 - Sair                     !
            ========================================
            ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (opcao != "0");
            Console.ResetColor();


            /*
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




