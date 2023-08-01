using System;
using static System.Console;

namespace uauLegal//recomendado usar o nome do projeto
{
    class MainClass
    {
        public static void printmenu(string[] options)
        {
            foreach (String option in options)//listando o array String[]
            {
                WriteLine(option);
            }
            WriteLine("Escolha sua opção:");
        }

        public static void Main(String[] args)
        {
            WriteLine("Cadastro de pessoas");//menu
            String[] options =
            {
                "1 - Cadastrar",
                "2 - Editar",
                "3 - Excluir",
                "4 - Listar",
                "5 - Sair"
            };
            int option = 0;
            while (true)
            {
                printmenu(options);//começo da escolha de menu
                try
                {
                    option = Convert.ToInt32(ReadLine());
                }
                catch (System.FormatException)//lidando com a teimosia do usuário
                {
                    WriteLine("Digite uma opção entre 1 e " + options.Length);
                    continue;
                }
                catch (Exception)//lidando com erros
                {
                    WriteLine("Ocorreu um erro! :(");
                    continue;
                }
                switch (option)//escolha de opções
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        Editar();
                        break;
                    case 3:
                        Excluir();
                        break;
                    case 4:
                        Listar();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Escolha uma opção entre 1 e " + options.Length);
                        break;
                }
            }
        }

        static List<string> nomes = new List<string>();
        static List<int> idades = new List<int>();

        private static void Cadastrar()
        {
            Clear();
            WriteLine("Cadastro de Pessoa\n");
            WriteLine("Digite o nome da pessoa:");
            nomes.Add(ReadLine());//adiciona nomes a uma posição da lista
            WriteLine("Digite a idade:");
            idades.Add(Convert.ToInt32(ReadLine()));//mesma coisa com números
            WriteLine();
        }

        private static void Editar()
        {
            Clear();
            WriteLine("Edite seu cadastro\n");
            string nome = "";
            WriteLine("Digite o nome do usuário");
            nome = ReadLine();
            int index = nomes.IndexOf(nome);//procura um nome pela posição
            if (index >= 0)
            {
                WriteLine("Registro");
                WriteLine($"Nome: {nomes[index]} - Idade: {idades[index]}");

                WriteLine("\nDigite um novo nome:");
                nomes[index] = ReadLine();
                WriteLine("\nDigite a npova idade:");
                idades[index] = Convert.ToInt32(ReadLine());
            }
            else
            {
                WriteLine("Registro não encontrado!!!");
            }

        }

        private static void Excluir()
        {
            Clear();
            WriteLine("Exclua seu cadastro\n");
            string nome = "";
            WriteLine("Digite o nome do usuário");
            nome = ReadLine();
            int index = nomes.IndexOf(nome);//procura um nome pela posição
            if (index >= 0)
            {
                WriteLine("Registro Removido");
                WriteLine($"Nome: {nomes[index]} - Idade: {idades[index]}");

                nomes.RemoveAt(index);
                idades.RemoveAt(index);
                WriteLine("Registro removido com sucesso!\n");
            }
            else
            {
                WriteLine("Registro não encontrado!!!");
            }
        }
        private static void Listar()
        {
            Clear();
            WriteLine("Listagem");
            int pos = 0;
            foreach (var item in nomes)
            {
                WriteLine($"Nome: {item} - Idade: {idades[pos]}");
                pos++;
            }
        }
    }
}