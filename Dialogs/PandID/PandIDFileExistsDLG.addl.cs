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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDFileExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[DialogBox]" + AcMainWin.cBabel(21057,3,"File Exists")+"|"+AcMainWin.cBabel(23037, 3, "File Exists"); ;
		}

		public override void Invoke()
		{
			PandIDFunctions.DeleteAllDrawings();
			PandIDFunctions.CreateDrawing("PANDID","no","ABC");
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("0");
			Drawing.Current.TypeE("_Close");
			PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
			if (PandIDWarningAutoCADDLG.Exists)
			{
				PandIDWarningAutoCADDLG.No.Click();
			}
			Drawing.Current.TypeE("_PROJECTMANAGER");
			PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = Current<PandIDPROJECTMANAGERDLG>();
			PandIDPROJECTMANAGERDLG.SetActive();
			PandIDFunctions.DeleteDrawing();
			PandID AppWnd = Current<PandID>();
            //AppWnd.File.New.Pick();
			AppWnd.TypeKeys("<Enter>");
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("0");
			PandIDPROJECTMANAGERDLG.Invoke();
			PandIDPROJECTMANAGERDLG.SetActive();
			PandIDPROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039,2,"Default Project"));
            //ExpandTreeP3D(wTreeView,1,1,1);
			PandIDNewDWGDLG PandIDNewDWGDLG = Current<PandIDNewDWGDLG>();
			PandIDNewDWGDLG.FolderPathTF.SetText("ABC");
			PandIDNewDWGDLG.OKPB.Click();
		}

		public override void Dismiss()
		{
			PandIDFileExistsDLG PandIDFileExistsDLG = Current<PandIDFileExistsDLG>();
			PandIDFileExistsDLG.SetActive();
			PandIDFileExistsDLG.TypeKeys("<Tab 2><Enter>");
			Drawing.Current.TypeE("SDI");
			Drawing.Current.TypeE("1");
		}
    }
}
