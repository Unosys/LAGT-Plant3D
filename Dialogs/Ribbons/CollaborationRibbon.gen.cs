// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]Ribbon|$59419/[CustomWin]Ribbon|$16719/[CustomWin]Ribbon|$7/[Pane]#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class CollaborationRibbon : RibbonDialogClassP3D
    {
        public  ProjectPanelClass ProjectPanel;
        public  FilePanelClass FilePanel;

        partial void OnInitialize();

        public CollaborationRibbon()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ProjectPanel = new ProjectPanelClass()
            {
                Tag = "[CustomWin]PNP*|$PNP.ID_TabPnPP360_PanelBarScrollViewer/[CustomWin]Project|$ID_PanelPnPP360Collaboration",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectPanel);

            FilePanel = new FilePanelClass()
            {
                Tag = "[CustomWin]PNP*|$PNP.ID_TabPnPP360_PanelBarScrollViewer/[CustomWin]File|$ID_PanelPnPP360File",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilePanel);
        }

        public partial class ProjectPanelClass : CustomWin
        {
            public PushButton ShareProjectPB;

            partial void OnInitialize();

            public ProjectPanelClass()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin]PNP*|$PNP.ID_TabPnPP360_PanelBarScrollViewer/[CustomWin]Project|$ID_PanelPnPP360Collaboration";
                ParentType = this.GetType();

                ShareProjectPB = new PushButton()
                {
                    Tag = "[CustomWin]Share*|$ID_PP_P360_ShareProject_RibbonItemControl/[PushButton]Share*|$ID_PP_P360_ShareProject",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(ShareProjectPB);
            }
        }

        public partial class FilePanelClass : CustomWin
        {
            public CustomWin CheckInWIN;
            public PushButton CheckInPB;
            public Image Image1IMG;
            public StaticText CheckInST;
            public CustomWin CheckOutWIN;
            public PushButton CheckOutPB;
            public Image Image2IMG;
            public StaticText CheckOutST;
            public CustomWin UndoCheckOutWIN;
            public PushButton UndoCheckOutPB;
            public Image Image3IMG;
            public StaticText UndoCheckOutST;
            public CustomWin OptionsWIN;
            public PushButton OptionsPB;
            public Image Image4IMG;
            public StaticText OptionsST;
            public CustomWin CustomWinWIN;
            public CustomWin AttachWIN;
            public PushButton AttachPB;
            public Image Image5IMG;
            public StaticText AttachST;
            public CustomWin IDPanelPnPP360FileWIN;
            public StaticText FileST;

            partial void OnInitialize();

            public FilePanelClass()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin]PNP*|$PNP.ID_TabPnPP360_PanelBarScrollViewer/[CustomWin]File|$ID_PanelPnPP360File";
                ParentType = this.GetType();

                CheckInWIN = new CustomWin()
                {
                    Tag = "[CustomWin]Check*|$ID_PP_P360_Check_In_RibbonItemControl|#4",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CheckInWIN);

                CheckInPB = new PushButton()
                {
                    Tag = "[CustomWin]Check*|$ID_PP_P360_Check_In_RibbonItemControl|#4/[PushButton]Check*|$ID_PP_P360_Check_In|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CheckInPB);

                Image1IMG = new Image()
                {
                    Tag = "[CustomWin]Check*|$ID_PP_P360_Check_In_RibbonItemControl|#4/[PushButton]Check*|$ID_PP_P360_Check_In|#1/[Image]$mImage|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Image1IMG);

                CheckInST = new StaticText()
                {
                    Tag = "[CustomWin]Check*|$ID_PP_P360_Check_In_RibbonItemControl|#4/[PushButton]Check*|$ID_PP_P360_Check_In|#1/[StaticText]Check*|$mText|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CheckInST);

                CheckOutWIN = new CustomWin()
                {
                    Tag = "[CustomWin]Check*|$ID_PP_P360_Check_Out_RibbonItemControl|#5",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CheckOutWIN);

                CheckOutPB = new PushButton()
                {
                    Tag = "[CustomWin]Check*|$ID_PP_P360_Check_Out_RibbonItemControl|#5/[PushButton]Check*|$ID_PP_P360_Check_Out|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CheckOutPB);

                Image2IMG = new Image()
                {
                    Tag = "[CustomWin]Check*|$ID_PP_P360_Check_Out_RibbonItemControl|#5/[PushButton]Check*|$ID_PP_P360_Check_Out|#1/[Image]$mImage|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Image2IMG);

                CheckOutST = new StaticText()
                {
                    Tag = "[CustomWin]Check*|$ID_PP_P360_Check_Out_RibbonItemControl|#5/[PushButton]Check*|$ID_PP_P360_Check_Out|#1/[StaticText]Check*|$mText|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CheckOutST);

                UndoCheckOutWIN = new CustomWin()
                {
                    Tag = "[CustomWin]Undo Check Out|$ID_PP_P360_Undo_Check_Out_RibbonItemControl|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(UndoCheckOutWIN);

                UndoCheckOutPB = new PushButton()
                {
                    Tag = "[CustomWin]Undo Check Out|$ID_PP_P360_Undo_Check_Out_RibbonItemControl|#1/[PushButton]Undo Check Out|$ID_PP_P360_Undo_Check_Out|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(UndoCheckOutPB);

                Image3IMG = new Image()
                {
                    Tag = "[CustomWin]Undo Check Out|$ID_PP_P360_Undo_Check_Out_RibbonItemControl|#1/[PushButton]Undo Check Out|$ID_PP_P360_Undo_Check_Out|#1/[Image]$mImage|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Image3IMG);

                UndoCheckOutST = new StaticText()
                {
                    Tag = "[CustomWin]Undo Check Out|$ID_PP_P360_Undo_Check_Out_RibbonItemControl|#1/[PushButton]Undo Check Out|$ID_PP_P360_Undo_Check_Out|#1/[StaticText]Undo Check Out|$mText|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(UndoCheckOutST);

                OptionsWIN = new CustomWin()
                {
                    Tag = "[CustomWin]Options|$ID_PP_P360_Options_RibbonItemControl|#2",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(OptionsWIN);

                OptionsPB = new PushButton()
                {
                    Tag = "[CustomWin]Options|$ID_PP_P360_Options_RibbonItemControl|#2/[PushButton]Options|$ID_PP_P360_Options|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(OptionsPB);

                Image4IMG = new Image()
                {
                    Tag = "[CustomWin]Options|$ID_PP_P360_Options_RibbonItemControl|#2/[PushButton]Options|$ID_PP_P360_Options|#1/[Image]$mImage|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Image4IMG);

                OptionsST = new StaticText()
                {
                    Tag = "[CustomWin]Options|$ID_PP_P360_Options_RibbonItemControl|#2/[PushButton]Options|$ID_PP_P360_Options|#1/[StaticText]Options|$mText|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(OptionsST);

                CustomWinWIN = new CustomWin()
                {
                    Tag = "[CustomWin]$_RibbonItemControl|#3",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CustomWinWIN);

                AttachWIN = new CustomWin()
                {
                    Tag = "[CustomWin]Attach|$ID_PP_P360_Attach_RibbonItemControl|#6",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(AttachWIN);

                AttachPB = new PushButton()
                {
                    Tag = "[CustomWin]Attach|$ID_PP_P360_Attach_RibbonItemControl|#6/[PushButton]Attach|$ID_PP_P360_Attach|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(AttachPB);

                Image5IMG = new Image()
                {
                    Tag = "[CustomWin]Attach|$ID_PP_P360_Attach_RibbonItemControl|#6/[PushButton]Attach|$ID_PP_P360_Attach|#1/[Image]$mImage|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Image5IMG);

                AttachST = new StaticText()
                {
                    Tag = "[CustomWin]Attach|$ID_PP_P360_Attach_RibbonItemControl|#6/[PushButton]Attach|$ID_PP_P360_Attach|#1/[StaticText]Attach|$mText|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(AttachST);

                IDPanelPnPP360FileWIN = new CustomWin()
                {
                    Tag = "[CustomWin]ID_PanelPnPP360File|$ID_PanelPnPP360File_PanelTitleBar|#7",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(IDPanelPnPP360FileWIN);

                FileST = new StaticText()
                {
                    Tag = "[CustomWin]ID_PanelPnPP360File|$ID_PanelPnPP360File_PanelTitleBar|#7/[StaticText]File|$PART_PanelTitleBarText|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(FileST);
            }
        }
    }
}
