using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Lab4BradyValentine.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Contact> Contacts { get; set; }
    }
}

