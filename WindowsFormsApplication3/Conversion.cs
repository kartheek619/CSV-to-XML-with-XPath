using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.IO;

namespace Week2Question
{
    class Conversion
    {

        public string convertToXml()
        {
            try
            {
                var lines = File.ReadAllLines("employees.csv");
                string[] headers = lines[0].Split(',').Select(x => x.Trim('\"')).ToArray();

                var xml = new XElement("employees",
                   lines.Where((line, index) => index > 0).Select(line => new XElement("employee",
                      line.Split(',').Select((column, index) => new XElement(headers[index], column)))));

                xml.Save("employeesxml.xml");
                return "Success";
            }
            catch (FileNotFoundException)
            {
                return "CSV File not found. Please check the file.";
            }
            catch (UnauthorizedAccessException)
            {
                return "Unable to save XML file. Administrator permissions Needed.";
            }
            catch (DirectoryNotFoundException)
            {
                return "Not able to find the directory to save the XML file";
            }
            catch
            {
                return "An Error has Occurred! Please contact administrator";
            }
            
        }

    }
}
