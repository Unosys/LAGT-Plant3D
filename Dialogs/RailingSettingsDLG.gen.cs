// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]RailingSettingsDLG", Parent = typeof(Plant3D))]
    public partial class RailingSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  StaticText FB14x4;
        public  StaticText FirstPost5;
        public  TextField FirstPost5TextField;
        public  GroupBox Geometry;
        public  StaticText Handrail;
        public  StaticText HandrailHeight1;
        public  TextField HandrailHeight1TextField;
        public  PushButton Help;
        public  StaticText KickPlate;
        public  StaticText KickPlateHeight4;
        public  TextField KickPlateHeight4TextField;
        public  StaticText Label;
        public  CheckBox MiddleRailContinuous;
        public  PushButton OK;
        public  StaticText PIPE2STD;
        public  StaticText PIPE2STD2;
        public  StaticText PIPE2STD3;
        public  StaticText Post;
        public  PushButton PushButton;
        public  PushButton PushButton2;
        public  PushButton PushButton3;
        public  PushButton PushButton4;
        public  StaticText SecondPost6;
        public  TextField SecondPost6TextField;
        public  GroupBox Shape;
        public  StaticText x1stMidRail;
        public  StaticText x1stMidRailHeight2;
        public  TextField x1stMidRailHeight2TextField;
        public  StaticText x2ndMidRailHeight3;
        public  TextField x2ndMidRailHeight3TextField;

        partial void OnInitialize();

        public RailingSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            FB14x4 = new StaticText()
            {
                Tag = "[StaticText]$FB 1/4 x 4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FB14x4);

            FirstPost5 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FirstPost5);

            FirstPost5TextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FirstPost5TextField);

            Geometry = new GroupBox()
            {
                Tag = "[GroupBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Geometry);

            Handrail = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Handrail);

            HandrailHeight1 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HandrailHeight1);

            HandrailHeight1TextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HandrailHeight1TextField);

            Help = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            KickPlate = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(KickPlate);

            KickPlateHeight4 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(KickPlateHeight4);

            KickPlateHeight4TextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(KickPlateHeight4TextField);

            Label = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label);

            MiddleRailContinuous = new CheckBox()
            {
                Tag = "[CheckBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MiddleRailContinuous);

            OK = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            PIPE2STD = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIPE2STD);

            PIPE2STD2 = new StaticText()
            {
                Tag = "[StaticText]$PIPE2STD",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIPE2STD2);

            PIPE2STD3 = new StaticText()
            {
                Tag = "[StaticText]$PIPE2STD",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIPE2STD3);

            Post = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Post);

            PushButton = new PushButton()
            {
                Tag = "[PushButton]$1033",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton);

            PushButton2 = new PushButton()
            {
                Tag = "[PushButton]$1035",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2);

            PushButton3 = new PushButton()
            {
                Tag = "[PushButton]$1039",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3);

            PushButton4 = new PushButton()
            {
                Tag = "[PushButton]$1037",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4);

            SecondPost6 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SecondPost6);

            SecondPost6TextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SecondPost6TextField);

            Shape = new GroupBox()
            {
                Tag = "[GroupBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Shape);

            x1stMidRail = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(x1stMidRail);

            x1stMidRailHeight2 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(x1stMidRailHeight2);

            x1stMidRailHeight2TextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(x1stMidRailHeight2TextField);

            x2ndMidRailHeight3 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(x2ndMidRailHeight3);

            x2ndMidRailHeight3TextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(x2ndMidRailHeight3TextField);
        }
    }
}
