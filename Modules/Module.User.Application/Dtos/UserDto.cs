using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.User.Application.Dtos
{
    public  class UserDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
