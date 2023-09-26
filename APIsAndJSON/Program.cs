using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            do
            {
                n -= 1;
                QuoteGenerator.KanyeQuote();
                Console.WriteLine();

                QuoteGenerator.RonQuote();
                Console.WriteLine();

            } while (n > 0);
        }
 
    }
}
