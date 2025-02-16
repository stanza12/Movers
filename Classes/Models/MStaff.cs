using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SR_Movers_coursework.Classes.Models
{
   public class MStaff 
    {
        private int staffID;
        private string forename;
        private string surname;
        private string email;
        private string telephoneNumber;
        private int roleID;
        private string status;
        private string hours;

        public List<string> errors = new List<string>();
        public List<string> Roles { get; set; }

        public MStaff(int a, string b, string c, string d, string e, int f, string g, string h)
        {
            StaffID = a;
            Forename = b;
            Surname = c;
            Email = d;
            TelephoneNumber = e;
            RoleID = f;
            Status = g;
            Hours = h;
        }

        public MStaff() 
        {

        }

        public ICollection<MStaffRoles> staffRoles {get; set; }


        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Forename
        {
            get { return forename; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Length < 3 || value.Length > 20)
                    {
                        errors.Add("Forename length should be between 3 and 20 characters.");
                    }
                    else if (value.Any(char.IsDigit))
                    {
                        errors.Add("Forename must not include numbers.");
                    }
                    else if (value.Any(c => !char.IsLetter(c)))
                    {
                        errors.Add("Forename must not contain any special characters.");
                    }
                    else
                    {
                        forename = value;
                    }
                }
                else
                {
                    errors.Add("Forname cannot be empty or conatin spaces");
                }
            }
        }


        public string Surname
        {
            get { return surname; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Length < 3 || value.Length > 20)
                    {
                        errors.Add("Surname length should be between 3 and 20 characters.");
                    }
                    else if (value.Any(char.IsDigit))
                    {
                        errors.Add("Surname must include at least one letter.");
                    }
                    else if (value.Any(c => !char.IsLetter(c)))
                    {
                        errors.Add("Surname must not contain any special characters.");
                    }
                    else
                    {
                        surname = value;
                    }
                }
                else
                {
                    errors.Add("Surname cannot be empty or conatin spaces");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    if (value.Length > 254)
                    {
                        errors.Add("Email address cannot exceed 254 characters.");

                    }
                    else if (!System.Text.RegularExpressions.Regex.IsMatch(value, emailpattern))
                    {
                        errors.Add("Format needs to be valid (e.g. example@domain.com).");
                    }
                    else
                    {
                        email = value;
                    }


                }
                else
                {
                    errors.Add("Email address cannot be empty or conatin spaces.");
                }
            }
        }

        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {

                    string sanitizedValue = value.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
                    string ukPhonePattern = @"^(0\d{9,10}|(\+44)\d{9,10})$";

                    if (!System.Text.RegularExpressions.Regex.IsMatch(sanitizedValue, ukPhonePattern))
                    {
                        errors.Add("A valid UK geographic phone number must contain 9 or 10 digits after '0' or '+44'.");
                    }
                    else
                    {
                        telephoneNumber = value;
                    }
                }
                else
                {
                    errors.Add("Phone number cannot be empty or contain spaces.");
                }
            }
        }

        public static string ValidatePassword(string password )
        {
            if (password.Length < 8)
                return "Password must be at least 8 characters long.";

            if (!password.Any(char.IsUpper))
                return "Password must contain at least one uppercase letter.";

            if (!password.Any(char.IsLower))
                return "Password must contain at least one lowercase letter.";

            if (!password.Any(char.IsDigit))
                return "Password must contain at least one number.";

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return "Password must contain at least one special character.";
            }
            
            var repeatingCharGroups = password.GroupBy(ch => ch)
                                          .Where(g => g.Count() > password.Length / 2);
            if (repeatingCharGroups.Any())
            {
               return "Password should not have too many repeating characters.";
            }


            return null;


        }






        public int RoleID
        {
            get { return roleID;}
            set { roleID = value; }
        }


        public string Status
        {
            get { return status; }
            set{ status = value;}
        }


        public string Hours
        {
            get { return hours; }
            set { hours = value; }
        }











    }
}




















  