using System;
namespace ENE_PROG.app.data.model
{
	public class AFP
	{
        public string Name { get; set; }
        public float DiscountPercentage { get; set; }

        public AFP(string name, float discountPercentage)
        {
            Name = name;
            DiscountPercentage = discountPercentage;
        }
    }
}

