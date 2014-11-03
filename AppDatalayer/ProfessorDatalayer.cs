using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WeekClassSchedule.AppData;
using WeekClassSchedule.Extensions;

namespace WeekClassSchedule.AppDatalayer
{
    public class ProfessorDatalayer
    {
        private WeekClassScheduleContainer _entitiesDb;
        private List<Professor> _professorList;

        public ProfessorDatalayer()
        {
            _entitiesDb = new WeekClassScheduleContainer();
        }

        public Professor GetById(long id)
        {
            return _entitiesDb.Professor.Single(p => p.Id == id);
        }

        public List<Professor> GetProfessorList()
        {
            if (_professorList == null)
                _professorList = _entitiesDb.Professor.OrderBy(i => i.Name).ToList();

            return _professorList;
        }

        public async Task<List<Professor>> GetProfessorListAsync()
        {
            return await _entitiesDb.Professor.OrderBy(i => i.Name).ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await this._entitiesDb.SaveChangesAsync();
        }

        public void SaveOrUpdate(Professor professorToSave)
        {
            if (professorToSave.Id == 0)
                _entitiesDb.Professor.Add(professorToSave);

            _entitiesDb.SaveChanges();
        }

        public void Remove(long professorId)
        {
            var professor = this.GetById(professorId);
            _entitiesDb.Professor.Remove(professor);
            _entitiesDb.SaveChanges();
        }

        public void RemoveAttendanceRules(List<AttendanceRules> attendanceRules)
        {
            _entitiesDb.AttendanceRules.RemoveRange(attendanceRules);
            _entitiesDb.SaveChanges();
        }

        public List<Professor> GetForScheduling(DayOfWeek dayOfWeek, int classNumber, int classroomId)
        { 
            return _professorList
                        .Where(p => p.AttendanceRules.Any(rule => rule.ClassNumber == classNumber && rule.DayOfWeek == (int)dayOfWeek)
                        && !p.HasSchedule(dayOfWeek, classNumber, classroomId)
                        && p.NumberOfRemainingClasses > 0).ToList();  
        }
    }
}
