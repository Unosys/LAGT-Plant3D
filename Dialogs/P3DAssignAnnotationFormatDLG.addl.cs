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
using LAGT.CommonFiles;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class P3DAssignAnnotationFormatDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Pane]$TagformatSetupDlg";
		}

		public  void Invoke()
		{
			P3DPipandEquipmentDLG P3DPipandEquipmentDLG = new P3DPipandEquipmentDLG();
            Drawing.Current.TypeE("RIBBON");
			P3DPipandEquipmentDLG.Invoke();
			ProjectSetupPalnt3DAnnotationDLG ProjectSetupPalnt3DAnnotationDLG = new ProjectSetupPalnt3DAnnotationDLG();
			ProjectSetupPalnt3DAnnotationDLG.M_btnModifyAnn.Click();
			System.Threading.Thread.Sleep(2000);
			SymbolSettingsDLG SymbolSettingsDLG = new SymbolSettingsDLG();
			SymbolSettingsDLG.TypeKeys("<tab 5><Enter>");
			P3DSelectBlockDrawingDLG P3DSelectBlockDrawingDLG = new P3DSelectBlockDrawingDLG();
           // P3DSelectBlockDrawingDLG.FileNameTextField.TypeKeys(Dialogs.Plant3D.Path+"PLNT3D\\AnnotationTemplates.dwg");
            P3DSelectBlockDrawingDLG.FileNameTextField.TypeKeys(Product.Variables.TestFilesDir + "EditAnnotation.dwg");
          
            System.Threading.Thread.Sleep(2000);
            P3DSelectBlockDrawingDLG.Open.Click();
			P3DSelectBlockDLG P3DSelectBlockDLG = new P3DSelectBlockDLG();
			P3DSelectBlockDLG.TypeKeys("<Down>");
			P3DSelectBlockDLG.OK.Click();
			SymbolSettingsDLG.OK.Click();
			ProjectSetupPalnt3DAnnotationDLG.M_btnEditAnn.Click();
            //Drawing.Current.WaitExists();
			System.Threading.Thread.Sleep(3000);
			Drawing.Current.TypeE("ASSIGN_ANNOT_FORMAT");
            //Drawing.Current.TypeE("0.267,0.057");//doubleclick  the dwg
            Drawing.Current.TypeE("0,0");//doubleclick  the dwg
            System.Threading.Thread.Sleep(2000);
			this.M_btnMoreless.Click();
            this.Size(500,300);
            this.SetActive();
        }

		public  void Dismiss()
		{
			this.M_btnCancel.Click();
            //Drawing.Current.TypeE("_bclose");
            Drawing.Current.TypeE("_Close");
            System.Threading.Thread.Sleep(2000);
            PandIDWarningAutoCADDLG PandIDWarningAutoCADDLG = new PandIDWarningAutoCADDLG();
            if (PandIDWarningAutoCADDLG.Exists)
            {
                PandIDWarningAutoCADDLG.No.Click();
            }

            System.Threading.Thread.Sleep(8000);
			ProjectSetupPlant3DDWG ProjectSetupPlant3DDWG = new ProjectSetupPlant3DDWG();
			ProjectSetupPlant3DDWG.WaitExists(5000);
            if (ProjectSetupPlant3DDWG.Exists)
            {
                ProjectSetupPlant3DDWG.Dismiss();
            }
            
		}
        public void SetSize()
        {
           
            RECT r = this.GetRect(true);
            if (r.xSize != 500 && r.ySize != 500)
            {
                this.Click(MouseButton.Right, 10, 5);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + 500, r.yPos + 300);
            }
        }
    }
}
