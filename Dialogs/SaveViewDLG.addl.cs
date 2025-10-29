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
    public partial class SaveViewDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = AcMainWin.cBabel(23052, 2, "Save View");
		}

        public void Invoke()
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Plant3DFunctions.CreateDrawing("P3D");
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetActive();
            Plant3DFunctions.CreateOrthoDrawingColurStyle("P3D");
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_PLANTORTHOCREATE");
            System.Threading.Thread.Sleep(3000);
            SelectReferenceModelsDLG SelectReferenceModelsDLG = new SelectReferenceModelsDLG();
            SelectOrthographicDrawingDLG SelectOrthographicDrawingDLG = new SelectOrthographicDrawingDLG();
            if (SelectReferenceModelsDLG.Exists)
            {
                SelectReferenceModelsDLG.SetActive();
                SelectReferenceModelsDLG.TypeKeys("<End>");
                SelectReferenceModelsDLG.TypeKeys("<Space>");
                SelectReferenceModelsDLG.M_btnOK.Click();
                System.Threading.Thread.Sleep(2000);
            }
            if (SelectOrthographicDrawingDLG.Exists)
            {
                SelectOrthographicDrawingDLG.TypeKeys("<Down 5>");//select p3d
                SelectOrthographicDrawingDLG.M_btnOK.Click();
                System.Threading.Thread.Sleep(2000);
            }
            Plant3D AppWnd = new Plant3D();
            if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
            {

                AppWnd.TypeKeys("<alt-Space><Down 5><Enter>");
            }
            else if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH)
            {

                AppWnd.TypeKeys("<alt-Space>n");
            }
            else if (Harness.Current.AppWnd.Language == LANG_ID.GERMAN)
            {

                AppWnd.TypeKeys("<alt-Space>x");
            }
            else
            {
                AppWnd.TypeKeys("<alt-Space>x");
            }
            System.Threading.Thread.Sleep(2000);
            AppWnd.SaveOrthoCubePB.Click();
            if (!this.Exists)
            {
                Desktop Desktop = new Desktop();
                ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Saveview.bmp");
                Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
                System.Threading.Thread.Sleep(2000);
            }

        }

        public void Dismiss()
        {
            SaveViewDLG SaveViewDLG = new SaveViewDLG();
            SaveViewDLG.Cancel.Click();
            System.Threading.Thread.Sleep(2000);
            Plant3D AppWnd = new Plant3D();
            if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
            {

                AppWnd.TypeKeys("<alt-Space><Down><Enter>");
            }
            else if (Harness.Current.AppWnd.Language == LANG_ID.GERMAN)
            {

                AppWnd.TypeKeys("<alt-Space>n");
            }
            else
            {
                AppWnd.TypeKeys("<alt-Space>R");
            }
            System.Threading.Thread.Sleep(5000);
            Drawing.Current.TypeE("_Close");
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_Close");
           
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_Close");
            
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
           
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Plant3DFunctions.DeleteOrthoDrawing();
            Plant3DFunctions.DeleteDrawing("P3D");
            PROJECTMANAGERDLG.Dismiss();
           
        }
    }
}
