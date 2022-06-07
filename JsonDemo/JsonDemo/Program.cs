namespace JsonDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Read read = new Read();
            TypesOfInventary data = read.ReadTheData("C:/Users/DELL/source/repos/JsonDemo/JsonDemo/Inventory.json");

            //Console.WriteLine(data.name);
            //Console.WriteLine(data.weight);
            Console.WriteLine("Types of pulses");

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
            }

            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);
            }

            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine(data.typesOfWheat[i].price);
            }
        }
    }
}