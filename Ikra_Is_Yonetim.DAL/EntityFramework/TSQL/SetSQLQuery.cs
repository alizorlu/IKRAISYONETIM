using Ikra_Is_Yonetim.DAL.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.TSQL
{
    public interface ISetSQLQuery
    {
        int SetQuery(string query);
        
    }
    public class IkraContextTsql : ISetSQLQuery
    {
        private IkraContext _context;
        public IkraContextTsql()
        {
            _context = new IkraContext();
        }
        public int SetQuery(string query)
        {
            return _context.Database.ExecuteSqlCommand(query);
        }
    }
    public class SetSQLQuery
    {
    }
}
