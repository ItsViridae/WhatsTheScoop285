using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsTheScoop.Data
{
    public class Option
    {
        //OptionID
        public int OptionId { get; set; }

        //Relationship to Crisis
        public int CrisisId { get; set; }

        //OptionName
        public string OptionName { get; set; }
    }
}
