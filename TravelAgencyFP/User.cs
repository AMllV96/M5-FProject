using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyFP
{
    public class User
    {
        private int id;
        private string email;
        private int role;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (id > 0)
                {
                    id = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != null && !string.IsNullOrEmpty(email) && !string.IsNullOrWhiteSpace(email))
                {
                    email = value;
                }
            }
        }
        public int Role
        {
            get
            {
                return role;
            }
            set
            {
                if (role>=0)
                {
                    role = value;
                }
            }
        }

        public User(int id, string email, int role)
        {
            this.id = id;
            this.email = email;
        }

        public override string? ToString()
        {
            return email;
        }
    }
}
