#nullable disable

using System;
namespace BotunsEntities.Contracts
{
    public interface ISoftDelete
    {
         DateTime? DeletedOn{get; set;}
         int? DeletedBy{get; set;}
         bool? IsDeleted{get; set;}
    }
}