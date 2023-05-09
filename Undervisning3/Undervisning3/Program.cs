namespace Undervisning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linn = new Person("Linn",25); // pause til 10: 57
            var marie = new Person("Marie", 0);
            var kjartan = new Person("kjartan", 356);
            var terje = new Person("Terje", 67, "no hair");
            
            var list = new List<Person>() { linn, marie };
         
            list.Add(kjartan);
            
            foreach(var person in list)
            {
                person.IntroduceSelf();
            }

            var linnObj = list.First(x => x.Name == "Linn");
            linnObj.Run();
            linnObj.Run("fast");
        }
    }
}