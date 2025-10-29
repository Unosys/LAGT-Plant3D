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
using Autodesk.GUIHarness.Plant3d.Core;
using Microsoft.Win32;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class AddBoltStandardDLG : Window
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$StandardBoltLengthAddMappingDialog";
		}
		public virtual string Contentpath
		{

            get { return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Autodesk\AutoCAD", "CurVer", "").ToString(); }
            set {; }
        }
		public void Invoke()
		{
			SpecUtilityOpenCatDLG SpecUtilityOpenCatDLG = new SpecUtilityOpenCatDLG();
			SpecUtilityOpenCatDLG.Invoke();
            //SpecUtilityOpenCatDLG.FileNameCB.SetText("C:\\AutoCAD Plant 3D 2025 Content\\CPak ASME\\ASME Pipes and Fittings Catalog.pcat");
            SpecUtilityOpenCatDLG.FileNameCB.SetText(Plant3dConstants.Contentpath+"\\CPak ASME\\ASME Pipes and Fittings Catalog.pcat");

            SpecUtilityOpenCatDLG.Open.Click();
			System.Threading.Thread.Sleep(10000);
			SpecEditorDLG SpecEditorDLG = new SpecEditorDLG();
			SpecEditorDLG.CatalogEditor.Click();
            SpecEditorDLG.CatalogsMI.Pick();
            SpecEditorDLG.EditBoltLengthMapping.Pick();
			BoltLengthMappingDLG BoltLengthMappingDLG = new BoltLengthMappingDLG();
			BoltLengthMappingDLG.AddBoltStandardPB.Click();
            System.Threading.Thread.Sleep(5000);
            AddBoltStandardDLG AddBoltStandardDLG = new AddBoltStandardDLG();
            AddBoltStandardDLG.SetActive();
		}

		public void Dismiss()
		{
			AddBoltStandardDLG AddBoltStandardDLG = new AddBoltStandardDLG();
			AddBoltStandardDLG.SetActive();
			AddBoltStandardDLG.TypeKeys("<esc>");
			BoltLengthMappingDLG BoltLengthMappingDLG = new BoltLengthMappingDLG();
			BoltLengthMappingDLG.Dismiss();
		}
    }
}
