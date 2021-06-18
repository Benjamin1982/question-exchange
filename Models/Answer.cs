using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionexchange.Models
{
    // The Reference to the Question
    public class Answer
    {
        public bool wasFound { get; set; }
        public static int _index = 0;
        public static int _indexCorrect = 0; // How many correct answers?
        public string content { get; set; }
        public int index { get; set; }
        public Answer() //schema-test: Answer a = new Answer(); Answer b = new Answer(); Console.WriteLine(a._index); Console.WriteLine(b._index);
        {
            // Am Anfang gilt eine Frage als unbeantwortet
            wasFound = false;
            _index++;
        }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
