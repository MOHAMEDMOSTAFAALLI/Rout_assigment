using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PART2.Interfaces
{
    public interface IAuthenticationService
    {
        object users { get; set; }
        object roles { get; set; }

        public bool AuthenticateUser(string username, string password)
        {
            // Check if username exists and password matches
            if (users.ContainsKey(username) && users[username] == password)
            {
                return true;
            }
            return false;
        }
        public bool AuthorizeUser(string username, string requiredRole)
        {
            // Check if user exists and has the required role
            if (roles.ContainsKey(username) && roles[username] == requiredRole)
            {
                return true;
            }
            return false;

        }
    }
}
