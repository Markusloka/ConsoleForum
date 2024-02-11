using ConsoleForum.Entities;
using ConsoleForum.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Services
{
    internal class ForumService
    {
        private readonly ForumsRepository _forumRepository;

        public ForumService( ForumsRepository forumRepository)
        {
            _forumRepository = forumRepository;
        }



        public ForumEntity CreateForum(string categoryName)
        {
            var forumEntity = _forumRepository.Get(x => x.CategoryName ==  categoryName);
            
            forumEntity ??= _forumRepository.Create(new ForumEntity { CategoryName = categoryName });
            
            return forumEntity;
        }

        public ForumEntity GetForumByCategoryName(string categoryName) {
            var forumEntity = _forumRepository.Get(x => x.CategoryName == categoryName);
            return forumEntity;
        }


    }
}
