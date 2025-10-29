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
    public partial class PandIDDataManagerDLG : CustomWin//Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            DataManagerDLG DataManagerDLG = new DataManagerDLG();
               Tag = DataManagerDLG.Tag;// "[CustomWin]#3"; //|[CustomWin]#2|" + AcMainWin.cBabel(21066, 9, "Data Manager");
        }

        public  void Invoke()
        {
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("_DATAMANAGER");
            this.SetSize(950, 400);
            //PandIDDataManagerDLG PandIDDataManagerDLG = new PandIDDataManagerDLG();
            //RECT rDM = PandIDDataManagerDLG.GetRect();
            //Desktop Desktop = new Desktop();
            //Desktop.DragMouse(MouseButton.Left, rDM.xPos + rDM.xSize - 1, rDM.yPos + rDM.ySize - 1, rDM.xPos + 800, rDM.yPos + 300);
        }

        public  void Dismiss()
        {
            Drawing.Current.TypeE("_DATAMANAGERCLOSE");
        }

        public void SetSize(int xRestSize, int yRestSize)
        {
            DataManagerDLG DataManagerDLG = new DataManagerDLG();
            RECT r = DataManagerDLG.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                DataManagerDLG.Click(MouseButton.Right, 10, 70);
                Desktop.Current.TypeKeys("<Down 2><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
    }
}
