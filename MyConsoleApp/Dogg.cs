namespace MyConsoleApp
{
    public class Dogg
    {
        //public int age = 2;

        //public int GetAge()
        //{
        //    return this.age;
        //}

        //public int Get()
        //{
        //    return age;
        //}

        //public string PrintAge()
        //{
        //    var result = this.GetAge();
        //    return $"My age is: {result}";
        //}


        private string name = "Doggy";

        public string Name 
        { 
            get { return this.name; }
        }

        private void Bark()
        {
            Console.WriteLine("Woo-woo");
        }

        public void DoSomething()
        {
            this.Bark();
        }
    }
}
