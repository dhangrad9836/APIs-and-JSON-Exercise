namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create RonVSKanye objects
            RonVSKanyeAPI.KanyeQuotes();

            RonVSKanyeAPI.RonSwanQuotes();





            for (int i = 0; i < 5; i++)
            {
                RonVSKanyeAPI.KanyeQuotes();
                RonVSKanyeAPI.RonSwanQuotes();
                Console.WriteLine();
                Console.WriteLine();
            }


            Console.ReadLine();
        }//endmain
    }
}
