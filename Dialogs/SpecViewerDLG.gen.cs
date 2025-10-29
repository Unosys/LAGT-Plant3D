// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]SpecViewerDLG", Parent = typeof(Plant3D))]
    public partial class SpecViewerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin AfxControlBar90u1;
        public  CustomWin AfxWnd90u1;
        public  CustomWin PipeSpecViewer;
        public  CustomWin SpecViewerESW;
        public  CustomWin M_SplitContainer;
        public  CustomWin SystemWindowsFormsSplitterP1;
        public  CustomWin M_Panel_Top;
        public  CustomWin HwndWrapperDefaultDomain611;
        public  CustomWin M_SpecViewerTitleBar;
        public  PopupList Spec;
        public  StaticText SpecText;
        public  CustomWin SystemWindowsFormsSplitterP2;
        public  CustomWin M_Panel_Bottom;
        public  CustomWin M_tableLayoutPanel;
        public  CustomWin M_PreviewPicBox;
        public  StaticText PartDetails1;
        public  StaticText PartTypeText;
        public  StaticText EndConnectionText;
        public  StaticText MaterialGradeText;
        public  StaticText RatingText;
        public  CustomWin PartDetails2;
        public  PushButton CreateToolPalette;
        public  PushButton InsertInModel;
        public  PushButton AddToToolPalette;
        public  CustomWin M_Panel_Bottom_PartsListView;
        public  CustomWin SystemWindowsFormsIntegrati;
        public  CustomWin HwndWrapperDefaultDomainDe1;
        public  CustomWin M_PartSizesTitleBar;

        partial void OnInitialize();

        public SpecViewerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AfxControlBar90u1 = new CustomWin()
            {
                Tag = "[CustomWin][AfxControlBar*u]$59423|[AfxControlBar*u]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AfxControlBar90u1);

            AfxWnd90u1 = new CustomWin()
            {
                Tag = "[AfxWnd*u]$16720",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AfxWnd90u1);

            PipeSpecViewer = new CustomWin()
            {
                Tag = "[CustomWin][AfxWnd*u]Pipe Spec Viewer|[AfxWnd*u]$8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecViewer);

            SpecViewerESW = new CustomWin()
            {
                Tag = "[Autodesk.ProcessPower.PnP3dSpecUI.SpecViewerESW]$SpecViewerESW",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecViewerESW);

            M_SplitContainer = new CustomWin()
            {
                Tag = "[System.Windows.Forms.SplitContainer]$m_SplitContainer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_SplitContainer);

            SystemWindowsFormsSplitterP1 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.SplitterPanel]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterP1);

            M_Panel_Top = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$m_Panel_Top",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_Panel_Top);

            HwndWrapperDefaultDomain611 = new CustomWin()
            {
                Tag = "[HwndWrapper[DefaultDomain;;6116536c-93b1-4868-9b53-3d8c5b6f3510]]$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HwndWrapperDefaultDomain611);

            M_SpecViewerTitleBar = new CustomWin()
            {
                Tag = "[Autodesk.ProcessPower.PnP3dSpecUI.SpecViewerTitleBar]$m_SpecViewerTitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_SpecViewerTitleBar);

            Spec = new PopupList()
            {
                Tag = "[PopupList]Spec:|$m_comboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spec);

            SpecText = new StaticText()
            {
                Tag = "[StaticText]Spec:|$m_label",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecText);

            SystemWindowsFormsSplitterP2 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.SplitterPanel]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterP2);

            M_Panel_Bottom = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$m_Panel_Bottom",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_Panel_Bottom);

            M_tableLayoutPanel = new CustomWin()
            {
                Tag = "[System.Windows.Forms.TableLayoutPanel]$m_tableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tableLayoutPanel);

            M_PreviewPicBox = new CustomWin()
            {
                Tag = "[System.Windows.Forms.PictureBox]$m_PreviewPicBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_PreviewPicBox);

            PartDetails1 = new StaticText()
            {
                Tag = "[StaticText]Part details|$m_DetailGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartDetails1);

            PartTypeText = new StaticText()
            {
                Tag = "[StaticText]Part Type:|$m_Label_PartType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartTypeText);

            EndConnectionText = new StaticText()
            {
                Tag = "[StaticText]End Connection:|$m_Label_EndCon",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndConnectionText);

            MaterialGradeText = new StaticText()
            {
                Tag = "[StaticText]Material Grade:|$m_Label_MaterialGrade",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialGradeText);

            RatingText = new StaticText()
            {
                Tag = "[StaticText]Rating:|$m_Label_Rating",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RatingText);

            PartDetails2 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]Part details|[System.Windows.Forms.Panel]$m_panel_btn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartDetails2);

            CreateToolPalette = new PushButton()
            {
                Tag = "[PushButton]Create Tool Palette|$m_btnCreate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateToolPalette);

            InsertInModel = new PushButton()
            {
                Tag = "[PushButton]Insert in Model|$m_btnInsert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsertInModel);

            AddToToolPalette = new PushButton()
            {
                Tag = "[PushButton]Add to Tool Palette|$m_btnAdd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddToToolPalette);

            M_Panel_Bottom_PartsListView = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$m_Panel_Bottom_PartsListView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_Panel_Bottom_PartsListView);

            SystemWindowsFormsIntegrati = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Integration.ElementHost]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsIntegrati);

            HwndWrapperDefaultDomainDe1 = new CustomWin()
            {
                Tag = "[HwndWrapper[DefaultDomain;;de14b149-fb4b-45af-ad48-0d6dce44329f]]$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HwndWrapperDefaultDomainDe1);

            M_PartSizesTitleBar = new CustomWin()
            {
                Tag = "[Autodesk.ProcessPower.PnP3dSpecUI.PartSizesTitleBar]$m_PartSizesTitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_PartSizesTitleBar);
        }
    }
}
