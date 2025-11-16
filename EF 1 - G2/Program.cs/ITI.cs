
#region student
public class Student
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public int DepId { get; set; }
}
#endregion

#region Departments
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime HiringDate { get; set; }
    public int InsId { get; set; }
}
#endregion


#region Instructors
public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal Bonus { get; set; }
    public decimal Salary { get; set; }
    public decimal HourRate { get; set; }
    public int DepId { get; set; }
}
#endregion

#region Topics
public class Topic
{
    public int Id { get; set; }
    public string Name { get; set; }
}

#endregion




#region Courses
public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    public string Description { get; set; }
    public int TopicId { get; set; }
}
#endregion


#region Stud_Course
public class StudCourse
{
    public int StudId { get; set; }
    public int CourseId { get; set; }
    public int Grade { get; set; }
}
#endregion

#region Course_Instructor
public class CourseInstructor
{
    public int CourseId { get; set; }
    public int InstId { get; set; }
    public string Evaluation { get; set; }
}
#endregion
