using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Character
    {
        public string CharacterName { get; set; }
        public string City {  get; set; }

        public char Vocation { get; set; }
        public char Sex { get; set; }
        public int Level { get; set;}
        public DateTime Created { get; set; }
    }
}
