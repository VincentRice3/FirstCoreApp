namespace FirstCoreApp.Models
{
    public class PageGreeting
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public string? Date { get; set; }
        public string Time { get; set; }

        public PageGreeting()
        {
            Name = "Vincent Rice";
            Greeting = GetGreeting();
            Time = GetTime();
        }

        public string GreetUser()
        {
            return $"{Greeting} {Name}, It is {Time}";
        }


        public string GetGreeting()
        {
            TimeSpan h = DateTime.Now.TimeOfDay;
            if (h.Hours >= 0 && h.Hours <= 11)
            {
                return "Good Morning";
            }
            else if (h.Hours >= 11 && h.Hours <= 16)
            {
                return "Good Afternoon";
            }
            else if (h.Hours >= 16 && h.Hours <= 23)
            {
                return "Good Evening";
            }
            else
            {
                return "invalid greeting";
            }
        }

        public string GetTime()
        {
            TimeSpan t = DateTime.Now.TimeOfDay;

            Time = $"{t.Hours}:{t.Minutes:00}";

            return Time;
        }
    }
}
