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
            Thread.Sleep(300);

            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write("#");
                Thread.Sleep(300);
            }
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
                        Endereco endPF = new Endereco();
                        endPF.logradouro = "Rua X";
                        endPF.numero = 100;
                        endPF.complemento = "Perto daqui";
                        endPF.enderecoComercial = false;

                        PessoaFisica Matheus = new PessoaFisica();
                        Matheus.CPF = "99999999907";
                        Matheus.dataNascimento = new DateTime(2002, 07, 08);
                        Matheus.endereco = endPF;
                        Matheus.nome = "Matheus Taldo Theu";

                        Console.WriteLine(@$"Nome: {Matheus.nome}
CPF: {Matheus.CPF} 
Nascido em {Matheus.dataNascimento.ToString("dd/MM/yyyy")}
Endereço: {endPF.logradouro}, {endPF.numero}");

                        Console.WriteLine();

                        break;
                    case "2":
                        Endereco endPJ = new Endereco();

                        endPJ.logradouro = "Rua X";
                        endPJ.numero = 100;
                        endPJ.complemento = "Logo Ali";
                        endPJ.enderecoComercial = true;

                        PessoaJuridica PJ = new PessoaJuridica();
                        PJ.CNPJ = "102050001";
                        PJ.endereco = endPJ;
                        PJ.razaoSocial = "TheuTaldo";
                        PJ.nome = "Matheus Taldo Theu";

                        Console.WriteLine(@$"Nome: {PJ.nome} 
Cnpj:{PJ.CNPJ}
Razão Social: {PJ.razaoSocial}
Endereço: {endPJ.logradouro}, {endPJ.numero}");

                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar o nosso sistema");
                        Console.Write("Finalizado");
                        Thread.Sleep(300);

                        for (var contador = 0; contador < 10; contador++)
                        {
                            Console.Write("#");
                            Thread.Sleep(300);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (opcao != "0");
            Console.ResetColor();

        }


    }

}




