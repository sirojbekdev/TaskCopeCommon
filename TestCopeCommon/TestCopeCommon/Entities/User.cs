﻿using System.Text.Json.Serialization;

namespace Posgres.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //[JsonIgnore]
        //public string PasswordHash { get; set; }
        [JsonIgnore]
        public virtual ICollection<TaskItem> Creators { get; set; }
        [JsonIgnore]
        public virtual ICollection<TaskItem> Performers { get; set; }
    }
}