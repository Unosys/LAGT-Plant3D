// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Formatting Rules Editor|$FormattingRulesEditorForm", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class FormattingRulesEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  PushButton PushButton3PB;
        public  PushButton PushButton4PB;
        public  PushButton PushButton5PB;
        public  PushButton PushButton6PB;
        public  PushButton EditRuleSheetPB;
        public  ListBox ListBoxLB;
        public  ListBox RulesAvailableInALB;
        public  ListBoxItem FormattingRule1LBI;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  Pane RootPANE;
        public  Pane GrpButtonsPANE;
        public  Pane LayoutControlGroup2PANE;
        public  Pane LayoutControlGroup3PANE;
        public  Pane LayoutControlGroup4PANE;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public FormattingRulesEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$downButton|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$upButton|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$removeRangeButton|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            PushButton4PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$removeButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            PushButton5PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$addRangeButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            PushButton6PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$addButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton6PB);

            EditRuleSheetPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]Edit Rule Sheet*|$editSheetButton|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditRuleSheetPB);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$layoutControl1|#1/[ListBox]$formattingRulesListBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            RulesAvailableInALB = new ListBox()
            {
                Tag = "[Pane]$layoutControl1|#1/[ListBox]Rules available in a report:|$ruleSheetListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RulesAvailableInALB);

            FormattingRule1LBI = new ListBoxItem()
            {
                Tag = "[Pane]$layoutControl1|#1/[ListBox]Rules available in a report:|$ruleSheetListBox|#1/[ListBoxItem]formattingRule1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRule1LBI);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]OK|$okButton|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]Cancel|$cancelButton|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            RootPANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]Root|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RootPANE);

            GrpButtonsPANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]Root|#1/[Pane]grpButtons|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GrpButtonsPANE);

            LayoutControlGroup2PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]Root|#1/[Pane]layoutControlGroup2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayoutControlGroup2PANE);

            LayoutControlGroup3PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]Root|#1/[Pane]layoutControlGroup3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayoutControlGroup3PANE);

            LayoutControlGroup4PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]Root|#1/[Pane]layoutControlGroup4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayoutControlGroup4PANE);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Formatting Rules Editor|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
