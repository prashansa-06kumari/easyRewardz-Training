using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;

class Problem12_JsonToXml
{
    public static void Run()
    {
        string json = File.ReadAllText("users.json");

        XmlDocument xmlDocument =
            JsonConvert.DeserializeXmlNode(
                "{ \"users\": " + json + " }",
                "root"
            );

        xmlDocument.Save("users.xml");

        Console.WriteLine(
            "JSON converted to XML successfully."
        );
    }
}