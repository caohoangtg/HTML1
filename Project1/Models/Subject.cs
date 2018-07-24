using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<User> Users { get; set; }
    }
}