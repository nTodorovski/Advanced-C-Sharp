using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Classes
{
    public class User
    {
        public string Id { get; set; }
        public User(string id)
        {
            Id = id;
        }
    }
}
