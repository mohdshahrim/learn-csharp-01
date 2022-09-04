using System;
using Newtonsoft.Json;


public class Account
{
    public string Name { get; set; }
    public string Email { get; set; }
}


namespace learn_csharp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Name = "Tokiwa Midori",
                Email = "tokiwa.midori@gmail.com"
            };
            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
        }
    }


}

