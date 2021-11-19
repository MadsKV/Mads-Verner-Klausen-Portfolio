using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;
namespace XML_TechCollage_V._2
{
    class Program
    {
        private const string sourceFile = @"..\..\..\Files\books.xml";
        private const string stylesheet = @"..\..\..\Files\belowAvg.xslt";
        private const string outputFile = @"..\..\..\Files\result.xml";
        static void Main(string[] args)
        {
            // Enable XSLT debugging. 
            XslCompiledTransform xslt = new XslCompiledTransform(true);
            // Compile the style sheet.
            xslt.Load(stylesheet);
            // Execute the XSLT transform.
            FileStream outputStream = new FileStream(outputFile, FileMode.Create); // Bemærk at Create overskriver!
            xslt.Transform(sourceFile, null, outputStream);

            XPathValidation();
        }

        
            public static void XPathValidation()
            {
                try
                {
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.Schemas.Add("", @"C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML TechCollage V.2\XML TechCollage V.2\Files\TechCollage.xsd");
                    settings.ValidationType = ValidationType.Schema;

                    XmlReader reader = XmlReader.Create(@"C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML TechCollage V.2\XML TechCollage V.2\Files\TechCollage.xml", settings);
                    XmlDocument document = new XmlDocument();
                    document.Load(reader);

                    ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);

                    // the following call to Validate succeeds.
                    document.Validate(eventHandler);

                // add a node so that the document is no longer valid
                // XPathNavigator navigator = document.CreateNavigator();
                // navigator.MoveToFollowing("price", "http://www.contoso.com/books");
                // XmlWriter writer = navigator.InsertAfter();
                // writer.WriteStartElement("anotherNode", "http://www.contoso.com/books");
                //writer.WriteEndElement();
                // writer.Close();

                    Console.WriteLine("It is Valid"); 
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
            }

            static void ValidationEventHandler(object sender, ValidationEventArgs e)
            {
                switch (e.Severity)
                {
                    case XmlSeverityType.Error:
                        Console.WriteLine("Error: {0}", e.Message);
                        break;
                    case XmlSeverityType.Warning:
                        Console.WriteLine("Warning {0}", e.Message);
                        break;
                }
            }
    }
}