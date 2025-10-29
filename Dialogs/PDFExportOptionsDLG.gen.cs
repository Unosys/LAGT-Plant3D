// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]PDF Export Options|$LinesForm|#2", Parent = typeof(ReportCreatorDLG), GUIType = GuiType.UIA)]
    public partial class PDFExportOptionsDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  StaticText PasswordSecurityST;
        public  TextField PasswordSecurityTF;
        public  PushButton Open4PB;
        public  StaticText DigitalSignatureST;
        public  TextField DigitalSignatureTF;
        public  PushButton Open5PB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PDFExportOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#2/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#2/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            PasswordSecurityST = new StaticText()
            {
                Tag = "[Pane]$layoutControl1|#2/[Pane]#2/[Pane]#13/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordSecurityST);

            PasswordSecurityTF = new TextField()
            {
                Tag = "[Pane]$layoutControl1|#2/[Pane]#2/[Pane]#13/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordSecurityTF);

            Open4PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#2/[Pane]#2/[Pane]#13/[TextField]#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open4PB);

            DigitalSignatureST = new StaticText()
            {
                Tag = "[Pane]$layoutControl1|#2/[Pane]#2/[Pane]$16517526|#14/[StaticText]$17958822|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DigitalSignatureST);

            DigitalSignatureTF = new TextField()
            {
                Tag = "[Pane]$layoutControl1|#2/[Pane]#2/[Pane]$16517526|#14/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DigitalSignatureTF);

            Open5PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#2/[Pane]#2/[Pane]$16517526|#14/[TextField]#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open5PB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
