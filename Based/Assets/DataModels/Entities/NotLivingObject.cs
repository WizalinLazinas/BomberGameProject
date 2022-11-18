using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Entities
{
    public class NotLivingObject
    {
        public int HealthPoints { get; set; }
        public int DamagePoints { get; set; }
        public bool MayBeDestroyed { get; set; }
    }
}
