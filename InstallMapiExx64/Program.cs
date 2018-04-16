using System.IO;
using System;

namespace InstallMapiExx64
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!(Directory.Exists(Config.x64BaseDir))) 
            {
                Console.WriteLine("Unable to locate source directory - {0}. Exiting...", Config.x64BaseDir);
                Environment.Exit(1);
            }

            if (!(Directory.Exists(Config.x86BaseDir)))
            {
                Console.WriteLine("Unable to locate target directory - {0}. Exiting...", Config.x86BaseDir);
                Environment.Exit(1);
            }

            if (!(Directory.Exists(Config.vboTarget)))
            {
                try
                {
                    Console.WriteLine("Unable to find target VBO directory. Attempting to create...");
                    Directory.CreateDirectory(Config.vboTarget);
                    CopyFileHelper.CopyFile(Config.mapiexVBOSource, Config.mapiexVBOTarget);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to create directory {0} - {1}", Config.vboTarget, e.Message);
                    Environment.Exit(1);
                }
            }

            try
            {
                CopyFileHelper.CopyFile(Config.mapi32DLLSource, Config.mapi32DLLTarget);
                CopyFileHelper.CopyFile(Config.mapiexDLLSource, Config.mapiexDLLTarget);
                CopyFileHelper.CopyFile(Config.mapiexAutomationDLLSource, Config.mapiexAutomationDLLTarget);
                CopyFileHelper.CopyFile(Config.mapiexAutomationTLBSource, Config.mapiexAutomationTLBTarget);
                CopyFileHelper.CopyFile(Config.MapiExHelpSource, Config.MapiExHelpTarget);
                CopyFileHelper.CopyFile(Config.mapiexVBOSource, Config.mapiexVBOTarget);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error encountered - {0}", e.Message);
                Environment.Exit(1);
            }
            Environment.Exit(0);
        }
    }
}