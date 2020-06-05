using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note1, note2, note3;
            note1 = new Note();
            note2 = new Note("New Text");
            note3 = new Note("Changing Importance", 2);
            Console.WriteLine(note1.getAuthor());
            Console.WriteLine(note1.getText());
            Console.WriteLine(note2.getAuthor());
            Console.WriteLine(note2.getText());
            Console.WriteLine(note3.getText());
            Console.WriteLine(note3.getAuthor());
           
        }
    }
}
