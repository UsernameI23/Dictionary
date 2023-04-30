namespace WorkingWithDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Member = new Dictionary<string, string>();
            

            //Adding Employees
            Member.Add("Kate", "Bard");
            Member.Add("Ashley", "Magician");
            Member.Add("Fiona", "Warrior");
            Member.Add("Abby", "Hunter");
            Member.Add("Tyler", "Thief");

            Console.WriteLine("MemberList Keys");
            Dictionary<string, string>.KeyCollection keys = Member.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("MemberList Values");
            Dictionary<string, string>.ValueCollection values = Member.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();

            Console.WriteLine("MemberList Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in Member)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            // Changing values
            //Member["Jo"] = "Wizard";
            //Member["Jenny"] = "Knight";
            Member.Remove("Tyler");
            

            Console.WriteLine("Revised MemberList Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in Member)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            //Console.WriteLine($"You have {Member} members");
            

            Console.WriteLine($"There are {Member.Count()} members");







        }

    }
}
