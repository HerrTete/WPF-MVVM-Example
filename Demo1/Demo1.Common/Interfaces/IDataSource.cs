using Demo1.Common.DTOs;
using System;
using System.Collections.Generic;

namespace Demo1.Common.Interfaces
{
    public interface IDataSource
    {
        List<PatientDto> GetPatientList();
        List<PatientDto> SearchForPatient(string searchString);
        PatientDetailsDto GetDetailsForPatientId(Guid patientId);
        List<InsuranceDto> GetInsurancesForPatientId(Guid patientId);
        List<PatientRecordDto> GetPatientRecordsForPatientId(Guid patientId);
    }
}
