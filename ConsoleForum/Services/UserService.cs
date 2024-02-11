using ConsoleForum.Entities;
using ConsoleForum.Repositories;
using ConsoleForum.Services;
using ConsoleRole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUsers.Services
{
    internal class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly UserInfoService _userInfoService;

        public UserService(UserRepository userRepository, UserInfoService userInfoService)
        {
            _userRepository = userRepository;
            _userInfoService = userInfoService;
        }






        public UsersEntity CreateUser(string userName, string firstName, string lastname, string email )
        {
            var UsersEntity = _userRepository.Get(x => x.UserName == userName);

            var userEntity = new UsersEntity
            {
               UserName = userName,
               FirstName = UserInfoEntity.Firstname,
            };

            userEntity = _userRepository.Create(userEntity); return userEntity;
        }







        public UsersEntity GetUsersByCategoryName(string userName)
        {
            var UsersEntity = _userRepository.Get(x => x.UserName == userName);
            return UsersEntity;
        }

        public UsersEntity GetUsersEntityById(int id)
        {
            var UsersEntity = _userRepository.Get(x => x.Id == id);
            return UsersEntity;
        }

        public IEnumerable<UsersEntity> GetUsers()
        {

            var Users = _userRepository.GetAll();
            return Users;
        }

        public UsersEntity UpdateUsers(UsersEntity UsersEntity)
        {
            var updatedUsersEntity = _userRepository.Update(x => x.Id == UsersEntity.Id, UsersEntity);
            return updatedUsersEntity;
        }

        public void DeleteUsers(int id)
        {
            _userRepository.Delete(x => x.Id == id);
        }
    }

}
}
