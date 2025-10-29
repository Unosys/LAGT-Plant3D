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
    public partial class PIDObjectMappingPipeLineGroupDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "$EditProjectSettingsDlg";

        }

		public  void Invoke()
		{
			PIDObjectMappingDLG PIDObjectMappingDLG = new PIDObjectMappingDLG();
			PIDObjectMappingDLG.Invoke();
			TreeView wtreeView=PIDObjectMappingDLG.M_treeClasses;
            switch (LAGT.CommonFiles.Product.Variables.Language)
            {
                case "RUS":
                    //wtreeView.Select(1);
                    wtreeView.Select("Группа трубопроводов");
                    break;
                case "DEU":
                    //wtreeView.Select(1);
                    wtreeView.Select("Rohrleitungsgruppe");
                    break;
                case "FRA":
                    //wtreeView.Select(3);
                    wtreeView.Select(AcMainWin.cBabel(21100, 5, "Pipe Line Group"));
                    break;
                case "KOR":
                    //wtreeView.Select(3);
                    wtreeView.Select(AcMainWin.cBabel(21100, 5, "Pipe Line Group"));
                    break;
                case "CHS":
                case "JPN":
                default:
                    //wtreeView.Select(2);
                    wtreeView.Select(AcMainWin.cBabel(21100, 5, "Pipe Line Group"));
                    break;
            }           
            System.Threading.Thread.Sleep(3000);
        }

		public  void Dismiss()
		{
            PIDObjectMappingDLG PIDObjectMappingDLG = new PIDObjectMappingDLG();
            PIDObjectMappingDLG.Dismiss() ;
			
		}
    }
}
