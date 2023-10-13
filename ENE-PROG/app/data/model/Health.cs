using System;
namespace ENE_PROG.app.data.model
{
	public class Health
	{
        public string Name { get; set; }
        public float DiscountPercentage { get; set; }

        public Health(string name, float discountPercentage)
        {
            Name = name;
            DiscountPercentage = discountPercentage;
        }
    }
}

