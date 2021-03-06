namespace Gu.Wpf.Geometry.UiTests
{
    using Gu.Wpf.UiAutomation;
    using NUnit.Framework;

    public sealed class GradientPathWindowTests
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ImageAssert.OnFail = OnFail.SaveImageToTemp;
        }

        [Test]
        public void Renders()
        {
            if (Env.IsAppVeyor)
            {
                return;
            }

            using (var app = Application.Launch("Gu.Wpf.Geometry.Demo.exe", "GradientPathWindow"))
            {
                var window = app.MainWindow;
                ImageAssert.AreEqual(".\\Images\\GradientPath.png", window.FindGroupBox("Path"));
            }
        }

        [Test]
        public void RendersWhenArcSegmentIssue28()
        {
            if (Env.IsAppVeyor)
            {
                return;
            }

            using (var app = Application.Launch("Gu.Wpf.Geometry.Demo.exe", "Issue28Window"))
            {
                var window = app.MainWindow;
                ImageAssert.AreEqual($".\\Images\\GradientPathWithArcSegment.png", window.FindGroupBox("Path"));
            }
        }
    }
}
