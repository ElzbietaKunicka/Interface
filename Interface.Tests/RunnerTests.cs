namespace Interface.Tests
{
    [TestClass]
    public class RunnerTests
    {
        [TestMethod]
        public void WhenMakeRunnerRunIsCalled_RunnerIsRunning()
        {
            var fakeRunner = new FakeRunner();
            var sut = new Runner
            {
                CanRun = fakeRunner
            };

            sut.MakeRunnerRun();
            Assert.IsTrue(fakeRunner.RunWasCalled);
        }
    }
    public class FakeRunner : ICanRun //sukurem  netikra runner
    {
        public bool RunWasCalled { get; set; }
        public void Run()
        {
            RunWasCalled = true;
        }
    }
}