// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]SDNF Export", Parent = typeof(Plant3D))]
    public partial class SDNFExportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Button1;
        public  PushButton Cancel;
        public  TextField ClientIdentificationTextField;
        public  TextField DesignCodeTextField;
        public  TextField EngineeringFirmNameTextField;
        public  PushButton Export;
        public  PushButton Help;
        public  GroupBox Objects;
        public  TextField OutputFileTextField;
        public  TextField ProjectIDTextField;
        public  PushButton PushButton;
        public  TextField RevisionNumberTextField;
        public  TextField StructureNameTextField;
        public  GroupBox TitlePacketInformation;

        partial void OnInitialize();

        public SDNFExportDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Button1 = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button1);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            ClientIdentificationTextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClientIdentificationTextField);

            DesignCodeTextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignCodeTextField);

            EngineeringFirmNameTextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringFirmNameTextField);

            Export = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Export);

            Help = new PushButton()
            {
                Tag = "[PushButton]$3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Objects = new GroupBox()
            {
                Tag = "[GroupBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Objects);

            OutputFileTextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OutputFileTextField);

            ProjectIDTextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectIDTextField);

            PushButton = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton);

            RevisionNumberTextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionNumberTextField);

            StructureNameTextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StructureNameTextField);

            TitlePacketInformation = new GroupBox()
            {
                Tag = "[GroupBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitlePacketInformation);
        }
    }
}
