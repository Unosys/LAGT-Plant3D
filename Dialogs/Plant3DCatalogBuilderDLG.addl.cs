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
using System.Diagnostics;
using ProductTestSuite.CommonFiles.TestSuite.GlobalDlgBox;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DCatalogBuilderDLG : MainWin//Window
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        //string sCmd = LAGT.CommonFiles.Product.Variables.ProductLocation +"\\PLNT3D\\AutoCADPlant3DCatalogBuilder.exe" + "/product" + "PLNT3D" + "/language" + LAGT.CommonFiles.Product.Variables.Language + LAGT.CommonFiles.Product.Variables.ProductLocation;
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            
            Tag = "[MainWin]*Autodesk Catalog Builder for AutoCAD Plant 3D 202*|$Window_1";
           
        }

        public void Invoke()
		{
            //string sPath1 = Autodesk.GUIHarness.AutoCAD.Dialogs.AutoCAD.Path + "\\PLNT3D\\AutoCADPlant3DCatalogBuilder.exe";
            //string sPath = Autodesk.GUIHarness.AutoCAD.Dialogs.AutoCAD.Path + "PLNT3D\\AutoCADPlant3DCatalogBuilder.exe";
            string sPath = LAGT.CommonFiles.Product.Variables.ProductLocation;
            if (!sPath.EndsWith("\\"))
                sPath += "\\";
            sPath += "PLNT3D\\AutoCADPlant3DCatalogBuilder.exe";
            Plant3DCatalogBuilderDLG Plant3DCatalogBuilderDLG = new Plant3DCatalogBuilderDLG();
            if (!Plant3DCatalogBuilderDLG.Exists)
			{
               
                    Process.Start(sPath);
                
			}
           
           
            System.Threading.Thread.Sleep(15000);
            Plant3DCatalogBuilderDLG.SetActive();
            //base.Invoke(sCmd);
            //this.SetActive();
            if (!Plant3DCatalogBuilderDLG.HowToCreateA1ST.Exists)
                {
                    Plant3DCatalogBuilderDLG.Chevron.Click();
                }
            //this.Restore();
            //this.Move(1,1);
		}

		public void Dismiss()
		{
			Plant3DCatalogBuilderDLG Plant3DCatalogBuilderDLG = new Plant3DCatalogBuilderDLG();
			Plant3DCatalogBuilderDLG.SetActive();
            Plant3DCatalogBuilderDLG.ClosePB.Click();
		}
    }
}
