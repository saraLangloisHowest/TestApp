using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApplication1.Core.Entities;

namespace WebApplication1.Data
{
    public class Seeder
    {
        private readonly ModelBuilder _builder;
        private readonly IWebHostEnvironment _env;

        public Seeder(ModelBuilder builder, IWebHostEnvironment env)
        {
            _builder = builder;
            _env = env;
            
        }
        private string GetData()
        {
            string rootPath = _env.ContentRootPath;
            string filePath = Path.GetFullPath(Path.Combine(rootPath, "Data", "users.json"));
            using (var r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }
        public void Seed()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            string data = GetData();
            var items = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(data);
            foreach (var item in items)
            {
                var user = new ApplicationUser { Id = item["id"], Firstname = item["first"], Lastname = item["last"] };
                users.Add(user);
            }
            _builder.Entity<ApplicationUser>().HasData(users);
        }
    }
}
