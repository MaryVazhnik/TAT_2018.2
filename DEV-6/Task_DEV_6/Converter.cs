using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task_DEV_6
{
    /// <summary>
    /// A method that converts a JSON file to XML and vice versa
    /// </summary>
    public class Converter
    {
        public string ParseToXml(string sourceJsonString)
        {
            FileStream s = File.Open(sourceJsonString, FileMode.Open);
            StreamReader streamReader = new StreamReader(s);
            string jsonString = streamReader.ReadToEnd();
            int tempIndexDeclimer;
            int tempIndex;
            if (jsonString.StartsWith("{") && jsonString.EndsWith("}"))
            {
                jsonString = Regex.Replace(jsonString, "(\"(?:[^\"\\\\]|\\\\.)*\")|\\s+", "$1");
                tempIndex = jsonString.IndexOf("{");
                tempIndexDeclimer = jsonString.IndexOf("[");
                if (tempIndex < tempIndexDeclimer)
                {

                    jsonString = jsonString.Replace("{\"", "<");
                    tempIndex = jsonString.IndexOf("\"");
                    string tempString = jsonString.Substring(1, tempIndex - 2);
                    jsonString = jsonString.Replace("\":[", ">");

                    tempIndex = jsonString.IndexOf(">");
                    jsonString = jsonString.Insert(tempIndex + 1, "<" + tempString + ">");

                    jsonString = jsonString.Replace("\",\"", "<");

                    while (jsonString.Contains("\":\""))
                    {
                        char[] jsonCharArray = jsonString.ToCharArray();
                        int i = jsonString.IndexOf("\"");
                        int count = 0;

                        while (jsonCharArray[i - count - 1] != '<')
                        {
                            count++;
                        }

                        int count2 = 0;
                        string tempStringIncide = jsonString.Substring(i - count, count);

                        while (jsonCharArray[count].ToString() != "\"")
                        {
                            count++;
                        }

                        jsonString = jsonString.Replace("\":\"", ">").Replace("\":", ">").Replace(",\"", "<");
                        jsonString = jsonString.Replace("\"},", "</" + tempString + "><" + tempString + ">");
                        jsonString = jsonString.Replace("\"}]}", "</" + tempString + "s>");
                    }
                }
            }
            return jsonString;
        }
        public string ParseToJson(string sourceXmlString)
        {
            FileStream s = File.Open(sourceXmlString, FileMode.Open);
            StreamReader streamReader = new StreamReader(s);
            string xmlString = streamReader.ReadToEnd();

            if (xmlString.StartsWith("<") && xmlString.EndsWith(">"))
            {
                xmlString = Regex.Replace(xmlString, "(@">\s*<")", "$1");
                Console.WriteLine(xmlString);
                tempIndex = xmlString.IndexOf("<");
                tempIndexDeclimer = xmlString.IndexOf("><");

                if (tempIndex < tempIndexDeclimer)
                {
                    xmlString = xmlString.Replace("<", "{\"");
                    tempIndex = xmlString.IndexOf(">");
                    string tempString = xmlString.Substring(1, tempIndex - 2);
                    xmlString = xmlString.Replace(">", "\":[");

                    tempIndex = xmlString.IndexOf(">");
                    xmlString = xmlString.Insert(tempIndex + 1, "{\"" + tempString + "\":[");

                    xmlString = xmlString.Replace("<", "\",\"").Replace(">", "\":").Replace(">", "\",");
                   
                    while (xmlString.Contains("<"))
                    {
                        char[] xmlCharArray = xmlString.ToCharArray();
                        int i = xmlString.IndexOf("<");
                        int count = 0;
                        
                        while (xmlCharArray[i - count - 1] != '\"')
                        {
                            count++;
                        }

                        int count2 = 0;
                        string tempStringIncide = xmlString.Substring(i - count, count);
                        
                        while (xmlCharArray[count].ToString() != "<")
                        {
                            count++;
                        }

                    xmlString = xmlString.Replace("</" + tempStringIncide + ">", "\"}]}");
                }
            }
         return xmlString;
    }
}