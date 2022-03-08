
var address = new Address("Main", "Washington");

string c;
(string s, c) = address;
public record class Address(string Street, string City);
