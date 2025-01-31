using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie18r4r1
{
    public class Vidosik : ICommander
    {
        private string Address;
        public Vidosik(string address) => Address = address;

        public void Load()
        {
            Console.WriteLine($"я видосик! я гружусь!\nгружусь отсюда: {Address}\nпых пых пых...");
            Thread.Sleep(3000);
            Console.WriteLine("загрузился!");
        }

        public void GetInfo()
        {
            var path = Path.GetFullPath("\\cdev_Text.txt");
            var fille = new FileInfo(path);
            Console.WriteLine($"\nзагрузился отсюда: {Address}\nимя: {fille.Name} \nразмер: {fille.Length} байт\nрасположение: {fille.FullName}\nформат: {Path.GetExtension(path)}");
        }
    }
}
