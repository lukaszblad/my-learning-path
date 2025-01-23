using StaticDataAndMembers;

namespace StaticDataAndMembers;
// Static classes can only
// contain static members! 
static class TimeUtilClass
{
  public static void PrintTime()
    => Console.WriteLine(DateTime.Now.ToShortTimeString());
public static void PrintDate()
  => Console.WriteLine(DateTime.Today.ToShortDateString());
}