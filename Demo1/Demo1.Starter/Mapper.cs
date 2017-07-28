using System;
using System.Collections.Generic;
using Demo1.Common.DTOs;
using Demo1.ViewModel;

namespace Demo1.Starter
{
    internal class Mapper
    {
        internal static List<PatientViewModel> Map(List<PatientDto> patientList)
        {
            var vms = new List<PatientViewModel>();
            foreach(var patient in patientList)
            {
                vms.Add(Map(patient));
            }

            return vms;
        }

        private static PatientViewModel Map(PatientDto patient)
        {
            return new PatientViewModel
            {
                Id = patient.Id,
                DisplayName = patient.FamilyName + ", " + patient.GivenName
            };
        }
    }
}