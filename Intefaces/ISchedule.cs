using PersonalAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccount.Intefaces
{
    public interface ISchedule
    {
        IEnumerable<Schedule> Schedule { get; }
        Schedule getObjectSchedule(int SchId);

    }
}
