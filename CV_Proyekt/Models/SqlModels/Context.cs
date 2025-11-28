using Microsoft.EntityFrameworkCore;

namespace CV_Proyekt.Models.SqlModels
{
    public class Context : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data source=DESKTOP-6CBBCTI; initial catalog=CoreMvcCVDb;Integrated Security=true;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-DCL0L79\\GUVANCH; initial catalog=CoreMvcCVDb;Integrated Security=true;TrustServerCertificate=True;");

        }

        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<ClientReview> ClientReviews { get; set; }

        public DbSet<ContactData> ContactDatas { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<FeaturedPosts> FeaturedPosts { get; set; }
         
        public DbSet<Portfolio> Portfolios { get; set; }    

        public DbSet<Price> Prices { get; set; }

        public DbSet<ProfSkill> ProfSkills { get; set; }

        public DbSet<ReachMe> ReachMes { get; set; }

        public DbSet<Skill> Skill { get; set; }

        public DbSet<SosialMediaIcon> SosialMediaIcons { get; set; }
        public DbSet<WhatIdo>  WhatIdos { get; set; }
         
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<TagSkill> TagSkills { get; set; }
    
    }
}
