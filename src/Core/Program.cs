using System;
using PlariumAssistant.Core;

class Program
{
    static void Main()
    {
        var bmp = CaptureEngine.CaptureRaidWindow();
        bmp.Save("raid_test.png");
        Console.WriteLine("Screenshot saved as raid_test.png");
    }
}
