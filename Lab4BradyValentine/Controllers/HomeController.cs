using Lab4BradyValentine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace Lab4BradyValentine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContactsContext _context;

        public HomeController(ILogger<HomeController> logger, ContactsContext context )
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //Retrieve All Contacts from Database
            var contacts = _context.Contacts.OrderBy(x => x.FirstName)
                .Select(x => new ContactModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Phone = x.PhoneNumber,
                    Email = x.Email,
                    CategoryName = x.category.Name
                }).ToList();

            //Return View with Model
            var model = new ContactsListModel
            {
                Contacts = contacts
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
