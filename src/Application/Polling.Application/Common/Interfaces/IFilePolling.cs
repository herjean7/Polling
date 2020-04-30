using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polling.Application.Common.Interfaces
{
    public interface IFilePolling
    {
        String GetDocID(string fileref);
    }
}
