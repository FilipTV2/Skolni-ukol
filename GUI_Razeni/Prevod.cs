using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Razeni
{
    internal class Prevod
    {
        private int prevod;
        private int minOtacky;

        public int PrevodGet { get { return prevod; } }
        private int MinOtacky {  get { return minOtacky; } }

        public Prevod(int prevod, int minOtacky)
        {
            this.prevod = prevod;
            this.minOtacky = minOtacky;
        }
    }
}
