using System;
using System.Timers;

namespace UserTimer
{
    public class TimerSet
    {
        public TimeSpan ParsedTime { get; set; }
        public Timer UserTimer { get; set; }
        public Double TimerInput { get; set; }

        public void SetTimer(string inputTime)
        {
            ParsedTime = TimeSpan.Parse(inputTime);

            TimeSpan duration = ParsedTime.Duration();

            Console.WriteLine($"\nYour timer is set for {duration}");
        }

        public void StartTimer(string start)
        { 

            TimerInput = ParsedTime.TotalMilliseconds;

            UserTimer = new Timer(TimerInput);

            UserTimer.Start();

            UserTimer.Elapsed += UserTimer_Elapsed;
         
         }

        private void UserTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            UserTimer.Stop();
            Console.WriteLine("\nDing! Your timer has ended.");
        }
    }
}