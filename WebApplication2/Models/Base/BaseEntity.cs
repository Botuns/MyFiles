using System;

namespace NETAUTH.Models.Base
{
    public abstract class BaseEntity
    {
        public string Id { get;  set; } = Guid.NewGuid().ToString();
    }
}