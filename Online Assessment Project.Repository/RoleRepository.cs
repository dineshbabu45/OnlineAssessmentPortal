﻿using Online_Assessment_Project.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Assessment_Project.Repository
{
    public interface IRoleRepository
    {
        List<Role> Display();
    }
        public class RoleRepository:IRoleRepository
   {
        AssessmentDbContext db;


        public RoleRepository()
        {
            db = new AssessmentDbContext();
        }
        public List<Role> Display()
        {
            
            List<Role> data = db.Roles.ToList();
            return (data);

        }
    }
}
