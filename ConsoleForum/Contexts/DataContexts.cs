
using ConsoleForum.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Contexts
{
    internal class DataContexts : DbContext
    {
        public DataContexts(DbContextOptions <DataContexts> options) : base(options)
        {
        }

        public DbSet<ForumEntity> Forums { get; set; }
        public DbSet<ForumPostEntity> Posts { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<UserInfoEntity> UserInfos { get; set; }
        public DbSet<UsersEntity> Users { get; set; }
    }
}
