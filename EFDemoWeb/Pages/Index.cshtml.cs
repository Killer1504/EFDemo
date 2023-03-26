using EFDataAcessLibrary.DataAccess;
using EFDataAcessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace EFDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _db;

        public IndexModel(ILogger<IndexModel> logger, PeopleContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            if (_db.People.Count() == 0)
            {
                string path = "generated.json";
                if (System.IO.File.Exists(path))
                {
                    string content = System.IO.File.ReadAllText(path);
                    var people = JsonSerializer.Deserialize<List<Person>>(content);
                    if (people != null && people.Count > 0)
                    {
                        _db.People.AddRange(people);
                        _db.SaveChanges();
                    }
                }

            }
        }

    }
}