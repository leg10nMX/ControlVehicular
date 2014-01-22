using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlVehicular.Constants
{
    public class ConnectionStrings
    {
#if DEBUG
        public const string DataBaseConnectionName = "EntitiesContext";
#else
        public const string DataBaseConnectionName = "DatabaseConnection";
#endif
    }
}