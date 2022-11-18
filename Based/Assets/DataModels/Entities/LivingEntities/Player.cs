using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.Enums;

namespace DataModels.Entities.LivingEntities
{
    public class Player: BaseLiving
    {
        public Player()
        {
            Type= LivingEntityType.Player;
        }
        public SpellType SpellLevel { get; set; }
        public int Score { get; set; }
    }
}
