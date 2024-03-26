namespace LoyalitySystem.Common
{
    public class Utils
    {
        public const string findPersonUrl = "https://www.crcind.com/csp/samples/%25SOAP.WebServiceInvoke.cls?CLS=SOAP.Demo&OP=FindPerson";
        public const string findPersonByIdUrl = "https://www.crcind.com/csp/samples/SOAP.Demo.cls?soap_method=FindPerson&id="; // add number of id at the end
        public const string getAllByName = "https://www.crcind.com/csp/samples/SOAP.Demo.cls?soap_method=GetByName&name="; 
    }
}
