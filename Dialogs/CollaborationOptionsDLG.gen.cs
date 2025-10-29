// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Collaboration Options|$Window_1", Parent = typeof(MainWin))]
    public partial class CollaborationOptionsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar CollaborationOptionsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  GroupBox ProjectUpdatesFromTeamGB;
        public  StaticText ProjectUpdatesFromTeamST;
        public  StaticText CheckForUpdates1ST;
        public  StaticText CheckForUpdates2ST;
        public  PopupList CheckForUpdatesPL;
        public  CheckBox AskMeBeforeApplyingCK;
        public  GroupBox CheckInCheckOutGB;
        public  StaticText CheckInCheckOutST;
        public  StaticText CheckOutDrawings1ST;
        public  StaticText CheckOutDrawings2ST;
        public  PopupList CheckOutDrawingsPL;
        public  StaticText CheckInDrawings1ST;
        public  StaticText CheckInDrawings2ST;
        public  PopupList CheckInDrawingsPL;
        public  GroupBox AdvancedGB;
        public  StaticText AdvancedST;
        public  CheckBox SpecifyWorkingFolderForCK;
        public  PushButton PushButtonPB;
        public  StaticText StaticTextST;
        public  TextField AdvancedTF;
        public  Pane PanePANE;
        public  PushButton HelpPB;
        public  StaticText HelpST;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton OKPB;
        public  StaticText OKST;

        partial void OnInitialize();

        public CollaborationOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CollaborationOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Collaboration Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CollaborationOptionsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Collaboration Options|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Collaboration Options|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Collaboration Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ProjectUpdatesFromTeamGB = new GroupBox()
            {
                Tag = "[GroupBox]Project updates from team members|$GroupBox_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectUpdatesFromTeamGB);

            ProjectUpdatesFromTeamST = new StaticText()
            {
                Tag = "[GroupBox]Project updates from team members|$GroupBox_1|#1/[StaticText]Project updates from team members|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectUpdatesFromTeamST);

            CheckForUpdates1ST = new StaticText()
            {
                Tag = "[GroupBox]Project updates from team members|$GroupBox_1|#1/[StaticText]Check for updates:|$Label_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckForUpdates1ST);

            CheckForUpdates2ST = new StaticText()
            {
                Tag = "[GroupBox]Project updates from team members|$GroupBox_1|#1/[StaticText]Check for updates:|$Label_1|#2/[StaticText]Check for updates:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckForUpdates2ST);

            CheckForUpdatesPL = new PopupList()
            {
                Tag = "[GroupBox]Project updates from team members|$GroupBox_1|#1/[PopupList]Check for updates:|$CheckForUpdatesComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckForUpdatesPL);

            AskMeBeforeApplyingCK = new CheckBox()
            {
                Tag = "[GroupBox]Project updates from team members|$GroupBox_1|#1/[CheckBox]Ask me before applying updates|$AskBeforeUpdatingCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AskMeBeforeApplyingCK);

            CheckInCheckOutGB = new GroupBox()
            {
                Tag = "[GroupBox]Check in*|$GroupBox_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInCheckOutGB);

            CheckInCheckOutST = new StaticText()
            {
                Tag = "[GroupBox]Check in*|$GroupBox_2|#2/[StaticText]Check in*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInCheckOutST);

            CheckOutDrawings1ST = new StaticText()
            {
                Tag = "[GroupBox]Check in*|$GroupBox_2|#2/[StaticText]Check out drawings:|$Label_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckOutDrawings1ST);

            CheckOutDrawings2ST = new StaticText()
            {
                Tag = "[GroupBox]Check in*|$GroupBox_2|#2/[StaticText]Check out drawings:|$Label_2|#2/[StaticText]Check out drawings:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckOutDrawings2ST);

            CheckOutDrawingsPL = new PopupList()
            {
                Tag = "[GroupBox]Check in*|$GroupBox_2|#2/[PopupList]Check out drawings:|$CheckOutOptionsComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckOutDrawingsPL);

            CheckInDrawings1ST = new StaticText()
            {
                Tag = "[GroupBox]Check in*|$GroupBox_2|#2/[StaticText]Check in drawings:|$Label_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInDrawings1ST);

            CheckInDrawings2ST = new StaticText()
            {
                Tag = "[GroupBox]Check in*|$GroupBox_2|#2/[StaticText]Check in drawings:|$Label_3|#3/[StaticText]Check in drawings:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInDrawings2ST);

            CheckInDrawingsPL = new PopupList()
            {
                Tag = "[GroupBox]Check in*|$GroupBox_2|#2/[PopupList]Check in drawings:|$CheckInOptionsComboBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInDrawingsPL);

            AdvancedGB = new GroupBox()
            {
                Tag = "[GroupBox]Advanced|$GroupBox_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedGB);

            AdvancedST = new StaticText()
            {
                Tag = "[GroupBox]Advanced|$GroupBox_3|#3/[StaticText]Advanced|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedST);

            SpecifyWorkingFolderForCK = new CheckBox()
            {
                Tag = "[GroupBox]Advanced|$GroupBox_3|#3/[CheckBox]Specify working folder for new collaboration projects|$SpecifyWorkingFolderCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyWorkingFolderForCK);

            PushButtonPB = new PushButton()
            {
                Tag = "[GroupBox]Advanced|$GroupBox_3|#3/[PushButton]**|$BrowseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            StaticTextST = new StaticText()
            {
                Tag = "[GroupBox]Advanced|$GroupBox_3|#3/[PushButton]**|$BrowseButton|#1/[StaticText]**|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            AdvancedTF = new TextField()
            {
                Tag = "[GroupBox]Advanced|$GroupBox_3|#3/[TextField]Advanced|$WorkingFolderTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedTF);

            PanePANE = new Pane()
            {
                Tag = "[GroupBox]Advanced|$GroupBox_3|#3/[TextField]Advanced|$WorkingFolderTextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$HelpButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            HelpST = new StaticText()
            {
                Tag = "[PushButton]Help|$HelpButton|#3/[StaticText]Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            OKST = new StaticText()
            {
                Tag = "[PushButton]OK|$OKButton|#1/[StaticText]OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKST);
        }
    }
}
