using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstallMapiExx64
{
    class CopyFileHelper
    {
        public static void CopyFile(string Source, string Target)
        {
            if (File.Exists(Source))
            {
                try
                {
                    Console.WriteLine("Copying {0} to {1}...", Source, Target);
                    File.Copy(Source, Target, true);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("Error copying {0} to {1} - {2}", Source, Target, e.Message);
                    throw new UnauthorizedAccessException(@"Unauthorized Access Exception", e);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Error copying {0} to {1} - {2}", Source, Target, e.Message);
                    throw new UnauthorizedAccessException(@"Unauthorized Access Exception", e);
                }
                catch (PathTooLongException e)
                {
                    Console.WriteLine("Source or target path exceeded 260 characters.");
                    throw new PathTooLongException(@"Path Too Long Exception", e);
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("Source or Target directory not located. Please validated and try again.");
                    throw new DirectoryNotFoundException(@"Directory Not Found Exception", e);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Source File Not Found - {0}", Source);
                    throw new FileNotFoundException(@"File Not Found Exception", e);
                }
                catch (IOException e)
                {
                    Console.WriteLine("An I/O error has occurred or the destination ({0}) is read-only", Target);
                    throw new IOException(@"Input / Output Exception", e);
                }
                catch (NotSupportedException e)
                {
                    Console.WriteLine("Source or Destination paths are in an invalid format. Please validate and try again.");
                    throw new NotSupportedException(@"Not Supported Exception", e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected error copying {0} to {1} - {2}", Source, Target, e.Message);
                    throw new Exception(@"Unexpected error", e);
                }
            }
        }
    }
}
