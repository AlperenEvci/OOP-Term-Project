using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    public class cloneUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }

        public virtual object Clone()
        {
            cloneUser userProfile = new cloneUser();
            userProfile.Name = this.Name;
            userProfile.Surname = this.Surname;
            userProfile.PhoneNumber = this.PhoneNumber;
            userProfile.Address = this.Address;
            userProfile.Email = this.Email;
            userProfile.Password = this.Password;
            userProfile.ID = this.ID;
            return userProfile;
        }
    }
}
