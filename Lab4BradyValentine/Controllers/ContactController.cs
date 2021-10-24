using Lab4BradyValentine.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4BradyValentine.Controllers
{
    /// <summary>
    /// This controller will handle Adding and Editing Contacts
    /// </summary>
    public class ContactController : Controller
    {
        private readonly ContactsContext _context;

        public ContactController(ContactsContext context)
        {
            _context = context;
        }

        //Add/Edit Contact
        [HttpGet]
        public IActionResult Index(int id)
        {
            //If Id > 0,  Edit existing Contact
            var contact = _context.Contacts.Find(id);

            //TODO: Assing retrieved contact to a view model (ContactModel - add properties to this as needed)
            var model = new ContactModel();

            if(contact != null)
            {
                model.Id = contact.Id;
                model.FirstName = contact.FirstName;
                //The rest of the props
            };
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
           //Insert/Update Contact

            if(model.Id > 0)
            {
                //This is an Edit

                //Retrieve the existing contact
                var contact = _context.Contacts.Find(model.Id);

                //Map the model to the Contact entity
                contact.FirstName = model.FirstName;
                contact.LastName = model.LastName;
                //And so on ...

                //Update the contact in the database
                _context.Contacts.Update(contact);
                _context.SaveChanges();
            }
            else
            {
                //This is an insert

                //Similar to above
                //Map the model props to a NEW Contact Entity

                //_context.Contacts.Add(newContact);
                //_context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }



    }

}