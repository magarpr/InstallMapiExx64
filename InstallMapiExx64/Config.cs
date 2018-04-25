using System;
using System.Collections.Generic;

namespace InstallMapiExx64
{
    internal class Config
    {
        public const string DestinationDirectory = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\";
        public const string SourceDirectory = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\";

        private static readonly string VboSourceDirectory = String.Concat(SourceDirectory, @"VBO\");
        public static readonly string VboTargetDirectory = String.Concat(DestinationDirectory, @"VBO\");

        private const string Mapi32DllFilename = "MAPI32.dll";
        private const string MapiexDllFilename = "MAPIEx.dll";
        private const string MapiexAutomationDllFilename = "BluePrismMAPIExAutomation.dll";
        private const string MapiexAutomationTlbFilename = "BluePrismMAPIExAutomation.tlb";
        private const string MapiExHelpFilename = "BPMapiEx.chm";
        private const string MapiexVboFilename = "BPA Object - Blue Prism MAPIEx.xml";

        public static readonly List<Tuple<string, string>> ListFile = new List<Tuple<string, string>>
        {
            Tuple.Create(String.Concat(SourceDirectory, Mapi32DllFilename), String.Concat(DestinationDirectory, Mapi32DllFilename)),
            Tuple.Create(String.Concat(SourceDirectory,  MapiexDllFilename), String.Concat(DestinationDirectory,  MapiexDllFilename)),
            Tuple.Create(String.Concat(SourceDirectory,  MapiexAutomationDllFilename), String.Concat(DestinationDirectory,  MapiexAutomationDllFilename)),
            Tuple.Create(String.Concat(SourceDirectory,  MapiexAutomationTlbFilename), String.Concat(DestinationDirectory,  MapiexAutomationTlbFilename)),
            Tuple.Create(String.Concat(SourceDirectory, MapiExHelpFilename), String.Concat(DestinationDirectory, MapiExHelpFilename)),
            Tuple.Create(String.Concat(VboSourceDirectory,  MapiexVboFilename), String.Concat(VboTargetDirectory,  MapiexVboFilename))
        };
    }
}
