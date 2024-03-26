using LoyalitySystem.Common;
using LoyalitySystem.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Xml;

namespace LoyalitySystem.Data
{
    public class ApplicationDbContext : DbContext
    {

        private readonly IConfiguration configuration;
        public ApplicationDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<LoyalityUser> LoyalityUsers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<User> users = FillData();

            foreach(var user in users)
            {
                modelBuilder.Entity<User>().Ignore(u => u.FavoriteColors);
                modelBuilder.Entity<User>().Ignore(u => u.Age);
                modelBuilder.Entity<User>()
                    .HasData(new
                    {
                        Id = user.Id,
                        Name = user.Name,
                        SSN = user.SSN,
                        DOB = user.DOB

                    });
            }

            modelBuilder.Entity<Campaign>()
                .HasData(new
                {
                    Id = 1,
                    CompanyName = "Telecomunication",
                    StartDate = DateTime.Now,
                    Duration = 30
                });

            #region LoyalityUser

            modelBuilder.Entity<LoyalityUser>()
                .HasData(new
                {
                    Id = 1,
                    CompanyId = 1,
                    UserId = 22,
                    Discount = 25
                });

            modelBuilder.Entity<LoyalityUser>()
                .HasData(new
                {
                    Id = 2,
                    CompanyId = 1,
                    UserId = 55,
                    Discount = 15
                });

            modelBuilder.Entity<LoyalityUser>()
                .HasData(new
                {
                    Id = 3,
                    CompanyId = 1,
                    UserId = 11,
                    Discount = 40
                });

            modelBuilder.Entity<LoyalityUser>()
                .HasData(new
                {
                    Id = 4,
                    CompanyId = 1,
                    UserId = 15,
                    Discount = 5
                });

            #endregion

            #region Purchases

            modelBuilder.Entity<Purchase>()
                .HasData(new
                {
                    Id = 1,
                    UserId = 22
                });

            modelBuilder.Entity<Purchase>()
                .HasData(new
                {
                    Id = 2,
                    UserId = 22
                });

            modelBuilder.Entity<Purchase>()
                .HasData(new
                {
                    Id = 3,
                    UserId = 22
                });

            modelBuilder.Entity<Purchase>()
                .HasData(new
                {
                    Id = 4,
                    UserId = 22
                });

            #endregion
        }

        private List<User> FillData()
        {
            List<User> users = new List<User>();
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                string xmlData = GetXmlFromUrl(Utils.getAllByName);

                // Now you have the XML data in the xmlData string, you can parse it or process it further.
               // Console.WriteLine(xmlData);
                xmlDoc.LoadXml(xmlData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Load the XML string into an XmlDocument

            // Select all 'SQL' nodes
            XmlNodeList sqlNodes = xmlDoc.SelectNodes("//ListByName/SQL");

            // Iterate through each 'SQL' node and extract information
            foreach (XmlNode sqlNode in sqlNodes)
            {
                int id = int.Parse(sqlNode.SelectSingleNode("ID").InnerText);
                string name = sqlNode.SelectSingleNode("Name").InnerText;
                string dob = sqlNode.SelectSingleNode("DOB").InnerText;
                DateTime myDate = DateTime.ParseExact(dob, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);

                string ssn = sqlNode.SelectSingleNode("SSN").InnerText;

                User user = new User();
                user.Id = id;
                user.Name = name;
                user.DOB = myDate;
                user.SSN = ssn;


                users.Add(user);

                //Console.WriteLine($"ID: {id}, Name: {name}, DOB: {dob}, SSN: {ssn}");
            }

            return users;
        }

        static string GetXmlFromUrl(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
    }
}
