// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]#3", Parent = typeof(Plant3D))]
    public partial class PandIDValidationSummaryDLG : CustomWin
    {
        public  CustomWin AfxControlBar90u1;
        public  CustomWin AfxWnd90u1;
        public  CustomWin ValidationSummary;
        public  CustomWin ReportSummaryESW;
        public  CustomWin CurrentProjectDefaultProjec1;
        public  CustomWin SystemWindowsFormsSplitterP1;
        public  CheckBox DonTDisplayErrorsMarkedAs;
        public  CustomWin M_detailsCollapsibleButton;
        public  TreeView M_errorValidationTree;
        public  CustomWin SystemWindowsFormsSplitterP2;
        public  CustomWin M_errorDetailsGrid;
        public  TextField M_detailDescription;
        public  Table M_errorDetailsGridView;
        public  PushButton CurrentProjectDefaultProjec2;
        public  PushButton CurrentProjectDefaultProjec3;
        public  StaticText CurrentProjectDefaultProjec4;

        partial void OnInitialize();

        public PandIDValidationSummaryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AfxControlBar90u1 = new CustomWin()
            {
                Tag = "[CustomWin][AfxControlBar*]#1|[AfxControlBar*]$59423",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AfxControlBar90u1);

            AfxWnd90u1 = new CustomWin()
            {
                Tag = "[CustomWin][AfxWnd*]#1|[AfxWnd*]$16720",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AfxWnd90u1);

            ValidationSummary = new CustomWin()
            {
                Tag = "[CustomWin][AfxWnd*]#1|[AfxWnd*]$8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValidationSummary);

            ReportSummaryESW = new CustomWin()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnIDDwgValidation.ReportSummaryESW]#1|[Autodesk.ProcessPower.PnIDDwgValidation.ReportSummaryESW]$ReportSummaryESW",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportSummaryESW);

            CurrentProjectDefaultProjec1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.SplitContainer]#1|[System.Windows.Forms.SplitContainer]$m_splitContainer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectDefaultProjec1);

            SystemWindowsFormsSplitterP1 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.SplitterPanel]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterP1);

            DonTDisplayErrorsMarkedAs = new CheckBox()
            {
                Tag = "[CheckBox]#1|$m_chkHideIgnored",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DonTDisplayErrorsMarkedAs);

            M_detailsCollapsibleButton = new CustomWin()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnIDDwgValidation.CollapsibleButton]#1|[Autodesk.ProcessPower.PnIDDwgValidation.CollapsibleButton]$m_detailsCollapsibleButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_detailsCollapsibleButton);

            M_errorValidationTree = new TreeView()
            {
                Tag = "[TreeView]#1|$m_errorValidationTree",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_errorValidationTree);

            SystemWindowsFormsSplitterP2 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.SplitterPanel]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterP2);

            M_errorDetailsGrid = new CustomWin()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnIDDwgValidation.ErrorDetailsGrid]#1|[Autodesk.ProcessPower.PnIDDwgValidation.ErrorDetailsGrid]$m_errorDetailsGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_errorDetailsGrid);

            M_detailDescription = new TextField()
            {
                Tag = "[TextField]#1|$m_detailDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_detailDescription);

            M_errorDetailsGridView = new Table()
            {
                Tag = "[Table]#1|$m_errorDetailsGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_errorDetailsGridView);

            CurrentProjectDefaultProjec2 = new PushButton()
            {
                Tag = "[PushButton]#2|$m_refreshButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectDefaultProjec2);

            CurrentProjectDefaultProjec3 = new PushButton()
            {
                Tag = "[PushButton]#1|$m_valSettingButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectDefaultProjec3);

            CurrentProjectDefaultProjec4 = new StaticText()
            {
                Tag = "[StaticText]#1|$m_errorValidationLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectDefaultProjec4);
        }
    }
}
