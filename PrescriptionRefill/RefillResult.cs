using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionRefill
{
    public class RefillResult
    {
        public bool Success { get; }
        public string Message { get; }

        public RefillResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}