using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace Week2Question
{
    class Validation
    {
        public string checkValidation()
        {
            try
            {
                XmlSchemaSet schemas = new XmlSchemaSet();
                schemas.Add("", "employees_schema.xsd");
                XDocument doc = XDocument.Load("employeesxml.xml");
                string msg = "";
                doc.Validate(schemas, (o, e) =>
                {
                    msg += e.Message + Environment.NewLine;
                });

                if (msg == "")
                {
                    return "Document is Valid";
                }
                else
                {
                    return "Document is Invalid! " + msg;
                }
            }
            catch (FileNotFoundException)
            {
                return "XML file not found";
            }
            catch (XmlException)
            {
                return "XML file is illegally modified! Cannot Validate";
            }
            catch
            {
                return "An Error has Occurred! Please contact administrator";
            }
        }


    }
}
