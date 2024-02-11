using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities
{
    internal class UserInfoEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Plattforms { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public int UserNameId { get; set; }
    }
}
