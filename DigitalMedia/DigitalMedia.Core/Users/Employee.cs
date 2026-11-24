public class Employee: IUser
{
    public string name {get; set;}
    public int age {get; set;}
    public int socialSecurityNumber {get; set;}

    public Employee(string name, int age, int socialSecuritNumber)
    {
        this.name = name;
        this.age = age;
        this.socialSecurityNumber = socialSecuritNumber;
    }

    public void addMedia()
    {
        
    }

    public void removeMedia()
    {
        
    }
}