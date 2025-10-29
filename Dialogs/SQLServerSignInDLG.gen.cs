// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmSqlServerSignIn", Parent = typeof(Plant3D))]
    public partial class SQLServerSignInDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TextField ProjectName;
        public  StaticText ProjectNameText;
        public  PushButton SignInPB;
        public  PushButton CancelPB;
        public  TextField PasswordTF;
        public  StaticText PasswordText;
        public  TextField UserNameTF;
        public  StaticText UserNameText;

        partial void OnInitialize();

        public SQLServerSignInDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ProjectName = new TextField()
            {
                Tag = "[TextField]Project Name:|#1|$m_textBox_ProjName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectName);

            ProjectNameText = new StaticText()
            {
                Tag = "[StaticText]Project Name:|#1|$m_label_projName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectNameText);

            SignInPB = new PushButton()
            {
                Tag = "[PushButton]Sign In|#2|$m_btnSignin",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignInPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|#1|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PasswordTF = new TextField()
            {
                Tag = "[TextField]Password:|#3|$m_textBox_pwd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTF);

            PasswordText = new StaticText()
            {
                Tag = "[StaticText]Password:|#3|$m_label_pwd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordText);

            UserNameTF = new TextField()
            {
                Tag = "[TextField]User Name:|#2|$m_textBox_username",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTF);

            UserNameText = new StaticText()
            {
                Tag = "[StaticText]User Name:|#2|$m_label_username",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameText);
        }
    }
}
