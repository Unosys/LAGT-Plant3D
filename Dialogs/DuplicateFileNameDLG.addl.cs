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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class DuplicateFileNameDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23037,1,"Duplicate File Name");
		}

		public override void Invoke()
		{
			string sProj;
            if (LAGT.CommonFiles.Product.Variables.ProductName == "AutoCAD Plant 3D")
            {
                sProj = "P3D";
            }
            else
            {
                sProj = "PID";
            }
			Drawing.Current.TypeE("_PROJECTMANAGER");
			//FunctionsP3D FunctionsP3D = new FunctionsP3D();
			Plant3DFunctions.DeleteAllDrawings();
            //print(sProj) print(sProj) = new print(sProj)();
            System.Console.WriteLine(sProj);
            AdResultLog.Current.Log(sProj);
			Plant3DFunctions.CreateDrawing(sProj,"no","Temp{RandInt(2,9)}", null);
			Plant3DFunctions.CreateDrawing(sProj,"no","Sample1", null);
			Drawing.Current.TypeE("_Close");
			WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
			if (WarningAutoCADDLG.Exists)
			{
				WarningAutoCADDLG.No.Click();
			}
			Plant3DFunctions.CreateDrawing(sProj,"no","Sample2", null);
			Drawing.Current.TypeE("_Close");
			if (WarningAutoCADDLG.Exists)
			{
				WarningAutoCADDLG.No.Click();
			}
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.SetActive();
			Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
			if (LAGT.CommonFiles.Product.Variables.ProductName == "AutoCAD Plant 3D")
			{
			Plant3DFunctions.ExpandTreeP3D(wTreeView,5,"1,2,1");
            }
			else
            {
			Plant3DFunctions.ExpandTreeP3D(wTreeView,5,"1,1,1");
            }
			RenameDWGDLG RenameDWGDLG = new RenameDWGDLG();
			RenameDWGDLG.SetActive();
			RenameDWGDLG.FileNameTF.SetText("Sample2.dwg");
			RenameDWGDLG.OK.Click();
		}

		public override void Dismiss()
		{
			DuplicateFileNameDLG DuplicateFileNameDLG = new DuplicateFileNameDLG();
			DuplicateFileNameDLG.SetActive();
			DuplicateFileNameDLG.NoPB.Click();
            //FunctionsP3D FunctionsP3D = new FunctionsP3D();
            Plant3DFunctions.DeleteAllDrawings();
		}
    }
}
