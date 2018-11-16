using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> vragen = new List<Question>();



            MultipleChoice vraag1 = new MultipleChoice()
            {
                MoeilijkheidsGraad = 3,
                Tekst = "Waar ligt Den Haag?"
            };
            
            vraag1.SetChoice("Nederland", true);
            vraag1.SetChoice("Engeland", false);
            vraag1.SetChoice("Duitsland", false);

            Question vraag2 = new OpenQuestion()
            {
                MoeilijkheidsGraad = 2,
                Tekst = "Wie heeft het WK in Rusland gewonnen?",
                Antwoord = "Frankrijk"
            };

            Question vraag3 = new OpenQuestion()
            {
                MoeilijkheidsGraad = 1,
                Tekst = "Wanneer wint Nederland het wk?",
                Antwoord = "2022"
            };
           
            vragen.Add(vraag2);
            vragen.Add(vraag1);
            vragen.Add(vraag3);

            var gesorteerd = vragen.OrderBy(v => v.MoeilijkheidsGraad); 
            
            foreach (Question vraag in gesorteerd)
            {
                Console.WriteLine(vraag.GetQuestion());
                Console.WriteLine(vraag.CheckAnswer(Console.ReadLine()));
            }
            Console.WriteLine("U heeft de quiz gemaakt goed gedaan!");
            Console.ReadLine();
        }
    }
}
