using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;

namespace NearestHotelInformation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string nearbyhotels(string radius) 
        {

            string latitute = "40.7127";
            string longitude = "-74.0059";
            string API_Key = "AIzaSyC9NF79kzyynKD1Z7xfyfWZLq4DWNnD8Ws";
            


            String url = "https://maps.googleapis.com/maps/api/place/search/xml?types=lodging&location=" + latitute + "," + longitude + "%20&radius=" +radius+ "%20&key=" + API_Key;
            WebRequest urlrequest = WebRequest.Create(@url);
            urlrequest.Method = "GET";
            string returndata = "";
            double price;
            string hotelroomprice; 



            HttpWebResponse response = urlrequest.GetResponse() as HttpWebResponse;


            try
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        XmlDocument xmlDoc= new XmlDocument();
                        xmlDoc.Load(responseStream);

                        XmlNodeList xmlnodes = xmlDoc.GetElementsByTagName("result");

                        foreach (XmlNode node in xmlnodes)
                        {
                  
                            price = Convert.ToDouble(node["rating"].InnerText);
                            price = price * 13.2;
                            hotelroomprice = Convert.ToString(price);
                            returndata += "Hotel id=" + node["id"].InnerText.Substring(0, 5) + "...." + node["name"].InnerText + ".. with a rating of " + node["rating"].InnerText +
                            "......Cost per room=$" +hotelroomprice + "per day </br>";


                        }

                    }
                }
                else
                {

                    throw new Exception("No response from the site");

                }
            }
            catch (Exception)
            {

            }

            return returndata;
        }
    }
}
