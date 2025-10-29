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
    public partial class PlantNoProjectOpenDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]"+AcMainWin.cBabel(23069, 2, "No Project Open");
		}

		public override void Invoke()
		{
            Plant3DFunctions.CreateProj();
            ProjManUndocked PROJECTMANAGER = new ProjManUndocked();
            PROJECTMANAGER.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Down 1><Enter>");
            Drawing.Current.TypeE("_PlantCreateReport");

		}

		public override void Dismiss()
		{
            Current<PlantNoProjectOpenDLG>().Close();
            Drawing.Current.TypeE("_PROJECTMANAGER");
            string sProjectName = Plant3DMainWin.sDefaultProjPath + "Project.xml";
            Drawing.Current.TypeE("openproject");
            Drawing.Current.TypeE(sProjectName);
		}
    }
}
