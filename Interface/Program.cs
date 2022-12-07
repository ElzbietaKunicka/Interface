namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();
            var dog = new Dog();

            var runner = new Runner
            {
                CanRun = dog
            };
            runner.MakeRunnerRun();
            human.Run();
        }
    }
}