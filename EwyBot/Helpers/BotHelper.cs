namespace EwyBot.Helpers;

public class BotHelper
{
    
    public static int GetYearsSince(DateTime date)
    {
        var years = DateTime.Now.Year - date.Year;

        if (DateTime.Now.Month < date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day))
        {
            years--;
        }
        
        return years;
    }
    
    
}