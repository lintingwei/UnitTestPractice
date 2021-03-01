using NUnit.Framework;
using UnitTestPractice;

namespace LogAnalyzerTests
{
    public class Tests
    {
        [Test]
        public void IsValidFileName_SupportExtension_ReturnsTrue()
        {
            IExtensionManager fakeExtensionManager = new FakeExtensionManager();

            ExtensionMangerFactory.SetManager(fakeExtensionManager);

            LogAnalyzer logAnalyzer = new LogAnalyzer();

            bool result = logAnalyzer.IsValidLogFileName("test File Name");

            Assert.IsTrue(result);
        }
    }
    internal class FakeExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}