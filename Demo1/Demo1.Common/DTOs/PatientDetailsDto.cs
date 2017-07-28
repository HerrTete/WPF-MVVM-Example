using System;

namespace Demo1.Common.DTOs
{
    public class PatientDetailsDto
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public string Notes { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
