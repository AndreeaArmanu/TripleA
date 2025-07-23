using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registerApp
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{ID},{Username},{Password},{Email}";
        }
        public static User FromString(string line)
        {
            var val = line.Split(',');
            return new User
            {
                ID = int.Parse(val[0]),
                Username = val[1],
                Password = val[2],
                Email = val[3]
            };
        }
    }
}
