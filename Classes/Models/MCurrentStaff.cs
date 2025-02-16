using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SR_Movers_coursework.Classes.Models
{
    public class MCurrentStaff : MasterDB
    {
        public static MCurrentStaff CurrentStaff { get; set; }
        public int StaffID { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Roles { get; set; }
        public int Status { get; set; }
        public int Hours { get; set; }


      
    }
}