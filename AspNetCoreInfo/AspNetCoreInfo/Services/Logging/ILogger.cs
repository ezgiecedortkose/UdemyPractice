using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInfo.Services.Logging
{
    public interface ILogger
    {
        void Log(string logMessage);
    }
}
