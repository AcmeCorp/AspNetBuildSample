namespace AcmeCorp.AspNetBuildSample.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WidgetTests
    {
        [TestMethod]
        public void UnitTest_That_Action_Does_Not_Throw()
        {
            Widget.Action();
        }
    }
}
