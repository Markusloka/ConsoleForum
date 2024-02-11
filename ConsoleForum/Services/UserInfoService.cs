using ConsoleForum.Entities;
using ConsoleForum.Repositories;
using ConsoleUsers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUserInfo.Services
{
    internal class UserInfoService
    { 
        private readonly UserInfoRepository _userInfoRepository;

        public UserInfoService(UserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }


        public List<UserInfoEntity> GetUserInfoByName(string FirstName, string LastName, string Email, string FullName)
        {
            var fullName = $"{FirstName} {LastName}";
            List<UserInfoEntity> matchingUsers = new List<UserInfoEntity>();

            if (!string.IsNullOrEmpty(FullName))
            {
                matchingUsers = _userInfoRepository.GetAll().Where(x => x.FullName == fullName).ToList();
            }
            else if (!string.IsNullOrEmpty(FirstName))
            {
                matchingUsers = _userInfoRepository.GetAll().Where(x => x.FirstName == FirstName).ToList();
            }
            else if (!string.IsNullOrEmpty(LastName))
            {
                matchingUsers = _userInfoRepository.GetAll().Where(x => x.LastName == LastName).ToList();
            }
            // Add more conditions if needed

            return matchingUsers;
        }



        public UserInfoEntity GetUserInfoEntityById(int id)
        {
            var UserInfoEntity = _userInfoRepository.Get(x => x.Id == id);
            return UserInfoEntity;
        }

        public IEnumerable<UserInfoEntity> GetUserInfos()
        {

            var UserInfos = _userInfoRepository.GetAll();
            return UserInfos;
        }

        public UserInfoEntity UpdateUserInfo(UserInfoEntity UserInfoEntity)
        {
            var updatedUserInfoEntity = _userInfoRepository.Update(x => x.Id == UserInfoEntity.Id, UserInfoEntity);
            return updatedUserInfoEntity;
        }

        public void DeleteUserInfo(int id)
        {
            _userInfoRepository.Delete(x => x.Id == id);
        }
    }
}
