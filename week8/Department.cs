namespace Mad401.LINQ.QES {
    class Department {
        public int DeptID { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return $"ID = {DeptID}, Name = {Name}";
        }

    }
}
