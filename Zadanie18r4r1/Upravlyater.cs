using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie18r4r1
{
    public class Upravlyater
    {
        ICommander iCommander;
        public void KavoGryzim(ICommander commander) => iCommander = commander;
        public void Load() => iCommander.Load();
        public void GetInfo() => iCommander.GetInfo();
    }
}
