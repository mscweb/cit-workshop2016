using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Get the current directory.
                string path = Directory.GetCurrentDirectory();

                // Get the files within the Content directory
                string[] files = Directory.GetFiles(path + "\\Content");
                Random rnd = new Random();

                // Select a random file
                int rand = rnd.Next(files.Length);
                var data = ParseFile(files[rand]);
                string madLib = CreateMadLib(data);
                Console.WriteLine(madLib);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        static string CreateMadLib(dynamic data)
        {
            string madLib = "";
            try
            {
                madLib += "Date: " + DateTime.Now.ToString("M/d/yyyy") + "\n" +
                    "Please excuse " + data["name"] + " who is far too " + data["adjective"] + " to attend " + data["noun"] + " class.\n" +
                    "Sincerely,\n" +
                    data["person"];
                return madLib;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        static dynamic ParseFile(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    string json = r.ReadToEnd();
                    dynamic data = JsonConvert.DeserializeObject<dynamic>(json);
                    return data;
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                return new JObject();
            }
        }
    }
}
