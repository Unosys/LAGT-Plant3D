// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]FlexNet License Finder", Parent = typeof(Desktop), GUIType = GuiType.WIN32)]
    public partial class VM_FlexNetLicenseFinderDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        public  PushButton NextPB;
        public  TextField EnterTheComputerNameTF;
        public  PushButton BackPB;
        public  PushButton CancelPB;
        public  DialogBox DialogBoxDLG;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  StaticText YourApplicationWasNotST;
        public  GroupBox GroupBoxGB;
        public  StaticText CopyrightcFlexeraSoftwareST;

        partial void OnInitialize();

        public VM_FlexNetLicenseFinderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            NextPB = new PushButton()
            {
                Tag = "[PushButton]$11016",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);

            EnterTheComputerNameTF = new TextField()
            {
                Tag = "[DialogBox]#1/[TextField]$11003",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterTheComputerNameTF);

            BackPB = new PushButton()
            {
                Tag = "[PushButton]<Back|$11017|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            DialogBoxDLG = new DialogBox()
            {
                Tag = "[DialogBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DialogBoxDLG);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[DialogBox]#1/[RadioButton]$11003|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[DialogBox]#1/[RadioButton]$11011|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            YourApplicationWasNotST = new StaticText()
            {
                Tag = "[DialogBox]#1/[StaticText]Your application was not able to obtain a license because the FlexNet license server manager could not determine where to find the licensing data it needs*|$-1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YourApplicationWasNotST);

            GroupBoxGB = new GroupBox()
            {
                Tag = "[DialogBox]#1/[GroupBox]$-1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxGB);

            CopyrightcFlexeraSoftwareST = new StaticText()
            {
                Tag = "[DialogBox]#1/[StaticText]Copyright (c) Flexera Software LLC|$-1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CopyrightcFlexeraSoftwareST);
        }
    }
}
