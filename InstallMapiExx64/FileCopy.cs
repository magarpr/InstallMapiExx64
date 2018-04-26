using System;
using System.IO;

namespace InstallMapiExx64
{
    internal class FileCopy
    {
        private bool Overwrite { get; set; }
        private string _sourceDirectory;
        private string _targetDirectory;
        private string SourceDirectory
        {
            get => _sourceDirectory;
            set => _sourceDirectory = ValidateDirectory(value);
        }
        private string TargetDirectory
        {
            get => _targetDirectory;
            set => _targetDirectory = ValidateDirectory(value);
        }
        private static string ValidateDirectory(string directory)
        {
            if (Directory.Exists(directory))
            {
                return directory;
            }

            throw new DirectoryNotFoundException($"{directory} not found. Please validate and try again.");
        }
        public FileCopy(string sourceDirectory, string targetDirectory, bool overwrite = true)
        {
            SourceDirectory = sourceDirectory;
            TargetDirectory = targetDirectory;
            Overwrite = overwrite;
        }
        public void CopyFile(string filename)
        {
            var fqSource = String.Concat(this.SourceDirectory, filename);
            var fqTarget = String.Concat(this.TargetDirectory, filename);
            File.Copy(fqSource, fqTarget, this.Overwrite);
        }
    }
}