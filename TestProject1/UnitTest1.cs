using System;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.TestHost;



public class ProgramTests
{
    [Fact]
    public void TestStartApplication()
    {
        using (var consoleOutput = new StringWriter())
        {
            Console.SetOut(consoleOutput);

            TicketsService.StartApplication();
            string consoleResult = consoleOutput.ToString().Trim();

            Assert.Contains("Hello, World!", consoleResult);
        }
    }
    [Fact]
    public void TestCalculateTotalPrice()
    {
        int quantity = 3;
        decimal expectedTotal = 15m;
        TicketsService order = new TicketsService(quantity);

        decimal actualTotal = order.CalculateTotalPrice();

        Assert.Equal(expectedTotal, actualTotal);
    }

    [Fact]
    public void Constructor_WithNegativeQuantity_ThrowsArgumentException()
    {
        int negativeQuantity = -1;

        Assert.Throws<ArgumentException>(() => new TicketsService(negativeQuantity));
    }
}