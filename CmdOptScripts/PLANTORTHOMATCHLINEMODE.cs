using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs; 
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using Autodesk.GUIHarness.Plant3D.TestSuites.GlobalCmdOpt;
using ProductTestSuite.CommonFiles; 
using LAGT.CommonFiles.Classes;
using Autodesk.GUIHarness.Plant3D.Dialogs;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
	public class PLANTORTHOMATCHLINEMODECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTORTHOMATCHLINEMODE = new List<Command>
		{
			new PLANTORTHOMATCHLINEMODE(),
			new PLANTORTHOMATCHLINEMODE_OFF(),
			new PLANTORTHOMATCHLINEMODE_ON()
		};
	}

	public class PLANTORTHOMATCHLINEMODE : Command
	{
		public override void Launch()
		{
           
            Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
			CmdOpt_Engine.EnterPoint(0,0);
			CmdOpt_Engine.EnterPoint(50,0);
			CmdOpt_Engine.EnterPoint(50,100);
			CmdOpt_Engine.EnterPoint(100,50);
			CmdOpt_Engine.EnterCR();
			Plant3DFunctions.CreateOrthoDrawingColurStyle();
			CmdOpt_Engine.SendCmd("_PLANTORTHOCREATE");
			SelectReferenceModelsDLG SelectReferenceModelsDLG = Window.Current<SelectReferenceModelsDLG>();
			SelectReferenceModelsDLG.SetActive();
			SelectReferenceModelsDLG.TypeKeys("<Space>");
			System.Threading.Thread.Sleep(5000);
			SelectReferenceModelsDLG.M_btnOK.Click();
            //if (SelectReferenceModelsDLG.Exists)
            //{
            //    SelectReferenceModelsDLG.M_btnOK.Click();
            //}
			CmdOpt_Engine.SendCmd("PLANTORTHOMATCHLINEMODE");
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc 5>");
			
          
        }

        public override void Verify()
		{
		}
	}

	public class PLANTORTHOMATCHLINEMODE_OFF : PLANTORTHOMATCHLINEMODE
	{
		public override void Launch()
		{
			
			CmdOpt_Engine.SendCmd("_PLANTORTHOMATCHLINEMODE");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("OFF");
			}
			else
			{
				string sString =(Plant3DMainWin.cBabel(23067,2,"OFF"));
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Enter>");
			Drawing.Current.TypeKeys("<Esc 4>");
			
		}

		public override void Verify()
		{
		}
	}

	public class PLANTORTHOMATCHLINEMODE_ON : PLANTORTHOMATCHLINEMODE
	{
		public override void Launch()
		{
			
			CmdOpt_Engine.SendCmd("_PLANTORTHOMATCHLINEMODE");
			if (AdOS.IsAsianLanguage)
			{
				CmdOpt_Engine.EnterText("ON");
			}
			else
			{
				string sString =(Plant3DMainWin.cBabel(23067,1,"ON"));
				//int iLen = Len(sString);
				CmdOpt_Engine.EnterText(sString);
			}
		}

		public override void Dismiss()
		{
			Drawing.Current.TypeKeys("<Esc 2>");
            Drawing.Current.TypeE("_Close");
            Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG SaveChangesMSG = new Autodesk.GUIHarness.Plant3D.Dialogs.SaveChangesMSG();
            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
            Drawing.Current.TypeE("_Close");

            if (SaveChangesMSG.WaitExists(2000))
            {
                SaveChangesMSG.NoPB.Click();

            }
         
            Plant3DFunctions.DeleteOrthoDrawing();
			Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
		}
	}
}
