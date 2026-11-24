public class Borrower: IUser
{
    public string name {get; set;}
    public int age {get; set;}
    public int socialSecurityNumber {get; set;}

    public Borrower(string name, int age, int socialSecurityNumber )
    {
        this.name = name;
        this.age = age;
        this.socialSecurityNumber = socialSecurityNumber;
    }

    public void selectMedia()
    {
        
    }

    public void previewMedia()
    {
        
    }

    public void rateMedia()
    {
        
    }
}