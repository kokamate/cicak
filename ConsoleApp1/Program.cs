using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Szine { Zold, Rozsa, Fekete, Feher, Lila }
    enum Neme { Fiu, Lany}
    class cica
    {
        public int ID { get; set; }
        public string Neve { get; set; }
        public Szine Szine { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public Neme Neme { get; set; }
        public int Suly { get; set; }
        public int Kor => DateTime.Now.Year - SzuletesiDatum.Year;

        public override string ToString()
        {
            return $"{ID, - 5}{Neve,-20}{Szine,-10}{SzuletesiDatum.ToString("yyy.MM.dd"),-15}{Neme,-10}{Suly,-5}{Kor,-99}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string print = "Nagy jános utolsó szava:";
            Console.WriteLine($"{print} `nem mondom meg mit csináltam itt és hogy hol ástam el a több millió $-nyi pénzt.`");
            Console.WriteLine("");
            List<cica> cicak = new List<cica>()
            {
                new cica()
                {
                    ID=1,
                    Neme = Neme.Fiu,
                    Neve="Megatron",
                    Suly=10,
                    Szine=Szine.Feher,
                    SzuletesiDatum=new DateTime(2018,08,13),
                },
                 new cica()
                {
                    ID=2,
                    Neme = Neme.Fiu,
                    Neve="Optimus",
                    Suly=10,
                    Szine=Szine.Lila,
                    SzuletesiDatum=new DateTime(2015,01,12),
                },
                 new cica()
                {
                    ID=3,
                    Neme = Neme.Fiu,
                    Neve="Urdongo",
                    Suly=5,
                    Szine=Szine.Fekete,
                    SzuletesiDatum=new DateTime(2025,02,15),
                },
                  new cica()
                {
                    ID=4,
                    Neme = Neme.Lany,
                    Neve="Jancsi",
                    Suly=33,
                    Szine=Szine.Rozsa,
                    SzuletesiDatum=new DateTime(2005,12,12),
                },
                  new cica()
                {
                    ID=5,
                    Neme = Neme.Lany,
                    Neve="Cikcak",
                    Suly=88,
                    Szine=Szine.Zold,
                    SzuletesiDatum=new DateTime(2035,02,3),
                },
            };
            cica elsocica = cicak.First();
            Console.WriteLine(elsocica);

            cica utolsocica = cicak.Last();
            Console.WriteLine(utolsocica);
            int osszsuly = cicak.Sum(x => x.Suly);
            Console.WriteLine($"Össz súly: {osszsuly} kg");
            double atlagkor = cicak.Average(x => x.Kor);
            Console.WriteLine($"Átlag életkor: {atlagkor}");
            int lanydb = cicak.Count(x=>x.Neme==Neme.Lany);
            Console.WriteLine($"Lány macskák száma: {lanydb}");
            int legveznabbcica = cicak.Min(x => x.Suly);
            Console.WriteLine($"Legvéknyabb cica: {legveznabbcica}");
            cicak.Where(x => x.Kor > 3).ToList().ForEach(x => Console.WriteLine(x.Neve));
            cicak.Where(x => x.Szine == Szine.Fekete).ToList().ForEach(x => Console.WriteLine(x.Szine));
            Console.ReadKey();
        }
    }
}
