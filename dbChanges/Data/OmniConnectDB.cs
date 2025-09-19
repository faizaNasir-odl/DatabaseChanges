using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using dbChanges.Models;

namespace dbChanges.Data;

public partial class OmniConnectDB : DbContext
{
    public OmniConnectDB()
    {
    }

    public OmniConnectDB(DbContextOptions<OmniConnectDB> options)
        : base(options)
    {
    }

    public virtual DbSet<AdfPipelineConfig> AdfPipelineConfigs { get; set; }

    public virtual DbSet<AdxDataType> AdxDataTypes { get; set; }

    public virtual DbSet<AdxIngestionConfig> AdxIngestionConfigs { get; set; }

    public virtual DbSet<AgentMessage> AgentMessages { get; set; }

    public virtual DbSet<AlarmEngineTime> AlarmEngineTimes { get; set; }

    public virtual DbSet<AlarmPriority> AlarmPriorities { get; set; }

    public virtual DbSet<AlarmRecipient> AlarmRecipients { get; set; }

    public virtual DbSet<AlarmRecipientM2m> AlarmRecipientM2ms { get; set; }

    public virtual DbSet<AlarmRunningHistory> AlarmRunningHistories { get; set; }

    public virtual DbSet<AlarmState> AlarmStates { get; set; }

    public virtual DbSet<AlarmStatesConfig> AlarmStatesConfigs { get; set; }

    public virtual DbSet<AlarmStatusAction> AlarmStatusActions { get; set; }

    public virtual DbSet<AlarmsExportsDataQualityCode> AlarmsExportsDataQualityCodes { get; set; }

    public virtual DbSet<AlarmsExportsDataStat> AlarmsExportsDataStats { get; set; }

    public virtual DbSet<AlarmsExportsDatum> AlarmsExportsData { get; set; }

    public virtual DbSet<AlarmsNotification> AlarmsNotifications { get; set; }

    public virtual DbSet<All427> All427s { get; set; }

    public virtual DbSet<AllAlarmFinal1> AllAlarmFinal1s { get; set; }

    public virtual DbSet<AllOtBlue> AllOtBlues { get; set; }

    public virtual DbSet<AllStatsFinal> AllStatsFinals { get; set; }

    public virtual DbSet<AllStatsFinal1> AllStatsFinal1s { get; set; }

    public virtual DbSet<AllStatsFinal3> AllStatsFinal3s { get; set; }

    public virtual DbSet<AllStatsFinal4> AllStatsFinal4s { get; set; }

    public virtual DbSet<AllStatsFinal5> AllStatsFinal5s { get; set; }

    public virtual DbSet<AllStatsFinal6> AllStatsFinal6s { get; set; }

    public virtual DbSet<AllTagsFinal2> AllTagsFinal2s { get; set; }

    public virtual DbSet<AnomalyDataSelection> AnomalyDataSelections { get; set; }

    public virtual DbSet<AnomalyDatum> AnomalyData { get; set; }

    public virtual DbSet<AnomalyDetectionGroup> AnomalyDetectionGroups { get; set; }

    public virtual DbSet<AnomalyDetectionGroupResult> AnomalyDetectionGroupResults { get; set; }

    public virtual DbSet<AnomalyDetectionGroupTag> AnomalyDetectionGroupTags { get; set; }

    public virtual DbSet<AnomalyDetectionMatrixTable> AnomalyDetectionMatrixTables { get; set; }

    public virtual DbSet<AnomalyDetectionTag> AnomalyDetectionTags { get; set; }

    public virtual DbSet<AnomalyDetectionTagGroup> AnomalyDetectionTagGroups { get; set; }

    public virtual DbSet<AnomalyDetectionTagResult> AnomalyDetectionTagResults { get; set; }

    public virtual DbSet<AnomalyTwinModel> AnomalyTwinModels { get; set; }

    public virtual DbSet<ApiConfig> ApiConfigs { get; set; }

    public virtual DbSet<ApiConfig1> ApiConfigs1 { get; set; }

    public virtual DbSet<ApiConnection> ApiConnections { get; set; }

    public virtual DbSet<ApiResponseLog> ApiResponseLogs { get; set; }

    public virtual DbSet<ApiTestingApiTestingNewSiteHierarchy297Area> ApiTestingApiTestingNewSiteHierarchy297Areas { get; set; }

    public virtual DbSet<ApiTestingApiTestingNewSiteHierarchy297Asset> ApiTestingApiTestingNewSiteHierarchy297Assets { get; set; }

    public virtual DbSet<ApiTestingApiTestingNewSiteHierarchy297CustomersSite> ApiTestingApiTestingNewSiteHierarchy297CustomersSites { get; set; }

    public virtual DbSet<ApiTestingApiTestingNewSiteHierarchy297Tag> ApiTestingApiTestingNewSiteHierarchy297Tags { get; set; }

    public virtual DbSet<ApxAssetsStatus> ApxAssetsStatuses { get; set; }

    public virtual DbSet<ApxHealthAlert> ApxHealthAlerts { get; set; }

    public virtual DbSet<ApxHealthAlertNotification> ApxHealthAlertNotifications { get; set; }

    public virtual DbSet<ApxHealthAlertTrend> ApxHealthAlertTrends { get; set; }

    public virtual DbSet<ApxHealthParameter> ApxHealthParameters { get; set; }

    public virtual DbSet<ApxHealthParameterValue> ApxHealthParameterValues { get; set; }

    public virtual DbSet<ApxHealthSelection> ApxHealthSelections { get; set; }

    public virtual DbSet<ApxHealthTagGroup> ApxHealthTagGroups { get; set; }

    public virtual DbSet<ApxHealthTagGroupStatus> ApxHealthTagGroupStatuses { get; set; }

    public virtual DbSet<ApxInsightTab> ApxInsightTabs { get; set; }

    public virtual DbSet<ApxParameter> ApxParameters { get; set; }

    public virtual DbSet<ApxParameterCategory> ApxParameterCategories { get; set; }

    public virtual DbSet<ApxParameterOutputMapping> ApxParameterOutputMappings { get; set; }

    public virtual DbSet<ApxStepsHeader> ApxStepsHeaders { get; set; }

    public virtual DbSet<ApxTemplateStep> ApxTemplateSteps { get; set; }

    public virtual DbSet<ApxTwinModel> ApxTwinModels { get; set; }

    public virtual DbSet<ApxWhatIfInput> ApxWhatIfInputs { get; set; }

    public virtual DbSet<AreaHierarchyExportsDatum> AreaHierarchyExportsData { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetArea> AssetAreas { get; set; }

    public virtual DbSet<AssetAssetAreaMToM> AssetAssetAreaMToMs { get; set; }

    public virtual DbSet<AssetCategory> AssetCategories { get; set; }

    public virtual DbSet<AssetHierarchyExportsDatum> AssetHierarchyExportsData { get; set; }

    public virtual DbSet<AssetLibrary> AssetLibraries { get; set; }

    public virtual DbSet<AssetLibraryHistory> AssetLibraryHistories { get; set; }

    public virtual DbSet<AssetProperty> AssetProperties { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<AutomationLog> AutomationLogs { get; set; }

    public virtual DbSet<AutomationLogsAlterSite> AutomationLogsAlterSites { get; set; }

    public virtual DbSet<AutomationLogsSitecreation> AutomationLogsSitecreations { get; set; }

    public virtual DbSet<AzureRegion> AzureRegions { get; set; }

    public virtual DbSet<AzureSqlDataType> AzureSqlDataTypes { get; set; }

    public virtual DbSet<BadUncertainAlarmsHistory> BadUncertainAlarmsHistories { get; set; }

    public virtual DbSet<BatchComputeWatooPullDatapullOtdata301> BatchComputeWatooPullDatapullOtdata301s { get; set; }

    public virtual DbSet<BatchComputeWatooPullMinutestesting310> BatchComputeWatooPullMinutestesting310s { get; set; }

    public virtual DbSet<BatchComputeWatooPullMondayTestingOttagdata305Area> BatchComputeWatooPullMondayTestingOttagdata305Areas { get; set; }

    public virtual DbSet<BatchComputeWatooPullMondayTestingOttagdata305Asset> BatchComputeWatooPullMondayTestingOttagdata305Assets { get; set; }

    public virtual DbSet<BatchComputeWatooPullMondayTestingOttagdata305CustomersSite> BatchComputeWatooPullMondayTestingOttagdata305CustomersSites { get; set; }

    public virtual DbSet<BatchComputeWatooPullMondayTestingOttagdata305Tag> BatchComputeWatooPullMondayTestingOttagdata305Tags { get; set; }

    public virtual DbSet<BatchComputeWatooPullOtFinal308> BatchComputeWatooPullOtFinal308s { get; set; }

    public virtual DbSet<BatchComputeWatooPullOtFinalTest309> BatchComputeWatooPullOtFinalTest309s { get; set; }

    public virtual DbSet<BatchComputeWatooPullOtTest306> BatchComputeWatooPullOtTest306s { get; set; }

    public virtual DbSet<BatchComputeWatooPullOtTestAgain307> BatchComputeWatooPullOtTestAgain307s { get; set; }

    public virtual DbSet<BatchComputeWatooPullOtTesting123311> BatchComputeWatooPullOtTesting123311s { get; set; }

    public virtual DbSet<BatchComputeWatooPullPostRelease2344> BatchComputeWatooPullPostRelease2344s { get; set; }

    public virtual DbSet<BatchComputeWatooPullTimertriggertesting358> BatchComputeWatooPullTimertriggertesting358s { get; set; }

    public virtual DbSet<BatchComputeWatooPullWattooPil300Area> BatchComputeWatooPullWattooPil300Areas { get; set; }

    public virtual DbSet<BatchComputeWatooPullWattooPil300Asset> BatchComputeWatooPullWattooPil300Assets { get; set; }

    public virtual DbSet<BatchComputeWatooPullWattooPil300CustomersSite> BatchComputeWatooPullWattooPil300CustomersSites { get; set; }

    public virtual DbSet<BatchComputeWatooPullWattooPil300Tag> BatchComputeWatooPullWattooPil300Tags { get; set; }

    public virtual DbSet<BatchJobHistory> BatchJobHistories { get; set; }

    public virtual DbSet<BatchJobQueryLanguage> BatchJobQueryLanguages { get; set; }

    public virtual DbSet<BatchJobTableColumn> BatchJobTableColumns { get; set; }

    public virtual DbSet<BatchJobTriggerType> BatchJobTriggerTypes { get; set; }

    public virtual DbSet<BatchJobsDefinition> BatchJobsDefinitions { get; set; }

    public virtual DbSet<BatchJobsGlobalVariable> BatchJobsGlobalVariables { get; set; }

    public virtual DbSet<BatchJobsScheduling> BatchJobsSchedulings { get; set; }

    public virtual DbSet<BatchStaticTable> BatchStaticTables { get; set; }

    public virtual DbSet<BatchStaticTableColumn> BatchStaticTableColumns { get; set; }

    public virtual DbSet<BatchUserFunction> BatchUserFunctions { get; set; }

    public virtual DbSet<BatchUserFunctionHistory> BatchUserFunctionHistories { get; set; }

    public virtual DbSet<BpmActivity> BpmActivities { get; set; }

    public virtual DbSet<BpmActivityDependency> BpmActivityDependencies { get; set; }

    public virtual DbSet<BpmActivityGlobalVar> BpmActivityGlobalVars { get; set; }

    public virtual DbSet<BpmActivityLevel> BpmActivityLevels { get; set; }

    public virtual DbSet<BpmJob> BpmJobs { get; set; }

    public virtual DbSet<BpmactivitiesHistory> BpmactivitiesHistories { get; set; }

    public virtual DbSet<BpmjobExecutionLog> BpmjobExecutionLogs { get; set; }

    public virtual DbSet<BpmjobTableColumn> BpmjobTableColumns { get; set; }

    public virtual DbSet<BpmjobsScheduling> BpmjobsSchedulings { get; set; }


    public virtual DbSet<BulkDeviceReplicationLog> BulkDeviceReplicationLogs { get; set; }

    public virtual DbSet<BulkDeviceReplicationLogDevice> BulkDeviceReplicationLogDevices { get; set; }

    public virtual DbSet<CalculatedTag> CalculatedTags { get; set; }

    public virtual DbSet<CalculatedTagTarget> CalculatedTagTargets { get; set; }

    public virtual DbSet<CalculatedTagTargetMonYear> CalculatedTagTargetMonYears { get; set; }

    public virtual DbSet<CalculatedTagTargetMonYearHistory> CalculatedTagTargetMonYearHistories { get; set; }

    public virtual DbSet<CalculatedTagTargetsHistory> CalculatedTagTargetsHistories { get; set; }

    public virtual DbSet<CalculatedTagsHistory> CalculatedTagsHistories { get; set; }

    public virtual DbSet<ChartType> ChartTypes { get; set; }

    public virtual DbSet<ChatMessage> ChatMessages { get; set; }

    public virtual DbSet<ChatThread> ChatThreads { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ConditionalCalculation> ConditionalCalculations { get; set; }

    public virtual DbSet<ConfigrationVersioning> ConfigrationVersionings { get; set; }

    public virtual DbSet<ConfigrationVersioningHistory> ConfigrationVersioningHistories { get; set; }

    public virtual DbSet<ConnectorFieldMapping> ConnectorFieldMappings { get; set; }

    public virtual DbSet<ControlSystemIntegratorProductM2m> ControlSystemIntegratorProductM2ms { get; set; }

    public virtual DbSet<ConversationHistory> ConversationHistories { get; set; }

    public virtual DbSet<CopyDataAlarmAction> CopyDataAlarmActions { get; set; }

    public virtual DbSet<CounterScheduledExportsData1> CounterScheduledExportsData1s { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CountryCode> CountryCodes { get; set; }

    public virtual DbSet<CsvImportStatus> CsvImportStatuses { get; set; }

    public virtual DbSet<CurveDatum> CurveData { get; set; }

    public virtual DbSet<CurveHeader> CurveHeaders { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Customtabletesting> Customtabletestings { get; set; }

    public virtual DbSet<DataAlarm> DataAlarms { get; set; }

    public virtual DbSet<DataAlarmAction> DataAlarmActions { get; set; }

    public virtual DbSet<DataAlarmActionHistory> DataAlarmActionHistories { get; set; }

    public virtual DbSet<DataAlarmState> DataAlarmStates { get; set; }

    public virtual DbSet<DataAlarmStatesConfig> DataAlarmStatesConfigs { get; set; }

    public virtual DbSet<DataPullTracker> DataPullTrackers { get; set; }

    public virtual DbSet<DependenciesMetrix> DependenciesMetrixes { get; set; }

    public virtual DbSet<DependenciesMetrixHistory> DependenciesMetrixHistories { get; set; }

    public virtual DbSet<DesignDatum> DesignData { get; set; }

    public virtual DbSet<DesignParameter> DesignParameters { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DeviceDlSetting> DeviceDlSettings { get; set; }

    public virtual DbSet<DeviceModbusSetting> DeviceModbusSettings { get; set; }

    public virtual DbSet<DeviceOpcServerM2m> DeviceOpcServerM2ms { get; set; }

    public virtual DbSet<DeviceOpcSetting> DeviceOpcSettings { get; set; }

    public virtual DbSet<DevicePlatform> DevicePlatforms { get; set; }

    public virtual DbSet<DeviceTimeStampIdmapping> DeviceTimeStampIdmappings { get; set; }

    public virtual DbSet<DeviceType> DeviceTypes { get; set; }

    public virtual DbSet<DevicesSitesM2m> DevicesSitesM2ms { get; set; }

    public virtual DbSet<Distributor> Distributors { get; set; }

    public virtual DbSet<DistributorProductM2m> DistributorProductM2ms { get; set; }

    public virtual DbSet<DummyTable> DummyTables { get; set; }

    public virtual DbSet<EdgeConfigurationTimeLine> EdgeConfigurationTimeLines { get; set; }

    public virtual DbSet<EdgeDevice> EdgeDevices { get; set; }

    public virtual DbSet<EnpAzureRelayConnectionDetail> EnpAzureRelayConnectionDetails { get; set; }

    public virtual DbSet<EnpConnectorApiUrl> EnpConnectorApiUrls { get; set; }

    public virtual DbSet<EnpConnectorConnector> EnpConnectorConnectors { get; set; }

    public virtual DbSet<EnpConnectorConnectorType> EnpConnectorConnectorTypes { get; set; }

    public virtual DbSet<EnpConnectorDatatypeAzureSql> EnpConnectorDatatypeAzureSqls { get; set; }

    public virtual DbSet<EnpConnectorDatatypeInterimService> EnpConnectorDatatypeInterimServices { get; set; }

    public virtual DbSet<EnpConnectorDatatypeSapHana> EnpConnectorDatatypeSapHanas { get; set; }

    public virtual DbSet<EnpConnectorDatatypeSapHanaAzureSql> EnpConnectorDatatypeSapHanaAzureSqls { get; set; }

    public virtual DbSet<EnpConnectorPipeline> EnpConnectorPipelines { get; set; }

    public virtual DbSet<EnpConnectorPipelineMapping> EnpConnectorPipelineMappings { get; set; }

    public virtual DbSet<EnpConnectorPipelineTrigger> EnpConnectorPipelineTriggers { get; set; }

    public virtual DbSet<EnpConnectorPipelineTriggerType> EnpConnectorPipelineTriggerTypes { get; set; }

    public virtual DbSet<EnpConnectorPipelineWriteBehaviour> EnpConnectorPipelineWriteBehaviours { get; set; }

    public virtual DbSet<EnpConnectorPipelineWriteOption> EnpConnectorPipelineWriteOptions { get; set; }

    public virtual DbSet<EnpConnectorRestApi> EnpConnectorRestApis { get; set; }

    public virtual DbSet<EnpConnectorSqlAutomation> EnpConnectorSqlAutomations { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventCategory> EventCategories { get; set; }

    public virtual DbSet<EventComponent> EventComponents { get; set; }

    public virtual DbSet<EventComponentLookup> EventComponentLookups { get; set; }

    public virtual DbSet<ExceptionLogging> ExceptionLoggings { get; set; }

    public virtual DbSet<Export5> Export5s { get; set; }

    public virtual DbSet<ExportJobExecutionLog> ExportJobExecutionLogs { get; set; }

    public virtual DbSet<ExportJobExecutionLog1> ExportJobExecutionLogs1 { get; set; }

    public virtual DbSet<ExportJobParameter> ExportJobParameters { get; set; }

    public virtual DbSet<ExportPipeLine> ExportPipeLines { get; set; }

    public virtual DbSet<ExportPointer> ExportPointers { get; set; }

    public virtual DbSet<ExportSiteLayOutStatus> ExportSiteLayOutStatuses { get; set; }

    public virtual DbSet<ExportToExcelStatus> ExportToExcelStatuses { get; set; }

    public virtual DbSet<ExportZamil> ExportZamils { get; set; }

    public virtual DbSet<ExportedKohinoor> ExportedKohinoors { get; set; }

    public virtual DbSet<ExportedTagDatum> ExportedTagData { get; set; }

    public virtual DbSet<ExportsScheduling> ExportsSchedulings { get; set; }

    public virtual DbSet<ExportsqldDatapointsQaRealTagOtTabletype> ExportsqldDatapointsQaRealTagOtTabletypes { get; set; }

    public virtual DbSet<FastAlarm> FastAlarms { get; set; }

    public virtual DbSet<FintechSiteShiftsConfiguration> FintechSiteShiftsConfigurations { get; set; }

    public virtual DbSet<FintechTankDelivery> FintechTankDeliveries { get; set; }

    public virtual DbSet<FintechTransactionstype> FintechTransactionstypes { get; set; }

    public virtual DbSet<FmLogin> FmLogins { get; set; }

    public virtual DbSet<FormatTable> FormatTables { get; set; }

    public virtual DbSet<FormulaDependenciesMetrix> FormulaDependenciesMetrixes { get; set; }

    public virtual DbSet<FormulaLibrary> FormulaLibraries { get; set; }

    public virtual DbSet<FormulaLibraryHistory> FormulaLibraryHistories { get; set; }

    public virtual DbSet<Hamconnection> Hamconnections { get; set; }

    public virtual DbSet<HamdataSource> HamdataSources { get; set; }

    public virtual DbSet<HamexecutionLog> HamexecutionLogs { get; set; }

    public virtual DbSet<HamtransformRule> HamtransformRules { get; set; }

    public virtual DbSet<HasanCustomersSite> HasanCustomersSites { get; set; }

    public virtual DbSet<HassanArea> HassanAreas { get; set; }

    public virtual DbSet<HassanAsset> HassanAssets { get; set; }

    public virtual DbSet<HassanTag> HassanTags { get; set; }

    public virtual DbSet<HierarchyExportsDatum> HierarchyExportsData { get; set; }

    public virtual DbSet<HubcoNelManual> HubcoNelManuals { get; set; }

    public virtual DbSet<ImportFile> ImportFiles { get; set; }

    public virtual DbSet<ImportFileStatus> ImportFileStatuses { get; set; }

    public virtual DbSet<IndustryType> IndustryTypes { get; set; }

    public virtual DbSet<IngestionStatus> IngestionStatuses { get; set; }

    public virtual DbSet<IotDeviceMetric> IotDeviceMetrics { get; set; }

    public virtual DbSet<ItTestingTab1> ItTestingTab1s { get; set; }

    public virtual DbSet<IttablesExportsDatum> IttablesExportsData { get; set; }

    public virtual DbSet<JobExecutionLog> JobExecutionLogs { get; set; }

    public virtual DbSet<KpiFormula> KpiFormulas { get; set; }

    public virtual DbSet<KpiFormulaVariableM2M> KpiFormulaVariableM2Ms { get; set; }

    public virtual DbSet<KpiSFormulaAttachment> KpiSFormulaAttachments { get; set; }

    public virtual DbSet<KpieIpTagsDatum> KpieIpTagsData { get; set; }

    public virtual DbSet<KpieIpTagsParameter> KpieIpTagsParameters { get; set; }

    public virtual DbSet<LogDetail> LogDetails { get; set; }

    public virtual DbSet<LogEvent> LogEvents { get; set; }

    public virtual DbSet<ManualFixPoint> ManualFixPoints { get; set; }

    public virtual DbSet<ManualFixPointsHistory> ManualFixPointsHistories { get; set; }

    public virtual DbSet<ModBusDeviceTagsImportStatus> ModBusDeviceTagsImportStatuses { get; set; }

    public virtual DbSet<ModelTrainingType> ModelTrainingTypes { get; set; }

    public virtual DbSet<Mtd> Mtds { get; set; }

    public virtual DbSet<None> Nones { get; set; }

    public virtual DbSet<NotificationCategory> NotificationCategories { get; set; }

    public virtual DbSet<NotificationComponent> NotificationComponents { get; set; }

    public virtual DbSet<NotificationEvent> NotificationEvents { get; set; }

    public virtual DbSet<NotificationEventsConfigM2m> NotificationEventsConfigM2ms { get; set; }

    public virtual DbSet<Nozzel> Nozzels { get; set; }

    public virtual DbSet<NtwManualEntryCount> NtwManualEntryCounts { get; set; }

    public virtual DbSet<NtwManualEntryExtra> NtwManualEntryExtras { get; set; }

    public virtual DbSet<NtwManualEntrySpecloss> NtwManualEntrySpeclosses { get; set; }

    public virtual DbSet<OdlProduct> OdlProducts { get; set; }

    public virtual DbSet<OmniAgentMessage> OmniAgentMessages { get; set; }

    public virtual DbSet<OmniAgentToolCall> OmniAgentToolCalls { get; set; }

    public virtual DbSet<OmniFintechSiteMapping> OmniFintechSiteMappings { get; set; }

    public virtual DbSet<OmniFintechTankMapping> OmniFintechTankMappings { get; set; }

    public virtual DbSet<OpcQualityCode> OpcQualityCodes { get; set; }

    public virtual DbSet<OpcQualityCodetType> OpcQualityCodetTypes { get; set; }

    public virtual DbSet<OpcQualityCodetTypesDataAlarmM2m> OpcQualityCodetTypesDataAlarmM2ms { get; set; }

    public virtual DbSet<OpcServerConfig> OpcServerConfigs { get; set; }

    public virtual DbSet<OpcSourceTag> OpcSourceTags { get; set; }

    public virtual DbSet<OpcSourceTagsCm> OpcSourceTagsCms { get; set; }

    public virtual DbSet<OpcSourceTagsDummy> OpcSourceTagsDummies { get; set; }

    public virtual DbSet<OpenAiconfigurationHistory> OpenAiconfigurationHistories { get; set; }

    public virtual DbSet<OpenAifileHistory> OpenAifileHistories { get; set; }

    public virtual DbSet<OtLongDataPattern> OtLongDataPatterns { get; set; }

    public virtual DbSet<OtLongDataTest12> OtLongDataTest12s { get; set; }

    public virtual DbSet<OtLongDatum> OtLongData { get; set; }

    public virtual DbSet<OtTimeTest> OtTimeTests { get; set; }

    public virtual DbSet<OtWidedata1> OtWidedata1s { get; set; }

    public virtual DbSet<OtWidedata2> OtWidedata2s { get; set; }

    public virtual DbSet<OtWidedata3> OtWidedata3s { get; set; }

    public virtual DbSet<OtWidedatum> OtWidedata { get; set; }

    public virtual DbSet<OutputTagDatum> OutputTagData { get; set; }

    public virtual DbSet<OutputTagParameter> OutputTagParameters { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PermissionCategory> PermissionCategories { get; set; }

    public virtual DbSet<PhysicalAssetProperty> PhysicalAssetProperties { get; set; }

    public virtual DbSet<PipeLineTag> PipeLineTags { get; set; }

    public virtual DbSet<PlantSite> PlantSites { get; set; }

    public virtual DbSet<PlantSiteEmailTracking> PlantSiteEmailTrackings { get; set; }

    public virtual DbSet<ProcessAlarm> ProcessAlarms { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Pump> Pumps { get; set; }

    public virtual DbSet<QualityManualEntryFibexDatum> QualityManualEntryFibexData { get; set; }

    public virtual DbSet<QualityManualEntryMoistureContentFilledValue> QualityManualEntryMoistureContentFilledValues { get; set; }

    public virtual DbSet<QualityManualEntryNtw> QualityManualEntryNtws { get; set; }

    public virtual DbSet<QualityManualNtwConstantValue> QualityManualNtwConstantValues { get; set; }

    public virtual DbSet<RawTagTarget> RawTagTargets { get; set; }

    public virtual DbSet<RawTagTargetMonYear> RawTagTargetMonYears { get; set; }

    public virtual DbSet<RawTagTargetMonYearHistory> RawTagTargetMonYearHistories { get; set; }

    public virtual DbSet<RawTagsTargetsHistory> RawTagsTargetsHistories { get; set; }

    public virtual DbSet<ReadApiLimiter> ReadApiLimiters { get; set; }

    public virtual DbSet<ReadApiLog> ReadApiLogs { get; set; }

    public virtual DbSet<ReadApiLogArchiveDailyCountTotal> ReadApiLogArchiveDailyCountTotals { get; set; }

    public virtual DbSet<ReadApiLogArchiveDailySizeTotal> ReadApiLogArchiveDailySizeTotals { get; set; }

    public virtual DbSet<ReadApiLogArchiveMinLimitBreach> ReadApiLogArchiveMinLimitBreaches { get; set; }

    public virtual DbSet<ReadApiUsageAggregate> ReadApiUsageAggregates { get; set; }

    public virtual DbSet<ReadApilimit> ReadApilimits { get; set; }

    public virtual DbSet<ReadapiPayload> ReadapiPayloads { get; set; }

    public virtual DbSet<RealRawPoint> RealRawPoints { get; set; }

    public virtual DbSet<Realstatstable> Realstatstables { get; set; }

    public virtual DbSet<RecipientGroup> RecipientGroups { get; set; }

    public virtual DbSet<RecipientGroupM2m> RecipientGroupM2ms { get; set; }

    public virtual DbSet<RecipientsGroup> RecipientsGroups { get; set; }

    public virtual DbSet<RecipientsInfo> RecipientsInfos { get; set; }

    public virtual DbSet<Reg30625BatchConnectorsBmpSiteExport265Numeric> Reg30625BatchConnectorsBmpSiteExport265Numerics { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<RestApicolumnMapping> RestApicolumnMappings { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermissionM2m> RolePermissionM2ms { get; set; }

    public virtual DbSet<SchPullExecutionLog3> SchPullExecutionLog3s { get; set; }

    public virtual DbSet<ScheduledExportsData1> ScheduledExportsData1s { get; set; }

    public virtual DbSet<ScheduledExportsData2> ScheduledExportsData2s { get; set; }

    public virtual DbSet<ScheduledExportsDatum> ScheduledExportsData { get; set; }

    public virtual DbSet<ScheduledPullExecutionLog> ScheduledPullExecutionLogs { get; set; }

    public virtual DbSet<SidefaultRegion> SidefaultRegions { get; set; }

    public virtual DbSet<SiteComponentConfiguration> SiteComponentConfigurations { get; set; }

    public virtual DbSet<SiteEventsM2m> SiteEventsM2ms { get; set; }

    public virtual DbSet<SiteHierarchyExportsDatum> SiteHierarchyExportsData { get; set; }

    public virtual DbSet<SiteOpcDefaultSetting> SiteOpcDefaultSettings { get; set; }

    public virtual DbSet<SiteRegionOne2m> SiteRegionOne2ms { get; set; }

    public virtual DbSet<SiteTestUsArea> SiteTestUsAreas { get; set; }

    public virtual DbSet<SiteTestUsAsset> SiteTestUsAssets { get; set; }

    public virtual DbSet<SiteTestUsCustomersSite> SiteTestUsCustomersSites { get; set; }

    public virtual DbSet<SiteTestUsTag> SiteTestUsTags { get; set; }

    public virtual DbSet<SourceTagImportStatus> SourceTagImportStatuses { get; set; }

    public virtual DbSet<SourceTagParameter> SourceTagParameters { get; set; }

    public virtual DbSet<SqlTestingExportToSqlPipilineDataAlarmMinute348Test> SqlTestingExportToSqlPipilineDataAlarmMinute348Tests { get; set; }

    public virtual DbSet<SqlTestingExportToSqlVerifySiteHeriarchy365Area> SqlTestingExportToSqlVerifySiteHeriarchy365Areas { get; set; }

    public virtual DbSet<SqlTestingExportToSqlVerifySiteHeriarchy365Asset> SqlTestingExportToSqlVerifySiteHeriarchy365Assets { get; set; }

    public virtual DbSet<SqlTestingExportToSqlVerifySiteHeriarchy365CustomersSite> SqlTestingExportToSqlVerifySiteHeriarchy365CustomersSites { get; set; }

    public virtual DbSet<SqlTestingExportToSqlVerifySiteHeriarchy365Tag> SqlTestingExportToSqlVerifySiteHeriarchy365Tags { get; set; }

    public virtual DbSet<SqlcolumnMapping> SqlcolumnMappings { get; set; }

    public virtual DbSet<StatTest11> StatTest11s { get; set; }

    public virtual DbSet<StatTest12> StatTest12s { get; set; }

    public virtual DbSet<SubscriptionTag> SubscriptionTags { get; set; }

    public virtual DbSet<SystemAlarmAction> SystemAlarmActions { get; set; }

    public virtual DbSet<SystemAlarmActionHistory> SystemAlarmActionHistories { get; set; }

    public virtual DbSet<SystemIntegrator> SystemIntegrators { get; set; }

    public virtual DbSet<TagGapAlarmsLog> TagGapAlarmsLogs { get; set; }

    public virtual DbSet<TagLakeLastUpdate> TagLakeLastUpdates { get; set; }

    public virtual DbSet<TagMap> TagMaps { get; set; }

    public virtual DbSet<TagType> TagTypes { get; set; }

    public virtual DbSet<TagsDataType> TagsDataTypes { get; set; }

    public virtual DbSet<Tank> Tanks { get; set; }

    public virtual DbSet<TankStatusLive> TankStatusLives { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblTankStatus> TblTankStatuses { get; set; }

    public virtual DbSet<TblTransaction> TblTransactions { get; set; }

    public virtual DbSet<TestApi> TestApis { get; set; }

    public virtual DbSet<TestingTankStatus> TestingTankStatuses { get; set; }

    public virtual DbSet<TimeBasedEntityAccess> TimeBasedEntityAccesses { get; set; }

    public virtual DbSet<TimerScheduledExportsData1> TimerScheduledExportsData1s { get; set; }

    public virtual DbSet<TobaccoWasteConstantValue> TobaccoWasteConstantValues { get; set; }

    public virtual DbSet<TobaccoWasteManualEntry> TobaccoWasteManualEntries { get; set; }

    public virtual DbSet<TrendingReport> TrendingReports { get; set; }

    public virtual DbSet<TrendingReportFilter> TrendingReportFilters { get; set; }

    public virtual DbSet<TrendingReportTag> TrendingReportTags { get; set; }

    public virtual DbSet<TrendingReportsShared> TrendingReportsShareds { get; set; }

    public virtual DbSet<TriggeredDataAlarm> TriggeredDataAlarms { get; set; }

    public virtual DbSet<UserActivityLogging> UserActivityLoggings { get; set; }

    public virtual DbSet<UserArea> UserAreas { get; set; }

    public virtual DbSet<UserAsset> UserAssets { get; set; }

    public virtual DbSet<UserControlSystemIntegratorM2m> UserControlSystemIntegratorM2ms { get; set; }

    public virtual DbSet<UserCustomerM2m> UserCustomerM2ms { get; set; }

    public virtual DbSet<UserDistributorM2m> UserDistributorM2ms { get; set; }

    public virtual DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

    public virtual DbSet<UserRoleM2m> UserRoleM2ms { get; set; }

    public virtual DbSet<UserSiteM2m> UserSiteM2ms { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<UserUserTypeM2m> UserUserTypeM2ms { get; set; }

    public virtual DbSet<Variable> Variables { get; set; }

    public virtual DbSet<ViewLostTree> ViewLostTrees { get; set; }

    public virtual DbSet<ViewTobaccoWasteDate> ViewTobaccoWasteDates { get; set; }

    public virtual DbSet<ViewUnaccountable> ViewUnaccountables { get; set; }

    public virtual DbSet<ViewWasteTree> ViewWasteTrees { get; set; }

    public virtual DbSet<WhatIfResult> WhatIfResults { get; set; }

    public virtual DbSet<WriteApiLog> WriteApiLogs { get; set; }

    public virtual DbSet<WriteApiLogArchiveDailyCountTotal> WriteApiLogArchiveDailyCountTotals { get; set; }

    public virtual DbSet<WriteApiLogArchiveDailyRecordTotal> WriteApiLogArchiveDailyRecordTotals { get; set; }

    public virtual DbSet<WriteApiLogArchiveDailySizeTotal> WriteApiLogArchiveDailySizeTotals { get; set; }

    public virtual DbSet<WriteApiTableConfiguration> WriteApiTableConfigurations { get; set; }

    public virtual DbSet<WriteBackLog> WriteBackLogs { get; set; }

    public virtual DbSet<WriteBackParam> WriteBackParams { get; set; }

    public virtual DbSet<WriteBackProperty> WriteBackProperties { get; set; }

    public virtual DbSet<ZamilAlarmsView> ZamilAlarmsViews { get; set; }

    public virtual DbSet<ZdtTestSyncNewstagingZdt254Numeric> ZdtTestSyncNewstagingZdt254Numerics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=oc-modernization-blue.database.windows.net; Database= ocm-staging; User Id=octopus; Password=avanceon@786;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdfPipelineConfig>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__ADF_Pipe__6E32B6A5C49CBB3A");

            entity.ToTable("ADF_Pipeline_Config");

            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.AdxClusterUri)
                .HasMaxLength(500)
                .HasColumnName("adx_cluster_uri");
            entity.Property(e => e.AdxDatabase)
                .HasMaxLength(200)
                .HasColumnName("adx_database");
            entity.Property(e => e.AdxTable)
                .HasMaxLength(200)
                .HasColumnName("adx_table");
            entity.Property(e => e.ColumnMapping).HasColumnName("column_mapping");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DfName)
                .HasMaxLength(100)
                .HasColumnName("df_name");
            entity.Property(e => e.PipelineName)
                .HasMaxLength(100)
                .HasColumnName("pipeline_name");
            entity.Property(e => e.RestBaseUrl)
                .HasMaxLength(500)
                .HasColumnName("rest_base_url");
            entity.Property(e => e.RestJsonPath)
                .HasMaxLength(200)
                .HasColumnName("rest_json_path");
            entity.Property(e => e.RestRelativeUrl)
                .HasMaxLength(500)
                .HasColumnName("rest_relative_url");
            entity.Property(e => e.RgName)
                .HasMaxLength(100)
                .HasColumnName("rg_name");
            entity.Property(e => e.SpClientId)
                .HasMaxLength(100)
                .HasColumnName("sp_client_id");
            entity.Property(e => e.SpClientSecret)
                .HasMaxLength(200)
                .HasColumnName("sp_client_secret");
            entity.Property(e => e.SubscriptionId)
                .HasMaxLength(100)
                .HasColumnName("subscription_id");
            entity.Property(e => e.TenantId)
                .HasMaxLength(100)
                .HasColumnName("tenant_id");
        });

        modelBuilder.Entity<AdxDataType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdxDataT__3214EC07A3486FCF");

            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<AdxIngestionConfig>(entity =>
        {
            entity.HasKey(e => e.ConfigId).HasName("PK__ADX_Inge__622D0495A9F90A90");

            entity.ToTable("ADX_Ingestion_Config");

            entity.Property(e => e.ConfigId).HasColumnName("Config_ID");
            entity.Property(e => e.IsLongFormat).HasColumnName("Is_Long_Format");
            entity.Property(e => e.SelectedColumns).HasColumnName("Selected_Columns");
            entity.Property(e => e.SiteName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Site_name");
            entity.Property(e => e.SourceTableName)
                .HasMaxLength(255)
                .HasColumnName("Source_Table_Name");
        });

        modelBuilder.Entity<AgentMessage>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PK__AgentMes__497F6CB44C856A05");

            entity.Property(e => e.Guid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("guid");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.MessageId)
                .HasMaxLength(100)
                .HasColumnName("message_id");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.ThreadId)
                .HasMaxLength(100)
                .HasColumnName("thread_id");
        });

        modelBuilder.Entity<AlarmEngineTime>(entity =>
        {
            entity.HasKey(e => e.AetId).HasName("PK__Alarm_En__103B5A9B46A0E16A");

            entity.ToTable("Alarm_Engine_Time");

            entity.Property(e => e.AetId).HasColumnName("AET_ID");
            entity.Property(e => e.ProcessTime).HasColumnType("datetime");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
        });

        modelBuilder.Entity<AlarmPriority>(entity =>
        {
            entity.HasKey(e => e.AlarmPriorityId).HasName("PK__ALARM_PR__3BEB414D8A0FCD3F");

            entity.ToTable("ALARM_PRIORITY");

            entity.Property(e => e.AlarmPriorityId).HasColumnName("AlarmPriority_ID");
            entity.Property(e => e.AlarmPriorityTitle)
                .HasMaxLength(200)
                .HasColumnName("AlarmPriority_Title");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PriorityType).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlarmRecipient>(entity =>
        {
            entity.HasKey(e => e.ArId).HasName("PK__ALARM_RE__003ED5D24CB73CEA");

            entity.ToTable("ALARM_RECIPIENT");

            entity.Property(e => e.ArId).HasColumnName("AR_ID");
            entity.Property(e => e.ContactNumber).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlarmRecipientM2m>(entity =>
        {
            entity.HasKey(e => e.ArmId).HasName("PK__ALARM_RE__AD65A7952EF9E00D");

            entity.ToTable("ALARM_RECIPIENT_M2M");

            entity.Property(e => e.ArmId).HasColumnName("ARM_ID");
            entity.Property(e => e.ArId).HasColumnName("AR_ID");
            entity.Property(e => e.AstId).HasColumnName("AST_ID");
            entity.Property(e => e.GrId).HasColumnName("GR_ID");
            entity.Property(e => e.IsSmsactive).HasColumnName("IsSMSActive");

            entity.HasOne(d => d.Ar).WithMany(p => p.AlarmRecipientM2ms)
                .HasForeignKey(d => d.ArId)
                .HasConstraintName("FK__ALARM_REC__AR_ID__062DE679");

            entity.HasOne(d => d.Ast).WithMany(p => p.AlarmRecipientM2ms)
                .HasForeignKey(d => d.AstId)
                .HasConstraintName("FK__ALARM_REC__AST_I__0539C240");

            entity.HasOne(d => d.Gr).WithMany(p => p.AlarmRecipientM2ms)
                .HasForeignKey(d => d.GrId)
                .HasConstraintName("FK__ALARM_REC__GR_ID__5A4F643B");
        });

        modelBuilder.Entity<AlarmRunningHistory>(entity =>
        {
            entity.ToTable("AlarmRunningHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LastProcessedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlarmState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__ALARM_ST__AF9338D7B6B81A72");

            entity.ToTable("ALARM_STATES");

            entity.Property(e => e.StateId).HasColumnName("State_ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.StateTitle)
                .HasMaxLength(200)
                .HasColumnName("State_Title");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlarmStatesConfig>(entity =>
        {
            entity.HasKey(e => e.AstId).HasName("PK__ALARM_ST__F9749478F4C7296A");

            entity.ToTable("ALARM_STATES_CONFIG");

            entity.Property(e => e.AstId).HasColumnName("AST_ID");
            entity.Property(e => e.AlarmPriorityId).HasColumnName("AlarmPriority_ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ProcessAlarmId).HasColumnName("ProcessAlarm_ID");
            entity.Property(e => e.StateId).HasColumnName("State_ID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AlarmPriority).WithMany(p => p.AlarmStatesConfigs)
                .HasForeignKey(d => d.AlarmPriorityId)
                .HasConstraintName("FK__ALARM_STA__Alarm__6A85CC04");

            entity.HasOne(d => d.ProcessAlarm).WithMany(p => p.AlarmStatesConfigs)
                .HasForeignKey(d => d.ProcessAlarmId)
                .HasConstraintName("FK__ALARM_STA__Proce__6991A7CB");

            entity.HasOne(d => d.State).WithMany(p => p.AlarmStatesConfigs)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK__ALARM_STA__State__5D2BD0E6");
        });

        modelBuilder.Entity<AlarmStatusAction>(entity =>
        {
            entity.HasKey(e => e.AsId).HasName("PK__AlarmSta__E871DE2FD67A92CB");

            entity.ToTable("AlarmStatus_Actions");

            entity.Property(e => e.AsId)
                .ValueGeneratedNever()
                .HasColumnName("AS_Id");
            entity.Property(e => e.AsTitle)
                .HasMaxLength(200)
                .HasColumnName("AS_Title");
        });

        modelBuilder.Entity<AlarmsExportsDataQualityCode>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AlarmPriority)
                .IsUnicode(false)
                .HasColumnName("Alarm_Priority");
            entity.Property(e => e.AlarmTime)
                .IsUnicode(false)
                .HasColumnName("Alarm_Time");
            entity.Property(e => e.LowerValue).IsUnicode(false);
            entity.Property(e => e.StateTitle)
                .IsUnicode(false)
                .HasColumnName("State_Title");
            entity.Property(e => e.Status).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TriggeredStateId).HasColumnName("Triggered_State_id");
            entity.Property(e => e.UpperValue).IsUnicode(false);
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<AlarmsExportsDataStat>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AlarmPriority)
                .IsUnicode(false)
                .HasColumnName("Alarm_Priority");
            entity.Property(e => e.AlarmTime)
                .IsUnicode(false)
                .HasColumnName("Alarm_Time");
            entity.Property(e => e.StateTitle)
                .IsUnicode(false)
                .HasColumnName("State_Title");
            entity.Property(e => e.Status).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TriggeredStateId).HasColumnName("Triggered_State_id");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<AlarmsExportsDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AlarmPriority)
                .IsUnicode(false)
                .HasColumnName("Alarm_Priority");
            entity.Property(e => e.AlarmTime)
                .IsUnicode(false)
                .HasColumnName("Alarm_Time");
            entity.Property(e => e.LowerValue).IsUnicode(false);
            entity.Property(e => e.StateTitle)
                .IsUnicode(false)
                .HasColumnName("State_Title");
            entity.Property(e => e.Status).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TriggeredStateId).HasColumnName("Triggered_State_id");
            entity.Property(e => e.UpperValue).IsUnicode(false);
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<AlarmsNotification>(entity =>
        {
            entity.HasKey(e => e.AnId).HasName("PK__ALARMS_N__6D7E8AE12BDCF92F");

            entity.ToTable("ALARMS_NOTIFICATION");

            entity.Property(e => e.AnId).HasColumnName("AN_ID");
            entity.Property(e => e.CurrentValue).HasColumnName("Current_Value");
            entity.Property(e => e.ProcessAlarmId).HasColumnName("ProcessAlarm_ID");
            entity.Property(e => e.ReadingTime)
                .HasColumnType("datetime")
                .HasColumnName("Reading_Time");
            entity.Property(e => e.StateId).HasColumnName("State_ID");

            entity.HasOne(d => d.ProcessAlarm).WithMany(p => p.AlarmsNotifications)
                .HasForeignKey(d => d.ProcessAlarmId)
                .HasConstraintName("FK__ALARMS_NO__Proce__703EA55A");
        });

        modelBuilder.Entity<All427>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_427");

            entity.Property(e => e.Avg)
                .IsUnicode(false)
                .HasColumnName("avg");
            entity.Property(e => e.Max)
                .IsUnicode(false)
                .HasColumnName("max");
            entity.Property(e => e.Min)
                .IsUnicode(false)
                .HasColumnName("min");
            entity.Property(e => e.Stdev)
                .IsUnicode(false)
                .HasColumnName("stdev");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.Variance)
                .IsUnicode(false)
                .HasColumnName("variance");
        });

        modelBuilder.Entity<AllAlarmFinal1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_alarm_final1");

            entity.Property(e => e.AlarmPriority)
                .IsUnicode(false)
                .HasColumnName("Alarm_Priority");
            entity.Property(e => e.AlarmTime)
                .IsUnicode(false)
                .HasColumnName("Alarm_Time");
            entity.Property(e => e.LowerValue).IsUnicode(false);
            entity.Property(e => e.StateTitle)
                .IsUnicode(false)
                .HasColumnName("State_Title");
            entity.Property(e => e.Status).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TriggeredStateId).HasColumnName("Triggered_State_id");
            entity.Property(e => e.UpperValue).IsUnicode(false);
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<AllOtBlue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_ot_blue");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<AllStatsFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_stats_final");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<AllStatsFinal1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_stats_final1");

            entity.Property(e => e.AvgValue)
                .IsUnicode(false)
                .HasColumnName("avg_Value");
            entity.Property(e => e.MaxValue)
                .IsUnicode(false)
                .HasColumnName("max_Value");
            entity.Property(e => e.MinValue)
                .IsUnicode(false)
                .HasColumnName("min_Value");
            entity.Property(e => e.StandardDeviation)
                .IsUnicode(false)
                .HasColumnName("Standard_Deviation");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.Variance).IsUnicode(false);
        });

        modelBuilder.Entity<AllStatsFinal3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_stats_final3");

            entity.Property(e => e.Avg)
                .IsUnicode(false)
                .HasColumnName("avg");
            entity.Property(e => e.Max)
                .IsUnicode(false)
                .HasColumnName("max");
            entity.Property(e => e.Min)
                .IsUnicode(false)
                .HasColumnName("min");
            entity.Property(e => e.Stdev)
                .IsUnicode(false)
                .HasColumnName("stdev");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.Variance)
                .IsUnicode(false)
                .HasColumnName("variance");
        });

        modelBuilder.Entity<AllStatsFinal4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_stats_final4");

            entity.Property(e => e.Avg)
                .IsUnicode(false)
                .HasColumnName("avg");
            entity.Property(e => e.Max)
                .IsUnicode(false)
                .HasColumnName("max");
            entity.Property(e => e.Min)
                .IsUnicode(false)
                .HasColumnName("min");
            entity.Property(e => e.Stdev)
                .IsUnicode(false)
                .HasColumnName("stdev");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.Variance)
                .IsUnicode(false)
                .HasColumnName("variance");
        });

        modelBuilder.Entity<AllStatsFinal5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_stats_final5");

            entity.Property(e => e.Avg)
                .IsUnicode(false)
                .HasColumnName("avg");
            entity.Property(e => e.Max)
                .IsUnicode(false)
                .HasColumnName("max");
            entity.Property(e => e.Min)
                .IsUnicode(false)
                .HasColumnName("min");
            entity.Property(e => e.Stdev)
                .IsUnicode(false)
                .HasColumnName("stdev");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.Variance)
                .IsUnicode(false)
                .HasColumnName("variance");
        });

        modelBuilder.Entity<AllStatsFinal6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_stats_final6");

            entity.Property(e => e.Avg)
                .IsUnicode(false)
                .HasColumnName("avg");
            entity.Property(e => e.Max)
                .IsUnicode(false)
                .HasColumnName("max");
            entity.Property(e => e.Min)
                .IsUnicode(false)
                .HasColumnName("min");
            entity.Property(e => e.Stdev)
                .IsUnicode(false)
                .HasColumnName("stdev");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.Variance)
                .IsUnicode(false)
                .HasColumnName("variance");
        });

        modelBuilder.Entity<AllTagsFinal2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("all_tags_final2");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<AnomalyDataSelection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC0781756C2E");

            entity.ToTable("AnomalyDataSelection");

            entity.Property(e => e.Timestamp).HasMaxLength(1500);
        });

        modelBuilder.Entity<AnomalyDatum>(entity =>
        {
            entity.HasKey(e => new { e.TimeStamp, e.TagName }).HasName("PK__AnomalyD__6CBF4DB25C092BC7");

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TagName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Actual).HasColumnName("actual");
            entity.Property(e => e.IsAnomaly).HasColumnName("is_anomaly");
            entity.Property(e => e.PersistenceRatio).HasColumnName("persistence_ratio");
            entity.Property(e => e.PersistentAnomaly).HasColumnName("persistent_anomaly");
            entity.Property(e => e.Site)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TagGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnomalyDetectionGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC07234B803A");

            entity.ToTable("AnomalyDetectionGroup");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GroupLeaderTagType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnomalyDetectionGroupResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC07E7FE4480");

            entity.ToTable("AnomalyDetectionGroupResult");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnomalyDetectionGroupTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC070416F05F");

            entity.ToTable("AnomalyDetectionGroupTag");

            entity.Property(e => e.TagType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnomalyDetectionMatrixTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC0710CFE911");

            entity.ToTable("AnomalyDetectionMatrixTable");

            entity.Property(e => e.DependentTagType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModelledTagType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnomalyDetectionTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC279DDFFF10");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagGroupId).HasColumnName("TagGroupID");
            entity.Property(e => e.TagName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.TagGroup).WithMany(p => p.AnomalyDetectionTags)
                .HasForeignKey(d => d.TagGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AnomalyDe__TagGr__2B803210");
        });

        modelBuilder.Entity<AnomalyDetectionTagGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC27A2C80D0D");

            entity.ToTable("AnomalyDetectionTagGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Customer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SiteName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TagGroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnomalyDetectionTagResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07CEB29EAB");

            entity.ToTable("AnomalyDetectionTagResult");

            entity.Property(e => e.IsOperating).HasColumnName("isOperating");
            entity.Property(e => e.MaeM1).HasColumnName("MAE_m1");
            entity.Property(e => e.MaeM2).HasColumnName("MAE_m2");
            entity.Property(e => e.MapeM1).HasColumnName("MAPE_m1");
            entity.Property(e => e.MapeM2).HasColumnName("MAPE_m2");
            entity.Property(e => e.NbCheck).HasColumnName("NB_check");
            entity.Property(e => e.Predictors).IsUnicode(false);
            entity.Property(e => e.R2ScoreM1).HasColumnName("R2_score_m1");
            entity.Property(e => e.R2ScoreM2).HasColumnName("R2_Score_m2");
            entity.Property(e => e.RampCheck).HasColumnName("ramp_check");
            entity.Property(e => e.RampPercentage).HasColumnName("ramp_percentage");
            entity.Property(e => e.RsqM1).HasColumnName("RSQ_m1");
            entity.Property(e => e.RsqM2).HasColumnName("RSQ_m2");
            entity.Property(e => e.StabilityScore).HasColumnName("stability_score");
            entity.Property(e => e.StdError).HasColumnName("std_error");
            entity.Property(e => e.TagType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnomalyTwinModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyT__3214EC07456AC14A");

            entity.ToTable("AnomalyTwinModel");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ResultJson).HasColumnName("ResultJSON");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApiConfig>(entity =>
        {
            entity.ToTable("API_Configs");

            entity.HasIndex(e => e.SiteId, "UQ__API_Conf__B22FDBCBA7D1768A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConsumerGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("consumer_group");
            entity.Property(e => e.IsCreated).HasColumnName("is_created");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
        });

        modelBuilder.Entity<ApiConfig1>(entity =>
        {
            entity.HasKey(e => e.ApiId).HasName("PK__ApiConfi__024B3BB3A64B9127");

            entity.ToTable("ApiConfig");

            entity.Property(e => e.ApiName).HasMaxLength(200);
            entity.Property(e => e.BaseUrl).HasMaxLength(500);
            entity.Property(e => e.ClientId).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Endpoint).HasMaxLength(500);
            entity.Property(e => e.HttpMethod).HasMaxLength(10);
            entity.Property(e => e.Scope).HasMaxLength(500);
            entity.Property(e => e.TokenEndpoint).HasMaxLength(500);
        });

        modelBuilder.Entity<ApiConnection>(entity =>
        {
            entity.HasKey(e => e.ApiConnectionId).HasName("PK__ApiConne__172C92CB5D8C5516");

            entity.Property(e => e.ApiName).HasMaxLength(100);
            entity.Property(e => e.AuthType).HasMaxLength(50);
            entity.Property(e => e.BaseUrl).HasMaxLength(500);
            entity.Property(e => e.ClientId).HasMaxLength(200);
            entity.Property(e => e.ClientSecret).HasMaxLength(500);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.JsonPath).HasMaxLength(500);
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.RequestMethod)
                .HasMaxLength(10)
                .HasDefaultValue("POST");
            entity.Property(e => e.ResponseFormat)
                .HasMaxLength(50)
                .HasDefaultValue("json");
            entity.Property(e => e.Scope).HasMaxLength(500);
            entity.Property(e => e.SiteId).HasMaxLength(200);
            entity.Property(e => e.SiteName).HasMaxLength(200);
            entity.Property(e => e.TenantId).HasMaxLength(200);
            entity.Property(e => e.TokenEndpoint).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.Username).HasMaxLength(200);
        });

        modelBuilder.Entity<ApiResponseLog>(entity =>
        {
            entity.HasKey(e => e.ResponseId).HasName("PK__ApiRespo__1AAA646C10C0B807");

            entity.ToTable("ApiResponseLog");

            entity.Property(e => e.LoggedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Api).WithMany(p => p.ApiResponseLogs)
                .HasForeignKey(d => d.ApiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ApiRespon__ApiId__2678227C");
        });

        modelBuilder.Entity<ApiTestingApiTestingNewSiteHierarchy297Area>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("API_Testing_API_Testing_New_site_hierarchy_297_Areas");

            entity.Property(e => e.AreaName).IsUnicode(false);
            entity.Property(e => e.CustomerSiteId).HasColumnName("CustomerSiteID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ApiTestingApiTestingNewSiteHierarchy297Asset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("API_Testing_API_Testing_New_site_hierarchy_297_Assets");

            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.AssetType).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParentAsset).IsUnicode(false);
        });

        modelBuilder.Entity<ApiTestingApiTestingNewSiteHierarchy297CustomersSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("API_Testing_API_Testing_New_site_hierarchy_297_Customers_Sites");

            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SiteName).IsUnicode(false);
        });

        modelBuilder.Entity<ApiTestingApiTestingNewSiteHierarchy297Tag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("API_Testing_API_Testing_New_site_hierarchy_297_Tags");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<ApxAssetsStatus>(entity =>
        {
            entity.ToTable("APxAssetsStatus");

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
        });

        modelBuilder.Entity<ApxHealthAlert>(entity =>
        {
            entity.ToTable("APxHealthAlerts");

            entity.Property(e => e.AlertAcknowledgedBy).HasMaxLength(50);
            entity.Property(e => e.AlertAcknowledgedOn).HasColumnType("datetime");
            entity.Property(e => e.AlertIgnoredBy).HasMaxLength(50);
            entity.Property(e => e.AlertIgnoredOn).HasColumnType("datetime");
            entity.Property(e => e.AnomalyEndOn).HasColumnType("datetime");
            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.LastNotifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterIdFK");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxHealthAlertNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__APxHealt__3214EC076C1C6025");

            entity.ToTable("APxHealthAlertNotification");
        });

        modelBuilder.Entity<ApxHealthAlertTrend>(entity =>
        {
            entity.ToTable("APxHealthAlertTrends");

            entity.HasIndex(e => new { e.AssetIdFk, e.ParameterIdFk }, "IX_APxHealthAlertTrends_Composite");

            entity.HasIndex(e => e.CreatedDate, "IX_APxHealthAlertTrends_CreatedDate").IsDescending();

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Jsondata).HasColumnName("JSONData");
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterIdFK");
        });

        modelBuilder.Entity<ApxHealthParameter>(entity =>
        {
            entity.ToTable("APxHealthParameters");

            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("AssetCategoryIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StepIdFk).HasColumnName("StepId_FK");
            entity.Property(e => e.TextType).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxHealthParameterValue>(entity =>
        {
            entity.ToTable("APxHealthParameterValues");

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.ConstValue).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterIdFK");
            entity.Property(e => e.TagDescription).HasMaxLength(250);
            entity.Property(e => e.TagType).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxHealthSelection>(entity =>
        {
            entity.ToTable("APxHealthSelection");

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.HasMode).HasColumnName("hasMode");
            entity.Property(e => e.HasSpike).HasColumnName("hasSpike");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.StepIdFk).HasColumnName("StepIdFK");
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxHealthTagGroup>(entity =>
        {
            entity.ToTable("APxHealthTagGroups");

            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("AssetCategoryIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Formula).HasMaxLength(200);
            entity.Property(e => e.FormulaCondition).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterIdFK");
            entity.Property(e => e.StepIdFk).HasColumnName("StepIdFK");
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxHealthTagGroupStatus>(entity =>
        {
            entity.ToTable("APxHealthTagGroupStatuses");

            entity.Property(e => e.ApxHealthGroupIdFk).HasColumnName("APxHealthGroupIdFK");
            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.OperatingTime).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TagJsondata).HasColumnName("TagJSONData");
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxInsightTab>(entity =>
        {
            entity.ToTable("APxInsightTabs");

            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("AssetCategoryId_FK");
            entity.Property(e => e.TabName).HasMaxLength(100);
        });

        modelBuilder.Entity<ApxParameter>(entity =>
        {
            entity.ToTable("APxParameters");

            entity.Property(e => e.ParameterCategoryIdFk).HasColumnName("ParameterCategoryId_FK");
            entity.Property(e => e.ParameterName).HasMaxLength(250);
        });

        modelBuilder.Entity<ApxParameterCategory>(entity =>
        {
            entity.ToTable("APxParameterCategories");

            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("AssetCategoryId_FK");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.InsightType).HasMaxLength(250);
            entity.Property(e => e.Section).HasMaxLength(250);
            entity.Property(e => e.StepName).HasMaxLength(250);
        });

        modelBuilder.Entity<ApxParameterOutputMapping>(entity =>
        {
            entity.ToTable("APxParameterOutputMapping");

            entity.Property(e => e.OutputTagParameterIdFk).HasColumnName("OutputTagParameterId_FK");
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterId_FK");
        });

        modelBuilder.Entity<ApxStepsHeader>(entity =>
        {
            entity.ToTable("APxStepsHeaders");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.HeaderName).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.StepIdFk).HasColumnName("StepId_FK");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ApxTemplateStep>(entity =>
        {
            entity.ToTable("APxTemplateSteps");

            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("AssetCategoryId_FK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.InsightType).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.StepName).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ApxTwinModel>(entity =>
        {
            entity.ToTable("APxTwinModel");

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsModelActivating).HasDefaultValue(false);
            entity.Property(e => e.ResultJson).HasColumnName("ResultJSON");
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxWhatIfInput>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WhatIf_InputData");

            entity.ToTable("APxWhatIf_Input");

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetId_Fk");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Section).HasMaxLength(100);
            entity.Property(e => e.WhatIfInputData).HasColumnName("WhatIf_InputData");
        });

        modelBuilder.Entity<AreaHierarchyExportsDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Area).IsUnicode(false);
            entity.Property(e => e.Asset).IsUnicode(false);
            entity.Property(e => e.AssetType)
                .IsUnicode(false)
                .HasColumnName("Asset_type");
            entity.Property(e => e.ParentAsset)
                .IsUnicode(false)
                .HasColumnName("Parent_Asset");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.Property(e => e.RoleId).HasMaxLength(450);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("trgAfterUpdateUser");
                    tb.HasTrigger("trgAfterUserCreation");
                });

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.AccessFailedCount).HasDefaultValue(0);
            entity.Property(e => e.ActivatedOn).HasColumnType("datetime");
            entity.Property(e => e.CellNumber).HasColumnName("Cell_Number");
            entity.Property(e => e.CreatedBy)
                .IsUnicode(false)
                .HasDefaultValue("OmniConnect");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrentLoggedInUserGuid)
                .HasMaxLength(128)
                .HasColumnName("CurrentLoggedInUserGUID");
            entity.Property(e => e.CustomerIdFk).HasColumnName("Customer_Id_FK");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.IsAaduser).HasColumnName("IsAADuser");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsSmsnotificationEnabled).HasColumnName("IsSMSNotificationEnabled");
            entity.Property(e => e.LastActivityStamp).HasColumnType("datetime");
            entity.Property(e => e.LastFaieldLogin).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.LastSuccessfulLogin).HasColumnType("datetime");
            entity.Property(e => e.LockoutEnabled).HasDefaultValue(true);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.LoginType).HasMaxLength(100);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.PhoneNumberConfirmed).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e.UserTypeIdFk)
                .HasDefaultValue(3)
                .HasColumnName("UserTypeId_Fk");

            entity.HasOne(d => d.CustomerIdFkNavigation).WithMany(p => p.AspNetUsers)
                .HasForeignKey(d => d.CustomerIdFk)
                .HasConstraintName("FK_AspNetUsers_Customer");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.Property(e => e.AssetId).HasColumnName("Asset_Id");
            entity.Property(e => e.ApxHealthStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APxHealthStatus");
            entity.Property(e => e.ApxPerformanceStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APxPerformanceStatus");
            entity.Property(e => e.AssetCategory).HasMaxLength(200);
            entity.Property(e => e.AssetName)
                .HasMaxLength(250)
                .HasColumnName("Asset_Name");
            entity.Property(e => e.AssetParentId).HasColumnName("Asset_Parent_Id");
            entity.Property(e => e.AssetType).HasMaxLength(200);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.HealthStatus).HasColumnName("Health_Status");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsApxHealthActivated)
                .HasDefaultValue(false)
                .HasColumnName("IsAPxHealthActivated");
            entity.Property(e => e.IsApxHealthActivating)
                .HasDefaultValue(false)
                .HasColumnName("IsAPxHealthActivating");
            entity.Property(e => e.IsKpiactivated)
                .HasDefaultValue(false)
                .HasColumnName("IsKPIActivated");
            entity.Property(e => e.IsKpiactivating)
                .HasDefaultValue(false)
                .HasColumnName("IsKPIActivating");
            entity.Property(e => e.LastServiceBy)
                .HasMaxLength(250)
                .HasColumnName("Last_Service_By");
            entity.Property(e => e.LastServiceDate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Service_Date");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.Type).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<AssetArea>(entity =>
        {
            entity.HasKey(e => e.AreaId);

            entity.ToTable("Asset_Area");

            entity.Property(e => e.AreaId).HasColumnName("Area_Id");
            entity.Property(e => e.AreaLocation).HasColumnName("Area_Location");
            entity.Property(e => e.AreaName)
                .HasMaxLength(250)
                .HasColumnName("Area_Name");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ParentId).HasColumnName("Parent_Id");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<AssetAssetAreaMToM>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Asset_Asset_Area_M_To_M_1");

            entity.ToTable("Asset_Asset_Area_M_To_M");

            entity.Property(e => e.AreaIdFk).HasColumnName("Area_Id_FK");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.AssetIdFkNavigation).WithMany(p => p.AssetAssetAreaMToMs)
                .HasForeignKey(d => d.AssetIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Asset_Asset_Area_M_To_M_Assets");
        });

        modelBuilder.Entity<AssetCategory>(entity =>
        {
            entity.HasKey(e => e.AcId).HasName("PK__ASSET_CA__BF5118282EFC0DC2");

            entity.ToTable("ASSET_CATEGORY");

            entity.Property(e => e.AcId).HasColumnName("AC_ID");
            entity.Property(e => e.AcDescription)
                .HasMaxLength(500)
                .HasColumnName("AC_Description");
            entity.Property(e => e.AcName)
                .HasMaxLength(250)
                .HasColumnName("AC_Name");
            entity.Property(e => e.AtId).HasColumnName("AT_ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsKpiconfigurable)
                .HasDefaultValue(false)
                .HasColumnName("IsKPIConfigurable");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.At).WithMany(p => p.AssetCategories)
                .HasForeignKey(d => d.AtId)
                .HasConstraintName("FK_ASSET_CATEGORY_ASSET_TYPE");
        });

        modelBuilder.Entity<AssetHierarchyExportsDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Area).IsUnicode(false);
            entity.Property(e => e.Asset).IsUnicode(false);
            entity.Property(e => e.AssetType)
                .IsUnicode(false)
                .HasColumnName("Asset_type");
            entity.Property(e => e.ParentAsset)
                .IsUnicode(false)
                .HasColumnName("Parent_Asset");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<AssetLibrary>(entity =>
        {
            entity.HasKey(e => e.AssetLibId);

            entity.ToTable("Asset_Library");

            entity.Property(e => e.AssetLibId)
                .ValueGeneratedNever()
                .HasColumnName("Asset_Lib_Id");
            entity.Property(e => e.AssetImage)
                .HasColumnType("image")
                .HasColumnName("Asset_Image");
            entity.Property(e => e.AssetName)
                .HasMaxLength(250)
                .HasColumnName("Asset_Name");
            entity.Property(e => e.AssetType)
                .HasMaxLength(250)
                .HasColumnName("Asset_Type");
        });

        modelBuilder.Entity<AssetLibraryHistory>(entity =>
        {
            entity.HasKey(e => e.AssetLibId);

            entity.ToTable("Asset_Library_History");

            entity.Property(e => e.AssetLibId)
                .ValueGeneratedNever()
                .HasColumnName("Asset_Lib_Id");
            entity.Property(e => e.AssetImage)
                .HasColumnType("image")
                .HasColumnName("Asset_Image");
            entity.Property(e => e.AssetName)
                .HasMaxLength(250)
                .HasColumnName("Asset_Name");
            entity.Property(e => e.AssetType)
                .HasMaxLength(250)
                .HasColumnName("Asset_Type");
            entity.Property(e => e.HistoryType)
                .HasMaxLength(250)
                .HasColumnName("History_Type");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Time_Stamp");
        });

        modelBuilder.Entity<AssetProperty>(entity =>
        {
            entity.HasKey(e => e.ApId);

            entity.ToTable("Asset_Property");

            entity.Property(e => e.ApId).HasColumnName("AP_id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_Fk");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PapIdFk).HasColumnName("PAP_Id_Fk");
            entity.Property(e => e.PapValue)
                .HasMaxLength(400)
                .HasColumnName("PAP_Value");

            entity.HasOne(d => d.AssetIdFkNavigation).WithMany(p => p.AssetProperties)
                .HasForeignKey(d => d.AssetIdFk)
                .HasConstraintName("FK_Asset_Property_Assets");

            entity.HasOne(d => d.PapIdFkNavigation).WithMany(p => p.AssetProperties)
                .HasForeignKey(d => d.PapIdFk)
                .HasConstraintName("FK_Asset_Property_Physical_Asset_Properties");
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.HasKey(e => e.AtId).HasName("PK__ASSET_TY__3033D60C7D39F262");

            entity.ToTable("ASSET_TYPE");

            entity.Property(e => e.AtId).HasColumnName("AT_ID");
            entity.Property(e => e.AtDescription)
                .HasMaxLength(500)
                .HasColumnName("AT_Description");
            entity.Property(e => e.AtName)
                .HasMaxLength(250)
                .HasColumnName("AT_Name");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.Property(e => e.Entity).HasMaxLength(200);
            entity.Property(e => e.LogEventIdFk).HasColumnName("LogEventId_FK");
            entity.Property(e => e.LoggedOn).HasColumnType("datetime");
            entity.Property(e => e.ObjectIdFk)
                .HasMaxLength(128)
                .HasColumnName("ObjectId_FK");
            entity.Property(e => e.SiidFk).HasColumnName("SIID_FK");
            entity.Property(e => e.UserIdFk)
                .HasMaxLength(128)
                .HasColumnName("UserId_FK");
        });

        modelBuilder.Entity<AutomationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Automati__3214EC27D7C925F3");

            entity.ToTable("Automation_Logs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Error).IsUnicode(false);
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("Execution_ID");
            entity.Property(e => e.ExecutionTime).HasColumnName("Execution_Time");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfExecution)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Type_of_execution");
        });

        modelBuilder.Entity<AutomationLogsAlterSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Automati__3214EC27EC503679");

            entity.ToTable("Automation_Logs_Alter_Site");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Error).IsUnicode(false);
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("Execution_ID");
            entity.Property(e => e.ExecutionTime).HasColumnName("Execution_Time");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfExecution)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Type_of_execution");
        });

        modelBuilder.Entity<AutomationLogsSitecreation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Automati__3214EC27CB44D1D4");

            entity.ToTable("Automation_Logs_Sitecreation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Error).IsUnicode(false);
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("Execution_ID");
            entity.Property(e => e.ExecutionTime).HasColumnName("Execution_Time");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfExecution)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Type_of_execution");
        });

        modelBuilder.Entity<AzureRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AzureReg__3214EC27C6EB4249");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClusterName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Cluster_Name");
            entity.Property(e => e.ClusterUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Cluster_URL");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).IsUnicode(false);
        });

        modelBuilder.Entity<AzureSqlDataType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AzureSql__3214EC0733CC09C3");

            entity.Property(e => e.TypeName).HasMaxLength(255);
        });

        modelBuilder.Entity<BadUncertainAlarmsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bad_Unce__3214EC271E7118C2");

            entity.ToTable("Bad_Uncertain_Alarms_History");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ReadingTime)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Reading_Time");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<BatchComputeWatooPullDatapullOtdata301>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_datapull_otdata_301");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullMinutestesting310>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_minutestesting_310");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullMondayTestingOttagdata305Area>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_Monday_testing_OTtagdata_305_Areas");

            entity.Property(e => e.AreaName).IsUnicode(false);
            entity.Property(e => e.CustomerSiteId).HasColumnName("CustomerSiteID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<BatchComputeWatooPullMondayTestingOttagdata305Asset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_Monday_testing_OTtagdata_305_Assets");

            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.AssetType).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParentAsset).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullMondayTestingOttagdata305CustomersSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_Monday_testing_OTtagdata_305_Customers_Sites");

            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SiteName).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullMondayTestingOttagdata305Tag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_Monday_testing_OTtagdata_305_Tags");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullOtFinal308>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_ot_final_308");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullOtFinalTest309>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_ot_final_test_309");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullOtTest306>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_ot_test_306");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullOtTestAgain307>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_ot_test_again_307");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullOtTesting123311>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_ot_testing123_311");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullPostRelease2344>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_post_release_2_344");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullTimertriggertesting358>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_timertriggertesting_358");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullWattooPil300Area>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_wattoo_pil_300_Areas");

            entity.Property(e => e.AreaName).IsUnicode(false);
            entity.Property(e => e.CustomerSiteId).HasColumnName("CustomerSiteID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<BatchComputeWatooPullWattooPil300Asset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_wattoo_pil_300_Assets");

            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.AssetType).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParentAsset).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullWattooPil300CustomersSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_wattoo_pil_300_Customers_Sites");

            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SiteName).IsUnicode(false);
        });

        modelBuilder.Entity<BatchComputeWatooPullWattooPil300Tag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batch_Compute__Watoo_Pull_wattoo_pil_300_Tags");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<BatchJobHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BatchJob__3214EC076962F35E");

            entity.ToTable("BatchJobHistory");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.JobVersion).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(255);

            entity.HasOne(d => d.BatchJob).WithMany(p => p.BatchJobHistories)
                .HasForeignKey(d => d.BatchJobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BatchJobH__Batch__0284DAC9");
        });

        modelBuilder.Entity<BatchJobQueryLanguage>(entity =>
        {
            entity.HasIndex(e => e.LanguageName, "UQ_LanguageName").IsUnique();

            entity.Property(e => e.LanguageName).HasMaxLength(100);
        });

        modelBuilder.Entity<BatchJobTableColumn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BatchJob__3214EC07F69B49E6");

            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.DataTypeNavigation).WithMany(p => p.BatchJobTableColumns)
                .HasForeignKey(d => d.DataType)
                .HasConstraintName("FK_BatchJobTableColumns_AdxDataTypes");

            entity.HasOne(d => d.Table).WithMany(p => p.BatchJobTableColumns)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchJobTableColumns_BatchJobsDefinition");
        });

        modelBuilder.Entity<BatchJobTriggerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BatchJob__3214EC079562095E");

            entity.HasIndex(e => e.TriggerTypeName, "UQ__BatchJob__6247D22471D5F113").IsUnique();

            entity.Property(e => e.TriggerTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BatchJobsDefinition>(entity =>
        {
            entity.ToTable("BatchJobsDefinition");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PublishedTableTime).HasColumnType("datetime");
            entity.Property(e => e.TableName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);

            entity.HasOne(d => d.Language).WithMany(p => p.BatchJobsDefinitions)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_BatchJobsDefinition_Language");
        });

        modelBuilder.Entity<BatchJobsGlobalVariable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BatchJob__3214EC07DCDE4FA2");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BatchJob).WithMany(p => p.BatchJobsGlobalVariables)
                .HasForeignKey(d => d.BatchJobId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BatchJobsGlobalVariables_BatchJobsDefinition");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.BatchJobsGlobalVariables)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchJobsGlobalVariables_AdxDataTypes");
        });

        modelBuilder.Entity<BatchJobsScheduling>(entity =>
        {
            entity.HasKey(e => e.TriggerId);

            entity.ToTable("BatchJobsScheduling");

            entity.Property(e => e.TriggerId).HasColumnName("Trigger_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.ExecuteNow).HasColumnName("Execute_Now");
            entity.Property(e => e.IsEnabled)
                .HasDefaultValue(true)
                .HasColumnName("Is_Enabled");
            entity.Property(e => e.JobId).HasColumnName("Job_Id");
            entity.Property(e => e.LastDayOfMonth).HasColumnName("Last_Day_Of_Month");
            entity.Property(e => e.LastRun)
                .HasColumnType("datetime")
                .HasColumnName("Last_Run");
            entity.Property(e => e.NextDue)
                .HasColumnType("datetime")
                .HasColumnName("Next_Due");
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Schedule_Type");
            entity.Property(e => e.ScheduleValue).HasColumnName("Schedule_Value");
            entity.Property(e => e.StartedOn)
                .HasColumnType("datetime")
                .HasColumnName("Started_On");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Trigger_Name");
            entity.Property(e => e.TriggerType).HasColumnName("Trigger_Type");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);

            entity.HasOne(d => d.Job).WithMany(p => p.BatchJobsSchedulings)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchJobsScheduling_BatchJobsDefinition");

            entity.HasOne(d => d.TriggerTypeNavigation).WithMany(p => p.BatchJobsSchedulings)
                .HasForeignKey(d => d.TriggerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchJobsScheduling_BatchJobTriggerTypes");
        });

        modelBuilder.Entity<BatchStaticTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BatchSta__3214EC07BA901E97");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<BatchStaticTableColumn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BatchSta__3214EC0717F52677");

            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.DataTypeNavigation).WithMany(p => p.BatchStaticTableColumns)
                .HasForeignKey(d => d.DataType)
                .HasConstraintName("FK_StaticTableColumns_AdxDataTypes");

            entity.HasOne(d => d.StaticTable).WithMany(p => p.BatchStaticTableColumns)
                .HasForeignKey(d => d.StaticTableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StaticTableColumns_StaticTable");
        });

        modelBuilder.Entity<BatchUserFunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Batch_Us__3214EC070ED39CD9");

            entity.ToTable("Batch_UserFunctions");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Language).WithMany(p => p.BatchUserFunctions)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_UserFunctions_Language");
        });

        modelBuilder.Entity<BatchUserFunctionHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BatchUserFunctionHistory");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<BpmActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BPM_Acti__482FBD6383648504");

            entity.ToTable("BPM_Activities");

            entity.Property(e => e.ActivityType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Published).HasDefaultValue(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.Validate).HasDefaultValue(false);

            entity.HasOne(d => d.Bpm).WithMany(p => p.BpmActivities)
                .HasForeignKey(d => d.BpmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BPM_Activ__bpm_i__526A1CA5");

            entity.HasOne(d => d.Language).WithMany(p => p.BpmActivities)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_BPM_Activities_Language");
        });

        modelBuilder.Entity<BpmActivityDependency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BPM_Acti__3214EC07D4DDAC01");

            entity.ToTable("BPM_Activity_Dependencies");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BpmActivityGlobalVar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BPM_Acti__3214EC070ABD820E");

            entity.ToTable("BPM_Activity_GlobalVar");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Bpm).WithMany(p => p.BpmActivityGlobalVars)
                .HasForeignKey(d => d.BpmId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BPM_GlobalVar_BPMJobs");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.BpmActivityGlobalVars)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BPM_GlobalVar_AdxDataTypes");
        });

        modelBuilder.Entity<BpmActivityLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BPM_Activity_Levels");
        });

        modelBuilder.Entity<BpmJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BPM_Jobs__181DF2FF65EBA7C4");

            entity.ToTable("BPM_Jobs");

            entity.Property(e => e.Bpmjson).HasColumnName("BPMJson");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BpmactivitiesHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BPMActiv__3214EC0726D09F75");

            entity.ToTable("BPMActivitiesHistory");

            entity.Property(e => e.ActivityType).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PublishedBy).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BpmjobExecutionLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__BPMJobEx__9E2397E0BB999033");

            entity.ToTable("BPMJobExecutionLogs");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.ExecutedAt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("executed_at");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TriggerId).HasColumnName("trigger_id");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("trigger_name");

            entity.HasOne(d => d.Trigger).WithMany(p => p.BpmjobExecutionLogs)
                .HasForeignKey(d => d.TriggerId)
                .HasConstraintName("FK_BPMJobExecutionLogs_JobScheduling");
        });

        modelBuilder.Entity<BpmjobTableColumn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BPMJobTa__3214EC0779D0C575");

            entity.ToTable("BPMJobTableColumns");

            entity.Property(e => e.Bpmid).HasColumnName("BPMId");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Bpm).WithMany(p => p.BpmjobTableColumns)
                .HasForeignKey(d => d.Bpmid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BPMJobTableColumns_BPM_Jobs");

            entity.HasOne(d => d.DataTypeNavigation).WithMany(p => p.BpmjobTableColumns)
                .HasForeignKey(d => d.DataType)
                .HasConstraintName("FK_BPMJobTableColumns_AdxDataTypes");
        });

        modelBuilder.Entity<BpmjobsScheduling>(entity =>
        {
            entity.HasKey(e => e.TriggerId);

            entity.ToTable("BPMJobsScheduling");

            entity.Property(e => e.TriggerId).HasColumnName("Trigger_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.ExecuteNow).HasColumnName("Execute_Now");
            entity.Property(e => e.IsEnabled)
                .HasDefaultValue(true)
                .HasColumnName("Is_Enabled");
            entity.Property(e => e.JobId).HasColumnName("Job_Id");
            entity.Property(e => e.LastDayOfMonth).HasColumnName("Last_Day_Of_Month");
            entity.Property(e => e.LastRun)
                .HasColumnType("datetime")
                .HasColumnName("Last_Run");
            entity.Property(e => e.NextDue)
                .HasColumnType("datetime")
                .HasColumnName("Next_Due");
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Schedule_Type");
            entity.Property(e => e.ScheduleValue).HasColumnName("Schedule_Value");
            entity.Property(e => e.StartedOn)
                .HasColumnType("datetime")
                .HasColumnName("Started_On");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Trigger_Name");
            entity.Property(e => e.TriggerType).HasColumnName("Trigger_Type");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);

            entity.HasOne(d => d.Job).WithMany(p => p.BpmjobsSchedulings)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BPMJobsScheduling_BPM_Jobs");

            entity.HasOne(d => d.TriggerTypeNavigation).WithMany(p => p.BpmjobsSchedulings)
                .HasForeignKey(d => d.TriggerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BPMJobsScheduling_BatchJobTriggerTypes");
        });


        modelBuilder.Entity<BulkDeviceReplicationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BulkDevi__3214EC07614705EF");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeviceNameConvention).HasMaxLength(255);
            entity.Property(e => e.DeviceType).HasMaxLength(10);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("In Progress");
            entity.Property(e => e.TagnameConvention).HasMaxLength(100);
        });

        modelBuilder.Entity<BulkDeviceReplicationLogDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BulkDevi__3214EC0740779B44");

            entity.Property(e => e.DeviceStatus)
                .HasMaxLength(20)
                .HasDefaultValue("In Progress");
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.Log).WithMany(p => p.BulkDeviceReplicationLogDevices)
                .HasForeignKey(d => d.LogId)
                .HasConstraintName("FK_BulkDeviceReplicationLogDevices_BulkDeviceReplicationLogs");
        });

        modelBuilder.Entity<CalculatedTag>(entity =>
        {
            entity.HasKey(e => e.CTagId);

            entity.ToTable("Calculated_Tags");

            entity.Property(e => e.CTagId).HasColumnName("C_Tag_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.Average).HasColumnName("AVERAGE");
            entity.Property(e => e.CTagName)
                .HasMaxLength(500)
                .HasColumnName("C_Tag_Name");
            entity.Property(e => e.CalculatedMappedName)
                .HasMaxLength(250)
                .HasColumnName("Calculated_Mapped_Name");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(500)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Deadband).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FlowRate).HasColumnName("Flow_Rate");
            entity.Property(e => e.IsCounterTag).HasDefaultValue(false);
            entity.Property(e => e.IsKpitag)
                .HasDefaultValue(false)
                .HasColumnName("IsKPITag");
            entity.Property(e => e.IsTimerTag).HasDefaultValue(false);
            entity.Property(e => e.IsTotalizer)
                .HasDefaultValue(false)
                .HasColumnName("Is_Totalizer");
            entity.Property(e => e.MappedFormula).HasColumnName("Mapped_Formula");
            entity.Property(e => e.OutputType).HasMaxLength(100);
            entity.Property(e => e.Roc).HasColumnName("ROC");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.Stdev).HasColumnName("STDEV");
            entity.Property(e => e.TotalizerReferenceId).HasColumnName("Totalizer_Reference_Id");
            entity.Property(e => e.Unit).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(500)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
            entity.Property(e => e.Variation).HasColumnName("VARIATION");

            entity.HasOne(d => d.AssetIdFkNavigation).WithMany(p => p.CalculatedTags)
                .HasForeignKey(d => d.AssetIdFk)
                .HasConstraintName("FK_Calculated_Tags_Assets");
        });

        modelBuilder.Entity<CalculatedTagTarget>(entity =>
        {
            entity.HasKey(e => e.TagTargetId).HasName("PK_Tag_Targets");

            entity.ToTable("Calculated_Tag_Targets");

            entity.Property(e => e.TagTargetId).HasColumnName("Tag_Target_Id");
            entity.Property(e => e.CTagIdFk).HasColumnName("C_Tag_Id_FK");
            entity.Property(e => e.CalculatedTargetMapped).HasMaxLength(50);
            entity.Property(e => e.CalculatedTargetMaxMapped).HasMaxLength(50);
            entity.Property(e => e.CalculatedTargetMinMapped).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MaximumTarget).HasColumnName("Maximum_Target");
            entity.Property(e => e.MinimumTarget).HasColumnName("Minimum_Target");
            entity.Property(e => e.TargetValue).HasColumnName("Target_Value");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");

            entity.HasOne(d => d.CTagIdFkNavigation).WithMany(p => p.CalculatedTagTargets)
                .HasForeignKey(d => d.CTagIdFk)
                .HasConstraintName("FK_Tag_Targets_Calculated_Tags");
        });

        modelBuilder.Entity<CalculatedTagTargetMonYear>(entity =>
        {
            entity.ToTable("Calculated_Tag_Target_Mon_Year");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CTagIdFk).HasColumnName("C_Tag_Id_FK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");

            entity.HasOne(d => d.CTagIdFkNavigation).WithMany(p => p.CalculatedTagTargetMonYears)
                .HasForeignKey(d => d.CTagIdFk)
                .HasConstraintName("FK_Calculated_Tag_Target_Mon_Year_Calculated_Tags");
        });

        modelBuilder.Entity<CalculatedTagTargetMonYearHistory>(entity =>
        {
            entity.ToTable("Calculated_Tag_Target_Mon_Year_History");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CTagIdFk).HasColumnName("C_Tag_Id_FK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.HistoryType)
                .HasMaxLength(500)
                .HasColumnName("History_Type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");
        });

        modelBuilder.Entity<CalculatedTagTargetsHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_Calculated_Tag_Targets_History_1");

            entity.ToTable("Calculated_Tag_Targets_History");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.CTagIdFk)
                .HasMaxLength(500)
                .HasColumnName("C_Tag_Id_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.HistoryType)
                .HasMaxLength(500)
                .HasColumnName("History_Type");
            entity.Property(e => e.MaximumTarget).HasColumnName("Maximum_Target");
            entity.Property(e => e.MinimumTarget).HasColumnName("Minimum_Target");
            entity.Property(e => e.TagTargetId).HasColumnName("Tag_Target_Id");
            entity.Property(e => e.TargetValue).HasColumnName("Target_Value");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Time_Stamp");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<CalculatedTagsHistory>(entity =>
        {
            entity.HasKey(e => e.CTagId);

            entity.ToTable("Calculated_Tags_History");

            entity.Property(e => e.CTagId).HasColumnName("C_Tag_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.CTagName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("C_Tag_Name");
            entity.Property(e => e.CalculatedMappedId)
                .HasMaxLength(250)
                .HasColumnName("Calculated_Mapped_Id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(500)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Formula)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.HistoryType)
                .HasMaxLength(500)
                .HasColumnName("History_Type");
            entity.Property(e => e.IsTotalizer)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Is_Totalizer");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Time_Stamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(500)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ChartType>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ChatMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07DD62E304");

            entity.Property(e => e.ChatThreadId).HasMaxLength(100);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.Gptmodel)
                .HasMaxLength(50)
                .HasColumnName("GPTModel");
            entity.Property(e => e.InputTokensCost).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.OutputTokensCost).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.TotalMessageCost).HasColumnType("decimal(20, 10)");

            entity.HasOne(d => d.ChatThread).WithMany(p => p.ChatMessages)
                .HasPrincipalKey(p => p.OpenAithreadId)
                .HasForeignKey(d => d.ChatThreadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChatMessages_ChatThreads");
        });

        modelBuilder.Entity<ChatThread>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0796C1A767");

            entity.HasIndex(e => e.OpenAithreadId, "UQ__tmp_ms_x__EA89CEDBCE5B7A59").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastMessageAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.OpenAithreadId)
                .HasMaxLength(100)
                .HasColumnName("OpenAIThreadId");
            entity.Property(e => e.UserId).HasMaxLength(450);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__F2D21A9616A374C5");

            entity.ToTable("City");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RegionidFk).HasColumnName("Regionid_Fk");
        });

        modelBuilder.Entity<ConditionalCalculation>(entity =>
        {
            entity.ToTable("Conditional_Calculation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CalTagIdFk).HasColumnName("CalTagId_FK");
            entity.Property(e => e.ConditionFormula).HasColumnName("Condition_Formula");
            entity.Property(e => e.ConditionMappedFormula).HasColumnName("Condition_Mapped_Formula");
            entity.Property(e => e.ConditionSequence).HasColumnName("Condition_Sequence");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(500)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.FalseFormula).HasColumnName("False_Formula");
            entity.Property(e => e.FalseMappedFormula).HasColumnName("False_Mapped_Formula");
            entity.Property(e => e.ParentConditionId).HasColumnName("Parent_Condition_Id");
            entity.Property(e => e.StopConditionFormula).HasColumnName("Stop_Condition_Formula");
            entity.Property(e => e.StopConditionMappedFormula).HasColumnName("Stop_Condition_Mapped_Formula");
            entity.Property(e => e.TrueFormula).HasColumnName("True_Formula");
            entity.Property(e => e.TrueMappedFormula).HasColumnName("True_Mapped_Formula");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(500)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");

            entity.HasOne(d => d.CalTagIdFkNavigation).WithMany(p => p.ConditionalCalculations)
                .HasForeignKey(d => d.CalTagIdFk)
                .HasConstraintName("FK_CalTagId");
        });

        modelBuilder.Entity<ConfigrationVersioning>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("Configration_Versioning");

            entity.Property(e => e.ConfigId).HasColumnName("Config_Id");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.CustomerIdFk).HasColumnName("Customer_Id_FK");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
            entity.Property(e => e.VersionEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Version_End_Date");
            entity.Property(e => e.VersionNum).HasColumnName("Version_Num");
            entity.Property(e => e.VersionStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Version_Start_Date");

            entity.HasOne(d => d.CustomerIdFkNavigation).WithMany(p => p.ConfigrationVersionings)
                .HasForeignKey(d => d.CustomerIdFk)
                .HasConstraintName("FK_Configration_Versioning_Customer");
        });

        modelBuilder.Entity<ConfigrationVersioningHistory>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("Configration_Versioning_History");

            entity.Property(e => e.ConfigId)
                .ValueGeneratedNever()
                .HasColumnName("Config_Id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Created_Date");
            entity.Property(e => e.CustomerIdFk).HasColumnName("Customer_Id_FK");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.HistoryType)
                .HasMaxLength(500)
                .HasColumnName("History_Type");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Time_Stamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Updated_Date");
            entity.Property(e => e.VersionEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Version_End_Date");
            entity.Property(e => e.VersionNum).HasColumnName("Version_Num");
            entity.Property(e => e.VersionStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Version_Start_Date");
        });

        modelBuilder.Entity<ConnectorFieldMapping>(entity =>
        {
            entity.HasKey(e => e.MappingId).HasName("PK__Connecto__8B57819D9E408D0A");

            entity.ToTable("ConnectorFieldMapping");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.SourceField).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(sysdatetime())");
        });

        modelBuilder.Entity<ControlSystemIntegratorProductM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ControlS__3214EC273826B218");

            entity.ToTable("ControlSystemIntegratorProductM2M");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedByUser).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Csiid).HasColumnName("CSIId");
            entity.Property(e => e.UpdatedByUser).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Csi).WithMany(p => p.ControlSystemIntegratorProductM2ms)
                .HasForeignKey(d => d.Csiid)
                .HasConstraintName("FK_ControlSystemIntegratorProductM2M_System_Integrator");

            entity.HasOne(d => d.Product).WithMany(p => p.ControlSystemIntegratorProductM2ms)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ControlSystemIntegratorProductM2M_ODL_Product");
        });

        modelBuilder.Entity<ConversationHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__conversa__3213E83FFE34B329");

            entity.ToTable("conversation_history");

            entity.HasIndex(e => e.ConversationId, "IX_conversation_history_conversation_id");

            entity.HasIndex(e => new { e.ConversationId, e.StepNumber }, "IX_conversation_history_step_number");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.ConversationId)
                .HasMaxLength(255)
                .HasColumnName("conversation_id");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
            entity.Property(e => e.StepNumber).HasColumnName("step_number");
            entity.Property(e => e.StepType)
                .HasMaxLength(50)
                .HasColumnName("step_type");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<CopyDataAlarmAction>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("COPY_PK__DATA_ALA__5D853E1A0C706C36");

            entity.ToTable("COPY_DATA_ALARM_ACTION");

            entity.Property(e => e.DatId).HasColumnName("DAT_ID");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionPerformedBy).HasMaxLength(128);
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AsId).HasColumnName("AS_Id");
            entity.Property(e => e.AstId).HasColumnName("AST_ID");
            entity.Property(e => e.CurrentValue).HasColumnName("Current_Value");
            entity.Property(e => e.DataAlarmActionGuid)
                .HasMaxLength(128)
                .HasColumnName("DataAlarmActionGUID");
            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ReadingTime)
                .HasColumnType("datetime")
                .HasColumnName("Reading_Time");
            entity.Property(e => e.StateId).HasColumnName("State_ID");
        });

        modelBuilder.Entity<CounterScheduledExportsData1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounterScheduledExportsData1");

            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CountryCode>(entity =>
        {
            entity.HasKey(e => e.CodeId).HasName("PK__CountryC__C6DE2C15EA659A49");

            entity.ToTable("CountryCode");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CsvImportStatus>(entity =>
        {
            entity.ToTable("Csv_Import_Status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlockList)
                .HasColumnType("text")
                .HasColumnName("block_list");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("file_name");
            entity.Property(e => e.ImportBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("import_by");
            entity.Property(e => e.IngestedUrl)
                .HasMaxLength(2083)
                .HasColumnName("ingested_url");
            entity.Property(e => e.IsIngested).HasColumnName("is_ingested");
            entity.Property(e => e.LastBlockId).HasColumnName("last_block_Id");
            entity.Property(e => e.ProgressStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("progress_status");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.TotalBlock).HasColumnName("total_block");
            entity.Property(e => e.UploadedBlock).HasColumnName("uploaded_block");
            entity.Property(e => e.UploadedBytes).HasColumnName("uploaded_bytes");
            entity.Property(e => e.UserId)
                .IsUnicode(false)
                .HasColumnName("userId");
        });

        modelBuilder.Entity<CurveDatum>(entity =>
        {
            entity.HasKey(e => e.CurveId);

            entity.ToTable("Curve_Data");

            entity.Property(e => e.CurveId).HasColumnName("Curve_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.CurveHeaderIdFk).HasColumnName("Curve_Header_Id_FK");
            entity.Property(e => e.CurveValue)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("Curve_Value");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.RowNo).HasColumnName("Row_No");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<CurveHeader>(entity =>
        {
            entity.ToTable("Curve_Headers");

            entity.Property(e => e.CurveHeaderId).HasColumnName("Curve_Header_Id");
            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("Asset_CategoryId_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.CurveHeaderName).HasColumnName("Curve_Header_Name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.Unit).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CellNumber)
                .HasMaxLength(50)
                .HasColumnName("Cell_Number");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreatdDate)
                .HasColumnType("datetime")
                .HasColumnName("Creatd_Date");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CsiFk).HasColumnName("CSI_Fk");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.LogoImage).HasColumnName("Logo_Image");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("Phone_Number");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");

            entity.HasOne(d => d.CsiFkNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CsiFk)
                .HasConstraintName("FK_Customer_System_Integrator");
        });

        modelBuilder.Entity<Customtabletesting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("customtabletesting");

            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.InstanceId)
                .IsUnicode(false)
                .HasColumnName("Instance_Id");
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal).HasColumnName("True_val");
        });

        modelBuilder.Entity<DataAlarm>(entity =>
        {
            entity.HasKey(e => e.DataAlarmId).HasName("PK__DATA_ALA__F96AC127D41C6334");

            entity.ToTable("DATA_ALARM");

            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.AExpirationTime)
                .HasColumnType("datetime")
                .HasColumnName("A_ExpirationTime");
            entity.Property(e => e.AStartTime)
                .HasColumnType("datetime")
                .HasColumnName("A_StartTime");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.CTagId).HasColumnName("C_Tag_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataAlarmName)
                .HasMaxLength(200)
                .HasColumnName("DataAlarm_Name");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDataAlarmOn).HasColumnName("isDataAlarmOn");
            entity.Property(e => e.IsStatAlarmOn).HasColumnName("isStatAlarmOn");
            entity.Property(e => e.RealTagId).HasColumnName("Real_Tag_Id");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CTag).WithMany(p => p.DataAlarms)
                .HasForeignKey(d => d.CTagId)
                .HasConstraintName("FK_DATA_ALARM_Calculated_Tags");

            entity.HasOne(d => d.RealTag).WithMany(p => p.DataAlarms)
                .HasForeignKey(d => d.RealTagId)
                .HasConstraintName("FK_DATA_ALARM_Real_Raw_Points");
        });

        modelBuilder.Entity<DataAlarmAction>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("PK__DataAlar__5D853E1A94E9BC69");

            entity.ToTable("DataAlarmAction");

            entity.Property(e => e.DatId)
                .ValueGeneratedNever()
                .HasColumnName("DAT_ID");
            entity.Property(e => e.AstIdFk).HasColumnName("AST_ID_FK");
            entity.Property(e => e.DataAlarmIdFk).HasColumnName("DataAlarm_ID_FK");
            entity.Property(e => e.ReadingTime)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.AstIdFkNavigation).WithMany(p => p.DataAlarmActions)
                .HasForeignKey(d => d.AstIdFk)
                .HasConstraintName("FK__DataAlarm__AST_I__763775D2");

            entity.HasOne(d => d.DataAlarmIdFkNavigation).WithMany(p => p.DataAlarmActions)
                .HasForeignKey(d => d.DataAlarmIdFk)
                .HasConstraintName("FK__DataAlarm__DataA__75435199");
        });

        modelBuilder.Entity<DataAlarmActionHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DATA_ALA__3214EC27DEF495B7");

            entity.ToTable("DATA_ALARM_ACTION_HISTORY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AsId).HasColumnName("AS_Id");
            entity.Property(e => e.DatId).HasColumnName("DAT_ID");
            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.StateId).HasColumnName("State_ID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DataAlarmState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__DATA_ALA__AF9338D73644AC38");

            entity.ToTable("DATA_ALARM_STATES");

            entity.Property(e => e.StateId).HasColumnName("State_ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.StateTitle)
                .HasMaxLength(200)
                .HasColumnName("State_Title");
            entity.Property(e => e.StateType).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DataAlarmStatesConfig>(entity =>
        {
            entity.HasKey(e => e.AstId).HasName("PK__dATA_ALA__F974947821766E91");

            entity.ToTable("DATA_ALARM_STATES_CONFIG");

            entity.HasIndex(e => e.AsId, "nci_wi_DATA_ALARM_STATES_CONFIG_94CE207B337340A1D8A7B8E6FC30E755");

            entity.Property(e => e.AstId).HasColumnName("AST_ID");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AlarmDuration).HasDefaultValue(24);
            entity.Property(e => e.AlarmPriorityId).HasColumnName("AlarmPriority_ID");
            entity.Property(e => e.AlarmProcessed)
                .HasDefaultValue(0)
                .HasColumnName("Alarm_Processed");
            entity.Property(e => e.AsId)
                .HasDefaultValue(2)
                .HasColumnName("AS_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.StateId).HasColumnName("State_ID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Value).HasMaxLength(100);

            entity.HasOne(d => d.AlarmPriority).WithMany(p => p.DataAlarmStatesConfigs)
                .HasForeignKey(d => d.AlarmPriorityId)
                .HasConstraintName("FK_dATA_ALARM_STATES_CONFIG_ALARM_PRIORITY");

            entity.HasOne(d => d.DataAlarm).WithMany(p => p.DataAlarmStatesConfigs)
                .HasForeignKey(d => d.DataAlarmId)
                .HasConstraintName("FK_dATA_ALARM_STATES_CONFIG_DATA_ALARM");

            entity.HasOne(d => d.State).WithMany(p => p.DataAlarmStatesConfigs)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_dATA_ALARM_STATES_CONFIG_DATA_ALARM_STATES");
        });

        modelBuilder.Entity<DataPullTracker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DataPull__3213E83F917544C1");

            entity.ToTable("DataPullTracker");

            entity.HasIndex(e => new { e.CustomerName, e.SiteName, e.PipelineId }, "IX_DataPullTracker_Customer_Site_Pipeline").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .HasColumnName("customer_name");
            entity.Property(e => e.LastTimestamp).HasColumnName("last_timestamp");
            entity.Property(e => e.PipelineId).HasColumnName("pipeline_id");
            entity.Property(e => e.SiteName)
                .HasMaxLength(200)
                .HasColumnName("site_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DependenciesMetrix>(entity =>
        {
            entity.HasKey(e => e.DmId);

            entity.ToTable("Dependencies_Metrix");

            entity.Property(e => e.DmId).HasColumnName("DM_Id");
            entity.Property(e => e.CalTagIdFk).HasColumnName("Cal_Tag_Id_FK");
            entity.Property(e => e.CalTagPId).HasColumnName("Cal_Tag_P_Id");
            entity.Property(e => e.CalTargetIdFk).HasColumnName("Cal_Target_Id_FK");
            entity.Property(e => e.CalculatedTagMaxTargetId).HasColumnName("CalculatedTagMaxTargetID");
            entity.Property(e => e.CalculatedTagMinTargetId).HasColumnName("CalculatedTagMinTargetID");
            entity.Property(e => e.CalculatedTagTargetId).HasColumnName("CalculatedTagTargetID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.MfTagIdFk).HasColumnName("MF_Tag_Id_FK");
            entity.Property(e => e.RawTagMaxTargetId).HasColumnName("RawTagMaxTargetID");
            entity.Property(e => e.RawTagMinTargetId).HasColumnName("RawTagMinTargetID");
            entity.Property(e => e.RawTagTargetId).HasColumnName("RawTagTargetID");
            entity.Property(e => e.RealTagIdFk).HasColumnName("Real_Tag_Id_FK");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");

            entity.HasOne(d => d.CalTagIdFkNavigation).WithMany(p => p.DependenciesMetrixes)
                .HasForeignKey(d => d.CalTagIdFk)
                .HasConstraintName("FK_Dependencies_Metrix_Calculated_Tags");

            entity.HasOne(d => d.MfTagIdFkNavigation).WithMany(p => p.DependenciesMetrixes)
                .HasForeignKey(d => d.MfTagIdFk)
                .HasConstraintName("FK_Dependencies_Metrix_Manual_Fix_Points");

            entity.HasOne(d => d.RealTagIdFkNavigation).WithMany(p => p.DependenciesMetrixes)
                .HasForeignKey(d => d.RealTagIdFk)
                .HasConstraintName("FK_Dependencies_Metrix_Real_Raw_Points");
        });

        modelBuilder.Entity<DependenciesMetrixHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_Dependencies_Metrix_History_1");

            entity.ToTable("Dependencies_Metrix_History");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.CalTagIdFk).HasColumnName("Cal_Tag_Id_FK");
            entity.Property(e => e.CalTagPId).HasColumnName("Cal_Tag_P_Id");
            entity.Property(e => e.CalTargetIdFk).HasColumnName("Cal_Target_Id_FK");
            entity.Property(e => e.CalculatedTagMaxTargetId).HasColumnName("CalculatedTagMaxTargetID");
            entity.Property(e => e.CalculatedTagMinTargetId).HasColumnName("CalculatedTagMinTargetID");
            entity.Property(e => e.CalculatedTagTargetId).HasColumnName("CalculatedTagTargetID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.DmId).HasColumnName("DM_Id");
            entity.Property(e => e.HistoryType)
                .HasMaxLength(500)
                .HasColumnName("History_Type");
            entity.Property(e => e.MfTagIdFk).HasColumnName("MF_Tag_Id_FK");
            entity.Property(e => e.RawTagMaxTargetId).HasColumnName("RawTagMaxTargetID");
            entity.Property(e => e.RawTagMinTargetId).HasColumnName("RawTagMinTargetID");
            entity.Property(e => e.RawTagTargetId).HasColumnName("RawTagTargetID");
            entity.Property(e => e.RealTagIdFk).HasColumnName("Real_Tag_Id_FK");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Time_Stamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");
        });

        modelBuilder.Entity<DesignDatum>(entity =>
        {
            entity.HasKey(e => e.DesignDataId);

            entity.ToTable("Design_Data");

            entity.Property(e => e.DesignDataId).HasColumnName("Design_Data_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.DataValue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Data_Value");
            entity.Property(e => e.DesignParameterIdFk).HasColumnName("Design_Parameter_Id_FK");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<DesignParameter>(entity =>
        {
            entity.ToTable("Design_Parameters");

            entity.Property(e => e.DesignParameterId).HasColumnName("Design_Parameter_Id");
            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("Asset_CategoryId_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ParameterName).HasColumnName("Parameter_Name");
            entity.Property(e => e.Unit).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CertificationExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DevicePlatform).HasColumnName("Device_Platform");
            entity.Property(e => e.DeviceTypeIdFk).HasColumnName("DeviceTypeID_Fk");
            entity.Property(e => e.FormatIdfk).HasColumnName("FormatIDFk");
            entity.Property(e => e.Guid).HasColumnName("GUID");
            entity.Property(e => e.IoTedgeConnectionString).HasColumnName("IoTEdge_ConnectionString");
            entity.Property(e => e.IotconnectionString).HasColumnName("IOTConnectionString");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.JiraTicketUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("JiraTicketURL");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MqttPassword).HasColumnName("Mqtt_Password");
            entity.Property(e => e.MqttPublishTopic).HasColumnName("Mqtt_Publish_Topic");
            entity.Property(e => e.MqttUsername).HasColumnName("Mqtt_Username");
            entity.Property(e => e.SiteSpecificMappedId)
                .HasMaxLength(100)
                .HasColumnName("Site_Specific_Mapped_ID");
            entity.Property(e => e.TicketIssuedOn).HasColumnType("datetime");

            entity.HasOne(d => d.DeviceTypeIdFkNavigation).WithMany(p => p.Devices)
                .HasForeignKey(d => d.DeviceTypeIdFk)
                .HasConstraintName("FK__Devices__DeviceT__7CDA51C0");
        });

        modelBuilder.Entity<DeviceDlSetting>(entity =>
        {
            entity.ToTable("Device_DL_Settings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceIdFk).HasColumnName("Device_ID_FK");
            entity.Property(e => e.DlPassword).HasColumnName("DL_Password");
            entity.Property(e => e.DlSiteName).HasColumnName("DL_Site_Name");
            entity.Property(e => e.DlUsername).HasColumnName("DL_Username");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");

            entity.HasOne(d => d.DeviceIdFkNavigation).WithMany(p => p.DeviceDlSettings)
                .HasForeignKey(d => d.DeviceIdFk)
                .HasConstraintName("FK__Device_DL__Devic__03874F4F");

            entity.HasOne(d => d.SiteIdFkNavigation).WithMany(p => p.DeviceDlSettings)
                .HasForeignKey(d => d.SiteIdFk)
                .HasConstraintName("FK__Device_DL__Site___6BF9DE81");
        });

        modelBuilder.Entity<DeviceModbusSetting>(entity =>
        {
            entity.ToTable("Device_Modbus_Settings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BaudRate).HasColumnName("Baud_Rate");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceIdFk).HasColumnName("Device_Id_Fk");
            entity.Property(e => e.Method)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Parity)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Port)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.StopBit).HasColumnName("Stop_Bit");

            entity.HasOne(d => d.DeviceIdFkNavigation).WithMany(p => p.DeviceModbusSettings)
                .HasForeignKey(d => d.DeviceIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Device_Modbus_Settings_Devices");
        });

        modelBuilder.Entity<DeviceOpcServerM2m>(entity =>
        {
            entity.ToTable("Device_OPC_Server_M2M");

            entity.Property(e => e.DeviceIdFk).HasColumnName("Device_Id_FK");
            entity.Property(e => e.OpcIdFk).HasColumnName("OPC_Id_FK");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");

            entity.HasOne(d => d.DeviceIdFkNavigation).WithMany(p => p.DeviceOpcServerM2ms)
                .HasForeignKey(d => d.DeviceIdFk)
                .HasConstraintName("FK_Device_OPC_Server_M2M_Devices1");

            entity.HasOne(d => d.OpcIdFkNavigation).WithMany(p => p.DeviceOpcServerM2ms)
                .HasForeignKey(d => d.OpcIdFk)
                .HasConstraintName("FK_Device_OPC_Server_M2M_OPC_Server_Config");
        });

        modelBuilder.Entity<DeviceOpcSetting>(entity =>
        {
            entity.ToTable("Device_OPC_Settings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceId).HasColumnName("Device_ID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OpcMachineAddress).HasColumnName("OPC_Machine_Address");
            entity.Property(e => e.OpcMachinePassword).HasColumnName("OPC_Machine_Password");
            entity.Property(e => e.OpcMachineUsername).HasColumnName("OPC_Machine_Username");
            entity.Property(e => e.OpcPassword).HasColumnName("OPC_Password");
            entity.Property(e => e.OpcSecurity).HasColumnName("OPC_Security");
            entity.Property(e => e.OpcServerAddress).HasColumnName("OPC_Server_Address");
            entity.Property(e => e.OpcUsername).HasColumnName("OPC_Username");
        });

        modelBuilder.Entity<DevicePlatform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Device_P__3214EC2797648D70");

            entity.ToTable("Device_Platform");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<DeviceTimeStampIdmapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DeviceTi__3214EC0723BBDC97");

            entity.ToTable("DeviceTimeStampIDMapping");

            entity.Property(e => e.IdSourceTagIdFk).HasColumnName("ID_SourceTagId_FK");
            entity.Property(e => e.TimeStampFormat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TimeStamp_Format");
            entity.Property(e => e.TimeStampSourceTagIdFk).HasColumnName("TimeStamp_SourceTagId_FK");

            entity.HasOne(d => d.Device).WithMany(p => p.DeviceTimeStampIdmappings)
                .HasForeignKey(d => d.DeviceId)
                .HasConstraintName("FK__DeviceTim__Devic__7DCE75F9");

            entity.HasOne(d => d.IdSourceTagIdFkNavigation).WithMany(p => p.DeviceTimeStampIdmappingIdSourceTagIdFkNavigations)
                .HasForeignKey(d => d.IdSourceTagIdFk)
                .HasConstraintName("FK__DeviceTim__ID_So__3E530F62");

            entity.HasOne(d => d.TimeStampSourceTagIdFkNavigation).WithMany(p => p.DeviceTimeStampIdmappingTimeStampSourceTagIdFkNavigations)
                .HasForeignKey(d => d.TimeStampSourceTagIdFk)
                .HasConstraintName("FK__DeviceTim__TimeS__3D5EEB29");
        });

        modelBuilder.Entity<DeviceType>(entity =>
        {
            entity.ToTable("Device_Type");

            entity.Property(e => e.DeviceTypeId).HasColumnName("DeviceTypeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<DevicesSitesM2m>(entity =>
        {
            entity.ToTable("Devices_SitesM2M");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeviceId).HasColumnName("Device_ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");
            entity.Property(e => e.SiteSpecificId).HasColumnName("Site_Specific_Id");
        });

        modelBuilder.Entity<Distributor>(entity =>
        {
            entity.HasKey(e => e.DistributorId).HasName("PK__Distribu__FD1AEB9E2E6C7F74");

            entity.ToTable("Distributor");

            entity.Property(e => e.ContactNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByUser).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DistributorName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedByUser).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DistributorProductM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Distribu__3214EC078580EF2F");

            entity.ToTable("DistributorProductM2M");

            entity.Property(e => e.CreatedByUser).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DistributorIdFk).HasColumnName("DistributorId_Fk");
            entity.Property(e => e.ProductIdFk).HasColumnName("ProductId_Fk");
            entity.Property(e => e.UpdatedByUser).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.DistributorIdFkNavigation).WithMany(p => p.DistributorProductM2ms)
                .HasForeignKey(d => d.DistributorIdFk)
                .HasConstraintName("FK_DistributorProductM2M.DistributorId");

            entity.HasOne(d => d.ProductIdFkNavigation).WithMany(p => p.DistributorProductM2ms)
                .HasForeignKey(d => d.ProductIdFk)
                .HasConstraintName("FK_DistributorProductM2M.ProductId");
        });

        modelBuilder.Entity<DummyTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DummyTab__3214EC07665C55B4");

            entity.ToTable("DummyTable");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EdgeConfigurationTimeLine>(entity =>
        {
            entity.ToTable("EdgeConfigurationTimeLine");

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<EdgeDevice>(entity =>
        {
            entity.HasKey(e => e.EdId).HasName("PK__edge_dev__B9CE0418673252C2");

            entity.ToTable("edge_device");

            entity.Property(e => e.EdId).HasColumnName("ED_ID");
            entity.Property(e => e.BufferedDataSize)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Buffered_data_size");
            entity.Property(e => e.CpuUtilization)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CPU_Utilization");
            entity.Property(e => e.EdgeDeviceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EdgeDeviceID");
            entity.Property(e => e.HardDiskConsumption)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Hard_Disk_Consumption");
            entity.Property(e => e.HardDiskFreeSpace)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Hard_Disk_Free_Space");
            entity.Property(e => e.HardDiskSize)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Hard_Disk_Size");
            entity.Property(e => e.LastSignalReceived)
                .HasColumnType("datetime")
                .HasColumnName("Last_Signal_Received");
            entity.Property(e => e.MemoryUsage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Memory_Usage");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
        });

        modelBuilder.Entity<EnpAzureRelayConnectionDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Azur__3214EC07778A87F2");

            entity.ToTable("Enp_AzureRelayConnectionDetails");

            entity.Property(e => e.ConnectionString)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.HybridConnectionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HybridConnectionUrl)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.KeyName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KeyValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RelayNamespace)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EnpConnectorApiUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Enp_Connector_Api_Url");

            entity.ToTable("Enp_Connector_Api_Urls");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.Username).HasMaxLength(200);
        });

        modelBuilder.Entity<EnpConnectorConnector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC07BAA66DCD");

            entity.ToTable("Enp_Connector_Connectors");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");
            entity.Property(e => e.DatabaseName).HasMaxLength(255);
            entity.Property(e => e.IsOtdata).HasColumnName("IsOTData");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.PortNumber).HasMaxLength(100);
            entity.Property(e => e.SelfHostedIr)
                .HasDefaultValue(true)
                .HasColumnName("SelfHostedIR");
            entity.Property(e => e.ServerAddress).HasMaxLength(250);
            entity.Property(e => e.SiteId).HasMaxLength(250);
            entity.Property(e => e.TenantId).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            entity.Property(e => e.Username).HasMaxLength(250);

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.EnpConnectorConnectors)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Enp_Connector_Connectors_Type");
        });

        modelBuilder.Entity<EnpConnectorConnectorType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC075B4688C4");

            entity.ToTable("Enp_Connector_ConnectorType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AzureIr)
                .HasDefaultValue(false)
                .HasColumnName("AzureIR");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EnpConnectorDatatypeAzureSql>(entity =>
        {
            entity.ToTable("Enp_Connector_Datatype_AzureSql");

            entity.Property(e => e.DataType).HasMaxLength(50);
        });

        modelBuilder.Entity<EnpConnectorDatatypeInterimService>(entity =>
        {
            entity.ToTable("Enp_Connector_Datatype_InterimService");

            entity.Property(e => e.DataType).HasMaxLength(50);
        });

        modelBuilder.Entity<EnpConnectorDatatypeSapHana>(entity =>
        {
            entity.ToTable("Enp_Connector_Datatype_SapHana");

            entity.Property(e => e.DataType).HasMaxLength(50);
        });

        modelBuilder.Entity<EnpConnectorDatatypeSapHanaAzureSql>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC07F7BA0C22");

            entity.ToTable("Enp_Connector_Datatype_SapHana_AzureSql");

            entity.HasOne(d => d.AzureSql).WithMany(p => p.EnpConnectorDatatypeSapHanaAzureSqls)
                .HasForeignKey(d => d.AzureSqlId)
                .HasConstraintName("FK__Enp_Conne__Azure__367CE370");

            entity.HasOne(d => d.InterimService).WithMany(p => p.EnpConnectorDatatypeSapHanaAzureSqls)
                .HasForeignKey(d => d.InterimServiceId)
                .HasConstraintName("FK__Enp_Conne__Inter__3588BF37");

            entity.HasOne(d => d.SapHana).WithMany(p => p.EnpConnectorDatatypeSapHanaAzureSqls)
                .HasForeignKey(d => d.SapHanaId)
                .HasConstraintName("FK__Enp_Conne__SapHa__34949AFE");
        });

        modelBuilder.Entity<EnpConnectorPipeline>(entity =>
        {
            entity.ToTable("Enp_Connector_Pipeline");

            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.DatabaseName).HasMaxLength(200);
            entity.Property(e => e.TableName).HasMaxLength(200);
            entity.Property(e => e.UniqueKeyName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");

            entity.HasOne(d => d.Connector).WithMany(p => p.EnpConnectorPipelines)
                .HasForeignKey(d => d.ConnectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Enp_Connector_Pipeline_Connector");

            entity.HasOne(d => d.WriteBehaviour).WithMany(p => p.EnpConnectorPipelines)
                .HasForeignKey(d => d.WriteBehaviourId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pipeline_WriteBehaviour");

            entity.HasOne(d => d.WriteOption).WithMany(p => p.EnpConnectorPipelines)
                .HasForeignKey(d => d.WriteOptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pipeline_WriteOption");
        });

        modelBuilder.Entity<EnpConnectorPipelineMapping>(entity =>
        {
            entity.ToTable("Enp_Connector_Pipeline_Mapping");

            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.InterimField).HasMaxLength(128);
            entity.Property(e => e.InterimType).HasMaxLength(100);
            entity.Property(e => e.SinkField).HasMaxLength(128);
            entity.Property(e => e.SinkType).HasMaxLength(100);
            entity.Property(e => e.SourceField).HasMaxLength(128);
            entity.Property(e => e.SourceType).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");

            entity.HasOne(d => d.Pipeline).WithMany(p => p.EnpConnectorPipelineMappings)
                .HasForeignKey(d => d.PipelineId)
                .HasConstraintName("FK_PipelineMapping_Pipeline");
        });

        modelBuilder.Entity<EnpConnectorPipelineTrigger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC0710CD38ED");

            entity.ToTable("Enp_Connector_Pipeline_Trigger");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.IsEnabled)
                .HasDefaultValue(true)
                .HasColumnName("Is_Enabled");
            entity.Property(e => e.LastRun)
                .HasColumnType("datetime")
                .HasColumnName("Last_Run");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NextDue)
                .HasColumnType("datetime")
                .HasColumnName("Next_Due");
            entity.Property(e => e.Recurrence).HasMaxLength(255);
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Minute")
                .HasColumnName("Schedule_Type");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);

            entity.HasOne(d => d.Connector).WithMany(p => p.EnpConnectorPipelineTriggers)
                .HasForeignKey(d => d.ConnectorId)
                .HasConstraintName("FK_Enp_Connector_Pipeline_Trigger_Connector");

            entity.HasOne(d => d.Pipeline).WithMany(p => p.EnpConnectorPipelineTriggers)
                .HasForeignKey(d => d.PipelineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Enp_Conne__Pipel__1A9FBED1");

            entity.HasOne(d => d.Type).WithMany(p => p.EnpConnectorPipelineTriggers)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Enp_Conne__TypeI__19AB9A98");
        });

        modelBuilder.Entity<EnpConnectorPipelineTriggerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC077045C3FB");

            entity.ToTable("Enp_Connector_Pipeline_TriggerType");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EnpConnectorPipelineWriteBehaviour>(entity =>
        {
            entity.ToTable("Enp_Connector_Pipeline_WriteBehaviour");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EnpConnectorPipelineWriteOption>(entity =>
        {
            entity.ToTable("Enp_Connector_Pipeline_WriteOption");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EnpConnectorRestApi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC07FEDD9235");

            entity.ToTable("Enp_Connector_RestApi");

            entity.Property(e => e.ClientId).HasMaxLength(250);
            entity.Property(e => e.ConnectIdFk).HasColumnName("ConnectIdFK");
            entity.Property(e => e.RestAuthPassword).HasMaxLength(250);
            entity.Property(e => e.RestAuthUsername).HasMaxLength(250);
        });

        modelBuilder.Entity<EnpConnectorSqlAutomation>(entity =>
        {
            entity.ToTable("Enp_Connector_SqlAutomation");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.SqlDbName).HasMaxLength(250);
            entity.Property(e => e.SqlServerName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            entity.Property(e => e.Username).HasMaxLength(250);
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.ErrorLogId).HasName("PK__ErrorLog__D65247E28CBE9AFA");

            entity.ToTable("ErrorLog");

            entity.Property(e => e.ErrorLogId).HasColumnName("ErrorLogID");
            entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
            entity.Property(e => e.ErrorTime).HasDefaultValueSql("(sysdatetime())");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Events__FD6BEF84E1E5AC2B");

            entity.Property(e => e.EventId).HasColumnName("Event_Id");
            entity.Property(e => e.EcomponentId).HasColumnName("EComponent_ID");
            entity.Property(e => e.EventName).HasMaxLength(200);

            entity.HasOne(d => d.Ecomponent).WithMany(p => p.Events)
                .HasForeignKey(d => d.EcomponentId)
                .HasConstraintName("FK_Events.EComponent_ID");
        });

        modelBuilder.Entity<EventCategory>(entity =>
        {
            entity.HasKey(e => e.EcategoryId).HasName("PK__EventCat__82D2BAFCA4BDB176");

            entity.ToTable("EventCategory");

            entity.Property(e => e.EcategoryId)
                .ValueGeneratedNever()
                .HasColumnName("ECategory_ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(200)
                .HasColumnName("Category_Name");
        });

        modelBuilder.Entity<EventComponent>(entity =>
        {
            entity.HasKey(e => e.EcomponentId).HasName("PK__EventCom__91861D69B15E56D1");

            entity.ToTable("EventComponent");

            entity.Property(e => e.EcomponentId)
                .ValueGeneratedNever()
                .HasColumnName("EComponent_ID");
            entity.Property(e => e.ComponentName)
                .HasMaxLength(200)
                .HasColumnName("Component_Name");
            entity.Property(e => e.EcategoryId).HasColumnName("ECategory_ID");

            entity.HasOne(d => d.Ecategory).WithMany(p => p.EventComponents)
                .HasForeignKey(d => d.EcategoryId)
                .HasConstraintName("FK_EventComponent.ECategory_ID");
        });

        modelBuilder.Entity<EventComponentLookup>(entity =>
        {
            entity.HasKey(e => e.EcomponentId).HasName("PK__EventCom__91861D09208F80B3");

            entity.ToTable("EventComponentLookup");

            entity.Property(e => e.EcomponentId).HasColumnName("EComponent_Id");
            entity.Property(e => e.EcategoryTitle)
                .HasMaxLength(200)
                .HasColumnName("ECategoryTitle");
            entity.Property(e => e.EcomponentTitle)
                .HasMaxLength(200)
                .HasColumnName("EComponentTitle");
            entity.Property(e => e.EventNameLevel1)
                .HasMaxLength(200)
                .HasColumnName("Event Name Level 1");
            entity.Property(e => e.EventNameLevel2)
                .HasMaxLength(100)
                .HasColumnName("Event Name Level 2");
            entity.Property(e => e.EventNameLevel3)
                .HasMaxLength(100)
                .HasColumnName("Event Name Level 3");
        });

        modelBuilder.Entity<ExceptionLogging>(entity =>
        {
            entity.ToTable("Exception_Logging");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ControllerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExceptionDate).HasColumnType("datetime");
            entity.Property(e => e.ExceptionMessage).IsUnicode(false);
        });

        modelBuilder.Entity<Export5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("export (5)");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagName).HasMaxLength(50);
        });

        modelBuilder.Entity<ExportJobExecutionLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__ExportJo__5E5499A8366FF124");

            entity.ToTable("ExportJobExecutionLog");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.Duration).HasMaxLength(50);
            entity.Property(e => e.ExecutionId).HasColumnName("ExecutionID");
            entity.Property(e => e.ExecutionTimestamp).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.RequestedEndTime)
                .HasColumnType("datetime")
                .HasColumnName("Requested_EndTime");
            entity.Property(e => e.RequestedStartTime)
                .HasColumnType("datetime")
                .HasColumnName("Requested_StartTime");
            entity.Property(e => e.RunId)
                .HasMaxLength(50)
                .HasColumnName("RunID");
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<ExportJobExecutionLog1>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("ExportJobExecutionLogs");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.ExecutedAt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("executed_at");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TriggerId).HasColumnName("trigger_id");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("trigger_name");
        });

        modelBuilder.Entity<ExportJobParameter>(entity =>
        {
            entity.HasKey(e => e.ParamId).HasName("PK__ExportJo__C4B284583C2A5AC6");

            entity.Property(e => e.ParamId).HasColumnName("Param_ID");
            entity.Property(e => e.Apx).HasColumnName("APX");
            entity.Property(e => e.AreaName)
                .HasMaxLength(200)
                .HasColumnName("Area_Name");
            entity.Property(e => e.ColumnDatetime)
                .HasColumnType("datetime")
                .HasColumnName("column_datetime");
            entity.Property(e => e.ColumnOrderedBy)
                .HasMaxLength(200)
                .HasColumnName("Column_Ordered_By");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.EndDatetime)
                .HasColumnType("datetime")
                .HasColumnName("End_Datetime");
            entity.Property(e => e.EndRelativeExpr)
                .HasMaxLength(50)
                .HasColumnName("End_Relative_Expr");
            entity.Property(e => e.IsRelativeTime).HasColumnName("Is_Relative_Time");
            entity.Property(e => e.ItemNames).HasColumnName("Item_Names");
            entity.Property(e => e.JobId).HasColumnName("Job_ID");
            entity.Property(e => e.Mode).HasMaxLength(50);
            entity.Property(e => e.NumberOfLatestRecords).HasColumnName("Number_Of_Latest_Records");
            entity.Property(e => e.ProductionDatabase).HasColumnName("Production_Database");
            entity.Property(e => e.RequiredColumns).HasColumnName("Required_Columns");
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");
            entity.Property(e => e.SiteName)
                .HasMaxLength(200)
                .HasColumnName("Site_Name");
            entity.Property(e => e.StartDatetime)
                .HasColumnType("datetime")
                .HasColumnName("Start_Datetime");
            entity.Property(e => e.StartRelativeExpr)
                .HasMaxLength(50)
                .HasColumnName("Start_Relative_Expr");
            entity.Property(e => e.TagAggregate)
                .HasMaxLength(50)
                .HasColumnName("Tag_Aggregate");
            entity.Property(e => e.TagGranularity)
                .HasMaxLength(50)
                .HasColumnName("Tag_Granularity");
            entity.Property(e => e.TagType)
                .HasMaxLength(50)
                .HasColumnName("Tag_Type");
            entity.Property(e => e.TargetTable)
                .HasMaxLength(200)
                .HasColumnName("Target_Table");
            entity.Property(e => e.UserFriendly).HasColumnName("User_Friendly");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UtcTime).HasColumnName("UTC_Time");
        });

        modelBuilder.Entity<ExportPipeLine>(entity =>
        {
            entity.HasKey(e => e.PipeLineId).HasName("PK__ExportPi__81251D8F73607690");

            entity.ToTable("ExportPipeLine");

            entity.Property(e => e.ConnectionHostName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataMode).HasMaxLength(50);
            entity.Property(e => e.DataPointAggregation).HasMaxLength(50);
            entity.Property(e => e.DataPointResolutionValueType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DatabaseName).HasMaxLength(200);
            entity.Property(e => e.EndTimeToPullData).HasPrecision(0);
            entity.Property(e => e.ManualDataTransferStartDate)
                .HasColumnType("datetime")
                .HasColumnName("manualDataTransferStartDate");
            entity.Property(e => e.ManualDataTrnsferEndtDate)
                .HasColumnType("datetime")
                .HasColumnName("manualDataTrnsferEndtDate");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PipeLineName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleStartDate)
                .HasColumnType("datetime")
                .HasColumnName("scheduleStartDate");
            entity.Property(e => e.ScheduleTransferResoultionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scheduleTransferResoultionType");
            entity.Property(e => e.ScheduleTrasferResolutionValue).HasColumnName("scheduleTrasferResolutionValue");
            entity.Property(e => e.SelectedTagType)
                .HasMaxLength(100)
                .HasColumnName("selectedTagType");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.StartTimeToPullData).HasPrecision(0);
            entity.Property(e => e.TransferType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("User_Id");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<ExportPointer>(entity =>
        {
            entity.HasKey(e => e.PointerId).HasName("PK__ExportPo__3A6395893D515731");

            entity.ToTable("ExportPointer");

            entity.Property(e => e.InsertedOn)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.MaxTimeStamp).HasPrecision(0);
        });

        modelBuilder.Entity<ExportSiteLayOutStatus>(entity =>
        {
            entity.HasKey(e => e.SiteLayOutId);

            entity.ToTable("ExportSiteLayOutStatus");

            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");

            entity.HasOne(d => d.Site).WithMany(p => p.ExportSiteLayOutStatuses)
                .HasForeignKey(d => d.SiteId)
                .HasConstraintName("FK_ExportSiteLayOutStatus_Plant_Site");

            entity.HasOne(d => d.User).WithMany(p => p.ExportSiteLayOutStatuses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ExportSiteLayOutStatus_AspNetUsers");
        });

        modelBuilder.Entity<ExportToExcelStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExportTo__3214EC0770AE464F");

            entity.ToTable("ExportToExcelStatus");

            entity.Property(e => e.ExportedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OperationId).HasMaxLength(255);
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<ExportZamil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("exportZamil");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IngestionTime).HasColumnName("Ingestion_Time");
            entity.Property(e => e.RMappedName)
                .HasMaxLength(50)
                .HasColumnName("R_Mapped_Name");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
        });

        modelBuilder.Entity<ExportedKohinoor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("exportedKohinoor");

            entity.Property(e => e.IngestionTime).HasColumnName("Ingestion_Time");
            entity.Property(e => e.RMappedName)
                .HasMaxLength(50)
                .HasColumnName("R_Mapped_Name");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
        });

        modelBuilder.Entity<ExportedTagDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Sc1Val).HasColumnName("SC1_Val");
            entity.Property(e => e.Sc2Val).HasColumnName("SC2_Val");
        });

        modelBuilder.Entity<ExportsScheduling>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExportsScheduling");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.ExecuteNow).HasColumnName("Execute_Now");
            entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");
            entity.Property(e => e.JobId).HasColumnName("Job_Id");
            entity.Property(e => e.LastDayOfMonth).HasColumnName("Last_Day_Of_Month");
            entity.Property(e => e.LastRun)
                .HasColumnType("datetime")
                .HasColumnName("Last_Run");
            entity.Property(e => e.NextDue)
                .HasColumnType("datetime")
                .HasColumnName("Next_Due");
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Schedule_Type");
            entity.Property(e => e.ScheduleValue).HasColumnName("Schedule_Value");
            entity.Property(e => e.StartedOn)
                .HasColumnType("datetime")
                .HasColumnName("Started_On");
            entity.Property(e => e.TriggerId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Trigger_Id");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Trigger_Name");
            entity.Property(e => e.TriggerType).HasColumnName("Trigger_Type");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<ExportsqldDatapointsQaRealTagOtTabletype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("exportsqld_datapoints_qa_real_tag_ot_tabletype");

            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<FastAlarm>(entity =>
        {
            entity.Property(e => e.MappedName).HasMaxLength(100);
            entity.Property(e => e.TagType).HasMaxLength(50);
        });

        modelBuilder.Entity<FintechSiteShiftsConfiguration>(entity =>
        {
            entity.HasKey(e => e.FsId);

            entity.ToTable("Fintech_Site_ShiftsConfigurations");

            entity.Property(e => e.FsId).HasColumnName("FS_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ShiftEndTime)
                .HasColumnType("datetime")
                .HasColumnName("Shift_EndTime");
            entity.Property(e => e.ShiftStartTime)
                .HasColumnType("datetime")
                .HasColumnName("Shift_StartTime");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
        });

        modelBuilder.Entity<FintechTankDelivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TDD");

            entity.ToTable("Fintech_TankDelivery");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateEnd).HasColumnName("date_end");
            entity.Property(e => e.DateStart).HasColumnName("date_start");
            entity.Property(e => e.DeliveryId).HasColumnName("delivery_id");
            entity.Property(e => e.DeliveryNoteId).HasColumnName("delivery_note_id");
            entity.Property(e => e.FcSiteId).HasColumnName("FC_SiteID");
            entity.Property(e => e.HeightEnd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("height_end");
            entity.Property(e => e.HeightStart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("height_start");
            entity.Property(e => e.LastModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("last_modified_date");
            entity.Property(e => e.OmniAssetId).HasColumnName("Omni_AssetID");
            entity.Property(e => e.ProdDensityEnd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prod_density_end");
            entity.Property(e => e.ProdDensityStart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prod_density_start");
            entity.Property(e => e.ProdTcDensityEnd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prod_tc_density_end");
            entity.Property(e => e.ProdTcDensityStart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prod_tc_density_start");
            entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.SourceType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("source_type");
            entity.Property(e => e.TankId).HasColumnName("tank_id");
            entity.Property(e => e.TempEnd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("temp_end");
            entity.Property(e => e.TempStart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("temp_start");
            entity.Property(e => e.TimeEnd).HasColumnName("time_end");
            entity.Property(e => e.TimeStart).HasColumnName("time_start");
            entity.Property(e => e.TransactionsVolume)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("transactions_volume");
            entity.Property(e => e.VolEnd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("vol_end");
            entity.Property(e => e.VolStart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("vol_start");
            entity.Property(e => e.VolTcEnd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("vol_tc_end");
            entity.Property(e => e.VolTcStart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("vol_tc_start");
            entity.Property(e => e.VolTcTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("vol_tc_total");
            entity.Property(e => e.VolTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("vol_total");
            entity.Property(e => e.WaterEnd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("water_end");
            entity.Property(e => e.WaterHeightEnd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("water_height_end");
            entity.Property(e => e.WaterHeightStart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("water_height_start");
            entity.Property(e => e.WaterStart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("water_start");
        });

        modelBuilder.Entity<FintechTransactionstype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fintech___3214EC2707EA55C2");

            entity.ToTable("fintech_transactionstype");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FcSiteId).HasColumnName("FC_SiteID");
            entity.Property(e => e.LastModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("last_modified_date");
            entity.Property(e => e.PayPaymentInfo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pay_payment_info");
            entity.Property(e => e.PayPaymentType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pay_payment_type");
            entity.Property(e => e.SaleId).HasColumnName("sale_id");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
        });

        modelBuilder.Entity<FmLogin>(entity =>
        {
            entity.ToTable("FM_Login");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(10);
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(10);
        });

        modelBuilder.Entity<FormatTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormatTa__3214EC27A3595AAC");

            entity.ToTable("FormatTable");

            entity.HasIndex(e => e.FuncName, "UQ__FormatTa__12EF90A60DBA8F3A").IsUnique();

            entity.HasIndex(e => e.FormatName, "UQ__FormatTa__DF6FD9EA07B8FEEE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FormatName)
                .HasMaxLength(255)
                .HasColumnName("formatName");
            entity.Property(e => e.FuncName)
                .HasMaxLength(255)
                .HasColumnName("funcName");
        });

        modelBuilder.Entity<FormulaDependenciesMetrix>(entity =>
        {
            entity.HasKey(e => e.FdmId).HasName("PK__Formula___527C2DA7750A68DC");

            entity.ToTable("Formula_Dependencies_Metrix");

            entity.Property(e => e.FdmId).HasColumnName("FDM_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FStatus).HasColumnName("F_status");
            entity.Property(e => e.FormulaId).HasColumnName("Formula_ID");
            entity.Property(e => e.FormulaPId).HasColumnName("Formula_P_ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpadtedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VariableId).HasColumnName("Variable_ID");

            entity.HasOne(d => d.Formula).WithMany(p => p.FormulaDependenciesMetrixes)
                .HasForeignKey(d => d.FormulaId)
                .HasConstraintName("FK__Formula_D__Formu__671F4F74");

            entity.HasOne(d => d.Variable).WithMany(p => p.FormulaDependenciesMetrixes)
                .HasForeignKey(d => d.VariableId)
                .HasConstraintName("FK__Formula_D__Varia__681373AD");
        });

        modelBuilder.Entity<FormulaLibrary>(entity =>
        {
            entity.HasKey(e => e.FormulaLibId);

            entity.ToTable("Formula_Library");

            entity.Property(e => e.FormulaLibId)
                .ValueGeneratedNever()
                .HasColumnName("Formula_Lib_Id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.Formula).HasMaxLength(500);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");

            entity.HasMany(d => d.AssetLibIdFks).WithMany(p => p.FormulaLibIdFks)
                .UsingEntity<Dictionary<string, object>>(
                    "AssetLibFormulaLibMToM",
                    r => r.HasOne<AssetLibrary>().WithMany()
                        .HasForeignKey("AssetLibIdFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Asset_Lib_Formula_Lib_M_To_M_Asset_Library"),
                    l => l.HasOne<FormulaLibrary>().WithMany()
                        .HasForeignKey("FormulaLibIdFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Asset_Lib_Formula_Lib_M_To_M_Formula_Library"),
                    j =>
                    {
                        j.HasKey("FormulaLibIdFk", "AssetLibIdFk");
                        j.ToTable("Asset_Lib_Formula_Lib_M_To_M");
                        j.IndexerProperty<int>("FormulaLibIdFk").HasColumnName("Formula_Lib_Id_FK");
                        j.IndexerProperty<int>("AssetLibIdFk").HasColumnName("Asset_Lib_Id_FK");
                    });
        });

        modelBuilder.Entity<FormulaLibraryHistory>(entity =>
        {
            entity.HasKey(e => e.FormulaLibId);

            entity.ToTable("Formula_Library_History");

            entity.Property(e => e.FormulaLibId)
                .ValueGeneratedNever()
                .HasColumnName("Formula_Lib_Id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.Formula).HasMaxLength(500);
            entity.Property(e => e.HistoryType)
                .HasMaxLength(250)
                .HasColumnName("History_Type");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Time_Stamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");
        });

        modelBuilder.Entity<Hamconnection>(entity =>
        {
            entity.HasKey(e => e.ConnectionId).HasName("PK__HAMConne__404A64F32DCEC2BF");

            entity.ToTable("HAMConnections");

            entity.Property(e => e.ConnectionId).HasColumnName("ConnectionID");
            entity.Property(e => e.ConnectionName).HasMaxLength(100);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Host).HasMaxLength(200);
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.Port).HasDefaultValue(22);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<HamdataSource>(entity =>
        {
            entity.HasKey(e => e.SourceId).HasName("PK__HAMDataS__16E019F95A535C29");

            entity.ToTable("HAMDataSources");

            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.ConnectionId).HasColumnName("ConnectionID");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FileFormat).HasMaxLength(20);
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SourceName).HasMaxLength(100);

            entity.HasOne(d => d.Connection).WithMany(p => p.HamdataSources)
                .HasForeignKey(d => d.ConnectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HAMDataSources_Connections");
        });

        modelBuilder.Entity<HamexecutionLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__HAMExecu__5E5499A8CE379E29");

            entity.ToTable("HAMExecutionLogs");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.ExecutionTime).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TriggerType).HasMaxLength(20);

            entity.HasOne(d => d.Source).WithMany(p => p.HamexecutionLogs)
                .HasForeignKey(d => d.SourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HAMExecutionLogs_DataSources");
        });

        modelBuilder.Entity<HamtransformRule>(entity =>
        {
            entity.HasKey(e => e.RuleId).HasName("PK__HAMTrans__110458C269ED4D25");

            entity.ToTable("HAMTransformRules");

            entity.Property(e => e.RuleId).HasColumnName("RuleID");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.TagField).HasMaxLength(200);
            entity.Property(e => e.TimestampField).HasMaxLength(200);
            entity.Property(e => e.ValueField).HasMaxLength(200);

            entity.HasOne(d => d.Source).WithMany(p => p.HamtransformRules)
                .HasForeignKey(d => d.SourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HAMTransformRules_DataSources");
        });

        modelBuilder.Entity<HasanCustomersSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hasan_Customers_Sites");

            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SiteName).IsUnicode(false);
        });

        modelBuilder.Entity<HassanArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hassan_Areas");

            entity.Property(e => e.AreaName).IsUnicode(false);
            entity.Property(e => e.CustomerSiteId).HasColumnName("CustomerSiteID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<HassanAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hassan_Assets");

            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.AssetType).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParentAsset).IsUnicode(false);
        });

        modelBuilder.Entity<HassanTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hassan_Tags");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<HierarchyExportsDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Area).IsUnicode(false);
            entity.Property(e => e.Asset).IsUnicode(false);
            entity.Property(e => e.AssetType)
                .IsUnicode(false)
                .HasColumnName("Asset_type");
            entity.Property(e => e.ParentAsset)
                .IsUnicode(false)
                .HasColumnName("Parent_Asset");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<HubcoNelManual>(entity =>
        {
            entity.HasKey(e => e.Date).HasName("PK__Hubco_NE__77387D068E7E4703");

            entity.ToTable("Hubco_NEL_manual");

            entity.HasIndex(e => e.Date, "UQ__Hubco_NE__77387D0797E7DB38").IsUnique();

            entity.Property(e => e.CapacityFactor).HasColumnName("Capacity_Factor");
            entity.Property(e => e.FuelStockHfoTank1).HasColumnName("Fuel_Stock_HFO_Tank_1");
            entity.Property(e => e.FuelStockHfoTank2).HasColumnName("Fuel_Stock_HFO_Tank_2");
            entity.Property(e => e.FuelStockHfoTank3).HasColumnName("Fuel_Stock_HFO_Tank_3");
            entity.Property(e => e.ImportEnergy).HasColumnName("Import_Energy");
            entity.Property(e => e.InhouseConsumption).HasColumnName("Inhouse_Consumption");
            entity.Property(e => e.SolarGeneration).HasColumnName("Solar_Generation");
        });

        modelBuilder.Entity<ImportFile>(entity =>
        {
            entity.HasKey(e => e.ImportId);

            entity.Property(e => e.ImportId).HasColumnName("Import_Id");
            entity.Property(e => e.ImportBy).IsUnicode(false);
            entity.Property(e => e.ImportEndDate).HasColumnType("datetime");
            entity.Property(e => e.ImportStartDate).HasColumnType("datetime");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_Fk");
        });

        modelBuilder.Entity<ImportFileStatus>(entity =>
        {
            entity.HasKey(e => e.ImportStatusId);

            entity.ToTable("Import_File_Status");

            entity.Property(e => e.ImportStatusId).HasColumnName("Import_Status_Id");
            entity.Property(e => e.ImportEntity)
                .HasMaxLength(200)
                .HasColumnName("Import_Entity");
            entity.Property(e => e.ImportIdFk).HasColumnName("Import_Id_Fk");
            entity.Property(e => e.ProcessingStatus).HasMaxLength(100);
            entity.Property(e => e.SuccessfulRecords).HasColumnName("Successful_Records");
            entity.Property(e => e.TotalEntityRecords).HasColumnName("Total_Entity_Records");
            entity.Property(e => e.UnsuccessfulRecords).HasColumnName("Unsuccessful_Records");

            entity.HasOne(d => d.ImportIdFkNavigation).WithMany(p => p.ImportFileStatuses)
                .HasForeignKey(d => d.ImportIdFk)
                .HasConstraintName("FK_Import_File_Status_ImportFiles");
        });

        modelBuilder.Entity<IndustryType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Industry__3214EC27A131C04C");

            entity.ToTable("Industry_Type");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<IngestionStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingestio__3214EC07666271ED");

            entity.ToTable("IngestionStatus");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CsvFileName).HasMaxLength(255);
            entity.Property(e => e.CurrentRange).HasMaxLength(255);
            entity.Property(e => e.DataRange).HasMaxLength(255);
            entity.Property(e => e.OperationId).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<IotDeviceMetric>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Iot_Devi__3214EC2762231470");

            entity.ToTable("Iot_Device_Metrics");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CurrentCpuUsagePercentage).HasColumnName("Current_CPU_Usage_Percentage");
            entity.Property(e => e.CurrentMemoryUsage).HasColumnName("Current_Memory_Usage");
            entity.Property(e => e.DeviceName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Device_Name");
            entity.Property(e => e.DockerDaemonVersion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Docker_Daemon_Version");
            entity.Property(e => e.HostUptimeDays).HasColumnName("Host_Uptime_Days");
            entity.Property(e => e.IotEdgeDaemonUptimeDays).HasColumnName("Iot_Edge_Daemon_Uptime_Days");
            entity.Property(e => e.IotEdgeDaemonVersion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Iot_Edge_Daemon_Version");
            entity.Property(e => e.NumberOfCpus).HasColumnName("Number_Of_CPUs");
            entity.Property(e => e.OsInfo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OS_Info");
        });

        modelBuilder.Entity<ItTestingTab1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("it_testing_tab1");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.CurrentTime).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Id)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.InstanceId)
                .IsUnicode(false)
                .HasColumnName("Instance_Id");
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.StatusCode).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStampDatetime)
                .IsUnicode(false)
                .HasColumnName("TimeStamp_datetime");
            entity.Property(e => e.TimeStampString)
                .IsUnicode(false)
                .HasColumnName("TimeStamp_string");
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<IttablesExportsDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AmountSap).HasColumnName("AMOUNT_SAP");
            entity.Property(e => e.CustomeridSap)
                .IsUnicode(false)
                .HasColumnName("CUSTOMERID_SAP");
            entity.Property(e => e.InstanceId)
                .IsUnicode(false)
                .HasColumnName("Instance_Id");
            entity.Property(e => e.MaxOdbc).HasColumnName("MAX_ODBC");
            entity.Property(e => e.TagNamOdbc)
                .IsUnicode(false)
                .HasColumnName("TagNam_ODBC");
            entity.Property(e => e.TagName).IsUnicode(false);
        });

        modelBuilder.Entity<JobExecutionLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__JobExecu__9E2397E0069B7D6F");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.ExecutedAt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("executed_at");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TriggerId).HasColumnName("trigger_id");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("trigger_name");

            entity.HasOne(d => d.Trigger).WithMany(p => p.JobExecutionLogs)
                .HasForeignKey(d => d.TriggerId)
                .HasConstraintName("FK_JobExecutionLogs_JobScheduling");
        });

        modelBuilder.Entity<KpiFormula>(entity =>
        {
            entity.HasKey(e => e.FId).HasName("PK__KPI_FORM__2C6EC7C385946F2B");

            entity.ToTable("KPI_FORMULA");

            entity.Property(e => e.FId).HasColumnName("F_ID");
            entity.Property(e => e.AcId).HasColumnName("AC_ID");
            entity.Property(e => e.FCreatedBy)
                .HasMaxLength(50)
                .HasColumnName("F_CreatedBy");
            entity.Property(e => e.FCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("F_CreationDate");
            entity.Property(e => e.FDescription)
                .HasMaxLength(500)
                .HasColumnName("F_Description");
            entity.Property(e => e.FDevloper)
                .HasMaxLength(500)
                .HasColumnName("F_Devloper");
            entity.Property(e => e.FIsGlobal).HasColumnName("F_IsGlobal");
            entity.Property(e => e.FName)
                .HasMaxLength(250)
                .HasColumnName("F_Name");
            entity.Property(e => e.FText)
                .HasMaxLength(500)
                .HasColumnName("F_Text");
            entity.Property(e => e.FUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("F_UpdatedBy");
            entity.Property(e => e.FUpdationDate)
                .HasColumnType("datetime")
                .HasColumnName("F_UpdationDate");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.KpiFMappedName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KPI_F_Mapped_Name");
            entity.Property(e => e.Sid).HasColumnName("SID");

            entity.HasOne(d => d.Ac).WithMany(p => p.KpiFormulas)
                .HasForeignKey(d => d.AcId)
                .HasConstraintName("FK_KPI_FORMULA_ASSET_CATEGORY");

            entity.HasOne(d => d.SidNavigation).WithMany(p => p.KpiFormulas)
                .HasForeignKey(d => d.Sid)
                .HasConstraintName("FK_KPI_FORMULA_System_Integrator");
        });

        modelBuilder.Entity<KpiFormulaVariableM2M>(entity =>
        {
            entity.HasKey(e => e.FvM2mId).HasName("PK__KPI_FORM__919B9BD09BE6FAC3");

            entity.ToTable("KPI_FORMULA_VARIABLE_M_2_M");

            entity.Property(e => e.FvM2mId).HasColumnName("FV_M2M_ID");
            entity.Property(e => e.FId).HasColumnName("F_ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.VId).HasColumnName("V_ID");

            entity.HasOne(d => d.FIdNavigation).WithMany(p => p.KpiFormulaVariableM2Ms)
                .HasForeignKey(d => d.FId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KPI_FORMULA_VARIABLE_M_2_M_KPI_FORMULA");

            entity.HasOne(d => d.VIdNavigation).WithMany(p => p.KpiFormulaVariableM2Ms)
                .HasForeignKey(d => d.VId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KPI_FORMULA_VARIABLE_M_2_M_VARIABLE");
        });

        modelBuilder.Entity<KpiSFormulaAttachment>(entity =>
        {
            entity.HasKey(e => e.FaId).HasName("PK__KPI'S_FO__4C1ADB3BB9E7D98A");

            entity.ToTable("KPI'S_FORMULA_ATTACHMENT");

            entity.Property(e => e.FaId).HasColumnName("FA_ID");
            entity.Property(e => e.FId).HasColumnName("F_ID");
            entity.Property(e => e.FaDescription)
                .HasMaxLength(500)
                .HasColumnName("FA_Description");
            entity.Property(e => e.FaName)
                .HasMaxLength(200)
                .HasColumnName("FA_Name");
            entity.Property(e => e.FaUrl)
                .HasMaxLength(250)
                .HasColumnName("FA_URL");

            entity.HasOne(d => d.FIdNavigation).WithMany(p => p.KpiSFormulaAttachments)
                .HasForeignKey(d => d.FId)
                .HasConstraintName("FK_KPI'S_FORMULA_ATTACHMENT_KPI_FORMULA");
        });

        modelBuilder.Entity<KpieIpTagsDatum>(entity =>
        {
            entity.HasKey(e => e.TagDataId).HasName("PK_KPIE_Tags_Data");

            entity.ToTable("KPIE_IP_Tags_Data");

            entity.Property(e => e.TagDataId).HasColumnName("Tag_Data_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.CalTagIdFk).HasColumnName("Cal_Tag_Id_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ManTagIdFk).HasColumnName("Man_Tag_Id_FK");
            entity.Property(e => e.RealTagIdFk).HasColumnName("Real_Tag_Id_FK");
            entity.Property(e => e.TagVariableIdFk).HasColumnName("Tag_Variable_Id_FK");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<KpieIpTagsParameter>(entity =>
        {
            entity.HasKey(e => e.TagVariableId).HasName("PK_KPIE_Tags_Parameters");

            entity.ToTable("KPIE_IP_Tags_Parameters");

            entity.Property(e => e.TagVariableId).HasColumnName("Tag_Variable_Id");
            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("Asset_CategoryId_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.Unit).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
            entity.Property(e => e.VariableDescription).HasColumnName("Variable_Description");
            entity.Property(e => e.VariableName).HasColumnName("Variable_Name");
        });

        modelBuilder.Entity<LogDetail>(entity =>
        {
            entity.Property(e => e.LogIdFk).HasColumnName("LogId_FK");
        });

        modelBuilder.Entity<LogEvent>(entity =>
        {
            entity.Property(e => e.EventDescription).HasMaxLength(200);
            entity.Property(e => e.EventName).HasMaxLength(100);
        });

        modelBuilder.Entity<ManualFixPoint>(entity =>
        {
            entity.HasKey(e => e.MfId);

            entity.ToTable("Manual_Fix_Points");

            entity.Property(e => e.MfId).HasColumnName("MF_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_date");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MfMappedName)
                .HasMaxLength(250)
                .HasColumnName("MF_Mapped_Name");
            entity.Property(e => e.MfTagName)
                .HasMaxLength(250)
                .HasColumnName("MF_Tag_Name");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.Type).HasMaxLength(250);
            entity.Property(e => e.Unit).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_date");

            entity.HasOne(d => d.AssetIdFkNavigation).WithMany(p => p.ManualFixPoints)
                .HasForeignKey(d => d.AssetIdFk)
                .HasConstraintName("FK_Manual_Fix_Points_Assets");
        });

        modelBuilder.Entity<ManualFixPointsHistory>(entity =>
        {
            entity.HasKey(e => e.MfId);

            entity.ToTable("Manual_Fix_Points_History");

            entity.Property(e => e.MfId).HasColumnName("MF_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_date");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.HistoryType)
                .HasMaxLength(500)
                .HasColumnName("History_Type");
            entity.Property(e => e.MfTagName)
                .HasMaxLength(250)
                .HasColumnName("MF_Tag_Name");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Time_Stamp");
            entity.Property(e => e.Type).HasMaxLength(250);
            entity.Property(e => e.Unit).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy)
                .HasColumnType("datetime")
                .HasColumnName("Updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_date");
        });

        modelBuilder.Entity<ModBusDeviceTagsImportStatus>(entity =>
        {
            entity.ToTable("ModBusDeviceTagsImportStatus");

            entity.Property(e => e.ImportEndDate).HasColumnType("datetime");
            entity.Property(e => e.ImportStartDate).HasColumnType("datetime");

            entity.HasOne(d => d.DeviceIdFkNavigation).WithMany(p => p.ModBusDeviceTagsImportStatuses)
                .HasForeignKey(d => d.DeviceIdFk)
                .HasConstraintName("FK_ModBusDeviceTagsImportStatus_Devices");
        });

        modelBuilder.Entity<ModelTrainingType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModelTra__3214EC0764E2B3E2");

            entity.ToTable("ModelTrainingType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Mtd>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("PK__MTD__B9DCB903EA33DB5F");

            entity.ToTable("MTD");

            entity.Property(e => e.SiteId)
                .ValueGeneratedNever()
                .HasColumnName("SiteID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<None>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("None");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<NotificationCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Notifica__19093A0B9F142D7B");

            entity.ToTable("NotificationCategory");

            entity.Property(e => e.CategoryName).IsUnicode(false);
        });

        modelBuilder.Entity<NotificationComponent>(entity =>
        {
            entity.HasKey(e => e.ComponentId).HasName("PK__Notifica__D79CF04EEC839B5B");

            entity.ToTable("NotificationComponent");

            entity.Property(e => e.ComponentName).IsUnicode(false);

            entity.HasOne(d => d.CategoryIdFkNavigation).WithMany(p => p.NotificationComponents)
                .HasForeignKey(d => d.CategoryIdFk)
                .HasConstraintName("FK_NotificationComponent.CategoryIdFk");
        });

        modelBuilder.Entity<NotificationEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Notifica__7944C81073765D5B");

            entity.Property(e => e.EventName).IsUnicode(false);

            entity.HasOne(d => d.ComponentIdFkNavigation).WithMany(p => p.NotificationEvents)
                .HasForeignKey(d => d.ComponentIdFk)
                .HasConstraintName("FK_NotificationEvents.ComponentIdFk");
        });

        modelBuilder.Entity<NotificationEventsConfigM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notifica__3214EC0722F57882");

            entity.ToTable("NotificationEventsConfigM2M");

            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.DataAlarmIdFkNavigation).WithMany(p => p.NotificationEventsConfigM2ms)
                .HasForeignKey(d => d.DataAlarmIdFk)
                .HasConstraintName("FK_NotificationEventsConfigM2M_DATA_ALARM");

            entity.HasOne(d => d.EventIdFkNavigation).WithMany(p => p.NotificationEventsConfigM2ms)
                .HasForeignKey(d => d.EventIdFk)
                .HasConstraintName("FK_NotificationEventsConfigM2M.EventIdFk");

            entity.HasOne(d => d.GroupIdFkNavigation).WithMany(p => p.NotificationEventsConfigM2ms)
                .HasForeignKey(d => d.GroupIdFk)
                .HasConstraintName("FK_NotificationEventsConfigM2M.GroupIdFk");
        });

        modelBuilder.Entity<Nozzel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__nozzel__3213E83FC91C3254");

            entity.ToTable("nozzel");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NozzelId).HasColumnName("NozzelID");
            entity.Property(e => e.PumpId).HasColumnName("PumpID");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.TankId).HasColumnName("TankID");
        });

        modelBuilder.Entity<NtwManualEntryCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NTW_Manu__3214EC271DDE4D65");

            entity.ToTable("NTW_Manual_Entry_Count");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aycount).HasColumnName("AYcount");
            entity.Property(e => e.CbPmcount).HasColumnName("CbPMcount");
            entity.Property(e => e.Clcount).HasColumnName("CLcount");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Gfcount).HasColumnName("GFcount");
            entity.Property(e => e.Totalcount).HasColumnName("TOTALcount");
        });

        modelBuilder.Entity<NtwManualEntryExtra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NTW_Manu__3214EC2779C48B6F");

            entity.ToTable("NTW_Manual_Entry_Extra");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AverageSpecloss).HasColumnName("Average_specloss");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DailyCountSpecloss).HasColumnName("Daily_count_specloss");
            entity.Property(e => e.DailyCountSpeclossBlend).HasColumnName("Daily_count_specloss_blend");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TotalSpecloss).HasColumnName("Total_specloss");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<NtwManualEntrySpecloss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NTW_Manu__3214EC279D5E704A");

            entity.ToTable("NTW_Manual_Entry_Specloss");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ayloss).HasColumnName("AYloss");
            entity.Property(e => e.CbPmloss).HasColumnName("CbPMloss");
            entity.Property(e => e.Clloss).HasColumnName("CLloss");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Gfloss).HasColumnName("GFloss");
            entity.Property(e => e.Totalloss).HasColumnName("TOTALloss");
        });

        modelBuilder.Entity<OdlProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__ODL_Prod__B40CC6CD0BCCD98B");

            entity.ToTable("ODL_Product");

            entity.Property(e => e.ProductName)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OmniAgentMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__omniAgen__3214EC077FB9DDB2");

            entity.ToTable("omniAgent_Messages");

            entity.Property(e => e.ChannelPartner).HasColumnName("channel_partner");
            entity.Property(e => e.ChatTitle).HasColumnName("Chat_Title");
            entity.Property(e => e.CustomerName).HasColumnName("customer_name");
            entity.Property(e => e.MessageId).HasColumnName("Message_Id");
            entity.Property(e => e.ResponseId).HasColumnName("Response_Id");
            entity.Property(e => e.SiteIdFk).HasColumnName("site_id_fk");
            entity.Property(e => e.SiteName).HasColumnName("site_name");
            entity.Property(e => e.StateDe).HasColumnName("State_DE");
            entity.Property(e => e.ThreadId).HasColumnName("Thread_Id");
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<OmniAgentToolCall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__omniAgen__3214EC076D39590E");

            entity.ToTable("omniAgent_ToolCalls");

            entity.Property(e => e.CallId).HasColumnName("Call_Id");
            entity.Property(e => e.ResponseId).HasColumnName("Response_Id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.ThreadId).HasColumnName("Thread_Id");
            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.ToolCallId).HasColumnName("toolCall_Id");
            entity.Property(e => e.ToolName).HasColumnName("tool_name");
        });

        modelBuilder.Entity<OmniFintechSiteMapping>(entity =>
        {
            entity.ToTable("Omni_Fintech_SiteMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FcSiteId).HasColumnName("FC_SiteID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OmniSiteId).HasColumnName("Omni_SiteID");
        });

        modelBuilder.Entity<OmniFintechTankMapping>(entity =>
        {
            entity.ToTable("Omni_Fintech_TankMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FcSiteId).HasColumnName("FC_SiteID");
            entity.Property(e => e.FcTankId).HasColumnName("FC_TankID");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasColumnType("datetime");
            entity.Property(e => e.OmniAssetId).HasColumnName("Omni_AssetID");
            entity.Property(e => e.OmniSiteId).HasColumnName("Omni_SiteID");
            entity.Property(e => e.ProdIdFk).HasColumnName("ProdID_FK");
        });

        modelBuilder.Entity<OpcQualityCode>(entity =>
        {
            entity.HasKey(e => e.ScId).HasName("PK__OPC_Qual__C402E57E7CC0BDC3");

            entity.ToTable("OPC_QualityCode");

            entity.Property(e => e.ScId).HasColumnName("SC_Id");
            entity.Property(e => e.ScTitle)
                .HasMaxLength(200)
                .HasColumnName("SC_Title");
        });

        modelBuilder.Entity<OpcQualityCodetType>(entity =>
        {
            entity.HasKey(e => e.SctId).HasName("PK__OPC_Qual__68F019D4E93C94AF");

            entity.ToTable("OPC_QualityCodetTypes");

            entity.Property(e => e.SctId).HasColumnName("SCT_Id");
            entity.Property(e => e.ScId).HasColumnName("SC_Id");
            entity.Property(e => e.SctTitle)
                .HasMaxLength(200)
                .HasColumnName("SCT_Title");

            entity.HasOne(d => d.Sc).WithMany(p => p.OpcQualityCodetTypes)
                .HasForeignKey(d => d.ScId)
                .HasConstraintName("FK_OPC_QualityCodetTypes_OPC_QualityCode");
        });

        modelBuilder.Entity<OpcQualityCodetTypesDataAlarmM2m>(entity =>
        {
            entity.ToTable("OPC_QualityCodetTypes_DATA_ALARM_M2M");

            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SctId).HasColumnName("SCT_Id");

            entity.HasOne(d => d.DataAlarm).WithMany(p => p.OpcQualityCodetTypesDataAlarmM2ms)
                .HasForeignKey(d => d.DataAlarmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OPC_QualityCodetTypes_DATA_ALARM_M2M_DATA_ALARM");

            entity.HasOne(d => d.Sct).WithMany(p => p.OpcQualityCodetTypesDataAlarmM2ms)
                .HasForeignKey(d => d.SctId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OPC_QualityCodetTypes_DATA_ALARM_M2M_OPC_QualityCodetTypes");
        });

        modelBuilder.Entity<OpcServerConfig>(entity =>
        {
            entity.ToTable("OPC_Server_Config");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OpcPassword).HasColumnName("OPC_Password");
            entity.Property(e => e.OpcSecurity).HasColumnName("OPC_Security");
            entity.Property(e => e.OpcServerAddress).HasColumnName("OPC_Server_Address");
            entity.Property(e => e.OpcUsername).HasColumnName("OPC_Username");
        });

        modelBuilder.Entity<OpcSourceTag>(entity =>
        {
            entity.HasKey(e => e.SourceTagId);

            entity.ToTable("OPC_SourceTags");

            entity.HasIndex(e => new { e.SiteSpecificDeviceId, e.IsValid, e.SiteIdFk }, "nci_wi_OPC_SourceTags_734623396A398C3E5512104F768C298C");

            entity.Property(e => e.SourceTagId).HasColumnName("Source_Tag_Id");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DlTagId).HasColumnName("DL_Tag_Id");
            entity.Property(e => e.HeartBeatRate).HasColumnName("Heart_Beat_Rate");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsValid).HasDefaultValue(true);
            entity.Property(e => e.OpcServerId).HasColumnName("OPC_Server_Id");
            entity.Property(e => e.PublishRate).HasColumnName("Publish_Rate");
            entity.Property(e => e.ScanRate).HasColumnName("Scan_Rate");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site__Id_FK");
            entity.Property(e => e.SiteSpecificDeviceId).HasColumnName("site_specific_device_id");
            entity.Property(e => e.SourceTagName).HasColumnName("Source_Tag_Name");
            entity.Property(e => e.SourceTagParametersId).HasColumnName("Source_Tag_Parameters_Id");
            entity.Property(e => e.TagType)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Tag_Type");
            entity.Property(e => e.Unit).HasColumnName("UNIT");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OpcSourceTagsCm>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__OPC_Sour__208BDB6085DFA1B5");

            entity.ToTable("OPC_SourceTags_CM");

            entity.Property(e => e.EventId).HasColumnName("Event_Id");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EntryType).HasColumnName("Entry_Type");
            entity.Property(e => e.EventLog).HasColumnName("Event_Log");
            entity.Property(e => e.HeartBeatRate).HasColumnName("Heart_Beat_Rate");
            entity.Property(e => e.PublishRate).HasColumnName("Publish_Rate");
            entity.Property(e => e.ScanRate).HasColumnName("Scan_Rate");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site__Id_FK");
            entity.Property(e => e.SiteSpecificDeviceId).HasColumnName("site_specific_device_id");
            entity.Property(e => e.SiteSpecificEventId).HasColumnName("Site_Specific_Event_ID");
            entity.Property(e => e.SourceTagIdFk).HasColumnName("Source_Tag_Id_Fk");
            entity.Property(e => e.SourceTagName).HasColumnName("Source_Tag_Name");
            entity.Property(e => e.Unit).HasColumnName("UNIT");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.SiteSpecificDevice).WithMany(p => p.OpcSourceTagsCms)
                .HasForeignKey(d => d.SiteSpecificDeviceId)
                .HasConstraintName("FK_OPC_SourceTags_CM_Devices");

            entity.HasOne(d => d.SourceTagIdFkNavigation).WithMany(p => p.OpcSourceTagsCms)
                .HasForeignKey(d => d.SourceTagIdFk)
                .HasConstraintName("FK_OPC_SourceTags_CM_OPC_SourceTags");
        });

        modelBuilder.Entity<OpcSourceTagsDummy>(entity =>
        {
            entity.HasKey(e => e.SourceTagId);

            entity.ToTable("OPC_SourceTags_Dummy");

            entity.Property(e => e.SourceTagId).HasColumnName("Source_Tag_Id");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.HeartBeatRate).HasColumnName("Heart_Beat_Rate");
            entity.Property(e => e.PublishRate).HasColumnName("Publish_Rate");
            entity.Property(e => e.ScanRate).HasColumnName("Scan_Rate");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site__Id_FK");
            entity.Property(e => e.SourceTagName).HasColumnName("Source_Tag_Name");
            entity.Property(e => e.Unit).HasColumnName("UNIT");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OpenAiconfigurationHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OpenAICo__3214EC07FE75A2B3");

            entity.ToTable("OpenAIConfigurationHistory");

            entity.Property(e => e.EventType).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<OpenAifileHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07174B2466");

            entity.ToTable("OpenAIFileHistory");

            entity.Property(e => e.FileId).HasMaxLength(255);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.FileSize).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<OtLongDataPattern>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OT_LongData_pattern");

            entity.Property(e => e.TagName).HasMaxLength(100);
        });

        modelBuilder.Entity<OtLongDataTest12>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OT_LongData_test12");

            entity.Property(e => e.Site)
                .HasMaxLength(100)
                .HasDefaultValue("site a")
                .HasColumnName("site");
            entity.Property(e => e.TagName).HasMaxLength(100);
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasDefaultValue("ms")
                .HasColumnName("unit");
        });

        modelBuilder.Entity<OtLongDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OT_LongData");

            entity.Property(e => e.Site)
                .HasMaxLength(100)
                .HasDefaultValue("site a")
                .HasColumnName("site");
            entity.Property(e => e.TagName).HasMaxLength(100);
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasDefaultValue("ms")
                .HasColumnName("unit");
        });

        modelBuilder.Entity<OtTimeTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ot_time_test");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<OtWidedata1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OT_widedata1");

            entity.Property(e => e.Moderator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("moderator");
            entity.Property(e => e.Sc1Val).HasColumnName("SC1_Val");
            entity.Property(e => e.Sc2Val).HasColumnName("SC2_Val");
            entity.Property(e => e.Sc3Val).HasColumnName("SC3_Val");
        });

        modelBuilder.Entity<OtWidedata2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OT_widedata2");

            entity.Property(e => e.Sc1Val).HasColumnName("SC1_Val");
            entity.Property(e => e.Sc2Val).HasColumnName("SC2_Val");
        });

        modelBuilder.Entity<OtWidedata3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OT_widedata3");

            entity.Property(e => e.Moderator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("moderator");
            entity.Property(e => e.Sc1Val).HasColumnName("SC1_Val");
            entity.Property(e => e.Sc2Val).HasColumnName("SC2_Val");
            entity.Property(e => e.Sc3Val).HasColumnName("SC3_Val");
        });

        modelBuilder.Entity<OtWidedatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OT_widedata");

            entity.Property(e => e.Sc1Val).HasColumnName("SC1_Val");
            entity.Property(e => e.Sc2Val).HasColumnName("SC2_Val");
            entity.Property(e => e.Sc3Val).HasColumnName("SC3_Val");
        });

        modelBuilder.Entity<OutputTagDatum>(entity =>
        {
            entity.HasKey(e => e.OutputTagId);

            entity.ToTable("Output_Tag_Data");

            entity.Property(e => e.OutputTagId).HasColumnName("Output_Tag_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.CalTagIdFk).HasColumnName("Cal_Tag_Id_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.OutputParameterIdFk).HasColumnName("Output_Parameter_Id_FK");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<OutputTagParameter>(entity =>
        {
            entity.HasKey(e => e.OutputParameterId);

            entity.ToTable("Output_Tag_Parameters");

            entity.Property(e => e.OutputParameterId).HasColumnName("Output_Parameter_Id");
            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("Asset_CategoryId_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.ParameterDescription).HasColumnName("Parameter_Description");
            entity.Property(e => e.ParameterName).HasColumnName("Parameter_Name");
            entity.Property(e => e.Unit).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__Permissi__EFA6FB2F483EBB54");

            entity.ToTable("Permission");

            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.PermissionCategoryId).HasColumnName("PermissionCategoryID");
            entity.Property(e => e.PermissionName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PermissionNameAlias)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ProductIdFk).HasColumnName("ProductId_FK");

            entity.HasOne(d => d.ProductIdFkNavigation).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.ProductIdFk)
                .HasConstraintName("FK__Permissio__Produ__69B26EB3");
        });

        modelBuilder.Entity<PermissionCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permissi__3214EC27BBF9870F");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PhysicalAssetProperty>(entity =>
        {
            entity.HasKey(e => e.PapId);

            entity.ToTable("Physical_Asset_Properties");

            entity.Property(e => e.PapId).HasColumnName("PAP_Id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.PropertyName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");
        });

        modelBuilder.Entity<PipeLineTag>(entity =>
        {
            entity.HasKey(e => e.PltagsId).HasName("PK__PipeLine__79D01BEF2D10AC27");

            entity.Property(e => e.PltagsId).HasColumnName("PLtagsId");
            entity.Property(e => e.DataTypeIdFk).HasColumnName("DataTypeID_FK");
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.DataTypeIdFkNavigation).WithMany(p => p.PipeLineTags)
                .HasForeignKey(d => d.DataTypeIdFk)
                .HasConstraintName("FK_PipeLineTags_TagsDataType");

            entity.HasOne(d => d.PipeLine).WithMany(p => p.PipeLineTags)
                .HasForeignKey(d => d.PipeLineId)
                .HasConstraintName("FK_PipeLineTags_ExportPipeLine");
        });

        modelBuilder.Entity<PlantSite>(entity =>
        {
            entity.HasKey(e => e.SiteId);

            entity.ToTable("Plant_Site", tb =>
                {
                    tb.HasTrigger("insert_site_to_ReadApiLimiter_table");
                    tb.HasTrigger("trg_AddSiteToReadAPILimits_V1");
                    tb.HasTrigger("update_Site_Name_ReadApiLimiter_table");
                });

            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.AdxRegion)
                .HasMaxLength(200)
                .HasColumnName("adx_region");
            entity.Property(e => e.AutomationTableName).HasMaxLength(250);
            entity.Property(e => e.BulkConnectionStringStatus).HasDefaultValue(false);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.CustomerIdFk).HasColumnName("Customer_Id_FK");
            entity.Property(e => e.Deadband).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EhConnection)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("EH_Connection");
            entity.Property(e => e.GeographicalLocation)
                .HasMaxLength(500)
                .HasColumnName("Geographical_Location");
            entity.Property(e => e.IndustryType).HasColumnName("Industry_Type");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsProductionEnv).HasColumnName("IsProductionENV");
            entity.Property(e => e.OriginalSiteName).HasMaxLength(250);
            entity.Property(e => e.Region)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RequestedSubId).HasColumnName("Requested_Sub_ID");
            entity.Property(e => e.RowV)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.SiteName)
                .HasMaxLength(250)
                .HasColumnName("Site_Name");
            entity.Property(e => e.SubId).HasColumnName("Sub_Id");
            entity.Property(e => e.TimeZone)
                .HasMaxLength(50)
                .HasColumnName("Time_Zone");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");

            entity.HasOne(d => d.CustomerIdFkNavigation).WithMany(p => p.PlantSites)
                .HasForeignKey(d => d.CustomerIdFk)
                .HasConstraintName("FK_Plant_Site_Customer");

            entity.HasOne(d => d.Sub).WithMany(p => p.PlantSites)
                .HasForeignKey(d => d.SubId)
                .HasConstraintName("FK__Plant_Sit__Sub_I__047AA831");
        });

        modelBuilder.Entity<PlantSiteEmailTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlantSit__3214EC278257941F");

            entity.ToTable("PlantSiteEmailTracking");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmailSent).HasDefaultValue(false);
            entity.Property(e => e.IsSiteCreated).HasDefaultValue(false);
            entity.Property(e => e.SiteIdFk).HasColumnName("SiteId_Fk");
        });

        modelBuilder.Entity<ProcessAlarm>(entity =>
        {
            entity.HasKey(e => e.ProcessAlarmId).HasName("PK__PROCESS___D0DE65633E3053E9");

            entity.ToTable("PROCESS_ALARM");

            entity.Property(e => e.ProcessAlarmId).HasColumnName("ProcessAlarm_ID");
            entity.Property(e => e.AExpirationTime)
                .HasColumnType("datetime")
                .HasColumnName("A_ExpirationTime");
            entity.Property(e => e.AName)
                .HasMaxLength(200)
                .HasColumnName("A_Name");
            entity.Property(e => e.AStartTime)
                .HasColumnType("datetime")
                .HasColumnName("A_StartTime");
            entity.Property(e => e.CTagId).HasColumnName("C_Tag_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.RealTagId).HasColumnName("Real_Tag_Id");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CTag).WithMany(p => p.ProcessAlarms)
                .HasForeignKey(d => d.CTagId)
                .HasConstraintName("FK__PROCESS_A__C_Tag__65C116E7");

            entity.HasOne(d => d.RealTag).WithMany(p => p.ProcessAlarms)
                .HasForeignKey(d => d.RealTagId)
                .HasConstraintName("FK__PROCESS_A__Real___64CCF2AE");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__47027DF5CD41D750");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("product_id");
            entity.Property(e => e.ProductName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("product_name");
        });

        modelBuilder.Entity<Pump>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pumps__3213E83FDF14153D");

            entity.ToTable("pumps");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Pumpid).HasColumnName("pumpid");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.Tankid).HasColumnName("tankid");
        });

        modelBuilder.Entity<QualityManualEntryFibexDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quality___3214EC2754693B1F");

            entity.ToTable("Quality_Manual_Entry_Fibex_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Dr).HasColumnName("DR");
            entity.Property(e => e.Fv).HasColumnName("FV");
            entity.Property(e => e.Mc).HasColumnName("MC");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Opno)
                .HasMaxLength(50)
                .HasColumnName("OPNo");
        });

        modelBuilder.Entity<QualityManualEntryMoistureContentFilledValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quality___3214EC27C926A620");

            entity.ToTable("Quality_Manual_Entry_MoistureContent_FilledValue");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Blend).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ExCpsSiloDr).HasColumnName("Ex_CPS_SIlo_DR");
            entity.Property(e => e.ExCpsSiloFv).HasColumnName("Ex_CPS_SIlo_FV");
            entity.Property(e => e.ExCpsSiloMc).HasColumnName("Ex_CPS_SIlo_MC");
            entity.Property(e => e.ExDryerDr).HasColumnName("Ex_Dryer_DR");
            entity.Property(e => e.ExDryerFv).HasColumnName("Ex_Dryer_FV");
            entity.Property(e => e.ExDryerMc).HasColumnName("Ex_Dryer_MC");
            entity.Property(e => e.FeederDr).HasColumnName("Feeder_DR");
            entity.Property(e => e.FeederFv).HasColumnName("Feeder_FV");
            entity.Property(e => e.FeederMc).HasColumnName("Feeder_MC");
            entity.Property(e => e.FpSilosDr).HasColumnName("FP_SIlos_DR");
            entity.Property(e => e.FpSilosFv).HasColumnName("FP_SIlos_FV");
            entity.Property(e => e.FpSilosMc).HasColumnName("FP_SIlos_MC");
            entity.Property(e => e.LcMc).HasColumnName("LC_MC");
            entity.Property(e => e.MakerDr).HasColumnName("Maker_DR");
            entity.Property(e => e.MakerFv).HasColumnName("Maker_FV");
            entity.Property(e => e.MakerMc).HasColumnName("Maker_MC");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScMc).HasColumnName("SC_MC");
            entity.Property(e => e.Shift).HasMaxLength(10);
        });

        modelBuilder.Entity<QualityManualEntryNtw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quality___3214EC271F011A6E");

            entity.ToTable("Quality_Manual_Entry_NTW");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Brand).HasMaxLength(10);
            entity.Property(e => e.CigWt).HasColumnName("Cig_Wt");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Module).HasMaxLength(10);
            entity.Property(e => e.Ntc).HasColumnName("NTC");
            entity.Property(e => e.Ntw).HasColumnName("NTW");
            entity.Property(e => e.Shift).HasMaxLength(10);
            entity.Property(e => e.TargetNtw).HasColumnName("Target_NTW");
            entity.Property(e => e.TimeSelection)
                .HasColumnType("datetime")
                .HasColumnName("Time_Selection");
        });

        modelBuilder.Entity<QualityManualNtwConstantValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quality___3214EC27944D77BE");

            entity.ToTable("Quality_Manual_NTW_Constant_Values");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TargetAy).HasColumnName("Target_AY");
            entity.Property(e => e.TargetCbpm).HasColumnName("Target_CBPM");
            entity.Property(e => e.TargetCl).HasColumnName("Target_CL");
            entity.Property(e => e.TargetGf).HasColumnName("Target_GF");
        });

        modelBuilder.Entity<RawTagTarget>(entity =>
        {
            entity.HasKey(e => e.RawTagTergetId);

            entity.ToTable("Raw_Tag_Targets");

            entity.Property(e => e.RawTagTergetId).HasColumnName("Raw_Tag_Terget_Id");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.RawTargetMapped).HasMaxLength(100);
            entity.Property(e => e.RealTagIdFk).HasColumnName("Real_Tag_Id_FK");
            entity.Property(e => e.RtargetMaxMapped)
                .HasMaxLength(100)
                .HasColumnName("RTargetMaxMapped");
            entity.Property(e => e.RtargetMinMapped)
                .HasMaxLength(100)
                .HasColumnName("RTargetMinMapped");
            entity.Property(e => e.TargetMaxValue).HasColumnName("Target_Max_Value");
            entity.Property(e => e.TargetMinValue).HasColumnName("Target_Min_Value");
            entity.Property(e => e.TargetValue).HasColumnName("Target_Value");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.RealTagIdFkNavigation).WithMany(p => p.RawTagTargets)
                .HasForeignKey(d => d.RealTagIdFk)
                .HasConstraintName("FK_Raw_Tag_Targets_Real_Raw_Points");
        });

        modelBuilder.Entity<RawTagTargetMonYear>(entity =>
        {
            entity.ToTable("Raw_Tag_Target_Mon_Year");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.RealTagIdFk).HasColumnName("Real_Tag_Id_FK");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");

            entity.HasOne(d => d.RealTagIdFkNavigation).WithMany(p => p.RawTagTargetMonYears)
                .HasForeignKey(d => d.RealTagIdFk)
                .HasConstraintName("FK_Raw_Tag_Target_Mon_Year_Real_Raw_Points");
        });

        modelBuilder.Entity<RawTagTargetMonYearHistory>(entity =>
        {
            entity.ToTable("Raw_Tag_Target_Mon_Year_History");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created_On");
            entity.Property(e => e.HistoryType)
                .HasMaxLength(50)
                .HasColumnName("History_Type");
            entity.Property(e => e.RealTagIdFk).HasColumnName("Real_Tag_Id_FK");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Time_Stamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Updated_On");
        });

        modelBuilder.Entity<RawTagsTargetsHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId);

            entity.ToTable("Raw_Tags_Targets_History");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.RawTargetMapped).HasMaxLength(100);
            entity.Property(e => e.RtargetMaxMapped)
                .HasMaxLength(100)
                .HasColumnName("RTargetMaxMapped");
            entity.Property(e => e.RtargetMinMapped)
                .HasMaxLength(100)
                .HasColumnName("RTargetMinMapped");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReadApiLimiter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tagTypeS__3214EC078F93D270");

            entity.ToTable("ReadApiLimiter", tb =>
                {
                    tb.HasTrigger("insert_site_to_ReadApiUsageAggregate_table");
                    tb.HasTrigger("update_Daily_Limit_Bytes_ReadApiLimiter_table");
                });

            entity.Property(e => e.BoolSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("Bool_Size_Avg");
            entity.Property(e => e.BoolSizeMax)
                .HasMaxLength(255)
                .HasColumnName("Bool_Size_Max");
            entity.Property(e => e.BoolSizeMin)
                .HasMaxLength(255)
                .HasColumnName("Bool_Size_Min");
            entity.Property(e => e.CalcSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("Calc_Size_Avg");
            entity.Property(e => e.CalcSizeMax)
                .HasMaxLength(255)
                .HasColumnName("Calc_Size_Max");
            entity.Property(e => e.CalcSizeMin)
                .HasMaxLength(255)
                .HasColumnName("Calc_Size_Min");
            entity.Property(e => e.CounterSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("Counter_Size_Avg");
            entity.Property(e => e.CounterSizeMax)
                .HasMaxLength(255)
                .HasColumnName("Counter_Size_Max");
            entity.Property(e => e.CounterSizeMin)
                .HasMaxLength(255)
                .HasColumnName("Counter_Size_Min");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.DailyLimitBytes).HasColumnName("Daily_Limit_Bytes");
            entity.Property(e => e.DailyLimitFactor).HasColumnName("Daily_Limit_Factor");
            entity.Property(e => e.GpsSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("GPS_Size_Avg");
            entity.Property(e => e.GpsSizeMax)
                .HasMaxLength(255)
                .HasColumnName("GPS_Size_Max");
            entity.Property(e => e.GpsSizeMin)
                .HasMaxLength(255)
                .HasColumnName("GPS_Size_Min");
            entity.Property(e => e.IngestionVolAvg)
                .HasMaxLength(255)
                .HasColumnName("Ingestion_Vol_Avg");
            entity.Property(e => e.IngestionVolMax)
                .HasMaxLength(255)
                .HasColumnName("Ingestion_Vol_Max");
            entity.Property(e => e.IngestionVolMin)
                .HasMaxLength(255)
                .HasColumnName("Ingestion_Vol_Min");
            entity.Property(e => e.IsDailyLimitUpdated).HasColumnName("is_Daily_Limit_Updated");
            entity.Property(e => e.LimitsModifiedBy).HasColumnName("Limits_Modified_By");
            entity.Property(e => e.LimitsModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("Limits_Modified_Date");
            entity.Property(e => e.ManSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("Man_Size_Avg");
            entity.Property(e => e.ManSizeMax)
                .HasMaxLength(255)
                .HasColumnName("Man_Size_Max");
            entity.Property(e => e.ManSizeMin)
                .HasMaxLength(255)
                .HasColumnName("Man_Size_Min");
            entity.Property(e => e.MaxDailyLimitFactor).HasColumnName("Max_Daily_Limit_Factor");
            entity.Property(e => e.RawSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("Raw_Size_Avg");
            entity.Property(e => e.RawSizeMax)
                .HasMaxLength(255)
                .HasColumnName("Raw_Size_Max");
            entity.Property(e => e.RawSizeMin)
                .HasMaxLength(255)
                .HasColumnName("Raw_Size_Min");
            entity.Property(e => e.SiteIdFk).HasColumnName("site_id_fk");
            entity.Property(e => e.SiteName)
                .HasMaxLength(255)
                .HasColumnName("Site_Name");
            entity.Property(e => e.StringSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("String_Size_Avg");
            entity.Property(e => e.StringSizeMax)
                .HasMaxLength(255)
                .HasColumnName("String_Size_Max");
            entity.Property(e => e.StringSizeMin)
                .HasMaxLength(255)
                .HasColumnName("String_Size_Min");
            entity.Property(e => e.TimeSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("Time_Size_Avg");
            entity.Property(e => e.TimeSizeMax)
                .HasMaxLength(255)
                .HasColumnName("Time_Size_Max");
            entity.Property(e => e.TimeSizeMin)
                .HasMaxLength(255)
                .HasColumnName("Time_Size_Min");
            entity.Property(e => e.TimerSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("Timer_Size_Avg");
            entity.Property(e => e.TimerSizeMax)
                .HasMaxLength(255)
                .HasColumnName("Timer_Size_Max");
            entity.Property(e => e.TimerSizeMin)
                .HasMaxLength(255)
                .HasColumnName("Timer_Size_Min");
            entity.Property(e => e.TotalizerSizeAvg)
                .HasMaxLength(255)
                .HasColumnName("Totalizer_Size_Avg");
            entity.Property(e => e.TotalizerSizeMax)
                .HasMaxLength(255)
                .HasColumnName("Totalizer_Size_Max");
            entity.Property(e => e.TotalizerSizeMin)
                .HasMaxLength(255)
                .HasColumnName("Totalizer_Size_Min");
            entity.Property(e => e.UpdatedTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("Updated_Time");
        });

        modelBuilder.Entity<ReadApiLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__ReadApiL__5E5499A852704FF4");

            entity.ToTable("ReadApiLog");

            entity.HasIndex(e => new { e.SiteName, e.CustomerName, e.Timestamp, e.ApxFlag }, "IX_ReadApiLog_Site_Cust_Time_APX_SizeBytes");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.ApxFlag).HasColumnName("apx_Flag");
            entity.Property(e => e.CustomerName).HasMaxLength(255);
            entity.Property(e => e.DataFrameShape).HasMaxLength(255);
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.ItemNamesRequest).HasColumnName("_item_names_request");
            entity.Property(e => e.ResponseSizeBytes).HasMaxLength(255);
            entity.Property(e => e.SiteName).HasMaxLength(255);
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.TagType).HasColumnName("tag_type");
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<ReadApiLogArchiveDailyCountTotal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReadApiL__3214EC075F374FDF");

            entity.ToTable("ReadApiLog_Archive_Daily_Count_Total");

            entity.Property(e => e.ApxFlag).HasColumnName("apx_Flag");
            entity.Property(e => e.UpdatedTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("Updated_Time");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ReadApiLogArchiveDailySizeTotal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReadApiL__3214EC072154B0D0");

            entity.ToTable("ReadApiLog_Archive_Daily_Size_Total");

            entity.Property(e => e.ApxFlag).HasColumnName("apx_Flag");
            entity.Property(e => e.UpdatedTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("Updated_Time");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ReadApiLogArchiveMinLimitBreach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReadApiL__3214EC07421C810E");

            entity.ToTable("ReadApiLog_Archive_Min_Limit_Breaches");

            entity.Property(e => e.ApxFlag).HasColumnName("apx_Flag");
            entity.Property(e => e.Minute).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ReadApiUsageAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReadApiU__3214EC072A219542");

            entity.ToTable("ReadApiUsageAggregate");

            entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");
            entity.Property(e => e.SiteIdFk).HasColumnName("site_id_fk");
            entity.Property(e => e.SiteName).HasColumnName("Site_Name");
            entity.Property(e => e.TotalDataRead).HasColumnName("Total_Data_Read");
            entity.Property(e => e.UpdatedTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("Updated_Time");
        });

        modelBuilder.Entity<ReadApilimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReadAPIL__3214EC07F3C73321");

            entity.ToTable("ReadAPILimits");

            entity.HasIndex(e => new { e.CustomerName, e.SiteName, e.UserAccessLevel }, "UQ__ReadAPIL__B5CDE85A5D9E4119").IsUnique();

            entity.Property(e => e.CustomerName).HasMaxLength(255);
            entity.Property(e => e.SiteName).HasMaxLength(255);
        });

        modelBuilder.Entity<ReadapiPayload>(entity =>
        {
            entity.HasKey(e => e.OrchestratorId).HasName("PK_orchestrator");

            entity.ToTable("readapi_payload");

            entity.Property(e => e.OrchestratorId)
                .HasMaxLength(200)
                .HasColumnName("orchestrator_id");
            entity.Property(e => e.CustomerName).HasColumnName("customer_name");
            entity.Property(e => e.EndDatetime).HasColumnName("end_datetime");
            entity.Property(e => e.EndDatetimeUpdated)
                .IsUnicode(false)
                .HasColumnName("end_datetime_updated");
            entity.Property(e => e.ItemNames).HasColumnName("item_names");
            entity.Property(e => e.ItemType)
                .HasMaxLength(100)
                .HasColumnName("item_type");
            entity.Property(e => e.ProductionDatabase).HasColumnName("production_database");
            entity.Property(e => e.ResponseFormat)
                .HasMaxLength(50)
                .HasColumnName("response_format");
            entity.Property(e => e.SiteName).HasColumnName("site_name");
            entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");
            entity.Property(e => e.StartDatetimeUpdated)
                .IsUnicode(false)
                .HasColumnName("start_datetime_updated");
            entity.Property(e => e.StatusCode).HasColumnName("status_code");
            entity.Property(e => e.StatusQueryUri).HasColumnName("status_query_uri");
            entity.Property(e => e.TagAggregate)
                .HasMaxLength(50)
                .HasColumnName("tag_aggregate");
            entity.Property(e => e.TagGranularity)
                .HasMaxLength(50)
                .HasColumnName("tag_granularity");
            entity.Property(e => e.TagType)
                .HasMaxLength(100)
                .HasColumnName("tag_type");
            entity.Property(e => e.TsNow)
                .IsUnicode(false)
                .HasColumnName("TsNOW");
            entity.Property(e => e.UserFriendly).HasColumnName("user_friendly");
            entity.Property(e => e.UtcTime).HasColumnName("utc_time");
        });

        modelBuilder.Entity<RealRawPoint>(entity =>
        {
            entity.HasKey(e => e.RealTagId);

            entity.ToTable("Real_Raw_Points");

            entity.HasIndex(e => new { e.SiteIdFk, e.RTagName }, "nci_wi_Real_Raw_Points_9E082316A1ACFE09DE411C82D200DC21");

            entity.Property(e => e.RealTagId).HasColumnName("Real_Tag_Id");
            entity.Property(e => e.AdxId).HasColumnName("ADX_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.Average).HasColumnName("AVERAGE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.DataTypeIdFk).HasColumnName("DataTypeID_Fk");
            entity.Property(e => e.Deadband).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.FlowRate).HasColumnName("Flow_Rate");
            entity.Property(e => e.HeartBeatRate).HasColumnName("Heart_Beat_Rate");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsCloudTotalizer)
                .HasDefaultValue(false)
                .HasColumnName("Is_Cloud_Totalizer");
            entity.Property(e => e.IsGps)
                .HasDefaultValue(false)
                .HasColumnName("IsGPS");
            entity.Property(e => e.IsTTotalizer)
                .HasDefaultValue(false)
                .HasColumnName("Is_T_Totalizer");
            entity.Property(e => e.ParentId).HasColumnName("Parent_Id");
            entity.Property(e => e.PublishRate).HasColumnName("Publish_Rate");
            entity.Property(e => e.RMappedByDevice).HasColumnName("R_Mapped_By_Device");
            entity.Property(e => e.RMappedName)
                .HasMaxLength(250)
                .HasColumnName("R_Mapped_Name");
            entity.Property(e => e.RTagName)
                .HasMaxLength(250)
                .HasColumnName("R_Tag_Name");
            entity.Property(e => e.Roc).HasColumnName("ROC");
            entity.Property(e => e.RtUnit)
                .HasMaxLength(250)
                .HasColumnName("RT_Unit");
            entity.Property(e => e.ScanInterval).HasColumnName("Scan_Interval");
            entity.Property(e => e.ScanRate).HasColumnName("Scan_Rate");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.SiteSpecificDeviceId).HasColumnName("Site_Specific_Device_Id");
            entity.Property(e => e.SourceTagIdFk).HasColumnName("Source_Tag_Id_Fk");
            entity.Property(e => e.Stdev).HasColumnName("STDEV");
            entity.Property(e => e.TotalizerRefrenceId).HasColumnName("Totalizer_Refrence_Id");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
            entity.Property(e => e.Variation).HasColumnName("VARIATION");
        });

        modelBuilder.Entity<Realstatstable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("realstatstable");

            entity.Property(e => e.StandardDeviation).HasColumnName("Standard_Deviation");
            entity.Property(e => e.TagName).IsUnicode(false);
        });

        modelBuilder.Entity<RecipientGroup>(entity =>
        {
            entity.HasKey(e => e.GrId).HasName("PK__RECIPIEN__80CBC3229ED43CED");

            entity.ToTable("RECIPIENT_GROUP");

            entity.Property(e => e.GrId).HasColumnName("GR_ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GrTitle)
                .HasMaxLength(200)
                .HasColumnName("GR_Title  ");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RecipientGroupM2m>(entity =>
        {
            entity.HasKey(e => e.RgId).HasName("PK__RECIPIEN__C1DD87DE1EF72A24");

            entity.ToTable("RECIPIENT_GROUP_M2M");

            entity.Property(e => e.RgId).HasColumnName("RG_ID");
            entity.Property(e => e.ArId).HasColumnName("AR_ID");
            entity.Property(e => e.GrId).HasColumnName("GR_ID");

            entity.HasOne(d => d.Ar).WithMany(p => p.RecipientGroupM2ms)
                .HasForeignKey(d => d.ArId)
                .HasConstraintName("FK__RECIPIENT__AR_ID__63D8CE75");

            entity.HasOne(d => d.Gr).WithMany(p => p.RecipientGroupM2ms)
                .HasForeignKey(d => d.GrId)
                .HasConstraintName("FK__RECIPIENT__GR_ID__64CCF2AE");
        });

        modelBuilder.Entity<RecipientsGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Recipien__149AF36A64B29D05");

            entity.ToTable("RecipientsGroup");

            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupName).IsUnicode(false);
            entity.Property(e => e.SiId).HasColumnName("SI_ID");
            entity.Property(e => e.UpdatedBy).IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RecipientsInfo>(entity =>
        {
            entity.HasKey(e => e.RecipientInfoId).HasName("PK__Recipien__9DBBE69BB75895AC");

            entity.ToTable("RecipientsInfo");

            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.IsOcuser).HasColumnName("IsOCUser");
            entity.Property(e => e.Phone).IsUnicode(false);
            entity.Property(e => e.RecipientName).IsUnicode(false);
            entity.Property(e => e.UpdatedBy).IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CodeIdFkNavigation).WithMany(p => p.RecipientsInfos)
                .HasForeignKey(d => d.CodeIdFk)
                .HasConstraintName("FK_RecipientsInfo.CodeIdFk");

            entity.HasOne(d => d.Group).WithMany(p => p.RecipientsInfos)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_RecipientsInfo.GroupId");
        });

        modelBuilder.Entity<Reg30625BatchConnectorsBmpSiteExport265Numeric>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("reg_30_6_25_batch_connectors_bmp_site_export_265_NUMERIC");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Region__ACD844433E6FD124");

            entity.ToTable("Region");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.CountryidFk).HasColumnName("Countryid_Fk");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RegionName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RestApicolumnMapping>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.OriginalColumn }).HasName("PK__RestAPIC__EF6F65119F66F788");

            entity.ToTable("RestAPIColumnMapping");

            entity.Property(e => e.OriginalColumn)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DataType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MappedColumn)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE1AA340A3D0");

            entity.ToTable("Role");

            entity.Property(e => e.CreatedByUser).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDefaultRole).HasDefaultValue(false);
            entity.Property(e => e.ProductIdFk).HasColumnName("ProductId_Fk");
            entity.Property(e => e.RoleName).HasMaxLength(300);
            entity.Property(e => e.UpdatedByUser).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.ProductIdFkNavigation).WithMany(p => p.Roles)
                .HasForeignKey(d => d.ProductIdFk)
                .HasConstraintName("FK_RoleProduct");
        });

        modelBuilder.Entity<RolePermissionM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RolePerm__3214EC27523A4355");

            entity.ToTable("RolePermissionM2M");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedByUser).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PermissionIdFk).HasColumnName("PermissionId_FK");
            entity.Property(e => e.RoleIdFk).HasColumnName("RoleId_Fk");
            entity.Property(e => e.UpdatedByUser).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.PermissionIdFkNavigation).WithMany(p => p.RolePermissionM2ms)
                .HasForeignKey(d => d.PermissionIdFk)
                .HasConstraintName("FK_RolePermissionM2M.PermissionId");

            entity.HasOne(d => d.RoleIdFkNavigation).WithMany(p => p.RolePermissionM2ms)
                .HasForeignKey(d => d.RoleIdFk)
                .HasConstraintName("FK_RolePermissionM2M_Role");
        });

        modelBuilder.Entity<SchPullExecutionLog3>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__SchPullE__5E5499A83E3B9541");

            entity.ToTable("SchPullExecutionLog3");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.ConnectorId).HasColumnName("ConnectorID");
            entity.Property(e => e.OutputLink).IsUnicode(false);
            entity.Property(e => e.PipelineId).HasColumnName("PipelineID");
            entity.Property(e => e.PipelineName).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Triggeredby)
                .HasMaxLength(50)
                .HasColumnName("triggeredby");
            entity.Property(e => e.Triggerid).HasColumnName("triggerid");
            entity.Property(e => e.Triggername)
                .HasMaxLength(50)
                .HasColumnName("triggername");
            entity.Property(e => e.Triggerstatus)
                .HasMaxLength(20)
                .HasColumnName("triggerstatus");
            entity.Property(e => e.Triggertime).HasColumnName("triggertime");
        });

        modelBuilder.Entity<ScheduledExportsData1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ScheduledExportsData1");

            entity.Property(e => e.Reading).IsUnicode(false);
            entity.Property(e => e.Tags).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
        });

        modelBuilder.Entity<ScheduledExportsData2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ScheduledExportsData2");

            entity.Property(e => e.Altitude).IsUnicode(false);
            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Lattitude).IsUnicode(false);
            entity.Property(e => e.Longitude).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<ScheduledExportsDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TagName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScheduledPullExecutionLog>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ExecutedAt)
                .HasColumnType("datetime")
                .HasColumnName("executed_at");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.LogId)
                .ValueGeneratedOnAdd()
                .HasColumnName("log_id");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TriggerId).HasColumnName("trigger_id");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("trigger_name");
        });

        modelBuilder.Entity<SidefaultRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SIDefaul__3214EC27BA88ED66");

            entity.ToTable("SIDefaultRegion");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CsiidFk).HasColumnName("CSIID_FK");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RegionIdFk).HasColumnName("RegionId_FK");

            entity.HasOne(d => d.CsiidFkNavigation).WithMany(p => p.SidefaultRegions)
                .HasForeignKey(d => d.CsiidFk)
                .HasConstraintName("FK_CSIID");

            entity.HasOne(d => d.RegionIdFkNavigation).WithMany(p => p.SidefaultRegions)
                .HasForeignKey(d => d.RegionIdFk)
                .HasConstraintName("FK_RegionID");
        });

        modelBuilder.Entity<SiteComponentConfiguration>(entity =>
        {
            entity.HasKey(e => e.SiteOpeId).HasName("PK__SiteComp__C818BC4E50BDC7FB");

            entity.ToTable("SiteComponentConfiguration");

            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.ComponentIdFkNavigation).WithMany(p => p.SiteComponentConfigurations)
                .HasForeignKey(d => d.ComponentIdFk)
                .HasConstraintName("FK_SiteComponentConfiguration.ComponentIdFk");
        });

        modelBuilder.Entity<SiteEventsM2m>(entity =>
        {
            entity.HasKey(e => e.SiteEventId);

            entity.ToTable("SITE_Events_M2M");

            entity.Property(e => e.SiteEventId).HasColumnName("SiteEventID");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AlarmPriorityId).HasColumnName("AlarmPriority_ID");
            entity.Property(e => e.AsId).HasColumnName("AS_Id");
            entity.Property(e => e.EventId).HasColumnName("Event_Id");
            entity.Property(e => e.IsAlarmActive).HasColumnName("isAlarmActive");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");

            entity.HasOne(d => d.AlarmPriority).WithMany(p => p.SiteEventsM2ms)
                .HasForeignKey(d => d.AlarmPriorityId)
                .HasConstraintName("FK_SITE_Events_M2M.AlarmPriority_ID");

            entity.HasOne(d => d.Event).WithMany(p => p.SiteEventsM2ms)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_SITE_Events_M2M.Event_Id");
        });

        modelBuilder.Entity<SiteHierarchyExportsDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Area).IsUnicode(false);
            entity.Property(e => e.Asset).IsUnicode(false);
            entity.Property(e => e.AssetType)
                .IsUnicode(false)
                .HasColumnName("Asset_type");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.ParentAsset)
                .IsUnicode(false)
                .HasColumnName("Parent_Asset");
            entity.Property(e => e.SiteName)
                .IsUnicode(false)
                .HasColumnName("Site_Name");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<SiteOpcDefaultSetting>(entity =>
        {
            entity.ToTable("Site_OPC_DefaultSettings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceId).HasColumnName("Device_Id");
            entity.Property(e => e.HeartBeatRate).HasColumnName("Heart_Beat_Rate");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PublishRate).HasColumnName("Publish_Rate");
            entity.Property(e => e.ScanRate).HasColumnName("Scan_Rate");
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");
        });

        modelBuilder.Entity<SiteRegionOne2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Site_Reg__3214EC2773E9ECB3");

            entity.ToTable("Site_Region_one2m", tb =>
                {
                    tb.HasTrigger("trg_TrackEmailSent");
                    tb.HasTrigger("trg_UpdateIsActivatedOn");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClusterName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Cluster_Name");
            entity.Property(e => e.ClusterUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Cluster_URL");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.JiraTicketUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("JiraTicketURL");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RegionIdFk).HasColumnName("RegionId_FK");
            entity.Property(e => e.SiteIdFk).HasColumnName("SiteId_FK");

            entity.HasOne(d => d.RegionIdFkNavigation).WithMany(p => p.SiteRegionOne2ms)
                .HasForeignKey(d => d.RegionIdFk)
                .HasConstraintName("FK_RegionID2");
        });

        modelBuilder.Entity<SiteTestUsArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("site_test_us_Areas");

            entity.Property(e => e.AreaName).IsUnicode(false);
            entity.Property(e => e.CustomerSiteId).HasColumnName("CustomerSiteID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SiteTestUsAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("site_test_us_Assets");

            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.AssetType).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParentAsset).IsUnicode(false);
        });

        modelBuilder.Entity<SiteTestUsCustomersSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("site_test_us_Customers_Sites");

            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SiteName).IsUnicode(false);
        });

        modelBuilder.Entity<SiteTestUsTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("site_test_us_Tags");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<SourceTagImportStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SourceTa__3214EC27B4E54B0F");

            entity.ToTable("SourceTagImportStatus");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.ImportEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Import_End_Date");
            entity.Property(e => e.ImportStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Import_Start_Date");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_ID_Fk");

            entity.HasOne(d => d.Device).WithMany(p => p.SourceTagImportStatuses)
                .HasForeignKey(d => d.DeviceId)
                .HasConstraintName("FK_SourceTagImportStatus_Relation_Devices");
        });

        modelBuilder.Entity<SourceTagParameter>(entity =>
        {
            entity.HasKey(e => e.SourceTagParametersId).HasName("PK__Source_T__B8C66B6A13A6F271");

            entity.ToTable("Source_Tag_Parameters");

            entity.Property(e => e.SourceTagParametersId).HasColumnName("Source_Tag_Parameters_Id");
            entity.Property(e => e.AddressMode)
                .HasMaxLength(200)
                .HasColumnName("Address_Mode");
            entity.Property(e => e.ModbusAddress).HasColumnName("Modbus_Address");
            entity.Property(e => e.ModbusFunction).HasColumnName("Modbus_function");
            entity.Property(e => e.RangeMax).HasColumnName("Range_Max");
            entity.Property(e => e.RangeMin).HasColumnName("Range_Min");
            entity.Property(e => e.RegisterLength).HasColumnName("Register_Length");
            entity.Property(e => e.SlaveId).HasColumnName("Slave_Id");
            entity.Property(e => e.TagType)
                .HasMaxLength(200)
                .HasColumnName("Tag_Type");
        });

        modelBuilder.Entity<SqlTestingExportToSqlPipilineDataAlarmMinute348Test>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SQL_Testing_Export_To_SQL_Pipiline_Data_Alarm_Minute_348_test");

            entity.Property(e => e.AlarmPriority)
                .IsUnicode(false)
                .HasColumnName("Alarm_Priority");
            entity.Property(e => e.AlarmTime)
                .IsUnicode(false)
                .HasColumnName("Alarm_Time");
            entity.Property(e => e.LowerValue).IsUnicode(false);
            entity.Property(e => e.StateTitle)
                .IsUnicode(false)
                .HasColumnName("State_Title");
            entity.Property(e => e.Status).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TriggeredStateId).HasColumnName("Triggered_State_id");
            entity.Property(e => e.UpperValue).IsUnicode(false);
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<SqlTestingExportToSqlVerifySiteHeriarchy365Area>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SQL_Testing_Export_To_SQL_Verify_Site_Heriarchy_365_Areas");

            entity.Property(e => e.AreaName).IsUnicode(false);
            entity.Property(e => e.CustomerSiteId).HasColumnName("CustomerSiteID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SqlTestingExportToSqlVerifySiteHeriarchy365Asset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SQL_Testing_Export_To_SQL_Verify_Site_Heriarchy_365_Assets");

            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.AssetType).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParentAsset).IsUnicode(false);
        });

        modelBuilder.Entity<SqlTestingExportToSqlVerifySiteHeriarchy365CustomersSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SQL_Testing_Export_To_SQL_Verify_Site_Heriarchy_365_Customers_Sites");

            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SiteName).IsUnicode(false);
        });

        modelBuilder.Entity<SqlTestingExportToSqlVerifySiteHeriarchy365Tag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SQL_Testing_Export_To_SQL_Verify_Site_Heriarchy_365_Tags");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TagType).IsUnicode(false);
        });

        modelBuilder.Entity<SqlcolumnMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SQLColumnMapping");

            entity.Property(e => e.DataType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MappedColumn)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OriginalColumn)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StatTest11>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stat_test_1_1");

            entity.Property(e => e.AlarmPriority)
                .IsUnicode(false)
                .HasColumnName("Alarm_Priority");
            entity.Property(e => e.AlarmTime)
                .IsUnicode(false)
                .HasColumnName("Alarm_Time");
            entity.Property(e => e.StateTitle)
                .IsUnicode(false)
                .HasColumnName("State_Title");
            entity.Property(e => e.Status).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TriggeredStateId).HasColumnName("Triggered_State_id");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<StatTest12>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stat_test_1_2");

            entity.Property(e => e.AlarmPriority)
                .IsUnicode(false)
                .HasColumnName("Alarm_Priority");
            entity.Property(e => e.AlarmTime)
                .IsUnicode(false)
                .HasColumnName("Alarm_Time");
            entity.Property(e => e.StateTitle)
                .IsUnicode(false)
                .HasColumnName("State_Title");
            entity.Property(e => e.Status).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TriggeredStateId).HasColumnName("Triggered_State_id");
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<SubscriptionTag>(entity =>
        {
            entity.HasKey(e => e.SubId).HasName("PK__Subscrip__DFB18CAD0425DE1C");

            entity.ToTable("Subscription_Tags");

            entity.Property(e => e.SubId).HasColumnName("Sub_ID");
            entity.Property(e => e.NoOfTags).HasColumnName("No_of_Tags");
            entity.Property(e => e.SubscriptionName)
                .HasMaxLength(200)
                .HasColumnName("Subscription_Name");
        });

        modelBuilder.Entity<SystemAlarmAction>(entity =>
        {
            entity.HasKey(e => e.SaaId).HasName("PK__SYSTEM_A__17D75666C8C7FB3E");

            entity.ToTable("SYSTEM_ALARM_ACTION");

            entity.Property(e => e.SaaId).HasColumnName("SAA_Id");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionPerformedBy).HasMaxLength(128);
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.ActivityPerformedBy).HasMaxLength(128);
            entity.Property(e => e.AsId).HasColumnName("AS_Id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ReadingTime)
                .HasColumnType("datetime")
                .HasColumnName("Reading_Time");
            entity.Property(e => e.SiteEventId).HasColumnName("SiteEventID");
            entity.Property(e => e.SystemAlarmDescription).HasColumnName("SystemAlarm_Description");

            entity.HasOne(d => d.ActionPerformedByNavigation).WithMany(p => p.SystemAlarmActions)
                .HasForeignKey(d => d.ActionPerformedBy)
                .HasConstraintName("FK_SYSTEM_ALARM_ACTION_AspNetUsers");

            entity.HasOne(d => d.As).WithMany(p => p.SystemAlarmActions)
                .HasForeignKey(d => d.AsId)
                .HasConstraintName("FK_SYSTEM_ALARM_ACTION.AS_Id");

            entity.HasOne(d => d.SiteEvent).WithMany(p => p.SystemAlarmActions)
                .HasForeignKey(d => d.SiteEventId)
                .HasConstraintName("FK_SYSTEM_ALARM_ACTION_SITE_Events_M2M");
        });

        modelBuilder.Entity<SystemAlarmActionHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYSTEM_A__3214EC27D4E93BA8");

            entity.ToTable("SYSTEM_ALARM_ACTION_HISTORY");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AsId).HasColumnName("AS_Id");
            entity.Property(e => e.SaaId).HasColumnName("SAA_Id");
            entity.Property(e => e.StateEventId).HasColumnName("StateEventID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SystemIntegrator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__System_I__3214EC2751092BE9");

            entity.ToTable("System_Integrator");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.DistributorIdFk).HasColumnName("DistributorID_FK");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LogoImage).HasColumnName("Logo_Image");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PathImage)
                .HasMaxLength(50)
                .HasColumnName("Path_Image");
            entity.Property(e => e.Phone).IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.DistributorIdFkNavigation).WithMany(p => p.SystemIntegrators)
                .HasForeignKey(d => d.DistributorIdFk)
                .HasConstraintName("FK__System_In__Distr__73B00EE2");
        });

        modelBuilder.Entity<TagGapAlarmsLog>(entity =>
        {
            entity.HasKey(e => e.TagGapId).HasName("PK__Tag_Gap___11CB4A76BC3BF76C");

            entity.ToTable("Tag_Gap_Alarms_Log");

            entity.Property(e => e.TagGapId).HasColumnName("Tag_Gap_ID");
            entity.Property(e => e.DurationMinutes)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Duration_Minutes");
            entity.Property(e => e.FiredAt).HasColumnName("fired_at");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastNotifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MappedName)
                .HasMaxLength(250)
                .HasColumnName("Mapped_Name");
            entity.Property(e => e.ResolvedAt).HasColumnName("resolved_at");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.State).HasMaxLength(250);
            entity.Property(e => e.TagIdFk).HasColumnName("Tag_Id_FK");
            entity.Property(e => e.TagTypeIdFk).HasColumnName("TagTypeId_fk");
            entity.Property(e => e.TagUpdateIdFk).HasColumnName("Tag_Update_Id_FK");
            entity.Property(e => e.ThresholdMinutes)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Threshold_Minutes");

            entity.HasOne(d => d.SiteIdFkNavigation).WithMany(p => p.TagGapAlarmsLogs)
                .HasForeignKey(d => d.SiteIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tag_Gap_A__site___1636CDBB");

            entity.HasOne(d => d.TagIdFkNavigation).WithMany(p => p.TagGapAlarmsLogs)
                .HasForeignKey(d => d.TagIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tag_Gap_A__Real___172AF1F4");

            entity.HasOne(d => d.TagUpdateIdFkNavigation).WithMany(p => p.TagGapAlarmsLogs)
                .HasForeignKey(d => d.TagUpdateIdFk)
                .HasConstraintName("FK_TagGapAlarmsLog_TagUpdate");
        });

        modelBuilder.Entity<TagLakeLastUpdate>(entity =>
        {
            entity.HasKey(e => e.TagUpdateId).HasName("PK__Tag_Lake__0226AC5B24BFB32A");

            entity.ToTable("Tag_Lake_Last_update");

            entity.HasIndex(e => new { e.SiteIdFk, e.TagId, e.MappedName, e.IsActive }, "UQ_Tag_Lake_Last_update_Site_Tag_Mapped").IsUnique();

            entity.Property(e => e.TagUpdateId).HasColumnName("Tag_Update_Id");
            entity.Property(e => e.CheckTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");
            entity.Property(e => e.DeviceIdFk).HasColumnName("Device_Id_FK");
            entity.Property(e => e.IngestTimeUpdatedAt).HasColumnName("IngestTimeUpdated_at");
            entity.Property(e => e.IngestionTime).HasColumnName("Ingestion_Time");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MappedName)
                .HasMaxLength(10)
                .HasColumnName("Mapped_Name");
            entity.Property(e => e.ReleaseEnv)
                .HasMaxLength(30)
                .HasColumnName("release_env");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_FK");
            entity.Property(e => e.TableEntryOn).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.TagId).HasColumnName("Tag_Id");
            entity.Property(e => e.TagTypeIdFk)
                .HasDefaultValue(1)
                .HasColumnName("TagTypeId_fk");
            entity.Property(e => e.ThresholdMinutes).HasColumnName("Threshold_Minutes");

            entity.HasOne(d => d.DeviceIdFkNavigation).WithMany(p => p.TagLakeLastUpdates)
                .HasForeignKey(d => d.DeviceIdFk)
                .HasConstraintName("FK__Tag_Lake___Devic__6E5DE68B");

            entity.HasOne(d => d.SiteIdFkNavigation).WithMany(p => p.TagLakeLastUpdates)
                .HasForeignKey(d => d.SiteIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tag_Lake___Site___6A8D55A7");
        });

        modelBuilder.Entity<TagMap>(entity =>
        {
            entity.HasKey(e => e.TagMapId).HasName("PK__TagMap__488347B0F6FA9777");

            entity.ToTable("TagMap");

            entity.HasIndex(e => e.FriendlyName, "UQ__TagMap__0C83760BF671A031").IsUnique();

            entity.Property(e => e.CanonicalName).HasMaxLength(50);
            entity.Property(e => e.FriendlyName).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.Units).HasMaxLength(32);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(128)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<TagType>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TagsDataType>(entity =>
        {
            entity.HasKey(e => e.DataTypeId).HasName("PK_DataType");

            entity.ToTable("TagsDataType");

            entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
        });

        modelBuilder.Entity<Tank>(entity =>
        {
            entity.HasKey(e => e.TankId).HasName("PK__Tank__97DE70057DC03B5A");

            entity.ToTable("Tank");

            entity.Property(e => e.TankId).HasColumnName("TankID");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ProdIdFk).HasColumnName("ProdID_FK");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
        });

        modelBuilder.Entity<TankStatusLive>(entity =>
        {
            entity.ToTable("TankStatusLive");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccumVolume).HasColumnName("Accum_Volume");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateLastLeakTest).HasColumnName("Date_Last_Leak_Test");
            entity.Property(e => e.DateLastRead).HasColumnName("Date_Last_Read");
            entity.Property(e => e.DeliveredVolume).HasColumnName("Delivered_Volume");
            entity.Property(e => e.DeliveryIniProductHeight).HasColumnName("Delivery_ini_Product_Height");
            entity.Property(e => e.DeliveryIniProductVolume).HasColumnName("Delivery_ini_Product_Volume");
            entity.Property(e => e.DeliveryIniTemp).HasColumnName("delivery_ini_temp");
            entity.Property(e => e.DeliveryIniWaterHeight).HasColumnName("Delivery_ini_Water_Height");
            entity.Property(e => e.DeliveryIniWaterVolume).HasColumnName("Delivery_ini_Water_Volume");
            entity.Property(e => e.DeliveryStartDate).HasColumnName("Delivery_Start_Date");
            entity.Property(e => e.DeliveryStartTime).HasColumnName("Delivery_Start_Time");
            entity.Property(e => e.DeliveryState)
                .IsUnicode(false)
                .HasColumnName("Delivery_State");
            entity.Property(e => e.FcSiteId).HasColumnName("FC_SiteID");
            entity.Property(e => e.FcTimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("FC_TimeStamp");
            entity.Property(e => e.LastModifiedDate).HasColumnName("Last_Modified_Date");
            entity.Property(e => e.LastTransId).HasColumnName("Last_Trans_ID");
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OmniAssetId).HasColumnName("Omni_AssetID");
            entity.Property(e => e.ProbeStatus).HasColumnName("Probe_Status");
            entity.Property(e => e.ProdTcDensity)
                .IsUnicode(false)
                .HasColumnName("prod_tc_density");
            entity.Property(e => e.ProductDensity).HasColumnName("Product_Density");
            entity.Property(e => e.ProductHeight).HasColumnName("Product_Height");
            entity.Property(e => e.ProductId)
                .IsUnicode(false)
                .HasColumnName("Product_ID");
            entity.Property(e => e.ProductNumber).HasColumnName("Product_Number");
            entity.Property(e => e.ProductTemperature).HasColumnName("Product_Temperature");
            entity.Property(e => e.ProductVolume).HasColumnName("Product_Volume");
            entity.Property(e => e.ProductWeight).HasColumnName("Product_Weight");
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");
            entity.Property(e => e.TankId).HasColumnName("Tank_ID");
            entity.Property(e => e.TcVolume).HasColumnName("TC_Volume");
            entity.Property(e => e.TimeLastLeakTest).HasColumnName("Time_Last_Leak_Test");
            entity.Property(e => e.TimeLastRead).HasColumnName("Time_Last_Read");
            entity.Property(e => e.TimeStamp).HasColumnName("Time_Stamp");
            entity.Property(e => e.WaterHeight).HasColumnName("Water_Height");
            entity.Property(e => e.WaterVolume).HasColumnName("Water_Volume");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblProdu__3214EC279C31C2C9");

            entity.ToTable("tblProduct");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_Fk");
        });

        modelBuilder.Entity<TblTankStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTankS__3214EC27080B0220");

            entity.ToTable("tblTankStatus");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_Fk");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.AssetIdFkNavigation).WithMany(p => p.TblTankStatuses)
                .HasForeignKey(d => d.AssetIdFk)
                .HasConstraintName("FK__tblTankSt__Asset__679450C0");
        });

        modelBuilder.Entity<TblTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTrans__3214EC27E77CB9BC");

            entity.ToTable("tblTransactions");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Article).IsUnicode(false);
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_Fk");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GasStation).IsUnicode(false);
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.AssetIdFkNavigation).WithMany(p => p.TblTransactions)
                .HasForeignKey(d => d.AssetIdFk)
                .HasConstraintName("FK__tblTransa__Asset__688874F9");
        });

        modelBuilder.Entity<TestApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("testAPI");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.SiteName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("site_name");
        });

        modelBuilder.Entity<TestingTankStatus>(entity =>
        {
            entity.ToTable("TestingTankStatus");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccumVolume).HasColumnName("Accum_Volume");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateLastLeakTest).HasColumnName("Date_Last_Leak_Test");
            entity.Property(e => e.DateLastRead).HasColumnName("Date_Last_Read");
            entity.Property(e => e.DeliveredVolume).HasColumnName("Delivered_Volume");
            entity.Property(e => e.DeliveryIniProductHeight).HasColumnName("Delivery_ini_Product_Height");
            entity.Property(e => e.DeliveryIniProductVolume).HasColumnName("Delivery_ini_Product_Volume");
            entity.Property(e => e.DeliveryIniTemp).HasColumnName("delivery_ini_temp");
            entity.Property(e => e.DeliveryIniWaterHeight).HasColumnName("Delivery_ini_Water_Height");
            entity.Property(e => e.DeliveryIniWaterVolume).HasColumnName("Delivery_ini_Water_Volume");
            entity.Property(e => e.DeliveryStartDate).HasColumnName("Delivery_Start_Date");
            entity.Property(e => e.DeliveryStartTime).HasColumnName("Delivery_Start_Time");
            entity.Property(e => e.DeliveryState)
                .IsUnicode(false)
                .HasColumnName("Delivery_State");
            entity.Property(e => e.FcSiteId).HasColumnName("FC_SiteID");
            entity.Property(e => e.LastModifiedDate).HasColumnName("Last_Modified_Date");
            entity.Property(e => e.LastTransId).HasColumnName("Last_Trans_ID");
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OmniAssetId).HasColumnName("Omni_AssetID");
            entity.Property(e => e.ProbeStatus).HasColumnName("Probe_Status");
            entity.Property(e => e.ProdTcDensity)
                .IsUnicode(false)
                .HasColumnName("prod_tc_density");
            entity.Property(e => e.ProductDensity).HasColumnName("Product_Density");
            entity.Property(e => e.ProductHeight).HasColumnName("Product_Height");
            entity.Property(e => e.ProductId)
                .IsUnicode(false)
                .HasColumnName("Product_ID");
            entity.Property(e => e.ProductNumber).HasColumnName("Product_Number");
            entity.Property(e => e.ProductTemperature).HasColumnName("Product_Temperature");
            entity.Property(e => e.ProductVolume).HasColumnName("Product_Volume");
            entity.Property(e => e.ProductWeight).HasColumnName("Product_Weight");
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");
            entity.Property(e => e.TankId).HasColumnName("Tank_ID");
            entity.Property(e => e.TcVolume).HasColumnName("TC_Volume");
            entity.Property(e => e.TimeLastLeakTest).HasColumnName("Time_Last_Leak_Test");
            entity.Property(e => e.TimeLastRead).HasColumnName("Time_Last_Read");
            entity.Property(e => e.TimeStamp).HasColumnName("Time_Stamp");
            entity.Property(e => e.WaterHeight).HasColumnName("Water_Height");
            entity.Property(e => e.WaterVolume).HasColumnName("Water_Volume");
        });

        modelBuilder.Entity<TimeBasedEntityAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TimeBase__3214EC0743C48D25");

            entity.ToTable("TimeBasedEntityAccess", tb =>
                {
                    tb.HasTrigger("trgAfterAssigningTimeBasedAccess");
                    tb.HasTrigger("trgAfterUpdateTimeBasedAccess");
                });

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserTypeM2mFk).HasColumnName("UserTypeM2M_Fk");

            entity.HasOne(d => d.UserTypeM2mFkNavigation).WithMany(p => p.TimeBasedEntityAccesses)
                .HasForeignKey(d => d.UserTypeM2mFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTypeM2M");
        });

        modelBuilder.Entity<TimerScheduledExportsData1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TimerScheduledExportsData1");

            entity.Property(e => e.Duration).IsUnicode(false);
            entity.Property(e => e.Endtime).IsUnicode(false);
            entity.Property(e => e.Starttime).IsUnicode(false);
            entity.Property(e => e.TagName).IsUnicode(false);
            entity.Property(e => e.TimeStamp).IsUnicode(false);
            entity.Property(e => e.TrueVal)
                .IsUnicode(false)
                .HasColumnName("True_val");
        });

        modelBuilder.Entity<TobaccoWasteConstantValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tobacco___3214EC27877A2F06");

            entity.ToTable("Tobacco_Waste_Constant_Values");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConstantAyCihCf).HasColumnName("Constant_AY_CIH_CF");
            entity.Property(e => e.ConstantAyOutputCf).HasColumnName("Constant_AY_Output_CF");
            entity.Property(e => e.ConstantCbPmCigCf).HasColumnName("Constant_CbPM_CIG_CF");
            entity.Property(e => e.ConstantCbpmOutputCf).HasColumnName("Constant_CBPM_Output_CF");
            entity.Property(e => e.ConstantClCigCf).HasColumnName("Constant_CL_CIG_CF");
            entity.Property(e => e.ConstantClOutputCf).HasColumnName("Constant_CL_Output_CF");
            entity.Property(e => e.ConstantGfCigCf).HasColumnName("Constant_GF_CIG_CF");
            entity.Property(e => e.ConstantGfOutputCf).HasColumnName("Constant_GF_Output_CF");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TobaccoWasteManualEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tobacco___3214EC273BF785D1");

            entity.ToTable("Tobacco_Waste_Manual_Entry");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CalcOverallSmddust).HasColumnName("Calc_Overall_SMDDUST");
            entity.Property(e => e.CalcSmdFloorsweep).HasColumnName("Calc_SMD_Floorsweep");
            entity.Property(e => e.CalcSmdUsable).HasColumnName("Calc_SMD_Usable");
            entity.Property(e => e.CalcSmddust).HasColumnName("Calc_SMDDUST");
            entity.Property(e => e.CalcUseableSmd).HasColumnName("Calc_Useable_SMD");
            entity.Property(e => e.CalcUseableSmdReceived).HasColumnName("Calc_Useable_SMD_Received");
            entity.Property(e => e.CigWtWasteReceivedSmd).HasColumnName("Cig_wt_Waste_Received_SMD");
            entity.Property(e => e.CleaningDustNrr).HasColumnName("Cleaning_Dust_NRR");
            entity.Property(e => e.ClosingStockUncorrected).HasColumnName("Closing_Stock_Uncorrected");
            entity.Property(e => e.ConstantAyCihCf).HasColumnName("Constant_AY_CIH_CF");
            entity.Property(e => e.ConstantAyOutputCf).HasColumnName("Constant_AY_Output_CF");
            entity.Property(e => e.ConstantCbPmCigCf).HasColumnName("Constant_CbPM_CIG_CF");
            entity.Property(e => e.ConstantCbpmOutputCf).HasColumnName("Constant_CBPM_Output_CF");
            entity.Property(e => e.ConstantClCigCf).HasColumnName("Constant_CL_CIG_CF");
            entity.Property(e => e.ConstantClOutputCf).HasColumnName("Constant_CL_Output_CF");
            entity.Property(e => e.ConstantGfCigCf).HasColumnName("Constant_GF_CIG_CF");
            entity.Property(e => e.ConstantGfOutputCf).HasColumnName("Constant_GF_Output_CF");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DustQuantitiesCentral).HasColumnName("Dust_Quantities_Central");
            entity.Property(e => e.DustQuantitiesLaminaAirlift).HasColumnName("Dust_Quantities_Lamina_Airlift");
            entity.Property(e => e.DustQuantitiesSmdDust).HasColumnName("Dust_Quantities_SMD_Dust");
            entity.Property(e => e.DustQuantitiesStemAirliftSieves).HasColumnName("Dust_Quantities_Stem_Airlift_Sieves");
            entity.Property(e => e.DustQuantitiesTotalPmdDust).HasColumnName("Dust_Quantities_Total_PMD_Dust");
            entity.Property(e => e.FloorSweep).HasColumnName("Floor_Sweep");
            entity.Property(e => e.FloorSweepPmd).HasColumnName("Floor_Sweep_PMD");
            entity.Property(e => e.FloorSweepWetScrap).HasColumnName("Floor_Sweep_Wet_Scrap");
            entity.Property(e => e.KnockoutsAverageDaily).HasColumnName("Knockouts_Average_Daily");
            entity.Property(e => e.KnockoutsAverageDailyHighestOperation).HasColumnName("Knockouts_Average_Daily_Highest_Operation");
            entity.Property(e => e.KnockoutsCbPmDaily).HasColumnName("Knockouts_CbPM_Daily");
            entity.Property(e => e.KnockoutsCbPmDailyHighestOperation).HasColumnName("Knockouts_CbPM_Daily_Highest_Operation");
            entity.Property(e => e.KnockoutsGfDaily).HasColumnName("Knockouts_GF_Daily");
            entity.Property(e => e.KnockoutsGfDailyHighestOperation).HasColumnName("Knockouts_GF_Daily_Highest_Operation");
            entity.Property(e => e.KnockoutsTotal).HasColumnName("Knockouts_Total");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OpeningStockUncorrected).HasColumnName("Opening_Stock_Uncorrected");
            entity.Property(e => e.OverallPmddust).HasColumnName("Overall_PMDDust");
            entity.Property(e => e.PmdCentralLoop).HasColumnName("PMD_Central_Loop");
            entity.Property(e => e.PmdCtsOpeningStockNextDay).HasColumnName("PMD_CTS_Opening_Stock_NextDay");
            entity.Property(e => e.PmdFloorSweep).HasColumnName("PMD_Floor_Sweep");
            entity.Property(e => e.PmdInputActual).HasColumnName("PMD_Input_Actual");
            entity.Property(e => e.PmdInputCorrected).HasColumnName("PMD_Input_Corrected");
            entity.Property(e => e.PmdKnockouts).HasColumnName("PMD_Knockouts");
            entity.Property(e => e.PmdLaminaDust).HasColumnName("PMD_Lamina_Dust");
            entity.Property(e => e.PmdOutputActual).HasColumnName("PMD_Output_Actual");
            entity.Property(e => e.PmdOutputUncorrected).HasColumnName("PMD_output_Uncorrected");
            entity.Property(e => e.PmdProduction).HasColumnName("PMD_Production");
            entity.Property(e => e.PmdStemDust).HasColumnName("PMD_Stem_Dust");
            entity.Property(e => e.PmdUnaccountable).HasColumnName("PMD_Unaccountable");
            entity.Property(e => e.PmdWaste).HasColumnName("PMD_Waste");
            entity.Property(e => e.PmdWetWaste).HasColumnName("PMD_Wet_Waste");
            entity.Property(e => e.SmdAy).HasColumnName("SMD_AY");
            entity.Property(e => e.SmdCbPm).HasColumnName("SMD_CbPM");
            entity.Property(e => e.SmdCl).HasColumnName("SMD_CL");
            entity.Property(e => e.SmdDust).HasColumnName("SMD_Dust");
            entity.Property(e => e.SmdFloorSweep).HasColumnName("SMD_Floor_Sweep");
            entity.Property(e => e.SmdGf).HasColumnName("SMD_GF");
            entity.Property(e => e.SmdInputCorrected).HasColumnName("SMD_Input_Corrected");
            entity.Property(e => e.SmdOutputCigWeight).HasColumnName("SMD_Output_Cig_Weight");
            entity.Property(e => e.SmdOutputCorrected).HasColumnName("SMD_Output_Corrected");
            entity.Property(e => e.SmdTotal).HasColumnName("SMD_TOTAL");
            entity.Property(e => e.SmdWaste).HasColumnName("SMD_Waste");
            entity.Property(e => e.SmdWinnowwers).HasColumnName("SMD_Winnowwers");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("Time_Stamp");
            entity.Property(e => e.UsableTobaccoSmd).HasColumnName("Usable_Tobacco_SMD");
            entity.Property(e => e.UseableInSmdDustPsd).HasColumnName("Useable_in_SMD_Dust_PSD");
            entity.Property(e => e.UseableShorts).HasColumnName("Useable_Shorts");
            entity.Property(e => e.UseableSmdReceived).HasColumnName("Useable_SMD_Received");
            entity.Property(e => e.UseableSmdRecovered).HasColumnName("Useable_SMD_Recovered");
            entity.Property(e => e.VWay).HasColumnName("V_Way");
            entity.Property(e => e.VWayDust).HasColumnName("V_Way_Dust");
        });

        modelBuilder.Entity<TrendingReport>(entity =>
        {
            entity.Property(e => e.ChartIdFk).HasColumnName("ChartId_FK");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.SiteIdFk).HasColumnName("SiteId_FK");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TrendingReportFilter>(entity =>
        {
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Granularity).HasMaxLength(10);
            entity.Property(e => e.IsLocalTime).HasColumnName("isLocalTime");
            entity.Property(e => e.ReportIdFk).HasColumnName("ReportId_FK");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TrendingReportTag>(entity =>
        {
            entity.Property(e => e.ReportIdFk).HasColumnName("ReportId_FK");
            entity.Property(e => e.TagIdFk).HasColumnName("TagId_FK");
            entity.Property(e => e.TagTypeIdFk).HasColumnName("TagTypeId_FK");
        });

        modelBuilder.Entity<TrendingReportsShared>(entity =>
        {
            entity.ToTable("TrendingReportsShared");

            entity.Property(e => e.ReportIdFk).HasColumnName("ReportId_FK");
            entity.Property(e => e.SharedBy).HasMaxLength(128);
            entity.Property(e => e.SharedDate).HasColumnType("datetime");
            entity.Property(e => e.SharedTo).HasMaxLength(128);
        });

        modelBuilder.Entity<TriggeredDataAlarm>(entity =>
        {
            entity.ToTable("Triggered_Data_Alarm");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<UserActivityLogging>(entity =>
        {
            entity.ToTable("UserActivityLogging");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserArea>(entity =>
        {
            entity.ToTable("User_Areas");

            entity.Property(e => e.UserAreaId).HasColumnName("User_Area_ID");
            entity.Property(e => e.AreaIdFk).HasColumnName("Area_ID_Fk");
            entity.Property(e => e.UserIdFk)
                .HasMaxLength(128)
                .HasColumnName("User_ID_FK");
        });

        modelBuilder.Entity<UserAsset>(entity =>
        {
            entity.ToTable("User_Assets");

            entity.Property(e => e.UserAssetId).HasColumnName("User_Asset_ID");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_ID_FK");
            entity.Property(e => e.UserIdFk)
                .HasMaxLength(128)
                .HasColumnName("User_ID_FK");
        });

        modelBuilder.Entity<UserControlSystemIntegratorM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserCont__3214EC2773403FB2");

            entity.ToTable("UserControlSystemIntegratorM2M", tb =>
                {
                    tb.HasTrigger("trgAfterAssigningSIAccess");
                    tb.HasTrigger("trgAfterSIAccessUpdate");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CsiidFk).HasColumnName("CSIId_Fk");
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserIdFk)
                .HasMaxLength(128)
                .HasColumnName("UserId_Fk");

            entity.HasOne(d => d.CsiidFkNavigation).WithMany(p => p.UserControlSystemIntegratorM2ms)
                .HasForeignKey(d => d.CsiidFk)
                .HasConstraintName("FK_UserControlSystemIntegratorM2M.CSIId");

            entity.HasOne(d => d.UserIdFkNavigation).WithMany(p => p.UserControlSystemIntegratorM2ms)
                .HasForeignKey(d => d.UserIdFk)
                .HasConstraintName("FK_UserControlSystemIntegratorM2M.UserId");
        });

        modelBuilder.Entity<UserCustomerM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User_Cus__3214EC2784A8D0D0");

            entity.ToTable("User_Customer_M2M");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");

            entity.HasOne(d => d.Customer).WithMany(p => p.UserCustomerM2ms)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerID");

            entity.HasOne(d => d.User).WithMany(p => p.UserCustomerM2ms)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserID");
        });

        modelBuilder.Entity<UserDistributorM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserDist__3214EC27B675F985");

            entity.ToTable("UserDistributorM2M");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedByUser).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DistributorIdFk).HasColumnName("DistributorId_Fk");
            entity.Property(e => e.IsOdladmin).HasColumnName("IsODLAdmin");
            entity.Property(e => e.UpdatedByUser).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserIdFk)
                .HasMaxLength(128)
                .HasColumnName("UserId_Fk");

            entity.HasOne(d => d.DistributorIdFkNavigation).WithMany(p => p.UserDistributorM2ms)
                .HasForeignKey(d => d.DistributorIdFk)
                .HasConstraintName("FK_UserDistributorM2M.DistributorId");

            entity.HasOne(d => d.UserIdFkNavigation).WithMany(p => p.UserDistributorM2ms)
                .HasForeignKey(d => d.UserIdFk)
                .HasConstraintName("FK_UserDistributorM2M.UserId");
        });

        modelBuilder.Entity<UserRefreshToken>(entity =>
        {
            entity.ToTable("UserRefreshToken");

            entity.Property(e => e.RefreshToken).HasMaxLength(100);
            entity.Property(e => e.TokenExpiry).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<UserRoleM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC07AD58981D");

            entity.ToTable("UserRoleM2M", tb =>
                {
                    tb.HasTrigger("trgAfterAssigningRole");
                    tb.HasTrigger("trgAfterRoleAccessUpdate");
                });

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RoleIdFk).HasColumnName("RoleId_Fk");
            entity.Property(e => e.UpdatedByUser).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserIdFk)
                .HasMaxLength(128)
                .HasColumnName("UserId_Fk");

            entity.HasOne(d => d.RoleIdFkNavigation).WithMany(p => p.UserRoleM2ms)
                .HasForeignKey(d => d.RoleIdFk)
                .HasConstraintName("FK_UserRoleM2M.RoleId");

            entity.HasOne(d => d.UserIdFkNavigation).WithMany(p => p.UserRoleM2ms)
                .HasForeignKey(d => d.UserIdFk)
                .HasConstraintName("FK_UserRoleM2M.UserId");
        });

        modelBuilder.Entity<UserSiteM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User_Sit__3214EC27F317C486");

            entity.ToTable("User_Site_M2M");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");

            entity.HasOne(d => d.Customer).WithMany(p => p.UserSiteM2ms)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerID_2");

            entity.HasOne(d => d.User).WithMany(p => p.UserSiteM2ms)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserID_2");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.ToTable("UserType");

            entity.Property(e => e.UserType1).HasColumnName("UserType");
        });

        modelBuilder.Entity<UserUserTypeM2m>(entity =>
        {
            entity.ToTable("User_UserType_M2M", tb =>
                {
                    tb.HasTrigger("trgAfterAssigningOtherAccessLevels");
                    tb.HasTrigger("trgAfterOtherAccessLevelsUpdate");
                });

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<Variable>(entity =>
        {
            entity.HasKey(e => e.VId).HasName("PK__VARIABLE__B35D77AC840AB39D");

            entity.ToTable("VARIABLE");

            entity.Property(e => e.VId).HasColumnName("V_ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VMappedName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("V_Mapped_Name");
            entity.Property(e => e.VName)
                .HasMaxLength(250)
                .HasColumnName("V_Name");
            entity.Property(e => e.VSymbol)
                .HasMaxLength(250)
                .HasColumnName("V_Symbol");
        });

        modelBuilder.Entity<ViewLostTree>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Lost_Tree");

            entity.Property(e => e.ClosingStockUncorrected).HasColumnName("CLosing_Stock_Uncorrected");
            entity.Property(e => e.Curr)
                .HasColumnType("datetime")
                .HasColumnName("curr");
            entity.Property(e => e.OpeningStockUncorrected).HasColumnName("Opening_Stock_Uncorrected");
            entity.Property(e => e.PmdCentralLoop).HasColumnName("PMD_Central_Loop");
            entity.Property(e => e.PmdFloorSweep).HasColumnName("PMD_Floor_Sweep");
            entity.Property(e => e.PmdInputCorrected).HasColumnName("PMD_Input_Corrected");
            entity.Property(e => e.PmdKnockouts).HasColumnName("PMD_Knockouts");
            entity.Property(e => e.PmdLaminaDust).HasColumnName("PMD_lamina_Dust");
            entity.Property(e => e.PmdOutputUncorrected).HasColumnName("PMD_output_Uncorrected");
            entity.Property(e => e.PmdStemDust).HasColumnName("PMD_Stem_Dust");
            entity.Property(e => e.PmdUnaccountable).HasColumnName("PMD_Unaccountable");
            entity.Property(e => e.PmdWetWaste).HasColumnName("PMD_Wet_Waste");
            entity.Property(e => e.SmdCigWaste).HasColumnName("SMD_Cig_Waste");
            entity.Property(e => e.SmdDust).HasColumnName("SMD_Dust");
            entity.Property(e => e.SmdFloorSweep).HasColumnName("SMD_floor_Sweep");
            entity.Property(e => e.SmdOutputCigWeight).HasColumnName("SMD_Output_Cig_Weight");
            entity.Property(e => e.SmdOutputCorrected).HasColumnName("SMD_Output_Corrected");
            entity.Property(e => e.SmdSpecLoss).HasColumnName("SMD_SpecLoss");
            entity.Property(e => e.SmdUsableReceived).HasColumnName("SMD_Usable_received");
            entity.Property(e => e.VWay).HasColumnName("V_Way");
        });

        modelBuilder.Entity<ViewTobaccoWasteDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Tobacco_Waste_Date");

            entity.Property(e => e.Curr)
                .HasColumnType("datetime")
                .HasColumnName("CURR");
            entity.Property(e => e.Day)
                .HasMaxLength(30)
                .HasColumnName("DAY");
            entity.Property(e => e.Prev)
                .HasColumnType("datetime")
                .HasColumnName("PREV");
            entity.Property(e => e.TwoPrev)
                .HasColumnType("datetime")
                .HasColumnName("TWO_PREV");
        });

        modelBuilder.Entity<ViewUnaccountable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Unaccountable");

            entity.Property(e => e.Curr)
                .HasColumnType("datetime")
                .HasColumnName("curr");
            entity.Property(e => e.PmdUnaccountable).HasColumnName("PMD_Unaccountable");
            entity.Property(e => e.SmdUnaccountable).HasColumnName("SMD_Unaccountable");
        });

        modelBuilder.Entity<ViewWasteTree>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Waste_Tree");

            entity.Property(e => e.ClosingStockUncorrected).HasColumnName("CLosing_Stock_Uncorrected");
            entity.Property(e => e.Curr)
                .HasColumnType("datetime")
                .HasColumnName("curr");
            entity.Property(e => e.OpeningStockUncorrected).HasColumnName("Opening_Stock_Uncorrected");
            entity.Property(e => e.PmdCentralLoop).HasColumnName("PMD_Central_Loop");
            entity.Property(e => e.PmdFloorSweep).HasColumnName("PMD_Floor_Sweep");
            entity.Property(e => e.PmdInputCorrected).HasColumnName("PMD_Input_Corrected");
            entity.Property(e => e.PmdKnockouts).HasColumnName("PMD_Knockouts");
            entity.Property(e => e.PmdLaminaDust).HasColumnName("PMD_lamina_Dust");
            entity.Property(e => e.PmdOutputUncorrected).HasColumnName("PMD_output_Uncorrected");
            entity.Property(e => e.PmdStemDust).HasColumnName("PMD_Stem_Dust");
            entity.Property(e => e.PmdWaste).HasColumnName("PMD_Waste");
            entity.Property(e => e.PmdWetWaste).HasColumnName("PMD_Wet_Waste");
            entity.Property(e => e.SmdCigWaste).HasColumnName("SMD_Cig_Waste");
            entity.Property(e => e.SmdDust).HasColumnName("SMD_Dust");
            entity.Property(e => e.SmdFloorSweep).HasColumnName("SMD_floor_Sweep");
            entity.Property(e => e.SmdInputCorrected).HasColumnName("SMD_Input_corrected");
            entity.Property(e => e.SmdOutputCigWeight).HasColumnName("SMD_Output_Cig_Weight");
            entity.Property(e => e.SmdOutputCorrected).HasColumnName("SMD_Output_Corrected");
            entity.Property(e => e.SmdSpecLoss).HasColumnName("SMD_SpecLoss");
            entity.Property(e => e.SmdUsableReceived).HasColumnName("SMD_Usable_received");
            entity.Property(e => e.SmdWaste).HasColumnName("SMD_Waste");
            entity.Property(e => e.VWay).HasColumnName("V_Way");
        });

        modelBuilder.Entity<WhatIfResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WhatIfRe__3214EC07B9B6D56D");

            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_ID_FK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.InputData)
                .IsUnicode(false)
                .HasColumnName("Input_Data");
            entity.Property(e => e.OutputData)
                .IsUnicode(false)
                .HasColumnName("Output_Data");
            entity.Property(e => e.Section).IsUnicode(false);
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_ID_FK");

            entity.HasOne(d => d.AssetIdFkNavigation).WithMany(p => p.WhatIfResults)
                .HasForeignKey(d => d.AssetIdFk)
                .HasConstraintName("FK__WhatIfRes__Asset__5852D887");

            entity.HasOne(d => d.SiteIdFkNavigation).WithMany(p => p.WhatIfResults)
                .HasForeignKey(d => d.SiteIdFk)
                .HasConstraintName("FK__WhatIfRes__Site___5946FCC0");
        });

        modelBuilder.Entity<WriteApiLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteApi__3214EC273F62371F");

            entity.ToTable("WriteApiLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomerName).HasMaxLength(200);
            entity.Property(e => e.ItemNamesRequest).HasColumnName("_item_names_request");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.SiteName).HasMaxLength(200);
            entity.Property(e => e.TagType)
                .HasMaxLength(100)
                .HasColumnName("tag_type");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<WriteApiLogArchiveDailyCountTotal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteApi__3214EC07FEE5392F");

            entity.ToTable("WriteApiLog_Archive_Daily_Count_Total");
        });

        modelBuilder.Entity<WriteApiLogArchiveDailyRecordTotal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteApi__3214EC077B94D551");

            entity.ToTable("WriteApiLog_Archive_Daily_Record_Total");
        });

        modelBuilder.Entity<WriteApiLogArchiveDailySizeTotal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteApi__3214EC07F8958973");

            entity.ToTable("WriteApiLog_Archive_Daily_Size_Total");
        });

        modelBuilder.Entity<WriteApiTableConfiguration>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__WriteApi__A4AE64B8C16FCF58");

            entity.ToTable("WriteApiTableConfiguration");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ConnectionString)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("connection_string");
            entity.Property(e => e.Consumergroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("consumergroup");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.DataConnectionName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("data_connection_name");
            entity.Property(e => e.DbName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("db_name");
            entity.Property(e => e.DbType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("db_type");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.IotHubName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IOT_hub_name");
            entity.Property(e => e.SiteName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("site_name");
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("table_name");
            entity.Property(e => e.TableType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("table_type");
        });

        modelBuilder.Entity<WriteBackLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteBac__3213E83F3A0D8B8D");

            entity.ToTable("WriteBack_Logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("updated_on");
        });

        modelBuilder.Entity<WriteBackParam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteBac__3213E83F6B28E14F");

            entity.ToTable("WriteBack_Params");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("updated_on");
        });

        modelBuilder.Entity<WriteBackProperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteBac__3213E83F87754C51");

            entity.ToTable("WriteBack_Properties");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(100)
                .HasColumnName("key");
            entity.Property(e => e.LogIdFk).HasColumnName("log_id_fk");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.LogIdFkNavigation).WithMany(p => p.WriteBackProperties)
                .HasForeignKey(d => d.LogIdFk)
                .HasConstraintName("FK_WriteBack_Logs");
        });

        modelBuilder.Entity<ZamilAlarmsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZamilAlarmsView");

            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionPerformedBy).HasMaxLength(128);
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AsId).HasColumnName("AS_Id");
            entity.Property(e => e.AstId).HasColumnName("AST_ID");
            entity.Property(e => e.CurrentValue).HasColumnName("Current_Value");
            entity.Property(e => e.DatId).HasColumnName("DAT_ID");
            entity.Property(e => e.DataAlarmActionGuid)
                .HasMaxLength(128)
                .HasColumnName("DataAlarmActionGUID");
            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ReadingTime)
                .HasColumnType("datetime")
                .HasColumnName("Reading_Time");
            entity.Property(e => e.StateId).HasColumnName("State_ID");
        });

        modelBuilder.Entity<ZdtTestSyncNewstagingZdt254Numeric>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zdt_test_sync_newstaging_zdt_254_NUMERIC");

            entity.Property(e => e.Min).HasColumnName("min");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
