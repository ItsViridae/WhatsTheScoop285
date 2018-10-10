using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsTheScoop.Data
{
    public class DBProcessorModel : DbContext
    {
        public DBProcessorModel(DbContextOptions<DBProcessorModel> options)
            : base(options)
        { }
        //Possible add for School project    ADD S          Check Data Folder if Confused.
        public DbSet<Crisis> Crisiss { get; set; }
        public DbSet<Explanation> Explanations { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<User> Users { get; set; }
        //Project adds Finished
    }

    public class CrisisProp
    { 
        public ICollection<Crisis> Crisiss { get; set; }
    }

    public class ExplanationProp
    {
        public ICollection<Explanation> Explanations { get; set; }

        public int CrisisId { get; set; }
        public Crisis Crisis { get; set; }
        //Did not add Collection to Crisis. Do not need Everythign inside Collection?
    }

    public class OptionProp
    {
        public ICollection<Option> Options { get; set; }

        public int CrisisId { get; set; }
        public Crisis Crisis { get; set; }
    }

    public class AnswerProp
    {
        public ICollection<Answer> Answers { get; set; }

        //add optionID set to Answer
        public int OptionId { get; set; }
        public Option Option { get; set; }
        //I don't think I have to access the Collection if I call the ID itself
            //public ICollection<Option> Options { get; set; }

        //add UserID set to Answer
        public int UserId { get; set; }
        public User User { get; set; }
        //I don't think I have to access the Collection if I call the ID
            //public ICollection<User> Users { get; set; }

    }

    public class UserProp
    {
        public IList<User> Users { get; set; }
    }
}
