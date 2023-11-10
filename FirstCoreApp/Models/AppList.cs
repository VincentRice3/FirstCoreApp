using System;
using System.Collections.Generic;
namespace FirstCoreApp.Models

{
    public static class AppList
    {
        public static List<App> ToList()
        {
            return new List<App>
            {
                new App("rice", "Rice Calculator", "#B23A48"),
                new App("weight", "Weight Calculator", "#62466B"),
                new App("colour", "Colour Picker", "#011936"),
                new App("youtube", "YouTube", "#667761"),
                new App("diaryView", "Diary", "#F374AE"),
                new App("netflix", "Netflix", "#F09D51")
            };
        }
    }
}
