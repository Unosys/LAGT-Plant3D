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
    public partial class AttachExternalReferencesFromVault_CheckinDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$frmVaultAttachReferences";
            //Tag = "[DialogBox]" + AcMainWin.cBabel(23165,22, "Attach External References from Vault");
        }

        public override void Invoke()
        {
            CheckInDLG CheckInDLG = new CheckInDLG();
            CheckInDLG.Invoke();
            CheckInDLG.OK.Click();
            System.Threading.Thread.Sleep(30000);
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
            Window wTreeView=PROJECTMANAGERDLG .TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 1, "0,2,1");
            Drawing.Current.TypeE("_PLANTVAULTATTACH");
            System.Threading.Thread.Sleep(6000);
        }

        public override void Dismiss()
        {
            AttachExternalReferencesFromVault_CheckinDLG AttachExternalReferencesFromVault_CheckinDLG = new AttachExternalReferencesFromVault_CheckinDLG();
            AttachExternalReferencesFromVault_CheckinDLG.OK.Click();
            System.Threading.Thread.Sleep(15000);
            Drawing.Current.TypeE("_CLOSE");
            System.Threading.Thread.Sleep(2000);
            SaveChangesMSG SaveChangesMSG = new SaveChangesMSG();
            if (SaveChangesMSG.Exists)
            {
                SaveChangesMSG.NoPB.Click();

            }
            Plant3DFunctions.DeleteVaultDrawing("P3D");
            Plant3DFunctions.SetToDefault();
        }
    }
}
