using System;
using System.Windows;
using System.Windows.Input;
using LAGT.CommonFiles.Classes;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using Microsoft.Win32;
using LAGT.CommonFiles;
using System.Diagnostics;
using Newtonsoft.Json;
using Autodesk.GUIHarness.Core;
using System.Drawing;
using System.Threading;
using System.Linq.Expressions;
//using System.Web.Script.Serialization;
//using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;

namespace Autodesk.GUIHarness.Plant3D
{
    public static class Plant3DFunctions
    {

        public static void ExpandTreeP3D(Window wWind, int aDown, string lsArgs)
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            System.Threading.Thread.Sleep(1000);
            PROJECTMANAGERDLG.SetActive();
            wWind.Click(MouseButton.Right, 1, 1); //set active            
            wWind.TypeKeys("<Esc><home><Add>");
            System.Threading.Thread.Sleep(1000);

            //parse arguments
            string[] lsTree = lsArgs.Split(','); //split output to a list
            foreach (string sTree in lsTree)
            {
                bool bFound = false;
                int iTemp;
                bFound = Int32.TryParse(sTree, out iTemp);
                //ResultLog.Current.Log(iTemp);
                if (bFound == true)
                {
                    while (iTemp > 0)
                    {
                        wWind.TypeKeys("<down>");
                        System.Threading.Thread.Sleep(1000);
                        wWind.TypeKeys("<Subtract>");
                        iTemp--;
                    }
                }
                else
                {
                    wWind.TypeKeys(sTree);
                }
                wWind.TypeKeys("<Add>");
            }
            RECT rTree = wWind.GetRect();
            //rTree = wWind.GetRect();
            System.Threading.Thread.Sleep(5000);
            //wWind.Click(MouseButton.Right, 5, 100);
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
                case "CHS":
                    if (lsTree.Length.Equals(2))
                    {
                        wWind.Click(MouseButton.Right, 5, 50);
                    }
                    else if (lsTree.Length.Equals(3))
                    {
                        wWind.Click(MouseButton.Right, 5, 65);
                    }
                    else
                    {
                        PROJECTMANAGERDLG.DefaultProjectTVI.Click(MouseButton.Right);
                    }
                    break;
                default:
                    if (lsTree.Length.Equals(2))
                    {
                        wWind.Click(MouseButton.Right, 5, 45);

                    }
                    else if (lsTree.Length.Equals(3))
                    {
                        wWind.Click(MouseButton.Right, 5, 65);

                    }
                    else
                    {
                        PROJECTMANAGERDLG.DefaultProjectTVI.Click(MouseButton.Right);
                    }
                    break;
            }

            System.Threading.Thread.Sleep(1000);
            //wWind.TypeKeys("<Shift-F10>");
            System.Threading.Thread.Sleep(1000);
            while (aDown > 0)
            {
                wWind.TypeKeys("<down>");
                aDown--;
            }
            wWind.TypeKeys("<enter>");
        }
        public static void ExpandTreeOrtho(Window wWind, int aDown, string lsArgs)
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetTab(2);
            wWind.Click(MouseButton.Right, 1, 1); //set active            
            wWind.TypeKeys("<Esc><home><Add>");
            System.Threading.Thread.Sleep(1000);

            //parse arguments
            string[] lsTree = lsArgs.Split(','); //split output to a list
            foreach (string sTree in lsTree)
            {
                bool bFound = false;
                int iTemp;
                bFound = Int32.TryParse(sTree, out iTemp);
                //ResultLog.Current.Log(iTemp);
                if (bFound == true)
                {
                    while (iTemp > 0)
                    {
                        wWind.TypeKeys("<down>");
                        System.Threading.Thread.Sleep(1000);
                        wWind.TypeKeys("<Subtract>");
                        iTemp--;
                    }
                }
                else
                {
                    wWind.TypeKeys(sTree);
                }
                wWind.TypeKeys("<Add>");
            }
            RECT rTree = wWind.GetRect();
            System.Threading.Thread.Sleep(5000);
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                //case "RUS":
                //case "CHS":

                //    break;
                default:
                    if (lsTree.Length.Equals(2))
                    {

                        wWind.Click(MouseButton.Right, 50, 25);//OrthographicDrawingsTV

                    }
                    else if (lsTree.Length.Equals(3))
                    {
                        wWind.Click(MouseButton.Right, 5, 45);//Default->OrthographicDrawings->Area1PlanTV

                    }
                    else if (lsTree.Length.Equals(4))
                    {
                        wWind.Click(MouseButton.Right, 5, 65);//Default->OrthographicDrawings->Area1PlanTV->TopPlanViewTVI

                    }
                    else
                    {
                        PROJECTMANAGERDLG.DefaultProjectTVI.Click(MouseButton.Right);
                    }
                    break;
            }

            System.Threading.Thread.Sleep(1000);
            while (aDown > 0)
            {
                wWind.TypeKeys("<down>");
                aDown--;
            }
            wWind.TypeKeys("<enter>");
        }

        public static void RightClickTreeP3D(TreeView wWind, string contextMenu1 = "", string contextMenu2 = "", bool treeItemMain = false, int treeItem1 = 0, int treeItem2 = 0, int treeItem3 = 0, int treeItem4 = 0,
           int treeItem5 = 0, int treeItem6 = 0, int treeItem7 = 0, int treeItem8 = 0, int treeItem9 = 0, int treeItem10 = 0)
        {
            string pTTag = "";
            int[] treeItem = new int[10];
            treeItem[0] = treeItem1;
            treeItem[1] = treeItem2;
            treeItem[2] = treeItem3;
            treeItem[3] = treeItem4;
            treeItem[4] = treeItem5;
            treeItem[5] = treeItem6;
            treeItem[6] = treeItem7;
            treeItem[7] = treeItem8;
            treeItem[8] = treeItem9;
            treeItem[9] = treeItem10;
            int selIdex = 0;
            Dialogs.Plant3D appwed = new Dialogs.Plant3D();
            var ProjManUndocked = new ProjManUndocked();

            switch (wWind.ParentType.Name.ToString())
            {
                case "ProjManUndocked":
                    pTTag = ProjManUndocked.Tag;
                    break;
                default:
                    break;
            }
            System.Threading.Thread.Sleep(5000);
            wWind.SetActive();
            wWind.CollapseAll();
            //wWind.Expand(0);
            wWind.SetActive();
            System.Threading.Thread.Sleep(2000);
            wWind.Select(0);
            System.Threading.Thread.Sleep(2000);

            if (!treeItemMain)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (treeItem[i] != 0)
                    {
                        wWind.SetActive();
                        //Desktop.Current.TypeKeys("<Right>");
                        wWind.TypeKeys("<Right>");
                        System.Threading.Thread.Sleep(2000);
                        for (int j = 0; j < treeItem[i]; j++)
                        {
                            //Desktop.Current.TypeKeys("<Down>");
                            //Desktop.Current.TypeKeys("<Subtract>");
                            wWind.TypeKeys("<Down>");
                            wWind.TypeKeys("<Subtract>");
                        }
                    }
                }
            }
            System.Threading.Thread.Sleep(2000);
            for (int i = 0; i < 10; i++)
            {
                selIdex = treeItem[i] + selIdex;
            }

            for (int j = 0; j < 2; j++)
            {
                wWind.Select(selIdex);
                System.Threading.Thread.Sleep(1500);
                if (!wWind.Exists)
                {
                    return;
                }
                else
                {
                    if (!wWind.IsEnabled)
                    {
                        return;
                    }
                }
            }
            RECT item = wWind.GetItemRect(selIdex);
            wWind.Click(MouseButton.Right, item.xPos + 5, item.yPos + 5);
            
            //Point pMouseButton = Cursor.Position;
            ////Point pMouseButton = System.Windows.Forms.Control.MousePosition;
            //Desktop.Current.Click(MouseButton.Right, pMouseButton.X, pMouseButton.Y);
            System.Threading.Thread.Sleep(1500);
            Desktop.Current.TypeKeys("<Down " + contextMenu1 + ">", 250);
            System.Threading.Thread.Sleep(1500);
            if (!string.IsNullOrEmpty(contextMenu2))
            {
                contextMenu2 = (Convert.ToInt32(contextMenu2) - 1).ToString();
                Desktop.Current.TypeKeys("<Right><Down " + contextMenu2 + "><Enter>", 250);
            }
            else
            {
                
                Desktop.Current.TypeKeys("<Enter>");

            }
            System.Threading.Thread.Sleep(1500);
        }
        public static void CreateDrawing(string sProjectDrawing = null, string sDefaultTemplate = null, string Title = null, string No = null)
        {
            // print("creating {sProjectDrawing} drawing {Title} with {sDefaultTemplate} template")
            if (Title == null)
            {
                Title = DateTime.Now.ToString();
                Title = Title.Replace(":", "_").Replace("/", "_");
            }
            if (No == null)
            {
                No = "01";
            }
            //Drawing.Current.TypeE("SDI 0");
            Drawing.Current.SetSysVar("SDI", 0);
            Drawing.Current.TypeE("_DYNMODE -3");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            //PROJECTMANAGERDLG.TreeViewTV.Select (AcMainWin.cBabel(23039,2,"Default Project"));
            if (sDefaultTemplate == null)
            {
                sDefaultTemplate = "no";
            }
            NewDWGDLG NewDWGDLG = new NewDWGDLG();
            P3DSelectTemplateFileDLG P3DSelectTemplateFileDLG = new P3DSelectTemplateFileDLG();
            //ResultLog.Current.Log(P3DSelectTemplateFileDLG.Tag);
            if (sProjectDrawing == "P3D")
            {
                ExpandTreeP3D(wTreeView, 1, "0,2");
                if (sDefaultTemplate == "no")
                {
                    System.Threading.Thread.Sleep(2000);
                    NewDWGDLG.M_dwtBrowseButton.Click();
                    //P3DSelectTemplateFileDLG.FileName.ClearText();
                    // P3DSelectTemplateFileDLG.FileName.SetText("{AppWnd.GetFullTemplatePath("acad.dwt")}") 
                    P3DSelectTemplateFileDLG.FileName.Click();
                    P3DSelectTemplateFileDLG.TypeKeys("acad.dwt");
                    P3DSelectTemplateFileDLG.Open.Click();
                }
            }
            if (sProjectDrawing == "PID")
            {
                //ExpandTreeP3D(wTreeView,1,"0,1");
                PROJECTMANAGERDLG.PIDDrawingsTVI.Click(MouseButton.Right);
                Desktop.Current.TypeKeys("<Down 1><Enter>");
                if (sDefaultTemplate == "no")
                {
                    NewDWGDLG.M_dwtBrowseButton.Click();
                    P3DSelectTemplateFileDLG.FileName.SetText("acad.dwt");
                    P3DSelectTemplateFileDLG.Open.Click();
                }
            }
            if (NewDWGDLG.M_tb_filename.Exists)
            {
                NewDWGDLG.M_tb_filename.SetText(Title);
            }
            NewDWGDLG.BtnOK.Click();
            WarningDLG WarningDLG = new WarningDLG();
            FileExistsDLG FileExistsDLG = new FileExistsDLG();
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            DWGTitleExistsDLG DWGTitleExistsDLG = new DWGTitleExistsDLG();
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            System.Threading.Thread.Sleep(2000);
            if (WarningDLG.Exists)
            {
                WarningDLG.OK.Click();
            }
            if (FileExistsDLG.Exists)
            {
                FileExistsDLG.TypeKeys("<Enter>");
                System.Threading.Thread.Sleep(2000);
            }
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.OK.Click();
                if (NewDWGDLG.Exists)
                {
                    NewDWGDLG.BtnCancel.Click();
                }
            }
            if (ProjectDataMergedDLG.Exists)
            {
                ProjectDataMergedDLG.SetActive();
                ProjectDataMergedDLG.BtnOk.Click();
            }
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.TypeKeys("<enter>");
            }
            if (DWGTitleExistsDLG.Exists)
            {
                DWGTitleExistsDLG.SetActive();
                DWGTitleExistsDLG.OK.Click();
                NewDWGDLG.BtnCancel.Click();
            }
            //Drawing.Current.TypeE("SDI 1");
            Drawing.Current.SetSysVar("SDI", 1);
            Drawing.Current.TypeKeys("<Esc>");
            PROJECTMANAGERDLG.SetActive();
            wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            if (sProjectDrawing == "P3D")
            {
                ExpandTreeP3D(wTreeView, 1, "0,2,1");
            }
            else
            {
                RightClickTreeP3D(PROJECTMANAGERDLG.TreeViewTV, "1", "", false, 1, 1);
                //// ExpandTreeP3D(wTreeView,1,"0,1,1");
                //Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
                //RECT wWind = WTreeView.GetRect();
                //if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
                //{
                //    WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 55);
                //}
                //else
                //{
                //    WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 60);
                //}

                //Desktop.Current.TypeKeys("<Down 1><Enter>");
            }
            System.Threading.Thread.Sleep(5000);
            if (WarningAutoCADDLG.Exists)
            {
                WarningAutoCADDLG.No.Click();
            }
            //restart logging for CMDs
            //ResultLog.Current.Log(LAGT.CommonFiles.AutomationTests.Variables.AutomationType);
            if (LAGT.CommonFiles.AutomationTests.Variables.AutomationType == "CMDOPT")
            {
                CmdOpt_Engine.StartLog();
            }
        }
        public static void CreateOrthoDrawingColurStyle(string Title = null)
        {
            if (Title == null)
            {
                Title = DateTime.Now.ToString();
                Title = Title.Replace(":", "_").Replace("/", "_");
            }
            string Path = new AcMainWin().RoamableRootFolder + "DefaultProject\\Orthos\\Styles\\Default\\Ortho - D -Color Dependent Plot Styles.dwt";
            //Drawing.Current.TypeE("SDI 0");
            Drawing.Current.SetSysVar("SDI", 0);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.Invoke();
            //PROJECTMANAGERDLG.Undock ();
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetTab(2);
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.OrthoTreeViewTV.TypeKeys("<home>");
            Window wTreeView = PROJECTMANAGERDLG.OrthoTreeViewTV;
            //PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1");
            Plant3DFunctions.ExpandTreeOrtho(wTreeView, 2, "0,1");//New Drawing...

            System.Threading.Thread.Sleep(2000);
            NewDWGDLG NewDWGDLG = new NewDWGDLG();
            NewDWGDLG.M_tb_filename.SetText(Title);
            NewDWGDLG.M_dwtBrowseButton.Click();
            P3DSelectTemplateFileDLG P3DSelectTemplateFileDLG = new P3DSelectTemplateFileDLG();
            P3DSelectTemplateFileDLG.FileName.SetText(Path);
            P3DSelectTemplateFileDLG.Open.Click();
            System.Threading.Thread.Sleep(2000);
            NewDWGDLG.BtnOK.Click();
            FileExistsDLG FileExistsDLG = new FileExistsDLG();
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
            WarningDLG WarningDLG = new WarningDLG();
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            DWGTitleExistsDLG DWGTitleExistsDLG = new DWGTitleExistsDLG();
            System.Threading.Thread.Sleep(2000);
            if (FileExistsDLG.Exists)
            {
                FileExistsDLG.TypeKeys("<Enter>");
            }
            System.Threading.Thread.Sleep(1000);
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.OK.Click();
                System.Threading.Thread.Sleep(1000);
                if (NewDWGDLG.Exists)
                {
                    NewDWGDLG.BtnCancel.Click();
                    // DeleteAllDrawings ();
                    Plant3DFunctions.CreateDrawing("P3D");
                }
            }
            if (WarningDLG.WaitExists(1000))
            {
                WarningDLG.OK.Click();
            }
            if (ProjectDataMergedDLG.WaitExists(1000))
            {
                ProjectDataMergedDLG.SetActive();
                ProjectDataMergedDLG.BtnOk.Click();
            }
            if (DrawingAlreadyExistsDLG.WaitExists(1000))
            {
                DrawingAlreadyExistsDLG.TypeKeys("<enter>");
            }
            if (DWGTitleExistsDLG.WaitExists(1000))
            {
                DWGTitleExistsDLG.SetActive();
                DWGTitleExistsDLG.OK.Click();
                NewDWGDLG.BtnCancel.Click();
            }
            System.Threading.Thread.Sleep(5000);
            Drawing.Current.SetSysVar("SDI", 1);

            PROJECTMANAGERDLG.SetTab(2);
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();

            if (WarningAutoCADDLG.WaitExists(2000))
            {
                WarningAutoCADDLG.No.Click();
            }
            System.Threading.Thread.Sleep(6000);
            PROJECTMANAGERDLG.SetTab(1);// .DoubleClick (1, rPaletteWnd.xSize-10,rPaletteWnd.ySize/5);
            ResultLog.Current.Log(LAGT.CommonFiles.AutomationTests.Variables.AutomationType);
            if (LAGT.CommonFiles.AutomationTests.Variables.AutomationType == "CMDOPT")
            {
                CmdOpt_Engine.StartLog();
            }
        }
        public static void DeleteOrthoDrawing(string sProjectDrawing = null)
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetTab(2);
            Window wTreeView = PROJECTMANAGERDLG.OrthoTreeViewTV;
            //Plant3DFunctions.ExpandTreeP3D(wTreeView, 2, "0,1,1");//7
            //RECT wWind = wTreeView.GetRect();
            //wTreeView.Click(MouseButton.Right, 5, wWind.ySize - 60);
            //System.Threading.Thread.Sleep(4000);
            //Desktop.Current.TypeKeys("<Down 7><Enter>");
            //System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.OrthoDefaultProjectTVI.Select();
            wTreeView.TypeKeys("<Home><Add><Down><Subtract><Add>");
            System.Threading.Thread.Sleep(2000);
            wTreeView.Click(MouseButton.Right, 5, 45);
            System.Threading.Thread.Sleep(1000);
            try
            {
                PROJECTMANAGERDLG.OrthoRemoveDrawingMI.Pick();
            }
            catch
            {
                //Plant3DFunctions.ExpandTreeOrtho(wTreeView, 3, "0,1,1");//Remove Drawing...
            }
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.TypeKeys("<Enter>");
            var RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
            System.Threading.Thread.Sleep(1000);
            if (RemoveDrawingsFromProjectDLG.Exists)
            {
                RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                System.Threading.Thread.Sleep(100);
            }
            System.Threading.Thread.Sleep(2000);
            var RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();
            if (RemoveDrawingFromProjectDLG.Exists)
            {
                RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(1000);
            PROJECTMANAGERDLG.SetTab(1);
        }

        public static void DeleteDrawing(string sProjectDrawing = null)
        {
            Desktop.Current.TypeKeys("<Esc 2>");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //wTreeView.Click(MouseButton.Left, 1, 1);
            //// PID drawings
            //PROJECTMANAGERDLG.TypeKeys("<Home>");

            RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
            RemoveDrawingFromProjectDLG RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();

            if (sProjectDrawing == "PID")
            {
                PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1,1");//4 for FY24
                if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                    System.Threading.Thread.Sleep(1000);
                }
                if (RemoveDrawingFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                    System.Threading.Thread.Sleep(1000);
                }
                System.Threading.Thread.Sleep(100);
            }
            else if (sProjectDrawing == "P3D")
            {
                System.Threading.Thread.Sleep(1000);
                // P3D drawings
                PROJECTMANAGERDLG.Plant3DDrawingsTVI.Click();
                PROJECTMANAGERDLG.Plant3DDrawingsTVI.TypeKeys("<Add>");
                PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
                string sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
                string sName2 = PROJECTMANAGERDLG.RelatedFilesTVI.Text;
                while (sName != sName2) //while (sName != "Related Files")
                {
                    if (sName.Equals(AcMainWin.cBabel(23073, 25, "Pipe Specs")) || sName.Equals(Plant3DFunctions.GetLocString("PipeSpecs")))
                    {
                        break;
                    }
                    Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "0,2,1");//4 for FY24
                    if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
                    {
                        RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                        System.Threading.Thread.Sleep(100);
                    }
                    if (RemoveDrawingFromProjectDLG.WaitExists(2000))
                    {
                        RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                        System.Threading.Thread.Sleep(1000);
                    }

                    System.Threading.Thread.Sleep(4000);
                    PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
                    sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
                    if (sName2.Equals(AcMainWin.cBabel(23073, 25, "Pipe Specs")) || sName.Equals(Plant3DFunctions.GetLocString("PipeSpecs")))
                    {
                        break;
                    }
                }
            }

        }
        public static void DeleteAllDrawings()
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            //PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            wTreeView.Click(MouseButton.Left, 1, 1);
            // PID drawings
            PROJECTMANAGERDLG.PIDDrawingsTVI.Click();
            PROJECTMANAGERDLG.PIDDrawingsTVI.TypeKeys("<Add>");
            RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
            //ResultLog.Current.Log(RemoveDrawingsFromProjectDLG.Tag);
            PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
            string sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
            string sName2 = PROJECTMANAGERDLG.Plant3DDrawingsTVI.Text;
            //ResultLog.Current.Log(sName);
            while (sName != sName2) //while (sName != "Plant 3D Drawings")
            {
                //Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");             
                Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
                RECT wWind = WTreeView.GetRect();
                if (LAGT.CommonFiles.Product.Variables.Language == "CHS")
                {   /*WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 50);*/
                    WTreeView.Click(MouseButton.Right, 5, 45);
                }
                else
                {
                    WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 60);//60 FY24
                }

                Desktop.Current.TypeKeys("<Down 3><Enter>");//3 for FY24
                if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                    System.Threading.Thread.Sleep(100);
                }
                RemoveDrawingFromProjectDLG RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();
                if (RemoveDrawingFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                    System.Threading.Thread.Sleep(1000);
                }
                System.Threading.Thread.Sleep(100);

                PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
                sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
                //ResultLog.Current.Log(sName);
            }
            System.Threading.Thread.Sleep(1000);
            // P3D drawings
            PROJECTMANAGERDLG.Plant3DDrawingsTVI.Click();
            PROJECTMANAGERDLG.Plant3DDrawingsTVI.TypeKeys("<Add>");
            PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
            sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
            sName2 = PROJECTMANAGERDLG.RelatedFilesTVI.Text;
            //ResultLog.Current.Log(sName);
            while (sName != sName2) //while (sName != "Related Files")
            {
                if (sName.Equals(AcMainWin.cBabel(23073, 25, "Pipe Specs")) || sName.Equals(Plant3DFunctions.GetLocString("PipeSpecs")))
                {
                    break;
                }

                Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "0,2,1");//remove
                //PROJECTMANAGERDLG.SetActive();
                //PROJECTMANAGERDLG.TreeViewTV.Click(MouseButton.Right,807,163);
                //Desktop.Current.TypeKeys("<Down 4><Enter>");
                if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                    System.Threading.Thread.Sleep(100);
                }
                RemoveDrawingFromProjectDLG RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();
                if (RemoveDrawingFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                    System.Threading.Thread.Sleep(1000);
                }

                System.Threading.Thread.Sleep(4000);
                PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
                sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
                if (sName2.Equals(AcMainWin.cBabel(23073, 25, "Pipe Specs")) || sName.Equals(Plant3DFunctions.GetLocString("PipeSpecs")))
                {
                    break;
                }
            }
            //ResultLog.Current.Log(sName);

            System.Threading.Thread.Sleep(100);
        }


        public static void CopyDrawing(string sDrawingName)
        {
            ProjManUndocked projectmanagerDLG = new ProjManUndocked();
            projectmanagerDLG.SetActive();
            Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,2");
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + sDrawingName);
            SelectDrawingsToCopyToProDLG.Open.Click();
            AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
            if (AutoCADPlant3DMigrationDLG.WaitExists(2000))
            {
                AutoCADPlant3DMigrationDLG.BackupTheDrawingBeforeCK.Uncheck();
                Desktop.Current.TypeKeys("<enter>"); //close migration
            }
            Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();           
            var Plant3DProjectDrawingsContainExternalReferencesDLG = new Plant3DProjectDrawingsContainExternalReferencesDLG();
            if (Plant3DProjectDrawingsContainExternalReferencesDLG.WaitExists(3000))
            {
                Plant3DProjectDrawingsContainExternalReferencesDLG.SetActive();
                Plant3DProjectDrawingsContainExternalReferencesDLG.CopyExternalReferencesToPB.Click();
            }
            System.Threading.Thread.Sleep(8000);
            if (Plant3DProjectSomeFilesDLG.WaitExists(3000))
            {
                Plant3DProjectSomeFilesDLG.SetActive();
                Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            }

            Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 1, "0,2,1");
            //restart logging for CMDs
            ResultLog.Current.Log(LAGT.CommonFiles.AutomationTests.Variables.AutomationType);
            if (LAGT.CommonFiles.AutomationTests.Variables.AutomationType == "CMDOPT")
            {
                CmdOpt_Engine.StartLog();
            }
            //TBD
            //ResultLog.Current.Log("Function CopyDrawing not implemented yet");
        }
        public static void CopyDrawing(string sDrawingName, string Project)
        {
            Plant3DMainWin Plant3DMainWin = new Plant3DMainWin();
            Plant3DMainWin.SetActive();
            ProjManUndocked projectmanagerDLG = new ProjManUndocked();
            projectmanagerDLG.SetActive();
            string DwgPath;
            string DwgTree;
            if (Project == "P3D")
            {
                Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,2");
                DwgPath = LAGT.CommonFiles.Product.Variables.TestFilesDir;
                DwgTree = "0,2,1";
            }
            else //PID
            {
                Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,1");
                DwgPath = "c:\\LAGT\\PandID\\TestFiles\\";
                DwgTree = "0,1,1";
            }
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.TypeKeys(DwgPath + sDrawingName);
            SelectDrawingsToCopyToProDLG.Open.Click();
            AutoCADPIDMigrationDLG AutoCADPIDMigrationDLG = new AutoCADPIDMigrationDLG();
            Plant3DProjectSomeFilesDLG Plant3DProjectSomeFilesDLG = new Plant3DProjectSomeFilesDLG();
            if (AutoCADPIDMigrationDLG.WaitExists(10000))
            {
                AutoCADPIDMigrationDLG.ChkboxBackup.Uncheck();
                Desktop.Current.TypeKeys("<enter>"); //start migration

                if (Plant3DProjectSomeFilesDLG.WaitExists(3000))
                {
                    Plant3DProjectSomeFilesDLG.SetActive();
                    Plant3DProjectSomeFilesDLG.M_btnOk.Click();
                }
                System.Threading.Thread.Sleep(2000);
                Desktop.Current.TypeKeys("<enter>"); //close migration
            }

            if (Plant3DProjectSomeFilesDLG.WaitExists(3000))
            {
                Plant3DProjectSomeFilesDLG.SetActive();
                Plant3DProjectSomeFilesDLG.M_btnOk.Click();
            }
            System.Threading.Thread.Sleep(2000);

            //Plant3DFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 1, DwgTree);
            //restart logging for CMDs
            //ResultLog.Current.Log(LAGT.CommonFiles.AutomationTests.Variables.AutomationType);
            if (LAGT.CommonFiles.AutomationTests.Variables.AutomationType == "CMDOPT")
            {
                CmdOpt_Engine.StartLog();
            }
            //TBD
            //ResultLog.Current.Log("Function CopyDrawing not implemented yet");
        }
        public static void SetupTitleBlock()
        {
            IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
            IsometricDWGSettingsTitleBlockandDisplayDLG.Invoke();
            IsometricDWGSettingsTitleBlockandDisplayDLG.SetupTitleBlockPB.Click();
        }
        public static void SetupTitleBlockClose()
        {
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeKeys("<Esc>");
            Drawing.Current.TypeE("_PLANTISOTBCLOSE");
            BlockChangesNotSavedDLG BlockChangesNotSavedDLG = new BlockChangesNotSavedDLG();
            BlockChangesNotSavedDLG2 BlockChangesNotSavedDLG2 = new BlockChangesNotSavedDLG2();
            IsometricDWGSettingsTitleBlockandDisplayDLG IsometricDWGSettingsTitleBlockandDisplayDLG = new IsometricDWGSettingsTitleBlockandDisplayDLG();
            if (BlockChangesNotSavedDLG.WaitExists(2000))
            {
                BlockChangesNotSavedDLG.TypeKeys("<Tab 2><Enter>");
                Drawing.Current.TypeE("_PLANTISOTBCLOSE");
            }
            if (BlockChangesNotSavedDLG.WaitExists(2000))
            {
                BlockChangesNotSavedDLG.TypeKeys("<Tab><Enter>");
            }
            //PushButton DiscardBtn = new DialogBox("#1").PushButton("Discard the changes and close the Block Editor|$CommandLink_1002|#2");
            //if (DiscardBtn.Exists)
            //{
            //    DiscardBtn.Click();
            //}
            if (BlockChangesNotSavedDLG2.WaitExists(2000))
            {
                BlockChangesNotSavedDLG2.SetActive();
                BlockChangesNotSavedDLG2.DiscardTheChangesAndPB.Click();
            }
            //if (BlockChangesNotSavedDLG.WaitExists(2000))
            //    BlockChangesNotSavedDLG.TypeKeys("<Tab><Enter>");
            //if(BlockSaveParameterChangesDLG.exists(2))
            //  BlockSaveParameterChangesDLG.typekeys("<tab><Enter>")

            System.Threading.Thread.Sleep(20000);
            if (IsometricDWGSettingsTitleBlockandDisplayDLG.WaitExists(2000))
            {
                IsometricDWGSettingsTitleBlockandDisplayDLG.Dismiss();
                System.Threading.Thread.Sleep(10000);
            }
        }
        public static void InvokeCentrifugalBlower()
        {
            //TBD
            ResultLog.Current.Log("Function InvokeCentrifugalBlower not implemented yet");
        }
        public static void InitDataManagerToolbarSize(Window wDlg)
        {
            //TBD
            ResultLog.Current.Log("Function InitDataManagerToolbarSize not implemented yet");
        }
        public static void InitDlgSize(Window wDlg = null, int itimesx = 0, int itimesy = 0)
        {
            //TBD
            ResultLog.Current.Log("Function InitDlgSize not implemented yet");
        }
        public static void CreateDrawingWithAnObject(string sProjectDrawing, string Title, string No)
        {
            //TBD
            ResultLog.Current.Log("Function CreateDrawingWithAnObject not implemented yet");
        }
        public static void CreateNewProject()
        {
            //TBD
            ResultLog.Current.Log("Function CreateNewProject not implemented yet");
        }
        public static void SelectToolPaletteTab(int iTabPos) //used in vine
        {
            //TBD
            ResultLog.Current.Log("Function SelectToolPaletteTab not implemented yet");
        }
        public static void LinkDrawing(string FilenameForOffPageConnector)
        {
            //TBD
            ResultLog.Current.Log("Function LinkDrawing not implemented yet");
        }
        public static void CreateProject(string ProjectName)
        {
            //TBD
            ResultLog.Current.Log("Function CreateProject not implemented yet");
        }
        public static void CreateOrthoDrawing(string Title)
        {
            //TBD
            //ResultLog.Current.Log("Function CreateOrthoDrawing not implemented yet");

            if (Title == null)
            {
                Title = DateTime.Now.ToString();
                Title = Title.Replace(":", "_").Replace("/", "_");
            }

            Drawing.Current.SetSysVar("SDI", 0);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.Invoke();
            //PROJECTMANAGERDLG.Undock ();
            PROJECTMANAGERDLG.SetTab(2);
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.OrthoTreeViewTV.TypeKeys("<home>");
            Window wTreeView = PROJECTMANAGERDLG.OrthoTreeViewTV;
            //Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,1");

            Window OrthographicDrawings = PROJECTMANAGERDLG.OrthographicDrawingsTVI;
            RECT OrthographicDraw = OrthographicDrawings.GetRect();
            OrthographicDrawings.TypeKeys("<Add>");
            OrthographicDrawings.Click(MouseButton.Right, 5, OrthographicDraw.ySize - 5);
            System.Threading.Thread.Sleep(1000);
            OrthographicDrawings.TypeKeys("<Down 2><Enter>");//new drawing

            NewDWGDLG NewDWGDLG = new NewDWGDLG();

            System.Threading.Thread.Sleep(2000);
            NewDWGDLG.M_tb_filename.SetText(Title);
            NewDWGDLG.BtnOK.Click();

            WarningDLG WarningDLG = new WarningDLG();
            FileExistsDLG FileExistsDLG = new FileExistsDLG();
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            DWGTitleExistsDLG DWGTitleExistsDLG = new DWGTitleExistsDLG();
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            System.Threading.Thread.Sleep(2000);
            if (WarningDLG.Exists)
            {
                WarningDLG.OK.Click();
            }
            if (FileExistsDLG.Exists)
            {
                FileExistsDLG.TypeKeys("<Enter>");
            }
            System.Threading.Thread.Sleep(2000);
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.OK.Click();
                NewDWGDLG.M_tb_filename.ClearText();
                NewDWGDLG.M_tb_filename.SetText(Title);
                NewDWGDLG.BtnOK.Click();
                if (FileExistsDLG.Exists)
                {
                    FileExistsDLG.TypeKeys("<Enter>");
                }
            }
            if (ProjectDataMergedDLG.Exists)
            {
                ProjectDataMergedDLG.SetActive();
                ProjectDataMergedDLG.BtnOk.Click();
            }
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.TypeKeys("<enter>");
            }
            if (DWGTitleExistsDLG.Exists)
            {
                DWGTitleExistsDLG.SetActive();
                DWGTitleExistsDLG.OK.Click();
                NewDWGDLG.BtnCancel.Click();
            }
            //Drawing.Current.TypeE("SDI 1");
            Drawing.Current.SetSysVar("SDI", 1);
            PROJECTMANAGERDLG.SetActive();
            PROJECTMANAGERDLG.SetTab(2);
            PROJECTMANAGERDLG.OrthoTreeViewTV.TypeKeys("<home>");
            wTreeView = PROJECTMANAGERDLG.OrthoTreeViewTV;
            PROJECTMANAGERDLG.SetActive();
            PROJECTMANAGERDLG.SetTab(1);

        }
        public static void ExpandTreePID(Window wWind, object aDown, string lsArgs)
        {
            //TBD
            ResultLog.Current.Log("Function ExpandTreePID not implemented yet");
        }
        public static void StandardControls(int i)
        {
            ////TBD
            //ResultLog.Current.Log("Function StandardControls not implemented yet");
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            RECT TPPos = ReportDesignerApplicationDLG.DevExpressXtraReportsUserDesignerXRDesignToolBox.GetRect();
            ReportDesignerApplicationDLG.DoubleClick(MouseButton.Left, TPPos.xPos + 30, TPPos.yPos + 50 + ((i - 1) * 32));
            System.Threading.Thread.Sleep(3000);
        }
        public static void construction1(int i)
        {
            //TBD
            ResultLog.Current.Log("Function construction1 not implemented yet");
        }
        public static void construction(int i)
        {
            //TBD
            //ResultLog.Current.Log("Function construction not implemented yet");
            ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            RECT TPPos = ChartWizardChartDLG.NbWizard.GetRect();
            //int x = TPPos.xPos+25;
            //Print ("X:",x);
            //int y= TPPos.yPos+60+(i*35);
            //Print ("Y:",y);
            ChartWizardChartDLG.PanelNavigation.DoubleClick(MouseButton.Left, TPPos.xPos + 25, 20 + (i * 32));
        }
        public static void ChartWizardPresentation(int i)// Void Plant3DFunctions.ChartWizardPresentation(int i,int j)
        {
            //TBD
            //ResultLog.Current.Log("Function ChartWizardPresentation not implemented yet");
            ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
            RECT TPPos = ChartWizardChartDLG.PanelNavigation.GetRect();
            //Print(TPPos);
            if (LAGT.CommonFiles.Product.Variables.Language == "KOR" || LAGT.CommonFiles.Product.Variables.Language == "JPN")
            {
                ChartWizardChartDLG.PanelNavigation.DoubleClick(MouseButton.Left, TPPos.xPos + 25, TPPos.yPos + 70 + (i * 40));

            }
            else
            {
                ChartWizardChartDLG.PanelNavigation.DoubleClick(MouseButton.Left, TPPos.xPos + 25, TPPos.yPos + 65 + (i * 40));

            }
            //int x = TPPos.xPos+25;
            //Print ("X:",x);
            //int y= TPPos.yPos+60+(i*40) ;
            //Print("Y:", y);
            System.Threading.Thread.Sleep(3000);
            ChartWizardChartDLG.SetActive();

        }
        public static void OpenExistingProject(string ProjectXmlPath)
        {
            //TBD
            ResultLog.Current.Log("Function OpenExistingProject not implemented yet");

        }
        public static void CreateProj(string sPname = null)
        {
            Drawing.Current.TypeE("_newproject");
            ProjectSetupWizardVaultDLG ProjectSetupWizardVaultDLG = new ProjectSetupWizardVaultDLG();
            ProjectSetupWizardVaultDLG.SetActive();
            if (sPname == null)
            {
                sPname = DateTime.Now.ToString();
                sPname = sPname.Replace(":", "_").Replace("/", "_");
            }
            ProjectSetupWizardVaultDLG.M_editName.SetText(sPname);
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardFinishVaultDLG ProjectSetupWizardFinishVaultDLG = new ProjectSetupWizardFinishVaultDLG();
            ProjectSetupWizardFinishVaultDLG.M_buttonFinish.Click();
            System.Threading.Thread.Sleep(60000);

        }
        public static void CreateMetricProj(string sPname = null)
        {
            Drawing.Current.TypeE("_newproject");
            ProjectSetupWizardVaultDLG ProjectSetupWizardVaultDLG = new ProjectSetupWizardVaultDLG();
            ProjectSetupWizardVaultDLG.SetActive();
            if (sPname == null)
            {
                sPname = DateTime.Now.ToString();
                sPname = sPname.Replace(":", "_").Replace("/", "_");
            }
            ProjectSetupWizardVaultDLG.M_editName.SetText(sPname);
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.MetricRB.Select();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardFinishVaultDLG ProjectSetupWizardFinishVaultDLG = new ProjectSetupWizardFinishVaultDLG();
            ProjectSetupWizardFinishVaultDLG.M_buttonFinish.Click();
            System.Threading.Thread.Sleep(60000);

        }
        public static void CreateProjForCollaboration(string sPname = null)
        {
            Drawing.Current.TypeE("_newproject");
            ProjectSetupWizardVaultDLG ProjectSetupWizardVaultDLG = new ProjectSetupWizardVaultDLG();
            ProjectSetupWizardVaultDLG.SetActive();
            if (sPname == null)
            {
                Random random = new Random();
                sPname = "Auto_ENU_0" + (random.Next(1, 1000));
            }
            ProjectSetupWizardVaultDLG.M_editName.SetText(sPname);
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardFinishVaultDLG ProjectSetupWizardFinishVaultDLG = new ProjectSetupWizardFinishVaultDLG();
            ProjectSetupWizardFinishVaultDLG.M_buttonFinish.Click();
            System.Threading.Thread.Sleep(60000);

        }
        public static void CloseDrawing(string sFileName = "")
        {
            Drawing.Current.TypeKeys("<Esc 3>");
            Drawing.Current.TypeE("_SDI");
            Drawing.Current.TypeE("0");
            Drawing.Current.TypeE("_CLOSEALL");
            System.Threading.Thread.Sleep(3000);
            Dialogs.SaveChangesMSG SaveChangesMSG = new Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }

            Dialogs.Plant3D appwnd = new Dialogs.Plant3D();
            appwnd.SetActive();
            System.Threading.Thread.Sleep(3000);
            //if (appwnd.NewFilePB.Exists)
            //{
            //    appwnd.NewFilePB.Click();
            //    appwnd.SetActive();
            //}
            //else 
            //{
            appwnd.TypeKeys("<Ctrl-n>");
            //appwnd.Click(MouseButton.Left, 26, 26);
            //ApplicationMenuWindow ApplicationMenuWindow = new ApplicationMenuWindow();
            //ApplicationMenuWindow.NewFilePB.Click();
            System.Threading.Thread.Sleep(1000);

            var selectTemplateFileDLG = new SelectTemplateFileDLG();
            if (selectTemplateFileDLG.WaitExists(3000))
            {
                selectTemplateFileDLG.OpenPB.Click();
            }
            else
            {
                try
                {
                    appwnd.TypeACommandTF.TypeKeys("<Enter>");
                    //Drawing.Current.TypeKeys("<Enter>");
                }
                catch
                {
                    if (selectTemplateFileDLG.WaitExists(3000))
                    {
                        selectTemplateFileDLG.OpenPB.Click();
                    }
                }
            }
            System.Threading.Thread.Sleep(3000);



        }
        public static void VaultLogin()
        {
            VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            VaultLogInDLG.Invoke();
            VaultLogInDLG.SetActive();
            VaultLogInDLG.UserNameTextBox.SetText(Plant3DFunctions.GetLocString("Administrator"));
            VaultLogInDLG.OK.Click();
            while (VaultLogInDLG.WaitExists(100))
            {
                System.Threading.Thread.Sleep(100);
            }
            System.Threading.Thread.Sleep(1000);
        }
        public static void VaultLogOut()
        {
            VaultLogOutDLG VaultLogOutDLG = new VaultLogOutDLG();
            VaultLogOutDLG.Invoke();
            VaultLogOutDLG.Dismiss();
            System.Threading.Thread.Sleep(2000);

        }
        public static void CreateNewVaultProject()   //to create new project into vault
        {
            ProjectSetupWizardFinishVaultDLG ProjectSetupWizardFinishVaultDLG = new ProjectSetupWizardFinishVaultDLG();
            ProjectSetupWizardFinishVaultDLG.Invoke();
            ProjectSetupWizardFinishVaultDLG.M_buttonFinish.Click();
            DatabaseNamePrefixTestDLG DatabaseNamePrefixTestDLG = new DatabaseNamePrefixTestDLG();
            while (ProjectSetupWizardFinishVaultDLG.Exists)
            {
                System.Threading.Thread.Sleep(100);
                if (DatabaseNamePrefixTestDLG.Exists)
                {
                    DatabaseNamePrefixTestDLG.ClosePB.Click();
                }
            }
            System.Threading.Thread.Sleep(5000);

            //ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG = new ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG();
            //ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG.M_buttonNext.Click();



        }
        public static void OpenVaultProject(string sProjName)   //to open project from vault
        {
            OpenProjectFromVaultDLG OpenProjectFromVaultDLG = new OpenProjectFromVaultDLG();
            OpenProjectFromVaultDLG.Invoke();
            System.Threading.Thread.Sleep(5000);
            OpenProjectFromVaultDLG.SetActive();
            //OpenProjectFromVaultDLG.VaultLocationLV.Select(sProjName);//0
            //OpenProjectFromVaultDLG.VaultLocationLV.Select("TestVault");//sProjName
            OpenProjectFromVaultDLG.TestVaultLBI.Click(MouseButton.Left, 5, 5);
            OpenProjectFromVaultDLG.OpenPB.Click();
            System.Threading.Thread.Sleep(10000);
            ///////////////add FY25
            VaultProjectError VaultProjectError = new VaultProjectError();
            ProjectRefreshFromVaultMSG ProjectRefreshFromVaultMSG = new ProjectRefreshFromVaultMSG();
            try 
            {
                if (VaultProjectError.Exists)
                {
                    VaultProjectError.ClosePB.Click();
                }
            }
            catch (UIException e)
            {
            }

            System.Threading.Thread.Sleep(3000);
            if (ProjectRefreshFromVaultMSG.Exists)
            {
                ProjectRefreshFromVaultMSG.OKPB.Click();
            }
            System.Threading.Thread.Sleep(8000);
            ///////////////////

            OpenVaultProjectDLG OpenVaultProjectDLG = new OpenVaultProjectDLG();
            try
            {
                if (OpenVaultProjectDLG.Exists)
                {
                    OpenVaultProjectDLG.SetActive();
                    OpenVaultProjectDLG.YesPB.Click();
                }


            }
            catch
            {
                System.Threading.Thread.Sleep(5000);
            }
            while (!Drawing.Current.ReadyForNextCommand())
            {
                System.Threading.Thread.Sleep(20000);
            }

        }

        public static void CreateVaultDrawing(string sProjectDrawing = null, string sDefaultTemplate = null, string Title = null, string No = null)
        {
            if (Title == null)
            {
                Title = DateTime.Now.ToString();
                Title = Title.Replace(":", "_").Replace("/", "_");
            }
            if (No == null)
            {
                No = "01";
            }
            //Drawing.Current.TypeE("SDI 0");
            Drawing.Current.SetSysVar("SDI", 0);
            Drawing.Current.TypeE("_DYNMODE -3");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            //      PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            //PROJECTMANAGERDLG.TreeViewTV.Select (AcMainWin.cBabel(23039,2,"Default Project"));
            if (sDefaultTemplate == null)
            {
                sDefaultTemplate = "no";
            }
            NewDWGDLG NewDWGDLG = new NewDWGDLG();
            P3DSelectTemplateFileDLG P3DSelectTemplateFileDLG = new P3DSelectTemplateFileDLG();
            //ResultLog.Current.Log(P3DSelectTemplateFileDLG.Tag);
            if (sProjectDrawing == "P3D")
            {
                ExpandTreeP3D(wTreeView, 1, "0,2");
                if (sDefaultTemplate == "no")
                {
                    System.Threading.Thread.Sleep(2000);
                    NewDWGDLG.M_dwtBrowseButton.Click();
                    //P3DSelectTemplateFileDLG.FileName.ClearText();
                    // P3DSelectTemplateFileDLG.FileName.SetText("{AppWnd.GetFullTemplatePath("acad.dwt")}") 
                    P3DSelectTemplateFileDLG.FileName.Click();
                    P3DSelectTemplateFileDLG.TypeKeys("acad.dwt");
                    P3DSelectTemplateFileDLG.Open.Click();
                }
            }
            if (sProjectDrawing == "PID")
            {
                ExpandTreeP3D(wTreeView, 1, "0,1");
                if (sDefaultTemplate == "no")
                {
                    NewDWGDLG.M_dwtBrowseButton.Click();
                    P3DSelectTemplateFileDLG.FileName.SetText("acad.dwt");
                    P3DSelectTemplateFileDLG.Open.Click();
                }
            }
            if (NewDWGDLG.M_tb_filename.Exists)
            {
                NewDWGDLG.M_tb_filename.SetText(Title);
            }
            NewDWGDLG.BtnOK.Click();
            WarningDLG WarningDLG = new WarningDLG();
            FileExistsDLG FileExistsDLG = new FileExistsDLG();
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            DWGTitleExistsDLG DWGTitleExistsDLG = new DWGTitleExistsDLG();
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            System.Threading.Thread.Sleep(2000);
            if (WarningDLG.Exists)
            {
                WarningDLG.OK.Click();
            }
            if (FileExistsDLG.Exists)
            {
                FileExistsDLG.TypeKeys("<Enter>");
                //}
                System.Threading.Thread.Sleep(2000);
            }
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.OK.Click();
                if (NewDWGDLG.Exists)
                {
                    NewDWGDLG.BtnCancel.Click();
                }
            }
            if (ProjectDataMergedDLG.Exists)
            {
                ProjectDataMergedDLG.SetActive();
                ProjectDataMergedDLG.BtnOk.Click();
            }
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.TypeKeys("<enter>");
            }
            if (DWGTitleExistsDLG.Exists)
            {
                DWGTitleExistsDLG.SetActive();
                DWGTitleExistsDLG.OK.Click();
                NewDWGDLG.BtnCancel.Click();
            }

            System.Threading.Thread.Sleep(3000);
            Drawing.Current.SetSysVar("SDI", 1);
            System.Threading.Thread.Sleep(1000);
            PROJECTMANAGERDLG.SetActive();
            wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            if (sProjectDrawing == "P3D")
            {
                ExpandTreeP3D(wTreeView, 1, "0,2,1");
            }
            else
            {
                ExpandTreeP3D(wTreeView, 1, "0,1,1");
            }
            System.Threading.Thread.Sleep(5000);
            if (WarningAutoCADDLG.Exists)
            {
                WarningAutoCADDLG.No.Click();
            }
            //restart logging for CMDs
            ResultLog.Current.Log(LAGT.CommonFiles.AutomationTests.Variables.AutomationType);
            if (LAGT.CommonFiles.AutomationTests.Variables.AutomationType == "CMDOPT")
            {
                CmdOpt_Engine.StartLog();
            }


        }
        public static void SetToDefault()
        {

            System.Threading.Thread.Sleep(2000);
            if (Drawing.Current == null) //AutoCAD started with no drawing
            {
                Drawing.New(false);
            }
            //VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            //if (VaultLogInDLG.Exists)
            //{
            //    VaultLogInDLG.UserNameTextBox.SetText("Administrator");
            //    VaultLogInDLG.OK.Click();
            //    System.Threading.Thread.Sleep(2000);
            //}            
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            if (!PROJECTMANAGERDLG.Exists)
            {
                Drawing.Current.TypeE("_PROJECTMANAGER");
            }
            PROJECTMANAGERDLG.SetActive();
            //string sText = PROJECTMANAGERDLG.CurrentProjectPL.GetItemText(1);
            //PROJECTMANAGERDLG.CurrentProjectPL.Select(sText);
            //try
            //{
            //    PROJECTMANAGERDLG.CurrentProjectPL.Select(AcMainWin.cBabel(23039, 2, "Default Project "));
            //}
            //catch
            //{
            // //   PROJECTMANAGERDLG.CurrentProjectPL.Select(AcMainWin.cBabel(23039, 2, "Default Project "));
            //    System.Threading.Thread.Sleep(1000);
            //}
            PROJECTMANAGERDLG.TreeViewTV.Click(MouseButton.Right, 1, 1); //set active            
            PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<Esc><home><Add>");
            PROJECTMANAGERDLG.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Down><Enter>");
            System.Threading.Thread.Sleep(5000);
            CloseProjectDrawingsDLG CloseProjectDrawingsDLG = new CloseProjectDrawingsDLG();
            if (CloseProjectDrawingsDLG.Exists)
            {
                CloseProjectDrawingsDLG.OKPB.Click();
            }

            Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
            System.Threading.Thread.Sleep(2000);
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();
            }
            String sProjectname = Plant3DMainWin.sDefaultProjPath + "Project.xml";
            Drawing.Current.TypeE("_Filedia 0");
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectname);
            System.Threading.Thread.Sleep(20000);
        }
        public static void OpenSampleProject()///add in FY23 
        {

            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            PROJECTMANAGERDLG.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Down><Enter>");//close
            System.Threading.Thread.Sleep(2000);
            CloseProjectDrawingsDLG CloseProjectDrawingsDLG = new CloseProjectDrawingsDLG();
            if (CloseProjectDrawingsDLG.Exists)
            {
                CloseProjectDrawingsDLG.OKPB.Click();
            }

            Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
            System.Threading.Thread.Sleep(2000);
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();
            }
            string sProjectPath = Registry.GetValue("HKEY_CURRENT_USER\\" + new AcMainWin().AcadRoot + "\\" + new AcMainWin().AcadNumber, "SampleProject", "") as string;
            string SampleProject = sProjectPath + "Project.xml";
            Drawing.Current.TypeE("_Filedia 0");
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(SampleProject);
            System.Threading.Thread.Sleep(20000);
        }
        public static void OpenProject(string sProjectName)///add in FY25 
        {

            Drawing.Current.TypeE("_Filedia 0");
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
            System.Threading.Thread.Sleep(20000);
            //AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
            //System.Threading.Thread.Sleep(5000);
            //if (!AutoCADPlant3DMigrationDLG.WaitExists(10000))
            //{
            //    AutoCADPlant3DMigrationDLG.SetActive();
            //}
        }
        public static void CheckOutDrawing()
        {
            //TBD
            //ResultLog.Current.Log("Function CheckOutDrawing not implemented yet");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 7, "0,2,1");//down 7
            //wTreeView.TypeKeys("<Down 10><Enter>");
            CheckOutDLG CheckOutDLG = new CheckOutDLG();
            CheckOutDLG.SetActive();
            CheckOutDLG.StaticText1ST.DoubleClick();
            CheckOutDLG.OK.Click();
            System.Threading.Thread.Sleep(15000);
        }
        public static void CheckInDrawing()
        {
            //TBD
            //  ResultLog.Current.Log("Function CheckInDrawing not implemented yet");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 0, "0,2,1");
            wTreeView.TypeKeys("<Down 9><Enter>");
            CheckInDLG CheckInDLG = new CheckInDLG();
            CheckInDLG.SetActive();
            CheckInDLG.OK.Click();
            System.Threading.Thread.Sleep(20000);
        }

        public static void OpenProjectFromVault()
        {
            ResultLog.Current.Log("Function OpenProjectFromVault not implemented yet");
        }
        public static void DeleteAllVaultDrawings()
        {
            PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            PROJECTMANAGERDLG.SetActive();
            System.Threading.Thread.Sleep(2000);
            //PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            wTreeView.Click(MouseButton.Left, 1, 1);
            // PID drawings
            PROJECTMANAGERDLG.PIDDrawingsTVI.Click();
            PROJECTMANAGERDLG.PIDDrawingsTVI.TypeKeys("<Add>");
            RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
            //ResultLog.Current.Log(RemoveDrawingsFromProjectDLG.Tag);
            PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
            string sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
            string sName2 = PROJECTMANAGERDLG.Plant3DDrawingsTVI.Text;
            //ResultLog.Current.Log(sName);
            while (sName != sName2) //while (sName != "Plant 3D Drawings")
            {
                Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");
                if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                    System.Threading.Thread.Sleep(100);
                }
                RemoveDrawingFromProjectDLG RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();
                if (RemoveDrawingFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                    System.Threading.Thread.Sleep(1000);
                }
                System.Threading.Thread.Sleep(100);

                PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
                sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
                //ResultLog.Current.Log(sName);
            }
            System.Threading.Thread.Sleep(1000);
            // P3D drawings
            PROJECTMANAGERDLG.Plant3DDrawingsTVI.Click();
            PROJECTMANAGERDLG.Plant3DDrawingsTVI.TypeKeys("<Add>");
            PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
            sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
            sName2 = PROJECTMANAGERDLG.RelatedFilesTVI.Text;
            //ResultLog.Current.Log(sName);
            while (sName != sName2) //while (sName != "Related Files")
            {
                Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,2,1");
                if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                    System.Threading.Thread.Sleep(100);
                }
                RemoveDrawingFromProjectDLG RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();
                if (RemoveDrawingFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                    System.Threading.Thread.Sleep(1000);
                }
                System.Threading.Thread.Sleep(100);
                PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
                sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
                // ResultLog.Current.Log(sName);
            }
            System.Threading.Thread.Sleep(100);
        }

        public static void treeViewSelect(TreeView treeView, string items)
        {
            if (treeView == null || String.IsNullOrEmpty(items))
            {
                return;
            }
            treeView.Select(getItemString(treeView, items));

        }
        private static string getItemString(TreeView treeView, string selectItem)
        {
            if ("/".Equals(selectItem[0]))
            {
                selectItem = selectItem.Substring(1);
            }
            if (selectItem.EndsWith("/"))
            {
                selectItem = selectItem.Substring(0, selectItem.Length - 1);
            }
            string[] sTemp = selectItem.Split('/');
            string retStr = "";
            string[] treeViewContents = treeView.Contents;
            if ("#".Equals(sTemp[0][0]))
            {
                retStr = treeViewContents[int.Parse(sTemp[0].Replace("#", "")) - 1];
            }
            else
            {
                for (int j = 0; j < treeViewContents.Length; j++)
                {
                    if (match(treeViewContents[j], sTemp[0]))
                    {
                        retStr = treeViewContents[j];
                        break;
                    }
                }
            }
            if (sTemp.Length <= 1)
            {
                return retStr;
            }
            StringBuilder sb = new StringBuilder(retStr);
            for (int i = 1; i < sTemp.Length; i++)
            {
                treeView.Expand(sb.ToString());
                treeViewContents = treeView.GetSubItems(sb.ToString());
                if ("#".Equals(sTemp[i][0].ToString()))
                {
                    retStr = treeViewContents[int.Parse(sTemp[i].Replace("#", "")) - 1];
                    sb.Append("/" + retStr);
                }
                else
                {
                    for (int j = 0; j < treeViewContents.Length; j++)
                    {
                        if (match(treeViewContents[j], sTemp[i]))
                        {
                            retStr = treeViewContents[j];
                            sb.Append("/" + retStr);
                            break;
                        }
                    }
                }
            }
            return sb.ToString();
        }
        private static bool match(string input, string pattern)
        {
            if (String.IsNullOrEmpty(input) || String.IsNullOrEmpty(pattern))
            {
                return false;
            }
            pattern = pattern.Trim();
            string[] tempStrArr = pattern.Split('*');
            int tempPos = 0;
            bool retFlag = true;
            for (int i = 0; i < tempStrArr.Length; i++)
            {
                if (String.IsNullOrEmpty(tempStrArr[i]))
                {
                    continue;
                }
                int tempArrPos = input.IndexOf(tempStrArr[i]);
                if (tempArrPos >= 0 && tempArrPos >= tempPos)
                {
                    tempPos = tempArrPos;
                }
                else
                {
                    retFlag = false;
                    break;
                }
            }
            return retFlag;
        }
        public static void DeleteVaultDrawing(string sProjectDrawing = null)
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            //PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            if (sProjectDrawing == "PID")
            {
                Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");
            }
            else if (sProjectDrawing == "P3D")
            {
                Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "0,2,1");
            }
            RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
            if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
            {
                RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                System.Threading.Thread.Sleep(20000);
            }
            //RemoveDrawingFromProjectDLG RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();
            //if (RemoveDrawingFromProjectDLG.WaitExists(2000))
            //{
            //    RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
            //    System.Threading.Thread.Sleep(1000);
            //}
            FileRemoveDLG FileRemoveDLG = new FileRemoveDLG();
            if (FileRemoveDLG.WaitExists(2000))
            {
                FileRemoveDLG.OK.Click();
            }
            System.Threading.Thread.Sleep(20000);
        }

        public static void DeleteClaudDrawing(string sProjectDrawing = null)
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            //PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            if (sProjectDrawing == "PID")
            {
                Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");
            }
            else if (sProjectDrawing == "P3D")
            {
                Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "0,2,1");
            }

            RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
            if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
            {
                RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(15000);
            FileRemoveDLG FileRemoveDLG = new FileRemoveDLG();
            try
            {
                if (FileRemoveDLG.WaitExists(2000))
                {
                    FileRemoveDLG.OK.Click();
                }
            } catch 
            { }
           

        }
        //public static void DeleteAllVaultDrawings(string sProjectDrawing = null)
        //{
        //    ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
        //    PROJECTMANAGERDLG.SetTab(1);
        //    Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
        //    if (sProjectDrawing == "PID")
        //    {
        //        Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");
        //    }
        //    else if (sProjectDrawing == "P3D")
        //    {
        //        Plant3DFunctions.ExpandTreeP3D(wTreeView, 4, "0,2,1");
        //    }
        //    RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
        //    if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
        //    {
        //        RemoveDrawingsFromProjectDLG.OK.Click();
        //        System.Threading.Thread.Sleep(1000);
        //    }
        //    System.Threading.Thread.Sleep(100);
        //}
        public static void CreateVaultProject(String sProjname)
        {
            Drawing.Current.TypeE("_newproject");
            ProjectSetupWizardVaultDLG ProjectSetupWizardVaultDLG = new ProjectSetupWizardVaultDLG();
            ProjectSetupWizardVaultDLG.SetActive();
            ProjectSetupWizardVaultDLG.M_editName.SetText(sProjname);
            ProjectSetupWizardVaultDLG.SetActive();
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardVaultDLG.M_checkBoxVaultPrj.Check();
            // ProjectSetupWizardVaultDLG.SetActive();
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(1000);
            VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            if (VaultLogInDLG.Exists)
            {
                VaultLogInDLG.OK.Click();
                System.Threading.Thread.Sleep(30000);
                ProjectSetupWizardVaultDLG.M_buttonNext.Click();
            }
            while (!ProjectSetupWizardVaultDLG.M_buttonNext.IsActive)
            {
                System.Threading.Thread.Sleep(15000);
            }
            ProjectSetupWizardSpecifyUnitSettingsVaultDLG ProjectSetupWizardSpecifyUnitSettingsVaultDLG = new ProjectSetupWizardSpecifyUnitSettingsVaultDLG();
            ProjectSetupWizardSpecifyUnitSettingsVaultDLG.SetActive();
            ProjectSetupWizardSpecifyUnitSettingsVaultDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(1000);
            ProjectSetupWizardSpecifyPIDSettingsVaultDLG ProjectSetupWizardSpecifyPIDSettingsVaultDLG = new ProjectSetupWizardSpecifyPIDSettingsVaultDLG();
            ProjectSetupWizardSpecifyPIDSettingsVaultDLG.SetActive();
            ProjectSetupWizardSpecifyPIDSettingsVaultDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(1000);
            ProjectSetupWizardSpecifyPlant3DVaultDLG ProjectSetupWizardSpecifyPlant3DVaultDLG = new ProjectSetupWizardSpecifyPlant3DVaultDLG();
            ProjectSetupWizardSpecifyPlant3DVaultDLG.SetActive();
            ProjectSetupWizardSpecifyPIDSettingsVaultDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(3000);
            ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG = new ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG();
            ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG.SetActive();
            ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG.M_comboServer.SetText("127.0.0.1\\AUTODESKVAULT,1433");
            ProjectSetupWizardSpecifyDatabaseSettingsVaultDLG.M_buttonNext.Click();
            System.Threading.Thread.Sleep(1000);
            ProjectSetupWizardFinishVaultDLG ProjectSetupWizardFinishVaultDLG = new ProjectSetupWizardFinishVaultDLG();
            ProjectSetupWizardFinishVaultDLG.SetActive();
            ProjectSetupWizardFinishVaultDLG.M_buttonFinish.Click();
            System.Threading.Thread.Sleep(110000);
            while (!Drawing.Current.ReadyForNextCommand())
            {
                System.Threading.Thread.Sleep(20000);
            }
        }

        public static void AutodeskPlant3dSignin(String username, String password)
        {
            //Drawing.Current.TypeE("_OnlineSyncSettings");
            //System.Threading.Thread.Sleep(7000);
            //ChooseWhichSettingsAreSyncedForPlant3DDLG ChooseWhichSettingsAreSyncedForPlant3DDLG = new ChooseWhichSettingsAreSyncedForPlant3DDLG();
            //if (ChooseWhichSettingsAreSyncedForPlant3DDLG.Exists)
            //{
            //    ChooseWhichSettingsAreSyncedForPlant3DDLG.CancelPB.Click();
            //    System.Threading.Thread.Sleep(2000);
            //}
            //else
            //{
            //    System.Threading.Thread.Sleep(10000);
            //    AutodeskSignInForPlant3DDLG AutodeskSignInForPlant3DDLG = new AutodeskSignInForPlant3DDLG();
            //    AutodeskSignInForPlant3DDLG.SetActive();
            //    //AutodeskSignInDLG AutodeskSignInDLG = new AutodeskSignInDLG();
            //    //AutodeskSignInDLG.SetActive();
            //    //AutodeskSignInDLG.TypeKeys(username);
            //    //AutodeskSignInDLG.TypeKeys("<Tab 1><Enter>");
            //    //System.Threading.Thread.Sleep(9000);
            //    //AutodeskSignInDLG.TypeKeys(password);
            //    //AutodeskSignInDLG.TypeKeys("<Tab 1><Enter>");
            //    System.Threading.Thread.Sleep(10000);
            //    AutodeskSignInForPlant3DDLG.TypeKeys("echo.wang@welocalize.com");
            //    System.Threading.Thread.Sleep(5000);
            //    AutodeskSignInForPlant3DDLG.TypeKeys("<Tab 1><Enter>");
            //    System.Threading.Thread.Sleep(9000);
            //    AutodeskSignInForPlant3DDLG.TypeKeys("test1234");
            //    AutodeskSignInForPlant3DDLG.TypeKeys("<Tab 1><Enter>");
            //    System.Threading.Thread.Sleep(12000);
            //    ChooseWhichSettingsAreSyncedDLG ChooseWhichSettingsAreSyncedDLG = new ChooseWhichSettingsAreSyncedDLG();
            //    if (ChooseWhichSettingsAreSyncedDLG.Exists)
            //    {
            //        ChooseWhichSettingsAreSyncedDLG.Cancel.Click();
            //        System.Threading.Thread.Sleep(2000);
            //    }
            //}

            ////////////////////////////////////////FY21 new add method
            Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D AppWnd = new Autodesk.GUIHarness.Plant3D.Dialogs.Plant3D();
            if (Harness.Current.AppWnd.Language == LANG_ID.FRENCH || Harness.Current.AppWnd.Language == LANG_ID.ITALIAN)
            {

                AppWnd.TypeKeys("<alt-Space>n");
            }
            if (Harness.Current.AppWnd.Language == LANG_ID.POLISH)
            {

                AppWnd.TypeKeys("<alt-Space>s");
            }
            else
            {

                AppWnd.TypeKeys("<alt-Space>x");
            }
            System.Threading.Thread.Sleep(3000);
            Drawing.Current.TypeE("_PROJECTMANAGERCLOSE");
            System.Threading.Thread.Sleep(1000);
            AppWnd.PushButton2PB.Click();
            Desktop Desktop = new Desktop();
            RECT r = AppWnd.CustomWin5WIN.GetRect(true);
            Desktop.TypeKeys("<Down 2><Right>");//Select Staging Server
            Desktop.TypeKeys("<Down><Enter>");
            System.Threading.Thread.Sleep(1000);
            AppWnd.SetActive();
            AppWnd.PushButton2PB.Click();
            System.Threading.Thread.Sleep(1000);
            Desktop.TypeKeys("<Down><Enter>");//Select Sign in
            System.Threading.Thread.Sleep(12000);

            SignInDLG SignInDLG = new SignInDLG();
            SignInDLG.SetActive();
            //System.Threading.Thread.Sleep(3000);
            //SignInDLG.TypeKeys(username);
            //SignInDLG.TextFieldTF.SetText(username);
            SignInDLG.TypeKeys("<Tab>");
            System.Threading.Thread.Sleep(3000);

            SignInDLG.TypeKeys(username);
            SignInDLG.TypeKeys("<Tab><Enter>");
            System.Threading.Thread.Sleep(3000);
            //SignInDLG.TypeKeys("<Tab>");
            SignInDLG.TypeKeys(password);
            SignInDLG.TypeKeys("<Tab><Enter>");
            System.Threading.Thread.Sleep(5000);
            Drawing.Current.TypeE("_PROJECTMANAGER");
            if (Harness.Current.AppWnd.Language == LANG_ID.POLISH)
            {

                AppWnd.TypeKeys("<alt-Space>P");
            }
            else
            {
                AppWnd.TypeKeys("<alt-Space>r");
            }
            System.Threading.Thread.Sleep(2000);

        }
        public static void OpenCollaborationProject(String Projname)
        {
            OpenCollaborationProjectDLG OpenCollaborationProjectDLG = new OpenCollaborationProjectDLG();
            OpenCollaborationProjectDLG.Invoke();
            System.Threading.Thread.Sleep(2000);
            //OpenCollaborationProjectDLG.ChooseAPlantProjectLB.Select(Projname);//.Select(0);
            OpenCollaborationProjectDLG.SearchTF.SetText(Projname);
            //OpenCollaborationProjectDLG.SearchTF.SetText("AutoFY26_JPN");
            OpenCollaborationProjectDLG.SearchWIN.Click();
            System.Threading.Thread.Sleep(8000);
            try 
            {
                OpenCollaborationProjectDLG.ChooseAPlantProjectLB.Select(Projname);//.Select(0);
            } catch
            {
                OpenCollaborationProjectDLG.AutoProject.Click();
            }
          
            OpenCollaborationProject2DLG OpenCollaborationProject2DLG = new OpenCollaborationProject2DLG();
            OpenCollaborationProject2DLG.OpenProjectPB.Click();
            System.Threading.Thread.Sleep(40000);
            Plant3D.Dialogs.Plant3D appwnd = new Plant3D.Dialogs.Plant3D();
            var CollaborationForPlant3DDLG = new CollaborationForPlant3DDLG();
            while (CollaborationForPlant3DDLG.Exists|| !Drawing.Current.ReadyForNextCommand())
            {
                System.Threading.Thread.Sleep(10000);
                if (Drawing.Current.ReadyForNextCommand()) 
                {
                    break;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(5000);
                if (appwnd.IsActive || appwnd.IsEnabled)
                {
                    break;
                }
            }
        }
        //Class for DlgboxBabel metadata.
        public class DlgboxBabel
        {
            public string DlgName { get; set; }  //Name of Dlg/TC
            public string ENU { get; set; }      //ENU
            public string JPN { get; set; }      //JPN
            public string DEU { get; set; }      //DEU
            public string FRA { get; set; }      //FRA
            public string CHS { get; set; }      //CHS
            public string ITA { get; set; }      //ITA
            public string CHT { get; set; }      //CHT
            public string ESP { get; set; }      //ESP
            public string KOR { get; set; }      //KOR
            public string RUS { get; set; }      //RUS
            public string CSY { get; set; }      //CSY
            public string PLK { get; set; }      //PLK
            public string PTB { get; set; }      //PTB
            public string HUN { get; set; }      //HUN
        }


        public static string GetLocString(string dlgboxName)
        {
            string locString = null;
            string reCapBabelJsonFile = LAGT.CommonFiles.Product.Variables.TestFilesDir.Replace("TestFiles", "Core") + "Plant3D.json";
            List<DlgboxBabel> ltDlgboxBabel = new List<DlgboxBabel>();

            ltDlgboxBabel = LoadJson(reCapBabelJsonFile);
            for (int i = 0; i < ltDlgboxBabel.Count; i++)
            {
                if (ltDlgboxBabel[i].DlgName == dlgboxName)
                {
                    switch (LAGT.CommonFiles.Product.Variables.Language)
                    {
                        case "ENU":
                            locString = ltDlgboxBabel[i].ENU;
                            break;
                        case "JPN":
                            locString = ltDlgboxBabel[i].JPN;
                            break;
                        case "DEU":
                            locString = ltDlgboxBabel[i].DEU;
                            break;
                        case "FRA":
                            locString = ltDlgboxBabel[i].FRA;
                            break;
                        case "CHS":
                            locString = ltDlgboxBabel[i].CHS;
                            break;
                        case "ITA":
                            locString = ltDlgboxBabel[i].ITA;
                            break;
                        case "CHT":
                            locString = ltDlgboxBabel[i].CHT;
                            break;
                        case "ESP":
                            locString = ltDlgboxBabel[i].ESP;
                            break;
                        case "KOR":
                            locString = ltDlgboxBabel[i].KOR;
                            break;
                        case "RUS":
                            locString = ltDlgboxBabel[i].RUS;
                            break;
                        case "CSY":
                            locString = ltDlgboxBabel[i].CSY;
                            break;
                        case "PLK":
                            locString = ltDlgboxBabel[i].PLK;
                            break;
                        case "PTB":
                            locString = ltDlgboxBabel[i].PTB;
                            break;
                        case "HUN":
                            locString = ltDlgboxBabel[i].HUN;
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }
            return locString;
        }

        public static List<DlgboxBabel> LoadJson(string JSONFile)
        {
            List<DlgboxBabel> dlgboxBabel = new List<DlgboxBabel>();
            try
            {
                using (StreamReader r = new StreamReader(JSONFile))
                {
                    string json = r.ReadToEnd();
                    //JavaScriptSerializer ser = new JavaScriptSerializer();
                    //dlgboxBabel = ser.Deserialize<List<DlgboxBabel>>(json);
                    dlgboxBabel = JsonConvert.DeserializeObject<List<DlgboxBabel>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The JSON file {0} is invalid!", JSONFile);
                Console.WriteLine(e.Message);
            }
            return dlgboxBabel;
        }
        public static string GetLicense()
        {
            string lincense = "";
            string inputFile = LAGT.CommonFiles.Core.Variables.FrameworkDir + "LAGT-APP\\Inputs.ini";
            StreamReader inputFileSR = new StreamReader(inputFile);
            while (!inputFileSR.EndOfStream)
            {
                string sLine = inputFileSR.ReadLine();
                if (sLine.Contains("License"))
                {
                    lincense = sLine.Replace("License=", "");
                    break;
                }
            }
            inputFileSR.Close();
            return lincense;
        }
        public static string GetLangCode()
        {
            string sLangCode;
            switch ((ESCGlobals.gsLangCode[(int)ESCGlobals.gBuildLang - 1]).ToUpper())
            {
                case "ENU":
                    sLangCode = "en-US"; break;
                case "DEU":
                    sLangCode = "de-DE"; break;
                case "FRA":
                    sLangCode = "fr-FR"; break;
                case "ITA":
                    sLangCode = "it-IT"; break;
                case "ESP":
                    sLangCode = "es-ES"; break;
                case "JPN":
                    sLangCode = "ja-JP"; break;
                case "KOR":
                    sLangCode = "ko-KR"; break;
                case "CHS":
                    sLangCode = "zh-CN"; break;
                case "CHT":
                    sLangCode = "zh-TW"; break;
                case "CSY":
                    sLangCode = "cs-CZ"; break;
                case "PLK":
                    sLangCode = "pl-PL"; break;
                case "RUS":
                    sLangCode = "ru-RU"; break;
                case "HUN":
                    sLangCode = "hu-HU"; break;
                case "BRA":
                    sLangCode = "pt-BR"; break;
                case "PTB":
                    sLangCode = "pt-BR"; break;
                default:
                    sLangCode = "en-US"; break;
            }
            return sLangCode;
        }

    }


}

