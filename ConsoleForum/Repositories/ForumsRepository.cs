﻿using ConsoleForum.Contexts;
using ConsoleForum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Repositories
{
    internal class ForumsRepository : Repo<ForumEntity>
    {
        public ForumsRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
