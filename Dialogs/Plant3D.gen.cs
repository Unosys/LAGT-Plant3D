// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Autodesk AutoCAD Plant 3D*", Parent = typeof(Desktop), GUIType = GuiType.WIN32)]
    public partial class Plant3D : Plant3DMainWin
    {
        public  MDIClient MDIClient;
        public  CustomWin Ribbon;
        public  CustomWin ExportWIN;
        public  CustomWin AdvanceSteelXMLExportWIN;
        public  PushButton AdvanceSteelXMLExportPB;
        public  PushButton PushButton2PB;
        public  CustomWin CustomWin5WIN;
        public  Image ISOImage;
        public  Image Spec;
        public  CustomWin LoadOrthoCubeWIN;
        public  PushButton LoadOrthoCubePB;
        public  PushButton SaveOrthoCubePB;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  TextField TypeACommandTF;

        partial void OnInitialize();

        public Plant3D()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            MDIClient = new MDIClient()
            {
                Tag = "[MDIClient]$59648",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MDIClient);

            Ribbon = new CustomWin()
            {
                Tag = "[CustomWin]Ribbon|$59419|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Ribbon);

            ExportWIN = new CustomWin()
            {
                Tag = "[CustomWin]Ribbon|$59419|#3/[CustomWin]Ribbon|$16719|#1/[CustomWin]Ribbon|#1/[Pane]#1/[CustomWin]$PNP.ID_TabStructural_PanelBarScrollViewer|#1/[CustomWin]Export|$ID_PanelStructure_Export|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportWIN);

            AdvanceSteelXMLExportWIN = new CustomWin()
            {
                Tag = "[CustomWin]Ribbon|$59419|#3/[CustomWin]Ribbon|$16719|#1/[CustomWin]Ribbon|#1/[Pane]#1/[CustomWin]$PNP.ID_TabStructural_PanelBarScrollViewer|#1/[CustomWin]Export|$ID_PanelStructure_Export|#5/[CustomWin]$STRUCT_ADVANCESTEEL_EXPORT_RibbonItemControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvanceSteelXMLExportWIN);

            AdvanceSteelXMLExportPB = new PushButton()
            {
                Tag = "[CustomWin]Ribbon|$59419|#3/[CustomWin]Ribbon|$16719|#1/[CustomWin]Ribbon|#1/[Pane]#1/[CustomWin]$PNP.ID_TabStructural_PanelBarScrollViewer|#1/[CustomWin]Export|$ID_PanelStructure_Export|#5/[CustomWin]$STRUCT_ADVANCESTEEL_EXPORT_RibbonItemControl|#1/[PushButton]$STRUCT_ADVANCESTEEL_EXPORT|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvanceSteelXMLExportPB);

            PushButton2PB = new PushButton()
            {
                Tag = "[CustomWin]AdImpApplicationFrame|$4096/[CustomWin]$InfoCenter/[CustomWin]$ID_IC_WebservicesLoginButton_RibbonItemControl/[PushButton]$ID_IC_WebservicesLoginButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            CustomWin5WIN = new CustomWin()
            {
                Tag = "[CustomWin]AdImpApplicationFrame|$4096/[CustomWin]$InfoCenter/[CustomWin]$ID_IC_WebservicesLoginButton_RibbonItemControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin5WIN);

            ISOImage = new Image()
            {
                Tag = "[StatusBar]$59393|#1/[Pane]$UserControl_1|#1/[CustomWin]$mStatusBarControl|#2/[Image]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ISOImage);

            Spec = new Image()
            {
                Tag = "[StatusBar]$59393|#1/[Pane]$UserControl_1|#1/[CustomWin]$mStatusBarControl|#2/[Image]$ID_|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spec);

            LoadOrthoCubeWIN = new CustomWin()
            {
                Tag = "[CustomWin]Ribbon|$59419|#2/[CustomWin]Ribbon|$16718|#1/[CustomWin]Ribbon|$4|#1/[Pane]#1/[CustomWin]PNP*|$PNP.ID_TabOrthoEditor_PanelBarScrollViewer|#2/[CustomWin]Library|$ID_PanelOrthoLibrary|#3/[CustomWin]Load Ortho Cube|$pnpLoadViewConfigButton_RibbonItemControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoadOrthoCubeWIN);

            LoadOrthoCubePB = new PushButton()
            {
                Tag = "[CustomWin]$59419|#2/[CustomWin]*/[CustomWin]#1/[Pane]#1/[CustomWin]$PNP.ID_TabOrthoEditor_PanelBarScrollViewer|#2/[CustomWin]$ID_PanelOrthoLibrary|#3/[CustomWin]$pnpLoadViewConfigButton_RibbonItemControl|#1/[PushButton]$pnpLoadViewConfigButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoadOrthoCubePB);

            SaveOrthoCubePB = new PushButton()
            {
                Tag = "[CustomWin]$59419|#2/[CustomWin]*/[CustomWin]#1/[Pane]#1/[CustomWin]$PNP.ID_TabOrthoEditor_PanelBarScrollViewer|#2/[CustomWin]$ID_PanelOrthoLibrary|#3/[CustomWin]$pnpSaveViewConfigButton_RibbonItemControl|#2/[PushButton]$pnpSaveViewConfigButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveOrthoCubePB);

            OKPB = new PushButton()
            {
                Tag = "[CustomWin]Ribbon|$59419|#2/[CustomWin]*/[CustomWin]#1/[Pane]#1/[CustomWin]$PNP.ID_TabOrthoEditor_PanelBarScrollViewer|#2/[CustomWin]$ID_PanelCanelOrthoCreation|#7/[CustomWin]$pnpOrthoViewCreateButton_RibbonItemControl|#1/[PushButton]$pnpOrthoViewCreateButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[CustomWin]Ribbon|$59419|#2/[CustomWin]*/[CustomWin]#1/[Pane]#1/[CustomWin]$PNP.ID_TabOrthoEditor_PanelBarScrollViewer|#2/[CustomWin]$ID_PanelCanelOrthoCreation|#7/[CustomWin]$pnpCancelOrthoEditorButton_RibbonItemControl|#2/[PushButton]$pnpCancelOrthoEditorButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            TypeACommandTF = new TextField()
            {
                Tag = "[CustomWin]$59422/[CustomWin]$16716/[CustomWin]#1/[Pane]#1/[CustomWin]$Control_1/[TextField]$local:AutoCompleteEdit_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TypeACommandTF);
        }
    }
}
