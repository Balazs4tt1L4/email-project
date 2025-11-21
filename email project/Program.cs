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
                    case "1":
                        Console.Clear();
                        Console.WriteLine("e-mail címet: ");
                        int sorszam = 0;
                            foreach (string e_mail in e_mailek)
                            {
                                Console.WriteLine($"{sorszam++}.{e_mail}");                                
                            }
                            break;
                    case "2": 
                        Console.WriteLine("Adja meg az új e-mail címet:"); 
                        string uj = Console.ReadLine();
                        e_mailek.Add(uj);
                        break;
                    case "3": 
                        Console.WriteLine("Adja meg a törlendő e-mail azonosítóját:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        e_mailek.RemoveAt(index);
                        break;
                        
                    case "4": 
                        Console.WriteLine("Érvényes e-mailek listája");
                        foreach (string e_mail in e_mailek)
                        {
                            if (e_mail.Contains("@") && e_mail.Contains("."))
                            {
                                Console.WriteLine(e_mail);
                            }
                        }
                        break;
                    default: Console.Clear(); Console.WriteLine("Rossz parancs"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
