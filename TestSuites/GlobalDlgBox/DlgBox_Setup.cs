using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTestSuite.CommonFiles.TestSuite.GlobalDlgBox;
using Autodesk.GUIHarness.Plant3D.Dialogs;

namespace Autodesk.GUIHarness.Plant3D.TestSuites.GlobalDlgBox
{

public class DlgBox_Setup : IDlgBox_Setup
    {
        // Test if the Text Fields accepts Extended (8bits/DoubleByte) characters ?
        public bool bExtCharTesting
        {
            get { return false; }
        }

        // Check only the bitmap
        public bool bCheckOnlyBitmap
        {
            get { return false; }
        }

        // lwAllDialogBoxList;

        //////////////////////////////////////////////////////
        // List of the dialogs to test on AutoCAD P3D
        //////////////////////////////////////////////////////
        List<dynamic> lwAllDialogBoxList = new List<dynamic>()
        {
            ////////////////Newcastle  New and Changed DIalgos /////////////////////
            new Plant3DProjectDrawingsContainExternalReferencesDLG (),
            //new EquipmentSaddleDLG (),
            //new EquipmentLegDLG (),
            //new ProjectSetupPipeBendSettingsDLG (),
            //new ProjectSetupPulledPipeBendDLG (),
            //new PIDPainterChooseAPropertyListDLG (),
            //new DeletePIDPainterStyleDLG (),
            //new ProjectSetupPIDPainterSettingsDLG (),
            //new  IsometricDWGSettingsDimensionsDLG(),
            //new  IsometricDWGSettingsAnnotationsDLG(),
            //new  ProjectSetupIsoDefaultSettingsDLG(),
            //new  ProjectSetupIsoThemesDLG(),
            //new  IsoSaveChangesDLG(),
            //new  IsometricDWGSettingsIsoStyleSetupMDLG(),
            //new  IsometricDWGSettingsIsoStyleSetupDLG(),
            //new  PlantCreateReportDLG(),
            //new  ExportResultsNewDLG(),
            //new  OrthoDWGSettingsTableSetupDLG(),
            //new  IsometricDWGSettingsAdvancedDefaultsDLG(),
            //new  OrthoGenerationSettingsDLG(),
            //new  CreateConnectionDLG(), //shared with PID
            //new  ProjectSetupTitleBlockandDisplayDLG(),
            //new  DrawingCheckerDLG(),
            //new  DrawingCheckerReviewDLG(),
            //new  OrthoCreationinProcessDLG(),
            //new  ReportValidationDLG(),
            //new  COGValidationDLG(),
            ////////////////////SpecEditor//////////////////////////////////
            //new  AddBoltStandardDLG(),
            //new  AddNotesToGroupDLG(),
            //new  AutoCADPlantDSpecEditorxBranchEditortabDLG(),
            //new  AutoCADPlantDSpecEditorxCatalogEditortabDLG(),
            //new  AutoCADPlantDSpecEditorxSpecEditortabDLG(),
            //new  AutoPLANTToDMappingClassMappingDLG(),
            //new  BatchAssignLongDescriptionStylesDLG(),
            //new  BoltLengthMappingDLG(),
            //new  BranchTableEditorBranchSizeUnavailableDLG(),
            //new  BranchTableSetupDLG(),
            //new  CADWorxDataTableFileDLG(),
            //new  CADWorxToPlantDMappingClassMappingDLG(),
            //new  CatalogPropertiesGeneralPropertiesDLG(),
            //new  CatalogPropertiesSizesAdvancedDLG(),
            //new  ConvertAutoPLANTSpecsAndCatalogsDLG(),
            //new  ConvertCADWorxSpecsDLG(),
            //new  ConvertCSVFilesDLG(),
            //new  CreateCatalogFromExistingCatalogDLG(),
            //new  CreateNewComponentDLG1(),
            //new  CreateSpecDLG(),
            //new  CreateSpecFromExistingSpecDLG1(),
            //new  CreateSpecFromExistingSpecDLG2(),
            //new  CsvToPlantDMappingClassMappingDLG(),
            //new  DuplicatePartfamilyDLG(),
            //new  EditLongDescriptionStyleDLG(),
            //new  ImportFailedTheExcelFileisnotexportedCatalogDataFileDLG(),
            //new  MessageBoxNoValueSelectedDLG(),
            //new  MigrateSpecsAndCatalogsDLG(),
            //new  ModifyCatalogPropertiesDLG(),
            //new  PleaseenterauniquenameDLG(),
            //new  PleaseenteravalidnameDLG(),
            //new  PrintPreviewapplicationDLG(),
            //new  ReminderConnectionPortCountshouldbefilledwithcorrectvalueDLG(),
            //new  ReminderLongDescriptionfilledwithcorrectvalueDLG(),
            //new  ReminderPleaseremembertoaddpartsizeDLG(),
            //new  ReminderPleaseremembertoselectonegraphicDLG(),
            //new  ResolveExcelImportChangesDLG(),
            //new  SaveAsCatalogBuilderExcelformatDLG(),
            //new  SelectBranchConnectionDLG(),
            //new  SelectBranchListDLG(),
            //new  SelectSpecsAndCatalogsDLG(),
            //new  SelectSpecsAndCatalogsToMigrateDLG(),
            //new  SelectSpecsandCatalogsDLG2(),
            //new  SpecAlreadyOpenAspecwiththisnameisalreadyopenDLG(),
            //new  SpecAndCatalogMigrationCompleteDLG(),
            //new  SpecAndCatalogMigrationRequireTaskDLG(),
            //new  SpecAndCatalogMigrationRequired1DLG(),
            //new  SpecAndCatalogMigrationRequired2DLG(),
            //new  SpecConversionReportDLG(),
            //new  SpecEditorBatchAssignlongDescriptionStylesCompletedDLG1(),
            //new  SpecEditorBatchAssignlongDescriptionStylesCompletedDLG2(),
            //new  SpecEditorDLG(),
            //new  SpecEditorEditValveOperatorsDLG(),
            //new  SpecEditorImportFailedDLG(),
            //new  SpecEditorLayoutAndSettingsDLG(),
            //new  SpecEditorLongDescriptionStyleDeletionDLG(),
            //new  SpecEditorValveOperatorShapeBrowserDLG(),
            //new  SpecFromExistingInvalidName(),
            //new  SpecUpdateNotificationCatalogpartshavechangedDLG1(),
            //new  SpecUpdateNotificationCatalogpartshavechangedDLG2(),
            //new  SpecUpdateNotificationNoUpdatesFoundDLG(),
            //new  SpecUpdateSynchronizationCompleteNotupdatedDLG(),
            //new  SpecUpdateSynchronizationCompleteUpdatedSpecsDLG(),
            //new  SpecUtilityBrowseForFolderDLG(),
            //new  SpecUtilityCatalogImportDLG(),
            //new  SpecUtilityCatalogPartsDLG(),
            //new  SpecUtilityEditpartsPartListDLG(),
            //new  SpecUtilityErrorDLG(),
            //new  SpecUtilityExportDataDLG(),
            //new  SpecUtilityExportDataDLG2(),
            //new  SpecUtilityExportToDLG(),
            //new  SpecUtilityImportFailedDLG(),
            //new  SpecUtilityImportFailedTheExcelnotexportedDLG(),
            //new  SpecUtilityImportFromDLG(),
            //new  SpecUtilityInvalidExistingFileDLG(),
            //new  SpecUtilityInvalidFileDLG(),
            //new  SpecUtilityInvalidNameDLG1(),
            //new  SpecUtilityInvalidNameDLG2(),
            //new  SpecUtilityInvalidPathDLG(),
            //new  SpecUtilityMissingExistingFileDLG(),
            //new  SpecUtilityOpenCatDLG(),
            //new  SpecUtilityOpenSpecDLG(),
            //new  SpecUtilityPartnameDLG(),
            //new  SpecUtilitySaveAsDLG(),
            //new  SpecUtilitySaveAsNewStyleDLG(),
            //new  SpecUtilitySaveChangesDLG(),
            //new  SpecUtilityWelcometoDLG(),
            //new  SpecandCatalogsConversionCompleteDLG(),
            //new  SpecandCatalogsEditorDLG(),
            //new  SupportingContentUnavailableDLG(),
            //new  ValveOperatorMappingDLG(),
            ///////////////////////END////////////////////////////////////////////////
            /////////////////////////CatlogBuilder//////////////////////
            //new  AdvancedDefaultSettingsDLG(),
            //new  AutoCADPlant3DCatalogBuildSettingsDLG(),
            //new  AutoCADPlant3DCatalogBuildTaskDLG(),
            //new  AutoCADPlant3DCatalogBuilderApplicationDLG(),
            //new  AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG(),
            //new  AutoCADPlant3DCatalogBuilderPartFamiliesDetailsNoGraphicsDLG(),
            //new  BlockInsideThisDWG(),
            //new  BuildCatalogSingleDLG(),
            //new  CatalogBuilderEditLongDescriptionStyleDLG(),
            //new  CatalogBuilderPartFamiliesExistTaskDLG(),
            //new  CatalogBuilderSaveAsExcelFileDLG(),
            //new  CreateCatalogTemplateDLG(),
            //new  CreateContentPackDLG(),
            //new  CustomScriptPathisinvalidDLG(),
            //new  IdenticalUnitsDLG(),
            //new  NoneBlockInsideThisDWGDLG(),
            //new  RemovePartFamilyDLG(),
            //new  Plant3DCatalogBuilderDLG(),
            //new  Plant3DCatalogBuilderSelectScriptFileDLG(),
            //new  SaveAsNewCatalogDLG(),
            //new  SaveCatalogTemplateAsDLG(),
            //new  SelectCatalogTemplateToEditDLG(),
            //new  SelectCatalogToAddIntoDLG(),
            //new  SelectDWGFileDLG(),
            //new  SelectExcelFilesToBuildCatDLG(),
            //new  SelectPreviewFileDLG(),
            //new  TemplateUnitConversionwasDoneTaskDLG(),
            //new  UnitConversionConfirmationTaskDLG(),
            /////////////////END/////////////////////////////////////////
            /////////ReportCreator/////////////////////////////////
            //new  ReportCreatorDLG(),
            //new  ReportCreatorSelectDrawingErrorDLG(),
            //new  ReportConfigurationDLG(),
            //new  NewReportConfigurationDLG(),
            //new  ValidationErrorsDLG(),
            //new  QueryConfigurationDLG(),
            //new  QueryResultDLG(),
            //new  ReportCreatorConfirmDeleteDLG(),
            //new  BrowseForFolderDLG(),
            //new  VariablesDLG(),
            //new  OpenReportCreatorProjectDLG(),
            //new  ReportConfigurationModifiedSaveChangesDLG(),
            //new  PDFExportOptionsDLG(),
            //new  PasswordSecurityDLG(),
            //new  ExportResultsDLG(),
            //new  ReportCreatorFileOverwriteDLG(),
            //new  HTMLExportOptionsDLG(),
            //new  MHTExportOptionsDLG(),
            //new  TextExportOptionsDLG(),
            //new  CSVExportOptionsDLG(),
            //new  XLSExportOptionsDLG(),
            //new  RTFExportOptionsDLG(),
            //new  ImageExportOptionsDLG(),
            //new  BrowseForReportFilesFolderDLG(),
            //new  RCBrowseForOutputDirFolderDLG(),
        };
        // ////////////////////////// DO NOT CHANGE SETTINGS BELOW /////////////////////

        // Enable the Harness watchdog
        public bool bUseKill = true;

        // Set the Harness watchdog timer
        public int iRecoverBatWaitTime = 5000;

        public List<dynamic> InitDlgList(string appWndName)
        {
            return lwAllDialogBoxList;
        }

    }


}
