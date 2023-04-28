namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Axrorbek Yuldashboev ");
            Console.WriteLine();
            Bankomat bankamat = new Bankomat(12, "chorsu");
            bankamat.ChooseLang();
            bankamat.pin();
            bankamat.selectOpr();
            Main(args);

        }
    }
}