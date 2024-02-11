using ConsoleForum.Contexts;
using ConsoleForum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
