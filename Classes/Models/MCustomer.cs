using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR_Movers_coursework.Classes
{
    class MCustomer
    {
        private int customerID;
        private string forename;
        private string surname;
        private string email;
        private string telephoneNo;
        private string billingAddress;

        
    public List<string> errors = new List<string>();

        public MCustomer(int a, string b, string c, string d, string e, string f )
        {
            CustomerID = a;
            Forename = b;
            Surname = c;
            Email = d;
            TelephoneNo = e;
            BillingAddress = f;

        }

        public MCustomer()
        {

        }

        public int CustomerID
    {
        get { return CustomerID; }
        set { CustomerID = value; }
    }




        public string Forename
        {
            get {return forename;}
            set
            {
                 if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Length < 3 || value.Length > 20 )
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
            get {return surname;}
            set
            {
                 if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Length < 3 || value.Length > 20 )
                    {
                        errors.Add("Surname length should be between 3 and 20 characters.");
                    }
                    else if (value.Any(char.IsDigit))
                        {
                         errors.Add("Surname must must not include numbers");
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
            get {return email;}
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    if (value.Length > 254)
                    {
                        errors.Add("Email address cannot exceed 254 characters.");

                    }
                    else if(!System.Text.RegularExpressions.Regex.IsMatch(value,emailpattern))
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

        public string TelephoneNo
        {
            get { return telephoneNo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                 
                    string sanitizedValue = value.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
                    string ukPhonePattern = @"^(0\d{9,10}|(\+44)\d{9,10})$";

                    if (!System.Text.RegularExpressions.Regex.IsMatch(sanitizedValue, ukPhonePattern))
                    {
                        errors.Add("Phone number must contain 9 or 10 digits after '0' or '+44'.");
                    }
                    else
                    {
                        telephoneNo = value;  
                    }
                }
                else
                {
                    errors.Add("Phone number cannot be empty or contain spaces.");
                }
            }
        }

        public string BillingAddress
        {
            get { return billingAddress; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Length < 10)
                    {
                        errors.Add("Billing address should be at least 10 characters long.");
                    }
                    else
                    {
                        billingAddress = value;  
                    }
                }
                else
                {
                    errors.Add("Billing address cannot be empty or whitespace.");
                }
            }
        }



     }
        }



