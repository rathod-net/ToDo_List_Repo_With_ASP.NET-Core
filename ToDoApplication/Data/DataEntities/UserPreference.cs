using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataEntities
{
    public class UserPreference
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Language { get; set; } = "en";
        public bool EnableDarkMode { get; set; } = false;
        public bool NotifyByEmail { get; set; } = true;

        public Guid UserId { get; set; }
        public User User { get; set; }
    }

}
