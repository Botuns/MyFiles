#nullable disable

using System;
using BotunsEntities.Contracts;
using System.Collections.Generic;
using System.Collections;
using BotunsEntities.Entities;
namespace BotunsEntities.Identity
{
    public class User : AuditableEntity
    {
        public string UserName{get; set;}
        public string Password{get; set;}
        public string Email{get; set;}
        public Admin Admin{get; set;}
        
        public ICollection<UserRole> UserRoles{get; set;} = new HashSet<UserRole>();
        
    }    
}