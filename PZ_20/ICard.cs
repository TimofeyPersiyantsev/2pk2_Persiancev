using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_20
{
    internal interface ICard
    {
        string Number { get; set; }
        string ClientFIO { get; set; }
        DateTime Validity { get; set; }
        int SecureCode { get; set; }
        string Type { get; set; }

        void PrintInfo();
    }
}
