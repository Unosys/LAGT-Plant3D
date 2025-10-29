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
using Microsoft.Win32;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PIDLineList : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$ControlAxSourcingSite";


        }

        public override void Invoke()
        {
            Plant3DFunctions.OpenSampleProject();
            Drawing.Current.TypeE("_SDI 1");
            Drawing.Current.Open(sSampleProjectPath+ "Plant_3D_Models\\Master.dwg");
            System.Threading.Thread.Sleep(8000);

            Drawing.Current.TypeE("_ProjectManagerClose");
            Drawing.Current.TypeE("_ToolPalettesClose");
            Drawing.Current.TypeE("_plantpidlinelist");
            System.Threading.Thread.Sleep(3000);
            PIDLineList PIDLineList = new PIDLineList();       
            PIDLineList.SetSize(900, 700);
           


        }
        public void SetSize(int xRestSize, int yRestSize)
        {
            PIDLineList PIDLineList = new PIDLineList();
            RECT r = PIDLineList.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                PIDLineList.Click(MouseButton.Right, -8, 70);
                System.Threading.Thread.Sleep(2000);
                Desktop.Current.TypeKeys("<Down 2><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
        public override void Dismiss()
        {
            PIDLineList PIDLineList = new PIDLineList();
            PIDLineList.SetActive();
            Drawing.Current.TypeKeys("<Esc 2>");
            Drawing.Current.TypeE("_SDI 0");
            PIDLineList.Close();           
            Drawing.Current.TypeE("_ProjectManager");
            Drawing.Current.TypeE("_CLOSE");
            System.Threading.Thread.Sleep(2000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();
            }
            System.Threading.Thread.Sleep(2000);
            Plant3DFunctions.SetToDefault();
        }
        public override void Close()
        {
            PIDLineList PIDLineList = new PIDLineList();
            RECT r = PIDLineList.GetRect(true);
            PIDLineList.Click(MouseButton.Right, -8, 70);
            System.Threading.Thread.Sleep(2000);
            Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
               
            

        }
        public virtual string sSampleProjectPath
        {
            get
            {
                return Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "SampleProject", "") as string;
     
            }
        }
    }
}
