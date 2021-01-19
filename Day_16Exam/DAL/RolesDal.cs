using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class RolesDal
    {
        public int AddInfos(Roless r) 
        {
            string sql = $"insert into Roles values('{r.RName}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public int UpdateInfos(Roless r)
        {
            string sql = $"update Roles set RName='{r.RName}' where RId='{r.RId}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public int Del(int id)
        {
            string sql = $"delete Roles where RId={id}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public List<Roless> ShowRoles() 
        {
            string sql = "select  * from Roles";
            return DBHelper.GetList<Roless>(sql);
        }
    }
}
