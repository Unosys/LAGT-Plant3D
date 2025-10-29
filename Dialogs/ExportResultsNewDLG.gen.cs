// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Export results[1]|$ExportResultsForm", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class ExportResultsNewDLG : Pane
    {
        public  ListBox M_exportsListBox;
        public  ListBoxItem CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADPlant3DLBI;
        public  PushButton M_okBtn;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ExportResultsNewDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_exportsListBox = new ListBox()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel/[ListBox]Export succeeded*|$m_exportsListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_exportsListBox);

            CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADPlant3DLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel/[ListBox]Export succeeded*|$m_exportsListBox/[ListBoxItem]C:*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADPlant3DLBI);

            M_okBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel/[PushButton]OK|$m_okBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Export results|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
