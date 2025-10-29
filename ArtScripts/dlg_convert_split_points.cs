using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using OptionSet;
using LAGT.CommonFiles;
using LAGT.CommonFiles.Constants;
using LAGT.CommonFiles.Entities;
using LAGT.CommonFiles.Extensions.CaptureBitmaps;
using LAGT.CommonFiles.Extensions.Rectangle;
using Autodesk.GUIHarness.AutoCAD;

namespace Autodesk.GUIHarness.Plant3D.ArtScripts
{
    public partial class dlg_convert_split_points : ConvertSplitPointsDLG
    {
        private List<string> steps;

        public dlg_convert_split_points() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "dlg_convert_split_points",//Name define by persons who edit scripts , excel?
                new List<string> {
				"GUID-1356D34E-3690-41FC-862B-8801F1EBCE51",

				//Add the GUID here
				},
                FYRelease.FY16
            );
            this.steps = new List<string> {
                "1. Wait for the balloon notification to show on Status Bar",
                "2. Click to bubble notification to view isometric creation details…"
            };
        }
        public override void Invoke()
        {
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.Size(1500,975);
            Plant3DFunctions.CreateDrawing("P3D");
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            Drawing.Current.TypeE("TRAYNOTIFY");
            Drawing.Current.TypeE("1");         
            Drawing.Current.TypeE("TRAYICONS");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("TRAYTIMEOUT");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("MENUBAR");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("_RIBBON");
            Drawing.Current.TypeE("_-OSNAP");
            Drawing.Current.TypeE("_MID");
            RibbonDialogClassP3D RibbonDialogClassP3D = new RibbonDialogClassP3D();
            RibbonDialogClassP3D.HomePB.Click(MouseButton.Left, 5, 5);
            HomeRibbonP3D HomeRibbonP3D = new HomeRibbonP3D();
            HomeRibbonP3D.PartInsertionPanel.LineNumberComboPL.Select("#0");
            System.Threading.Thread.Sleep(3000);
            AssignTag AssignTag = new AssignTag();
            AssignTag.SetActive();
            AssignTag.TextField1TF.SetText("102");
            AssignTag.AssignPB.Click();
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("50,50");
            Drawing.Current.TypeE("50,30");
            Drawing.Current.TypeE("");
            HomeRibbonP3D.PartInsertionPanel.LineNumberComboPL.Select("#0");
            AssignTag.SetActive();
            AssignTag.TextField1TF.SetText("104");
            AssignTag.AssignPB.Click();
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("0,0");
            Drawing.Current.TypeE("30,0");
            Drawing.Current.TypeE("");
            HomeRibbonP3D.PartInsertionPanel.LineNumberComboPL.Select("#0");
            AssignTag.SetActive();
            AssignTag.TextField1TF.SetText("105");
            AssignTag.AssignPB.Click();
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("10,10");
            Drawing.Current.TypeE("30,10");
            Drawing.Current.TypeE("");
            Drawing.Current.TypeE("_ZOOM");
            Drawing.Current.TypeE("_E");
            Drawing.Current.TypeE("_PLANTISOADDINFO");
            Drawing.Current.TypeE("_B");
            Desktop.Current.MoveMouse(1110, 300);
            Desktop.Current.Click(MouseButton.Left, 1110, 300);
            Drawing.Current.TypeE("_PLANTISOADDINFO");
            Drawing.Current.TypeE("_B");
            Desktop.Current.MoveMouse(650, 698);
            Desktop.Current.Click(MouseButton.Left, 650, 698);
            Drawing.Current.TypeE("_PLANTISOADDINFO");
            Drawing.Current.TypeE("_B");
            Desktop.Current.MoveMouse(580, 840);
            Desktop.Current.Click(MouseButton.Left, 580,840);
            Drawing.Current.TypeE("_PLANTQUICKISO");
            Drawing.Current.TypeE("_L");
            System.Threading.Thread.Sleep(2000);
            SelectQuickIsoDLG SelectQuickIsoDLG = new SelectQuickIsoDLG();
            SelectQuickIsoDLG.SetActive();
            SelectQuickIsoDLG.one02LBI.Click(MouseButton.Left, 3, 3);
            SelectQuickIsoDLG.one04LBI.Click(MouseButton.Left, 3, 3);
            SelectQuickIsoDLG.one05LBI.Click(MouseButton.Left, 3, 3);
            SelectQuickIsoDLG.CreatePB.Click();
            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            System.Threading.Thread.Sleep(2000);
            IsometricCreationResultsDLG IsometricCreationResultsDLG = new IsometricCreationResultsDLG();
            IsometricCreationResultsDLG.SetActive();
            IsometricCreationResultsDLG.ConvertSplitPointsPB.Click();
            ConvertSplitPointsDLG ConvertSplitPointsDLG = new ConvertSplitPointsDLG();
            ConvertSplitPointsDLG.Click(MouseButton.Left, 130,190);
            ConvertSplitPointsDLG.Click(MouseButton.Left, 240,190);
            ConvertSplitPointsDLG.Click(MouseButton.Left, 315,190);



        }
        public override void Capture(string SaveLocation)
        {

            ConvertSplitPointsDLG ConvertSplitPointsDLG = new ConvertSplitPointsDLG();
            ConvertSplitPointsDLG.CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension);


        }

        public override void Dismiss()
        {

            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            AppWnd.Size(653, 635);
            base.Dismiss();

            Drawing.Current.TypeE("TRAYNOTIFY");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("TRAYICONS");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("TRAYTIMEOUT");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("MENUBAR");
            Drawing.Current.TypeE("1");
            Drawing.Current.TypeE("_RIBBONCLOSE");
            Plant3DFunctions.DeleteAllDrawings();
        }

    }
}
