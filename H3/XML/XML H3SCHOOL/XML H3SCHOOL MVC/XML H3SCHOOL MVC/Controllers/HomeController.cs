using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;
using XML_H3SCHOOL_MVC.Models;

namespace XML_H3SCHOOL_MVC.Controllers
{

    

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult xmlTransformator()
        {
            try
            {
                const string sourceFile = @"C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\main.xml";
                const string stylesheet = @"C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Transformation.xslt";
                const string outputFile = @"C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\SchemaXSD.xsd";


                // Enable XSLT debugging.
                XslCompiledTransform xslt = new XslCompiledTransform(true);
                // Compile the style sheet.
                xslt.Load(stylesheet);
                // Execute the XSLT transform.
                FileStream outputStream = new FileStream(outputFile, FileMode.Create); // Create will overwrite.
                xslt.Transform(sourceFile, null, outputStream);

                outputStream.Close();
                ViewBag.TransformMessage = "The stylesheet worked and has been Transformed to fit it";
                return View("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        

        public IActionResult XPathValidation()
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(
                    "",
                    @"C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\SchemaXSD.xsd");
                settings.ValidationType = ValidationType.Schema;

                XmlReader reader = XmlReader.Create(
                    @"C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\main.xml", settings);
                XmlDocument document = new XmlDocument();
                document.Load(reader);

                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);

                // the following call to Validate succeeds.
                document.Validate(eventHandler);

                ViewBag.ValidMessage = "File Is Vaild";
                ViewBag.ValidateMessage = "Your file has been validated and works";
                return View("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ViewBag.ErrorMessage = "File is not Vaild";
                return View("Index");
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
