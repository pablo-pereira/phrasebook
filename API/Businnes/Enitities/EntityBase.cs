using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enitities
{
    internal interface IEntityBase
    {
        Guid CreatedBy { get; set; }
        DateTime CreationDate { get; set; }
        Guid Id { get; set; }
        bool IsDeleted { get; set; }
        Guid ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }
    }

    internal abstract class EntityBase : IEntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
