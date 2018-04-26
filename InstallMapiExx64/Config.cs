using System;
using System.Collections.Generic;

namespace InstallMapiExx64
{
    internal class Config
    {
        public const string DestinationDirectory = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\";
        public const string SourceDirectory = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\";

        private const string Mapi32DllFilename = "MAPI32.dll";
        private const string MapiexDllFilename = "MAPIEx.dll";
        private const string MapiexAutomationDllFilename = "BluePrismMAPIExAutomation.dll";
        private const string MapiexAutomationTlbFilename = "BluePrismMAPIExAutomation.tlb";
        private const string MapiExHelpFilename = "BPMapiEx.chm";


        private static readonly string VboSourceDirectory = String.Concat(SourceDirectory, @"VBO\");
        public static readonly string VboTargetDirectory = String.Concat(DestinationDirectory, @"VBO\");
        private const string MapiexVboFilename = @"VBO\BPA Object - Blue Prism MAPIEx.xml";

        public static readonly List<String> ListFile = new List<String>
        {
            MapiexDllFilename,
            MapiexAutomationDllFilename,
            MapiexAutomationTlbFilename,
            MapiExHelpFilename,
            MapiexVboFilename,
            Mapi32DllFilename
        };
    }
}
