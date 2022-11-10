using Models.Enums;
namespace Models.Assets
{
    public class BaseLivingEntity
    {
        public int Id { get; set; }
        public int HealthPoints { get; set; }
        public LivingEntityType Type { get; set; }
        public float Speed { get; set; } 
    }
}