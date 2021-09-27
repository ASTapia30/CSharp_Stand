/*
Instructions
In this exercise you'll be processing log-lines.

Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".

There are three different log levels:

INFO
WARNING
ERROR
You have three tasks, each of which will take a log line and ask you to do something with it.

1. Get message from a log line
Implement the (static) LogLine.Message() method to return a log line's message:

LogLine.Message("[ERROR]: Invalid operation")
// => "Invalid operation"
Any leading or trailing white space should be removed:

LogLine.Message("[WARNING]:  Disk almost full\r\n")
// => "Disk almost full"
2. Get log level from a log line
Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:

LogLine.LogLevel("[ERROR]: Invalid operation")
// => "error"
3. Reformat a log line
Implement the (static) LogLine.Reformat() method that reformats the log line, putting the message first and the log level after it in parentheses:

LogLine.Reformat("[INFO]: Operation completed")
// => "Operation completed (info)"

*/

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