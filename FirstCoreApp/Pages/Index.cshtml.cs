using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }

        public string Greeting { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }


        public void OnGet()
        {
            Name = "Vincent Rice";
            Greeting = GetGreeting();
            Time = GetTime();

        }


        public string GetGreeting() {
            TimeSpan h = DateTime.Now.TimeOfDay;
            if (h.Hours >= 0 && h.Hours <=11) {
                return "Good Morning";
            }else if(h.Hours >= 11 && h.Hours <= 16) 
            {
                return "Good Afternoon";
            } else if(h.Hours >= 16 && h.Hours <= 23)
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

        public string GetColour()
        {
            char[] values = { 'A', 'B', 'C', 'D', 'E', 'F', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            string hexValue = "#";


            for (int i  = 0; i < 6; i++)
            {
                Random randomNumber = new();

                int num = randomNumber.Next(values.Length);

                hexValue += values[num];

            }

            return hexValue;
        }
    }
}