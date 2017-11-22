﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain.Entities.Identity
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base()
        {
        }
        public AppRole(string name) : base(name)
        { }
    }
}
