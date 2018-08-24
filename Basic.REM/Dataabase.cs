using Basic.REM.INTFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.REM
{
    public abstract class Database
    {
        public Database(DbConfig dbConfig, params Table[] tables)
        {
        }
    }
}
