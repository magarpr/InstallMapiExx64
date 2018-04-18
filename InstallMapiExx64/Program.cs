﻿using System;
using System.IO;

namespace InstallMapiExx64
{
    internal class Program
    {
        public static void CopyFile(string source, string target)
        {
            try
            {
                Console.WriteLine("Copying {0} to {1}...", source, target);
                File.Copy(source, target, true);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError copying {0} to {1} - {2}\n", source, target, e.Message);
            }
        }

        private static void Main()
        {
            if (!(Directory.Exists(Config.DestinationDirectory)))
            {
                Console.Write("\nUnable to locate source directory - {0}. ", Config.DestinationDirectory);
                Environment.ExitCode = 1;
            }
            if (!(Directory.Exists(Config.SourceDirectory)) && (Environment.ExitCode == 0))
            {
                Console.Write("\nUnable to locate target directory - {0}. ", Config.SourceDirectory);
                Environment.ExitCode = 1;
            }
            if (!(Directory.Exists(Config.VboTargetDirectory)) && (Environment.ExitCode == 0))
            {
                try
                {
                    Console.WriteLine("Unable to find target VBO directory. Attempting to create...");
                    Directory.CreateDirectory(Config.VboTargetDirectory);
                    Console.WriteLine("Target VBO Directory created successfully.");
                }
                catch (Exception e)
                {
                    Console.Write("\nError creating target VBO directory {0} - {1}. ", Config.VboTargetDirectory, e.Message);
                    Environment.ExitCode = 1;
                }
            }
            if (Environment.ExitCode != 0)
            {
                Console.WriteLine("Exiting...\n");
                Environment.Exit(Environment.ExitCode);
            }
            try
            {
                CopyFile(Config.Mapi32DllSource, Config.Mapi32DllTarget);
                CopyFile(Config.MapiexDllSource, Config.MapiexDllTarget);
                CopyFile(Config.MapiexAutomationDllSource, Config.MapiexAutomationDllTarget);
                CopyFile(Config.MapiexAutomationTlbSource, Config.MapiexAutomationTlbTarget);
                CopyFile(Config.MapiExHelpSource, Config.MapiExHelpTarget);
                CopyFile(Config.MapiexVboSource, Config.MapiexVboTarget);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error encountered - {0}", e.Message);
                Environment.ExitCode = 1;
            }
            finally
            {
                Environment.Exit(Environment.ExitCode);
            }
        }
    }
}