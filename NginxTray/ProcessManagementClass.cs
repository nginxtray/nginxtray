/*
 * NginxTray - A tray icon to manage Nginx and other components.
 * 
 * This file is part of NginxTray <https://github.com/nginxtray/nginxtray>.
 * 
 * Copyright (C) 2010-2017 by Emiliano del Gobbo
 * <https://emilianodelgobbo.com> and other contributors.
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License version 2 as 
 * published by the Free Software Foundation.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License version 2 for more details.
 * 
 * You should have received a copy of the GNU General Public License 
 * version 2 along with this program.  If not, see
 * <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NginxTray
{
    public class ProcessManagement
    {

        //Start a new process
        public bool StartProcess(string address, string process, string arguments = "")
        {

            Process Proc = new Process();

            Proc.StartInfo.WorkingDirectory = address; //Process Directory

            Proc.StartInfo.FileName = process; //Process FileName

            Proc.StartInfo.Arguments = arguments; //Process optional arguments

            Proc.StartInfo.CreateNoWindow = true; //Set no display windows

            Proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Set no display any window

            try
            {
                Proc.Start();
            }
            catch
            {
                return false;
            }

            return true;
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
