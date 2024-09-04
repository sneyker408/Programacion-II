namespace ConexionEjemplo
{
    public class Customers
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; internal set; }
        public string ContactName { get; internal set; }
        public string ContactTitle { get; internal set; }
        public string Address { get; internal set; }
        public string City { get; internal set; }
        public string Region { get; internal set; }
        public string PostalCode { get; internal set; }
        public string Phone { get; internal set; }
        public string Country { get; internal set; }
        public string Fax { get; internal set; }
    }
}