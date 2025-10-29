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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDAutoCADPIDDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$DataGridInfoDialog";
		}

        public override void Invoke()
        {
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Invoke();
            PandIDFunctions.CreateDrawing();
            System.Threading.Thread.Sleep(5000);
            Drawing.Current.TypeE("SDI");
            Drawing.Current.TypeE("0");
            System.Threading.Thread.Sleep(1000);
            PandIDProjManUndocked pROJECTMANAGERDLG = new PandIDProjManUndocked();
            pROJECTMANAGERDLG.SetActive();
            Window wTreeView = pROJECTMANAGERDLG.TreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 8, "0,1");//import
        }

		public override void Dismiss()
		{
            this.Close();
            PandIDImportFromDLG PandIDImportFromDLG = new PandIDImportFromDLG();
            PandIDImportFromDLG.Close();
            PandIDFunctions.DeleteDrawing();
            PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
            PandIDPROJECTMANAGERDLG.Dismiss();

		}
    }
}
