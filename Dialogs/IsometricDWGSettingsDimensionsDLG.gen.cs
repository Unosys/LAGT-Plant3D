// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class IsometricDWGSettingsDimensionsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  CustomWin CustomWin1WIN;
        public  CustomWin CustomWin2WIN;
        public  PopupList PopupListPL;
        public  CustomWin CustomWin3WIN;
        public  PushButton PushButton1PB;
        public  PopupList ThemePL;
        public  StaticText ThemeST;
        public  StaticText Dimensions1ST;
        public  PushButton PushButton2PB;
        public  Image Image1IMG;
        public  PushButton PushButton3PB;
        public  Image Image2IMG;
        public  Window Setting;
        public  StaticText SettingsST;
        public  CustomWin CustomWin4WIN;
        public  StaticText GeneralSettingsST;
        public  Pane Pane14PANE;
        public  Window EndtoEnd;
        public  StaticText EndToEndOverallST;
        public  Window String;
        public  StaticText StringST;
        public  Window Locating;
        public  StaticText LocatingST;
        public  Pane Pane15PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton Add2PB;
        public  PushButton Add1PB;
        public  PushButton DeleteAnchorPointPB;

        partial void OnInitialize();

        public IsometricDWGSettingsDimensionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]$2622924|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PopupList]$ComboBox_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            CustomWin3WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[CustomWin]$local:IsometricInfoButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin3WIN);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[CustomWin]$local:IsometricInfoButton_1|#1/[PushButton]$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            ThemePL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PopupList]Theme:|$ComboBox_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemePL);

            ThemeST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[StaticText]Theme:|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemeST);

            Dimensions1ST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[StaticText]Dimensions|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Dimensions1ST);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]$XMLEditor_button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            Image1IMG = new Image()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]$XMLEditor_button|#1/[Image]$Image_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]$addStyle_button|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            Image2IMG = new Image()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]$addStyle_button|#2/[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            Setting = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Setting);

            SettingsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#1/[StaticText]Settings|$tabtext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsST);

            CustomWin4WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#1/[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin4WIN);

            GeneralSettingsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#1/[CustomWin]$UserControl_1|#1/[StaticText]General Settings:|$TextBlock_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsST);

            Pane14PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#1/[CustomWin]$UserControl_1|#1/[TextField]Stacking:|$Stacking_textBox|#2/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane14PANE);

            EndtoEnd = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndtoEnd);

            EndToEndOverallST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#2/[StaticText]End to End (Overall)|$tabtext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndToEndOverallST);

            String = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(String);

            StringST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#3/[StaticText]String|$tabtext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StringST);

            Locating = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Locating);

            LocatingST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#4/[StaticText]Locating|$tabtext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocatingST);

            Pane15PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3412262|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane15PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3412262|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3412262|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3412262|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3412262|#2/[PushButton]Apply|$m_btnSave|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            ProjectSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Add2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]*/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl/[Window]#2/[CustomWin]$UserControl_1|#1/[PushButton]$AddNewAnchor_Exclusion",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add2PB);

            Add1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]*/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl/[Window]#2/[CustomWin]$UserControl_1|#1/[PushButton]$AddNewAnchor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add1PB);

            DeleteAnchorPointPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9573186|#1/[Pane]$m_splitVert|#1/[Pane]$2233028|#2/[Pane]$1249300|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricDimensionTabCtrl|#1/[Window]#2/[CustomWin]$UserControl_1|#1/[PushButton]$DeleteAnchorPoint|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteAnchorPointPB);
        }
    }
}
