using System;
static class LogLine
{
    public static string Message(string logLine)
    {
        int startpoint = logLine.IndexOf(": ");
        string message = logLine.Substring(startpoint+1);
        return message.Trim();
    }
    public static string LogLevel(string logLine)
    {
        int startpoint = logLine.IndexOf("[");//0
        int endpoint = logLine.LastIndexOf("]");//7
        int length = (endpoint) - (startpoint +1);//7 - 1
        string level = logLine.Substring((startpoint+1), length);//1,5
        return level.ToLower();
    }
    public static string Reformat(string logLine)
    {
        return $"{LogLine.Message(logLine)} ({LogLine.LogLevel(logLine)})";
    }
}

LogLine.Message("[ERROR]: Stack overflow")); // "Stack overflow"
LogLine.Message("[WARNING]: Disk almost full")); // "Disk almost full"
LogLine.Message("[WARNING]:   \tTimezone not set  \r\n")); // "Timezone not set"

LogLine.LogLevel("[ERROR]: Disk full")); // "error"
LogLine.LogLevel("[WARNING]: Unsafe password")); // "warning"

LogLine.Reformat("[ERROR]: Segmentation fault")); //"Segmentation fault (error)"
LogLine.Reformat("[INFO]: Disk defragmented")); //"Disk defragmented (info)"