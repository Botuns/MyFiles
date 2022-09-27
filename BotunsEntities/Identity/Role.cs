#nullable disable

using System;
using BotunsEntities.Contracts;
using System.Collections.Generic;
using System.Collections;
namespace BotunsEntities.Identity
{
    public class Role : AuditableEntity
    {
        public string Name{get; set;}
        public string Description{get; set;}
        public ICollection<UserRole> UserRoles{get; set;} = new HashSet<UserRole>();
    }    
}