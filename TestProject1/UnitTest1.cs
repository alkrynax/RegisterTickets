using System;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.TestHost;



public class ProgramTests
{
    [Fact]
    public void TestStartApplication()
    {
        // Capturer la sortie console
        using (var consoleOutput = new StringWriter())
        {
            Console.SetOut(consoleOutput);

            // Appeler la m�thode StartApplication()
            TicketsService.StartApplication();

            // R�cup�rer la sortie console
            string consoleResult = consoleOutput.ToString().Trim();

            // V�rifier si la sortie console contient la cha�ne attendue
            Assert.Contains("Hello, World!", consoleResult);
        }
    }
}