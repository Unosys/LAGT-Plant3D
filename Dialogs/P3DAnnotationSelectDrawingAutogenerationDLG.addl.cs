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
    public partial class P3DAnnotationSelectDrawingAutogenerationDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$SelectProjectAutogenDlg";
		}

		public  void Invoke()
		{
			P3DAnnotationDefineExpressionDLG P3DAnnotationDefineExpressionDLG = new P3DAnnotationDefineExpressionDLG();
			P3DAnnotationDefineExpressionDLG.Invoke();
			P3DAnnotationDefineExpressionDLG.SetActive();
			System.Threading.Thread.Sleep(3000);
			P3DAnnotationDefineExpressionDLG.Click(MouseButton.Left,195,195);
			RECT Rrect = P3DAnnotationDefineExpressionDLG.GetRect();
			Desktop Desktop = new Desktop();
			Desktop.Click(MouseButton.Left,(Rrect.xPos +32),(Rrect.yPos +203));
            bool bState = P3DAnnotationDefineExpressionDLG.M_noExpressioncheckBox.IsChecked;
			if (bState==true)
			{
				P3DAnnotationDefineExpressionDLG.M_noExpressioncheckBox.Uncheck();
			}
			if ( ! P3DAnnotationDefineExpressionDLG.M_autogenerateCheckBox.IsChecked)
			{
				P3DAnnotationDefineExpressionDLG.M_autogenerateCheckBox.Check();
			}
			P3DAnnotationDefineExpressionDLG.M_drawingFieldRadioButton.Click();
			P3DAnnotationDefineExpressionDLG.M_drawingFieldButton.Click();
		}

		public  void Dismiss()
		{
			P3DAnnotationSelectDrawingAutogenerationDLG P3DAnnotationSelectDrawingAutogenerationDLG = new P3DAnnotationSelectDrawingAutogenerationDLG();
			P3DAnnotationSelectDrawingAutogenerationDLG.M_btnCancel.Click();
			P3DAnnotationDefineExpressionDLG P3DAnnotationDefineExpressionDLG = new P3DAnnotationDefineExpressionDLG();
			P3DAnnotationDefineExpressionDLG.Dismiss();
		}
    }
}
