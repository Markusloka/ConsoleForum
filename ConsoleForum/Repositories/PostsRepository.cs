using ConsoleForum.Contexts;
using ConsoleForum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Repositories
{
    internal class PostsRepository : Repo<ForumPostEntity>
    {
        public PostsRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
