using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;

namespace Models.Entities.LivingEntities
{
    public class Enemy : BaseLiving
    {
        public Enemy()
        {
            Type = LivingEntityType.Enemy;
        }
        public int Id { get; set; }
        public EnemyType Species { get; set; }
        public bool IsHostile { get; set; }
        public bool IsRanged { get; set; }
    }
}
