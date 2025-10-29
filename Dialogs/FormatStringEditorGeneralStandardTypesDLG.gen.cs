// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Format String Editor|$FormatStringEditorForm", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class FormatStringEditorGeneralStandardTypesDLG : Pane
    {
        public  ListBox CategoryLB;
        public  ListBoxItem DateTimeLBI;
        public  ListBoxItem NumberLBI;
        public  ListBoxItem PercentLBI;
        public  ListBoxItem CurrencyLBI;
        public  ListBoxItem SpecialLBI;
        public  ListBoxItem GeneralLBI;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  Window StandardTypesWIN;
        public  Window CustomWIN;
        public  Pane StandardTypesPANE;
        public  Pane GeneralStandardGroupPANE;
        public  Pane GrpButtonsPANE;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public FormatStringEditorGeneralStandardTypesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CategoryLB = new ListBox()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[ListBox]Category|$lbxCategory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CategoryLB);

            DateTimeLBI = new ListBoxItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[ListBox]Category|$lbxCategory|#1/[ListBoxItem]DateTime|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateTimeLBI);

            NumberLBI = new ListBoxItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[ListBox]Category|$lbxCategory|#1/[ListBoxItem]Number|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberLBI);

            PercentLBI = new ListBoxItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[ListBox]Category|$lbxCategory|#1/[ListBoxItem]Percent|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PercentLBI);

            CurrencyLBI = new ListBoxItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[ListBox]Category|$lbxCategory|#1/[ListBoxItem]Currency|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrencyLBI);

            SpecialLBI = new ListBoxItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[ListBox]Category|$lbxCategory|#1/[ListBoxItem]Special|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecialLBI);

            GeneralLBI = new ListBoxItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[ListBox]Category|$lbxCategory|#1/[ListBoxItem]General|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralLBI);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            StandardTypesWIN = new Window()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]Root|#1/[PageList]tabbedControlGroup1|#1/[PageList]#1/[Window]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StandardTypesWIN);

            CustomWIN = new Window()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]Root|#1/[PageList]tabbedControlGroup1|#1/[PageList]#1/[Window]Custom|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWIN);

            StandardTypesPANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]Root|#1/[PageList]tabbedControlGroup1|#1/[Pane]Standard Types|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StandardTypesPANE);

            GeneralStandardGroupPANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]Root|#1/[PageList]tabbedControlGroup1|#1/[Pane]Standard Types|#1/[Pane]generalStandardGroup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralStandardGroupPANE);

            GrpButtonsPANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]Root|#1/[Pane]grpButtons|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GrpButtonsPANE);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Format String Editor|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
