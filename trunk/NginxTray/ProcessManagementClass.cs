using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NginxTray
{
    public class ProcessManagement
    {

        //Start a new process
        public void StartProcess(string address, string process, string arguments = "")
        {

            Process Proc = new Process();

            Proc.StartInfo.WorkingDirectory = address; //Process Directory

            Proc.StartInfo.FileName = process; //Process FileName

            Proc.StartInfo.Arguments = arguments; //Process optional arguments

            Proc.StartInfo.CreateNoWindow = true; //Set no display windows

            Proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Set no display any window

            Proc.Start();
        }

        //Stop a process
        public void StopProcess(string process)
        {

            Process[] processgroup = Process.GetProcessesByName(process); // Select processes with that name

            foreach (Process Proc in processgroup)
            {
                Proc.Kill(); // Stop each process with that name
            }

        }
    }
}
