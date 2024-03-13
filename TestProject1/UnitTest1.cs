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

            // Appeler la méthode StartApplication()
            TicketsService.StartApplication();

            // Récupérer la sortie console
            string consoleResult = consoleOutput.ToString().Trim();

            // Vérifier si la sortie console contient la chaîne attendue
            Assert.Contains("Hello, World!", consoleResult);
        }
    }
}