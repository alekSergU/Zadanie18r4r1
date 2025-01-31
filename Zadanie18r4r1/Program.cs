namespace Zadanie18r4r1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "address.com";   // Console.ReadLine();
            Vidosik vidosik = new Vidosik(path);
            Upravlyater upravlyater = new Upravlyater();
            upravlyater.KavoGryzim(vidosik);
            upravlyater.Load();
            upravlyater.GetInfo();
        }
    } 
}
