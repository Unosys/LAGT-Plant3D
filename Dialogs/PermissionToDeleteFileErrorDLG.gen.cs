// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$MessageForm", Parent = typeof(Plant3D))]
    public partial class PermissionToDeleteFileErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox M_buttonsTableLayoutPanel;
        public  CustomWin M_iconPicBox;
        public  GroupBox M_mainTableLayoutPanel;
        public  StaticText M_msgLbl;
        public  PushButton M_okBtn;

        partial void OnInitialize();

        public PermissionToDeleteFileErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_buttonsTableLayoutPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_buttonsTableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonsTableLayoutPanel);

            M_iconPicBox = new CustomWin()
            {
                Tag = "[CustomWin]$m_iconPicBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_iconPicBox);

            M_mainTableLayoutPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_mainTableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mainTableLayoutPanel);

            M_msgLbl = new StaticText()
            {
                Tag = "[StaticText]$m_msgLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_msgLbl);

            M_okBtn = new PushButton()
            {
                Tag = "[PushButton]$m_okBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);
        }
    }
}
