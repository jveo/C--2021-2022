namespace Mad401.LINQ {
    class Course {
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Term { get; set; }
        public int Capacity { get; set; }
        public int Teacher { get; set; }
        public override string ToString() {
            return $"ID = {CourseID}, Code = {CourseCode}, Name = {Name}, Cost = {Cost.ToString("C2")}, Term = {Term}, Capacity = {Capacity}, Teacher = {Teacher}";
        }
    }
}
