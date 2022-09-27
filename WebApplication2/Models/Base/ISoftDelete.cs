using System;

namespace NETAUTH.Models.Base
{
    public interface ISoftDelete
    {
        DateTime? DeletedOn { get; set; }
        string DeletedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}