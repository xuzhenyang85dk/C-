namespace Samlinger
{
    internal class Test
    {
        static void Main1(string[] args)
        {
            
            System.Collections.ArrayList a = 
                new System.Collections.ArrayList();  
            
            a.Add(1);
            a.Add(2);
            a.Add(100);
            a.Add(10000);
            a.Add("sdfasd");
            a.Add(true);
            a.Insert(1, 2000);
            
            // Dynamic array by using generic types
            List<string> b = new List<string>();

            b.Add("Xu");
            b.Add("Caroline");
            b.Add("Fu");
            b.Add("Mikkel");

            b.RemoveAt(3);

            for (int i = 0; i < b.Count; i++)
            {
                Console.WriteLine(b[i]);
            }


            // 
            Queue<int> c = new Queue<int>();

            c.Enqueue(100);
            c.Enqueue(200);


            //Dictionary
            Dictionary<string, int> d = new Dictionary<string, int>();

            d.Add("asdfsafd", 234324);
            d.Add("wrfsfsdf", 345345);
            d.Add("sdfdasfs", 345345);

            foreach (var item in d)
            {
                Console.WriteLine($"{item}, {item.Key}, {item.Value}");
            }
        }
    }
}