using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGroupProject_106
{
    public class Shushkanov
    {
        public int thing { get; set; }

        public void explode(int a,Panel p)
        {
            for (int i=0;i<a; i++)
            {
                Console.WriteLine("Bam");
            }
            
        }

        public Shushkanov() { }
        public Shushkanov(int i)
        {

        }
    }
}
