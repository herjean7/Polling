using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polling.Domain
{
    public class File
    {
        public string FileReference { get; set; }
        public string DocumentId { get; set; }
        public string FileName { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}
