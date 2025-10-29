// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Template File|#1", Parent = typeof(NewDWGDLG))]
    public partial class P3DSelectTemplateFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListView ListView1;
        public  StaticText FileNameText;
        public  ComboBox FileName;
        public  StaticText FilesOfTypeText;
        public  PopupList FilesOfType;
        public  PushButton Open;
        public  PushButton Cancel;
        public  PushButton Preview;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public P3DSelectTemplateFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ListView1 = new ListView()
            {
                Tag = "[CustomWin]#1/[ListView]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView1);

            FileNameText = new StaticText()
            {
                Tag = "[StaticText]File name:|$13008",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);

            FileName = new ComboBox()
            {
                Tag = "[ComboBox]$13006|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FilesOfTypeText = new StaticText()
            {
                Tag = "[StaticText]Files of type:|$13009",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeText);

            FilesOfType = new PopupList()
            {
                Tag = "[PopupList]Files of type:|$13002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType);

            Open = new PushButton()
            {
                Tag = "[PushButton]Open|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Preview = new PushButton()
            {
                Tag = "[PushButton]Preview|$13101",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Template File|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
