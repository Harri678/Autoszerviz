namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Szerviz szerviz = new Szerviz();

            Jarmu asd = new Jarmu("", 55, 2000000, 234);

            Console.WriteLine(asd.SzervizSzukseges);

        }
    }
}
