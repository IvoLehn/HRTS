using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;


namespace HRTS
{
    class SessionVerwaltung
    {
        public static List<List<string>> QUser(List<string> serverListe)
        {
            List<List<string>> liste = new List<List<string>>();

            Parallel.ForEach(serverListe, server =>
            {
                using (PowerShell powershell = PowerShell.Create())
                {
                    List<string> linie = new List<string>();

                    Collection<PSObject> obj = new Collection<PSObject>();

                    obj = powershell.AddScript("quser /server:" + server + @" | ForEach-Object -Process { $_ -replace '\s{2,}',',' } ").Invoke();

                    foreach (var item in obj)
                    {
                        string line = server + ',' + item.ToString();
                        liste.Add(line.Split(',').ToList());
                    }
                }
            });

            return liste.OrderBy(x => x[0]).ToList();
        }
        public static void LogOffUser(List<List<string>> users)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                foreach (List<string> user in users)
                {
                    powerShell.AddScript("logoff " + user[1] + " /server:" + user[0]).Invoke();
                }
            }
        }
        public static void ShadowSession(List<List<string>> users)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                foreach (List<string> user in users)
                {
                    powerShell.AddScript("mstsc.exe /v:" + user[0] + " /shadow:" + user[1] + " /control /f").Invoke();
                }
            }
        }
        public static void Mstsc(List<string> serverListe)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                foreach (string server in serverListe)
                {
                    powerShell.AddScript("mstsc.exe /v:" + server + " /admin /control /f").Invoke();
                }
            }
        }

        public static void CreateCMDKey(List<string> serverListe, string userName, string passWord)
        {
            foreach(string hostName in serverListe)
            {
                Process CreateCMDKey = new Process();
                CreateCMDKey.StartInfo.FileName = "cmdkey.exe";
                CreateCMDKey.StartInfo.Arguments = $@"/generic:TERMSRV/{hostName} /user:vrg-ol.de\{userName} /pass:{passWord}";
                CreateCMDKey.Start();
            }
        }
        public static bool ADAuthentication(string domain, string user, string pw)
        {
            try
            {
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
                {
                    return pc.ValidateCredentials(user, pw);
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
