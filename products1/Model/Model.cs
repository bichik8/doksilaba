using System;


namespace products1.Model
{
    [Serializable]
    internal class Infodok
    {
        public override string ToString()
        {
            return $"\tНазвание документа: {Name}\n\tКоличество Страничик: {Colvo}\n\tДата выпуска: {Typi}";
        }

        public string Name { get; set; }
        public string Colvo { get; set; }
        public string Typi { get; set; }
        



        public Infodok(string name, string colvo, string typi)
        {
            Name = name;
            Colvo = colvo;
            Typi = typi;
            
        }
    }
}
