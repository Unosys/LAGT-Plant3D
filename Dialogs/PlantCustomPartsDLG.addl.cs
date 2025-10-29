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
    public partial class PlantCustomPartsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox//CustomWin
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[CustomWin]#3|#5";

        }

		public override void Invoke()
		{
            Plant3DFunctions.CreateDrawing("P3D");
            Drawing.Current.Ready(10);
            System.Threading.Thread.Sleep(4000);
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
			Drawing.Current.TypeE("_PLANTCUSTOMPARTS");
            CUSTOMPARTSBUILDER CUSTOMPARTSBUILDER = new CUSTOMPARTSBUILDER();
            //if (CUSTOMPARTSBUILDER.Exists) {
                CUSTOMPARTSBUILDER.Undock();
            //}
            this.SetSize(900, 880);
            System.Threading.Thread.Sleep(5000);
        }

		public override void Dismiss()
		{
            
            Drawing.Current.TypeE("_PLANTCUSTOMPARTS");
			Drawing.Current.TypeE("_PROJECTMANAGER");
            Plant3DFunctions.DeleteDrawing("P3D");
		}
        
        public void SetActive()
        {
            if (this.Exists)
            {
                this.Click(MouseButton.Left, 10, 80);
            }
            else
                this.Invoke();
        }
        public void SetSize(int xRestSize, int yRestSize)
        {
            PlantCustomPartsDLG PlantCustomPartsDLG = new PlantCustomPartsDLG();
            RECT r = PlantCustomPartsDLG.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                PlantCustomPartsDLG.Click(MouseButton.Right, 8, 70);
                Desktop.Current.TypeKeys("<Down 2><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }

       
    }
}
