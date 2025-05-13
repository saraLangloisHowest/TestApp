using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json;
using System.Diagnostics;
using System;
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
        public static List<ApplicationUser> applicationUsers = new List<ApplicationUser>();
        public static List<Municipality> municipalities = new List<Municipality>();
        public static List<Maturity> maturities = new List<Maturity>();
        public static List<MaturityLevel> maturityLevels = new List<MaturityLevel>();
        public static List<Assessment> assessments = new List<Assessment>();
        public static List<Score> scores = new List<Score>();
        private static Random Random { get; set; } = new Random();

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
                WebApplication1.Core.Entities.Function function = new WebApplication1.Core.Entities.Function
                {
                    Id = Guid.NewGuid(),
                    Name = func["domain_name"].ToString(),
                    Color = func["domain_color"].ToString(),
                };
                GetCategories(func, function.Id);
                functions.Add(function);
            }
            GetUsers();
            GetMunicipalities();
            GetMaturities();
            GetMaturityLevels();
            GetAssessments();
            GetScores();
            builder.Entity<Guidance>().HasData(guidances);
            builder.Entity<Requirement>().HasData(requirements);
            builder.Entity<SubCategory>().HasData(subCategories);
            builder.Entity<Category>().HasData(categories);
            builder.Entity<WebApplication1.Core.Entities.Function>().HasData(functions);
            builder.Entity<ApplicationUser>().HasData(applicationUsers);
            builder.Entity<Municipality>().HasData(municipalities);
            builder.Entity<Maturity>().HasData(maturities);
            builder.Entity<MaturityLevel>().HasData(maturityLevels);
            builder.Entity<Assessment>().HasData(assessments);
            builder.Entity<Score>().HasData(scores);
        }

        private static void GetMaturities()
        {
            maturities = new List<Maturity>
            {
                new Maturity
                {
                    Id=Guid.NewGuid(),
                    Name="Important",
                    Description="",
                    Threshold=3,
                }
            };
        }

        private static void GetMaturityLevels()
        {
            maturityLevels = new List<MaturityLevel>
            {
                new MaturityLevel {
                    Id=Guid.NewGuid(),
                    MaturityId=maturities[0].Id,
                    Level="Initial",
                    Value=1,
                    Documentation="No Process documentation or not formally approved by management.\r\n",
                    Implementation="Standard process does not exist.\r\n",
                },
                new MaturityLevel
                {
                    Id=Guid.NewGuid(),
                    MaturityId=maturities[0].Id,
                    Level="Repeatable",
                    Value=2,
                    Documentation="Formally approved Process documentation exists but not reviewed in the previous 2 years.\r\n",
                    Implementation="Ad-hoc process exists and is done informally.\r\n",
                },
                new MaturityLevel
                {
                    Id=Guid.NewGuid(),
                    MaturityId=maturities[0].Id,
                    Level="Defined",
                    Value=3,
                    Documentation="Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 5% of the time.",
                    Implementation="Formal process exists and is implemented. Evidence available for most activities. Less than 10% process exceptions.\r\n"
                },
                new MaturityLevel
                {
                    Id=Guid.NewGuid(),
                    MaturityId=maturities[0].Id,
                    Level="Managed",
                    Value=4,
                    Documentation="Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 3% of the time.\r\n",
                    Implementation="Formal process exists and is implemented. Evidence available for all activities. Detailed metrics of the process are captured and reported.\r\nMinimal target for metrics has been established. Less than 5% of process exceptions.\"\r\n",
                },
                new MaturityLevel
                {
                    Id=Guid.NewGuid(),
                    MaturityId=maturities[0].Id,
                    Level="Optimizing",
                    Value=5,
                    Documentation="Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 0,5% of the time.\r\n",
                    Implementation="Formal process exists and is implemented. Evidence available for all activities. Detailed metrics of the process are captured and reported.\r\nMinimal target for metrics has been established and continually improving. Less than 1% of process exceptions.\"\r\n",
                },
            };
        }

        
        private static void GetAssessments()
        {
            assessments = new List<Assessment>
            {
                new Assessment
                {
                    Id=Guid.NewGuid(),
                    MunicipalityId = municipalities[0].Id,
                    UserId = applicationUsers[0].Id,
                    AssessorId = applicationUsers[1].Id,
                    MaturityId=maturities[0].Id,
                },
            };

        }

        private static void GetMunicipalities()
        {
            municipalities = new List<Municipality> {
                new Municipality
                {
                Id = Guid.NewGuid(),
                Name="Brugge",
                },
                new Municipality
                {
                    Id= Guid.NewGuid(),
                    Name="Gent"
                },
                };           
        }

        private static void GetScores()
        {
        //    public Assessment Assessment { get; set; }
        //public Guid AssessmentId { get; set; }

        //public Requirement Requirement { get; set; }
        //public Guid RequirementId { get; set; }

        //public int DocumentationMaturityScore { get; set; }
        //public int ImplementationMaturityScore { get; set; }

        //public string AdditionalInfo { get; set; }
        //public string AssessorComment { get; set; }
            foreach(Requirement req in requirements)
            {
                scores.Add(new Score
                {
                    AssessmentId = assessments[0].Id,
                    RequirementId = req.Id,
                    DocumentationMaturityScore = 1+ (int)Math.Floor(Random.NextDouble()*5),
                    ImplementationMaturityScore = 1+(int)Math.Floor(Random.NextDouble() * 5),
                    AdditionalInfo = "Well done",
                    AssessorComment = $"Elephants are cool {req.Id}",
                });
            }
        }

        

        private static void ClearLists()
        {
            functions.Clear();
            categories.Clear();
            subCategories.Clear();
            requirements.Clear();
            guidances.Clear();
            applicationUsers.Clear();
            municipalities.Clear();
            assessments.Clear();
            maturities.Clear();
            maturityLevels.Clear();
            scores.Clear();
        }


        public static void GetUsers()
        {
            applicationUsers = new List<ApplicationUser>
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
