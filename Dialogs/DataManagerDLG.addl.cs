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
    public partial class DataManagerDLG : CustomWin
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[CustomWin]#3";// AcMainWin.cBabel(21066, 9, "Data Manager");
           
                
               
        }

		public void Invoke()
		{
            Drawing.Current.TypeE("_projectmanagerclose");
            Drawing.Current.TypeE("_DATAMANAGER");
            System.Threading.Thread.Sleep(2000);
            try 
            { 
                this.SetSize(950, 400);
            } catch 
            { 
            }
            
            //DataManagerDLG DataManagerDLG = new DataManagerDLG();
            //RECT rDM = DataManagerDLG.GetRect();
            //Desktop.Current.DragMouse(MouseButton.Left,rDM.xPos+rDM.xSize,rDM.yPos+rDM.ySize, rDM.xPos+800, rDM.yPos+300);
            //this.SetActive();

        }

		public void Dismiss()
		{
            Drawing.Current.TypeE("_DATAMANAGERCLOSE");
            Drawing.Current.TypeE("_projectmanager");
        }
        public void SetSize(int xRestSize, int yRestSize)
        {
            DataManagerDLG DataManagerDLG = new DataManagerDLG();
            RECT r = DataManagerDLG.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                DataManagerDLG.Click(MouseButton.Right, 8, 70);
                Desktop.Current.TypeKeys("<Down 2><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
    }
}
