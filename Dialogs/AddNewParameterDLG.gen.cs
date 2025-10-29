// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Add New Parameter|$ReportParameterEditorForm|#2", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class AddNewParameterDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  Pane TablePanel11PANE;
        public  Pane Pane2PANE;
        public  Pane TablePanel12PANE;
        public  CheckBox SelectAllValuesCK;
        public  Pane NavigationFrame1PANE;
        public  TextField ExpressionTF;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  PushButton PushButtonPB;
        public  PopupList ValueSourcePL;
        public  StaticText noneST;
        public  PushButton Open1PB;
        public  PopupList TypePL;
        public  StaticText Number32BitIntegerST;
        public  PushButton Open2PB;
        public  CheckBox AllowNullValueCK;
        public  CheckBox AllowMultipleValuesCK;
        public  CheckBox ShowInTheParametersCK;
        public  TextField DescriptionTF;
        public  TextField TextField3TF;
        public  TextField TextField4TF;
        public  TextField NameTF;
        public  TextField TextField5TF;
        public  TextField TextField6TF;
        public  StaticText ValueSourceST;
        public  StaticText ExpressionST;
        public  StaticText DefaultValueST;
        public  StaticText TypeST;
        public  StaticText DescriptionST;
        public  StaticText NameST;
        public  TextField DefaultValueTF;
        public  TextField TextField7TF;
        public  TextField TextField8TF;
        public  CustomWin SpinnerWIN;
        public  PushButton UpPB;
        public  PushButton DownPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TitleBar AddNewParameterCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AddNewParameterDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            TablePanel11PANE = new Pane()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TablePanel11PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            TablePanel12PANE = new Pane()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TablePanel12PANE);

            SelectAllValuesCK = new CheckBox()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[CheckBox]Select all values|$ceSelectAll|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectAllValuesCK);

            NavigationFrame1PANE = new Pane()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[Pane]navigationFrame1|$navigationFrame1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NavigationFrame1PANE);

            ExpressionTF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Expression:|$defaultValueExpressionEditor|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExpressionTF);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Expression:|$defaultValueExpressionEditor|#4/[TextField]$4984282|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Expression:|$defaultValueExpressionEditor|#4/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Expression:|$defaultValueExpressionEditor|#4/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            ValueSourcePL = new PopupList()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[PopupList]Value Source:|$cbeValueSource|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueSourcePL);

            noneST = new StaticText()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[PopupList]Value Source:|$cbeValueSource|#1/[StaticText](none)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(noneST);

            Open1PB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[PopupList]Value Source:|$cbeValueSource|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            TypePL = new PopupList()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[PopupList]Type:|$cbeType|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TypePL);

            Number32BitIntegerST = new StaticText()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[PopupList]Type:|$cbeType|#2/[StaticText]Number (32 bit integer)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Number32BitIntegerST);

            Open2PB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[PopupList]Type:|$cbeType|#2/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            AllowNullValueCK = new CheckBox()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[CheckBox]Allow null value|$ceAllowNull|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllowNullValueCK);

            AllowMultipleValuesCK = new CheckBox()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[CheckBox]Allow multiple values|$ceAllowMultiple|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllowMultipleValuesCK);

            ShowInTheParametersCK = new CheckBox()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[CheckBox]Show in the parameters panel|$ceVisible|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowInTheParametersCK);

            DescriptionTF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Description:|$teDescription|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionTF);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Description:|$teDescription|#2/[TextField]$1773034|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            TextField4TF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Description:|$teDescription|#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            NameTF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Name:|$teName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameTF);

            TextField5TF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Name:|$teName|#1/[TextField]$2493444|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            TextField6TF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Name:|$teName|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            ValueSourceST = new StaticText()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[StaticText]Value Source:|$labelControl6|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueSourceST);

            ExpressionST = new StaticText()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[StaticText]Expression:|$labelControl5|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExpressionST);

            DefaultValueST = new StaticText()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[StaticText]Default Value:|$labelControl4|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueST);

            TypeST = new StaticText()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[StaticText]Type:|$labelControl3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TypeST);

            DescriptionST = new StaticText()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[StaticText]Description:|$labelControl2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionST);

            NameST = new StaticText()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[StaticText]Name:|$labelControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameST);

            DefaultValueTF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Default Value:|$defaultValueEditor|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueTF);

            TextField7TF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Default Value:|$defaultValueEditor|#3/[TextField]$69132|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField7TF);

            TextField8TF = new TextField()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Default Value:|$defaultValueEditor|#3/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField8TF);

            SpinnerWIN = new CustomWin()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Default Value:|$defaultValueEditor|#3/[CustomWin]Spinner|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpinnerWIN);

            UpPB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Default Value:|$defaultValueEditor|#3/[CustomWin]Spinner|#1/[PushButton]Up|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpPB);

            DownPB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[Pane]$parameterEditorContentControl|#1/[Pane]tablePanel1|$tablePanel1|#1/[TextField]Default Value:|$defaultValueEditor|#3/[CustomWin]Spinner|#1/[PushButton]Down|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DownPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#2/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            AddNewParameterCTL = new TitleBar()
            {
                Tag = "[TitleBar]Add New Parameter|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddNewParameterCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Add New Parameter|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
