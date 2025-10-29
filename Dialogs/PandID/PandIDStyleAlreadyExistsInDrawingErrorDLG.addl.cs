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
    public partial class PandIDStyleAlreadyExistsInDrawingErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[DialogBox]" + AcMainWin.cBabel(517,16,"Error");
		}

		public override void Invoke()
		{
			PandIDCreateClassDLG PandIDCreateClassDLG = new PandIDCreateClassDLG();
			PandIDCreateClassDLG.Invoke();
			PandIDCreateClassDLG.M_textBoxName.SetText("temp");
			PandIDCreateClassDLG.M_btnOk.Click();
			PandIDDuplicateDefinitionDLG PandIDDuplicateDefinitionDLG = new PandIDDuplicateDefinitionDLG();
            PandIDProjectSetupPandIDClassDefinitionDLG PandIDProjectSetupPandIDClassDefinitionDLG=new PandIDProjectSetupPandIDClassDefinitionDLG();
			if (PandIDDuplicateDefinitionDLG.Exists)
			{
				PandIDDuplicateDefinitionDLG.OK.Click();
				PandIDCreateClassDLG.M_btnCancel.Click();
			}
            //else
            //{
            //    PandIDProjectSetupPandIDClassDefinitionDLG.SetActive();
            //    PandIDCreateClassDLG.Invoke();
            //    PandIDCreateClassDLG.M_textBoxName.SetText("temp");
            //    PandIDCreateClassDLG.M_btnOk.Click();
            //}

            StepsRepeat(2);
		}

		public override void Dismiss()
		{
            this.Close();
            System.Threading.Thread.Sleep(2000);
            PandIDClassDefinitionOrSymbolNameRequiredDeskTop PandIDClassDefinitionOrSymbolNameRequiredDLG = new PandIDClassDefinitionOrSymbolNameRequiredDeskTop();
            PandIDClassDefinitionOrSymbolNameRequiredDLG.RadioButton1RB.Select();
            PandIDClassDefinitionOrSymbolNameRequiredDLG.OKPB.Click();
			//PandIDAddSymbolsEditSymbolSettingsDLG PandIDAddSymbolsEditSymbolSettingsDLG = Current<PandIDAddSymbolsEditSymbolSettingsDLG>();
			//PandIDAddSymbolsEditSymbolSettingsDLG.Close();
			PandIDProjectSetupPandIDClassDefinitionDLG PandIDProjectSetupPandIDClassDefinitionDLG = new PandIDProjectSetupPandIDClassDefinitionDLG();
			PandIDProjectSetupPandIDClassDefinitionDLG.Dismiss();
		}

		public void StepsRepeat(int i)
		{
			int j;
            PandIDStyleAlreadyExistsInDrawingErrorDLG PandIDStyleAlreadyExistsInDrawingErrorDLG = new PandIDStyleAlreadyExistsInDrawingErrorDLG();
            for (j = 1; j <= i; j++)
            {
                if (!PandIDStyleAlreadyExistsInDrawingErrorDLG.Exists)
                {
                    PandIDProjectSetupPandIDClassDefinitionDLG PandIDProjectSetupPandIDClassDefinitionDLG = Current<PandIDProjectSetupPandIDClassDefinitionDLG>();
                    PandIDProjectSetupPandIDClassDefinitionDLG.M_btnAddStyle.Click();
                    PandIDAddSymbolsSelectSymbolsDLG PandIDAddSymbolsSelectSymbolsDLG = Current<PandIDAddSymbolsSelectSymbolsDLG>();
                    PandIDAddSymbolsSelectSymbolsDLG.M_BrowseBtn.Click();
                    PandIDSelectBlockDrawingDLG PandIDSelectBlockDrawingDLG = Current<PandIDSelectBlockDrawingDLG>();
                    PandIDSelectBlockDrawingDLG.SetActive();
                    //                 if (LAGT.CommonFiles.Product.Variables.Language == "FRA"||LAGT.CommonFiles.Product.Variables.Language == "KOR")
                    //         {
                    //           PandIDSelectBlockDrawingDLG.FileNameCB.SetText(Product.Variables.ProductLocation + @"\PLNT3D\SymbolLibrary\DIN_Equipment.dwg");

                    //         }
                    //         else{
                    //PandIDSelectBlockDrawingDLG.FileNameCB.SetText(Product.Variables.ProductLocation + @"PLNT3D\SymbolLibrary\DIN_Equipment.dwg");

                    //} string installpath = LAGT.CommonFiles.Product.Variables.ProductLocation;

                    string installpath = LAGT.CommonFiles.Product.Variables.ProductLocation;

                    if (!installpath.EndsWith("\\"))
                        installpath += "\\";
                    PandIDSelectBlockDrawingDLG.FileNameCB.SetText(installpath + @"PLNT3D\SymbolLibrary\DIN_Equipment.dwg");

                    PandIDSelectBlockDrawingDLG.OpenPB.Click();
                    System.Threading.Thread.Sleep(2000);
                    PandIDAddSymbolsSelectSymbolsDLG.SetActive();
                    PandIDAddSymbolsSelectSymbolsDLG.M_AddBtn.Click();
                    PandIDAddSymbolsSelectSymbolsDLG.M_NextBtn.Click();
                    PandIDAddSymbolsEditSymbolSettingsDLG PandIDAddSymbolsEditSymbolSettingsDLG = Current<PandIDAddSymbolsEditSymbolSettingsDLG>();
                    PandIDAddSymbolsEditSymbolSettingsDLG.BrowsePB.Click();
                    PandIDSelectPIDClassDLG PandIDSelectPIDClassDLG = new PandIDSelectPIDClassDLG();
                    PandIDSelectPIDClassDLG.SetActive();
                    PandIDSelectPIDClassDLG.ClassTreeView.Select(0);
                    PandIDSelectPIDClassDLG.ClassTreeView.TypeKeys("<right 2>");
                    PandIDSelectPIDClassDLG.BtnOK.Click();
                    System.Threading.Thread.Sleep(2000);
                    PandIDAddSymbolsEditSymbolSettingsDLG.SelectedBlocks.Click();
                    PandIDAddSymbolsEditSymbolSettingsDLG.SelectedBlocks.TypeKeys("<Tab>Test<Enter>");
                    PandIDAddSymbolsEditSymbolSettingsDLG.Finish.Click();
                    System.Threading.Thread.Sleep(2000);
                }
            }
		}
    }
}
