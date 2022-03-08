
var p = new Person("Roland", "Guijt", null);

if (p is Person { Address.City: "Amsterdam" } person)
    Console.WriteLine(person.FirstName);

public record Person(string FirstName, string LastName, Address Address);
public record Address(string Street, string City);
