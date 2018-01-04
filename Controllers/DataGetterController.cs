using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using textrackMigration.Models;
using Microsoft.AspNetCore.Html;

namespace textrackMigration.Controllers
{
    public class DataGetter:Controller
    {
        private ApplicationDbContext context;

        public DataGetter(ApplicationDbContext context)
        {
            this.context = context;
        }

        public JsonResult GetAllUsers()
        {
            var users = context.Users.ToList();
            return Json(users);       
            
        }
        
    }
}