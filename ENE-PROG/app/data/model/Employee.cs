using System;
namespace ENE_PROG.app.data.model
{
	public class Employee
	{
        public string RUT { get; set; }
        public int HourValue { get; set; }
        public int ExtraValue { get; set; }
        public int GrossSalary { get; set; }
        public int NetSalary { get; set; }
        public int DiscountAFP { get; set; }
        public int DiscountHealth { get; set; }

        public string AFPName { get; set; }
        public string HealthName { get; set; }

        public virtual AFP AFP { get; set; }

        public virtual Health Health { get; set; }

        public Employee(string rut, int hourValue, int extraValue, int grossSalary, int netSalary, int discountAFP, int discountHealth, string afpName, string healthName)
        {
            RUT = rut;
            HourValue = hourValue;
            ExtraValue = extraValue;
            GrossSalary = grossSalary;
            NetSalary = netSalary;
            DiscountAFP = discountAFP;
            DiscountHealth = discountHealth;
            AFPName = afpName;
            HealthName = healthName;
        }
    }
}

