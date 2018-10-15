using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.ReadJson;

namespace Castinet_AutomatesSmoke.TestCases.Utilities
{
    public class TestEnvironment
    {
        public static JsonData LoadJson()
        {
            JsonData items = null;
            using (StreamReader r = new StreamReader("E:\\VSTS\\CASTiNET-TestAutomation\\Castinet-AutomatesSmoke.TestCases\\TestData\\properties.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<JsonData>(json);
            }
            return items;
        }
    }
}
