﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearnManagSystem.Models
{
    public class Module
    {
        public int Id { get; set; }

        [Required]

        [StringLength(100)]

        [Display(Name = "Module Name")]

        public string Name { get; set; }

        public string Description { get; set; }

        [Required]

        [DataType(DataType.Date)]

        [Display(Name = "Start Date")]

        public DateTime StartDate { get; set; }



        [Required]

        [DataType(DataType.Date)]

        [Display(Name = "End Date")]

        public DateTime EndDate { get; set; }

        public Course Course { get; set; }

        public int CourseId { get; set; }


    }
}