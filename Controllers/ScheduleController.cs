using Microsoft.AspNetCore.Mvc;
using PersonalAccount.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PersonalAccount.Controllers
{
    public class ScheduleController : Controller
    {

        private readonly ISchedule _schedule;
        private readonly IDays _days;
        public ScheduleController(ISchedule schedule, IDays days)
        {
            _schedule = schedule;
            _days = days;
        }

        public ViewResult List()
        {
            var schedule = _schedule.Schedule;
            return View(schedule);
        }
    }
}
