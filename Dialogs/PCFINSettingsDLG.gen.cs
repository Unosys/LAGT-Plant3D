// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]PCF to Pipe Settings|$Window|#1", Parent = typeof(PCFINListDLG), GUIType = GuiType.UIA)]
    public partial class PCFINSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar PCFToPipeSettingsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  GroupBox SpecFileSubstitutionsGB;
        public  StaticText SpecFileSubstitutionsST;
        public  StaticText PCFSpec1ST;
        public  StaticText PCFSpec2ST;
        public  StaticText Plant3DSpec1ST;
        public  StaticText Plant3DSpec2ST;
        public  StaticText ThePlaceholderSpecWillST;
        public  Pane PanePANE;
        public  StaticText NothingToSeeHereST;
        public  StaticText WeHaveFoundMatchesST;
        public  PopupList PCFINPL;
        public  PushButton OKPB;
        public  StaticText OKST;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton HelpPB;
        public  StaticText HelpST;

        partial void OnInitialize();

        public PCFINSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PCFToPipeSettingsCTL = new TitleBar()
            {
                Tag = "[TitleBar]PCF to Pipe Settings|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFToPipeSettingsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]PCF to Pipe Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]PCF to Pipe Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]PCF to Pipe Settings|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            SpecFileSubstitutionsGB = new GroupBox()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecFileSubstitutionsGB);

            SpecFileSubstitutionsST = new StaticText()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[StaticText]Spec File Substitutions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecFileSubstitutionsST);

            PCFSpec1ST = new StaticText()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[StaticText]PCF Spec|$Label_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFSpec1ST);

            PCFSpec2ST = new StaticText()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[StaticText]PCF Spec|$Label_1|#2/[StaticText]PCF Spec|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFSpec2ST);

            Plant3DSpec1ST = new StaticText()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[StaticText]Plant 3D Spec|$Label_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DSpec1ST);

            Plant3DSpec2ST = new StaticText()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[StaticText]Plant 3D Spec|$Label_2|#3/[StaticText]Plant 3D Spec|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DSpec2ST);

            ThePlaceholderSpecWillST = new StaticText()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[StaticText]The Placeholder spec will be used for any unmatched specs that do not have a substitution specified*|$TextBlock_1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThePlaceholderSpecWillST);

            PanePANE = new Pane()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[Pane]$ScrollViewerContainer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            NothingToSeeHereST = new StaticText()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[Pane]$ScrollViewerContainer|#1/[StaticText]Nothing to see here*|$TextBlock_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NothingToSeeHereST);

            WeHaveFoundMatchesST = new StaticText()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1|#1/[Pane]$ScrollViewerContainer|#1/[StaticText]We have found matches for all of the specs used in the selected PCF files*|$TextBlock_3|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeHaveFoundMatchesST);

            PCFINPL = new PopupList()
            {
                Tag = "[GroupBox]Spec File Substitutions|$GroupBox_1/[Pane]$ScrollViewerContainer/[PopupList]PCFIN",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFINPL);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            OKST = new StaticText()
            {
                Tag = "[PushButton]OK|$OKBtn|#1/[StaticText]OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$HelpBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            HelpST = new StaticText()
            {
                Tag = "[PushButton]Help|$HelpBtn|#3/[StaticText]Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);
        }
    }
}
