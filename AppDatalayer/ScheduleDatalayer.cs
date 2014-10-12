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

        public List<vWeeklyScheduleByClass> ScheduleViewByClass(int classroomId)
        {
            _entitiesDb = new WeekClassScheduleEntities();
            return _entitiesDb.vWeeklyScheduleByClass.Where(ws => ws.ClassroomId == classroomId).ToList();
        }

        public List<WeekSchedule> WeekScheduleByClass(int classroomId)
        {
            return _entitiesDb.WeekSchedule.Where(ws => ws.ClassroomId == classroomId).ToList();
        }

        public async Task SaveWeekSchedulesAsync(List<vWeeklyScheduleByClass> schedulesView)
        {
            var classroomId = schedulesView.First().ClassroomId;
            var weekScheduleList = this.WeekScheduleByClass(classroomId);

            foreach (var item in schedulesView)
            {
                var mondaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (int)DayOfWeek.Monday).Single();
                mondaySchedule.ProfessorId = item.Monday.Value;

                var tuesdaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (int)DayOfWeek.Tuesday).Single();
                tuesdaySchedule.ProfessorId = item.Tuesday.Value;

                var wednesdaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (int)DayOfWeek.Wednesday).Single();
                wednesdaySchedule.ProfessorId = item.Wednesday.Value;

                var thursdaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (int)DayOfWeek.Thursday).Single();
                thursdaySchedule.ProfessorId = item.Thursday.Value;

                var fridaySchedule = weekScheduleList.Where(w => w.ClassNumber == item.ClassNumber && w.WeekDay == (int)DayOfWeek.Friday).Single();
                fridaySchedule.ProfessorId = item.Friday.Value;

                this._entitiesDb.Entry<vWeeklyScheduleByClass>(item).State = EntityState.Unchanged;
            }

            await this._entitiesDb.SaveChangesAsync();
        }
    }
}
