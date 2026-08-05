using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionRefill
{
    public class RefillService
    {
        public RefillResult SubmitRequest(Patient patient, string medicineName, int daysRemaining)
        {
            if (patient == null)
                return new RefillResult(false, "Refill failed: patient details are required.");

            if (string.IsNullOrWhiteSpace(medicineName))
                return new RefillResult(false, "Refill failed: medicine name is required.");

            var request = new RefillRequest(medicineName, daysRemaining);
            string urgencyNotice = request.IsUrgent ? " (Marked as Urgent)" : "";

            return new RefillResult(
                true,
                $"Refill requested successfully for {request.MedicineName}{urgencyNotice}."
            );
        }
    }
}