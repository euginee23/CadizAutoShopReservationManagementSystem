using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadizAutoShopManagementSystem.Models
{
    public class AdminModel
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public DateTime LastLogin { get; set; }

        public AdminModel()
        {
            AdminId = 0; 
            Username = string.Empty;
            PasswordHash = string.Empty;
            Salt = string.Empty;
            LastLogin = DateTime.MinValue;
        }
    }
}
