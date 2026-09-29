namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Szerviz szerviz = new Szerviz();

            ElektromosAuto asd = new ElektromosAuto("", 55, 2000000, 234);

            asd.Szervizel(150000);
            Console.WriteLine(asd.AkkumulatorSzint);

        }
    }
}
