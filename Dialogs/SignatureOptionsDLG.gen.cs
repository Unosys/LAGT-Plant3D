// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Signature Options|$PdfSignatureEditorForm", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class SignatureOptionsDLG : Pane
    {
        public  Pane TheXtraLayoutControlPANE;
        public  TextField ContactInformationTF;
        public  Pane Pane1PANE;
        public  TextField TextFieldTF;
        public  Pane Pane2PANE;
        public  ListBox ListBoxLB;
        public  Pane Pane3PANE;
        public  ScrollBar VerticalSB;
        public  ToolBar ToolBarTB;
        public  CustomWin Group1WIN;
        public  ListBoxItem NoneLBI;
        public  StaticText ContactInformationST;
        public  TextField LocationTF;
        public  StaticText StaticText1ST;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton LoadImagePB;
        public  PushButton ClearImagePB;
        public  TextField ReasonTF;
        public  StaticText StaticText2ST;
        public  StaticText LocationST;
        public  StaticText ReasonST;
        public  StaticText CertificateST;
        public  StaticText ImageST;
        public  Pane Pane4PANE;
        public  TitleBar SignatureOptionsCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SignatureOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TheXtraLayoutControlPANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControlPANE);

            ContactInformationTF = new TextField()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]Contact Information:|$tbContactInfo|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContactInformationTF);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]Contact Information:|$tbContactInfo|#3/[Pane]$5640126|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            TextFieldTF = new TextField()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]Contact Information:|$tbContactInfo|#3/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$certificateSelector|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$certificateSelector|#1/[ListBox]$list|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$certificateSelector|#1/[ListBox]$list|#1/[Pane]$6493398|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            VerticalSB = new ScrollBar()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$certificateSelector|#1/[ListBox]$list|#1/[ScrollBar]Vertical|$3412996|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalSB);

            ToolBarTB = new ToolBar()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$certificateSelector|#1/[ListBox]$list|#1/[ToolBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBarTB);

            Group1WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$certificateSelector|#1/[ListBox]$list|#1/[CustomWin]Group1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Group1WIN);

            NoneLBI = new ListBoxItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$certificateSelector|#1/[ListBox]$list|#1/[CustomWin]Group1|#1/[ListBoxItem]None|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoneLBI);

            ContactInformationST = new StaticText()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[StaticText]Contact Information:|$lbContactInfo|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContactInformationST);

            LocationTF = new TextField()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]Location:|$tbLocation|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocationTF);

            StaticText1ST = new StaticText()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]Location:|$tbLocation|#2/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            OKPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]OK|$btnOK|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Cancel|$btnCancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            LoadImagePB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Load Image|$btnLoadImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoadImagePB);

            ClearImagePB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Clear Image|$btnClearImage|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClearImagePB);

            ReasonTF = new TextField()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]Reason:|$tbReason|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReasonTF);

            StaticText2ST = new StaticText()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]Reason:|$tbReason|#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            LocationST = new StaticText()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[StaticText]Location:|$lbLocation|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocationST);

            ReasonST = new StaticText()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[StaticText]Reason:|$lbReason|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReasonST);

            CertificateST = new StaticText()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[StaticText]Certificate:|$lbCertificate|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CertificateST);

            ImageST = new StaticText()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[StaticText]Image:|$lbImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageST);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$peImage|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            SignatureOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Signature Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignatureOptionsCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Signature Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
