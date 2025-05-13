using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Core.Entities;
using WebApplication1.Data;
using WebApplication1.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Controllers
{
    public class SurveyController : Controller
    {
        private ApplicationDbContext _db;

        public SurveyController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            //get the user
            Guid userId = _db.Users.FirstOrDefault(u=>u.UserName=="sara.langlois2003@gmail.com").Id;
            ApplicationUser user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null) {
                return RedirectToAction("Index", "Home");
            }

            //get the assessment
            Assessment assessment = await _db.Assessments
                .Include(a=>a.Municipality)
                .Include(a=>a.Assessor)
                .Include(a=>a.Maturity)
                .FirstOrDefaultAsync(a => a.UserId == userId);
            if (assessment == null)
            {
                return RedirectToAction("GetFunctions", userId);
            }
            //create viewmodel
            SurveyIndexViewModel surveyIndexVM = new SurveyIndexViewModel();
            surveyIndexVM.AssessmentId = assessment.Id;
            surveyIndexVM.Municipality = assessment.Municipality.Name;
            surveyIndexVM.User = user.UserName;
            surveyIndexVM.Assessor = assessment.Assessor.UserName;
            surveyIndexVM.Maturity = assessment.Maturity.Name;
           
            //pass viewmodel to view

            return View(surveyIndexVM);
        }

        public async Task<IActionResult> AssessmentDetails(Guid assessmentId)
        {
            //get the user
            Guid userId = _db.Users.FirstOrDefault(u => u.UserName == "sara.langlois2003@gmail.com").Id;
            ApplicationUser user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //get the data
            Assessment assessment = await _db.Assessments
                .Include(a=>a.Municipality)
                .Include(a=>a.Maturity)
                .Include(a=>a.Assessor)
                .Where(a=>a.Id==assessmentId)
                .FirstOrDefaultAsync();
            if(assessment==null || assessment.UserId!=user.Id)
            {
                return RedirectToAction("Index", "Home");
            }

            IEnumerable<Core.Entities.Function> Functions = await _db.Functions
                .Include(f => f.Categories)
                    .ThenInclude(c => c.SubCategories)
                        .ThenInclude(s => s.Requirements)
                            .ThenInclude(r => r.Scores)
                                .ThenInclude(s => s.Assessment)
                .Include(f => f.Categories)
                    .ThenInclude(c => c.SubCategories)
                    .ThenInclude(s => s.Requirements)
                        .ThenInclude(r => r.Guidances)
                .ToListAsync();
            SurveyAssessmentDetailsViewModel surveyAssessmentDetailsVM = new SurveyAssessmentDetailsViewModel();
            surveyAssessmentDetailsVM.Municipality = assessment.Municipality.Name;
            surveyAssessmentDetailsVM.User = user.UserName;
            surveyAssessmentDetailsVM.Assessor = assessment.Assessor.UserName;
            surveyAssessmentDetailsVM.Maturity = assessment.Maturity.Name;
            surveyAssessmentDetailsVM.Functions = Functions.Select(f => new BaseDescriptionViewModel
             {
                 Id = f.Id,
                 Name = f.Name,
                 Children = f.Categories.Select(c => new BaseDescriptionViewModel
                 {
                     Id = c.Id,
                     Name = c.Name,
                     Children = c.SubCategories.Select(s => new BaseDescriptionViewModel
                     {
                         Id = s.Id,
                         Name = s.Name,
                         Children = s.Requirements.Select(r => new RequirementViewModel
                         {
                             Id = r.Id,
                             Name = r.Name,
                             Score = new ScoreViewModel
                             {
                                 DocumentationMaturityScore = r.Scores.FirstOrDefault(s => s.AssessmentId == assessmentId).DocumentationMaturityScore,
                                 ImplementationMaturityScore = r.Scores.FirstOrDefault(s => s.AssessmentId == assessmentId).ImplementationMaturityScore,
                                 AdditionalInfo = r.Scores.FirstOrDefault(s => s.AssessmentId == assessmentId).AdditionalInfo,
                                 AssessorComment = r.Scores.FirstOrDefault(s => s.AssessmentId == assessmentId).AssessorComment,
                             },
                             Guidances = r.Guidances.Select(g => new GuidanceViewModel
                             {
                                 Id = g.Id,
                                 Description = g.Description,
                                 IsTitle = g.IsTitle,
                             })
                         })
                     })
                 })
             });
            return View(surveyAssessmentDetailsVM);


        }
        public async Task<IActionResult> GetFunctions(Guid userId)
        {
            //get the data
            IEnumerable<Core.Entities.Function> functions = await _db.Functions.ToListAsync();

            //create viewmodel
            SurveyGetFunctionsViewModel surveyGetFunctionsVM = new SurveyGetFunctionsViewModel();
            surveyGetFunctionsVM.UserId = userId;
            surveyGetFunctionsVM.Functions = functions
                .Select(f => new BaseDescriptionViewModel
                {
                    Id = f.Id,
                    Name = f.Name,
                    Color = f.Color,
                    Description = f.Description,
                }).ToList();

            //pass viewmodel to view
            return View(surveyGetFunctionsVM);

        }

        public async Task<IActionResult> GetCategories(Guid userId, Guid functionId)
        {
            //get the data
            IEnumerable<Category> categories = await _db.Categories.Where(c => c.FunctionId == functionId)
                                                                    .ToListAsync();

            //create viewmodel
            SurveyGetCategoriesViewModel surveyGetCategoriesVM = new SurveyGetCategoriesViewModel();
            surveyGetCategoriesVM.UserId = userId;
            surveyGetCategoriesVM.FunctionId = functionId;
            surveyGetCategoriesVM.Categories = categories
                .Select(category => new BaseDescriptionViewModel
                {
                    Id = category.Id,
                    Description = category.Description,
                    Name = category.Name
                }).ToList();

            //pass viewmodel to view
            return View(surveyGetCategoriesVM);

        }
    }
}
