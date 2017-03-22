using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Honeydew.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public int ListID { get; set; }
        public string Title { get; set; }
        public int HoursNeeded { get; set; }
        public bool Completed { get; set; }
        public string DueDate { get; set; }
        public string OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual ApplicationUser Owner { get; set; }
    }
}