using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public interface IConvertAdapter
    {
        void GetString(ReturningStrings returningStrings); // Can get string or int
    }
}
