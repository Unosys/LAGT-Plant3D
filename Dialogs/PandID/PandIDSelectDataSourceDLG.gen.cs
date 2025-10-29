// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$SelectDataSource", Parent = typeof(Pane))]
    public partial class PandIDSelectDataSourceDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_cancelBtn;
        public  PushButton M_helpBtn;
        public  StaticText M_objectCategoryLabel;
        public  TreeView M_objectDefinitionTreeView;
        public  StaticText M_objectPropertyLabel;
        public  ListBox M_objectPropertyListBox;
        public  GroupBox M_objectTabPage;
        public  PushButton M_OKBtn;
        public  CustomizedPagelist PageListPG;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;

        partial void OnInitialize();

        public PandIDSelectDataSourceDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_cancelBtn = new PushButton()
            {
                Tag = "[PushButton]$m_cancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelBtn);

            M_helpBtn = new PushButton()
            {
                Tag = "[PushButton]$m_helpBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_helpBtn);

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

            M_objectTabPage = new GroupBox()
            {
                Tag = "[GroupBox]$m_objectTabPage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_objectTabPage);

            M_OKBtn = new PushButton()
            {
                Tag = "[PushButton]$m_OKBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_OKBtn);

            PageListPG = new CustomizedPagelist()
            {
                Tag = "[PageList]$m_propertyTabs",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);

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
