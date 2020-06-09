using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log;
            int select;
            int severity;
            string message;

            Console.WriteLine("Program za simulaciju logiranja poruka");
            Console.Write("Unesite 1-txt,  2-xml,  0-kraj: ");
            Int32.TryParse(Console.ReadLine(), out select);

            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        log = new TextLogger();
                        break;
                    case 2:
                        log = new XmlLogger();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.Write("Unesite značajnost poruke (0-7): ");
                Int32.TryParse(Console.ReadLine(), out severity);
                Console.Write("Unesite poruku: ");
                message = Console.ReadLine();
                log.LogMessage(severity, message);
                Console.WriteLine(log.ToString());

                Console.Write("Unesite 1-txt,  2-xml,  0-kraj: ");
                Int32.TryParse(Console.ReadLine(), out select);
            }
        }
    }
}
