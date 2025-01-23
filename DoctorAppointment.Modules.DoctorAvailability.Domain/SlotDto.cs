using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Modules.DoctorAvailability.Domain
{
    public class SlotDto
    {
        public string DoctorName { get; set; }
        public bool IsReserved  { get; set; }
        public decimal Cost  { get; set; }
    }
}
