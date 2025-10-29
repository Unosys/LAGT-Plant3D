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
    public partial class SelectReferenceModelsDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$frmSelectRefModels";
		}

		public void Invoke()
		{
			Plant3DFunctions.CreateOrthoDrawing(null);
			//Drawing.Current.TypeKeys("<Esc>");
			Drawing.Current.TypeE("_PLANTORTHOCREATE");
		}

		public void Dismiss()
		{
			SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
			SelectReferenceModelsDLG.M_btnCancel.Click();
            System.Threading.Thread.Sleep(3000);
            Drawing.Current.TypeE("_Close");
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
           
            System.Threading.Thread.Sleep(3000);
            //Plant3DFunctions.DeleteOrthoDrawing();
            PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            PROJECTMANAGERDLG.Undock();
        }
    }
}
