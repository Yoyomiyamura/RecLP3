namespace RecLP3.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public Customer() {}

    public Customer(int id, string name, string city, string address, string email, string phone)
    {
        Id = id;
        Name = name;
        City = city;
        Address = address;
        Email = email;
        Phone = phone;
    }
}