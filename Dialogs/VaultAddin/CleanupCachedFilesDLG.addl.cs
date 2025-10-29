using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using System;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CleanupCachedFilesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[DialogBox]"+AcMainWin.cBabel(23165,23,"Cleanup Cached Files");
        }

        public override void Invoke()
        {
            Plant3DFunctions.OpenVaultProject("TestVault");
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.DefaultProjectTVI.Click(MouseButton.Right);
            Desktop.Current.TypeKeys("<Down 6><Enter>");//Cleanup Cached Files

        }
        public override void Dismiss()
        {
            this.CancelPB.Click();
            Plant3DFunctions.SetToDefault();
        }
    }
}
