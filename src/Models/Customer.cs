namespace shopStore.Models;

public class Customer {

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public DateTime RegistrationDate { get; set; }
    public IList<Product> Productes { get; set; }

}