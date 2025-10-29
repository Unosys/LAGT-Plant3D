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
    public partial class PandIDOverrideValveOperatorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "$CustomizeValveOperatorWindow";// Tag = AcMainWin.cBabel(23055, 1, "Override Valve Operator");
        }
        public override void Invoke()
        {
            PropertiesPallete PropertiesPallete = new PropertiesPallete();
            PropertiesPallete.Invoke();
            PropertiesPallete.Move(10, 10);
            PropertiesPallete.SetSize(500, 1000);
            System.Threading.Thread.Sleep(2000);
            PropertiesPallete.ListBoxLB.Select(Plant3DFunctions.GetLocString("ValveOperator"));
            System.Threading.Thread.Sleep(2000);
            RECT r = PropertiesPallete.ValveOperator5.GetRect(true);
            Desktop Desktop = new Desktop();
            PropertiesPallete.ValveOperator5.DoubleClick(MouseButton.Left, r.xPos +10,r.yPos+10);
            Desktop.DoubleClick(MouseButton.Left, 456,302);
            System.Threading.Thread.Sleep(3000);
            if (PropertiesPallete.ButtonWIN5.Exists)
            {
                //PropertiesPallete.ButtonWIN5.DoubleClick(MouseButton.Left, 3, 3);
                Desktop.DoubleClick(MouseButton.Left, 546, 302);
            }
            else if (!PropertiesPallete.ButtonWIN5.Exists)
            {
                //RECT r6 = PropertiesPallete.ValveOperator6.GetRect(true);
                //Desktop.DoubleClick(MouseButton.Left, r6.xPos + 20, r6.yPos + 5);
                //System.Threading.Thread.Sleep(3000);
                //PropertiesPallete.ButtonWIN6.DoubleClick(MouseButton.Left, 3, 3);
                Desktop.DoubleClick(MouseButton.Left, 546, 302);
            }
            System.Threading.Thread.Sleep(2000);
            PandIDOverrideValveOperatorDLG PandIDOverrideValveOperatorDLG = new PandIDOverrideValveOperatorDLG();
            PandIDOverrideValveOperatorDLG.SetActive();
            //PandIDOverrideValveOperatorDLG.SetSize();
            AdResultLog.Current.Print(r);
        }

        public override void Dismiss()
        {
            PandIDOverrideValveOperatorDLG PandIDOverrideValveOperatorDLG = new PandIDOverrideValveOperatorDLG();
            PandIDOverrideValveOperatorDLG.SetActive();
            PandIDOverrideValveOperatorDLG.CancelPB.Click();
            if (PandIDOverrideValveOperatorDLG.Exists) {
                PandIDOverrideValveOperatorDLG.TypeKeys("<Alt-F4>");
            }
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_PROPERTIESCLOSE");
            Plant3DFunctions.DeleteDrawing("P3D");
        }
        public void SetSize()
        {
            RECT r = this.GetRect(true);
            if (r.xSize != 1270 && r.ySize != 700)
            {
                this.Click(MouseButton.Right, 10, 10);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos +1270, r.yPos + 700);
            }
        }
    }
}
