using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Instrastructure
{
    public abstract class Entity : Entity<long>
    {

    }

    public abstract class Entity<TKey>
    {
        /// <summary>
        /// Id
        /// </summary>
        public TKey Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
