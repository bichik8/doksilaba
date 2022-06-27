using System;
using products1.Controller;

namespace products1.View
{
    internal class Console
    {

        private Controller.adddoks dokuments;

        public Console(string path)
        {
            try
            {
                dokuments = new adddoks(path);
                consolepusk();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        private void comandos()
        {
            System.Console.WriteLine("commands - список команд");
            System.Console.WriteLine("listdok - список документов");
            System.Console.WriteLine("addoks - добавить документ");
            System.Console.WriteLine("exit - завершить ");
        }

        public void consolepusk()
        {
            comandos();
            while (true)
            {
                try
                {
                    switch (Consolestart("Введите команду...").ToLower())
                    {
                        case "commands": comandos(); break;
                        case "listdok": Listdok(); break;
                        case "addoks": Addoks(); break;
                        case "exit": Environment.Exit(0); break;
                        default:
                            System.Console.WriteLine("неверная команда"); break;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }

        private void Addoks()
        {
            string name = Consolestart("Укажите название документа");
            string colvo = Consolestart("количество (например - \"2.\")");
            string typi = Consolestart(" (дата выдачи год - \" год \")");

            dokuments.Add(name, colvo, typi);
            System.Console.WriteLine("докуминт успешно добавлен");
            Listdok();
        }

        private void Listdok()
        {
            if (dokuments.Bichmoki.Count == 0)
            {
                System.Console.WriteLine("Информации о документе отсутствует");
                return;
            }

            foreach (var item in dokuments.Bichmoki)
            {
                System.Console.WriteLine(item);
            }
        }

        private string Consolestart(string v)
        {
            System.Console.WriteLine(v);
            var s = System.Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                System.Console.WriteLine("некоректный ввод");
                return Consolestart(v);
            }
            return s.TrimStart().TrimEnd();
        }
    }
}