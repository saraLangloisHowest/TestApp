using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json;
using WebApplication1.Core.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WepApplication1.Data
{
    public static class Seeder
    {
        public static List<WebApplication1.Core.Entities.Function> functions = new List<WebApplication1.Core.Entities.Function>();
        public static List<Category> categories = new List<Category>();
        public static List<SubCategory> subCategories = new List<SubCategory>();
        public static List<Requirement> requirements = new List<Requirement>();
        public static List<Guidance> guidances = new List<Guidance>();
        private static string GetJSONData(IWebHostEnvironment env)
        {
            string rootPath = env.ContentRootPath;
            string filePath = Path.GetFullPath(Path.Combine(rootPath, "Data", "cyfun.json"));
            using (var r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }

        public static void GetCategories(Dictionary<string, object> func, Guid funcId)
        {
            List<Dictionary<string, object>> cats =
                    JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(func["categories"].ToString());
            foreach (var cat in cats)
            {
                Category category = new Category
                {
                    Id = Guid.NewGuid(),
                    Name = cat["category_name"].ToString(),
                    Description = cat["description_nl"].ToString(),
                    FunctionId = funcId,
                };
                GetSubCategories(cat, category.Id);
                categories.Add(category);
            }
        }

        public static void GetSubCategories(Dictionary<string, object> cat, Guid catId)
        {
            List<Dictionary<string, object>> subCats =
                        JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(cat["subcategories"].ToString());
            foreach (var subCat in subCats)
            {
                SubCategory subCategory = new SubCategory
                {
                    Id = Guid.NewGuid(),
                    Name = subCat["subcategory_name"].ToString(),
                    Description = subCat["description_nl"].ToString(),
                    CategoryId = catId,
                };
                GetRequirements(subCat, subCategory.Id);
                subCategories.Add(subCategory);
            }
        }

        public static void GetRequirements(Dictionary<string, object> subCat, Guid subCatId)
        {
            List<Dictionary<string, object>> reqs =
                        JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(subCat["requirements"].ToString());
            foreach (var req in reqs)
            {
                Requirement requirement = new Requirement
                {
                    Id = Guid.NewGuid(),
                    Name = req["requirement_name"].ToString(),
                    Description = req["description_nl"].ToString(),
                    SubCategoryId = subCatId,
                };
                GetGuidances(req, requirement.Id);
                requirements.Add(requirement);
            }
        }

        public static void GetGuidances(Dictionary<string, object> req, Guid reqId)
        {
            List<Guidance> guidances = new List<Guidance>();
            List<Dictionary<string, object>> gdnces =
                       JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(req["guidances"].ToString());
            foreach (var gdnce in gdnces)
            {
                Guidance guidance = new Guidance
                {
                    Id = Guid.NewGuid(),
                    Description = gdnce["description_nl"].ToString(),
                    RequirementId = reqId,
                };
                guidances.Add(guidance);
            }
        }



        public static void Seed(ModelBuilder builder, IWebHostEnvironment env)
        {
            ClearLists();
            string data = GetJSONData(env);
            List<Dictionary<string, object>> funcs =
                JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(data);
            foreach (var func in funcs)
            {
                Core.Entities.Function function = new Core.Entities.Function
                {
                    Id = Guid.NewGuid(),
                    Name = func["domain_name"].ToString(),
                    //Color = func["domain_color"]
                };
                GetCategories(func, function.Id);
                functions.Add(function);
            }
            builder.Entity<Guidance>().HasData(guidances);
            builder.Entity<Requirement>().HasData(requirements);
            builder.Entity<SubCategory>().HasData(subCategories);
            builder.Entity<Category>().HasData(categories);
            builder.Entity<Core.Entities.Function>().HasData(functions);
            builder.Entity<ApplicationUser>().HasData(GetUsers());
        }

        public static void ClearLists()
        {
            functions.Clear();
            categories.Clear();
            subCategories.Clear();
            requirements.Clear();
            guidances.Clear();
        }


        public static List<ApplicationUser> GetUsers()
        {
            return new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Id=Guid.NewGuid(),
                    Created=new DateTime(2015,1,1),
                    UserName = "sara.langlois2003@gmail.com",
                    IsAssesor=false,
                    IsAdmin=false,
                },
                new ApplicationUser
                {
                    Id=Guid.NewGuid(),
                    Created=new DateTime(2016,6,6),
                    UserName = "mauro.bekaert@lolol.be",
                    IsAssesor=true,
                    IsAdmin=false,
                },
                new ApplicationUser
                {
                    Id=Guid.NewGuid(),
                    Created=new DateTime(2015,1,1),
                    UserName = "timo.blomme@hahaha.com",
                    IsAssesor=true,
                    IsAdmin=true,
                },
                new ApplicationUser
                {
                    Id=Guid.NewGuid(),
                    Created=new DateTime(2015,1,1),
                    UserName = "maarten.sohier@hihi.be",
                    IsAssesor=false,
                    IsAdmin=true,
                },
            };
        }
    }


}
