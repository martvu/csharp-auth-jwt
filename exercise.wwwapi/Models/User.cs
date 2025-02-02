﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.wwwapi.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        
        [Column("username")]
        public string Username { get; set; }

        [Column("password_hash")]
        public string PasswordHash { get; set; }

        public List<BlogPost> BlogPosts { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
