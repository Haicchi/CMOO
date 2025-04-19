using System.Reflection.PortableExecutable;

namespace LAB_7_1;

public class Person:IComparable,ICloneable
{
    string firstName;
    string lastName;
    DateTime birth;

    public Person(string firstname, string lastname, DateTime birth)
    {
        this.firstName = firstname;
        this.lastName = lastname;
        this.birth = birth;
    }
    public Person()
    {
        firstName = "";
        lastName = "";
        birth = DateTime.Now;
    }
    public string Firstname { get { return firstName; } set { firstName = value; } }
    public string Lastname { get { return lastName; } set { lastName = value; } }
    public DateTime Birth { get { return birth; } set { birth = value; } }
    public override string ToString()
    {
        return $"Firstname: {firstName}|Lastname: {lastName}| birth date: {birth}";
    }
    public string ToShortString()
    {
        return $"Firstname: {firstName}|Lastname: {lastName}";
    }

    public int CompareTo(object obj)
    {
        Person temp = (Person)obj;
        if (this.firstName.Length > temp.firstName.Length) return 1;
        if (this.firstName.Length < temp.firstName.Length) return -1;
        return 0;
    }

    public object Clone()
    {
        return new Person
        {
            firstName = this.firstName,
            lastName = this.lastName,
            birth = this.birth
        };
    }
}