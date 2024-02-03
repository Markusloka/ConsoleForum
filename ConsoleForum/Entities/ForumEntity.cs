﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities
{
    internal class ForumEntity
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}
