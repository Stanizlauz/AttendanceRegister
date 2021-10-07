using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceRegister.Data
{
    public class Attendance
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Status { get; set; }
        
        public bool SignIn { get; set; }
        
        public bool SignOut { get; set; }

        public string Reason { get; set; }


        [ForeignKey(nameof(Staff))]
        public int StaffId { get; set; }

        [ForeignKey(nameof(Staff.Name))]
        public Staff StaffName { get; set; }
        
    }
}
