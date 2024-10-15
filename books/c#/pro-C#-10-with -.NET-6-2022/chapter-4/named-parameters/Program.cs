Console.WriteLine("***** Fun with Methods *****");
DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
  textColor: ConsoleColor.DarkRed,
  backgroundColor: ConsoleColor.White);
DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
  message: "Testing...",
  textColor: ConsoleColor.DarkBlue);

static void DisplayFancyMessage(ConsoleColor textColor,
  ConsoleColor backgroundColor, string message)
{
    // Store old colors to restore after message is printed. 
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Set new colors and print message. 
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
  // Restore previous colors. 
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}
