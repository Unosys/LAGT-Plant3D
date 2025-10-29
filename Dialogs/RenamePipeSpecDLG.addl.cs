// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class RenamePipeSpecDLG : Window
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2017";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "$Window_1";
            //Tag = "[Window]" + AcMainWin.cBabel(23074, 8, "Rename Pipe Spec");
        }

        public  void Invoke()
        {
            Drawing.Current.TypeE("_ProjectManager");
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.PipeSpecsTVI.Select();
            ProjManUndocked.PipeSpecsTVI.TypeKeys("<Right><Down>");
            //ProjManUndocked.one00HC01TVI.Select();
            //ProjManUndocked.one00HC01TVI.Click(MouseButton.Right);
            RECT rTree = ProjManUndocked.TreeViewTV.GetRect();           
            switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            {
                case "RUS":
                    ProjManUndocked.TreeViewTV.Click(MouseButton.Right, rTree.xPos + 5, rTree.ySize - 23);
                    Desktop.Current.TypeKeys("<Down 4><Enter>");
                    break;
                default:
                    ProjManUndocked.TreeViewTV.Click(MouseButton.Right, rTree.xPos + 5, rTree.ySize - 23);
                    Desktop.Current.TypeKeys("<Down 5><Enter>");
                    break;
            }
        }

        public  void Dismiss()
        {
            RenamePipeSpecDLG RenamePipeSpecDLG = Current<RenamePipeSpecDLG>();
            RenamePipeSpecDLG.CancelPB.Click();
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.SetActive();
            ProjManUndocked.TypeKeys("<Home>");
            ProjManUndocked.PipeSpecsTVI.Select();
            ProjManUndocked.PipeSpecsTVI.TypeKeys("<Left>");
        }
    }
}
