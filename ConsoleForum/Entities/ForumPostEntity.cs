using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities
{
    internal class ForumPostEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int CategoryId { get; set; }
        public ForumEntity Category { get; set; } = null!;
    }
}
