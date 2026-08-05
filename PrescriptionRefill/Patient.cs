using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionRefill
{
    public class Patient
    {
        public string Id { get; }
        public string FullName { get; }

        public Patient(string id, string fullName)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Patient ID is required.");
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Patient name is required.");

            Id = id;
            FullName = fullName;
        }
    }
}