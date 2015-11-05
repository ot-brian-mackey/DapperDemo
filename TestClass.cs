using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OneTechnologies.Credit.CallCredit.Domain;

namespace WindowsFormsApplication1
{
    public class TestClass
    {
        private const string BureauDb = "Data Source=localhost;Initial Catalog=Bureau;Persist Security Info=True;";

        public CallCreditClient Test()
        {
            var parameters = new
            {
                param1 = "hey"
            };

            using (IDbConnection db = new SqlConnection(BureauDb))
            {
                var responses =
                     db.Query<CallCreditClient>("dbo.myproc", parameters, commandType: CommandType.StoredProcedure);

                if (responses != null)
                {
                    return responses.First();
                }

                return null;
            }
        }
        /// <summary>
        /// Internal use only.  Ignore me
        /// </summary>
        /// <param name="userIdentifier"></param>
        /// <param name="txn"></param>
        /// <returns></returns>
        public CallCreditClient Read(Guid userIdentifier, IDbTransaction txn = null)
        {
            var parameters = new
            {
                UserIdentifier = userIdentifier
            };

            using (var db = new SqlConnection(BureauDb))
            {
                var responses =
                    db.Query<CallCreditClient>("crud.callcreditClientsRead", parameters, commandType: CommandType.StoredProcedure);

                if (responses != null)
                {
                    return responses.OrderBy(r => r.LastScoreRequestDate).First();
                }
            }

            return new CallCreditClient();
        }
    }
}
