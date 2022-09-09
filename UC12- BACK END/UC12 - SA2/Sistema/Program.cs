namespace Sistema
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<PessoaFisica> listaPF = new List<PessoaFisica>();

            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();


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
            !       Escolha uma das opção abaixo   !
            ========================================
            !             Pessoa Física            !
            !                                      !
            !      1 - Cadastrar Pessoa Física     !
            !      2 - Listar Pessoa Física        !
            !      3 - Deletar Pessoa Física       !
            !                                      !
            !            Pessoa Jurídica           !
            !                                      !
            !      4 - Cadastrar Pessoa Jurídica   !                           
            !      5 - Listar Pessoa Jurídica      !
            !      6 - Deletar Pessoa Jurídica     !
            ========================================
            !              0 - Sair                !
            ========================================
            ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Endereco endPF = new Endereco();
                        Console.WriteLine("Digite seu logradouro");
                        endPF.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite seu número");
                        endPF.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine(@$"Digite o complemento da sua residência ou 
                    Pressione ENTER para pular");
                        endPF.complemento = Console.ReadLine();

                        Console.WriteLine("Este endereço e comercial ? (S = SIM/ N = NÃO)");
                        string enderecoComercial = Console.ReadLine().ToUpper();

                        if (enderecoComercial == "S")
                        {
                            endPF.enderecoComercial = true;
                        }
                        else
                        {
                            endPF.enderecoComercial = false;
                        }

                        PessoaFisica PF = new PessoaFisica();
                        PF.endereco = endPF;

                        Console.WriteLine("Digite seu CPF ( Somente números)");
                        PF.CPF = Console.ReadLine();

                        Console.WriteLine("Digite seu nome");
                        PF.nome = Console.ReadLine();

                        Console.WriteLine("Digite o valor do seu sálario");
                        PF.salario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite sua data de aniversário [AA, MM, DD]");
                        PF.dataNascimento = DateTime.Parse(Console.ReadLine());

                        bool idadeValida = PF.ValidarDataNascimento(PF.dataNascimento);
                        if(idadeValida == true){
                            Console.WriteLine("Cadastro Aprovado");
                            listaPF.Add(PF);
                            Console.WriteLine(PF.PagarImposto(PF.salario));
                        }

                        // Console.WriteLine(endPF.logradouro);
                        // Console.WriteLine(endPF.numero);
                        // Console.WriteLine(endPF.complemento);
                        // Console.WriteLine(endPF.enderecoComercial);
                        // Console.WriteLine(endPF.logradouro);
                        // Console.WriteLine(endPF.numero);
                        // Console.WriteLine(endPF.complemento);
                        // Console.WriteLine(endPF.enderecoComercial);
                        break;
                    case "2":
                    foreach(var cadaItem in listaPF){
                        Console.WriteLine($"{cadaItem.nome}, {cadaItem.CPF}, {cadaItem.endereco} ");
                    }
                        break;
                    case "3":
                    Console.WriteLine("Digite o CPF de quem deseja remover");
                    string CPFProcurado = Console.ReadLine();
                    PessoaFisica pessoaEncontrada = listaPF.Find(cadaItem => cadaItem.CPF == CPFProcurado);

                    if(pessoaEncontrada != null){
                        listaPF.Remove(pessoaEncontrada);
                        Console.WriteLine("Pessoa removida");
                    }else{
                        Console.WriteLine("CPF não encontrado");
                    }

                        break;
                    case "4":
                        novaPj.nome = "Nome PJ";
                        novaPj.CNPJ = "00.000.000/0001-00";
                        novaPj.razaoSocial = "Razaão Social Pj";

                        novoEndPj.logradouro = "Alameda Barão de Limeira";
                        novoEndPj.numero = 539;
                        novoEndPj.complemento = "SENAI Informática";
                        novoEndPj.enderecoComercial = true;

                        novaPj.endereco = novoEndPj;

                        break;
                    case "5":
                        break;
                    case "6":
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




