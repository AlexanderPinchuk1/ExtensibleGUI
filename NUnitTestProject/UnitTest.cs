using ExtensibleGUI;
using NUnit.Framework;
using System.Windows.Forms;
using Moq;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            FMain form = new FMain();

            form.LoadExtensions();
        }
    }
}