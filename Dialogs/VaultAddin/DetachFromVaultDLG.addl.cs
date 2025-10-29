using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class DetachFromVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[DialogBox]" + AcMainWin.cBabel(23165, 2, "Detach from Vault");             
        }
        public override void Invoke()
        {
            Plant3DFunctions.OpenVaultProject("TestVault");
            ProjManUndocked PROJECTMANAGERDLG =new ProjManUndocked();
            PROJECTMANAGERDLG.SetActive();
            Window wTreeView = PROJECTMANAGERDLG.TreeViewTV;
            Plant3DFunctions.ExpandTreeP3D(wTreeView, 0, "0,0,0");
            //RECT rRect = wTreeView.GetRect();
            //string sTreePath = wTreeView.IsActive.ToString();
            //RECT rRect = wTreeView.GetRect(IsActive);
            //wTreeView.Click(MouseButton.Right,rRect.xPos+8, rRect.yPos+8);
            wTreeView.TypeKeys("<Down 3><Right><Down 5><Enter>");
            System.Threading.Thread.Sleep(3000);
            DetachFromVaultDLG DetachFromVaultDLG = new DetachFromVaultDLG();
            DetachFromVaultDLG.SetActive();
        }

        public override void Dismiss()
        {
            DetachFromVaultDLG DetachFromVaultDLG = new DetachFromVaultDLG();
            DetachFromVaultDLG.Cancel.Click();
            System.Threading.Thread.Sleep(3000);
            Plant3DFunctions.SetToDefault();
        }
    }
}
