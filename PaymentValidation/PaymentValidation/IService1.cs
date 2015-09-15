using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PaymentValidation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        
        [OperationContract]
        [WebGet(UriTemplate = "CreditCardVal?name={name}&cardno={cardno}&cvv={cvv}&expiry_date={expiry_date}")]
        Boolean CreditCardVal(string cardno, string name, string cvv, string expiry_date);
        [WebGet(UriTemplate = "PaymentVal?usrnm={usrnm}&passwd={passwd}&amt={amt}")]
        string PaymentVal(string usrnm, string passwd, double amt);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
}
