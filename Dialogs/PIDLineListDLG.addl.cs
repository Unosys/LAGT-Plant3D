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
    public partial class PIDLineListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[CustomWin]#3|*P&ID*";//" P&ID LINE LIST#1";


        }

		public override void Invoke()
		{
            Plant3DFunctions.CreateDrawing("P3D");
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_ProjectManagerClose");
			Drawing.Current.TypeE("_ToolPalettesClose");
			Drawing.Current.TypeE("_plantpidlinelist");
			PIDLineListDLG PIDLineListDLG = new PIDLineListDLG();
            //PIDLineListDLG.Undock();
            //Plant3DFunctions.InitDataManagerToolbarSize(PIDLineListDLG);
            PIDLineListDLG.SetSize(400,600);
        }
        public void SetSize(int xRestSize, int yRestSize)
        {
            PIDLineListDLG PIDLineListDLG = new PIDLineListDLG();
            RECT r = PIDLineListDLG.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                PIDLineListDLG.Click(MouseButton.Right, 8, 70);
                System.Threading.Thread.Sleep(2000);
                Desktop.Current.TypeKeys("<Down 2><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
        public override void Dismiss()
		{
			PIDLineListDLG PIDLineListDLG = new PIDLineListDLG();
			PIDLineListDLG.SetActive();
            //         RECT rPIDLineList = PIDLineListDLG.GetRect(true);
            //Agent.SetOption(AgentOptions.OPT_VERIFY_ACTIVE, false);
            //Agent.SetOption(AgentOptions.OPT_VERIFY_ENABLED, false);
            //         Plant3DMainWin AppWnd = new Plant3DMainWin();
            //         //AppWnd.KeyboardDelay = 1; 
            //         //Agent.SetOption(AgentOptions.OPT_KEYBOARD_DELAY, 0.8);
            //         PIDLineListDLG.KeyboardDelay = 800;
            //PIDLineListDLG.SetActive();
            //PIDLineListDLG.Click(MouseButton.Left,20,50);
            //PIDLineListDLG.TypeKeys("<Alt-Space><Down 3><Enter>");
            Drawing.Current.TypeE("_plantpidlinelist");
            Drawing.Current.TypeE("_ProjectManager");
            //AppWnd.KeyboardDelay = 0;  
            //Agent.SetOption(AgentOptions.OPT_KEYBOARD_DELAY, 0);
            //Drawing.Current.KeyboardDelay = 0;
            //   Plant3DFunctions.DeleteDrawing("P3D") Plant3DFunctions.DeleteDrawing("P3D") = new Plant3DFunctions.DeleteDrawing("P3D")();
			Plant3DFunctions.DeleteDrawing("P3D");
		}
    }
}
