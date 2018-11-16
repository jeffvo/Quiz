using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
     interface Question
    {
         String Tekst { get; set; }
         string Antwoord { get; set; }
         int MoeilijkheidsGraad { get; set; }

        String GetQuestion();
        String CheckAnswer(String A);

    }
}
