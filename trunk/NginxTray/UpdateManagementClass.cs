using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace NginxTray
{
    
    class UpdateManagementClass
    {
        public const string version = "0.7 RC2"; // Actual software version used

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
                rssVersion.Load("http://nginxtray.codeplex.com/Project/ProjectRss.aspx");
                XmlNode curVersion = rssVersion.SelectSingleNode("//channel/item/description/text()");
                versione = curVersion.InnerText.Replace("<div>", "");
                versione = versione.Replace("</div>", "");
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
