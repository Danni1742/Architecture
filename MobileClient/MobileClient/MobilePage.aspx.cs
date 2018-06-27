using System;
using System.IO;
using System.Net;
using System.Xml;

namespace MobileClient
{
    public partial class MobilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Web Reference
        protected void convert_button_Click(object sender, EventArgs e)
        {
            localhost.Convert wsConvert = new localhost.Convert();

            string inches = inches_tb.Text;

            centimeters_label.Text = wsConvert.InchesToСentimeters(inches);
        }

        protected void clear_btn_Click(object sender, EventArgs e)
        {
            inches_tb.Text = string.Empty;
            centimeters_label.Text = string.Empty;
        }

        //SOAP Request
        public void Execute()
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new XmlDocument();
            soapEnvelopeXml.LoadXml(string.Format(@"<?xml version=""1.0"" encoding=""utf-8""?>
<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
<soap:Body>
<InchesToСentimeters xmlns=""http://tempuri.org/"">
  <inches>{0}</inches>
</InchesToСentimeters>
</soap:Body>
</soap:Envelope>", inches_tb_1.Text));

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    string soapResult = rd.ReadToEnd();
                    centimeters_label_1.Text = soapResult;
                }
            }
        }

        public HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://192.168.56.1:45455/Convert.asmx");
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        protected void convert_button_1_Click(object sender, EventArgs e)
        {
            CreateWebRequest();
            Execute();
        }

        protected void clear_btn_1_Click(object sender, EventArgs e)
        {
            inches_tb_1.Text = string.Empty;
            centimeters_label_1.Text = string.Empty;
        }
    }
}
