using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgram
{
    public class DemoJson
    {
        public void Read()
        {
            StreamReader rice = new StreamReader(@"E:\BridgeLabzProject\OPPs\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\RiceJson.json");
            StreamReader wheat = new StreamReader(@"E:\BridgeLabzProject\OPPs\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\wheatJson.json");
            StreamReader pulse = new StreamReader(@"E:\BridgeLabzProject\OPPs\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\PulseJson.json");

            string jsonString1 = rice.ReadToEnd();
            string jsonString2 = wheat.ReadToEnd();
            string jsonString3 = pulse.ReadToEnd();

            Rice rice1 = JsonConvert.DeserializeObject<Rice>(jsonString1);
            Wheat wheat1 = JsonConvert.DeserializeObject<Wheat>(jsonString2);
            Pulse pulse1 = JsonConvert.DeserializeObject<Pulse>(jsonString3);
            Console.WriteLine("Rice perkg " + rice1.Perkg + " and weight " + rice1.Weight + ", Total value for rice inventory :"+ (rice1.Perkg * rice1.Weight));
            Console.WriteLine("Wheat perkg " + wheat1.Perkg + " and weight " + wheat1.Weight + ", Total value for wheat inventory:" +(wheat1.Perkg * wheat1.Weight));
            Console.WriteLine("Pulse perkg " + pulse1.Perkg + " and weight " + pulse1.Weight + ", Total value for pulse inventory:" + (pulse1.Perkg * wheat1.Weight));

        }
    }
}
