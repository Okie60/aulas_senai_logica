using static System.Console;
using System;
namespace uaulegal
{
    class MainClass
    {
        public static void printMenu(String[] options)
        {
            foreach (String option in options)
            {
                WriteLine(option);
            }
            WriteLine("Escolha a sua opção: ");
        }

        public static void Main(String[] args)
        {
            WriteLine("<<< EXEMPLO DE MENU >>>");
            String[] options = { "1  - Opção 1", "2 - Opção 2", "3 - Opção 3", "4 - Sair" };
            int option = 0;
            while (true)
            {
                printMenu(options);
                try
                {
                    option = Convert.ToInt32(ReadLine());
                }
                catch (System.FormatException)
                {
                    WriteLine("Por favor, digite uma opção entre 1 e " + options.Length);
                    continue;
                }
                catch (Exception)
                {
                    WriteLine("Ocorreu um erro.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        option1();
                        break;
                    case 2:
                        option2();
                        break;
                    case 3:
                        option3();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Por favor digite uma opção entre 1 e " + options.Length);
                        break;
                }
            }
        }

        private static void option1()
        {
            WriteLine("Opção 1");
        }
        private static void option2()
        {
            WriteLine("Opção 2");
        }
        private static void option3()
        {
            WriteLine("Opção 3");
        }
    }
}