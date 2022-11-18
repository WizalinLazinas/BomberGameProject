using DataModels.Enums;
namespace DataModels.Entities.LivingEntities
{
    public class BaseLiving
    {
        public int HealthPoints { get; set; }
        public LivingEntityType Type { get; set; }
        public float Speed { get; set; } 
    }
}