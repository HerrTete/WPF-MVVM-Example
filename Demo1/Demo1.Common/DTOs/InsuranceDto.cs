using System;

namespace Demo1.Common.DTOs
{
    public class InsuranceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaxCoveragePerYear { get; set; }
    }
}
