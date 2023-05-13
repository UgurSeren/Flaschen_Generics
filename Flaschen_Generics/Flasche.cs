using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaschen_Generics
{
    internal class Flasche
    {
        public string name { set; get; }

        public string inhalt { set; get; }
        public List<Getraenke> getraenkes { set; get; }= new List<Getraenke>();
        bool ergebnis;

        public Flasche(bool b)
        {
            ergebnis = b;   
        }


        public bool IsLeer()
        {
            
            if (ergebnis== true)
            {
                
                Console.WriteLine("Die Flasche is voll:\n\n Möchten Sie die Flasche leeren\n1)Ja\t2)Nein");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Leeren();
                        break;
                    case 2:
                        Console.WriteLine("Ok");
                        break;
                    default:
                        break;
                }
            }
            else if(ergebnis== false)
            {
                
                Console.WriteLine("Die Flasche is leer:\n\n Möchten Sie die Flasche füllen\n1)Ja\t2)Nein");
                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Mit Welchen Getränke möchten sie füllen");
                        string t=Console.ReadLine();
                        t.ToLower();
                       
                        switch (t)
                        {
                            case "bier":
                                Bier bier = new Bier();
                                
                                bier.name = t;
                                
                                Füllen(bier);
                                AddGetraenke(bier);
                                break;
                            case "rotwein":
                                Rotwein wein = new Rotwein();
                                wein.name = t;
                                Füllen(wein);
                                AddGetraenke(wein);
                                break;
                            case "weißwein":
                                Weißwein wein1 = new Weißwein();
                                wein1.name = t;
                                Füllen(wein1);
                                AddGetraenke(wein1);
                                break;
                            default:
                                break;
                        }


                        break;
                    case 2:
                        Console.WriteLine("Ok");
                        break;
                    default:
                        break;
                }
                


            }

            return ergebnis;

        }
        public void AddGetraenke(Getraenke g)
        {
            g.dateTime= DateTime.Now;
            getraenkes.Add(g);
        }
        public void ZeigGetraenke()
        {
            foreach (var item in getraenkes)
            {
                Console.WriteLine($"Geränke:{item.name} Datum:{item.dateTime.Year}");
            }
        }
        public void Füllen(Getraenke g)
        {
            inhalt = g.name;
            
            Console.WriteLine($"Die Flasche ist mit {inhalt} gefüllt");
        }
        public void Leeren()
        {
            Console.WriteLine("ist geleert");
        }
    }
}
