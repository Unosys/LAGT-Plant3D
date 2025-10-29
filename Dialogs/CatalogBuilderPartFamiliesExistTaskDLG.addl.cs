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
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CatalogBuilderPartFamiliesExistTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[MainWin]$Window_1";
        }

        public override void Invoke()
        {
            //string saveAsName = "{TimeStr ()}"
            //saveAsName = StrTran (saveAsName, ":", "_")
            string saveAsName = DateTime.Now.ToString();
            AdResultLog.Current.Log(saveAsName);
            saveAsName = saveAsName.Replace(":", "_").Replace("/", "_");
            SaveAsNewCatalogDLG SaveAsNewCatalogDLG = new SaveAsNewCatalogDLG();
            SaveAsNewCatalogDLG.Invoke();
            System.Threading.Thread.Sleep(5000);
            Desktop.Current.TypeKeys(saveAsName);
            SaveAsNewCatalogDLG.Save.Click();

            System.Threading.Thread.Sleep(10000);
            BuildCatalogSingleDLG BuildCatalogSingleDLG = new BuildCatalogSingleDLG();
            BuildCatalogSingleDLG.AddToExistingPB.Click();
            SelectCatalogToAddIntoDLG SelectCatalogToAddIntoDLG = new SelectCatalogToAddIntoDLG();
            SelectCatalogToAddIntoDLG.SetActive();
            Desktop.Current.TypeKeys(saveAsName);
            //SelectCatalogToAddIntoDLG.FileName1.SetText("test-cs150")
            SelectCatalogToAddIntoDLG.Open.Click();
            System.Threading.Thread.Sleep(3000);
            if (SelectCatalogToAddIntoDLG.YesPB.Exists)
            {
                SelectCatalogToAddIntoDLG.YesPB.Click();
            }
            System.Threading.Thread.Sleep(10000);
            CatalogBuilderPartFamiliesExistTaskDLG CatalogBuilderPartFamiliesExistTaskDLG = new CatalogBuilderPartFamiliesExistTaskDLG();
            if (!CatalogBuilderPartFamiliesExistTaskDLG.CancelPB.Exists)
            {
                BuildCatalogSingleDLG.AddToExistingPB.Click();
                SelectCatalogToAddIntoDLG.SetActive();
                Desktop.Current.TypeKeys(saveAsName);

                SelectCatalogToAddIntoDLG.Open.Click();
            }
            CatalogBuilderPartFamiliesExistTaskDLG.SetActive();
        }

        public void Dismiss()
        {
            CatalogBuilderPartFamiliesExistTaskDLG CatalogBuilderPartFamiliesExistTaskDLG = new CatalogBuilderPartFamiliesExistTaskDLG();
            CatalogBuilderPartFamiliesExistTaskDLG.Close();
            BuildCatalogSingleDLG BuildCatalogSingleDLG = new BuildCatalogSingleDLG();
            BuildCatalogSingleDLG.Dismiss();
        }
    }
}
