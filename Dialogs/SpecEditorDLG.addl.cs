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
using System.Diagnostics;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SpecEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            
            Tag = "[MainWin]$SpecAndCatalogV2Window|Spec Editor for AutoCAD Plant 3D *";

        }

		public override void Invoke()
		{
            //Process.Start("Taskkill /f /im SpecsAndCatalogsEditor.exe");
            var SpecEditorDLG = new SpecEditorDLG();
             if (SpecEditorDLG.Exists)
             {
                 SpecEditorDLG.ClosePB.Click();
                 //SpecEditorDLG.TypeKeys("<Alt-F4>");
                 //Process.Start("Taskkill /f /im SpecsAndCatalogsEditor.exe");
             }
            //string sPath1 = Autodesk.GUIHarness.AutoCAD.Dialogs.AutoCAD.Path + "\\PLNT3D\\SpecsAndCatalogsEditor.exe";
            //string sPath = Autodesk.GUIHarness.AutoCAD.Dialogs.AutoCAD.Path + "PLNT3D\\SpecsAndCatalogsEditor.exe";
            string sPath = LAGT.CommonFiles.Product.Variables.ProductLocation;
            if (!sPath.EndsWith("\\"))
                sPath += "\\";
            sPath += "PLNT3D\\SpecsAndCatalogsEditor.exe";
            System.Threading.Thread.Sleep(2000);
            if (!SpecEditorDLG.Exists)
            {
              
                   Process.Start(sPath);

            }
 
            System.Threading.Thread.Sleep(5000);
            //WelcomeWindow WelcomeWindow = new WelcomeWindow();
            //if (WelcomeWindow.Exists)
            //{
            //    WelcomeWindow.SetActive();
            //    WelcomeWindow.Dismiss1();
            //}
            if (SpecEditorDLG.WaitExists(5000))
            {
                SpecEditorDLG.SetActive();
                //SpecEditorDLG.Restore();
                //SpecEditorDLG.Move(1,1);
                //if (SpecEditorDLG.MaximizePB.Exists)
                //{
                //    SpecEditorDLG.MaximizePB.Click();
                //}
                SpecEditorDLG.Maximize();
                SpecEditorDLG.SetActive();
            }
			
		}

		public override void Dismiss()
		{
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
            SpecEditorDLG.ClosePB.Click();
		}

        //public override void path()
        //{
        //    SpecUtilityOpenSpecDLG SpecUtilityOpenSpecDLG = new SpecUtilityOpenSpecDLG();
        //    SpecUtilityOpenSpecDLG.Invoke();
        //    SpecUtilityOpenSpecDLG.SetActive();
        //    SpecUtilityOpenSpecDLG.TypeKeys(path);
        //    SpecUtilityOpenSpecDLG.Open.Click();
        //    SpecEditorDLG SpecEditorDLG = Current<SpecEditorDLG>();
        //    if (SpecEditorDLG.Exists)
        //    {
        //        SpecEditorDLG.SetActive();
        //    }
			
        //}
        public partial class MenuItem : Control
        {
            //partial void OnInitialize()
            //{
            //}
            public void Pick()
            {
                this.Click(MouseButton.Left, 3, 3);
            }
        }
        public void OpenSpec(string path)
        {
            SpecUtilityOpenSpecDLG SpecUtilityOpenSpecDLG = new SpecUtilityOpenSpecDLG();
            SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
            SpecUtilityOpenSpecDLG.Invoke();
            SpecUtilityOpenSpecDLG.SetActive();
            SpecUtilityOpenSpecDLG.TypeKeys(path);
            SpecUtilityOpenSpecDLG.Open.Click();
            System.Threading.Thread.Sleep(30000);
            //if (SpecEditorDLG.WaitExists(50000))
            //{
            //    SpecEditorDLG.SetActive();
            //}
            int i = 0;
            while (!SpecEditorDLG.WaitExists(15000))
            {
                System.Threading.Thread.Sleep(15000);
                if (SpecEditorDLG.WaitExists(15000))
                {
                    break;
                }
                if (i > 5)
                {
                    break;
                }
                i++;
            }
        }
    }
}
