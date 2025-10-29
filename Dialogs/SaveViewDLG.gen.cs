// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Save View|$frmSaveViewDetails", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class SaveViewDLG : Pane
    {
        public  ListBox ViewList;
        public  PushButton Cancel;
        public  PushButton OK;
        public  TextField ViewName;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SaveViewDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ViewList = new ListBox()
            {
                Tag = "[ListBox]View List:|$m_viewListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewList);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            ViewName = new TextField()
            {
                Tag = "[TextField]View Name:|$m_viewNameTxtBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewName);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Save View|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
