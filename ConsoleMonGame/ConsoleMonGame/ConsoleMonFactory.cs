using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {


        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines(datafile);
            foreach (string line in lines)
            {
                string[] typeSplit = line.Split('|');
                string[] consoleMonData = typeSplit[0].Split(",");
                Console.WriteLine(line);
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                dataMon.energy = Convert.ToInt32(consoleMonData[4]);
                dataMon.health = Convert.ToInt32(consoleMonData[2]);

            }
        }

        internal List<ConsoleMon> LoadJson(string datafile)
        {
          string json = File.ReadAllText(datafile);
            Console.WriteLine(json);
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
            return templates;
        }

        internal Skill CopySkill(Skill copyFrom)
        {
           Skill copyResult = new Skill(copyFrom.damage, copyFrom.energyCost, copyFrom.name, copyFrom.element); 


            return copyResult;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {

            ConsoleMon copyResult = new ConsoleMon(copyFrom.health,copyFrom.energy,copyFrom.name,copyFrom.weakness);
            copyResult.skills = new List<Skill>();
            foreach (var item in copyFrom.skills)
            {
                copyResult.skills.Add(CopySkill(item));

            }
           
            return copyResult;
        }



    }
}
