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
    public partial class OrthoCreationinProcessDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = Plant3DFunctions.GetLocString("OrthoCreationinProcessDLG");

        }

		public override void Invoke()
		{
            Plant3DFunctions.CreateDrawing("P3D");
            Drawing.Current.TypeE("_PLANTDYNAMICTOOLPALETTE");
            Drawing.Current.TypeE("_E");
            Drawing.Current.TypeE("_PLANTPIPEADD");
            Drawing.Current.TypeE("0,0");
            Drawing.Current.TypeE("50,0");
            Drawing.Current.TypeE("50,100");
            Drawing.Current.TypeE("100,50");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_ZOOM");
            Drawing.Current.TypeE("_E");
            Plant3DFunctions.CreateOrthoDrawingColurStyle(null);
           System.Threading.Thread.Sleep(1000);
           Drawing.Current.TypeE("_PLANTORTHOCREATE");
            System.Threading.Thread.Sleep(1000);
            SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
            if (SelectReferenceModelsDLG.Exists)
            {
                SelectReferenceModelsDLG.SetActive();
                SelectReferenceModelsDLG.TypeKeys("<End>");
                SelectReferenceModelsDLG.TypeKeys("<Space>");
                SelectReferenceModelsDLG.M_btnOK.Click();
                System.Threading.Thread.Sleep(2000);
            }
            System.Threading.Thread.Sleep(5000);
            //Plant3D AppWnd = new Plant3D();
            //if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH || Harness.Current.AppWnd.Language == LANG_ID.ITALIAN)
            //{

            //    AppWnd.TypeKeys("<alt-Space>n");
            //}
            //if (Harness.Current.AppWnd.Language == LANG_ID.POLISH)
            //{

            //    AppWnd.TypeKeys("<alt-Space>s");
            //}
            //else
            //{

            //    AppWnd.TypeKeys("<alt-Space>x");
            //}
            //System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeKeys("<Esc 2>");

            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
           PROJECTMANAGERDLG.SetActive();
           Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            PROJECTMANAGERDLG.DefaultProjectTVI.Click();
            //PROJECTMANAGERDLG.TreeViewTV.Select(AcMainWin.cBabel(23039, 2, "Default Project"));
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2,1");
            System.Threading.Thread.Sleep(2000);

		}

		public override void Dismiss()
		{
            this.TypeKeys("<Enter>");
            
            Drawing.Current.TypeE("_.close");
            System.Threading.Thread.Sleep(1000);
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            if (WarningAutoCADDLG.Exists) 
            {
                WarningAutoCADDLG.No.Click();
            }
            Drawing.Current.TypeE("_Close");
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(100))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_Close");
            
            if (SaveChangesMSG.WaitExists(100))
            {
                SaveChangesMSG.NoPB.Click();

            }
            //Plant3D AppWnd = new Plant3D();
            //if (Harness.Current.AppWnd.Language == LANG_ID.POLISH)
            //{

            //    AppWnd.TypeKeys("<alt-Space>P");
            //}
            //else if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH)
            //{

            //    AppWnd.TypeKeys("<alt-Space>R");
            //}
            //else
            //{
            //    AppWnd.TypeKeys("<alt-Space>R");
            //}

            Plant3DFunctions.DeleteOrthoDrawing();
            Plant3DFunctions.DeleteAllDrawings();
		}
    }
}
