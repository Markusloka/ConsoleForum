using ConsoleForum.Contexts;
using ConsoleForum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Repositories
{
    internal class UserRepository : Repo<UsersEntity>
    {
        public UserRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
