using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr16._7Ugryumova_2
{
    internal class Employees
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public int salary { get; set; }
        public override string ToString()
        {
            return string.Format($"{surname}   {name}   {patronymic}   {sex}   {age}   {salary}");
        }
    }
}
