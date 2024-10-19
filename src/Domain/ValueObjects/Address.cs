namespace Domain.ValueObjects
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        // Methods to enforce invariants and encapsulate logic
    }
}