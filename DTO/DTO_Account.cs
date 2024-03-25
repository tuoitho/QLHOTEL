using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        private string userName;
        private string passWord;
        private string email;
        private string role;
        private string maNV;
        //get,set
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Role { get => role; set => role = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
