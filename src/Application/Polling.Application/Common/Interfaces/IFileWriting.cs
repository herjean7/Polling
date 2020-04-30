using Polling.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polling.Application.Interfaces
{
    public interface IFileWriting
    {
        void CreatePDF(List<Person> persons, string filedepositpath);
    }
}
