using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class OpenQuestion : Question
    {
        public String Tekst { get; set; }
        public string Antwoord { get; set; }
        public int MoeilijkheidsGraad { get; set; }

        public String GetQuestion()
        {
            return this.Tekst;
        }

        public String CheckAnswer(String A)
        {
            if (Antwoord.Equals(A))
            {
                return "Correct!";

            }
            else {
                return "Fout, het antwoord is " + Antwoord;
            }
            
        }

    }
}
