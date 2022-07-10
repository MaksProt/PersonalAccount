using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccount.Models
{
    public class Days
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public List<Schedule> schedule { get; set; }

    }
}
