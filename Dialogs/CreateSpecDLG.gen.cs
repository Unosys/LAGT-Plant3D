// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Create Spec|$NewFileWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class CreateSpecDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton CreatePB;
        public  PushButton CancelPB;
        public  TextField NewSpecNameTF;
        public  PushButton PushButtonPB;
        public  TextField SpecDescriptionTF;
        public  PopupList LoadCatalogPL;
        public  ComboBox FileNameCB;
        public  PushButton SavePB;
        public  DialogBox SaveAsDLG;
        public  DialogBox ConfirmSaveAsDLG;
        public  Pane ConfirmSaveAsPANE;
        public  Image MainInstructionIconIMG;
        public  StaticText CS150FlangedpspxAlreadyExistsST;
        public  PushButton YesPB;
        public  PushButton NoPB;

        partial void OnInitialize();

        public CreateSpecDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar/[PushButton]$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]$CreateButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$CancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            NewSpecNameTF = new TextField()
            {
                Tag = "[TextField]$NewFileTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewSpecNameTF);

            PushButtonPB = new PushButton()
            {
                Tag = "[PushButton]$NewFileBrowseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            SpecDescriptionTF = new TextField()
            {
                Tag = "[TextField]$DescTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecDescriptionTF);

            LoadCatalogPL = new PopupList()
            {
                Tag = "[PopupList]$LoadCatalogComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoadCatalogPL);

            FileNameCB = new ComboBox()
            {
                Tag = "[DialogBox]Save As|#1/[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Details Pane|$BackgroundClear|#5/[ComboBox]File name:|$FileNameControlHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            SavePB = new PushButton()
            {
                Tag = "[DialogBox]Save As|#1/[PushButton]Save|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            SaveAsDLG = new DialogBox()
            {
                Tag = "[DialogBox]Save As|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsDLG);

            ConfirmSaveAsDLG = new DialogBox()
            {
                Tag = "[DialogBox]Save As|#1/[DialogBox]Confirm Save As|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfirmSaveAsDLG);

            ConfirmSaveAsPANE = new Pane()
            {
                Tag = "[DialogBox]Save As|#1/[DialogBox]Confirm Save As|#1/[Pane]Confirm Save As|$Window|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfirmSaveAsPANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[DialogBox]Save As|#1/[DialogBox]Confirm Save As|#1/[Pane]Confirm Save As|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            CS150FlangedpspxAlreadyExistsST = new StaticText()
            {
                Tag = "[DialogBox]Save As|#1/[DialogBox]Confirm Save As|#1/[Pane]Confirm Save As|$Window|#1/[StaticText]CS150 Flanged*|$ContentText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CS150FlangedpspxAlreadyExistsST);

            YesPB = new PushButton()
            {
                Tag = "[DialogBox]Save As|#1/[DialogBox]Confirm Save As|#1/[Pane]Confirm Save As|$Window|#1/[PushButton]Yes|$CommandButton_6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[DialogBox]Save As|#1/[DialogBox]Confirm Save As|#1/[Pane]Confirm Save As|$Window|#1/[PushButton]No|$CommandButton_7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);
        }
    }
}
