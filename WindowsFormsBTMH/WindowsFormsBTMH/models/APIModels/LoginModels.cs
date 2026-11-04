using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBTMH.models.APIModels
{
    public class LoginModel
    {
        public string sessionId { get; set; }
        public string accessToken { get; set; }
        public string expireDate { get; set; }
        public string refreshToken { get; set; }
        public string expireDateRefreshToken { get; set; }
        public AccountInfo accountInfo { get; set; }
        public List<string> listMenu { get; set; }

    }

    public class AccountInfo
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string idStaff { get; set; }
        public string idDivision { get; set; }
    }
}
