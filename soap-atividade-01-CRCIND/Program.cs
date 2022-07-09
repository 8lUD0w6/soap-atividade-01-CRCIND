
using SOAPDemo;

namespace SOAPDemo
{

    class program
    {

        static async Task Main(string[] args)
        {

            using (var client = new SOAPDemoSoapClient())
            {

                var mission = await client.MissionAsync();
                Console.WriteLine(String.Format($"Mensagem Missão:"));
                Console.WriteLine();
                Console.WriteLine(mission);
                Console.WriteLine();

                var person = await client.FindPersonAsync("50");
                Console.WriteLine(String.Format($"Nome Completo Pessoa:"));
                Console.WriteLine(person.Name);
                Console.WriteLine();

                var zip = await client.LookupCityAsync("93101");
                Console.WriteLine(String.Format($"Caixa Postal:"));
                Console.WriteLine(zip.Zip);
                Console.WriteLine();
                Console.WriteLine(String.Format($"Estado:"));
                Console.WriteLine(zip.State);
                Console.WriteLine();
                Console.WriteLine(String.Format($"Cidade:"));
                Console.WriteLine(zip.City);
               

            }


        }


    }


}