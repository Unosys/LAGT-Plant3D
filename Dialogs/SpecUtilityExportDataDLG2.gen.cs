// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Export Data|$ExcelExportWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUtilityExportDataDLG2 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OkPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  StaticText Label2;
        public  PopupList ComboBox1;
        public  StaticText Label3;
        public  TextField FilePathTextBox;
        public  PushButton BrowsePB;

        partial void OnInitialize();

        public SpecUtilityExportDataDLG2()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OkPB = new PushButton()
            {
                Tag = "[PushButton]$OkButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$CancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]$HelpButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            Label2 = new StaticText()
            {
                Tag = "[StaticText]$Label_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label2);

            ComboBox1 = new PopupList()
            {
                Tag = "[PopupList]$ComboBox_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBox1);

            Label3 = new StaticText()
            {
                Tag = "[StaticText]$Label_3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label3);

            FilePathTextBox = new TextField()
            {
                Tag = "[TextField]$FilePathTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilePathTextBox);

            BrowsePB = new PushButton()
            {
                Tag = "[PushButton]$BrowseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);
        }
    }
}
