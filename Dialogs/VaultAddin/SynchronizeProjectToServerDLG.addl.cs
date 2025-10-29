// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SynchronizeProjectToServerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            Tag = "[DialogBox]" + AcMainWin.cBabel(23165, 26, "Synchronize to Vault").Replace('.',' ').Trim()+"|*Vault*";
		}

		public override void Invoke()
		{
            //CheckInDLG CheckInDLG = new CheckInDLG();
            //CheckInDLG.Invoke();
            //CheckInDLG.SetActive();
            //CheckInDLG.OK.Click();
            //System.Threading.Thread.Sleep(20000);
            //ProjectDataMergedVaultDLG ProjectDataMergedVaultDLG = Current<ProjectDataMergedVaultDLG>();
            //ProjectDataMergedVaultDLG.SetActive();
            //ProjectDataMergedVaultDLG.BtnOk.Click();
            //Drawing.Current.TypeE("<Esc>");
            //Drawing.Current.TypeE("<Esc>");
         //   Console.WriteLine(AcMainWin.cBabel(23165, 26, "Synchronize to Vault").Replace('.', ' ').Trim());
            Plant3DFunctions.OpenVaultProject("TestVault");
            Random randnum = new Random();
            String number = "Draw" + (randnum.Next(2, 9));
            Plant3DFunctions.CreateVaultDrawing("P3D", "no", number);
            System.Threading.Thread.Sleep(2000);
            Drawing.Current.TypeE("_PLANTPIPEADD");
            Drawing.Current.TypeE("20");
            Drawing.Current.TypeE("100");
            System.Threading.Thread.Sleep(3000);
            PipingPipeSpecNotLoaded PipingPipeSpecNotLoaded = new PipingPipeSpecNotLoaded();
            if (PipingPipeSpecNotLoaded.Exists)
            {
                PipingPipeSpecNotLoaded.Dismiss();
            }
            Drawing.Current.TypeE("");
            //Drawing.Current.TypeE("");
            //Drawing.Current.TypeE("");
            Plant3DFunctions.CreateVaultDrawing("P3D", "no", "abc1");
            Drawing.Current.TypeE("_PLANTPIPEADD");
            Drawing.Current.TypeE("20");
            Drawing.Current.TypeE("100");
            System.Threading.Thread.Sleep(3000);
            if (PipingPipeSpecNotLoaded.Exists)
            {
                PipingPipeSpecNotLoaded.Dismiss();
            }
            Drawing.Current.TypeE("");
			Drawing.Current.TypeE("_PLANTSYNCHRONIZETOVAULT");
            System.Threading.Thread.Sleep(7000);
			SynchronizeProjectToServerDLG SynchronizeProjectToServerDLG = new SynchronizeProjectToServerDLG();
			SynchronizeProjectToServerDLG.SetActive();
            SynchronizeProjectToServerDLG.ShowDetailsPB.Click();
            System.Threading.Thread.Sleep(8000);
		}

		public override void Dismiss()
		{
            SynchronizeProjectToServerDLG SynchronizeProjectToServerDLG = new SynchronizeProjectToServerDLG();
            SynchronizeProjectToServerDLG.SetActive();
			SynchronizeProjectToServerDLG.Cancel.Click();
            System.Threading.Thread.Sleep(3000);
            //Plant3DFunctions.CheckInDrawing();
            //Plant3DFunctions.CheckOutDrawing();
            Drawing.Current.TypeE("_CLOSE");
            System.Threading.Thread.Sleep(2000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_CLOSE");
            System.Threading.Thread.Sleep(2000);
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.DeleteVaultDrawing("P3D");
            System.Threading.Thread.Sleep(6000);
            //Plant3DFunctions.CheckOutDrawing();
            Plant3DFunctions.DeleteVaultDrawing("P3D");
            Plant3DFunctions.SetToDefault();
		}
    }
}
