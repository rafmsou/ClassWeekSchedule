using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Entity;
using WeekClassSchedule.AppData;

namespace WeekClassSchedule.AppDatalayer
{
    public class ScheduleDatalayer
    {
        private WeekClassScheduleEntities _entitiesDb;

        public ScheduleDatalayer()
        {
            this._entitiesDb = new WeekClassScheduleEntities();
        }

        public async Task<List<vWeeklyScheduleByClass>> AllSchedulesAsync()
        {
            return await _entitiesDb.vWeeklyScheduleByClass.ToListAsync();
        }

        public List<vWeeklyScheduleByClass> ScheduleViewByClass(long classroomId)
        {
            _entitiesDb = new WeekClassScheduleEntities();

            var result = _entitiesDb.vWeeklyScheduleByClass.Where(ws => ws.ClassroomId == classroomId).ToList();
            return result;
        }

        public List<WeekSchedule> WeekScheduleByClass(long classroomId)
        {
            return _entitiesDb.WeekSchedule.Where(ws => ws.ClassroomId == classroomId).ToList();
        }

        public async Task SaveWeekSchedulesAsync(List<vWeeklyScheduleByClass> schedulesView)
        {
            var classroomId = schedulesView.First().ClassroomId;
            var weekScheduleList = this.WeekScheduleByClass(classroomId);

            foreach (var item in schedulesView)
            {
                var mondaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (long)DayOfWeek.Monday).Single();
                mondaySchedule.ProfessorId = item.Monday;

                var tuesdaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (long)DayOfWeek.Tuesday).Single();
                tuesdaySchedule.ProfessorId = item.Tuesday;

                var wednesdaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (long)DayOfWeek.Wednesday).Single();
                wednesdaySchedule.ProfessorId = item.Wednesday;

                var thursdaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (long)DayOfWeek.Thursday).Single();
                thursdaySchedule.ProfessorId = item.Thursday;

                var fridaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (long)DayOfWeek.Friday).Single();
                fridaySchedule.ProfessorId = item.Friday;

                this._entitiesDb.Entry(item).State = EntityState.Detached;
            }

            await this._entitiesDb.SaveChangesAsync();
        }
    }
}
