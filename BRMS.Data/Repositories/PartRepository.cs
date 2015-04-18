﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BRMS.Model.Entities;

namespace BRMS.Data.Repositories
{
    public class PartRepository : DbRepository<Part>
    {
        public PartRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}