// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SpecUpdateAvailableDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2017";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = AcMainWin.cBabel(23073, 30, "Spec Update Available");
        }
        public override void Invoke()
        {
            SelectFilesToCopyToProjectDLG SelectFilesToCopyToProjectDLG = new SelectFilesToCopyToProjectDLG();
            SelectFilesToCopyToProjectDLG.Invoke();
            SelectFilesToCopyToProjectDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SpecUpdateAvailableSpec.pspx");
            SelectFilesToCopyToProjectDLG.OpenPB.Click();
            SpecAlreadyExistsErrorDLG SpecAlreadyExistsErrorDLG = new SpecAlreadyExistsErrorDLG();
            if (SpecAlreadyExistsErrorDLG.Exists)
            {
                SpecAlreadyExistsErrorDLG.OKPB.Click();
            }
            SpecAleadyExistsWarningDLG SpecAleadyExistsWarningDLG = new SpecAleadyExistsWarningDLG();
            if (SpecAleadyExistsWarningDLG.Exists)
            {
                SpecAleadyExistsWarningDLG.YesPB.Click();
            }

            Plant3DFunctions.CopyDrawing("TestSpecUpdateAvailable.dwg");
            System.Threading.Thread.Sleep(2000);
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.PipeSpecsTVI.Click();
            ProjManUndocked.PipeSpecsTVI.TypeKeys("<Right><Down>");
            ProjManUndocked.TypeKeys("Spec");
            System.Threading.Thread.Sleep(1000);
            RECT rTree = ProjManUndocked.TreeViewTV.GetRect();
            ProjManUndocked.TreeViewTV.Click(MouseButton.Right, rTree.xPos + 5, rTree.ySize - 20);
            System.Threading.Thread.Sleep(5000);
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
                    ProjManUndocked.TypeKeys("<Down 2><Enter>", 250);
                    break;
                default:
                    ProjManUndocked.TypeKeys("<Down 3><Enter>", 250);
                    break;
            }
            System.Threading.Thread.Sleep(10000);
            CatalognotfoundDLG CatalognotfoundDLG = new CatalognotfoundDLG();
            if (CatalognotfoundDLG.Exists)
            {
                CatalognotfoundDLG.CancelPB.Click();
            }
            System.Threading.Thread.Sleep(3000);
            SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
            SpecEditorDLG.Maximize();
            SpecEditorDLG.SetActive();
            //RECT Swind = SpecEditorDLG.SpecSheetListView.GetRect();
            //SpecEditorDLG.Click(MouseButton.Left,Swind.xPos + 45, Swind.yPos + 45);
            //SpecEditorDLG.TypeKeys("<Down 2>");
            //SpecEditorDLG.EditParts.Click();

            try 
            { 
                SpecEditorDLG.SpecSheetListView.Select(2); 
            } catch 
            { 
                SpecEditorDLG.SpecSheetEditorRow2LVI.Click(); 
            }
            //SpecEditorDLG.PropertyEditorPB.Click();
            //SpecUtilityEditpartsPartListDLG SpecUtilityEditpartsPartListDLG = new SpecUtilityEditpartsPartListDLG();
            //SpecUtilityEditpartsPartListDLG.RemoveFromSpecRow1CK.Click();
            //SpecUtilityEditpartsPartListDLG.TypeKeys("<Right 2>");            
            //string Specname = DateTime.Now.ToString();
            //Specname = Specname.Replace(":", "_").Replace("/", "_");
            //SpecUtilityEditpartsPartListDLG.TypeKeys(Specname);
            //SpecUtilityEditpartsPartListDLG.OKPB.Click();
            SpecEditorDLG.ManufacturerTF.SetText("TEST");
            SpecEditorDLG.SavePB.Click();
            System.Threading.Thread.Sleep(3000);
            SpecEditorDLG.TypeKeys("<Alt-F4>");
            SpecandCatalogsEditorDLG SpecandCatalogsEditorDLG = new SpecandCatalogsEditorDLG();
            if (SpecandCatalogsEditorDLG.Exists){
                SpecandCatalogsEditorDLG.YesPB.Click(); 
            }

            System.Threading.Thread.Sleep(5000);
            Drawing.Current.SetActive();
            Drawing.Current.TypeE("_PLANTSPECUPDATECHECK");

        }

        public override void Dismiss()
        {
            this.TypeKeys("<Esc>");
            System.Threading.Thread.Sleep(2000);
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.TreeViewTV.Click(MouseButton.Left, 1, 1);
            ProjManUndocked.TreeViewTV.TypeKeys("<Home>");
            ProjManUndocked.PipeSpecsTVI.Click();
            ProjManUndocked.PipeSpecsTVI.TypeKeys("<Subtract>");
            Plant3DFunctions.DeleteAllDrawings();

        }
    }
}
