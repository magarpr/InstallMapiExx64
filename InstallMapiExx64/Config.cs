using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstallMapiExx64
{
    class Config
    {
        public static string x64BaseDir = @"c:\Program Files\Blue Prism Limited\Blue Prism Automate\";
        public static string x86BaseDir = @"c:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\";

        public static string mapi32DLLSource = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\MAPI32.dll";
        public static string mapiexDLLSource = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\MAPIEx.dll";
        public static string mapiexAutomationDLLSource = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\BluePrismMAPIExAutomation.dll";
        public static string mapiexAutomationTLBSource = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\BluePrismMAPIExAutomation.tlb";
        public static string MapiExHelpSource = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\BPMapiEx.chm";
        public static string mapiexVBOSource = @"C:\Program Files (x86)\Blue Prism Limited\Blue Prism Automate\VBO\BPA Object - Blue Prism MAPIEx.xml";

        public static string mapi32DLLTarget = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\MAPI32.dll";
        public static string mapiexDLLTarget = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\MAPIEx.dll";
        public static string mapiexAutomationDLLTarget = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\BluePrismMAPIExAutomation.dll";
        public static string mapiexAutomationTLBTarget = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\BluePrismMAPIExAutomation.tlb";
        public static string MapiExHelpTarget = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\BPMapiEx.chm";
        public static string mapiexVBOTarget = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\VBO\BPA Object - Blue Prism MAPIEx.xml";
        public static string vboTarget = @"C:\Program Files\Blue Prism Limited\Blue Prism Automate\VBO";
    }
}
