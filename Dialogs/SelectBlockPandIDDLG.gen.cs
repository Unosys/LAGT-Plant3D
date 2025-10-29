// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Block", Parent = typeof(Plant3D))]
    public partial class SelectBlockPandIDDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  PushButton Cancel;
        public  StaticText Preview;
        public  CustomWin AutodeskProcessPowerPnPProje;
        public  ListBox AvailableBlocks;
        public  StaticText AvailableBlocksText;

        partial void OnInitialize();

        public SelectBlockPandIDDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Preview = new StaticText()
            {
                Tag = "[StaticText]#1|$m_groupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview);

            AutodeskProcessPowerPnPProje = new CustomWin()
            {
                Tag = "[Autodesk.ProcessPower.PnPProjectSetup.GSPreviewCtrl]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerPnPProje);

            AvailableBlocks = new ListBox()
            {
                Tag = "[ListBox]#1|$m_listBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AvailableBlocks);

            AvailableBlocksText = new StaticText()
            {
                Tag = "[StaticText]#1|$m_labelBlkList",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AvailableBlocksText);
        }
    }
}
