using System;
using System.Timers;

namespace Question_2
{
    public class PrintJob
    {
        public string JobName { get; set; }
        public int PageCount { get; set; }
        public bool IsDoubleSided { get; set; }
        public DateTime StartTime { get; set; }
        public bool IsCompleted { get; private set; }


        public PrintJob(string jobName, int pageCount, bool isDoubleSided)
        {
            JobName = jobName;
            PageCount = pageCount;
            IsDoubleSided = isDoubleSided;
            StartTime = DateTime.Now;
            IsCompleted = false;
        }

        public double GetPrintTime()
        {
            double timePerPage = IsDoubleSided ? 1.0 : 0.5;
            return PageCount * timePerPage;
        }
        
        public override string ToString()
        {
            string mode = IsDoubleSided ? "Double-sided" : "Single-sided";
            string status = IsCompleted ? "Completed" : "Pending";
            return $"{JobName} - {PageCount} pages, {mode}, Status: {status}";
        }
        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public TimeSpan TimeLeft()
        {
            double timeSpent = (DateTime.Now - StartTime).TotalSeconds;
            double totalTime = GetPrintTime();

            if (timeSpent >= totalTime)
            {
                MarkAsCompleted();
                return TimeSpan.Zero; 
            }
            return TimeSpan.FromSeconds(totalTime - timeSpent);
        }

    }
}
