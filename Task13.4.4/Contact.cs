public class Contact 
{
    public Contact(long phoneNumber, String email)
    {
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public long PhoneNumber { get; set; }
    public String Email { get; set; }
}
