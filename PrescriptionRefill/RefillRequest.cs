using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionRefill
{
    public class RefillRequest
    {
        public string MedicineName { get; }
        public int DaysRemaining { get; }
        public bool IsUrgent { get; }

        public RefillRequest(string medicineName, int daysRemaining)
        {
            MedicineName = medicineName;
            DaysRemaining = daysRemaining;
            IsUrgent = daysRemaining <= 2;
        }
    }
}