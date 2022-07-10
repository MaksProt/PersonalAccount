using PersonalAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccount.Intefaces
{
    public interface IDays
    {
        IEnumerable<Days> Week { get; }
    }
}
