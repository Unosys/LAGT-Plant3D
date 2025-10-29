using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductTestSuite.CommonFiles.TestSuite.GlobalDlgBox;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using Autodesk.GUIHarness.AutoCAD;
using DataLinkPropertiesDLG = Autodesk.GUIHarness.Plant3D.Dialogs.DataLinkPropertiesDLG;
using ProductTestSuite.CommonFiles;
using ExportDataDLG = Autodesk.GUIHarness.Plant3D.Dialogs.ExportDataDLG;

namespace Autodesk.GUIHarness.Plant3D.TestSuites.GlobalDlgBox
{
    public class DlgBox_Exceptions : IDlgBox_Exceptions
    {
        public bool TestDLGException(dynamic wCurrentDialog, int iCurrentTab, int iTabsCount, ref int iCurrentShape, ref int iShapesCount)
        {
            // Take care of exceptions
            string winName = wCurrentDialog.Name;
            Desktop Desktop = new Desktop();
            ResultLog.Current.Log("aaa + " + winName);
            //ResultLog.Current.Printf("aaa + " + winName);
            
            switch (winName)
            {
                //case "ExternalDatabaseReferenceManager":
                //    ExternalDatabaseReferenceManager ExternalDatabaseReferenceManager = new ExternalDatabaseReferenceManager();
                //    ExternalDatabaseReferenceManager.SelectTab(1);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    ExternalDatabaseReferenceManager.SelectTab(2);
                //    System.Threading.Thread.Sleep(3000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    return true;
                case "NozzleDialog":
                    var NozzleDialog = new NozzleDialog();
                    NozzleDialog.ChangeTypeST.Click(MouseButton.Left,2,2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    NozzleDialog.ChangeLocationST.Click(MouseButton.Left, 2, 2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "EquipmentPlatformDLG":
                    EquipmentPlatformDLG EquipmentPlatformDLG = new EquipmentPlatformDLG();
                    EquipmentPlatformDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    EquipmentPlatformDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                   
                    return true;
                case "EquipmentFlatHeadDLG":
                    EquipmentFlatHeadDLG EquipmentFlatHeadDLG = new EquipmentFlatHeadDLG();                   
                    EquipmentFlatHeadDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    EquipmentFlatHeadDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "P3DModifyEquipmentDLG":
                    P3DModifyEquipmentDLG P3DModifyEquipmentDLG = new P3DModifyEquipmentDLG();                  
                    P3DModifyEquipmentDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    P3DModifyEquipmentDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    P3DModifyEquipmentDLG.PropertiesPANE.DoubleClick(MouseButton.Left, 10, -2);
                    return true;
                case "EquipmentStiffeningRingDLG":
                    EquipmentStiffeningRingDLG EquipmentStiffeningRingDLG = new EquipmentStiffeningRingDLG();                    
                    EquipmentStiffeningRingDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    EquipmentStiffeningRingDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "EquipmentSkirtDLG":
                    EquipmentSkirtDLG EquipmentSkirtDLG = new EquipmentSkirtDLG();
                    EquipmentSkirtDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    EquipmentSkirtDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "EquipmentLugDLG":
                    EquipmentLugDLG EquipmentLugDLG = new EquipmentLugDLG();           
                    EquipmentLugDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    EquipmentLugDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "EquipmentBodyFlangeDLG":
                    EquipmentBodyFlangeDLG EquipmentBodyFlangeDLG = new EquipmentBodyFlangeDLG();
                   
                    EquipmentBodyFlangeDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    EquipmentBodyFlangeDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "P3DCreateEquipmentDLG":
                    P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
                    P3DCreateEquipmentDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    P3DCreateEquipmentDLG.SelectTab(2); 
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "EquipmentLegDLG":
                    EquipmentLegDLG EquipmentLegDLG = new EquipmentLegDLG();
                    EquipmentLegDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    EquipmentLegDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    
                    return true;
                case "EquipmentSaddleDLG":
                    EquipmentSaddleDLG EquipmentSaddleDLG = new EquipmentSaddleDLG();
                    EquipmentSaddleDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    EquipmentSaddleDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "InsertTitleBlockAttributesDLG":
                    InsertTitleBlockAttributesDLG InsertTitleBlockAttributesDLG = new InsertTitleBlockAttributesDLG();
                    RECT r11 = InsertTitleBlockAttributesDLG.AddAttributesPANE.GetRect(true);
                    Desktop.Current.Click(MouseButton.Left, r11.xPos + 5, r11.yPos - 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Desktop.Current.Click(MouseButton.Left, r11.xPos + 5, r11.yPos - 5);
                    Desktop.Current.TypeKeys("<Right>");
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "TableSetupDLG":
                    TableSetupDLG TableSetupDLG = new TableSetupDLG();
                    RECT r12 = TableSetupDLG.TableLayoutPANE.GetRect(true);
                    Desktop.Current.Click(MouseButton.Left, r12.xPos + 5, r12.yPos - 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Desktop.Current.Click(MouseButton.Left, r12.xPos + 5, r12.yPos - 5);
                    Desktop.Current.TypeKeys("<Right>");
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "InsertTitleBlockAttributes_RequiredExelDLG":
                    InsertTitleBlockAttributes_RequiredExelDLG InsertTitleBlockAttributes_RequiredExelDLG = new InsertTitleBlockAttributes_RequiredExelDLG();
                    RECT r13 = InsertTitleBlockAttributes_RequiredExelDLG.AddAttributesPANE.GetRect(true);
                    Desktop.Current.Click(MouseButton.Left, r13.xPos + 5, r13.yPos - 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Desktop.Current.Click(MouseButton.Left, r13.xPos + 5, r13.yPos - 5);
                    Desktop.Current.TypeKeys("<Right>");
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "AddCalculatedPropertyDLG":
                    AddCalculatedPropertyDLG AddCalculatedPropertyDLG = new AddCalculatedPropertyDLG();
                    AddCalculatedPropertyDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AddCalculatedPropertyDLG.PushButton1PB.Click();
                    AddCalculatedPropertyDLG.TreeViewTV.Select(1);//Substring
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    //AddCalculatedPropertyDLG.PushButton1PB.Click();
                    AddCalculatedPropertyDLG.TreeViewTV.Select(2);//ToUpper
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    //AddCalculatedPropertyDLG.PushButton1PB.Click();
                    AddCalculatedPropertyDLG.TreeViewTV.Select(3);//ToLower
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    //AddCalculatedPropertyDLG.PushButton1PB.Click();
                    AddCalculatedPropertyDLG.TreeViewTV.Select(4);//ToString
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    //AddCalculatedPropertyDLG.PushButton1PB.Click();
                    AddCalculatedPropertyDLG.TreeViewTV.Select(5);//ToNumber
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 6, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ////AddCalculatedPropertyDLG.PushButton1PB.Click();
                    AddCalculatedPropertyDLG.TreeViewTV.Select(6);//Round
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 7, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    //AddCalculatedPropertyDLG.PushButton1PB.Click();
                    AddCalculatedPropertyDLG.TreeViewTV.Select(7);//Split
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 8, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    //AddCalculatedPropertyDLG.PushButton1PB.Click();
                    AddCalculatedPropertyDLG.TreeViewTV.Select(8);//Trim
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 9, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AddCalculatedPropertyDLG.PushButton1PB.Click(MouseButton.Left,2,2);
                    System.Threading.Thread.Sleep(1000);                  
                    AddCalculatedPropertyDLG.TypeKeys("<Down><Right><Down>");
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 10, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    System.Threading.Thread.Sleep(2000);
                    AddCalculatedPropertyDLG.PushButton2PB.Click(MouseButton.Left, 2, 2);
                    AddCalculatedPropertyDLG.TypeKeys("<Down><Right><Down>");
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 11, 11))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "OrthoTableSetupTableLayoutPopupListDLG":
                    OrthoTableSetupTableLayoutDLG OrthoTableSetupTableLayoutDLG = new OrthoTableSetupTableLayoutDLG();
                    OrthoTableSetupTableLayoutDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    OrthoTableSetupTableLayoutDLG.PopupListPL.Select(1);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    OrthoTableSetupTableLayoutDLG.PopupListPL.Select(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "CatalogPropertiesGeneralPropertiesDLG":
                    CatalogPropertiesGeneralPropertiesDLG CatalogPropertiesGeneralPropertiesDLG = new CatalogPropertiesGeneralPropertiesDLG();
                    CatalogPropertiesGeneralPropertiesDLG.GeneralPropertiesWIN.DoubleClick(MouseButton.Left, 10, 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    CatalogPropertiesGeneralPropertiesDLG.SizesST.DoubleClick(MouseButton.Left, 10, 5);

                    CatalogPropertiesGeneralPropertiesDLG.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "PandIDProjectSetupSQLExpressDatabaseSetupDLG":
                    PandIDProjectSetupSQLExpressDatabaseSetupDLG PandIDProjectSetupSQLExpressDatabaseSetupDLG = new PandIDProjectSetupSQLExpressDatabaseSetupDLG();
                    PandIDProjectSetupSQLExpressDatabaseSetupDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    PandIDProjectSetupSQLExpressDatabaseSetupDLG.AddPB.Click();
                    DataLinkPropertiesDLG DataLinkPropertiesDLG1 = new DataLinkPropertiesDLG();
                    DataLinkPropertiesDLG1.OKPB.Click();
                    PandIDProjectSetupSQLExpressDatabaseSetupDLG.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "CatalogPropertyEditorDLG":
                    CatalogPropertyEditorDLG CatalogPropertyEditorDLG = new CatalogPropertyEditorDLG();
                    CatalogPropertyEditorDLG.PartListST.DoubleClick(MouseButton.Left, 10, 5);
                    CatalogPropertyEditorDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CatalogPropertyEditorDLG.ManageSizesST.DoubleClick(MouseButton.Left, 10, 5);
                    CatalogPropertyEditorDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CatalogPropertyEditorDLG.ManagePropertiesST.DoubleClick(MouseButton.Left, 10, 5);
                    CatalogPropertyEditorDLG.DisplayNameTF.SetText("BP3");
                    CatalogPropertyEditorDLG.DefaultValueTF.SetText("5001");
                    CatalogPropertyEditorDLG.FieldNameTF.SetText("TEXT5001");
                    System.Threading.Thread.Sleep(1000);
                    CatalogPropertyEditorDLG.AddPB.Click();                   
                    CatalogPropertyEditorDLG.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CatalogPropertyEditorDLG.AddedPropertiesLB.Select(0);
                    CatalogPropertyEditorDLG.RemovePB.Click();
                    return true;
                case "SpecPropertyEditorDLG":
                    SpecPropertyEditorDLG SpecPropertyEditorDLG = new SpecPropertyEditorDLG();
                    SpecPropertyEditorDLG.PartListST.DoubleClick(MouseButton.Left, 10, 5);
                    SpecPropertyEditorDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SpecPropertyEditorDLG.ManageSizesST.DoubleClick(MouseButton.Left, 10, 5);
                    SpecPropertyEditorDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SpecPropertyEditorDLG.ManagePropertiesST.DoubleClick(MouseButton.Left, 10, 5);
                    SpecPropertyEditorDLG.SetActive();
                    SpecPropertyEditorDLG.DisplayNameTF.SetText("BP3");
                    SpecPropertyEditorDLG.DefaultValueTF.SetText("5001");
                    SpecPropertyEditorDLG.FieldNameTF.SetText("TEXT5001");
                    System.Threading.Thread.Sleep(1000);
                    SpecPropertyEditorDLG.AddPB.Click();
                    SpecPropertyEditorDLG.SetActive();
                    
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SpecPropertyEditorDLG.AddedPropertiesLB.Select(0);
                    SpecPropertyEditorDLG.RemovePB.Click();
                    return true;
                case "SelectClassProperty_Piping_Sort_Add":
                    SelectClassProperty_Piping_Sort_Add SelectClassProperty_Piping_Sort_Add = new SelectClassProperty_Piping_Sort_Add();
                    SelectClassProperty_Piping_Sort_Add.SortingDirectionInTablePL.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SelectClassProperty_Piping_Sort_Add.SortingDirectionInTablePL.Select(1);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "SelectClassProperty_Equitment_Sort_Add":
                    SelectClassProperty_Equitment_Sort_Add SelectClassProperty_Equitment_Sort_Add = new SelectClassProperty_Equitment_Sort_Add();
                    SelectClassProperty_Equitment_Sort_Add.SortingDirectionInTablePL.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SelectClassProperty_Equitment_Sort_Add.SortingDirectionInTablePL.Select(1);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "SelectClassProperty_Nozzle_Sort_Add":
                    SelectClassProperty_Nozzle_Sort_Add SelectClassProperty_Nozzle_Sort_Add = new SelectClassProperty_Nozzle_Sort_Add();
                    SelectClassProperty_Nozzle_Sort_Add.SortingDirectionInTablePL.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SelectClassProperty_Nozzle_Sort_Add.SortingDirectionInTablePL.Select(1);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "SelectClassProperty_Steel_Sort_Add":
                    SelectClassProperty_Steel_Sort_Add SelectClassProperty_Steel_Sort_Add = new SelectClassProperty_Steel_Sort_Add();
                    SelectClassProperty_Steel_Sort_Add.SortingDirectionInTablePL.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SelectClassProperty_Steel_Sort_Add.SortingDirectionInTablePL.Select(1);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "SelectClassProperty_Spool_Sort_Add":
                    SelectClassProperty_Spool_Sort_Add SelectClassProperty_Spool_Sort_Add = new SelectClassProperty_Spool_Sort_Add();
                    SelectClassProperty_Spool_Sort_Add.SortingDirectionInTablePL.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SelectClassProperty_Spool_Sort_Add.SortingDirectionInTablePL.Select(1);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "CreateIsometricStyleDLG":
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleDLG CreateIsometricStyleDLG = new CreateIsometricStyleDLG();
                    CreateIsometricStyleDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 6, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 7, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "ReportDesignerPropertiesDLG":
                    wCurrentDialog.SetActive();
                    ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Appearance.bmp");
                    Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    //Desktop Desktop = new Desktop();
                    ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Behavior.bmp");
                    Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\data.bmp");
                    Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\PageSetting.bmp");
                    Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\MIsce.bmp");
                    Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    ProductTestSuite.CommonFiles.SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Favourites.bmp");
                    Desktop.Click(MouseButton.Left, ProductTestSuite.CommonFiles.SAM.iXCoord + 2, ProductTestSuite.CommonFiles.SAM.iYCoord + 2);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 6, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "DataSourceWizardDLG":
                    DataSourceWizardDLG DataSourceWizardDLG = new DataSourceWizardDLG();
                    DataSourceWizardDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }                   
                    DataSourceWizardDLG.NoRB.Click();
                    DataSourceWizardDLG.NextPB.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataSourceWizardDLG.EntityFrameworkLBI.DoubleClick();
                    System.Threading.Thread.Sleep(3000);
                    //DataSourceWizardDLG.NextPB.Click();
                    //System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount,3, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataSourceWizardDLG.PreviousPB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DataSourceWizardDLG.ObjectLBI.DoubleClick();
                    System.Threading.Thread.Sleep(3000);
                    //DataSourceWizardDLG.NextPB.Click(MouseButton.Left,2,2);
                    //System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataSourceWizardDLG.NextPB.Click(MouseButton.Left, 2, 2);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataSourceWizardDLG.PreviousPB.Click();
                    DataSourceWizardDLG.PreviousPB.Click();
                    DataSourceWizardDLG.PreviousPB.Click();
                    return true;
                //case "DataSourceWizardDLG":
                //    DataSourceWizardDLG DataSourceWizardDLG = new DataSourceWizardDLG();
                //    DataSourceWizardDLG.SetActive();
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }

                //    //do you want to use an..
                //    DataSourceWizardDLG.DatabaseLBI.Click();
                //    System.Threading.Thread.Sleep(1000);
                //    DataSourceWizardDLG.NextPB.Click();
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    //Select the date...
                //    DataSourceWizardDLG.NORB.Click();
                //    System.Threading.Thread.Sleep(1000);
                //    DataSourceWizardDLG.NextPB.Click();
                //    if (DataSourceWizardDLG.NORB.Exists)
                //    {
                //        DataSourceWizardDLG.TypeKeys("<Enter>");
                //    }
                //    System.Threading.Thread.Sleep(1000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    //create a query..                    
                //    DataSourceWizardDLG.NextPB.Click();
                //    if (DataSourceWizardDLG.ComboBox1CB.Exists)
                //    {
                //        DataSourceWizardDLG.TypeKeys("<Enter>");
                //    }
                //    System.Threading.Thread.Sleep(1000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    System.Threading.Thread.Sleep(1000);
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    if (!DataSourceWizardDLG.YesRB.Exists)
                //    {
                //        SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Previous.bmp");
                //        Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                //    }
                //    DataSourceWizardDLG.YesRB.Click();
                //    DataSourceWizardDLG.NextPB.Click();
                //    if (DataSourceWizardDLG.YesRB.Exists)
                //    {
                //        DataSourceWizardDLG.TypeKeys("<Enter>");
                //    }
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }

                //    DataSourceWizardErrorMSG DataSourceWizardErrorMSG = new DataSourceWizardErrorMSG();
                //    if (DataSourceWizardErrorMSG.Exists)
                //    {
                //        DataSourceWizardErrorMSG.OKPB.Click();
                //    }
                //    //EntityFramework
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    if (DataSourceWizardDLG.YesRB.Exists)
                //    {
                //        SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Previous.bmp");
                //        Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                //    }
                //    System.Threading.Thread.Sleep(1000);
                //    DataSourceWizardDLG.EntityFrameworkLBI.Click();
                //    DataSourceWizardDLG.NextPB.Click();
                //    System.Threading.Thread.Sleep(5000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 6, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    //Object
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    if (!DataSourceWizardDLG.ObjectLBI.Exists)
                //    {
                //        SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Previous.bmp");
                //        Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                //    }
                //    DataSourceWizardDLG.ObjectLBI.Click();
                //    DataSourceWizardDLG.NextPB.Click();
                //    System.Threading.Thread.Sleep(3000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 7, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    //select a data source type
                //    DataSourceWizardDLG.NextPB.Click();
                //    if (DataSourceWizardDLG.MainViewTBL.Exists)
                //    {
                //        DataSourceWizardDLG.TypeKeys("<Enter>");
                //    }
                //    System.Threading.Thread.Sleep(3000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 8, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    if (!DataSourceWizardDLG.ExcelFileLBI.Exists)
                //    {
                //        SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Previous.bmp");
                //        Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                //    }
                //    if (!DataSourceWizardDLG.ExcelFileLBI.Exists)
                //    {
                //        SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Previous.bmp");
                //        Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                //    }
                //    DataSourceWizardDLG.ExcelFileLBI.Click();
                //    DataSourceWizardDLG.NextPB.Click();
                //    System.Threading.Thread.Sleep(5000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 9, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    System.Threading.Thread.Sleep(1000);
                //    if (!DataSourceWizardDLG.JSONLBI.Exists)
                //    {
                //        SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Previous.bmp");
                //        Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                //    }
                //    DataSourceWizardDLG.JSONLBI.Click();
                //    DataSourceWizardDLG.NextPB.Click();
                //    System.Threading.Thread.Sleep(1000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 10, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    DataSourceWizardDLG.PopupListPL.Select(1);
                //    System.Threading.Thread.Sleep(1000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 11, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    DataSourceWizardDLG.PopupListPL.Select(2);
                //    System.Threading.Thread.Sleep(1000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 12, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    if (!DataSourceWizardDLG.XPOLBI.Exists)
                //    {
                //        SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Previous.bmp");
                //        Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                //    }
                //    System.Threading.Thread.Sleep(1000);
                //    DataSourceWizardDLG.XPOLBI.Click();
                //    DataSourceWizardDLG.NextPB.Click();
                //    System.Threading.Thread.Sleep(1000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 13, 13))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    DataSourceWizardDLG.PreviousPB.Click();
                //    if (!DataSourceWizardDLG.XPOLBI.Exists)
                //    {
                //        SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\Previous.bmp");
                //        Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
                //    }
                //    return true;
                case "ChartWizardChartDLG":
                    ChartWizardChartDLG ChartWizardChartDLG = new ChartWizardChartDLG();
                    ChartWizardChartDLG.SetActive();
                    //ChartWizardChartDLG.PageListPG.selectTab(0);
                    ChartWizardChartDLG.SelectTab(1);

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    //ChartWizardChartDLG.PageListPG.selectTab(1);
                    ChartWizardChartDLG.SelectTab(2);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    //ChartWizardChartDLG.PageListPG.selectTab(2);
                    ChartWizardChartDLG.SelectTab(3);

                    System.Threading.Thread.Sleep(1000); 
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "PlantCustomPartsDLG":
                    PlantCustomPartsDLG PlantCustomPartsDLG = new PlantCustomPartsDLG();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PlantCustomPartsDLG.AutoCADBlockWIN.Click();
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "ProjectSetupPipeSpecObjectMappingDLG":
                    ProjectSetupPipeSpecObjectMappingDLG ProjectSetupPipeSpecObjectMappingDLG = new ProjectSetupPipeSpecObjectMappingDLG();
                    ProjectSetupPipeSpecObjectMappingDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupPipeSpecObjectMappingDLG.SelectTab(2);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "ProjectSetupPipeSpecObjectMappingDLG_Valves":
                    ProjectSetupPipeSpecObjectMappingDLG_Valves ProjectSetupPipeSpecObjectMappingDLG_Valves = new ProjectSetupPipeSpecObjectMappingDLG_Valves();
                    ProjectSetupPipeSpecObjectMappingDLG_Valves.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupPipeSpecObjectMappingDLG_Valves.SelectTab(2);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "ProjectSetupPipeSpecObjectMappingDLG_Fittings":
                    ProjectSetupPipeSpecObjectMappingDLG_Fittings ProjectSetupPipeSpecObjectMappingDLG_Fittings = new ProjectSetupPipeSpecObjectMappingDLG_Fittings();
                    ProjectSetupPipeSpecObjectMappingDLG_Fittings.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupPipeSpecObjectMappingDLG_Fittings.SelectTab(2);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "ProjectSetupPipeSpecObjectMappingDLG_Specialty":
                    ProjectSetupPipeSpecObjectMappingDLG_Specialty ProjectSetupPipeSpecObjectMappingDLG_Specialty = new ProjectSetupPipeSpecObjectMappingDLG_Specialty();
                    ProjectSetupPipeSpecObjectMappingDLG_Specialty.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupPipeSpecObjectMappingDLG_Specialty.SelectTab(2);
                    wCurrentDialog.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "Plant3DExcelImportDLG":
                    Plant3DExcelImportDLG Plant3DExcelImportDLG = new Plant3DExcelImportDLG();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Plant3DExcelImportDLG.UpdatePB.Click();                   
                    System.Threading.Thread.Sleep(10000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
   

                case "ChartWizardSeriesViewsGeneralDLG":
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ChartWizardSeriesViewsGeneralDLG ChartWizardSeriesViewsGeneralDLG = new ChartWizardSeriesViewsGeneralDLG();
                    ChartWizardSeriesViewsGeneralDLG.PageListPG.Select(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ChartWizardSeriesViewsGeneralDLG.PageListPG.Select(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ChartWizardSeriesViewsGeneralDLG.PageListPG.Select(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ChartWizardSeriesViewsGeneralDLG.PageListPG.Select(4);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "ChartWizardChartTitlesTextDLG":
                    wCurrentDialog.SetActive();
                    ChartWizardChartTitlesTextDLG ChartWizardChartTitlesTextDLG = new ChartWizardChartTitlesTextDLG();
                    //ChartWizardChartTitlesTextDLG.PageListPG.Select(0);
                    RECT r14 = ChartWizardChartTitlesTextDLG.OptionsPANE.GetRect(true);
                    Desktop.Current.Click(MouseButton.Left, r14.xPos + 5, r14.yPos - 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    //ChartWizardChartTitlesTextDLG.PageListPG.Select(1);
                    Desktop.Current.Click(MouseButton.Left, r14.xPos + 5, r14.yPos - 5);
                    Desktop.Current.TypeKeys("<Right>");
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "PandIDPIDPublishOutputSettingsDLG":
                    PandIDPIDPublishOutputSettingsDLG PandIDPIDPublishOutputSettingsDLG = new PandIDPIDPublishOutputSettingsDLG();
                    RECT r15 = PandIDPIDPublishOutputSettingsDLG.ObjectPropertiesPANE.GetRect(true);
                    Desktop.Current.Click(MouseButton.Left, r15.xPos + 5, r15.yPos - 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Desktop.Current.Click(MouseButton.Left, r15.xPos + 5, r15.yPos - 5);
                    Desktop.Current.TypeKeys("<Right>");
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "PandIDPIDDWFOutputSettingsDLG":
                    PandIDPIDDWFOutputSettingsDLG PandIDPIDDWFOutputSettingsDLG = new PandIDPIDDWFOutputSettingsDLG();
                    RECT r16 = PandIDPIDDWFOutputSettingsDLG.ObjectPropertiesPANE.GetRect(true);
                    Desktop.Current.Click(MouseButton.Left, r16.xPos + 5, r16.yPos - 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Desktop.Current.Click(MouseButton.Left, r16.xPos + 5, r16.yPos - 5);
                    Desktop.Current.TypeKeys("<Right>");
                    PandIDPIDDWFOutputSettingsDLG.ProjectDetailsTVI.Click();
                    PandIDPIDDWFOutputSettingsDLG.SetActive();
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDPIDDWFOutputSettingsDLG.ProjectDataTVI.Click();
                    PandIDPIDDWFOutputSettingsDLG.SetActive();
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDPIDDWFOutputSettingsDLG.ClientInformationTVI.Click();
                    PandIDPIDDWFOutputSettingsDLG.SetActive();
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDPIDDWFOutputSettingsDLG.DrawingPropertiesTVI.Click();
                    PandIDPIDDWFOutputSettingsDLG.SetActive();
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 5))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "IsoThemesDLG":
                    IsoThemesDLG IsoThemesDLG = new IsoThemesDLG();
                    RECT r17 = IsoThemesDLG.DefaultThemePANE.GetRect(true);
                    Desktop.Current.Click(MouseButton.Left, r17.xPos + 5, r17.yPos - 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Desktop.Current.Click(MouseButton.Left, r17.xPos + 5, r17.yPos - 5);
                    Desktop.Current.TypeKeys("<Right>");
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "CreateIsometricStyleSpoolDLG":
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleSpoolDLG CreateIsometricStyleSpoolDLG = new CreateIsometricStyleSpoolDLG();
                    CreateIsometricStyleSpoolDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleSpoolDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleSpoolDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleSpoolDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleSpoolDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 6, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateIsometricStyleSpoolDLG.Btn_Next.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 7, 7))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;

                case "Plant3DCatalogBuilderDLG":
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Plant3DCatalogBuilderDLG Plant3DCatalogBuilderDLG = new Plant3DCatalogBuilderDLG();
                    Plant3DCatalogBuilderDLG.Chevron.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;

                case "AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG":
                    var AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG = new AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG();
                    AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG.Graphics1RB.Select();
                    AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG.Graphics2RB.Select();
                    AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG.Graphics3RB.Click();
                    AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "CustomizationDLG":
                    wCurrentDialog.SetActive();
                    CustomizationDLG CustomizationDLG = new CustomizationDLG();
                    CustomizationDLG.SelectTab(1);
                    //CustomizationDLG.ToolbarsWIN.Click(MouseButton.Left, 5, 5);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CustomizationDLG.SelectTab(2);
                    //CustomizationDLG.CommandsWIN.Click(MouseButton.Left, 5, 5);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CustomizationDLG.SelectTab(3);
                    //CustomizationDLG.OptionsWIN.Click(MouseButton.Left, 5, 5);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "AutoPLANTToDMappingClassMappingDLG":                 
                    AutoPLANTToDMappingClassMappingDLG AutoPLANTToDMappingClassMappingDLG = new AutoPLANTToDMappingClassMappingDLG();
                    AutoPLANTToDMappingClassMappingDLG.ClassMappingST.Click(MouseButton.Left, 5, 5);
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AutoPLANTToDMappingClassMappingDLG.GeometryMappingST.Click(MouseButton.Left, 5, 5);
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AutoPLANTToDMappingClassMappingDLG.PropertyTranslationST.Click(MouseButton.Left, 5, 5);
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "CADWorxToPlantDMappingClassMappingDLG":
                    var CADWorxToPlantDMappingClassMappingDLG = new CADWorxToPlantDMappingClassMappingDLG();
                    CADWorxToPlantDMappingClassMappingDLG.ClassMappingST.Click(MouseButton.Left, 5, 5);
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CADWorxToPlantDMappingClassMappingDLG.GeometryMappingST.Click(MouseButton.Left, 5, 5);
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CADWorxToPlantDMappingClassMappingDLG.PropertyTranslationST.Click(MouseButton.Left, 5, 5);
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "PandIDAutoCADPIDMigration2009DLG":
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDAutoCADPIDMigration2009DLG PandIDAutoCADPIDMigration2009DLG = new PandIDAutoCADPIDMigration2009DLG();
                    PandIDAutoCADPIDMigration2009DLG.NextPB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDAutoCADPIDMigration2009DLG.TextFieldTF.SetText("C:\\temp");
                    //PandIDAutoCADPIDMigration2009DLG.BackupTheseFilesBeforeCK.Uncheck();
                    PandIDAutoCADPIDMigration2009DLG.NextPB.Click();
                    System.Threading.Thread.Sleep(90000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;

                case "PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG":
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG = new PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG();
                    PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_radioSQLServer.Click();


                    PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboAuthent.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDProjectSetupWizardSpecifyDatabaseSettingsDLG.M_comboAuthent.Select(1);

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;

                case "PandIDPMUConvertProjectToSQLExpressDLG":
                    PandIDPMUConvertProjectToSQLExpressDLG PandIDPMUConvertProjectToSQLExpressDLG = new PandIDPMUConvertProjectToSQLExpressDLG();
                    try
                    {
                        PandIDPMUConvertProjectToSQLExpressDLG.AuthenticationCombobox.Select(AcMainWin.cBabel(21060, 2, "Windows Authentication"));
                    }
                    catch (Exception)
                    {
                    }

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDPMUConvertProjectToSQLExpressDLG.AuthenticationCombobox.TypeKeys("<Down>");
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;

                case "PandIDPROJECTMANAGERDLG":
                    PandIDPROJECTMANAGERDLG PandIDPROJECTMANAGERDLG = new PandIDPROJECTMANAGERDLG();
                    RECT rPaletteWnd = PandIDPROJECTMANAGERDLG.GetRect();
                    PandIDPROJECTMANAGERDLG.SetActive();
                    PandIDPROJECTMANAGERDLG.Click(MouseButton.Left, rPaletteWnd.xSize - 10, 74);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDPROJECTMANAGERDLG.SetActive();
                    PandIDPROJECTMANAGERDLG.Click(MouseButton.Left, rPaletteWnd.xSize - 10, 190);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDPROJECTMANAGERDLG.SetActive();
                    PandIDPROJECTMANAGERDLG.Click(MouseButton.Left, rPaletteWnd.xSize - 10, 320);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "P3DTagFormatSetupDLG":
                    P3DTagFormatSetupDLG P3DTagFormatSetupDLG = new P3DTagFormatSetupDLG();

                    if (P3DTagFormatSetupDLG.Pane1PANE.Exists)
                    {
                        P3DTagFormatSetupDLG.M_btnMoreless.Click();
                    }
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }                   
                        P3DTagFormatSetupDLG.M_btnMoreless.Click();                                     
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "PipingComponentSelectionDLG":
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PipingComponentSelectionDLG PipingComponentSelectionDLG = new PipingComponentSelectionDLG();
                    PipingComponentSelectionDLG.AdvancedST.DoubleClick(MouseButton.Left, 5, 2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "PipingComponentSelectionAddExclusionDLG":
                    wCurrentDialog.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PipingComponentSelectionAddExclusionDLG PipingComponentSelectionAddExclusionDLG = new PipingComponentSelectionAddExclusionDLG();
                    PipingComponentSelectionAddExclusionDLG.AdvancedST.DoubleClick(MouseButton.Left, 5, 2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;


                case "AddPropertyConnections": 
                    AddPropertyConnections AddPropertyConnections = new AddPropertyConnections();
                    AddPropertyConnections.PCFST.DoubleClick(MouseButton.Left, 2, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    AddPropertyConnections.SymbolsST.DoubleClick(MouseButton.Left, 2, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "OrthoDWGTableSetupDLG": 
                    OrthoDWGTableSetupDLG OrthoDWGTableSetupDLG = new OrthoDWGTableSetupDLG();
                    OrthoDWGTableSetupDLG.TableLayoutST.DoubleClick(MouseButton.Left, 2, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    OrthoDWGTableSetupDLG.SettingsST.DoubleClick(MouseButton.Left, 2, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                //case "AddPropertyPropertyChanges": // 3 shapes
                //    AddPropertyPropertyChanges AddPropertyPropertyChanges = new AddPropertyPropertyChanges();
                //    AddPropertyPropertyChanges.Plant3DST.DoubleClick(MouseButton.Left, 5, 2);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                //        DlgBox_Engine.Current.giNbFailure++;
                //    AddPropertyPropertyChanges.PCFST.DoubleClick(MouseButton.Left, 5, 2);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                //        DlgBox_Engine.Current.giNbFailure++;
                //    AddPropertyPropertyChanges.Symbols1ST.DoubleClick(MouseButton.Left, 5, 2);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                //        DlgBox_Engine.Current.giNbFailure++;
                //    return true;
                //case "IsometricDWGSettingsIsoStyleSetupAddPropertyDLG": // 3 shapes
                //IsometricDWGSettingsIsoStyleSetupAddPropertyDLG IsometricDWGSettingsIsoStyleSetupAddPropertyDLG = new IsometricDWGSettingsIsoStyleSetupAddPropertyDLG();
                //IsometricDWGSettingsIsoStyleSetupAddPropertyDLG.Plant3DST.DoubleClick(MouseButton.Left, 5, 2);
                //DlgBox_Engine.Current.giNbDialogChecked++;
                //if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                //    DlgBox_Engine.Current.giNbFailure++;
                //IsometricDWGSettingsIsoStyleSetupAddPropertyDLG.ExistingAttributesST.DoubleClick(MouseButton.Left, 5, 2);
                //DlgBox_Engine.Current.giNbDialogChecked++;
                //if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                //    DlgBox_Engine.Current.giNbFailure++;
                //IsometricDWGSettingsIsoStyleSetupAddPropertyDLG.SymbolsST.DoubleClick(MouseButton.Left, 5, 2);
                //DlgBox_Engine.Current.giNbDialogChecked++;
                //if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                //    DlgBox_Engine.Current.giNbFailure++;
                //return true;
                case "IsometricDWGSettingsIsoStyleSetupAddPropertyDLG": // 3 shapes
                    IsometricDWGSettingsIsoStyleSetupAddPropertyDLG IsometricDWGSettingsIsoStyleSetupAddPropertyDLG = new IsometricDWGSettingsIsoStyleSetupAddPropertyDLG();
                    IsometricDWGSettingsIsoStyleSetupAddPropertyDLG.Plant3DST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsIsoStyleSetupAddPropertyDLG.PCFST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                 
                    return true;
                case "AddPropertyPiping": // 3 shapes
                    AddPropertyPiping AddPropertyPiping = new AddPropertyPiping();
                    AddPropertyPiping.Plant3DST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    AddPropertyPiping.PCFST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    AddPropertyPiping.SymbolsST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    //AddPropertyPiping.SpecialPropertiesST.DoubleClick(MouseButton.Left, 5, 2);
                    //DlgBox_Engine.Current.giNbDialogChecked++;
                    //if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                    //    DlgBox_Engine.Current.giNbFailure++;
                    return true;
                //case "CalculatedPropertiesManager": // 3 shapes
                //    CalculatedPropertiesManager CalculatedPropertiesManager = new CalculatedPropertiesManager();
                //    CalculatedPropertiesManager.PnIdWIN.DoubleClick(MouseButton.Left, 5, 2);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                //        DlgBox_Engine.Current.giNbFailure++;
                //    CalculatedPropertiesManager.PipingWIN.DoubleClick(MouseButton.Left, 5, 2);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                //        DlgBox_Engine.Current.giNbFailure++;
                //    CalculatedPropertiesManager.IsoWIN.DoubleClick(MouseButton.Left, 5, 2);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                //        DlgBox_Engine.Current.giNbFailure++;
                //    CalculatedPropertiesManager.OrthoWIN.DoubleClick(MouseButton.Left, 5, 2);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                //        DlgBox_Engine.Current.giNbFailure++;
                //    //CalculatedPropertiesManager.MiscWIN.DoubleClick(MouseButton.Left, 5, 2);
                //    //DlgBox_Engine.Current.giNbDialogChecked++;
                //    //if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 5))
                //    //    DlgBox_Engine.Current.giNbFailure++;
                //    return true;
                case "IsometricDWGSettingsAnnotationsTableIDDLG": // 3 shapes
                    IsometricDWGSettingsAnnotationsTableIDDLG IsometricDWGSettingsAnnotationsTableIDDLG = new IsometricDWGSettingsAnnotationsTableIDDLG();
                    IsometricDWGSettingsAnnotationsTableIDDLG.WhatToAnnotateLB.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 6))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsTableIDDLG.WhatToAnnotateLB.Select(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 6))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsTableIDDLG.WhatToAnnotateLB.Select(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 6))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsTableIDDLG.WhatToAnnotateLB.Select(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 6))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsTableIDDLG.WhatToAnnotateLB.Select(4);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 6))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsTableIDDLG.WhatToAnnotateLB.Select(5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 6, 6))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "IsometricDWGSettingsAnnotationsPropertyChangesDLG": // 3 shapes
                    IsometricDWGSettingsAnnotationsPropertyChangesDLG IsometricDWGSettingsAnnotationsPropertyChangesDLG = new IsometricDWGSettingsAnnotationsPropertyChangesDLG();
                    IsometricDWGSettingsAnnotationsPropertyChangesDLG.WhatToAnnotateLB.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 5))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsPropertyChangesDLG.WhatToAnnotateLB.Select(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 5))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsPropertyChangesDLG.WhatToAnnotateLB.Select(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 5))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsPropertyChangesDLG.WhatToAnnotateLB.Select(4);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 5))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsAnnotationsPropertyChangesDLG.WhatToAnnotateLB.Select(5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 5))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "AddAnnotationDLG":
                    AddAnnotationDLG AddAnnotationDLG = new AddAnnotationDLG();
                    AddAnnotationDLG.StandardST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    AddAnnotationDLG.AdvancedST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "ProjectSetupIsoThemesDLG":
                    ProjectSetupIsoThemesDLG ProjectSetupIsoThemesDLG = new ProjectSetupIsoThemesDLG();
                    ProjectSetupIsoThemesDLG.DefaultPipingST.DoubleClick(MouseButton.Left, 5, 2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    ProjectSetupIsoThemesDLG.OverrideST.DoubleClick(MouseButton.Left, 5, 2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupIsoThemesDLG.BranchPipingST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "ProjectSetupIsoThemesBranchPipingDLG":
                    ProjectSetupIsoThemesBranchPipingDLG ProjectSetupIsoThemesBranchPipingDLG = new ProjectSetupIsoThemesBranchPipingDLG();
                    ProjectSetupIsoThemesBranchPipingDLG.BranchPipingThemesLB.Select(0);
                    ProjectSetupIsoThemesBranchPipingDLG.PipingDetailsPB.Click();
                    ProjectSetupIsoThemesBranchPipingDLG.StartsWithPB.Click();
                    ProjectSetupIsoThemesBranchPipingDLG.EndsWithPB.Click();                    
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupIsoThemesBranchPipingDLG.BranchPipingThemesLB.Select(1);
                    ProjectSetupIsoThemesBranchPipingDLG.Contains9PB.Click();
                    ProjectSetupIsoThemesBranchPipingDLG.DoesNotContainPB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "IsometricDWGSettingsIsoStyleSetupDLG":
                    var IsometricDWGSettingsIsoStyleSetupDLG = new IsometricDWGSettingsIsoStyleSetupDLG();
                    IsometricDWGSettingsIsoStyleSetupDLG.SizingMethodPL.Select(0);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsIsoStyleSetupDLG.SizingMethodPL.Select(1);
                   
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsIsoStyleSetupDLG.SizingMethodPL.Select(2);

                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "ProjectSetupIsoThemesOverrideDLG":

                    ProjectSetupIsoThemesOverrideDLG ProjectSetupIsoThemesOverrideDLG = new ProjectSetupIsoThemesOverrideDLG();
                    ProjectSetupIsoThemesOverrideDLG.OverrideThemesLB.Select(0);
                    ProjectSetupIsoThemesOverrideDLG.PipingDetailsPB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupIsoThemesOverrideDLG.OverrideThemesLB.Select(1);
                    System.Threading.Thread.Sleep(300);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupIsoThemesOverrideDLG.OverrideThemesLB.Select(2);
                    ProjectSetupIsoThemesOverrideDLG.StartsWithPB.Click();
                    ProjectSetupIsoThemesOverrideDLG.TypeKeys("<Down><Space><Down 2><Space>");
                    //ProjectSetupIsoThemesOverrideDLG.EndsWithPB.Click();
                    //ProjectSetupIsoThemesOverrideDLG.OnlyContainPB.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupIsoThemesOverrideDLG.OverrideThemesLB.Select(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "IsometricDWGSettingsDimensionsDLG":


                    IsometricDWGSettingsDimensionsDLG IsometricDWGSettingsDimensionsDLG = new IsometricDWGSettingsDimensionsDLG();
                    IsometricDWGSettingsDimensionsDLG.SettingsST.DoubleClick(MouseButton.Left, 5, 2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    IsometricDWGSettingsDimensionsDLG.EndToEndOverallST.DoubleClick(MouseButton.Left, 5, 5);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsDimensionsDLG.StringST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsDimensionsDLG.LocatingST.DoubleClick(MouseButton.Left, 5, 2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "IsometricDWGSettingsDimensionsSettingsDefaultDLG":

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsDimensionsSettingsDefaultDLG IsometricDWGSettingsDimensionsSettingsDefaultDLG = new IsometricDWGSettingsDimensionsSettingsDefaultDLG();
                    IsometricDWGSettingsDimensionsSettingsDefaultDLG.EndToEndCK.Click(MouseButton.Left, 2, 2);
                    //IsometricDWGSettingsDimensionsSettingsDefaultDLG.TypeKeys("<Space>");
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsDimensionsSettingsDefaultDLG.StringCK.Click(MouseButton.Left, 2, 2);
                    //IsometricDWGSettingsDimensionsSettingsDefaultDLG.TypeKeys("<Space>");
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsDimensionsSettingsDefaultDLG.LocatingCK.Click(MouseButton.Left, 2, 2);
                    //IsometricDWGSettingsDimensionsSettingsDefaultDLG.TypeKeys("<Space>");
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "IsometricDWGSettingsDimensionsSettingsGasketDimensioningDLG":

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsDimensionsSettingsGasketDimensioningDLG IsometricDWGSettingsDimensionsSettingsGasketDimensioningDLG = new IsometricDWGSettingsDimensionsSettingsGasketDimensioningDLG();
                    IsometricDWGSettingsDimensionsSettingsGasketDimensioningDLG.GeneralSettingsPL.Select(1);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsDimensionsSettingsGasketDimensioningDLG.GeneralSettingsPL.Select(2);
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "IsometricDWGSettingsDimensionsLocatingSupportDLG":

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    IsometricDWGSettingsDimensionsLocatingSupportDLG IsometricDWGSettingsDimensionsLocatingSupportDLG = new IsometricDWGSettingsDimensionsLocatingSupportDLG();
                    IsometricDWGSettingsDimensionsLocatingSupportDLG.HowToDimensionEndPointsPL.Select(1);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "ProjectCompareIsometricsIsoStylesDLG":

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectCompareIsometricsIsoStylesDLG ProjectCompareIsometricsIsoStylesDLG = new ProjectCompareIsometricsIsoStylesDLG();
                    ProjectCompareIsometricsIsoStylesDLG.IsodwtLBI.Click(MouseButton.Left, 1, 1);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "ProjectCompareIsometricsSupportFilesDLG":

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectCompareIsometricsSupportFilesDLG ProjectCompareIsometricsSupportFilesDLG = new ProjectCompareIsometricsSupportFilesDLG();
                    ProjectCompareIsometricsSupportFilesDLG.Plant3dIsoSymbolsdwgLBI.Click(MouseButton.Left, 1, 1);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "ProjectComparePipingLayerColorSettingsDLG":

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectComparePipingLayerColorSettingsDLG ProjectComparePipingLayerColorSettingsDLG = new ProjectComparePipingLayerColorSettingsDLG();
                    ProjectComparePipingLayerColorSettingsDLG.DefaultLBI.Click(MouseButton.Left, 1, 1);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "ProjectComparePIDClassesDLG":

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectComparePIDClassesDLG ProjectComparePIDClassesDLG = new ProjectComparePIDClassesDLG();

                    ProjectComparePIDClassesDLG.Acceptall.Click();
                    System.Threading.Thread.Sleep(1000);
                                     
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                //case "ProjectComparePIDClassesDLG":

                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    ProjectComparePIDClassesDLG ProjectComparePIDClassesDLG = new ProjectComparePIDClassesDLG();

                //    ProjectComparePIDClassesDLG.ModifiedGB.Click();
                //    System.Threading.Thread.Sleep(1000);
                //    ProjectComparePIDClassesDLG.TypeKeys("<Tab 2><Space>");
                //    System.Threading.Thread.Sleep(1000);
                //    ProjectComparePIDClassesDLG.TypeKeys("<Down 2><Space>");
                //    System.Threading.Thread.Sleep(3000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }

                //return true;
                //case "ProjectComparePipingClassesDLG":

                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    ProjectComparePipingClassesDLG ProjectComparePipingClassesDLG = new ProjectComparePipingClassesDLG();

                //    ProjectComparePipingClassesDLG.ModifiedGB.Click();
                //    System.Threading.Thread.Sleep(1000);
                //    ProjectComparePipingClassesDLG.TypeKeys("<Tab 2><Space>");
                //    System.Threading.Thread.Sleep(1000);
                //    ProjectComparePipingClassesDLG.TypeKeys("<Down 2><Space>");
                //    System.Threading.Thread.Sleep(3000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }

                //    return true;
                case "IsoStyleEditorDLG":
                    IsoStyleEditorDLG IsoStyleEditorDLG = new IsoStyleEditorDLG();
                    IsoStyleEditorDLG.TableWIN.Click(MouseButton.Left,1,1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    IsoStyleEditorDLG.CodeWIN.Click(MouseButton.Left, 1, 1);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "DataManagerConfigurationDLG":
                    DataManagerConfigurationDLG DataManagerConfigurationDLG = new DataManagerConfigurationDLG();
                    DataManagerConfigurationDLG.CreateViewPB.Click();
                    DataManagerConfigurationDLG.NewLevelPB.Click();
                    System.Threading.Thread.Sleep(1000);
                    var PandIDSelectClassPropertyDLG = new PandIDSelectClassPropertyDLG();
                    PandIDSelectClassPropertyDLG.M_button_ok.Click();
                    DataManagerConfigurationDLG.ScopePL.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataManagerConfigurationDLG.ScopePL.Select(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "ProjectCompareProgramDLG":

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectCompareProgramDLG ProjectCompareProgramDLG = new ProjectCompareProgramDLG();
                    ProjectCompareProgramDLG.BrowsePB.Click(MouseButton.Left, 2, 2);
                    System.Threading.Thread.Sleep(1000);
                    ProjectCompareBrowserDLG ProjectCompareBrowserDLG = new ProjectCompareBrowserDLG();
                    ProjectCompareBrowserDLG.FileNameCB.SetText(LAGT.CommonFiles.Product.Variables.TestFilesDir+ "TestProjectCompare.txt");
                    ProjectCompareBrowserDLG.OpenPB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "SeriesCollectionEditorPointsDLG":
                    SeriesCollectionEditorPointsDLG SeriesCollectionEditorPointsDLG = new SeriesCollectionEditorPointsDLG();
                    SeriesCollectionEditorPointsDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    SeriesCollectionEditorPointsDLG.SelectTab(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "FormatStringEditorGeneralStandardTypesDLG":
                    FormatStringEditorGeneralStandardTypesDLG FormatStringEditorGeneralStandardTypesDLG = new FormatStringEditorGeneralStandardTypesDLG();
                    FormatStringEditorGeneralStandardTypesDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    FormatStringEditorGeneralStandardTypesDLG.SelectTab(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "FormatStringEditorStandardTypesDLG":
                    FormatStringEditorStandardTypesDLG FormatStringEditorStandardTypesDLG = new FormatStringEditorStandardTypesDLG();
                    FormatStringEditorStandardTypesDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    FormatStringEditorStandardTypesDLG.SelectTab(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "ReportWizardDLG":
                    ReportWizardDLG ReportWizardDLG = new ReportWizardDLG();
                    ReportWizardDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    if (!ReportWizardDLG.RightNode1TVI.Exists) {
                        ReportWizardDLG.LeftNode01TVI.Click();
                        ReportWizardDLG.LeftNode01TVI.TypeKeys("<Space>");
                    }
                    ReportWizardDLG.RightNode1TVI.Click();
                    ReportWizardDLG.RightNode1TVI.TypeKeys("<Space>");
                    ReportWizardDLG.NextPB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ReportWizardDLG.AddPB.Click();
                    System.Threading.Thread.Sleep(1000);
                    ReportWizardDLG.NextPB.Click();
                    if (ReportWizardDLG.AddPB.Exists) {
                        ReportWizardDLG.TypeKeys("<Enter>");
                    }
                    System.Threading.Thread.Sleep(2000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ReportWizardDLG.NextPB.Click();
                    if (ReportWizardDLG.IgnoreNullValuesCK.Exists)
                    {
                        ReportWizardDLG.TypeKeys("<Enter>");
                    }
                    System.Threading.Thread.Sleep(2000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ReportWizardDLG.NextPB.Click();
                    if (ReportWizardDLG.LandscapePB.Exists)
                    {
                        ReportWizardDLG.TypeKeys("<Enter>");
                    }
                    System.Threading.Thread.Sleep(2000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 5, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ReportWizardDLG.NextPB.Click();
                    if (ReportWizardDLG.ListBoxLB.Exists)
                    {
                        ReportWizardDLG.TypeKeys("<Enter>");
                    }
                    System.Threading.Thread.Sleep(2000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 6, 6))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "P3DSelectDataSourceDLG":
                    P3DSelectDataSourceDLG P3DSelectDataSourceDLG = new P3DSelectDataSourceDLG();
                    P3DSelectDataSourceDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    P3DSelectDataSourceDLG.SelectTab(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    P3DSelectDataSourceDLG.SelectTab(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "SpecUtilityCatalogPartsDLG":
                    SpecUtilityCatalogPartsDLG SpecUtilityCatalogPartsDLG = new SpecUtilityCatalogPartsDLG();
                    SpecUtilityCatalogPartsDLG.GeneralPropertiesWIN.DoubleClick(MouseButton.Left,5,5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    SpecUtilityCatalogPartsDLG.SizesWIN.DoubleClick(MouseButton.Left, 5, 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "IsometricDWGSettingsIsoStyleSetupMDLG":
                    IsometricDWGSettingsIsoStyleSetupMDLG IsometricDWGSettingsIsoStyleSetupMDLG = new IsometricDWGSettingsIsoStyleSetupMDLG();
                    IsometricDWGSettingsIsoStyleSetupMDLG.SizingMethodPL.Select(0); 
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    IsometricDWGSettingsIsoStyleSetupMDLG.SizingMethodPL.Select(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "SpecUtilityEditpartsPartListDLG":
                    SpecUtilityEditpartsPartListDLG SpecUtilityEditpartsPartListDLG = new SpecUtilityEditpartsPartListDLG();
                    SpecUtilityEditpartsPartListDLG.DisplayPL.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                        DlgBox_Engine.Current.giNbFailure++;
                    SpecUtilityEditpartsPartListDLG.DisplayPL.Select(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                        DlgBox_Engine.Current.giNbFailure++;
                    SpecUtilityEditpartsPartListDLG.DisplayPL.Select(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                        DlgBox_Engine.Current.giNbFailure++;
                    SpecUtilityEditpartsPartListDLG.DisplayPL.Select(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "ProjectSetupProjectDetailsDLG":
                    ProjectSetupProjectDetailsDLG ProjectSetupProjectDetailsDLG = new ProjectSetupProjectDetailsDLG();
                    ProjectSetupProjectDetailsDLG.ProjectDataLBI.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    ProjectSetupProjectDetailsDLG.ClientInformationLBI.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "CsvToPlantDMappingClassMappingDLG":
                    CsvToPlantDMappingClassMappingDLG CsvToPlantDMappingClassMappingDLG = new CsvToPlantDMappingClassMappingDLG();
                    CsvToPlantDMappingClassMappingDLG.ClassMappingWIN.Click(MouseButton.Left,5,5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    CsvToPlantDMappingClassMappingDLG.GeometryMappingWIN.Click(MouseButton.Left, 5, 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    CsvToPlantDMappingClassMappingDLG.PropertyTranslationWIN.Click(MouseButton.Left, 5, 5);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "PIDLineList":
                    PIDLineList PIDLineList = new PIDLineList();
                    System.Threading.Thread.Sleep(1000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                        DlgBox_Engine.Current.giNbFailure++;
                    PIDLineList.PushButton1PB.Click();//1038
                    System.Threading.Thread.Sleep(1000);
                    Desktop.Current.TypeKeys("<Down 2>");
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                        DlgBox_Engine.Current.giNbFailure++;
                    Desktop.Current.TypeKeys("<Esc><home><Subtract>",250);
                    PIDLineList.PushButton2PB.Click();//1039
                    System.Threading.Thread.Sleep(1000);
                    Desktop.Current.TypeKeys("<Down 11>");
                    Desktop.Current.MoveMouse(10, 10);
                    
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                        DlgBox_Engine.Current.giNbFailure++;
                    Desktop.Current.TypeKeys("<Esc><home><Down><Subtract>",250);
                    System.Threading.Thread.Sleep(5000);
                    PIDLineList.Pane3PANE.Click(MouseButton.Right,50,50);
                    Desktop.Current.TypeKeys("<Down><Enter>");
                    System.Threading.Thread.Sleep(5000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                        DlgBox_Engine.Current.giNbFailure++;
                    return true;
                case "Plant3DDWFOutputSettingsDLG":
                    Plant3DDWFOutputSettingsDLG Plant3DDWFOutputSettingsDLG = new Plant3DDWFOutputSettingsDLG();
                    Plant3DDWFOutputSettingsDLG.ShowClassesWithItemsCK.Uncheck();
                    Plant3DDWFOutputSettingsDLG.PageListPG.selectTab(0);

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Plant3DDWFOutputSettingsDLG.PageListPG.selectTab(1);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
               
                case "PandIDAddSelectionListDLG":
                    var PandIDAddSelectionListDLG = new PandIDAddSelectionListDLG();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDAddSelectionListDLG.NewSelectionListNameTF.SetText("TEST");
                    PandIDAddSelectionListDLG.OKPB.Click();
                    PandIDSelectionListPropertyDLG PandIDSelectionListPropertyDLG = new PandIDSelectionListPropertyDLG();                  
                    PandIDSelectionListPropertyDLG.AddListPB.Click();
                    PandIDAddSelectionListDLG.NewSelectionListNameTF.SetText("TEST"); 
                    PandIDAddSelectionListDLG.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    System.Threading.Thread.Sleep(3000);
                    PandIDAddSelectionListDLG.CancelPB.Click();
                    PandIDSelectionListPropertyDLG.RemoveListPB.Click();
                    var ConfirmDeleteSelectionListDLG = new ConfirmDeleteSelectionListDLG();
                    ConfirmDeleteSelectionListDLG.YesPB.Click();
                    return true;
                case "PandIDSelectionListPropertyDLG":
                    var PandIDSelectionListPropertyDLG1 = new PandIDSelectionListPropertyDLG();
                    var PandIDAddSelectionListDLG1 = new PandIDAddSelectionListDLG();
                    PandIDSelectionListPropertyDLG1.AddListPB.Click();
                    PandIDAddSelectionListDLG1.NewSelectionListNameTF.SetText("TEST");
                    PandIDAddSelectionListDLG1.OKPB.Click();
                    PandIDSelectionListPropertyDLG1.AddListPB.Click();                    
                    PandIDAddSelectionListDLG1.NewSelectionListNameTF.SetText("TEST1");
                    PandIDAddSelectionListDLG1.CreateSharedSelectionListCK.Click();
                    PandIDAddSelectionListDLG1.OKPB.Click();
                    PandIDSelectionListPropertyDLG1.AddRowPB.Click();

                    var P3DAddRowDLG = new P3DAddRowDLG();
                    P3DAddRowDLG.DescriptionTF.SetText("TESTAAA");
                    P3DAddRowDLG.ValueTF.SetText("TESTBBB");
                    P3DAddRowDLG.OKPB.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 1))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    var Plant3DDeleteSharedListDLG = new Plant3DDeleteSharedListDLG();
                    PandIDSelectionListPropertyDLG1.NameLB.Select("TEST1");
                    PandIDSelectionListPropertyDLG1.RemoveListPB.Click();
                    System.Threading.Thread.Sleep(2000);
                    if (Plant3DDeleteSharedListDLG.Exists) {
                        Plant3DDeleteSharedListDLG.DeleteTETSFromBothPB.Click();
                    }
                    PandIDSelectionListPropertyDLG1.NameLB.Select("TEST");
                    PandIDSelectionListPropertyDLG1.RemoveListPB.Click();
                    var ConfirmDeleteSelectionListDLG1 = new ConfirmDeleteSelectionListDLG();
                    ConfirmDeleteSelectionListDLG1.YesPB.Click();
                    return true;
                case "SpecUpdateCheckDLG":
                    SpecUpdateCheckDLG SpecUpdateCheckDLG = new SpecUpdateCheckDLG();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SpecUpdateCheckDLG.M_comboBoxHoursPL.Select(5);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "AutoCADPlantDSpecEditorxSpecEditortabDLG":
                    AutoCADPlantDSpecEditorxSpecEditortabDLG AutoCADPlantDSpecEditorxSpecEditortabDLG = new AutoCADPlantDSpecEditorxSpecEditortabDLG();

                    AutoCADPlantDSpecEditorxSpecEditortabDLG.PartFamilyPropertiesST.Click(MouseButton.Left, 2, 2);
                    AutoCADPlantDSpecEditorxSpecEditortabDLG.FamilyPB.Click();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AutoCADPlantDSpecEditorxSpecEditortabDLG.PartSizeProperties1ST.Click(MouseButton.Left, 2, 2);
                    AutoCADPlantDSpecEditorxSpecEditortabDLG.SizePB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                   
                    return true;
                case "AutoCADPlantDSpecEditorxCatalogEditortabDLG":
                    AutoCADPlantDSpecEditorxCatalogEditortabDLG AutoCADPlantDSpecEditorxCatalogEditortabDLG = new AutoCADPlantDSpecEditorxCatalogEditortabDLG();                   
                    AutoCADPlantDSpecEditorxCatalogEditortabDLG.FamilyPB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AutoCADPlantDSpecEditorxCatalogEditortabDLG.SizePB.Click();
                    System.Threading.Thread.Sleep(3000);
                    AutoCADPlantDSpecEditorxCatalogEditortabDLG.AddPB.Click();
                    AutoCADPlantDSpecEditorxCatalogEditortabDLG.DuplicatePB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "SpecUpdateNotificationCatalogpartshavechangedDLG1":
                    SpecUpdateNotificationCatalogpartshavechangedDLG1 SpecUpdateNotificationCatalogpartshavechangedDLG1 = new SpecUpdateNotificationCatalogpartshavechangedDLG1();
                    
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SpecUpdateNotificationCatalogpartshavechangedDLG1.PushButtonPB.Click();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
               
                case "CreateNewComponentDLG1":
                    var CreateNewComponentDLG1 = new CreateNewComponentDLG1();
                    CreateNewComponentDLG1.GraphicsSelection1RB.Select();
                    CreateNewComponentDLG1.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateNewComponentDLG1.PushButton5PB.Click();
                    CreateNewComponentDLG1.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CreateNewComponentDLG1.GraphicsSelection2RB.Select();
                    CreateNewComponentDLG1.SetActive();                 
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++; 
                    }
                    return true;
                case "ProjectSetupLayerAndColorSettingDLG":
                    var ProjectSetupLayerAndColorSettingDLG = new ProjectSetupLayerAndColorSettingDLG();
                    ProjectSetupLayerAndColorSettingDLG.AssignLayerBy1PL.Select(0);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupLayerAndColorSettingDLG.AssignLayerBy1PL.Select(1);
                    ProjectSetupLayerAndColorSettingDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupLayerAndColorSettingDLG.AssignLayerBy1PL.Select(2);
                    ProjectSetupLayerAndColorSettingDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "PandIDSelectDataSourceDLG":
                    PandIDSelectDataSourceDLG PandIDSelectDataSourceDLG = new PandIDSelectDataSourceDLG();

                    PandIDSelectDataSourceDLG.PageListPG.selectTab(0);

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDSelectDataSourceDLG.PageListPG.selectTab(1);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PandIDSelectDataSourceDLG.PageListPG.selectTab(2);
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 3))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "Plant3DAuditProjectDLG_Collaboration":
                    var Plant3DAuditProjectDLG_Collaboration = new Plant3DAuditProjectDLG_Collaboration();
                    Plant3DAuditProjectDLG_Collaboration.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Plant3DAuditProjectDLG_Collaboration.AuditPB.Click();
                    System.Threading.Thread.Sleep(12000);
                    Plant3DAuditProjectDLG_Collaboration.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                   
                    return true;
                case "Plant3DOrthoGenerationDLG1":
                    var Plant3DOrthoGenerationDLG1 = new Plant3DOrthoGenerationDLG1();
                    Plant3DOrthoGenerationDLG1.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    Plant3DOrthoGenerationDLG1.UpdatePB.Click();
                    System.Threading.Thread.Sleep(8000);
                    Plant3DOrthoGenerationDLG1.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "PortProperties":
                    PortProperties PortProperties = new PortProperties();
                    PropertiesPallete PropertiesPallete = new PropertiesPallete();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    PropertiesPallete.ListBoxLB.Select(Plant3DFunctions.GetLocString("PortName"));
                    Desktop.Current.TypeKeys("<Home><F4><Down><Enter>");

                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "OrthoGenerationSettingsDLG":
                    var OrthoGenerationSettingsDLG = new OrthoGenerationSettingsDLG();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    OrthoGenerationSettingsDLG.Use3DModelLayersCK.Check();
                    OrthoGenerationSettingsDLG.PopupList1PL.Select(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "CheckInSettingsDLG":
                    var CheckInSettingsDLG = new CheckInSettingsDLG();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CheckInSettingsDLG.PopupListPL.Select(1);                    
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    CheckInSettingsDLG.PopupListPL.Select(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    CheckInSettingsDLG.PopupListPL.Select(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }

                    return true;
                case "AdvanceSteelXMLExportDLG":
                    var AdvanceSteelXMLExportDLG = new AdvanceSteelXMLExportDLG();
                    AdvanceSteelXMLExportDLG.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    AdvanceSteelXMLExportDLG.ExportPB.Click();
                    AdvanceSteelXMLExportDLG.SetActive();
                    System.Threading.Thread.Sleep(3000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "ProjectSetupforVault":
                    var ProjectSetupforVault = new ProjectSetupforVault();
                    ProjectSetupforVault.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    ProjectSetupforVault.CheckOutPB.Click();
                    ProjectSetupforVault.SetActive();
                    System.Threading.Thread.Sleep(8000);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                //case "ProjectSetupforCollaboration":
                //    var ProjectSetupforCollaboration = new ProjectSetupforCollaboration();
                //    ProjectSetupforCollaboration.SetActive();
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    ProjectSetupforCollaboration.CheckOutPB.Click();
                //    ProjectSetupforCollaboration.SetActive();
                //    System.Threading.Thread.Sleep(8000);
                //    DlgBox_Engine.Current.giNbDialogChecked++;
                //    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                //    {
                //        DlgBox_Engine.Current.giNbFailure++;
                //    }
                //    return true;
                case "SelectVaultLocationDLG1":
                    var SelectVaultLocationDLG1 = new SelectVaultLocationDLG1();
                    SelectVaultLocationDLG1.SetActive();
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    SelectVaultLocationDLG1.NonReleasedBiasedPB.Click();
                    SelectVaultLocationDLG1.SetActive();                 
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 2))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    System.Threading.Thread.Sleep(2000);
                    return true;
                case "PandIDPandIDValidationSettingsDLG":
                    var PandIDPandIDValidationSettingsDLG = new PandIDPandIDValidationSettingsDLG();
                    PandIDPandIDValidationSettingsDLG.SetActive();
                    PandIDPandIDValidationSettingsDLG.threeDPipingTVI.Select();
                    PandIDPandIDValidationSettingsDLG.threeDPipingTVI.TypeKeys("<Right>");
                    PandIDPandIDValidationSettingsDLG.BaseAutoCADObjectsTVI.Select();
                    PandIDPandIDValidationSettingsDLG.BaseAutoCADObjectsTVI.TypeKeys("<Right>");
                    PandIDPandIDValidationSettingsDLG.threeDModelToPIDTVI.Select();
                    PandIDPandIDValidationSettingsDLG.threeDModelToPIDTVI.TypeKeys("<Right>");
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 1))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "DataLinkPropertiesDLG":
                    var DataLinkPropertiesDLG = new DataLinkPropertiesDLG();
                    DataLinkPropertiesDLG.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG.SelectTab(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG.SelectTab(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG.SelectTab(4);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "DataLinkPropertiesDLG_P3D":
                    var DataLinkPropertiesDLG_P3D = new DataLinkPropertiesDLG_P3D();
                    DataLinkPropertiesDLG_P3D.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG_P3D.SelectTab(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG_P3D.SelectTab(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG_P3D.SelectTab(4);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                case "DataLinkPropertiesDLG_PandID":
                    var DataLinkPropertiesDLG_PandID = new DataLinkPropertiesDLG_PandID();
                    DataLinkPropertiesDLG_PandID.SelectTab(1);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 1, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG_PandID.SelectTab(2);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 2, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG_PandID.SelectTab(3);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 3, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    DataLinkPropertiesDLG_PandID.SelectTab(4);
                    DlgBox_Engine.Current.giNbDialogChecked++;
                    if (!DlgBox_Engine.Current.TestDialog(wCurrentDialog, iCurrentTab, iTabsCount, 4, 4))
                    {
                        DlgBox_Engine.Current.giNbFailure++;
                    }
                    return true;
                default: // Dialog not tested
                    ResultLog.Current.Log("aaa + " + winName);
                    iCurrentShape = 1;
                    iShapesCount = 1;
                    //System.Threading.Thread.Sleep(10000);
                    return false;
            }
        }
    }
}
