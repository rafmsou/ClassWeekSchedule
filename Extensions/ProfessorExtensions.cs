using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekClassSchedule.AppData;

namespace WeekClassSchedule.Extensions
{
    public static class ProfessorExtensions
    {
        private static WeekClassScheduleEntities _entitiesDb = new WeekClassScheduleEntities();

        public static bool HasSchedule(this Professor p, DayOfWeek weekDay, int classNumber)
        {
            return _entitiesDb.WeekSchedule
                .Any(ws => ws.ProfessorId == p.Id && ws.WeekDay == (int)weekDay && ws.ClassNumber == classNumber);
        }
    }
}
