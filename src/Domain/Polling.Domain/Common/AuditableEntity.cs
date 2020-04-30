using System;

namespace Polling.Domain.Common
{
    public class AuditableEntity
    {
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
