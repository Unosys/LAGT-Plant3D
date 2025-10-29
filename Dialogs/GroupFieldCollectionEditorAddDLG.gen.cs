// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$GroupFieldCollectionEditorForm", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class GroupFieldCollectionEditorAddDLG : Pane
    {
        public  PushButton AddButton;
        public  GroupBox AddRemoveTableLayoutPanel;
        public  PushButton Alphabetical;
        public  PushButton CancelButton;
        public  PushButton Categorized;
        public  PushButton DownButton;
        public  ListBox Listbox;
        public  StaticText MembersLabel;
        public  PushButton OkButton;
        public  GroupBox OkCancelTableLayoutPanel;
        public  GroupBox OverArchingTableLayoutPanel;
        public  StaticText PropertiesLabel;
        public  CustomWin PropertyBrowser;
        public  ToolBar PropertyGridToolBar;
        public  CustomWin PropertyGridView;
        public  PushButton PropertyPages;
        public  PushButton PushToolItem;
        public  PushButton RemoveButton;
        public  PushButton UpButton;

        partial void OnInitialize();

        public GroupFieldCollectionEditorAddDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddButton = new PushButton()
            {
                Tag = "[PushButton]$addButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddButton);

            AddRemoveTableLayoutPanel = new GroupBox()
            {
                Tag = "[GroupBox]$addRemoveTableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddRemoveTableLayoutPanel);

            Alphabetical = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Alphabetical);

            CancelButton = new PushButton()
            {
                Tag = "[PushButton]$cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelButton);

            Categorized = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Categorized);

            DownButton = new PushButton()
            {
                Tag = "[PushButton]$downButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DownButton);

            Listbox = new ListBox()
            {
                Tag = "[ListBox]$listbox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Listbox);

            MembersLabel = new StaticText()
            {
                Tag = "[StaticText]$membersLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MembersLabel);

            OkButton = new PushButton()
            {
                Tag = "[PushButton]$okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkButton);

            OkCancelTableLayoutPanel = new GroupBox()
            {
                Tag = "[GroupBox]$okCancelTableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkCancelTableLayoutPanel);

            OverArchingTableLayoutPanel = new GroupBox()
            {
                Tag = "[GroupBox]$overArchingTableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverArchingTableLayoutPanel);

            PropertiesLabel = new StaticText()
            {
                Tag = "[StaticText]$propertiesLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesLabel);

            PropertyBrowser = new CustomWin()
            {
                Tag = "[CustomWin]$propertyBrowser",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyBrowser);

            PropertyGridToolBar = new ToolBar()
            {
                Tag = "[ToolBar]$propertyBrowser",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyGridToolBar);

            PropertyGridView = new CustomWin()
            {
                Tag = "[CustomWin]$propertyBrowser",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyGridView);

            PropertyPages = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyPages);

            PushToolItem = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushToolItem);

            RemoveButton = new PushButton()
            {
                Tag = "[PushButton]$removeButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveButton);

            UpButton = new PushButton()
            {
                Tag = "[PushButton]$upButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpButton);
        }
    }
}
