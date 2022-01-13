using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccoutModel
    {
        private ShopDbContext context = null;
        public AccoutModel()
        {
            context = new ShopDbContext();
        }
        public bool Login(string userName , string passWord)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@PassWord",passWord),
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @UserName,@PassWord ", sqlParams).SingleOrDefault();
            return res;
        }

        public object Login(int userName, string passWord)
        {
            throw new NotImplementedException();
        }
    }
}
