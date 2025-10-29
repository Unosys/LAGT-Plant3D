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
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DDWFOutputSettingsDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$DWFOutputSettingsDlg";
		}

		public  void Invoke()
        {
            string Title = DateTime.Now.ToString();
            Title = Title.Replace(":", "_").Replace("/", "_");
            //Plant3DFunctions.CreateDrawing("P3D", "Test_New.dwg");
            Plant3DFunctions.CreateDrawing("P3D", "no", "Temp_Title");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039, 2, "Default Project"));
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Drawing.Current.SetSysVar("SDI", 0);
            //Plant3DFunctions.ExpandTreeP3D(wTreeView, 7, "0,2");
            PROJECTMANAGERDLG.Plant3DDrawingsTVI.Select();
            PROJECTMANAGERDLG.Plant3DDrawingsTVI.Click(MouseButton.Right);
            System.Threading.Thread.Sleep(3000);
            wTreeView.TypeKeys("<Down 5><Enter>");
            System.Threading.Thread.Sleep(3000);
            PublishPandIDDLG PublishPandIDDLG = new PublishPandIDDLG();
            PublishPandIDDLG.PublishOptions.Click();
            System.Threading.Thread.Sleep(3000);
            ProjectPublishOptionsDLG ProjectPublishOptionsDLG = new ProjectPublishOptionsDLG();
            ProjectPublishOptionsDLG.SetActive();
            Desktop Desktop = new Desktop();
            Desktop.TypeKeys("<Tab><Tab 4>");//plant 3D DWF options
            ProjectPublishOptionsDLG.PushButton1PB.Click();
            System.Threading.Thread.Sleep(2000);
           
        }

		public  void Dismiss()
		{
            Plant3DDWFOutputSettingsDLG Plant3DDWFOutputSettingsDLG=new Plant3DDWFOutputSettingsDLG();
            Plant3DDWFOutputSettingsDLG.CancelBtn.Click();
            ProjectPublishOptionsDLG ProjectPublishOptionsDLG = new ProjectPublishOptionsDLG();
            ProjectPublishOptionsDLG.CancelPB.Click();
            PublishPandIDDLG PublishPandIDDLG = new PublishPandIDDLG();
            PublishPandIDDLG.Cancel.Click();
            Plant3DFunctions.DeleteDrawing("P3D");            
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.Dismiss();
		}
     
    }
}
