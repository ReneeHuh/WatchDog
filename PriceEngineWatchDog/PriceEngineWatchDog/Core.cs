using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace PriceEngineWatchDog
{
    class Core
    {
        private static string ProcessName = "PriceEngine";
  
        public static bool IsRunning
        { 
            get
            {
                bool r = false;
                foreach (Process myProcess in Process.GetProcesses())
                {
                    if (myProcess.ProcessName.ToLower() == ProcessName.ToLower())
                    {
                     r = true;
                    }
                }
                return r;
            }
        }

        public static bool IsResponding
        { 
            get
            {
                bool r = false;
                foreach (Process myProcess in Process.GetProcesses())
                {
                    if (myProcess.ProcessName.ToLower() == ProcessName.ToLower())
                    {
                        r = myProcess.Responding;
                    }
                }
                return r;
            }
        }
        public static bool HasMultipleProcesses
        {
            get 
            {
                bool r = false;
                int count = 0;
                foreach (Process myProcess in Process.GetProcesses())
                {
                    if (myProcess.ProcessName.ToLower() == ProcessName.ToLower())
                    {
                        count++;
                    }
                }
                if (count > 1) { r = true; }
                else { r = false; }
                return r;
            }
        }

        public static void Start()
        {
            try
            {
                if (IsRunning == false)
                {
                    Process.Start(ProcessName);
                    Log(DateTime.Now.ToString() + " - Process started");
                }
            }
            catch
            { 
                
            }
        }

        public static void Stop()
        {
            foreach (Process myProcess in Process.GetProcesses())
            {
                if (myProcess.ProcessName == ProcessName)
                {
                    try
                    {
                        myProcess.Kill();
                        Log(DateTime.Now.ToString() + " - Process Stoped");
                    }
                    catch
                    { 
                    
                    }
                }
            
            }
        }

        public static void Restart()
        { 
            Stop();
            Thread.Sleep(1000);
            Start();
        }
        public static void Log(string input)
        {
            string FileName = "WatchDog.txt";
            if (File.Exists(FileName) == false) { File.CreateText(FileName); }
            try
            {
                string read = File.ReadAllText(FileName);
                read = read + Environment.NewLine + input;
                File.WriteAllText(FileName, read);
            }
            catch
            {
                Thread.Sleep(250);
                try
                {
                    string read = File.ReadAllText(FileName);
                    read = read + Environment.NewLine + input;
                    File.WriteAllText(FileName, read);
                }
                catch
                { 
                
                }

            }
        }
    }
}
