using System;

namespace Demo1.Common.DTOs
{
    public class PatientRecordDto
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
