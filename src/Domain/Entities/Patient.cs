﻿namespace Domain.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        // Other domain-specific properties
    }
}