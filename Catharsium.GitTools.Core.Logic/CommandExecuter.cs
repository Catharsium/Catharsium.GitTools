using Catharsium.GitTools.Core.Entities.Interfaces;

namespace Catharsium.GitTools.Core.Logic
{
    public class CommandExecuter : IGitCommandExecuter
    {
        //string directory = ""; // directory of the git repository

        //using (PowerShell powershell = PowerShell.Create())
        //{
        //    // this changes from the user folder that PowerShell starts up with to your git repository
        //    powershell.AddScript(String.Format(@"cd {0}", directory);

        //    powershell.AddScript(@"git init");
        //    powershell.AddScript(@"git add *");
        //    powershell.AddScript(@"git commit -m 'git commit from PowerShell in C#'");
        //    powershell.AddScript(@"git push");

        //    Collection<PSObject> results = powershell.Invoke();
        //}
    }
}