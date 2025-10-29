// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Rename Class|$RenameObjectDefinitionDlg", Parent = typeof(ProjectSetupPandIDClassDefinitionDLG), GUIType = GuiType.UIA)]
    public partial class RenameClassDLG : Autodesk.GUIHarness.Pane
    {
        public  PushButton OKPB;
        public  PushButton HelpPB;
        public  PushButton M_btnCancel;
        public  TextField DisplayNameOfTheTF;
        public  StaticText DisplayNameOfTheST;
        public  TextField ClassNameTF;
        public  StaticText ClassNameST;
        public  TitleBar RenameClassCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public RenameClassDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            DisplayNameOfTheTF = new TextField()
            {
                Tag = "[TextField]Display Name of the Class:|$m_textBoxDisplayName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameOfTheTF);

            DisplayNameOfTheST = new StaticText()
            {
                Tag = "[StaticText]Display Name of the Class:|$m_labelDisplayName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameOfTheST);

            ClassNameTF = new TextField()
            {
                Tag = "[TextField]Class Name:|$m_textBoxName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassNameTF);

            ClassNameST = new StaticText()
            {
                Tag = "[StaticText]Class Name:|$m_labelName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassNameST);

            RenameClassCTL = new TitleBar()
            {
                Tag = "[TitleBar]Rename Class|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenameClassCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Rename Class|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
