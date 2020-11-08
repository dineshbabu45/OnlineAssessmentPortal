using System.Data.Entity;

namespace Online_Assessment_Project.DomainModel
{
    public class AssessmentDbContext :DbContext
    {
        public AssessmentDbContext() : base("OnlineAssessmentDB")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Questions> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }
    }
}
