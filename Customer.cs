using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesEx4
{
    public class Customer
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value >= 1)
                { id = value; }
                else { id = -1; }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 6)
                { name = value; }
                else
                {
                    name = "invalid";
                }
            }
        }
    }
}