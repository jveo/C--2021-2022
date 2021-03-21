namespace Mad401.LINQ {
    class Department {
        public int DeptID { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return $"ID = {DeptID}, Name = {Name}";
        }

    }
}
