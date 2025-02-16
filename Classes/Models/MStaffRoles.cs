using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR_Movers_coursework.Classes.Models
{
    public class MStaffRoles
    {
        private int staffID;
        private int roleID;

        public MStaffRoles(int a, int b)
        {
            StaffID = a;
            RoleID = b;
        }


        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }


        public int RoleID
        {
            get { return staffID; }
            set { RoleID = value; }
        }


        public MStaff Staff { get; set; }
        public MRoleTable RoleTable { get; set; }





































    }
}
