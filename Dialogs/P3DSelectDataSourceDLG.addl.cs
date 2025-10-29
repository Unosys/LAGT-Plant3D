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
using ProductTestSuite.CommonFiles;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class P3DSelectDataSourceDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$SelectDataSource";
		}

		public  void Invoke()
		{
			P3DAddPropertyDLG P3DAddPropertyDLG = new P3DAddPropertyDLG();
			P3DAddPropertyDLG.Invoke();
			P3DAddPropertyDLG.PropertyNameTF.SetText("temp");
			if (AdOS.IsAsianLanguage)
			{
				P3DAddPropertyDLG.RadioButton2RB.Click();
			}
			else
			{
				P3DAddPropertyDLG.RadioButton2RB.Click();
			}
			P3DAddPropertyDLG.SetActive();
			P3DAddPropertyDLG.OKPB.Click();
		}

		public  void Dismiss()
		{
			P3DSelectDataSourceDLG P3DSelectDataSourceDLG = new P3DSelectDataSourceDLG();
			P3DSelectDataSourceDLG.M_cancelBtn.Click();
			P3DAddPropertyDLG P3DAddPropertyDLG = new P3DAddPropertyDLG();
			P3DAddPropertyDLG.Dismiss();
        }
        public void SelectTab(int i = 1)
        {

            RECT r = this.Pane1.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r.xPos + 10, r.yPos - 10);
            if (i != 1)
            {
                Desktop.Current.TypeKeys("<Right " + (i - 1).ToString() + ">");
            }
        }
    }
}
