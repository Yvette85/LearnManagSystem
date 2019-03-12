using LearnManagSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnManagSystem.ViewModels
{
    public class AllTeachersView
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<ApplicationUser> teachers = new List<ApplicationUser>();

    }

}