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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class LoginRequiredDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "[DialogBox]" + AcMainWin.cBabel(23165,5,"Login Required");
		}

		public override void Invoke()
		{
         //   Plant3DFunctions.OpenVaultProject("Proj1");
            CheckInDLG CheckInDLG = new CheckInDLG();
            CheckInDLG.Invoke();
            CheckInDLG.SetActive();
            CheckInDLG.OK.Click();
            System.Threading.Thread.Sleep(10000);
            Drawing.Current.TypeE("_PLANTVAULTLOGOUT");
            VaultLogOutDLG VaultLogOutDLG = Current<VaultLogOutDLG>();
            VaultLogOutDLG.SetActive();
            VaultLogOutDLG.ClosePB.Click();
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();         
            PROJECTMANAGERDLG.SetActive();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 3, "0,2,1");            
            RemoveDrawingsFromProjectDLG RemoveDrawingsFromProjectDLG = new RemoveDrawingsFromProjectDLG();
            if (RemoveDrawingsFromProjectDLG.WaitExists(2000))
            {
                RemoveDrawingsFromProjectDLG.RemoveTheDrawingsFromPB.Click();
                System.Threading.Thread.Sleep(1000);
            }
            RemoveDrawingFromProjectDLG RemoveDrawingFromProjectDLG = new RemoveDrawingFromProjectDLG();
            if (RemoveDrawingFromProjectDLG.WaitExists(2000))
            {
                RemoveDrawingFromProjectDLG.RemoveTheDrawingFromPB.Click();
                System.Threading.Thread.Sleep(1000);
            }
            LoginRequiredDLG LoginRequiredDLG = new LoginRequiredDLG();
            LoginRequiredDLG.SetActive();
		}

		public override void Dismiss()
		{
            LoginRequiredDLG LoginRequiredDLG = new LoginRequiredDLG();
            LoginRequiredDLG.SetActive();
            LoginRequiredDLG.OK.Click();
            Drawing.Current.TypeE("_PLANTVAULTLOGIN");
            VaultLogInDLG VaultLogInDLG = new VaultLogInDLG();
            VaultLogInDLG.OK.Click();
            System.Threading.Thread.Sleep(3000);
          
            Plant3DFunctions.DeleteVaultDrawing("P3D");
            System.Threading.Thread.Sleep(3000);
            Plant3DFunctions.SetToDefault();
		}
    }
}
