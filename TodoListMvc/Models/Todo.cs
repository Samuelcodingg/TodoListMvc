using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo_List_MVC.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Write a todo please.")]
        [StringLength(20, ErrorMessage = "The lenght must be between {2} and {1}", MinimumLength = 5)]
        public string Description { get; set; }
    }
}
