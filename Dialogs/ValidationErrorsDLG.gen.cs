// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Validation Errors|$ValidationInfoForm|#2", Parent = typeof(ReportConfigurationDLG), GUIType = GuiType.UIA)]
    public partial class ValidationErrorsDLG : Pane
    {
        public  Pane M_mainTableLayoutPanel;
        public  ListBox M_errorListBox;
        public  ListBoxItem QueryEmptyLBI;
        public  ListBoxItem ReportLayoutEmptyLBI;
        public  StaticText M_descriptionLbl;
        public  PushButton M_oKBtn;
        public  Pane M_iconPicBox;
        public  TitleBar ValidationErrorsCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ValidationErrorsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_mainTableLayoutPanel = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mainTableLayoutPanel);

            M_errorListBox = new ListBox()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[ListBox]The following fields are not valid:|$m_errorListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_errorListBox);

            QueryEmptyLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[ListBox]The following fields are not valid:|$m_errorListBox|#1/[ListBoxItem]Query: Empty |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QueryEmptyLBI);

            ReportLayoutEmptyLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[ListBox]The following fields are not valid:|$m_errorListBox|#1/[ListBoxItem]Report layout: Empty |#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportLayoutEmptyLBI);

            M_descriptionLbl = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]The following fields are not valid:|$m_descriptionLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_descriptionLbl);

            M_oKBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]OK|$m_oKBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_oKBtn);

            M_iconPicBox = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]The following fields are not valid:|$m_iconPicBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_iconPicBox);

            ValidationErrorsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Validation Errors|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValidationErrorsCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Validation Errors|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
