namespace Mad401.LINQ.QES {
    class Teacher {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public int Dept { get; set; }
        public override string ToString() {
            return $"ID = {EmpID}, Name = {Name}, School = {School}, Dept = {Dept}";
        }


    }
}
