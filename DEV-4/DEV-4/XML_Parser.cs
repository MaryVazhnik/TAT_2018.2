using System;
using System.Text;

namespace DEV_4
{
    class XML_Parser
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">xml file</param>
        static void Main(string[] args)
        {
            try
            {
                if(args == null)
                {
                    throw new Exception("Missing file");
                }
                string text = String.Empty, name = String.Empty;
                name = args[0];
                WorkWithXMLFile file = new WorkWithXMLFile();
                text = file.Enter(name);
                file.Parse(text);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}