using ConsoleForum.Entities;
using ConsoleForum.Repositories;
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
        private readonly RoleService _roleService;

        public UserService(UserRepository userRepository, RoleService roleService)
        {
            _userRepository = userRepository;
            _roleService = roleService;
        }

        public UsersEntity CreateUsers(string userName)
        {
            var UsersEntity = _userRepository.Get(x => x.UserName == userName);

            UsersEntity ??= _userRepository.Create(new UsersEntity { UserName = userName });

            return UsersEntity;
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
