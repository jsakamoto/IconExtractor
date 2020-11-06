using System;
using System.IO;
using Xunit;

namespace Toolbelt.Drawing.Test
{
    public class IconExtractorTest
    {
        [Fact]
        public void Extract1stIconTo_Test()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;

            var fixtureAppPath = Path.Combine(baseDir, "IconExtractor.Test.FixtureApp.exe");
            using var outputStream = new MemoryStream();
            IconExtractor.Extract1stIconTo(fixtureAppPath, outputStream);

            var originalIconBytes = File.ReadAllBytes(Path.Combine(baseDir, "app.ico"));
            outputStream.ToArray().Is(originalIconBytes);
        }
    }
}
