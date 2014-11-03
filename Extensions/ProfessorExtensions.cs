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
        private static WeekClassScheduleContainer _entitiesDb = new WeekClassScheduleContainer();

        public static bool HasSchedule(this Professor p, DayOfWeek weekDay, int classNumber, int classroomId)
        {
            return _entitiesDb.WeekSchedule
                .Any(ws => ws.ProfessorId == p.Id && ws.WeekDay == (int)weekDay && ws.ClassNumber == classNumber && ws.ClassroomId != classroomId);
        }
    }
}
