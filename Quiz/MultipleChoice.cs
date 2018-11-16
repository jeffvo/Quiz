using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class MultipleChoice : Question
    {
        public Dictionary<String, bool> Choice = new Dictionary<string, bool>();

        public string Tekst { get; set; }
        public string Antwoord { get; set; }
        public int MoeilijkheidsGraad { get; set; }

        public void SetChoice(String key, bool value) => Choice.Add(key, value);


        public new string GetQuestion()
        {
            String Choices = null;
            foreach (String key in Choice.Keys)
            {
                Choices += key + " ";
            }
            
            return this.Tekst + "," + Choices;
            
        }
        public String CheckAnswer(String A)
        {
            String correcteAntwoord = null;
            foreach (var a in Choice)
            {
                if (a.Value.Equals(true) && A == a.Key) {
                    correcteAntwoord = a.Key;
                    return "Correct!";
                }
            }
            return "Fout het correcte antwoord is " + correcteAntwoord;
        }
    }
}
