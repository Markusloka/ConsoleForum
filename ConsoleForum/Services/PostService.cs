using ConsoleForum.Entities;
using ConsoleForum.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Services
{
    internal class PostService
    {
        private readonly PostsRepository _postsRepository;

        public PostService(PostsRepository postsRepository)
        {
            _postsRepository = postsRepository;
        }


        public ForumPostEntity CreatePost( int Id, string title, string description, int categoryName )
        {
            var forumPostEntity = _postsRepository.Get(x => x.Id == Id);

            forumPostEntity ??= _postsRepository.Create(new ForumPostEntity { Title = title, Description = description});

            return forumPostEntity;
        }

        public ForumPostEntity GetPostsByCategoryName(string categoryName)
        {
            var forumPostEntity = _postsRepository.Get(x => x.CategoryName == categoryName);
            return forumPostEntity;
        }

        public ForumPostEntity GetForumPostEntityById(int id)
        {
            var forumPostEntity = _postsRepository.Get(x => x.Id == id);
            return forumPostEntity;
        }

        public IEnumerable<ForumPostEntity> GetAllPosts()
        {

            var posts = _postsRepository.GetAll();
            return posts;
        }

        public ForumPostEntity UpdatePosts(ForumPostEntity forumPostsEntity)
        {
            var updatedForumPostEntity = _postsRepository.Update(x => x.Id == forumPostsEntity.Id, forumPostsEntity);
            return updatedForumPostEntity;
        }

        public void DeleteForum(int id)
        {
            _postsRepository.Delete(x => x.Id == id);
        }
    }
}
