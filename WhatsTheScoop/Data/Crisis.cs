using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsTheScoop.Data
{
    public class Crisis
    {
        //Crisis Id stored in DB
        //CrisisID will have a 1 to MANY RELATIONSHIP with Explanation/Option. Keep in mind
        public int CrisisId { get; set; }

        //Crisis Name in DB
        public string CrisisName { get; set; }

        //Description/Body of Crisis in DB
        public string CrisisDescription { get; set; }

    }
}
