// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2015 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SelectPlant3DClassMappingDLG : Pane
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            ///if this case have harness , because parent type is change.
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "JPN":                   
                case "FRA":                    
                case "DEU":              
                case "RUS":                
                case "KOR":
                    Tag = Plant3DFunctions.GetLocString("SelectPlant3DClassMappingDLG");
                    break;
                default:
                    Tag = "[Pane]$Select3DClassMappingDlg" + "|" + Plant3DFunctions.GetLocString("SelectPlant3DClassMappingDLG");
                    break;
            }

        }

        public void Invoke()
        {
            PIDObjectMappingDLG PIDObjectMappingDLG = new PIDObjectMappingDLG();
            PIDObjectMappingDLG.Invoke();
            TreeView wtreeView = PIDObjectMappingDLG.M_treeClasses;

            if (LAGT.CommonFiles.Product.Variables.Language == "RUS")
            {
                
                try
                {
                    wtreeView.Select("Группа трубопроводов");
                }
                catch
                {
                    PIDObjectMappingDLG.PipeLineGroupdeuTVI.DoubleClick();
                }
            }
            else if (LAGT.CommonFiles.Product.Variables.Language == "DEU")
            {
                
                try
                {
                    wtreeView.Select("Rohrleitungsgruppe");
                }
                catch
                {
                    PIDObjectMappingDLG.PipeLineGroupdeuTVI.DoubleClick();
                }
            }
            else
            {
                try 
                { 
                    wtreeView.Select(AcMainWin.cBabel(21100, 5, "Pipe Line Group"));
                }
                catch
                {
                    PIDObjectMappingDLG.PipeLineGroupTVI.DoubleClick();
                }
            }
            PIDObjectMappingDLG.AddPB.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public void Dismiss()
        {
            SelectPlant3DClassMappingDLG SelectPlant3DClassMappingDLG = new SelectPlant3DClassMappingDLG();
            SelectPlant3DClassMappingDLG.CancelPB.Click();
            ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
            ProjectSetupPlant3DDWG.Dismiss();
        }
    }
}
