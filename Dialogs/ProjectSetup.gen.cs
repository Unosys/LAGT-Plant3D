// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetup : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TreeView M_treeView;
        public  StaticText CustomizedViews;
        public  ListBox M_viewListBox;
        public  PushButton CreateView;
        public  PushButton DeleteView;
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;
        public  PushButton Apply;

        partial void OnInitialize();

        public ProjectSetup()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]#1|$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            CustomizedViews = new StaticText()
            {
                Tag = "[StaticText]Customized views|#1|$m_viewsGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomizedViews);

            M_viewListBox = new ListBox()
            {
                Tag = "[ListBox]#1|$m_viewListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_viewListBox);

            CreateView = new PushButton()
            {
                Tag = "[PushButton]Create View|#1|$m_buttonNewView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateView);

            DeleteView = new PushButton()
            {
                Tag = "[PushButton]Delete View|#2|$m_buttonRemoveView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteView);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|#4|$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|#3|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|#2|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Apply = new PushButton()
            {
                Tag = "[PushButton]Apply|#1|$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Apply);
        }
    }
}
