namespace InstallMapiExx64
{
    internal class Config
    {
        public static string DestinationDirectory = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\";
        public static string SourceDirectory = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\";

        public static string VboTargetDirectory = DestinationDirectory + @"VBO\";
        public static string VboSourceDirectory = SourceDirectory + @"VBO\";

        private const string Mapi32DllFilename = "MAPI32.dll";
        private const string MapiexDllFilename = "MAPIEx.dll";
        private const string MapiexAutomationDllFilename = "BluePrismMAPIExAutomation.dll";
        private const string MapiexAutomationTlbFilename = "BluePrismMAPIExAutomation.tlb";
        private const string MapiExHelpFilename = "BPMapiEx.chm";
        private const string MapiexVboFilename = "BPA Object - Blue Prism MAPIEx.xml";


        public static string Mapi32DllSource = SourceDirectory + Mapi32DllFilename;
        public static string Mapi32DllTarget = DestinationDirectory + Mapi32DllFilename;

        public static string MapiexDllSource = SourceDirectory + MapiexDllFilename;
        public static string MapiexDllTarget = DestinationDirectory + MapiexDllFilename;

        public static string MapiexAutomationDllSource = SourceDirectory + MapiexAutomationDllFilename;
        public static string MapiexAutomationDllTarget = DestinationDirectory + MapiexAutomationDllFilename;

        public static string MapiexAutomationTlbSource = SourceDirectory + MapiexAutomationTlbFilename;
        public static string MapiexAutomationTlbTarget = DestinationDirectory + MapiexAutomationTlbFilename;

        public static string MapiExHelpSource = SourceDirectory + MapiExHelpFilename;
        public static string MapiExHelpTarget = DestinationDirectory + MapiExHelpFilename;

        public static string MapiexVboSource = VboSourceDirectory + MapiexVboFilename;
        public static string MapiexVboTarget = VboTargetDirectory + MapiexVboFilename;

    }
}
