using System;

namespace Demo1.Common.DTOs
{
    public class PatientDto
    {
        public Guid Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
    }
}
