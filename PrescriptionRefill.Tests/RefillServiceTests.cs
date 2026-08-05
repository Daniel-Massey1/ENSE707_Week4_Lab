using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrescriptionRefill;

namespace PrescriptionRefill.Tests
{
    [TestClass]
    public class RefillServiceTests
    {
        [TestMethod]
        public void SubmitRequest_ValidPatientAndMedicine_ReturnsSuccess()
        {
            var patient = new Patient("P001", "Jane Doe");
            var service = new RefillService();

            RefillResult result = service.SubmitRequest(patient, "Amoxicillin", 5);

            Assert.IsTrue(result.Success);
            StringAssert.Contains(result.Message, "Refill requested successfully");
        }

        [TestMethod]
        public void Patient_EmptyPatientId_ThrowsException()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Patient("", "Jane Doe"));
        }

        [TestMethod]
        public void SubmitRequest_EmptyMedicineName_ReturnsFailure()
        {
            var patient = new Patient("P001", "Jane Doe");
            var service = new RefillService();

            RefillResult result = service.SubmitRequest(patient, "", 5);

            Assert.IsFalse(result.Success);
            StringAssert.Contains(result.Message, "medicine name is required");
        }

        [TestMethod]
        public void SubmitRequest_TwoOrFewerDaysRemaining_MarksRequestAsUrgent()
        {
            var patient = new Patient("P001", "Jane Doe");
            var service = new RefillService();

            RefillResult result = service.SubmitRequest(patient, "Amoxicillin", 2);

            Assert.IsTrue(result.Success);
            StringAssert.Contains(result.Message, "Marked as Urgent");
        }

        [TestMethod]
        public void SubmitRequest_ResultMessage_IsClear()
        {
            var patient = new Patient("P001", "Jane Doe");
            var service = new RefillService();

            RefillResult result = service.SubmitRequest(patient, "Amoxicillin", 10);

            Assert.IsFalse(string.IsNullOrWhiteSpace(result.Message));
        }
    }
}