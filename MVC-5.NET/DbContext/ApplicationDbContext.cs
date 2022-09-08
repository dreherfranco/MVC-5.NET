using Microsoft.AspNet.Identity.EntityFramework;
using MVC_5.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_5.NET.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}