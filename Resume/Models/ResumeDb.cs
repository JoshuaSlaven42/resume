﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class ResumeDb : DbContext
    {
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}