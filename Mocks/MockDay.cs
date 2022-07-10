using PersonalAccount.Intefaces;
using PersonalAccount.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccount.Mocks
{
    public class MockDay : IDays
    {
        public IEnumerable<Days> Week
        {
            get
            {
                return new List<Days>
                {
                    new Days {Name ="Понедельник", Date="5.07.22"},
                    new Days {Name ="Вторник", Date="6.07.22"},
                    new Days {Name ="Среда", Date="7.07.22"},
                    new Days {Name ="Четверг", Date="8.07.22"},
                    new Days {Name ="Пятница", Date="9.07.22"}

                };
                    
            }
        }
    }
}
