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
using System.Xml;
using System.Text.RegularExpressions;

namespace NginxTray
{
    
    class UpdateManagementClass
    {
        public const string version = "1.0.1"; // Actual software version used

        public bool CheckFailed = false; // Set true if unable to check a new version

        public string CurrentVersion; // Current Version available

        public bool NeedUpdate = false; // Comparation version available and used

        public UpdateManagementClass()
        {
            this.CheckCurrentVersion();
        }

        // Campare currentversion and using version
        public void CheckUpdate()
        {
            if (version == CurrentVersion)
            {
                NeedUpdate = false;
            }
            else
            {
                NeedUpdate = true;
            }

        }

        // Check the current version from web
        public string CheckCurrentVersion()
        {
            string versione = "";
            try
            {
                XmlDocument rssVersion = new XmlDocument();
                rssVersion.Load("https://github.com/nginxtray/nginxtray/releases.atom");
                XmlNode curVersion = rssVersion.SelectSingleNode("descendant::entry");
                versione = Regex.Replace(curVersion.InnerText, @"<(.|\n)*?>", string.Empty);
                versione = versione.Replace("NginxTray ", "");
                CurrentVersion = versione;
            }
            catch
            {
                CheckFailed = true;
            }
            return (versione);
        }

    }
}
