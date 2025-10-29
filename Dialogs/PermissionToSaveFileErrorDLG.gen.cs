// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$ExceptionMessageForm", Parent = typeof(Plant3D))]
    public partial class PermissionToSaveFileErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox M_buttonsPanel;
        public  PushButton M_detailsBtn;
        public  CustomWin M_iconPicBox;
        public  StaticText M_mainExceptionText;
        public  GroupBox M_mainTableLayoutPanel;
        public  PushButton M_okBtn;

        partial void OnInitialize();

        public PermissionToSaveFileErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_buttonsPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_buttonsPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonsPanel);

            M_detailsBtn = new PushButton()
            {
                Tag = "[PushButton]$m_detailsBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_detailsBtn);

            M_iconPicBox = new CustomWin()
            {
                Tag = "[CustomWin]$m_iconPicBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_iconPicBox);

            M_mainExceptionText = new StaticText()
            {
                Tag = "[StaticText]$m_mainExceptionText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mainExceptionText);

            M_mainTableLayoutPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_mainTableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mainTableLayoutPanel);

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
