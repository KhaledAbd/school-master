﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace school.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
