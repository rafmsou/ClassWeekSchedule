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
    public class ClassroomDatalayer
    {
        private WeekClassScheduleEntities _entitiesDb;
        private List<Classroom> _classroomList;

        public ClassroomDatalayer()
        {
            _entitiesDb = new WeekClassScheduleEntities();
        }

        public List<Classroom> ClassroomList
        {
            get {
                if (_classroomList == null)
                    _classroomList = _entitiesDb.Classroom.ToList();

                return _classroomList;
            }

            set {
                this._classroomList = value;
            }
        }

        public async Task<List<Classroom>> GetClassroomListAsync()
        {
            return await _entitiesDb.Classroom.OrderBy(i => i.Name).ToListAsync();
        }

        public void Save(Classroom classroomToSave)
        {
            _entitiesDb.Classroom.Add(classroomToSave);
            _entitiesDb.SaveChanges();
            _classroomList.Add(classroomToSave);
        }

        public void GenerateWeekSchedule(string classroomName)
        {
            var classroom = this._classroomList.Where(c => c.Name.Equals(classroomName)).FirstOrDefault();
            if (classroom != null)
            {
                ClassroomClasses classes;

                for (short i = 1; i <= classroom.NumberOfClasses; i++)
                {
                    classes = new ClassroomClasses();
                    classes.ClassromId = classroom.Id;
                    classes.ClassNumber = i;
                    _entitiesDb.ClassroomClasses.Add(classes);

                    WeekSchedule weekSchedule;
                    for (short w = (short)DayOfWeek.Monday; w <= (short)DayOfWeek.Friday; w++)
                    {
                        weekSchedule = new WeekSchedule();
                        weekSchedule.ClassroomId = (short)classroom.Id;
                        weekSchedule.ClassNumber = i;
                        weekSchedule.ProfessorId = 0;
                        weekSchedule.WeekDay = w;

                        _entitiesDb.WeekSchedule.Add(weekSchedule);
                    }
                }
                _entitiesDb.SaveChanges();
          }
       }
    }
}
