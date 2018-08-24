using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.REM.INTFC
{
    internal interface IDatabase
    {
        IDatabase Database(DbConfig dbConfig, params ITable[] tables);
    }
}
