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
    public partial class PathNameErrorDLG : Window
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]"+AcMainWin.cBabel(23048, 2, "Path Name Error");
                    

		}

		public  void Invoke()
		{
			ModifySharedContentFolderDLG ModifySharedContentFolderDLG = new ModifySharedContentFolderDLG();
			ModifySharedContentFolderDLG.Invoke();
			ModifySharedContentFolderDLG.TypeKeys("<Tab><Shift-End><E><Enter>");
            PathNameErrorDLG PathNameErrorDLG = new PathNameErrorDLG();
            //PathNameErrorDLG.MoveMouse(10, 10);            
            PathNameErrorDLG.SetActive();
		}

		public  void Dismiss()
		{
            PathNameErrorDLG PathNameErrorDLG = new PathNameErrorDLG();
            PathNameErrorDLG.SetActive();
            PathNameErrorDLG.OK.Click();
			ModifySharedContentFolderDLG ModifySharedContentFolderDLG = new ModifySharedContentFolderDLG();
			ModifySharedContentFolderDLG.TypeKeys("<Tab 4><Enter>");
			Drawing.Current.SetSysVar("cmddia", 0);
		}
    }
}
