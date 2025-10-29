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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class ModifyCatalogPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$Window_1";
		}

		public override void Invoke()
		{
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.OpenSpec(LAGT.CommonFiles.Product.Variables.TestFilesDir+"CS150 Flanged.pspx");
			RECT Rrect = SpecEditorDLG.GetRect();
			Desktop Desktop = new Desktop();
			Desktop.Click(MouseButton.Left,(Rrect.xPos + Rrect.xSize - 70),(Rrect.yPos + 65));
            SpecEditorDLG.CatalogsMI.Pick();
            SpecEditorDLG.ModifyCatalogProperties.Pick();
			ModifyCatalogPropertiesDLG ModifyCatalogPropertiesDLG = new ModifyCatalogPropertiesDLG();
			ModifyCatalogPropertiesDLG.SetActive();
            this.SetSize(800,470);
		}

		public override void Dismiss()
		{
			ModifyCatalogPropertiesDLG ModifyCatalogPropertiesDLG = new ModifyCatalogPropertiesDLG();
			ModifyCatalogPropertiesDLG.SetActive();
			ModifyCatalogPropertiesDLG.CancelButton.Click();
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.SetActive();
            //SpecEditorDLG.CloseAll.Click();
			SpecEditorDLG.Dismiss();
		}
        public void SetSize(int xRestSize, int yRestSize)
        {

            RECT r = this.GetRect(true);
            if (r.xSize != xRestSize && r.ySize != yRestSize)
            {
                this.Click(MouseButton.Right, 8, 70);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + xRestSize, r.yPos + yRestSize);
            }
        }
    }
}
