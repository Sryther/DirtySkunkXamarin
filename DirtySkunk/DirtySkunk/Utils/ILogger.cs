using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtySkunk.Core.Utils
{
    public interface ILogger
    {
        void WriteLine(string message);
    }
}
