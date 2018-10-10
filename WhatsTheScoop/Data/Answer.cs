using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsTheScoop.Data
{
    public class Answer
    {
        //Answer Id in DB
        public int AnswerId { get; set; }

        //Options for user stored in DB
        //1 to 1 Relationship (May Change)
        public int OptionId { get; set; }

        //studentID / User
        //1 to 1 Relationship (May Change)
        public int UserId { get; set; }

        //what the user/student responds with
        public int AnswerInput { get; set; }

    }
}
