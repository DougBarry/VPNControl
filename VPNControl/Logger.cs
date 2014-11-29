using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace VPNControl
{
    public enum DebugSeverity
    {
        Status = 100,
        Critical = 50,
        Important = 40,
        Warning = 30,
        Info = 20,
        All = 1
    }

    public static class Logger
    {
        private static List<Delegate> logTargets;

        // FIXME change to appropriate value
        public static int MinLogDisplayLevel = (int)DebugSeverity.All;

        public static void AddLogTarget(Delegate d)
        {
            if (logTargets == null)
            {
                logTargets = new List<Delegate>();
            }
            logTargets.Add(d);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Start()
        {
            OutputMessage("[" + GetTimestamp() + "] Application start");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void End()
        {
            OutputMessage("[" + GetTimestamp() + "] Application end");
        }
        
        /*[MethodImpl(MethodImplOptions.NoInlining)]
        public static void Exit()
        {
            var meth = new StackFrame(1, true).GetMethod();
            string caller = meth.ReflectedType.Name + "." + meth.Name;
            Console.WriteLine("[" + GetTimestamp() + "] {" + caller + "} Exit");
        }*/

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Entry()
        {
            var meth = new StackFrame(1, true).GetMethod();
            string caller = meth.ReflectedType.Name + "." + meth.Name;

            // log to console
            if (((int)DebugSeverity.Info) > MinLogDisplayLevel)
            {
                OutputMessage("[" + GetTimestamp() + "] {" + caller + "}");
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void OutputMessage(string message)
        {
            Console.WriteLine(message);
            if (logTargets != null)
            {
                foreach (Delegate d in logTargets)
                {
                    try
                    {
                        d.DynamicInvoke(message);
                    }
                    catch(Exception e)
                    {
                        continue;
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Log(string message, DebugSeverity severity = DebugSeverity.Info)
        {
            /*
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
             */
            var meth = new StackFrame(1, true).GetMethod();
            string caller = meth.ReflectedType.Name + "." + meth.Name;

            // log to console
            if (((int)severity) >= MinLogDisplayLevel)
            {
                OutputMessage("[" + GetTimestamp() + "] {" + caller + "} " + message);
            }

            // log to other outputs?
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Log(Exception e)
        {
            var meth = new StackFrame(1, true).GetMethod();
            string caller = meth.ReflectedType.Name + "." + meth.Name;
            Log("Exception: {" + caller + "}(" + e.GetType().ToString() + ") " + e.Message, DebugSeverity.Important);
        }

        public static string GetTimestamp()
        {
            return DateTime.UtcNow.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string GetTimestamp(DateTime dts)
        {
            return dts.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
