﻿using System;
using System.IO;

namespace InstallMapiExx64
{
    internal class Program
    {
        private static void CopyFile(string source, string target)
        {
                Console.WriteLine($"Copying {source} to {target}...");
                File.Copy(source, target, true);
        }

        private static void Main()
        {
            if (!(Directory.Exists(Config.DestinationDirectory)))
            {
                //Console.Write("\nUnable to locate source directory - {0}. Exiting...", Config.DestinationDirectory);
                Console.WriteLine($"\nUnable to locate source directory - {Config.DestinationDirectory}. Exiting...");
                Environment.ExitCode = 1;
                Environment.Exit(Environment.ExitCode);
            }
            if (!(Directory.Exists(Config.SourceDirectory)))
            {
                Console.WriteLine($"\nUnable to locate target directory - {Config.SourceDirectory}. Exiting...", Config.SourceDirectory);
                Environment.ExitCode = 1;
                Environment.Exit(Environment.ExitCode);
            }
            if (!(Directory.Exists(Config.VboTargetDirectory)))
            {
                try
                {
                    Console.WriteLine("Unable to find target VBO directory. Attempting to create...");
                    Directory.CreateDirectory(Config.VboTargetDirectory);
                    Console.WriteLine("Target VBO Directory created successfully.");
                }
                catch (Exception e)
                {
                    Console.Write($"\nError creating target VBO directory {Config.VboTargetDirectory} - {e.Message}. Exiting...");
                    Environment.ExitCode = 1;
                    Environment.Exit(Environment.ExitCode);
                }
            }

            try
            {
                foreach (var tuple in Config.ListFile)
                {
                    CopyFile(tuple.Item1, tuple.Item2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error encountered - {e.Message}. Exiting...");
                Environment.ExitCode = 1;
                Environment.Exit(Environment.ExitCode);
            }
            finally
            {
                Environment.Exit(Environment.ExitCode);
            }
        }
    }
}