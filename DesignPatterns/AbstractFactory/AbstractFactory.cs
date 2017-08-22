using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public virtual DbConnection Connection { get; set; }
        public virtual DbCommand Cmmand { get; set; }
    }
}
