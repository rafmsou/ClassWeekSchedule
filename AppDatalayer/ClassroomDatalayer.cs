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
            if (classroomToSave.Id == 0)
            {
                _entitiesDb.Classroom.Add(classroomToSave);
                _entitiesDb.SaveChanges();

                _classroomList.Add(classroomToSave);
            }
            else
            {
                var classroomToUpdate = _entitiesDb.Classroom.Where(c => c.Id == classroomToSave.Id).Single();
                classroomToUpdate.Name = classroomToSave.Name;
                classroomToUpdate.NumberOfClasses = classroomToSave.NumberOfClasses;
                _entitiesDb.SaveChanges();
            }
        }

        public void Remove(long classroomId)
        {
            var classroomToRemove =_entitiesDb.Classroom.Where(c => c.Id == classroomId).Single();
            _entitiesDb.Classroom.Remove(classroomToRemove);

            _entitiesDb.SaveChanges();
            _classroomList.Remove(classroomToRemove);
        }

        public void GenerateWeekSchedule(long classroomId)
        {
            var classroom = this._classroomList.Where(c => c.Id.Equals(classroomId)).FirstOrDefault();
            if (classroom != null && !classroom.WeekSchedule.Any())
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
                        weekSchedule.ClassroomId = classroom.Id;
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
