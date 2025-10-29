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
    public partial class IsoStyleEditorSave : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[MainWin]$Window_1" + "|" + AcMainWin.cBabel(23165, 30, "Iso Style Editor") + "*C*";

            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //    case "JPN":
            //    case "DEU":
            //    case "CHS":
            //    case "FRA":
            //    case "RUS":
            //        Tag = Plant3DFunctions.GetLocString("IsoStyleEditorSave");
            //        break;

            //    default:
            //        Tag = "~ActiveApp/[DialogBox]" + AcMainWin.cBabel(23165, 30, "Iso Style Editor") + "|" + "*Iso*";
            //        break;
            //}
        }

        public override void Invoke()
        {
            IsoStyleEditorDLG IsoStyleEditorDLG = new IsoStyleEditorDLG();
            IsoStyleEditorDLG.Invoke();
            System.Threading.Thread.Sleep(1000);
            if (IsoStyleEditorDLG.CheckBox1CK.IsChecked)
            {
                IsoStyleEditorDLG.CheckBox1CK.Uncheck();

            }
            System.Threading.Thread.Sleep(1000);
            if (!IsoStyleEditorDLG.CheckBox1CK.IsChecked)
            {
                IsoStyleEditorDLG.CheckBox1CK.Check();

            }
            IsoStyleEditorDLG.SetActive();
            IsoStyleEditorDLG.FileMI.Pick();            
            //IsoStyleEditorDLG.CheckBox2CK.Check();
            IsoStyleEditorDLG.TypeKeys("<Down 2><Enter>");//Save
            System.Threading.Thread.Sleep(3000);
        }

        public override void Dismiss()
        {
            this.OKPB.Click();
            IsoStyleEditorDLG IsoStyleEditorDLG = new IsoStyleEditorDLG();
            IsoStyleEditorDLG.Dismiss();
            
            

        }
    }
}
