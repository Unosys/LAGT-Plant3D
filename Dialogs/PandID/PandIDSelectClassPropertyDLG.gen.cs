// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]SelectClassPropertyDLG")]
    public partial class PandIDSelectClassPropertyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_button_cancel;
        public  PushButton M_button_help;
        public  PushButton M_button_ok;
        public  StaticText M_objectCategoryLabel;
        public  TreeView M_objectDefinitionTreeView;
        public  StaticText M_objectPropertyLabel;
        public  ListBox M_objectPropertyListBox;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;

        partial void OnInitialize();

        public PandIDSelectClassPropertyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_button_cancel = new PushButton()
            {
                Tag = "[PushButton]$m_button_cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_button_cancel);

            M_button_help = new PushButton()
            {
                Tag = "[PushButton]$m_button_help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_button_help);

            M_button_ok = new PushButton()
            {
                Tag = "[PushButton]$m_button_ok",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_button_ok);

            M_objectCategoryLabel = new StaticText()
            {
                Tag = "[StaticText]$m_objectCategoryLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_objectCategoryLabel);

            M_objectDefinitionTreeView = new TreeView()
            {
                Tag = "[TreeView]$m_objectDefinitionTreeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_objectDefinitionTreeView);

            M_objectPropertyLabel = new StaticText()
            {
                Tag = "[StaticText]$m_objectPropertyLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_objectPropertyLabel);

            M_objectPropertyListBox = new ListBox()
            {
                Tag = "[ListBox]$m_objectPropertyListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_objectPropertyListBox);

            SystemWindowsFormsSplitterPanel = new GroupBox()
            {
                Tag = "[GroupBox]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel);

            SystemWindowsFormsSplitterPanel2 = new GroupBox()
            {
                Tag = "[GroupBox]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel2);
        }
    }
}
