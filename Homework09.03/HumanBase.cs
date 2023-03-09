using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Inheritance
{
    internal class HumanBase
    {
        public int a = 10;
        private int b = 20;
        internal int c = 30;
        protected int d = 40;
        private protected int e = 50;
        protected internal int f = 60;





        public HumanBase()
        {
        }
        public HumanBase(short age)
        {
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }
        public GenderEnum Gender { get; set; }
        private string Test { get; set; }
        public void publicHelloMen()
        {
        }
        internal void internalByMen()
        {
        }
        protected void protectedWhyMen()
        {
        }
        private void _privateWhyMen()
        {
        }
    }
    public enum GenderEnum
    {
        Boy,
        Girl,
        Esiminch
    }
}