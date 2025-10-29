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
    public partial class IsometricCreationResultsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$IsometricResultsDetail";
		}

		public override void Invoke()
		{

            CreateQuickIsoDLG CreateQuickIsoDLG = new CreateQuickIsoDLG();
            CreateQuickIsoDLG.Invoke();
            CreateQuickIsoDLG.Button_Create.Click();
            System.Threading.Thread.Sleep(3000);           
            Plant3D AppWnd = new Plant3D();
            if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH || Harness.Current.AppWnd.Language == LANG_ID.ITALIAN)
            {

                AppWnd.TypeKeys("<alt-Space>n");
            }
            if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
            {

                AppWnd.TypeKeys("<alt-Space><Down 5><Enter>");
            }
            else
            {

                AppWnd.TypeKeys("<alt-Space>x");
            }
            System.Threading.Thread.Sleep(10000);
            Desktop Desktop = new Desktop();
            try
            {
                if (AppWnd.ISOImage.Exists)
                {
                    AppWnd.ISOImage.Click();
                }
            }
            catch
            {
            }
            if (!this.Exists)
            {
                ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\iso.bmp");
                Desktop.DoubleClick(MouseButton.Left, SAM.iXCenter, SAM.iYCenter);
                System.Threading.Thread.Sleep(2000);
            }
            this.SetActive();
        }

		public override void Dismiss()
		{
			IsometricCreationResultsDLG IsometricCreationResultsDLG = new IsometricCreationResultsDLG();
            IsometricCreationResultsDLG.Close2PB.Click();
            Plant3D AppWnd = new Plant3D();
            if (Harness.Current.AppWnd.Language == LANG_ID.RUSSIAN)
            {

                AppWnd.TypeKeys("<alt-Space><Down><Enter>");
            }
            else if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH)
            {

                AppWnd.TypeKeys("<alt-Space>R");
            }
            else if (Harness.Current.AppWnd.Language == LANG_ID.GERMAN)
            {

                AppWnd.TypeKeys("<alt-Space>W");
            }
            else
            {
                AppWnd.TypeKeys("<alt-Space>R");
            }

            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(1000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.DeleteDrawing("P3D");
            PROJECTMANAGERDLG.Dismiss();
        }
    }
}
