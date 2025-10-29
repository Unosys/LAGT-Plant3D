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
	public partial class PandIDMapExternalPropertiesDLG_AddDataStore : Autodesk.GUIHarness.AutoCAD.AcDialogBox
	{
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
		///// <summary>
		///// OnInitialize() is used to contain additional initialization code
		///// Uncomment the code block below to use it
		///// </summary>
		partial void OnInitialize()
		{
			Tag = "[Window]$Window_1"; //Map External Properties
		}

		public override void Invoke()
		{

			PandIDMapExternalPropertiesDLG PandIDMapExternalPropertiesDLG = new PandIDMapExternalPropertiesDLG();
			PandIDMapExternalPropertiesDLG.Invoke();
			PandIDMapExternalPropertiesDLG.AddDataSourcePB.Click();
			System.Threading.Thread.Sleep(5000);
			DataLinkPropertiesDLG_PandID DataLinkPropertiesDLG_PandID = new DataLinkPropertiesDLG_PandID();	
			DataLinkPropertiesDLG_PandID.SelectTheDataYouLV.Select(3);//Microsoft Office 16*
			DataLinkPropertiesDLG_PandID.NextPB.Click();
			DataLinkPropertiesDLG_PandID.oneSelectOrEnterCB.SetText(@"\\10.194.1.6\sqa\Projects\Projects\Autodesk\Manual Testing\13. FY24\Plant_3D_2024\7. New Feature_Materials\XDBmanager\2019_IMP_MUP_Piping_Imported.accdb");
			DataLinkPropertiesDLG_PandID.OKPB.Click();
			System.Threading.Thread.Sleep(10000);
			this.SetActive();
		}

		public override void Dismiss()
		{
			PandIDMapExternalPropertiesDLG PandIDMapExternalPropertiesDLG = new PandIDMapExternalPropertiesDLG();
			PandIDMapExternalPropertiesDLG.Dismiss();

		}
	}
}
