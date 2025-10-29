// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Center Of Gravity Validation|$CenterOfGravityValidationDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class COGValidationDLG : Pane
    {
        public  Pane PositionMayNotBePANE;
        public  StaticText PositionMayNotBeST;
        public  StaticText MissingWeightValuesST;
        public  Link Elbow14204LINK;
        public  StaticText StaticTextST;
        public  Link Pipe14212LINK;
        public  StaticText MissingLinearWeightValuesST;
        public  Link Pipe24212LINK;
        public  TitleBar CenterOfGravityValidationCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public COGValidationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PositionMayNotBePANE = new Pane()
            {
                Tag = "[Pane]Position may not be accurate due to:|$pictureBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PositionMayNotBePANE);

            PositionMayNotBeST = new StaticText()
            {
                Tag = "[StaticText]Position may not be accurate due to:|$m_titleLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PositionMayNotBeST);

            MissingWeightValuesST = new StaticText()
            {
                Tag = "[StaticText]Missing weight values :|$3015876|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MissingWeightValuesST);

            Elbow14204LINK = new Link()
            {
                Tag = "[Link]Elbow 1(4204)|$2949636|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Elbow14204LINK);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText],|$1771108|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Pipe14212LINK = new Link()
            {
                Tag = "[Link]Pipe 1(4212)|$2294444|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pipe14212LINK);

            MissingLinearWeightValuesST = new StaticText()
            {
                Tag = "[StaticText]Missing linear weight values :|$1248216|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MissingLinearWeightValuesST);

            Pipe24212LINK = new Link()
            {
                Tag = "[Link]Pipe 2(4212)|$1705882|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pipe24212LINK);

            CenterOfGravityValidationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Center Of Gravity Validation|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityValidationCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Center Of Gravity Validation|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
