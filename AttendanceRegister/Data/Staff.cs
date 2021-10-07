using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceRegister.Data
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
