using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    public class Category
    {
        private string ID;
        public string AddID
        {
            get { return ID; }
            set {ID = value; }
        }
        private string Name;
        public string AddName
        { 
            get { return Name; } 
            set {  Name = value; } 
        }
    }
}
