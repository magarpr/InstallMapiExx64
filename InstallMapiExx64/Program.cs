using System;
using System.IO;

namespace InstallMapiExx64
{
    internal static class Program
    {
        private static void Main()
        {
            var fileCopyWorker = new FileCopy(Config.SourceDirectory, Config.DestinationDirectory);

            foreach (var file in Config.ListFile)
            {
                try
                {
                    fileCopyWorker.CopyFile(file);
                }
                catch (FileNotFoundException e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                catch (IOException e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine($"Unexpected error encountered. Exiting. \n {e.Message} - {e.StackTrace}");
                    Environment.ExitCode = 1;
                    Environment.Exit(Environment.ExitCode);
                }
            }
            Environment.Exit(Environment.ExitCode);
        }
    }
}