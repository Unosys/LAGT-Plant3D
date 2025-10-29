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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
	public partial class DataLinkPropertiesDLG_P3D : DataLinkPropertiesDLG
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
		///// <summary>
		///// OnInitialize() is used to contain additional initialization code
		///// Uncomment the code block below to use it
		///// </summary>
		partial void OnInitialize()
		{
            DataLinkPropertiesDLG DataLinkPropertiesDLG = new DataLinkPropertiesDLG();
            Tag = DataLinkPropertiesDLG.Tag;
        }

        public override void Invoke()
		{
			P3DMapExternalPropertiesDLG P3DMapExternalPropertiesDLG = new P3DMapExternalPropertiesDLG();
			P3DMapExternalPropertiesDLG.Invoke();
			P3DMapExternalPropertiesDLG.AddDataSourcePB.Click();
			System.Threading.Thread.Sleep(5000);
			this.SetActive();
		}

		public override void Dismiss()
		{
			this.CancelPB.Click();

			P3DMapExternalPropertiesDLG P3DMapExternalPropertiesDLG = new P3DMapExternalPropertiesDLG();
			P3DMapExternalPropertiesDLG.Dismiss();

        }
        public void SelectTab(int i = 1)
        {

            RECT r = this.ProviderWIN.GetRect(true);
            Desktop.Current.Click(MouseButton.Left, r.xPos + 5, r.yPos - 5);
            //Desktop.Current.TypeKeys("<Home>");
            if (i != 1)
            {
                Desktop.Current.TypeKeys("<Right " + (i - 1).ToString() + ">");
            }
        }
    }
}
