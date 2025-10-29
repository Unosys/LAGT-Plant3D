// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2015 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class GroupFieldCollectionEditorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
            //Tag = "[Pane]$CollectionEditor";
            Tag = "[Pane]$GroupFieldCollectionEditorForm";
        }

		public  void Invoke()
		{
			ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
			ReportDesignerApplicationDLG.Invoke();
			
			ReportDesignerApplicationDLG.TypeKeys("<Ctrl-n>");
			System.Threading.Thread.Sleep(5000);

           

            Desktop Desktop = new Desktop();
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\detail.bmp");
            Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
            System.Threading.Thread.Sleep(3000);           
            ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\ReportDesignerExpand_Button.bmp");
            Desktop.Click(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord + 2);
            System.Threading.Thread.Sleep(1000);
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {

                //case "JPN":

                //    break;
                //case "DEU":

                //    break;
                //case "FRA":

                //    break;
                //case "RUS":

                //    break;
                //case "CHS":

                //    break;
                //case "KOR":

                //    break;
                default:
                    SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\DetailTask.bmp");
                    Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 2, SAM.iYCoord +2);
                    break;

            }
            
            this.SetActive();
            this.SetSize();

        }
        public void SetSize()
        {
            GroupFieldCollectionEditorDLG GroupFieldCollectionEditorDLG = new GroupFieldCollectionEditorDLG();
           
            RECT r = GroupFieldCollectionEditorDLG.GetRect(true);
            if (r.xSize != 660 && r.ySize != 400)
            {
                this.Click(MouseButton.Right, 50, 10);
                Desktop.Current.TypeKeys("<Down 3><Enter>", 500);
                Desktop.Current.TypeKeys("<Right><Down>");
                Desktop.Current.Click(MouseButton.Left, r.xPos + 660, r.yPos + 400);
            }
        }
        public  void Dismiss()
		{
			GroupFieldCollectionEditorDLG GroupFieldCollectionEditorDLG = new GroupFieldCollectionEditorDLG();
			GroupFieldCollectionEditorDLG.SetActive();
            GroupFieldCollectionEditorDLG.CancelPB.Click();// TypeKeys("<Alt-F4>");
            ReportDesignerApplicationDLG ReportDesignerApplicationDLG = new ReportDesignerApplicationDLG();
            ReportDesignerApplicationDLG.Dismiss();
        }
    }
}
