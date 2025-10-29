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
using Autodesk.GUIHarness.AutoCAD;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class StyleAlreadyExistsInDrawingErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "~ActiveApp/[DialogBox]" + AcMainWin.cBabel(517,16,"Error");
		}

		public override void Invoke()
		{
			CreateClassDLG CreateClassDLG = new CreateClassDLG();
			CreateClassDLG.Invoke();
			CreateClassDLG.M_textBoxName.SetText("temp");
			CreateClassDLG.M_btnOk.Click();
			DuplicateDefinitionDLG DuplicateDefinitionDLG = new DuplicateDefinitionDLG();
			if (DuplicateDefinitionDLG.Exists)
			{
				DuplicateDefinitionDLG.OK.Click();
				CreateClassDLG.M_btnCancel.Click();
			}
			StepsRepeat(2);
		}

		public override void Dismiss()
		{
			StyleAlreadyExistsInDrawingErrorDLG StyleAlreadyExistsInDrawingErrorDLG = new StyleAlreadyExistsInDrawingErrorDLG();
			StyleAlreadyExistsInDrawingErrorDLG.OK.Click();
			ClassDefinitionOrSymbolNameRequiredDLG ClassDefinitionOrSymbolNameRequiredDLG = new ClassDefinitionOrSymbolNameRequiredDLG();
			ClassDefinitionOrSymbolNameRequiredDLG.OK.Click();
			AddSymbolsEditSymbolSettingsDLG AddSymbolsEditSymbolSettingsDLG = new AddSymbolsEditSymbolSettingsDLG();
			AddSymbolsEditSymbolSettingsDLG.Close();
			ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
			ProjectSetupPandIDClassDefinitionDLG.Dismiss();
		}

		public void StepsRepeat(int i)
		{
			int j;
            for (j = 1; j <= i; j++)
            {
                ProjectSetupPandIDClassDefinitionDLG ProjectSetupPandIDClassDefinitionDLG = new ProjectSetupPandIDClassDefinitionDLG();
                ProjectSetupPandIDClassDefinitionDLG.M_btnAddStyle.Click();
                AddSymbolsSelectSymbolsDLG AddSymbolsSelectSymbolsDLG = new AddSymbolsSelectSymbolsDLG();
                AddSymbolsSelectSymbolsDLG.M_BrowseBtn.Click();
                SelectBlockDrawingDLG SelectBlockDrawingDLG = new SelectBlockDrawingDLG();
                SelectBlockDrawingDLG.SetActive();
                SelectBlockDrawingDLG.OpenPB.Click();
                AddSymbolsSelectSymbolsDLG.SetActive();
                AddSymbolsSelectSymbolsDLG.M_AddBtn.Click();
                AddSymbolsSelectSymbolsDLG.M_NextBtn.Click();
                AddSymbolsEditSymbolSettingsDLG AddSymbolsEditSymbolSettingsDLG = new AddSymbolsEditSymbolSettingsDLG();
                AddSymbolsEditSymbolSettingsDLG.BrowsePB.Click();
                SelectPIDClassDLG SelectPIDClassDLG = new SelectPIDClassDLG();
                SelectPIDClassDLG.SetActive();
                SelectPIDClassDLG.ClassTreeView.Select("/#1");
                SelectPIDClassDLG.ClassTreeView.TypeKeys("<right 2>");
                SelectPIDClassDLG.OK.Click();
                AddSymbolsEditSymbolSettingsDLG.ListBox1.Click();
                AddSymbolsEditSymbolSettingsDLG.ListBox1.TypeKeys("<Tab>Test<Enter>");
                AddSymbolsEditSymbolSettingsDLG.FinishPB.Click();
            }
		}
    }
}
