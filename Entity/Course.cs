using System;

namespace SchoolEntity
{
    public class Course
    {
        public string id { get; private set; }
        public string name { get; set; }
        public Schedule schedule { get; set; }

        public Course() => id = Guid.NewGuid().ToString();
    }
}