﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities
{
    internal class UsersEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        
        public int RoleId { get; set; }

        public string Fullname { get; set; } = null!;
        public RoleEntity Role { get; set; } = null!;

        public UserInfoEntity UserInfo { get; set; } = null!;
    }
}
