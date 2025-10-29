// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Bolt Standard|$StandardBoltLengthAddMappingDialog|#1", Parent = typeof(BoltLengthMappingDLG), GUIType = GuiType.UIA)]
    public partial class AddBoltStandardDLG : Window
    {
        public  TitleBar AddBoltStandardCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;
        public  PushButton OK;
        public  StaticText OKST;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton HelpPB;
        public  StaticText HelpST;
        public  StaticText BoltCompatibleStandard1ST;
        public  StaticText BoltCompatibleStandard2ST;
        public  TextField TbBoltCompatibleStd;
        public  Pane PanePANE;
        public  StaticText Units1ST;
        public  StaticText Units2ST;
        public  PopupList CbUnit;
        public  StaticText BoltLengthsToInclude1ST;
        public  StaticText BoltLengthsToInclude2ST;
        public  ListView BoltLengthsToIncludeLV;
        public  Header HeaderCTL;
        public  CustomWin BoltSizeWIN;
        public  StaticText BoltSizeST;
        public  Thumb Thumb1CTL;
        public  CustomWin LengthFromWIN;
        public  StaticText LengthFromST;
        public  Thumb Thumb2CTL;
        public  Thumb Thumb3CTL;
        public  CustomWin ToWIN;
        public  StaticText ToST;
        public  Thumb Thumb4CTL;
        public  Thumb Thumb5CTL;
        public  CustomWin IncrementWIN;
        public  StaticText IncrementST;
        public  Thumb Thumb6CTL;
        public  Thumb Thumb7CTL;

        partial void OnInitialize();

        public AddBoltStandardDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddBoltStandardCTL = new TitleBar()
            {
                Tag = "[TitleBar]Add Bolt Standard|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddBoltStandardCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Add Bolt Standard|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Add Bolt Standard|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Bolt Standard|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Bolt Standard|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Add Bolt Standard|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$btApply|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            OKST = new StaticText()
            {
                Tag = "[PushButton]OK|$btApply|#1/[StaticText]_OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$btCancel|#2/[StaticText]_Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$btHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            HelpST = new StaticText()
            {
                Tag = "[PushButton]Help|$btHelp|#3/[StaticText]_Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);

            BoltCompatibleStandard1ST = new StaticText()
            {
                Tag = "[StaticText]Bolt Compatible Standard:|$lbBoltCompatibleStandard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltCompatibleStandard1ST);

            BoltCompatibleStandard2ST = new StaticText()
            {
                Tag = "[StaticText]Bolt Compatible Standard:|$lbBoltCompatibleStandard|#1/[StaticText]Bolt Compatible Standard:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltCompatibleStandard2ST);

            TbBoltCompatibleStd = new TextField()
            {
                Tag = "[TextField]Bolt Compatible Standard:|$tbBoltCompatibleStd|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TbBoltCompatibleStd);

            PanePANE = new Pane()
            {
                Tag = "[TextField]Bolt Compatible Standard:|$tbBoltCompatibleStd|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            Units1ST = new StaticText()
            {
                Tag = "[StaticText]Units:|$lbUnit|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Units1ST);

            Units2ST = new StaticText()
            {
                Tag = "[StaticText]Units:|$lbUnit|#2/[StaticText]Units:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Units2ST);

            CbUnit = new PopupList()
            {
                Tag = "[PopupList]Units:|$cbUnit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CbUnit);

            BoltLengthsToInclude1ST = new StaticText()
            {
                Tag = "[StaticText]Bolt lengths to include:|$lbBoltCompatibleStandard|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltLengthsToInclude1ST);

            BoltLengthsToInclude2ST = new StaticText()
            {
                Tag = "[StaticText]Bolt lengths to include:|$lbBoltCompatibleStandard|#3/[StaticText]Bolt lengths to include:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltLengthsToInclude2ST);

            BoltLengthsToIncludeLV = new ListView()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltLengthsToIncludeLV);

            HeaderCTL = new Header()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            BoltSizeWIN = new CustomWin()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Bolt Size|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltSizeWIN);

            BoltSizeST = new StaticText()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Bolt Size|#1/[StaticText]Bolt Size|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltSizeST);

            Thumb1CTL = new Thumb()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Bolt Size|#1/[Thumb]$PART_RightHeaderGripper|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb1CTL);

            LengthFromWIN = new CustomWin()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Length From|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LengthFromWIN);

            LengthFromST = new StaticText()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Length From|#2/[StaticText]Length From|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LengthFromST);

            Thumb2CTL = new Thumb()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Length From|#2/[Thumb]$PART_LeftHeaderGripper|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb2CTL);

            Thumb3CTL = new Thumb()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Length From|#2/[Thumb]$PART_RightHeaderGripper|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb3CTL);

            ToWIN = new CustomWin()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]To|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToWIN);

            ToST = new StaticText()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]To|#3/[StaticText]To|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToST);

            Thumb4CTL = new Thumb()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]To|#3/[Thumb]$PART_LeftHeaderGripper|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb4CTL);

            Thumb5CTL = new Thumb()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]To|#3/[Thumb]$PART_RightHeaderGripper|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb5CTL);

            IncrementWIN = new CustomWin()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Increment|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncrementWIN);

            IncrementST = new StaticText()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Increment|#4/[StaticText]Increment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncrementST);

            Thumb6CTL = new Thumb()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Increment|#4/[Thumb]$PART_LeftHeaderGripper|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb6CTL);

            Thumb7CTL = new Thumb()
            {
                Tag = "[ListView]Bolt lengths to include:|$dgBoltLengthIncl|#1/[Header]$PART_ColumnHeadersPresenter|#1/[CustomWin]Increment|#4/[Thumb]$PART_RightHeaderGripper|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb7CTL);
        }
    }
}
