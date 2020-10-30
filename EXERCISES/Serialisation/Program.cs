using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using PersonClassLibrary;
using System.IO;
using ClientListClassLibrary;

namespace Serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientList clients = new ClientList();
            clients.Add(new Person("Boudier", "Aurelien", new DateTime(1988, 12, 29), SexType.Male));
            clients.Add(new Person("Devoldere", "Mike", new DateTime(1983, 10, 22), SexType.Male));
            clients.Add(new Person("Thiry", "Sophie", new DateTime(1980, 08, 12), SexType.Female));
     

            //Person aurelien = new Person("Boudier", "Aurelien", new DateTime(1988, 12, 29), SexType.Male);
            string resultSerialisation = JsonSerializer.Serialize(clients);
            File.WriteAllText("sauvegarde.json", resultSerialisation);
            
            //if file exits
            //string deser = File.ReadAllText("sauvegarde.json");
            
            // Console.WriteLine(deser);
            //Person mike = JsonSerializer.Deserialize<Person>(deser);
            //Console.WriteLine(mike.FirstName + mike.DateOfBirth);
            //Console.WriteLine(resultSerialisation);

            Console.ReadLine();
        }
    }
}
