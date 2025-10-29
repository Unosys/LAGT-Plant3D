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
using ProductTestSuite.CommonFiles;
//using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;

namespace Autodesk.GUIHarness.Plant3D
{
    public static class PandIDFunctions
    {
        public static void ExpandTreeP3D(Window wWind, int aDown, string lsArgs)
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
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
                //case "RUS":
                //    if (lsTree.Length.Equals(2))//P&ID
                //    {
                //        wWind.Click(MouseButton.Right, 5, rTree.ySize - 65);
                //    }
                //    else if (lsTree.Length.Equals(3))//Plant3D
                //    {
                //        wWind.Click(MouseButton.Right, 5, rTree.ySize - 50);//55
                //    }
                //    else
                //    {
                //        PROJECTMANAGERDLG.DefaultProjectTVI.Click(MouseButton.Right);
                //    }
                //    break;
                //case "CHS":

                //    if (lsTree.Length.Equals(2))//P&ID
                //    {
                //        wWind.Click(MouseButton.Right, 5, rTree.ySize - 70);
                //    }
                //    else if (lsTree.Length.Equals(3))//Plant3D
                //    {
                //        wWind.Click(MouseButton.Right, 5, rTree.ySize - 50);//55
                //    }
                //    else
                //    {
                //        PROJECTMANAGERDLG.DefaultProjectTVI.Click(MouseButton.Right);
                //    }
                //    break;
                //case "JPN":
                //case "KOR":
                //    if (lsTree.Length.Equals(2))
                //    {
                //        wWind.Click(MouseButton.Right, 5, rTree.ySize - 80);
                //    }
                //    else if (lsTree.Length.Equals(3))
                //    {
                //        wWind.Click(MouseButton.Right, 5, rTree.ySize - 70);
                //    }
                //    else
                //    {
                //        PROJECTMANAGERDLG.DefaultProjectTVI.Click(MouseButton.Right);
                //    }
                //    break;
                default:
                    if (lsTree.Length.Equals(2))
                    {
                        wWind.Click(MouseButton.Right, 5, 25);//P&ID Drawing
                    }
                    else if (lsTree.Length.Equals(3))
                    {
                        wWind.Click(MouseButton.Right, 5, 45);//new PID drawing
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

            try
            {
                wWind.CollapseAll();
            }
            catch(Exception ex)
            {
                for (int i = wWind.ItemCount; i > 0; i--)
                {
                    if (wWind.IsItemExpanded(i - 1))
                    {
                        wWind.Collapse(i - 1);
                    }
                }
            }
            finally {
               
            }
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
            PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
            P3DSelectTemplateFileDLG P3DSelectTemplateFileDLG = new P3DSelectTemplateFileDLG();
            if (sProjectDrawing == "P3D")
            {
                ExpandTreeP3D(wTreeView, 1, "0,2");
                if (sDefaultTemplate == "no")
                {
                    System.Threading.Thread.Sleep(2000);
                    PandIDNewDWGDLG.PushButtonPB.Click();
                    //P3DSelectTemplateFileDLG.FileName.ClearText();
                    // P3DSelectTemplateFileDLG.FileName.SetText("{AppWnd.GetFullTemplatePath("acad.dwt")}") 
                    P3DSelectTemplateFileDLG.FileName.Click();
                    P3DSelectTemplateFileDLG.TypeKeys("acad.dwt");
                    P3DSelectTemplateFileDLG.Open.Click();
                }
            }
            else if (sProjectDrawing == "PID")
            {
                ExpandTreeP3D(wTreeView, 1, "0,1");
                if (sDefaultTemplate == "no")
                {
                    System.Threading.Thread.Sleep(1000);
                    PandIDNewDWGDLG.PushButtonPB.Click();
                    P3DSelectTemplateFileDLG.FileName.SetText("acad.dwt");
                    P3DSelectTemplateFileDLG.Open.Click();
                }
            }
            else //PID
            {
                ExpandTreeP3D(wTreeView, 1, "0,1");
                if (sDefaultTemplate == "no")
                {
                    System.Threading.Thread.Sleep(1000);
                    PandIDNewDWGDLG.PushButtonPB.Click();
                    P3DSelectTemplateFileDLG.FileName.SetText("acad.dwt");
                    P3DSelectTemplateFileDLG.Open.Click();
                }
            }
            if (PandIDNewDWGDLG.FileNameTF.Exists)
            {
                PandIDNewDWGDLG.FileNameTF.SetText(Title);
            }
            PandIDNewDWGDLG.OKPB.Click();
            WarningDLG WarningDLG = new WarningDLG();
            FileExistsDLG FileExistsDLG = new FileExistsDLG();
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            DWGTitleExistsDLG DWGTitleExistsDLG = new DWGTitleExistsDLG();
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            System.Threading.Thread.Sleep(1000);
            if (WarningDLG.Exists)
            {
                WarningDLG.OK.Click();
            }
            if (FileExistsDLG.Exists)
            {
                FileExistsDLG.TypeKeys("<Enter>");
            }
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.OK.Click();
                if (PandIDNewDWGDLG.Exists)
                {
                    PandIDNewDWGDLG.CancelPB.Click();
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
                PandIDNewDWGDLG.CancelPB.Click();
            }
            //Drawing.Current.TypeE("SDI 1");
            Drawing.Current.SetSysVar("SDI", 1);
            PROJECTMANAGERDLG.SetActive();
            wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            if (sProjectDrawing == "P3D")
            {
                ExpandTreeP3D(wTreeView, 1, "0,2,1");
            }
            else
            {
                RightClickTreeP3D(PROJECTMANAGERDLG.TreeViewTV, "1", "", false, 1, 1);
                ////ExpandTreeP3D(wTreeView, 1, "0,1,1");
                //Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
                //RECT wWind = WTreeView.GetRect();
                //if (LAGT.CommonFiles.Product.Variables.Language == "RUS"||LAGT.CommonFiles.Product.Variables.Language == "CHS")
                //{
                //    WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 55);//50
                //}
                //else {

                //    WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 70);
                //}

                //Desktop.Current.TypeKeys("<Down 1><Enter>");
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
        public static void CreateOrthoDrawingColurStyle(string Title)
        {
            if (Title == null)
            {
                Title = DateTime.Now.ToString();
                Title = Title.Replace(":", "_").Replace("/", "_");
            }
            string Path = new AcMainWin().RoamableRootFolder + "DefaultProject\\Orthos\\Styles\\Default\\Ortho - D -Color Dependent Plot Styles.dwt";
            Drawing.Current.TypeE("SDI 0");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.Invoke();
            //PROJECTMANAGERDLG.Undock ();
            PROJECTMANAGERDLG.SetTab(2);
            System.Threading.Thread.Sleep(2000);
            PROJECTMANAGERDLG.OrthoTreeViewTV.TypeKeys("<home>");
            Window wTreeView = PROJECTMANAGERDLG.OrthoTreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1");
            PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
            PandIDNewDWGDLG.FileNameTF.SetText(Title);
            PandIDNewDWGDLG.PushButtonPB.Click();
            P3DSelectTemplateFileDLG P3DSelectTemplateFileDLG = new P3DSelectTemplateFileDLG();
            P3DSelectTemplateFileDLG.FileName.SetText(Path);
            P3DSelectTemplateFileDLG.Open.Click();
            System.Threading.Thread.Sleep(2000);
            PandIDNewDWGDLG.OKPB.Click();
            FileExistsDLG FileExistsDLG = new FileExistsDLG();
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
            WarningDLG WarningDLG = new WarningDLG();
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            DWGTitleExistsDLG DWGTitleExistsDLG = new DWGTitleExistsDLG();

            if (FileExistsDLG.Exists)
            {
                FileExistsDLG.TypeKeys("<Enter>");
            }
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.OK.Click();
                if (PandIDNewDWGDLG.Exists)
                {
                    PandIDNewDWGDLG.CancelPB.Click();
                    // DeleteAllDrawings ();
                    PandIDFunctions.CreateDrawing("P3D");
                }
            }
            if (WarningDLG.Exists)
            {
                WarningDLG.OK.Click();
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
                PandIDNewDWGDLG.CancelPB.Click();
            }
            System.Threading.Thread.Sleep(5000);
            Drawing.Current.TypeE("SDI 1");
            // PROJECTMANAGERDLG.SetActive ();
            PROJECTMANAGERDLG.SetTab(2);//DoubleClick (1, rPaletteWnd.xSize-10,rPaletteWnd.ySize/2);
            // PROJECTMANAGERDLG.SetActive();
            //PROJECTMANAGERDLG.M_treeViewOrtho.Select(AppWnd.Babel(23039,2,"Default Project"));
            wTreeView = PROJECTMANAGERDLG.OrthoTreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 4, "0,1,1");
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            if (WarningAutoCADDLG.Exists)
            {
                WarningAutoCADDLG.No.Click();
            }
            System.Threading.Thread.Sleep(3000);
            // PROJECTMANAGERDLG.SetActive ();
            PROJECTMANAGERDLG.SetTab(1);// .DoubleClick (1, rPaletteWnd.xSize-10,rPaletteWnd.ySize/5);
        }
        public static void DeleteOrthoDrawing(string sProjectDrawing = null)
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            PROJECTMANAGERDLG.SetTab(2);
            Window wTreeView = PROJECTMANAGERDLG.OrthoTreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 7, "0,1,1");
            PandIDRemoveDrawingDLG RemoveDrawingsFromProjectDLG = new PandIDRemoveDrawingDLG();
            if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
            {
                RemoveDrawingsFromProjectDLG.RemoveTheDrawingFromPB.Click();
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(1000);
        }
        public static void DeleteDrawing(string sProjectDrawing = null)
        {
            Desktop.Current.TypeKeys("<Esc 2>");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1,1");
            //Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
            //RECT wWind = WTreeView.GetRect();
            //if (LAGT.CommonFiles.Product.Variables.Language == "RUS"||LAGT.CommonFiles.Product.Variables.Language == "CHS")
            //{
            //    WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 55);//50
            //}
            //else
            //{
            //    WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 70);
            //}

            //Desktop.Current.TypeKeys("<Down 4><Enter>");
            PandIDRemoveDrawingDLG RemoveDrawingsFromProjectDLG = new PandIDRemoveDrawingDLG();
            if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
            {
                RemoveDrawingsFromProjectDLG.RemoveTheDrawingFromPB.Click();
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(1000);
        }
        public static void DeleteAllDrawings()
        {
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            //PROJECTMANAGERDLG.SetActive();
            PROJECTMANAGERDLG.SetTab(1);
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            wTreeView.Click(MouseButton.Left, 1, 1);
            // PID drawings
            PROJECTMANAGERDLG.PIDDrawingsTVI.Click();
            PROJECTMANAGERDLG.PIDDrawingsTVI.TypeKeys("<Add>");
            PandIDRemoveDrawingDLG RemoveDrawingsFromProjectDLG = new PandIDRemoveDrawingDLG();
            PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
            string sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
            string sName2 = PROJECTMANAGERDLG.Plant3DDrawingsTVI.Text;
            //ResultLog.Current.Log(sName);
            while (sName != sName2) //while (sName != "Plant 3D Drawings")
            {
                PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,1,1");//4 in list
                if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingsFromProjectDLG.RemoveTheDrawingFromPB.Click();
                    System.Threading.Thread.Sleep(100);
                }
                System.Threading.Thread.Sleep(100);
                PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
                sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
                //ResultLog.Current.Log(sName);
            }
            System.Threading.Thread.Sleep(100);
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
                PandIDFunctions.ExpandTreeP3D(wTreeView, 3, "0,2,1");//4 in list
                if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
                {
                    RemoveDrawingsFromProjectDLG.RemoveTheDrawingFromPB.Click();
                    System.Threading.Thread.Sleep(100);
                }
                System.Threading.Thread.Sleep(100);
                PROJECTMANAGERDLG.TreeViewTV.TypeKeys("<down>");
                sName = PROJECTMANAGERDLG.TreeViewTV.SelectedText;
                // ResultLog.Current.Log(sName);

                if (sName2.Equals(AcMainWin.cBabel(23073, 25, "Pipe Specs")) || sName.Equals(Plant3DFunctions.GetLocString("PipeSpecs")))
                {
                    break;
                }
            }
            System.Threading.Thread.Sleep(100);
        }
        public static void CopyDrawing(string sDrawingName)
        {
            ProjManUndocked projectmanagerDLG = new ProjManUndocked();
            projectmanagerDLG.SetActive();
            PandIDFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,1");
            SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
            SelectDrawingsToCopyToProDLG.SetActive();
            SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + sDrawingName);
            SelectDrawingsToCopyToProDLG.Open.Click();
            //AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
            //if (AutoCADPlant3DMigrationDLG.WaitExists(2000))
            //{
            //    AutoCADPlant3DMigrationDLG.BackupTheDrawingBeforeCK.Uncheck();
            //    Desktop.Current.TypeKeys("<enter>"); //close migration
            //}
            //Pane NotAll = new Pane("$frmMultilineMsgBox");
            //if (NotAll.WaitExists(1000));
            //{
            //    NotAll.PushButton("$m_btnOk").Click();
            //}

            PandIDFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 1, "0,1,1");
            //TBD
            //ResultLog.Current.Log("Function CopyDrawing not implemented yet");
            //restart logging for CMDs
            ResultLog.Current.Log(LAGT.CommonFiles.AutomationTests.Variables.AutomationType);
            if (LAGT.CommonFiles.AutomationTests.Variables.AutomationType == "CMDOPT")
            {
                CmdOpt_Engine.StartLog();
            }
        }
        public static void InvokeCentrifugalBlower()
        {
            PandIDProjectSetupPandIDClassDefinitionDLG PandIDProjectSetupPandIDClassDefinitionDLG = new PandIDProjectSetupPandIDClassDefinitionDLG();
            PandIDProjectSetupPandIDClassDefinitionDLG.Invoke();

            string sIndex;
            switch (Product.Variables.Language)
            {
                case "Kor":
                    sIndex = "#3";
                    break;
                case "Deu":
                    sIndex = "#5";
                    break;
                case "Rus":
                    sIndex = "#3";
                    break;
                case "Chs":
                    sIndex = "#2";
                    break;
                default:
                    sIndex = "#1";
                    break;
            }
            ProjectSetupEndConnectionDLG ProjectSetupEndConnectionDLG = new ProjectSetupEndConnectionDLG();

            //PandIDFunctions.treeViewExpand(ProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex);
            //PandIDFunctions.treeViewExpand(ProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items"));

            //PandIDFunctions.treeViewExpand(ProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment"));
            //PandIDFunctions.treeViewExpand(ProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + AcMainWin.cBabel(21100, 2, "Engineering Items") + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers"));
            //PandIDFunctions.treeViewSelect(ProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21000, 2, "Equipment") + "/" + AcMainWin.cBabel(21000, 3, "Blowers") + "/" + AcMainWin.cBabel(21000, 4, "Centrifugal Blower"));
            //PandIDFunctions.treeViewSelect(ProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21030, 1, "P&ID DWG Settings") + "/" + AcMainWin.cBabel(21013, 1, "P&ID Class Definitions") + "/" + sIndex + "/" + AcMainWin.cBabel(21051, 3, "Equipment") + "/" + AcMainWin.cBabel(21100, 6, "Blowers") + "/" + AcMainWin.cBabel(21100, 7, "Centrifugal Blower"));
            PandIDFunctions.treeViewSelect(ProjectSetupEndConnectionDLG.M_treeView, AcMainWin.cBabel(21100, 6, "Blowers") + "/" + AcMainWin.cBabel(21000, 4, "Centrifugal Blower"));

            //  if (LAGT.CommonFiles.Product.Variables.Language == "JPN") {

            //      PandIDFunctions.treeViewSelect(ProjectSetupEndConnectionDLG.M_treeView,  AcMainWin.cBabel(21100, 6, "Blowers") + "/" + AcMainWin.cBabel(21100, 7, "Centrifugal Blower"));
            //      //Desktop Desktop = new Desktop();
            //      //Desktop.TypeKeys("<Down 1>");
            //  }else
            //if ( LAGT.CommonFiles.Product.Variables.Language == "RUS")
            //  {

            //      Desktop Desktop = new Desktop();
            //      Desktop.TypeKeys("<UP 1>");
            //  }
            //  else if (LAGT.CommonFiles.Product.Variables.Language == "DEU")
            //  {

            //      Desktop Desktop = new Desktop();
            //      Desktop.TypeKeys("<Down 2>");
            //  }
            //  else
            //  {
            //      PandIDFunctions.treeViewSelect(ProjectSetupEndConnectionDLG.M_treeView,  AcMainWin.cBabel(21100, 6, "Blowers"));
            //      Desktop Desktop = new Desktop();
            //      Desktop.TypeKeys("<Down 2>");
            //  }

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
        public static void CreateDrawingWithAnObject(string sProjectDrawing = null, string Title = null, string No = null)
        {
            if (Title == null)
            {
                Title = DateTime.Now.ToString();
                Title = Title.Replace(":", "_").Replace("/", "_");
            }
            if (No == null)
            {
                No = "1";
            }
            Drawing.Current.TypeE("SDI 0");
            Drawing.Current.TypeE("_DYNMODE -3");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;// .M_treeView

            PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
            P3DSelectTemplateFileDLG P3DSelectTemplateFileDLG = new P3DSelectTemplateFileDLG();


            ExpandTreeP3D(wTreeView, 1, "0,1");

            PandIDNewDWGDLG.PushButtonPB.Click();
            P3DSelectTemplateFileDLG.FileName.SetText("acad.dwt");
            P3DSelectTemplateFileDLG.Open.Click();
            if (PandIDNewDWGDLG.FileNameTF.Exists)
            {
                PandIDNewDWGDLG.FileNameTF.SetText(Title);
            }
            PandIDNewDWGDLG.OKPB.Click();
            WarningDLG WarningDLG = new WarningDLG();
            FileExistsDLG FileExistsDLG = new FileExistsDLG();
            DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
            ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
            DWGTitleExistsDLG DWGTitleExistsDLG = new DWGTitleExistsDLG();
            WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
            if (WarningDLG.Exists)
            {
                WarningDLG.OK.Click();
            }
            if (FileExistsDLG.Exists)
            {
                FileExistsDLG.TypeKeys("<Enter>");
            }
            if (DrawingAlreadyExistsDLG.Exists)
            {
                DrawingAlreadyExistsDLG.OK.Click();
                if (PandIDNewDWGDLG.Exists)
                {
                    PandIDNewDWGDLG.CancelPB.Click();
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
                PandIDNewDWGDLG.CancelPB.Click();
            }
            Drawing.Current.TypeE("SDI 1");
            PROJECTMANAGERDLG.SetActive();
            wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            if (No == "1")
            {
                ExpandTreeP3D(wTreeView, 1, "0,1," + No);
            }
            if (No == "2")
            {
                ////ExpandTreeP3D(wTreeView, 1, "0,1," + No);
                //Window WTreeView = PROJECTMANAGERDLG.TreeViewTV;
                //RECT wWind = WTreeView.GetRect();
                //WTreeView.Click(MouseButton.Right, 5, wWind.ySize - 50);
                //Desktop.Current.TypeKeys("<Down 1><Enter>");
                RightClickTreeP3D(PROJECTMANAGERDLG.TreeViewTV, "1", "", false, 1, 2);
            }
            System.Threading.Thread.Sleep(5000);
            if (WarningAutoCADDLG.Exists)
            {
                WarningAutoCADDLG.No.Click();
            }
            Drawing.Current.TypeE("_MODEL");
            Drawing.Current.TypeE("_SLINE");
            Drawing.Current.TypeE("_s");
            Drawing.Current.TypeE("");//("Primary Style")
            Drawing.Current.TypeE("200,500");
            Drawing.Current.TypeE("200,700");
            if (!Drawing.Current.ReadyForNextCommand())
            {
                Drawing.Current.TypeE("");
            }

            Drawing.Current.TypeE("_ZOOM");
            Drawing.Current.TypeE("_EXTENTS");

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
            ResultLog.Current.Log("Function CreateOrthoDrawing not implemented yet");
        }
        public static void ExpandTreePID(Window wWind, object aDown, string lsArgs)
        {
            //TBD
            ResultLog.Current.Log("Function ExpandTreePID not implemented yet");
        }
        public static void StandardControls(int i)
        {
            //TBD
            ResultLog.Current.Log("Function StandardControls not implemented yet");
        }
        public static void construction1(int i)
        {
            //TBD
            ResultLog.Current.Log("Function construction1 not implemented yet");
        }
        public static void construction(int i)
        {
            //TBD
            ResultLog.Current.Log("Function construction not implemented yet");
        }
        public static void ChartWizardPresentation(int i)// Void PandIDFunctions.ChartWizardPresentation(int i,int j)
        {
            //TBD
            ResultLog.Current.Log("Function ChartWizardPresentation not implemented yet");
        }
        public static void OpenExistingProject(string ProjectXmlPath)
        {
            //TBD
            ResultLog.Current.Log("Function OpenExistingProject not implemented yet");
        }
        public static string CreateProj(string sPname = null)
        {
            ProjectSetupWizardDLG ProjectSetupWizardDLG = new ProjectSetupWizardDLG();
            ProjectSetupWizardDLG.Invoke();
            ProjectSetupWizardDLG.SetActive();
            if (sPname == null)
            {
                sPname = DateTime.Now.ToString();
                sPname = sPname.Replace(":", "_").Replace("/", "_");
            }
            ProjectSetupWizardDLG.M_editName.SetText(sPname);
            System.Threading.Thread.Sleep(2000);
            ProjectSetupWizardDLG.M_editProjDir.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir);
            ProjectSetupWizardDLG.M_buttonNext.Click();

            ProjectSetupWizardDLG.M_buttonNext.Click();
            ProjectSetupWizardDLG.M_buttonNext.Click();
            ProjectSetupWizardDLG.M_buttonNext.Click();
            ProjectSetupWizardDLG.M_buttonNext.Click();
            ProjectSetupWizardFinishDLG ProjectSetupWizardFinishDLG = new ProjectSetupWizardFinishDLG();
            ProjectSetupWizardFinishDLG.M_buttonFinish.Click();
            System.Threading.Thread.Sleep(20000);
            ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0");

            string sProjectName = Plant3DMainWin.sDefaultProjPath + "Project.xml";
            Drawing.Current.TypeE("_Filedia 0");
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectName);
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.Ready();
            Drawing.Current.TypeE("_Filedia 1");
            return sPname;

        }
        public static void VaultLogin()
        {
            //TBD
            ResultLog.Current.Log("Function VaultLogin not implemented yet");
        }
        public static void VaultLogOut()
        {
            //TBD
            ResultLog.Current.Log("Function VaultLogOut not implemented yet");
        }
        public static void CreateNewVaultProject()   //to create new project into vault
        {
            //TBD
            ResultLog.Current.Log("Function CreateNewVaultProject not implemented yet");
        }
        public static void CreateVaultDrawing(string sProjectDrawing = null, string sDefaultTemplate = null, string Title = null, string No = null)
        {
            //TBD
            ResultLog.Current.Log("Function CreateVaultDrawing not implemented yet");
        }
        public static void SetToDefault()
        {
            //TBD
            ResultLog.Current.Log("Function SetToDefault not implemented yet");
        }
        public static void CheckOutDrawing()
        {
            //TBD
            ResultLog.Current.Log("Function CheckOutDrawing not implemented yet");
        }
        public static void CheckInDrawing()
        {
            //TBD
            ResultLog.Current.Log("Function CheckInDrawing not implemented yet");
        }

        //public static void CopyDrawing(string sDrawingName, string sProjectDrawing = null, String Title = null, String No = null)
        //{
        //    ProjManUndocked projectmanagerDLG = new ProjManUndocked();
        //    projectmanagerDLG.SetActive();
        //    PandIDFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 3, "0,2");
        //    SelectDrawingsToCopyToProDLG SelectDrawingsToCopyToProDLG = new SelectDrawingsToCopyToProDLG();
        //    SelectDrawingsToCopyToProDLG.SetActive();
        //    SelectDrawingsToCopyToProDLG.FileName.TypeKeys(LAGT.CommonFiles.Product.Variables.TestFilesDir + sDrawingName);
        //    SelectDrawingsToCopyToProDLG.Open.Click();
        //    //AutoCADPlant3DMigrationDLG AutoCADPlant3DMigrationDLG = new AutoCADPlant3DMigrationDLG();
        //    //if (AutoCADPlant3DMigrationDLG.WaitExists(2000))
        //    //{
        //    //    AutoCADPlant3DMigrationDLG.BackupTheDrawingBeforeCK.Uncheck();
        //    //    Desktop.Current.TypeKeys("<enter>"); //close migration
        //    //}
        //    PandIDFunctions.ExpandTreeP3D(projectmanagerDLG.TreeViewTV, 1, "0,2,1");
        //    //TBD
        //}
        //public static void CreateDrawing(string sProjectDrawing = null, string sDefaultTemplate = null, string Title = null, string No = null)
        //{
        //    // print("creating {sProjectDrawing} drawing {Title} with {sDefaultTemplate} template")
        //    if (Title == null)
        //    {
        //        Title = DateTime.Now.ToString();
        //        Title = Title.Replace(":", "_").Replace("/", "_");
        //    }
        //    if (No == null)
        //    {
        //        No = "01";
        //    }
        //    Drawing.Current.TypeE("SDI 0");
        //    Drawing.Current.TypeE("_DYNMODE -3");
        //    Drawing.Current.TypeE("_PROJECTMANAGER");
        //    ProjManUndocked PROJECTMANAGERDLG = new ProjManUndocked();
        //    PROJECTMANAGERDLG.SetActive();
        //    Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;// .M_treeView
        //    //PROJECTMANAGERDLG.TreeViewTV.Select (AcMainWin.cBabel(23039,2,"Default Project"));
        //    if (sDefaultTemplate == null)
        //    {
        //        sDefaultTemplate = "no";
        //    }
        //    PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
        //    P3DSelectTemplateFileDLG P3DSelectTemplateFileDLG = new P3DSelectTemplateFileDLG();
        //    if (sProjectDrawing == "P3D")
        //    {
        //        ExpandTreeP3D(wTreeView, 1, "0,2");
        //        if (sDefaultTemplate == "no")
        //        {
        //            System.Threading.Thread.Sleep(2000);
        //            PandIDNewDWGDLG.PushButtonPB.Click();
        //            //P3DSelectTemplateFileDLG.FileName.ClearText();
        //            // P3DSelectTemplateFileDLG.FileName.SetText("{AppWnd.GetFullTemplatePath("acad.dwt")}") 
        //            P3DSelectTemplateFileDLG.FileName.Click();
        //            P3DSelectTemplateFileDLG.TypeKeys("acad.dwt");
        //            P3DSelectTemplateFileDLG.Open.Click();
        //        }
        //    }
        //    if (sProjectDrawing == "PID")
        //    {
        //        ExpandTreeP3D(wTreeView, 1, "0,1");
        //        if (sDefaultTemplate == "no") 
        //        {
        //            PandIDNewDWGDLG.PushButtonPB.Click();
        //            P3DSelectTemplateFileDLG.FileName.SetText("acad.dwt");
        //            P3DSelectTemplateFileDLG.Open.Click();
        //        }
        //    }
        //    if (PandIDNewDWGDLG.FileNameTF.Exists)
        //    {
        //        PandIDNewDWGDLG.FileNameTF.SetText(Title);
        //    }
        //    PandIDNewDWGDLG.OKPB.Click();
        //    WarningDLG WarningDLG = new WarningDLG();
        //    FileExistsDLG FileExistsDLG = new FileExistsDLG();
        //    DrawingAlreadyExistsDLG DrawingAlreadyExistsDLG = new DrawingAlreadyExistsDLG();
        //    ProjectDataMergedDLG ProjectDataMergedDLG = new ProjectDataMergedDLG();
        //    DWGTitleExistsDLG DWGTitleExistsDLG = new DWGTitleExistsDLG();
        //    WarningAutoCADDLG WarningAutoCADDLG = new WarningAutoCADDLG();
        //    if (WarningDLG.Exists)
        //    {
        //        WarningDLG.OK.Click();
        //    }
        //    if (FileExistsDLG.Exists)
        //    {
        //        FileExistsDLG.TypeKeys("<Enter>");
        //    }
        //    if (DrawingAlreadyExistsDLG.Exists)
        //    {
        //        DrawingAlreadyExistsDLG.OK.Click();
        //        if (PandIDNewDWGDLG.Exists)
        //        {
        //            PandIDNewDWGDLG.CancelPB.Click();
        //        }
        //    }
        //    if (ProjectDataMergedDLG.Exists)
        //    {
        //        ProjectDataMergedDLG.SetActive();
        //        ProjectDataMergedDLG.BtnOk.Click();
        //    }
        //    if (DrawingAlreadyExistsDLG.Exists)
        //    {
        //        DrawingAlreadyExistsDLG.TypeKeys("<enter>");
        //    }
        //    if (DWGTitleExistsDLG.Exists)
        //    {
        //        DWGTitleExistsDLG.SetActive();
        //        DWGTitleExistsDLG.OK.Click();
        //        PandIDNewDWGDLG.CancelPB.Click();
        //    }
        //    Drawing.Current.TypeE("SDI 1");
        //    PROJECTMANAGERDLG.SetActive();
        //    wTreeView = PROJECTMANAGERDLG.TreeViewTV;
        //    if (sProjectDrawing == "P3D")
        //    {
        //        ExpandTreeP3D(wTreeView, 1, "0,2,1");
        //    }
        //    else
        //    {
        //        ExpandTreeP3D(wTreeView, 1, "0,1,1");
        //    }
        //    System.Threading.Thread.Sleep(5000);
        //    if (WarningAutoCADDLG.Exists)
        //    {
        //        WarningAutoCADDLG.No.Click();
        //    }
        //}

        //public static void InvokeCentrifugalBlower()
        //{
        //    //TBD
        //}
        //public static void ExpandTreeP3D(Window wWind, object aDown, string lsArgs)
        //{
        //    //TBD
        //}
        //public static void DeleteDrawing(string sProjectDrawing = null)
        //{
        //    //TBD
        //}
        //public static void InitDataManagerToolbarSize(Window wDlg)
        //{
        //    //TBD
        //}
        //public static void InitDlgSize(Window wDlg = null, int itimesx = 0, int itimesy = 0)
        //{
        //    //TBD
        //}
        //public static void CreateDrawingWithAnObject(string sProjectDrawing, string Title, string No)
        //{
        //    //TBD
        //}
        //public static void DeleteAllDrawings()
        //{
        //    //TBD
        //}
        //public static void CreateNewProject()
        //{
        //    //TBD
        //}
        //public static void SelectToolPaletteTab(int iTabPos) //used in vine
        //{
        //    //TBD
        //}
        //public static void LinkDrawing(string FilenameForOffPageConnector)
        //{
        //    //TBD
        //}
        //public static void CreateProject(string ProjectName)
        //{
        //    //TBD
        //}
        //public static void CreateOrthoDrawing(string Title)
        //{
        //    //TBD
        //}
        //public static void CreateOrthoDrawingColurStyle(string Title)
        //{
        //    //TBD
        //}
        //public static void DeleteOrthoDrawing(string sProjectDrawing = null)
        //{
        //    //TBD
        //}
        //public static void ExpandTreePID(Window wWind, object aDown, string lsArgs)
        //{
        //    //TBD
        //}
        //public static void StandardControls(int i)
        //{
        //    //TBD
        //}
        //public static void construction1(int i)
        //{
        //    //TBD
        //}
        //public static void construction(int i)
        //{
        //    //TBD
        //}
        //public static void ChartWizardPresentation(int i)// Void PandIDFunctions.ChartWizardPresentation(int i,int j)
        //{
        //    //TBD
        //}
        //public static void OpenExistingProject(string ProjectXmlPath)
        //{
        //    //TBD
        //}
        //public static void CreateProj(string sPname)
        //{
        //    //TBD
        //}
        //public static void VaultLogin()
        //{
        //    //TBD
        //}
        //public static void VaultLogOut()
        //{
        //    //TBD
        //}
        //public static void CreateNewVaultProject()   //to create new project into vault
        //{
        //    //TBD
        //}
        //public static void CreateVaultDrawing(string sProjectDrawing = null, string sDefaultTemplate = null, string Title = null, string No = null)
        //{
        //    //TBD
        //}
        //public static void SetToDefault()
        //{
        //    //TBD
        //}
        //public static void CheckOutDrawing()
        //{
        //    //TBD
        //}
        //public static void CheckInDrawing()
        //{
        //    //TBD
        //}
        /// <summary>
        /// override treeview select
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="items"></param>
        public static void treeViewSelect(TreeView treeView, string items)
        {
            if (treeView == null || String.IsNullOrEmpty(items))
            {
                return;
            }
            treeView.Select(getItemString(treeView, items));

        }
        /// <summary>
        /// override treeview getItemRect
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static RECT treeViewGetItemRect(TreeView treeView, string items)
        {
            if (treeView == null || String.IsNullOrEmpty(items))
            {
                return new RECT();
            }
            RECT retRect = treeView.GetItemRect(getItemString(treeView, items));
            return retRect;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tv"></param>
        /// <param name="selectItem"></param>
        public static void treeViewExpand(TreeView tv, string selectItem)
        {
            if (string.IsNullOrEmpty(selectItem) || tv == null)
            {
                return;
            }
            try
            {
                tv.Expand(getItemString(tv, selectItem));
            }
            catch (Exception)
            {
            }
        }
        public static void RunCmd(string cmd)
        {
            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            proc.Close();
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

    }

}
