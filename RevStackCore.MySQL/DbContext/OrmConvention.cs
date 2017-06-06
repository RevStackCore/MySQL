using System;
using System.Collections.Generic;
using System.Text;

namespace RevStackCore.MySQL.DbContext
{
    public class OrmConvention : Dapper.FastCrud.Configuration.OrmConventions
    {
        public OrmConvention()
        {
            this.ClearEntityToTableNameConversionRules();
        }
    }
}
