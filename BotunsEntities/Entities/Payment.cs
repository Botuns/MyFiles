using System;
using BotunsEntities.Contracts;
namespace BotunsEntities.Entities
{
    public class Payment : AuditableEntity
    {
        public string? ReferrenceNumber{get; set;}
        public int ClientId{get; set;}
        public Client? Client{get; set;}
        public decimal AmountPaid{get; set;}
        public string? DateOfPayment{get; set;}
        public int ContractId{get; set;}
        public Contract? Contract{get; set;}
        public bool IsVerified{get; set;}
    }
}