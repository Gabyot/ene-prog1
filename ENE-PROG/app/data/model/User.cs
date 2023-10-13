using System;
namespace ENE_PROG.app.data
{
	public class User
	{
		//Propiedades
		public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Permissions { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }

        public User(string name, string email, string password, string permissions, string address, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Permissions = permissions;
            Address = address;
            Phone = phone;
        }
    }
}

