using System.Collections.Generic;

namespace Mad401.LINQ.QES {
    class Student {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int[] Courses { get; set; }
        public override string ToString() {
            return $"ID = {StudentID}, Name = {Name}, Courses = {string.Join(",", Courses)}";
        }

    }
}
