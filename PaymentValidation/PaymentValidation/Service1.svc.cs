using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PaymentValidation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Boolean CreditCardVal(string Cardno, String Name, string Cvv, string Expiry_date)
        {
            Boolean isVal = false;


            if (Cardno == "" || Cvv == "" || Expiry_date == "")
                return isVal;



            int cardno = Convert.ToInt32(Cardno.Trim());
            int cvv = Convert.ToInt32(Cvv.Trim());
            int expiry_date = Convert.ToInt32(Expiry_date.Trim());



            try
            {
                if (cardno >= 1000 && cardno <= 9999) // expected cardnumber range
                {
                    if (cvv >= 100 && cvv <= 999) // expected cvv range
                    {
                        if (expiry_date % 100 >= 1 && expiry_date % 100 <= 12) // month check
                        {

                            if (expiry_date >= Convert.ToInt32(DateTime.Now.ToString("yyyyMM"))) // expiry date check
                            {
                                if (Name.Contains(" ") == true)
                                {
                                    isVal = true;
                                }
                            }
                        }
                    }
                }




            }
            catch (Exception)
            {
               
                return isVal;
            }


            return isVal;
        }
        public string PaymentVal(string Usrnm, string Passwd, double amt)
        {


            try
            {


                string usrnm = Usrnm.Trim();
                string passwd = Passwd.Trim();


                if (usrnm == "") // returns if username is blank
                    return "Please enter your username";
                if (passwd == "" || passwd.Length <= 3) // checks the min password length
                    return "Please enter a valid password";
                Random rnd = new Random();
                double bal = rnd.Next(1, 10000); // generates a random balance amount

                if (amt > bal)
                    return "Balance is not enough..";
                else
                    return "Payment Successful...";

            }
            catch (Exception)
            {
                return "Please enter a valid data";
            }

        }

    }
}
