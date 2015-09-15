using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Xml;

namespace PaymentValidation
{
    public partial class PaymentValidationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*protected void Button1_Click(object sender, EventArgs e)
        {
            String status = "false";

            string CardNumber = TextBox2.Text.Trim();
            string  CVV = TextBox3.Text.Trim();
            string ExpiryDate = TextBox4.Text.Trim();
            string FullName = TextBox1.Text;

              String url = "http://localhost:63681/Service1.svc/CreditCardVal?name=" +FullName+ "&cardno=" +CardNumber+ "&cvv=" + CVV  + "&expiry_date=" + ExpiryDate;
            WebRequest urlrequest = WebRequest.Create(@url);
            urlrequest.Method = "GET";

            HttpWebResponse response = urlrequest.GetResponse() as HttpWebResponse;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    XmlDocument xmlDocObject = new XmlDocument();
                    xmlDocObject.Load(responseStream);
                    status = Convert.ToString(xmlDocObject["boolean"].InnerText);
                }
            }
            else
            {
                Label5.Text = " Unable to connect";
                Label5.Visible = true;
            }


            if (status == "true")
            {
                Label5.Text = "Valid";
                Label5.Visible = true; 
                

            }
            else
            {
                Label5.Text = "Invalid";
                Label5.Visible = true;
            }
        
        }*/

      /*  protected void Button2_Click(object sender, EventArgs e)
        {
            string username = TextBox5.Text;
            string password = TextBox6.Text;
            double amount = Convert.ToDouble(TextBox7.Text);


            String url = "http://localhost:63681/Service1.svc/PaymentVal?usrnm=" +username+ "&passwd=" + password + "&amt=" +amount;
            WebRequest urlrequest = WebRequest.Create(@url);
            urlrequest.Method = "GET";

            HttpWebResponse response = urlrequest.GetResponse() as HttpWebResponse;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    XmlDocument xmlDocObject = new XmlDocument();
                    xmlDocObject.Load(responseStream);
                    Label10.Text = Convert.ToString(xmlDocObject["string"].InnerText);
                    Label10.Visible = true;
                }
            }
            else
            {
                Label10.Text = " Unable to connect";
                Label10.Visible = true;
            }
        }*/

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String status = "false";

            string CardNumber = TextBox2.Text.Trim();
            string CVV = TextBox3.Text.Trim();
            string ExpiryDate = TextBox4.Text.Trim();
            string FullName = TextBox1.Text;

            String url = "http://localhost:63681/Service1.svc/CreditCardVal?name=" + FullName + "&cardno=" + CardNumber + "&cvv=" + CVV + "&expiry_date=" + ExpiryDate;
            WebRequest urlrequest = WebRequest.Create(@url);
            urlrequest.Method = "GET";

            HttpWebResponse response = urlrequest.GetResponse() as HttpWebResponse;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    XmlDocument xmlDocObject = new XmlDocument();
                    xmlDocObject.Load(responseStream);
                    status = Convert.ToString(xmlDocObject["boolean"].InnerText);
                }
            }
            else
            {
                Label5.Text = " Unable to connect";
                Label5.Visible = true;
            }


            if (status == "true")
            {
                Label5.Text = "Valid";
                Label5.Visible = true;


            }
            else
            {
                Label5.Text = "Invalid";
                Label5.Visible = true;
            }
        
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            string username = TextBox5.Text;
            string password = TextBox6.Text;
            double amount = Convert.ToDouble(TextBox7.Text);


            String url = "http://localhost:63681/Service1.svc/PaymentVal?usrnm=" + username + "&passwd=" + password + "&amt=" + amount;
            WebRequest urlrequest = WebRequest.Create(@url);
            urlrequest.Method = "GET";

            HttpWebResponse response = urlrequest.GetResponse() as HttpWebResponse;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    XmlDocument xmlDocObject = new XmlDocument();
                    xmlDocObject.Load(responseStream);
                    Label10.Text = Convert.ToString(xmlDocObject["string"].InnerText);
                    Label10.Visible = true;
                }
            }
            else
            {
                Label10.Text = " Unable to connect";
                Label10.Visible = true;
            }


        }


        }
    }
