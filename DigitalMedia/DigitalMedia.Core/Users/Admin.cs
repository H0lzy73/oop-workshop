using System.Security.Cryptography;

public class Admin : IUser
{
    public string name { get; set; }
    public int age { get; set; }
    public int socialSecurityNumber { get; set; }
    public Admin(string name, int age, int socialSecurityNumber )
    {
        this.name = name;
        this.age = age;
        this.socialSecurityNumber = socialSecurityNumber;

    }

    public void View()
    {
        
    }

    public void Create()
    {
        
    }

    public void Delete()
    {
        
    }

    public void UpdateInfo()
    {
        
    }

}