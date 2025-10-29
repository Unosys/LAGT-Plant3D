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
using System;
using System.IO;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PropertyGridDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$propertyGridDockPanel1";

        }

        public override void Invoke()
        {

            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportDesignerApplicationDLG.Invoke();
            ReportDesignerApplicationDLG.TypeKeys("<Ctrl-n>");
            System.Threading.Thread.Sleep(5000);
            PropertyGridDLG PropertyGridDLG = new PropertyGridDLG();
            ReportDesignerApplicationDLG.RibbonTabsPG.Select(3);//View tab
            System.Threading.Thread.Sleep(2000);
            ReportDesignerApplicationDLG.WindowsMI.Click();
            System.Threading.Thread.Sleep(3000);
            ReportDesignerApplicationDLG.TypeKeys("<Down 3><Space>");
            if (!PropertyGridDLG.Exists)
            {
                ReportDesignerApplicationDLG.RibbonTabsPG.Select(3);//View tab
                System.Threading.Thread.Sleep(2000);
                ReportDesignerApplicationDLG.WindowsMI.Click();
                System.Threading.Thread.Sleep(3000);
                ReportDesignerApplicationDLG.TypeKeys("<Down 3><Space>");
            }

            this.SetSize();


        }

        public override void Dismiss()
        {

            this.Close();
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportDesignerApplicationDLG.Dismiss();

        }
        public void SetSize()
        {
            ReportDesignerPropertiesDLG ReportDesignerPropertiesDLG = new ReportDesignerPropertiesDLG();

            RECT r = ReportDesignerPropertiesDLG.GetRect(true);
            Desktop.Current.MoveMouse(r.xPos, r.yPos + 5);
            Desktop.Current.Click(MouseButton.Left, r.xPos, r.yPos + 5);
            System.Threading.Thread.Sleep(5000);
            Desktop.Current.BeginDragAt(MouseButton.Left, r.xPos, r.yPos + 5);
            Desktop.Current.DragMouse(MouseButton.Left, r.xPos, r.yPos + 5, r.xPos - 300, r.yPos + 5);
            Desktop.Current.EndDragAt(r.xPos - 300, r.yPos + 5);

            //Desktop.Current.PressMouse(MouseButton.Left, r.xPos, r.yPos);
            //Desktop.Current.ReleaseMouse(MouseButton.Left, r.xPos-300, r.yPos);


        }
        public void Close()
        {
            ReportDesignerPropertiesDLG ReportDesignerPropertiesDLG = new ReportDesignerPropertiesDLG();

            RECT r = ReportDesignerPropertiesDLG.GetRect(true);
            Desktop.Current.Click(MouseButton.Right, r.xPos + 5, r.yPos + 5);
            Desktop.Current.TypeKeys("<Up><Enter>");


        }
    }
}
