using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CumpusFranceProject
{
    internal class WriteXMLResult
    {   
        public WriteXMLResult(string methodName, bool result) {

       

            // Utiliser TestContext pour obtenir le répertoire de travail
            string resultsDirectory = TestContext.CurrentContext.WorkDirectory;
            string resultFilePath = Path.Combine(resultsDirectory, "TestResults.xml");

            // Créer un document XML pour stocker les résultats
            var doc = new XDocument(
                new XElement
                
                ("TestResults",
                    new XElement("Test",
                        new XAttribute("Name", methodName),
                        new XElement("Result", result ? "Passed" : "Failed"),
                        new XElement("ExecutionTime", DateTime.Now.ToString("o"))
                    )
                )
            );

            // Assurez-vous que le répertoire existe
            Directory.CreateDirectory(resultsDirectory);

            // Sauvegarder le document XML
            doc.Save(resultFilePath);

        }

    }
}
