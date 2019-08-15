using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StCourse.Model
{
    public static class Repository
    {
        private static List<Student> StudentsList = new List<Student>();

        public static List<Student> Students { get
            {
                return StudentsList;
            } }

        public static void AddStudent(Student student)
        {
            StudentsList.Add(student);
        }
    }

}
