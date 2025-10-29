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
using System.Diagnostics;
using System.IO;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PandIDFileSetToReadOnlyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]AutoCAD Plant 3D";
            //Tag = "[DialogBox]" + "AutoCAD P&ID";
        }

		public override void Invoke()
		{
            //string sPath = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\ABC.dwg";
            //string sPathBak = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\ABC.bak";
            //string sProd = "PID";
            //if (File.Exists(sPath))
            //{
            //    PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
            //    File.Delete(sPath);
            //    File.Delete(sPathBak);
            //}
            //PandIDFunctions.CreateDrawing(sProd, null, "ABC");
            //Drawing.Current.TypeE("_close");
            //System.Threading.Thread.Sleep(2000);
            //PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
            //if (PandIDWarningAutoCADDLG.Exists)
            //{
            //    PandIDWarningAutoCADDLG.No.Click();
            //}
            ////string sPathcopy = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\ABC\";
            ////if (!Directory.Exists(sPathcopy)) Directory.CreateDirectory(sPathcopy);

            //PandIDFunctions.DeleteDrawing();
            //System.Threading.Thread.Sleep(2000);
            //if (!File.Exists(sPath))
            //{
            //    File.Create(sPath);

            //}
            //PandIDFunctions.RunCmd("Attrib +R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
            //this.CreateDrawing(sProd, null, "ABC");

            //////////////////////////
            PROJECTMANAGERDLG PROJECTMANAGERDLG = new PROJECTMANAGERDLG();
            string sPath;
            string sProd = "PID";
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\PID_DWG\\PIDABC.dwg";
            FileInfo file = new FileInfo(sPath);
            if (!File.Exists(sPath))
            {
                File.Copy(LAGT.CommonFiles.Product.Variables.TestFilesDir + "PandID\\PIDABC.dwg", sPath);
            }
            Desktop Desktop = new Desktop();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Process.Start("cmd.exe", "/c attrib " + "+R \"" + sPath + "\"");
            this.CreateDrawing(sProd, null, "PIDABC");
        }

		public override void Dismiss()
		{
            //this.OKPB.Click();
            //string sPath = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\ABC.dwg";
            //string sPathBak = new AcMainWin().RoamableRootFolder + @"DefaultProject\PID_DWG\ABC.bak";          
            //PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
            //PandIDNewDWGDLG.CancelPB.Click();
            //System.Threading.Thread.Sleep(2000);
            //if (File.Exists(sPath))
            //{
            //    PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
            //    File.Delete(sPath);
            //    File.Delete(sPathBak);
            //}

            //PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            //PandIDPROJECTMANAGERDLG.Dismiss();
            this.OKPB.Click();          
            PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
            PandIDNewDWGDLG.CancelPB.Click();
            System.Threading.Thread.Sleep(2000);
            string sPath;
           
            sPath = new AcMainWin().RoamableRootFolder + "DefaultProject\\PID_DWG\\PIDABC.dwg";
            if (File.Exists(sPath))
            {
                Process.Start("cmd.exe", "/c attrib " + "-R \"" + sPath + "\"");
                //PandIDFunctions.RunCmd("Attrib -R " + System.Convert.ToChar(34) + sPath + System.Convert.ToChar(34));
                //File.Delete(sPath);

            }
            //Plant3DFunctions.DeleteDrawing("PID");


        }
        private void CreateDrawing(string sProjectDrawing = null, string sDefaultTemplate = null, string Title = null, string No = null)
        {
            if (Title == null)
            {
                Title = System.DateTime.Now.ToString();
                Title = Title.Replace(":", "_").Replace("/", "_");
            }
            if (No == null)
            {
                No = "01";
            }
            Drawing.Current.TypeE("SDI 0");
            Drawing.Current.TypeE("_DYNMODE -3");
            Drawing.Current.TypeE("_PROJECTMANAGER");
            PandIDProjManUndocked PandIDPROJECTMANAGERDLG = new PandIDProjManUndocked();
            PandIDPROJECTMANAGERDLG.SetActive();
            Window wTreeView = PandIDPROJECTMANAGERDLG.TreeViewTV;// .M_treeView
            //PandIDPROJECTMANAGERDLG.TreeViewTV.Select (AcMainWin.cBabel(23039,2,"Default Project"));
            if (sDefaultTemplate == null)
            {
                sDefaultTemplate = "no";
            }
            PandIDNewDWGDLG PandIDNewDWGDLG = new PandIDNewDWGDLG();
            PandIDP3DSelectTemplateFileDLG PandIDP3DSelectTemplateFileDLG = new PandIDP3DSelectTemplateFileDLG();
            if (sProjectDrawing == "P3D")
            {
                PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,2");
                if (sDefaultTemplate == "no")
                {
                    System.Threading.Thread.Sleep(2000);
                    PandIDNewDWGDLG.PushButtonPB.Click();
                    //PandIDP3DSelectTemplateFileDLG.FileName.ClearText();
                    // PandIDP3DSelectTemplateFileDLG.FileName.SetText("{AppWnd.GetFullTemplatePath("acad.dwt")}") 
                    PandIDP3DSelectTemplateFileDLG.FileNameCB.Click();
                    PandIDP3DSelectTemplateFileDLG.TypeKeys("acad.dwt");
                    PandIDP3DSelectTemplateFileDLG.OpenPB.Click();
                }
            }
            //if (sProjectDrawing == "PID")
            else
            {

                PandIDFunctions.ExpandTreeP3D(wTreeView, 1, "0,1");
                System.Threading.Thread.Sleep(1000);
                if (sDefaultTemplate == "no")
                {
                    PandIDNewDWGDLG.PushButtonPB.Click();
                    PandIDP3DSelectTemplateFileDLG.FileNameCB.SetText("acad.dwt");
                    PandIDP3DSelectTemplateFileDLG.OpenPB.Click();
                }
            }
            if (PandIDNewDWGDLG.FileNameTF.Exists)
            {
                PandIDNewDWGDLG.FileNameTF.SetText(Title);
            }
            PandIDNewDWGDLG.OKPB.Click();
            PandIDFileExistsDLG PandIDFileExistsDLG = new PandIDFileExistsDLG();
            PandIDFileExistsDLG.TypeKeys("<Enter>");
        }
    }
}
