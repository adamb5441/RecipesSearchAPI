﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Domain.SeedWork
{
    public abstract class Entity<TId>
    {
        public TId Id { get; protected set; }
    }
}
