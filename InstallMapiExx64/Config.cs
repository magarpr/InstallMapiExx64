namespace InstallMapiExx64
{
    internal class Config
    {
        public static string DestinationDirectory = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\";
        public static string SourceDirectory = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\";

        public static string Mapi32DllSource = SourceDirectory + @"MAPI32.dll";
        public static string Mapi32DllTarget = DestinationDirectory + @"MAPI32.dll";

        public static string MapiexDllSource = SourceDirectory + @"MAPIEx.dll";
        public static string MapiexDllTarget = DestinationDirectory + @"MAPIEx.dll";

        public static string MapiexAutomationDllSource = SourceDirectory + @"BluePrismMAPIExAutomation.dll";
        public static string MapiexAutomationDllTarget = DestinationDirectory + @"BluePrismMAPIExAutomation.dll";

        public static string MapiexAutomationTlbSource = SourceDirectory + @"BluePrismMAPIExAutomation.tlb";
        public static string MapiexAutomationTlbTarget = DestinationDirectory + @"BluePrismMAPIExAutomation.tlb";

        public static string MapiExHelpSource = SourceDirectory + @"BPMapiEx.chm";
        public static string MapiExHelpTarget = DestinationDirectory + @"BPMapiEx.chm";

        public static string MapiexVboSource = SourceDirectory + @"VBO\BPA Object - Blue Prism MAPIEx.xml";
        public static string MapiexVboTarget = DestinationDirectory + @"VBO\BPA Object - Blue Prism MAPIEx.xml";

        public static string VboTargetDirectory = DestinationDirectory + @"VBO";
    }
}
