using Demo1.Common.Interfaces;
using System;
using Demo1.Common.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Demo1.Data
{
    public class DemoDataSource : IDataSource
    {
        private List<PatientDto> _patients = new List<PatientDto>();
        private List<PatientDetailsDto> _patientDetails = new List<PatientDetailsDto>();
        private List<InsuranceDto> _insurances = new List<InsuranceDto>();
        private List<PatientRecordDto> _patientRecords = new List<PatientRecordDto>();

        public DemoDataSource()
        {
            _patients.Add(
                new PatientDto
                {
                    Id = Guid.NewGuid(),
                    FamilyName = "Mustermann",
                    GivenName = "Max"
                });
            _patientDetails.Add(
                new PatientDetailsDto
                {
                    Id = Guid.NewGuid(),
                    PatientId = _patients.LastOrDefault().Id,
                    DateOfBirth = new DateTime(1965, 11, 6)
                });
            _patients.Add(
                new PatientDto
                {
                    Id = Guid.NewGuid(),
                    FamilyName = "Mustermann",
                    GivenName = "Manuela"
                });
            _patientDetails.Add(
                new PatientDetailsDto
                {
                    Id = Guid.NewGuid(),
                    PatientId = _patients.LastOrDefault().Id,
                    DateOfBirth = new DateTime(1983, 1, 16)
                });
            _patients.Add(
                new PatientDto
                {
                    Id = Guid.NewGuid(),
                    FamilyName = "Mustermann",
                    GivenName = "Horst"
                });
            _patientDetails.Add(
                new PatientDetailsDto
                {
                    Id = Guid.NewGuid(),
                    PatientId = _patients.LastOrDefault().Id,
                    DateOfBirth = new DateTime(1986, 4, 19)
                });
            _patients.Add(
                new PatientDto
                {
                    Id = Guid.NewGuid(),
                    FamilyName = "Schulze",
                    GivenName = "Gerd"
                });
            _patientDetails.Add(
                new PatientDetailsDto
                {
                    Id = Guid.NewGuid(),
                    PatientId = _patients.LastOrDefault().Id,
                    DateOfBirth = new DateTime(1991, 7, 28)
                });

            foreach(var patient in _patients)
            {

                _patientRecords.Add(
                    new PatientRecordDto
                    {
                        Id = Guid.NewGuid(),
                        Content = "Patient " + patient.FamilyName + ", " + patient.GivenName + " hat große Schmerzen im linken Bein",
                        Created = DateTime.Now.AddDays(-3),
                        PatientId = patient.Id
                    });
                _patientRecords.Add(
                    new PatientRecordDto
                    {
                        Id = Guid.NewGuid(),
                        Content = "Patient " + patient.FamilyName + ", " + patient.GivenName + " ist am letzten WE mit dem Bein gegen einen Tisch gelaufen",
                        Created = DateTime.Now.AddDays(-3),
                        PatientId = patient.Id
                    });
                _patientRecords.Add(
                    new PatientRecordDto
                    {
                        Id = Guid.NewGuid(),
                        Content = patient.FamilyName + ", " + patient.GivenName + " Einfache Fraktur der Tibula",
                        Created = DateTime.Now.AddDays(-3),
                        PatientId = patient.Id
                    });
                _patientRecords.Add(
                    new PatientRecordDto
                    {
                        Id = Guid.NewGuid(),
                        Content = "S82.40",
                        Created = DateTime.Now.AddDays(-3),
                        PatientId = patient.Id
                    });
            }

            _insurances.Add(
                new InsuranceDto
                {
                    Id = Guid.NewGuid(),
                    Name = "AOK",
                    MaxCoveragePerYear = 400
                });
            _insurances.Add(
                new InsuranceDto
                {
                    Id = Guid.NewGuid(),
                    Name = "TKK",
                    MaxCoveragePerYear = 450
                });
            _insurances.Add(
                new InsuranceDto
                {
                    Id = Guid.NewGuid(),
                    Name = "BKK",
                    MaxCoveragePerYear = 430
                });
        }


        public PatientDetailsDto GetDetailsForPatientId(Guid patientId)
        {
            return _patientDetails.Find(d => d.PatientId == patientId);
        }

        public List<InsuranceDto> GetInsurancesForPatientId(Guid patientId)
        {
            return _insurances;
        }

        public List<PatientDto> GetPatientList()
        {
            return _patients;
        }

        public List<PatientRecordDto> GetPatientRecordsForPatientId(Guid patientId)
        {
            return _patientRecords.Where(d => d.PatientId == patientId).ToList();
        }

        public List<PatientDto> SearchForPatient(string searchString)
        {
            return _patients.Where(p => p.FamilyName.StartsWith(searchString) || p.GivenName.StartsWith(searchString)).ToList();
        }
    }
}
