// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(VaultLogInDLG))]
    public partial class Error : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TableLayoutPanel1Class TableLayoutPanel1;

        partial void OnInitialize();

        public Error()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TableLayoutPanel1 = new TableLayoutPanel1Class()
            {
                Tag = "[CustomWin][System.Windows.Forms.TableLayoutPanel]$tableLayoutPanel1|[System.Windows.Forms.TableLayoutPanel]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPanel1);
        }

        public partial class TableLayoutPanel1Class : CustomWin
        {
            public StaticText UserUser1DoesNotHaveAdequ1;
            public UserUser1DoesNotHaveAdequ2Class UserUser1DoesNotHaveAdequ2;
            public CustomWin M_errorIcon;

            partial void OnInitialize();

            public TableLayoutPanel1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][System.Windows.Forms.TableLayoutPanel]$tableLayoutPanel1|[System.Windows.Forms.TableLayoutPanel]#1";
                ParentType = this.GetType();

                UserUser1DoesNotHaveAdequ1 = new StaticText()
                {
                    Tag = "[StaticText]$m_errorText|User User1 does not have adequate permissions to log into Vault.|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(UserUser1DoesNotHaveAdequ1);

                UserUser1DoesNotHaveAdequ2 = new UserUser1DoesNotHaveAdequ2Class()
                {
                    Tag = "[CustomWin][System.Windows.Forms.TableLayoutPanel]$tableLayoutPanel2|[System.Windows.Forms.TableLayoutPanel]User User1 does not have adequate permissions to log into Vault.|[System.Windows.Forms.TableLayoutPanel]#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(UserUser1DoesNotHaveAdequ2);

                M_errorIcon = new CustomWin()
                {
                    Tag = "[CustomWin][System.Windows.Forms.PictureBox]$m_errorIcon|[System.Windows.Forms.PictureBox]#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(M_errorIcon);
            }
        }

        public partial class UserUser1DoesNotHaveAdequ2Class : CustomWin
        {
            public PushButton OK;

            partial void OnInitialize();

            public UserUser1DoesNotHaveAdequ2Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][System.Windows.Forms.TableLayoutPanel]$tableLayoutPanel2|[System.Windows.Forms.TableLayoutPanel]User User1 does not have adequate permissions to log into Vault.|[System.Windows.Forms.TableLayoutPanel]#1";
                ParentType = this.GetType();

                OK = new PushButton()
                {
                    Tag = "[PushButton]$button1|OK|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(OK);
            }
        }
    }
}
