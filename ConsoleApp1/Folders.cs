using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsoleApp1
{
    class Folders
    {
        // https://www.testdome.com/tests/c-sharp-online-test/18


        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            var lst = new List<string>();
            var lst1 = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            lst1.Add(doc.DocumentElement.Attributes["name"].Value);
            lst1.AddRange(Folders.GetChildren(doc.DocumentElement));
            foreach (var folder in lst1)
            {
                if (folder.StartsWith(startingLetter.ToString()))
                {
                    lst.Add(folder);
                }
            }
            return lst;
        }
        public static IEnumerable<string> GetChildren(XmlElement elm) {
            var lst = new List<string>();
            foreach (XmlElement chld in elm.ChildNodes)
            {
                lst.Add(chld.Attributes["name"].Value);
                if (chld.HasChildNodes)
                {
                    lst.AddRange(GetChildren(chld));
                }
            }
            return lst;
        }

        public static void Main03(string[] args)
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            foreach (string name in Folders.FolderNames(xml, 'c'))
                Console.WriteLine(name);
        }

    }



}
