namespace email_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //adatszerkezet
            List<string> e_mailek = new List<string>();
            e_mailek.Add("alma1@kört.hu");
            e_mailek.Add("alma2@kört.hu");
            e_mailek.Add("alma3@kört.hu");
            e_mailek.Add("balazsa@kkszki.hu");
            e_mailek.Add("alma.korte@alma.hu");

            //menüvezérlés
            while (true)
            {
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. e-mailek listázása");
                Console.WriteLine("2. új email");
                Console.WriteLine("3. e-mail törlés");
                Console.WriteLine("4. érvényes e-mailek listázása");

                string valsztas = Console.ReadLine();
                switch (valsztas)
                {
                    case "0": return;
                    case "1": Console.WriteLine("e-mailek listázása"); break;
                    case "2": Console.WriteLine("új e-mailek"); break;
                    case "3": Console.WriteLine("e-mail törlés"); break;
                    case "4": Console.WriteLine("érvényes e-mailek listázása"); break;
                    default: Console.Clear(); Console.WriteLine("Rossz parancs"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
