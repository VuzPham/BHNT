using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHiemNhanTho
{
    public class Customer
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string CustomerId { get; set; }

        public Name Name { get; set; }

        public DateTime Dob { get; set; }

        public string Gender { get; set; }

        public Address Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<InsurancePolicy> InsurancePolicies { get; set; }

        public List<Payment> Payments { get; set; }
    }

    public class Name
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }

    public class InsurancePolicy
    {
        public ObjectId PolicyId { get; set; }

        public string PolicyNumber { get; set; }

        public string PolicyType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Premium { get; set; }

        public decimal CoverageAmount { get; set; }

        public List<Beneficiary> Beneficiaries { get; set; }

        public List<Claim> Claims { get; set; }
    }

    public class Beneficiary
    {
        public string Name { get; set; }

        public string Relationship { get; set; }

        public int Percentage { get; set; }
    }

    public class Claim
    {
        public ObjectId ClaimId { get; set; }

        public string ClaimNumber { get; set; }

        public DateTime DateOfClaim { get; set; }

        public decimal ClaimAmount { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }
    }

    public class Payment
    {
        public ObjectId PaymentId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PaymentMethod { get; set; }
    }
}
