// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]New Spec|$Window_1|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class NewSpecDLG : Window
    {
        public  TitleBar NewSpecCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton OKPB;
        public  StaticText OKST;
        public  StaticText SpecName1ST;
        public  StaticText SpecName2ST;
        public  TextField SpecNameTF;
        public  Pane Pane1PANE;
        public  StaticText CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST;
        public  StaticText SpecDescription1ST;
        public  StaticText SpecDescription2ST;
        public  TextField SpecDescriptionTF;
        public  Pane Pane2PANE;

        partial void OnInitialize();

        public NewSpecDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            NewSpecCTL = new TitleBar()
            {
                Tag = "[TitleBar]New Spec|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewSpecCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]New Spec|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]New Spec|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]New Spec|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

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

            SpecName1ST = new StaticText()
            {
                Tag = "[StaticText]Spec name:|$Label_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecName1ST);

            SpecName2ST = new StaticText()
            {
                Tag = "[StaticText]Spec name:|$Label_1|#1/[StaticText]Spec name:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecName2ST);

            SpecNameTF = new TextField()
            {
                Tag = "[TextField]Spec name:|$SpecNameTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecNameTF);

            Pane1PANE = new Pane()
            {
                Tag = "[TextField]Spec name:|$SpecNameTextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST = new StaticText()
            {
                Tag = "[StaticText]C:*|$TextBlock_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST);

            SpecDescription1ST = new StaticText()
            {
                Tag = "[StaticText]Spec description:|$Label_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecDescription1ST);

            SpecDescription2ST = new StaticText()
            {
                Tag = "[StaticText]Spec description:|$Label_2|#3/[StaticText]Spec description:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecDescription2ST);

            SpecDescriptionTF = new TextField()
            {
                Tag = "[TextField]Spec description:|$SpecDescTextBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecDescriptionTF);

            Pane2PANE = new Pane()
            {
                Tag = "[TextField]Spec description:|$SpecDescTextBox|#2/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);
        }
    }
}
