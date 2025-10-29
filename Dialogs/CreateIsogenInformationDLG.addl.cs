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
    public partial class CreateIsogenInformationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[Pane]$IsoInformationDlg";
		}

		public override void Invoke()
		{
			PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
			PROJECTMANAGERDLG.Invoke();
			Plant3DFunctions.CreateDrawing("P3D");
			Drawing.Current.TypeE("_dynmode");
			Drawing.Current.TypeE("-3");
            //Drawing.Current.TypeE("_RIBBON");
			Drawing.Current.TypeE("_PLANTPIPEADD");
			Drawing.Current.TypeE("63,32");
			Drawing.Current.TypeE("100,26");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("_Zoom");
			Drawing.Current.TypeE("_Extents");
            Desktop Desktop = new Desktop();
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{

            //    case "DEU":
            //        Drawing.Current.TypeE("_PLANTISOADDINFO");
            //        System.Threading.Thread.Sleep(1000);
            //        Drawing.Current.TypeE("_Arrow");
            //        System.Threading.Thread.Sleep(2000);

            //        Desktop.Click(MouseButton.Left, 314, 297);
            //        Drawing.Current.TypeKeys("<Enter>");
            //        Desktop.DoubleClick(MouseButton.Left, 314, 297);//Double click the --"->"
            //        break;

            //    default:
            //        Drawing.Current.TypeE("_PLANTISOADDINFO");
            //        System.Threading.Thread.Sleep(1000);
            //        Drawing.Current.TypeE("_Arrow");
            //        System.Threading.Thread.Sleep(2000);

            //        Desktop.Click(MouseButton.Left, 314, 316);
            //        Drawing.Current.TypeKeys("<Enter>");
            //        Desktop.DoubleClick(MouseButton.Left, 349, 318);//Double click the --"->"
            //        break;
            //}
            Drawing.Current.TypeE("_PLANTISOADDINFO");
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.TypeE("_Arrow");
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            Drawing.Current.TypeKeys("<Enter>");
            System.Threading.Thread.Sleep(1000);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            this.SetActive();
        }

        public override void Dismiss()
		{
			CreateIsogenInformationDLG CreateIsogenInformationDLG = new CreateIsogenInformationDLG();
			CreateIsogenInformationDLG.M_bt_Cancel.Click();
			Drawing.Current.TypeKeys("<Esc 2>");
			Drawing.Current.TypeE("_ProjectManager");
			Plant3DFunctions.DeleteDrawing("P3D");
			
		}
    }
}
