using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    // a class information of node
    public class PrintJob
    {
        public string DocumentName { get; set; }
        public int CopyCount { get; set; }

        public PrintJob(string documentName, int pageCount)
        {
            DocumentName = documentName;
            CopyCount = pageCount;
        }

        public override string ToString()
        {
            return $"{DocumentName} - {CopyCount} copies";
        }
    }
}
