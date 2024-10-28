﻿using System.ComponentModel.DataAnnotations;

namespace inputoutput.Models
{
    public class Idea
    {
        public int Id { get; set; }
        [Required]
        public string Note { get; set; }
    }
}
