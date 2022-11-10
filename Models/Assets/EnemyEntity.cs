using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;

namespace Models.Assets
{
    public class EnemyEntity : BaseLivingEntity
    {
        public EnemyEntity()
        {
            Type = LivingEntityType.Enemy;
        }
        public bool IsHostile { get; set; }
        public bool IsRanged { get; set; }
    }
}
