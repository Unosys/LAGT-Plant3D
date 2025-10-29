// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Property Editor|$PropertyEditor", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecPropertyEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  StaticText Display1ST;
        public  StaticText Display2ST;
        public  PopupList DisplayPL;
        public  Window PartListWIN;
        public  StaticText PartListST;
        public  Window ManageSizesWIN;
        public  StaticText ManageSizesST;
        public  Window ManagePropertiesWIN;
        public  StaticText ManagePropertiesST;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton AddPB;
        public  PushButton RemovePB;
        public  TextField DisplayNameTF;
        public  TextField DefaultValueTF;
        public  TextField FieldNameTF;
        public  ListBox AddedPropertiesLB;

        partial void OnInitialize();

        public SpecPropertyEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Spec Property Editor|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Display1ST = new StaticText()
            {
                Tag = "[StaticText]Display:|$PropertyTypeLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Display1ST);

            Display2ST = new StaticText()
            {
                Tag = "[StaticText]Display:|$PropertyTypeLabel|#1/[StaticText]Display:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Display2ST);

            DisplayPL = new PopupList()
            {
                Tag = "[PopupList]Display:|$PropertyTypeCombo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayPL);

            PartListWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Part List|$PartListTab|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartListWIN);

            PartListST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Part List|$PartListTab|#1/[StaticText]Part List|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartListST);

            ManageSizesWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Manage Sizes|$ManageSizesTab|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManageSizesWIN);

            ManageSizesST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Manage Sizes|$ManageSizesTab|#2/[StaticText]Manage Sizes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManageSizesST);

            ManagePropertiesWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Manage Properties|$ManagePropsTab|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManagePropertiesWIN);

            ManagePropertiesST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Manage Properties|$ManagePropsTab|#3/[StaticText]Manage Properties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManagePropertiesST);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OK_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel_Button|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            AddPB = new PushButton()
            {
                Tag = "[CustomWin]$m_EditProperties|#1/[PushButton]$AddBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            RemovePB = new PushButton()
            {
                Tag = "[CustomWin]$m_EditProperties|#1/[PushButton]$Remove_Button|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            DisplayNameTF = new TextField()
            {
                Tag = "[CustomWin]$m_EditProperties|#1/[TextField]$DisplayName_TB|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameTF);

            DefaultValueTF = new TextField()
            {
                Tag = "[CustomWin]$m_EditProperties|#1/[TextField]$DefaultValue_TB|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueTF);

            FieldNameTF = new TextField()
            {
                Tag = "[CustomWin]$m_EditProperties|#1/[TextField]$FieldName_TB|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldNameTF);

            AddedPropertiesLB = new ListBox()
            {
                Tag = "[CustomWin]$m_EditProperties|#1/[ListBox]$AddedProperties_LB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddedPropertiesLB);
        }
    }
}
