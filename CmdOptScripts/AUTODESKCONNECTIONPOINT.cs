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
    public class AUTODESKCONNECTIONPOINTCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcAUTODESKCONNECTIONPOINT = new List<Command>
		{
			new AUTODESKCONNECTIONPOINT(),
            new AUTODESKCONNECTIONPOINT_Insert(),
            new AUTODESKCONNECTIONPOINT_Insert_Yes(),
            new AUTODESKCONNECTIONPOINT_Insert_No(),

            new AUTODESKCONNECTIONPOINT_cHangedirection(),
            new AUTODESKCONNECTIONPOINT_Edit(),
            new AUTODESKCONNECTIONPOINT_Connect(),
            new AUTODESKCONNECTIONPOINT_Disconnect(),
            new AUTODESKCONNECTIONPOINT_List(),
            new AUTODESKCONNECTIONPOINT_eXport()

        };
        public static void prepareAUTODESKCONNECTIONPOINT()
        {
            Plant3DFunctions.CreateDrawing("P3D");
            CmdOpt_Engine.SendCmd("_DYNMODE");
            CmdOpt_Engine.EnterInt(-3);
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(50, 50);
            CmdOpt_Engine.EnterPoint(140, 50);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_ZOOM"); //updated
            CmdOpt_Engine.SendOpt("_Extents"); // updated
        }

        public class AUTODESKCONNECTIONPOINT : Command
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("AUTODESKCONNECTIONPOINT");
            }

            public override void Dismiss()
            {
                CmdOpt_Engine.SendOpt("_Insert");
                CmdOpt_Engine.EnterCR();
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_Insert : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOption("Insert", 1, 7);
            }

            public override void Dismiss()
            {
                CmdOpt_Engine.EnterPoint(200, 200);
                CmdOpt_Engine.EnterPoint(0, 0);
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterPoint(140, 50);
                CmdOpt_Engine.SendOpt("_No");
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_Insert_Yes : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOpt("_Insert");
                CmdOpt_Engine.EnterPoint(200, 200);
                CmdOpt_Engine.EnterPoint(0, 0);
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterPoint(140, 50);
                CmdOpt_Engine.SendOption("Yes", 1, 2);
            }

            public override void Dismiss()
            {
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_Insert_No : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOpt("_Insert");
                CmdOpt_Engine.EnterPoint(200, 200);
                CmdOpt_Engine.EnterPoint(0, 0);
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterPoint(140, 50);
                CmdOpt_Engine.SendOption("No", 2, 2);
            }

            public override void Dismiss()
            {
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_cHangedirection : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOption("cHange direction", 2, 7);
            }

            public override void Dismiss()
            {
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterPoint(140, 50);
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_Edit : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOption("Edit", 3, 7);
            }

            public override void Dismiss()
            {
                CmdOpt_Engine.EnterPoint(50, 50);
                System.Threading.Thread.Sleep(2000);
                Dialogs.AutodeskConnectionPointEditorDLG AutodeskConnectionPointEditorDLG = new Dialogs.AutodeskConnectionPointEditorDLG();
                if (AutodeskConnectionPointEditorDLG.Exists)
                {
                    AutodeskConnectionPointEditorDLG.CancelPB.Click();
                }
                //Desktop Desktop = new Desktop();
                //Desktop.TypeKeys("<Enter>");
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_Connect : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                //CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                //CmdOpt_Engine.SendOpt("_Insert");
                //CmdOpt_Engine.EnterPoint(200, 200);
                //CmdOpt_Engine.EnterPoint(0, 0);
                //CmdOpt_Engine.EnterPoint(50, 50);
                //CmdOpt_Engine.EnterPoint(50, 50);
                //CmdOpt_Engine.EnterPoint(140, 50);
                //CmdOpt_Engine.SendOption("No", 2, 2);
                //Drawing.Current.TypeKeys("<Esc 3>");
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOption("Connect", 4, 7);
            }

            public override void Dismiss()
            {
                CmdOpt_Engine.EnterPoint(50, 50);
                CmdOpt_Engine.EnterCR();
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_Disconnect : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOption("Disconnect", 5, 7);
            }

            public override void Dismiss()
            {
                CmdOpt_Engine.EnterPoint(50, 50);
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_List : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOption("List", 6, 7);
            }

            public override void Dismiss()
            {
                CmdOpt_Engine.EnterPoint(50, 50);
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                //Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }
        }

        public class AUTODESKCONNECTIONPOINT_eXport : AUTODESKCONNECTIONPOINT
        {
            public override void Launch()
            {
                //prepareAUTODESKCONNECTIONPOINT() prepareAUTODESKCONNECTIONPOINT() = Window.Current<prepareAUTODESKCONNECTIONPOINT()>();
                //prepareAUTODESKCONNECTIONPOINT();
                CmdOpt_Engine.SendCmd("_AUTODESKCONNECTIONPOINT");
                CmdOpt_Engine.SendOption("eXport", 7, 7);
            }

            public override void Dismiss()
            {
                CmdOpt_Engine.EnterPoint(50, 50);
                Drawing.Current.TypeKeys("<Esc 3>");
                //DeleteAllDrawings("P3D") DeleteAllDrawings("P3D") = Window.Current<DeleteAllDrawings("P3D")>();
                Plant3DFunctions.DeleteAllDrawings();
            }

            public override void Verify()
            {
            }

        }
    }
}
