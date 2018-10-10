using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsTheScoop.Data
{
    public class Explanation
    {
        //Explanation ID in DB
        public int ExplanationId { get; set; }

        //RELATION with CRISIS
        public int CrisisId { get; set; }

        //Explanation Name        
        public string ExplanationName { get; set; }

        //Explanation Description
        public string ExplanationDescription { get; set; }

    }
}
