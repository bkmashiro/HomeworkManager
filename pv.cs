using System;
using System.Collections.Generic;

namespace HomeworkManager
{
    public class pv
    {
        public struct Task
        {
            public string name;
            public string Content;
            public DateTime StartTime;
            public DateTime EndTime;
            public bool Finished;
            public string Appendix;
        };

        public static List<List<string>> candiate = new List<List<string>>();
        public static List<string> candiate_lesson = new List<string>();
    }
}
