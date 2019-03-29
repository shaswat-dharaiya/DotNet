using System;

public class Student
{
    public string name;
    public long enroll;
    public string branch;

	public Student(){}

    public Student(string name)
    {
        this.name = name;
    }
    public Student(string name, long enroll)
    {
        this.name = name;
        this.enroll = enroll;
    }
    public Student(string name, long enroll, string branch)
    {
        this.name = name;
        this.enroll = enroll;
        this.branch = branch;
    }

    public static void Main()
    {
        string name, branch;
        long enroll;

        name = "Shaswat";
        enroll = 160470107052;
        branch = "CE";

        Student s1 = new Student(name);
        Student s2 = new Student(name,enroll);
        Student s3 = new Student(name, enroll,branch);
        s1.disp();
        s2.disp();
        s3.disp();
    }

    public void disp()
    {
        Console.WriteLine(this.name);
        Console.WriteLine(this.enroll);
        Console.WriteLine(this.branch);
    }
}
