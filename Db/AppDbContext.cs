using Microsoft.EntityFrameworkCore;

namespace NotasUnivoDev.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.FacultiesModel> Faculties { get; set; }
        public DbSet<Models.CareersModel> Careers { get; set; }
        public DbSet<Models.SubjectsModel> Subjects { get; set; }

        public DbSet<Models.CareersSubjectsModel> CareersSubjects { get; set; }
    }
}
