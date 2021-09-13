﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListMvc.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Write a todo please.")]
        [StringLength(80, ErrorMessage = "The lenght must be between {2} and {1}", MinimumLength = 5)]
        public string Description { get; set; }
    }
}
