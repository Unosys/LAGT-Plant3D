// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Modify Catalog Properties|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ModifyCatalogPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OkButton;
        public  PushButton CancelButton;
        public  PushButton ApplyButton;
        public  PushButton HelpButton;
        public  CustomWin MEditProperties;
        public  StaticText AddedPropertiesText;
        public  PushButton AddButton;
        public  PushButton RemoveButton;
        public  ListBox AddedPropertiesLb;
        public  GroupBox GroupBox1;
        public  StaticText DisplayNameLabel;
        public  TextField DisplayNameTb;
        public  StaticText DefaultValueLabel;
        public  TextField DefaultValueTb;
        public  StaticText AddPropertyToLabel;
        public  PopupList AddPropertyToCb;
        public  StaticText FieldNameLabel;
        public  TextField FieldNameTb;
        public  StaticText FieldTypeLabel;
        public  PopupList FieldTypeCb;
        public  StaticText FieldSizeLabel;
        public  TextField FieldSizeTb;

        partial void OnInitialize();

        public ModifyCatalogPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OkButton = new PushButton()
            {
                Tag = "[PushButton]$OK_Button",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkButton);

            CancelButton = new PushButton()
            {
                Tag = "[PushButton]$Cancel_Button",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelButton);

            ApplyButton = new PushButton()
            {
                Tag = "[PushButton]$Apply_Button",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyButton);

            HelpButton = new PushButton()
            {
                Tag = "[PushButton]$Help_Button",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpButton);

            MEditProperties = new CustomWin()
            {
                Tag = "[CustomWin]$m_EditProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MEditProperties);

            AddedPropertiesText = new StaticText()
            {
                Tag = "[StaticText]$AddedPropertiesText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddedPropertiesText);

            AddButton = new PushButton()
            {
                Tag = "[PushButton]$Add_Button",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddButton);

            RemoveButton = new PushButton()
            {
                Tag = "[PushButton]$Remove_Button",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveButton);

            AddedPropertiesLb = new ListBox()
            {
                Tag = "[ListBox]$AddedProperties_LB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddedPropertiesLb);

            GroupBox1 = new GroupBox()
            {
                Tag = "[GroupBox]$GroupBox_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox1);

            DisplayNameLabel = new StaticText()
            {
                Tag = "[StaticText]$DisplayNameLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameLabel);

            DisplayNameTb = new TextField()
            {
                Tag = "[TextField]$DisplayName_TB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameTb);

            DefaultValueLabel = new StaticText()
            {
                Tag = "[StaticText]$DefaultValueLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueLabel);

            DefaultValueTb = new TextField()
            {
                Tag = "[TextField]$DefaultValue_TB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueTb);

            AddPropertyToLabel = new StaticText()
            {
                Tag = "[StaticText]$AddPropertyToLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyToLabel);

            AddPropertyToCb = new PopupList()
            {
                Tag = "[PopupList]$AddPropertyTo_CB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyToCb);

            FieldNameLabel = new StaticText()
            {
                Tag = "[StaticText]$FieldNameLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldNameLabel);

            FieldNameTb = new TextField()
            {
                Tag = "[TextField]$FieldName_TB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldNameTb);

            FieldTypeLabel = new StaticText()
            {
                Tag = "[StaticText]$FieldTypeLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldTypeLabel);

            FieldTypeCb = new PopupList()
            {
                Tag = "[PopupList]$FieldType_CB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldTypeCb);

            FieldSizeLabel = new StaticText()
            {
                Tag = "[StaticText]$FieldSizeLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldSizeLabel);

            FieldSizeTb = new TextField()
            {
                Tag = "[TextField]$FieldSize_TB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldSizeTb);
        }
    }
}
