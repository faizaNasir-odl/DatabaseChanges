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

    public virtual DbSet<ApxHealthParameter> ApxHealthParameters { get; set; }
     
    public virtual DbSet<ApxHealthParameterValue> ApxHealthParameterValues { get; set; }

    public virtual DbSet<ApxHealthTagGroup> ApxHealthTagGroups { get; set; }

    public virtual DbSet<ApxHealthTagGroupStatus> ApxHealthTagGroupStatuses { get; set; }

    public virtual DbSet<ApxParameter> ApxParameters { get; set; }

    public virtual DbSet<ApxParameterCategory> ApxParameterCategories { get; set; }

    public virtual DbSet<ApxParameterOutputMapping> ApxParameterOutputMappings { get; set; }

    public virtual DbSet<ApxStepsHeader> ApxStepsHeaders { get; set; }

    public virtual DbSet<ApxTemplateStep> ApxTemplateSteps { get; set; }

    public virtual DbSet<ApxTwinModel> ApxTwinModels { get; set; }

    public virtual DbSet<ApxWhatIfInput> ApxWhatIfInputs { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<AuditLogsDssTracking> AuditLogsDssTrackings { get; set; }

    public virtual DbSet<AutomationLog> AutomationLogs { get; set; }

    public virtual DbSet<AutomationLogsAlterSite> AutomationLogsAlterSites { get; set; }

    public virtual DbSet<AutomationLogsAlterSiteDssTracking> AutomationLogsAlterSiteDssTrackings { get; set; }

    public virtual DbSet<AutomationLogsDssTracking> AutomationLogsDssTrackings { get; set; }

    public virtual DbSet<AutomationLogsSitecreation> AutomationLogsSitecreations { get; set; }

    public virtual DbSet<AutomationLogsSitecreationDssTracking> AutomationLogsSitecreationDssTrackings { get; set; }

    public virtual DbSet<AzureRegion> AzureRegions { get; set; }

    public virtual DbSet<AzureRegionsDssTracking> AzureRegionsDssTrackings { get; set; }

    public virtual DbSet<BadUncertainAlarmsHistory> BadUncertainAlarmsHistories { get; set; }

    public virtual DbSet<BadUncertainAlarmsHistoryDssTracking> BadUncertainAlarmsHistoryDssTrackings { get; set; }

    public virtual DbSet<BatchJobQueryLanguage> BatchJobQueryLanguages { get; set; }

    public virtual DbSet<BatchJobQueryLanguagesDssTracking> BatchJobQueryLanguagesDssTrackings { get; set; }

    public virtual DbSet<BatchJobTableColumn> BatchJobTableColumns { get; set; }

    public virtual DbSet<BatchJobTableColumnsDssTracking> BatchJobTableColumnsDssTrackings { get; set; }

    public virtual DbSet<BatchJobTriggerType> BatchJobTriggerTypes { get; set; }

    public virtual DbSet<BatchJobTriggerTypesDssTracking> BatchJobTriggerTypesDssTrackings { get; set; }

    public virtual DbSet<BatchJobsDefinition> BatchJobsDefinitions { get; set; }

    public virtual DbSet<BatchJobsDefinitionDssTracking> BatchJobsDefinitionDssTrackings { get; set; }

    public virtual DbSet<BatchJobsScheduling> BatchJobsSchedulings { get; set; }

    public virtual DbSet<BatchJobsSchedulingDssTracking> BatchJobsSchedulingDssTrackings { get; set; }

    public virtual DbSet<BpmActivitiesDssTracking> BpmActivitiesDssTrackings { get; set; }

    public virtual DbSet<BpmActivitiesTestDssTracking> BpmActivitiesTestDssTrackings { get; set; }

    public virtual DbSet<BpmActivity> BpmActivities { get; set; }

    public virtual DbSet<BpmActivityDependenciesDssTracking> BpmActivityDependenciesDssTrackings { get; set; }

    public virtual DbSet<BpmActivityDependenciesGuidDssTracking> BpmActivityDependenciesGuidDssTrackings { get; set; }

    public virtual DbSet<BpmActivityDependency> BpmActivityDependencies { get; set; }

    public virtual DbSet<BpmActivityGlobalVar> BpmActivityGlobalVars { get; set; }

    public virtual DbSet<BpmActivityLevel> BpmActivityLevels { get; set; }

    public virtual DbSet<BpmActivityLevelsDssTracking> BpmActivityLevelsDssTrackings { get; set; }

    public virtual DbSet<BpmActivityLevelsGuidDssTracking> BpmActivityLevelsGuidDssTrackings { get; set; }

    public virtual DbSet<BpmActivityLevelsTestingDssTracking> BpmActivityLevelsTestingDssTrackings { get; set; }

    public virtual DbSet<BpmActivityMetadataDssTracking> BpmActivityMetadataDssTrackings { get; set; }

    public virtual DbSet<BpmJob> BpmJobs { get; set; }

    public virtual DbSet<BpmJobsDssTracking> BpmJobsDssTrackings { get; set; }

    public virtual DbSet<BpmactivityQueriesDssTracking> BpmactivityQueriesDssTrackings { get; set; }

    public virtual DbSet<BpmjobsScheduling> BpmjobsSchedulings { get; set; }


    public virtual DbSet<BufferDssTracking> BufferDssTrackings { get; set; }

    public virtual DbSet<BulkDeviceReplicationLog> BulkDeviceReplicationLogs { get; set; }

    public virtual DbSet<BulkDeviceReplicationLogDevice> BulkDeviceReplicationLogDevices { get; set; }

    public virtual DbSet<BulkDeviceReplicationLogDevicesDssTracking> BulkDeviceReplicationLogDevicesDssTrackings { get; set; }

    public virtual DbSet<BulkDeviceReplicationLogsDssTracking> BulkDeviceReplicationLogsDssTrackings { get; set; }

    public virtual DbSet<CalculatedTag> CalculatedTags { get; set; }

    public virtual DbSet<ConditionalCalculation> ConditionalCalculations { get; set; }

    public virtual DbSet<CurveDatum> CurveData { get; set; }

    public virtual DbSet<CurveHeader> CurveHeaders { get; set; }

    public virtual DbSet<CurveHeadersDssTracking> CurveHeadersDssTrackings { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerDssTracking> CustomerDssTrackings { get; set; }

    public virtual DbSet<DataAlarm> DataAlarms { get; set; }

    public virtual DbSet<DataAlarmAction> DataAlarmActions { get; set; }

    public virtual DbSet<DataAlarmActionDssTracking> DataAlarmActionDssTrackings { get; set; }

    public virtual DbSet<DataAlarmActionHistory> DataAlarmActionHistories { get; set; }

    public virtual DbSet<DataAlarmActionHistoryDssTracking> DataAlarmActionHistoryDssTrackings { get; set; }

    public virtual DbSet<DataAlarmDssTracking> DataAlarmDssTrackings { get; set; }

    public virtual DbSet<DataAlarmState> DataAlarmStates { get; set; }

    public virtual DbSet<DataAlarmStatesConfig> DataAlarmStatesConfigs { get; set; }

    public virtual DbSet<DesignDatum> DesignData { get; set; }

    public virtual DbSet<DesignParameter> DesignParameters { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DeviceDlSetting> DeviceDlSettings { get; set; }

    public virtual DbSet<DeviceDlSettingsDssTracking> DeviceDlSettingsDssTrackings { get; set; }

    public virtual DbSet<DeviceModbusSetting> DeviceModbusSettings { get; set; }

    public virtual DbSet<DeviceModbusSettingsDssTracking> DeviceModbusSettingsDssTrackings { get; set; }

    public virtual DbSet<DeviceOpcServerM2m> DeviceOpcServerM2ms { get; set; }

    public virtual DbSet<DeviceOpcServerM2mDssTracking> DeviceOpcServerM2mDssTrackings { get; set; }

    public virtual DbSet<DeviceOpcSetting> DeviceOpcSettings { get; set; }

    public virtual DbSet<DeviceOpcSettingsDssTracking> DeviceOpcSettingsDssTrackings { get; set; }

    public virtual DbSet<DevicePlatform> DevicePlatforms { get; set; }

    public virtual DbSet<DevicePlatformDssTracking> DevicePlatformDssTrackings { get; set; }

    public virtual DbSet<DeviceTimeStampIdmapping> DeviceTimeStampIdmappings { get; set; }

    public virtual DbSet<DeviceTimeStampIdmappingDssTracking> DeviceTimeStampIdmappingDssTrackings { get; set; }

    public virtual DbSet<DeviceType> DeviceTypes { get; set; }

    public virtual DbSet<DeviceTypeDssTracking> DeviceTypeDssTrackings { get; set; }

    public virtual DbSet<DevicesDssTracking> DevicesDssTrackings { get; set; }

    public virtual DbSet<DevicesSitesM2m> DevicesSitesM2ms { get; set; }

    public virtual DbSet<DevicesSitesM2mDssTracking> DevicesSitesM2mDssTrackings { get; set; }

    public virtual DbSet<Distributor> Distributors { get; set; }

    public virtual DbSet<DistributorDssTracking> DistributorDssTrackings { get; set; }

    public virtual DbSet<DistributorProductM2m> DistributorProductM2ms { get; set; }

    public virtual DbSet<DistributorProductM2mDssTracking> DistributorProductM2mDssTrackings { get; set; }

    public virtual DbSet<EdgeConfigurationTimeLine> EdgeConfigurationTimeLines { get; set; }

    public virtual DbSet<EdgeConfigurationTimeLineDssTracking> EdgeConfigurationTimeLineDssTrackings { get; set; }

    public virtual DbSet<EdgeDevice> EdgeDevices { get; set; }

    public virtual DbSet<EdgeDeviceDssTracking> EdgeDeviceDssTrackings { get; set; }

    public virtual DbSet<EnpAzureRelayConnectionDetail> EnpAzureRelayConnectionDetails { get; set; }

    public virtual DbSet<EnpAzureRelayConnectionDetailsDssTracking> EnpAzureRelayConnectionDetailsDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorApiUrl> EnpConnectorApiUrls { get; set; }

    public virtual DbSet<EnpConnectorApiUrlsDssTracking> EnpConnectorApiUrlsDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorConnector> EnpConnectorConnectors { get; set; }

    public virtual DbSet<EnpConnectorConnectorType> EnpConnectorConnectorTypes { get; set; }

    public virtual DbSet<EnpConnectorConnectorTypeDssTracking> EnpConnectorConnectorTypeDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorConnectorsDssTracking> EnpConnectorConnectorsDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorDatatypeAzureSql> EnpConnectorDatatypeAzureSqls { get; set; }

    public virtual DbSet<EnpConnectorDatatypeAzureSqlDssTracking> EnpConnectorDatatypeAzureSqlDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorDatatypeInterimService> EnpConnectorDatatypeInterimServices { get; set; }

    public virtual DbSet<EnpConnectorDatatypeInterimServiceDssTracking> EnpConnectorDatatypeInterimServiceDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorDatatypeSapHana> EnpConnectorDatatypeSapHanas { get; set; }

    public virtual DbSet<EnpConnectorDatatypeSapHanaAzureSql> EnpConnectorDatatypeSapHanaAzureSqls { get; set; }

    public virtual DbSet<EnpConnectorDatatypeSapHanaAzureSqlDssTracking> EnpConnectorDatatypeSapHanaAzureSqlDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorDatatypeSapHanaDssTracking> EnpConnectorDatatypeSapHanaDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorPipeline> EnpConnectorPipelines { get; set; }

    public virtual DbSet<EnpConnectorPipelineDssTracking> EnpConnectorPipelineDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorPipelineMapping> EnpConnectorPipelineMappings { get; set; }

    public virtual DbSet<EnpConnectorPipelineMappingDssTracking> EnpConnectorPipelineMappingDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorPipelineTrigger> EnpConnectorPipelineTriggers { get; set; }

    public virtual DbSet<EnpConnectorPipelineTriggerDssTracking> EnpConnectorPipelineTriggerDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorPipelineTriggerType> EnpConnectorPipelineTriggerTypes { get; set; }

    public virtual DbSet<EnpConnectorPipelineTriggerTypeDssTracking> EnpConnectorPipelineTriggerTypeDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorPipelineWriteBehaviour> EnpConnectorPipelineWriteBehaviours { get; set; }

    public virtual DbSet<EnpConnectorPipelineWriteBehaviourDssTracking> EnpConnectorPipelineWriteBehaviourDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorPipelineWriteOption> EnpConnectorPipelineWriteOptions { get; set; }

    public virtual DbSet<EnpConnectorPipelineWriteOptionDssTracking> EnpConnectorPipelineWriteOptionDssTrackings { get; set; }

    public virtual DbSet<EnpConnectorSqlAutomation> EnpConnectorSqlAutomations { get; set; }

    public virtual DbSet<EnpConnectorSqlAutomationDssTracking> EnpConnectorSqlAutomationDssTrackings { get; set; }

    public virtual DbSet<EnumType> EnumTypes { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventCategory> EventCategories { get; set; }

    public virtual DbSet<EventCategoryDssTracking> EventCategoryDssTrackings { get; set; }

    public virtual DbSet<EventComponent> EventComponents { get; set; }

    public virtual DbSet<EventComponentDssTracking> EventComponentDssTrackings { get; set; }

    public virtual DbSet<EventComponentLookup> EventComponentLookups { get; set; }

    public virtual DbSet<EventComponentLookupDssTracking> EventComponentLookupDssTrackings { get; set; }

    public virtual DbSet<EventsDssTracking> EventsDssTrackings { get; set; }

    public virtual DbSet<ExceptionLogging> ExceptionLoggings { get; set; }

    public virtual DbSet<ExceptionLoggingDssTracking> ExceptionLoggingDssTrackings { get; set; }

    public virtual DbSet<Export5> Export5s { get; set; }

    public virtual DbSet<ExportPipeLine> ExportPipeLines { get; set; }

    public virtual DbSet<ExportPipeLineDssTracking> ExportPipeLineDssTrackings { get; set; }

    public virtual DbSet<ExportSiteLayOutStatus> ExportSiteLayOutStatuses { get; set; }

    public virtual DbSet<ExportSiteLayOutStatusDssTracking> ExportSiteLayOutStatusDssTrackings { get; set; }

    public virtual DbSet<ExportToExcelStatus> ExportToExcelStatuses { get; set; }

    public virtual DbSet<ExportToExcelStatusDssTracking> ExportToExcelStatusDssTrackings { get; set; }

    public virtual DbSet<ExportZamil> ExportZamils { get; set; }

    public virtual DbSet<ExportedKohinoor> ExportedKohinoors { get; set; }

    public virtual DbSet<FastAlarm> FastAlarms { get; set; }

    public virtual DbSet<FastAlarmsDssTracking> FastAlarmsDssTrackings { get; set; }

    public virtual DbSet<FintechSiteShiftsConfiguration> FintechSiteShiftsConfigurations { get; set; }

    public virtual DbSet<FintechSiteShiftsConfigurationsDssTracking> FintechSiteShiftsConfigurationsDssTrackings { get; set; }

    public virtual DbSet<FintechTankDelivery> FintechTankDeliveries { get; set; }

    public virtual DbSet<FintechTankDeliveryDssTracking> FintechTankDeliveryDssTrackings { get; set; }

    public virtual DbSet<FintechTransactionstype> FintechTransactionstypes { get; set; }

    public virtual DbSet<FintechTransactionstypeDssTracking> FintechTransactionstypeDssTrackings { get; set; }

    public virtual DbSet<FmLogin> FmLogins { get; set; }

    public virtual DbSet<FmLoginDssTracking> FmLoginDssTrackings { get; set; }

    public virtual DbSet<FormatTable> FormatTables { get; set; }

    public virtual DbSet<FormatTableDssTracking> FormatTableDssTrackings { get; set; }

    public virtual DbSet<FormulaDependenciesMetrix> FormulaDependenciesMetrixes { get; set; }

    public virtual DbSet<FormulaDependenciesMetrixDssTracking> FormulaDependenciesMetrixDssTrackings { get; set; }

    public virtual DbSet<FormulaLibrary> FormulaLibraries { get; set; }

    public virtual DbSet<FormulaLibraryDssTracking> FormulaLibraryDssTrackings { get; set; }

    public virtual DbSet<FormulaLibraryHistory> FormulaLibraryHistories { get; set; }

    public virtual DbSet<FormulaLibraryHistoryDssTracking> FormulaLibraryHistoryDssTrackings { get; set; }

    public virtual DbSet<HubcoNelManual> HubcoNelManuals { get; set; }

    public virtual DbSet<HubcoNelManualDssTracking> HubcoNelManualDssTrackings { get; set; }

    public virtual DbSet<ImportFile> ImportFiles { get; set; }

    public virtual DbSet<ImportFileStatus> ImportFileStatuses { get; set; }

    public virtual DbSet<ImportFileStatusDssTracking> ImportFileStatusDssTrackings { get; set; }

    public virtual DbSet<ImportFilesDssTracking> ImportFilesDssTrackings { get; set; }

    public virtual DbSet<IndustryType> IndustryTypes { get; set; }

    public virtual DbSet<IndustryTypeDssTracking> IndustryTypeDssTrackings { get; set; }

    public virtual DbSet<IngestionStatus> IngestionStatuses { get; set; }

    public virtual DbSet<IngestionStatusDssTracking> IngestionStatusDssTrackings { get; set; }

    public virtual DbSet<IotDeviceMetric> IotDeviceMetrics { get; set; }

    public virtual DbSet<IotDeviceMetricsDssTracking> IotDeviceMetricsDssTrackings { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobExecutionLog> JobExecutionLogs { get; set; }

    public virtual DbSet<JobExecutionLogsDssTracking> JobExecutionLogsDssTrackings { get; set; }

    public virtual DbSet<KpiFormula> KpiFormulas { get; set; }

    public virtual DbSet<KpiFormulaDssTracking> KpiFormulaDssTrackings { get; set; }

    public virtual DbSet<KpiFormulaVariableM2M> KpiFormulaVariableM2Ms { get; set; }

    public virtual DbSet<KpiFormulaVariableM2MDssTracking> KpiFormulaVariableM2MDssTrackings { get; set; }

    public virtual DbSet<KpiSFormulaAttachment> KpiSFormulaAttachments { get; set; }

    public virtual DbSet<KpiSFormulaAttachmentDssTracking> KpiSFormulaAttachmentDssTrackings { get; set; }

    public virtual DbSet<KpieIpTagsDataDssTracking> KpieIpTagsDataDssTrackings { get; set; }

    public virtual DbSet<KpieIpTagsDatum> KpieIpTagsData { get; set; }

    public virtual DbSet<KpieIpTagsParameter> KpieIpTagsParameters { get; set; }

    public virtual DbSet<LogDetail> LogDetails { get; set; }

    public virtual DbSet<LogEvent> LogEvents { get; set; }

    public virtual DbSet<OutputTagDatum> OutputTagData { get; set; }

    public virtual DbSet<OutputTagParameter> OutputTagParameters { get; set; }

    public virtual DbSet<PipeLineTag> PipeLineTags { get; set; }

    public virtual DbSet<PipeLineTagsDssTracking> PipeLineTagsDssTrackings { get; set; }

    public virtual DbSet<PlantSite> PlantSites { get; set; }

    public virtual DbSet<PlantSiteDssTracking> PlantSiteDssTrackings { get; set; }

    public virtual DbSet<PlantSiteEmailTracking> PlantSiteEmailTrackings { get; set; }

    public virtual DbSet<PlantSiteEmailTrackingDssTracking> PlantSiteEmailTrackingDssTrackings { get; set; }

    public virtual DbSet<ProcessAlarm> ProcessAlarms { get; set; }

    public virtual DbSet<ProcessAlarmDssTracking> ProcessAlarmDssTrackings { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsDssTracking> ProductsDssTrackings { get; set; }

    public virtual DbSet<ProvisionMarkerDss> ProvisionMarkerDsses { get; set; }

    public virtual DbSet<Pump> Pumps { get; set; }

    public virtual DbSet<PumpsDssTracking> PumpsDssTrackings { get; set; }

    public virtual DbSet<QualityManualEntryFibexDataDssTracking> QualityManualEntryFibexDataDssTrackings { get; set; }

    public virtual DbSet<QualityManualEntryFibexDatum> QualityManualEntryFibexData { get; set; }

    public virtual DbSet<QualityManualEntryMoistureContentFilledValue> QualityManualEntryMoistureContentFilledValues { get; set; }

    public virtual DbSet<QualityManualEntryMoistureContentFilledValueDssTracking> QualityManualEntryMoistureContentFilledValueDssTrackings { get; set; }

    public virtual DbSet<QualityManualEntryNtw> QualityManualEntryNtws { get; set; }

    public virtual DbSet<QualityManualEntryNtwDssTracking> QualityManualEntryNtwDssTrackings { get; set; }

    public virtual DbSet<QualityManualNtwConstantValue> QualityManualNtwConstantValues { get; set; }

    public virtual DbSet<QualityManualNtwConstantValuesDssTracking> QualityManualNtwConstantValuesDssTrackings { get; set; }

    public virtual DbSet<RawTagTarget> RawTagTargets { get; set; }

    public virtual DbSet<RawTagTargetMonYear> RawTagTargetMonYears { get; set; }

    public virtual DbSet<RawTagTargetMonYearDssTracking> RawTagTargetMonYearDssTrackings { get; set; }

    public virtual DbSet<RawTagTargetMonYearHistory> RawTagTargetMonYearHistories { get; set; }

    public virtual DbSet<RawTagTargetMonYearHistoryDssTracking> RawTagTargetMonYearHistoryDssTrackings { get; set; }

    public virtual DbSet<RawTagTargetsDssTracking> RawTagTargetsDssTrackings { get; set; }

    public virtual DbSet<RawTagsTargetsHistory> RawTagsTargetsHistories { get; set; }

    public virtual DbSet<RawTagsTargetsHistoryDssTracking> RawTagsTargetsHistoryDssTrackings { get; set; }

    public virtual DbSet<ReadApiLimiter> ReadApiLimiters { get; set; }

    public virtual DbSet<ReadApiLimiterDssTracking> ReadApiLimiterDssTrackings { get; set; }

    public virtual DbSet<ReadApiLog> ReadApiLogs { get; set; }

    public virtual DbSet<ReadApiLogDssTracking> ReadApiLogDssTrackings { get; set; }

    public virtual DbSet<ReadApilimit> ReadApilimits { get; set; }

    public virtual DbSet<ReadApilimitsDssTracking> ReadApilimitsDssTrackings { get; set; }

    public virtual DbSet<ReadapiPayload> ReadapiPayloads { get; set; }

    public virtual DbSet<ReadapiPayloadDssTracking> ReadapiPayloadDssTrackings { get; set; }

    public virtual DbSet<RealRawPoint> RealRawPoints { get; set; }

    public virtual DbSet<RealRawPointsDssTracking> RealRawPointsDssTrackings { get; set; }

    public virtual DbSet<RecipientGroup> RecipientGroups { get; set; }

    public virtual DbSet<RecipientGroupDssTracking> RecipientGroupDssTrackings { get; set; }

    public virtual DbSet<RecipientGroupM2m> RecipientGroupM2ms { get; set; }

    public virtual DbSet<RecipientGroupM2mDssTracking> RecipientGroupM2mDssTrackings { get; set; }

    public virtual DbSet<RecipientsGroup> RecipientsGroups { get; set; }

    public virtual DbSet<RecipientsGroupDssTracking> RecipientsGroupDssTrackings { get; set; }

    public virtual DbSet<RecipientsInfo> RecipientsInfos { get; set; }

    public virtual DbSet<RecipientsInfoDssTracking> RecipientsInfoDssTrackings { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<RegionDssTracking> RegionDssTrackings { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleDssTracking> RoleDssTrackings { get; set; }

    public virtual DbSet<RolePermissionM2m> RolePermissionM2ms { get; set; }

    public virtual DbSet<RolePermissionM2mDssTracking> RolePermissionM2mDssTrackings { get; set; }

    public virtual DbSet<Scaleunitlimit> Scaleunitlimits { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }

    public virtual DbSet<ScheduleTask1> ScheduleTasks1 { get; set; }

    public virtual DbSet<SchemaInfoDss> SchemaInfoDsses { get; set; }

    public virtual DbSet<ScopeConfigDss> ScopeConfigDsses { get; set; }

    public virtual DbSet<ScopeInfoDss> ScopeInfoDsses { get; set; }

    public virtual DbSet<SidefaultRegion> SidefaultRegions { get; set; }

    public virtual DbSet<SidefaultRegionDssTracking> SidefaultRegionDssTrackings { get; set; }

    public virtual DbSet<SiteComponentConfiguration> SiteComponentConfigurations { get; set; }

    public virtual DbSet<SiteComponentConfigurationDssTracking> SiteComponentConfigurationDssTrackings { get; set; }

    public virtual DbSet<SiteEventsM2m> SiteEventsM2ms { get; set; }

    public virtual DbSet<SiteEventsM2mDssTracking> SiteEventsM2mDssTrackings { get; set; }

    public virtual DbSet<SiteOpcDefaultSetting> SiteOpcDefaultSettings { get; set; }

    public virtual DbSet<SiteOpcDefaultSettingsDssTracking> SiteOpcDefaultSettingsDssTrackings { get; set; }

    public virtual DbSet<SiteRegionOne2m> SiteRegionOne2ms { get; set; }

    public virtual DbSet<SiteRegionOne2mDssTracking> SiteRegionOne2mDssTrackings { get; set; }

    public virtual DbSet<SourceTagImportStatus> SourceTagImportStatuses { get; set; }

    public virtual DbSet<SourceTagImportStatusDssTracking> SourceTagImportStatusDssTrackings { get; set; }

    public virtual DbSet<SourceTagParameter> SourceTagParameters { get; set; }

    public virtual DbSet<SourceTagParametersDssTracking> SourceTagParametersDssTrackings { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<SubscriptionTag> SubscriptionTags { get; set; }

    public virtual DbSet<SubscriptionTagsDssTracking> SubscriptionTagsDssTrackings { get; set; }

    public virtual DbSet<SyncObjectDatum> SyncObjectData { get; set; }

    public virtual DbSet<Syncgroup> Syncgroups { get; set; }

    public virtual DbSet<Syncgroupmember> Syncgroupmembers { get; set; }

    public virtual DbSet<SystemAlarmAction> SystemAlarmActions { get; set; }

    public virtual DbSet<SystemAlarmActionDssTracking> SystemAlarmActionDssTrackings { get; set; }

    public virtual DbSet<SystemAlarmActionHistory> SystemAlarmActionHistories { get; set; }

    public virtual DbSet<SystemAlarmActionHistoryDssTracking> SystemAlarmActionHistoryDssTrackings { get; set; }

    public virtual DbSet<SystemIntegrator> SystemIntegrators { get; set; }

    public virtual DbSet<SystemIntegratorDssTracking> SystemIntegratorDssTrackings { get; set; }

    public virtual DbSet<TagLakeLastUpdate> TagLakeLastUpdates { get; set; }

    public virtual DbSet<TagType> TagTypes { get; set; }

    public virtual DbSet<TagTypesDssTracking> TagTypesDssTrackings { get; set; }

    public virtual DbSet<TagsDataType> TagsDataTypes { get; set; }

    public virtual DbSet<TagsDataTypeDssTracking> TagsDataTypeDssTrackings { get; set; }

    public virtual DbSet<Tank> Tanks { get; set; }

    public virtual DbSet<TankDssTracking> TankDssTrackings { get; set; }

    public virtual DbSet<TankStatusLive> TankStatusLives { get; set; }

    public virtual DbSet<TankStatusLiveDssTracking> TankStatusLiveDssTrackings { get; set; }


    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductDssTracking> TblProductDssTrackings { get; set; }

    public virtual DbSet<TblTankStatus> TblTankStatuses { get; set; }

    public virtual DbSet<TblTankStatusDssTracking> TblTankStatusDssTrackings { get; set; }

    public virtual DbSet<TblTransaction> TblTransactions { get; set; }

    public virtual DbSet<TblTransactionsDssTracking> TblTransactionsDssTrackings { get; set; }

    public virtual DbSet<TestApi> TestApis { get; set; }

    public virtual DbSet<TestingTankStatus> TestingTankStatuses { get; set; }

    public virtual DbSet<TestingTankStatusDssTracking> TestingTankStatusDssTrackings { get; set; }

    public virtual DbSet<TimeBasedEntityAccess> TimeBasedEntityAccesses { get; set; }

    public virtual DbSet<TimeBasedEntityAccessDssTracking> TimeBasedEntityAccessDssTrackings { get; set; }

    public virtual DbSet<TobaccoWasteConstantValue> TobaccoWasteConstantValues { get; set; }

    public virtual DbSet<TobaccoWasteConstantValuesDssTracking> TobaccoWasteConstantValuesDssTrackings { get; set; }

    public virtual DbSet<TobaccoWasteManualEntry> TobaccoWasteManualEntries { get; set; }

    public virtual DbSet<TobaccoWasteManualEntryDssTracking> TobaccoWasteManualEntryDssTrackings { get; set; }

    public virtual DbSet<TrendingReport> TrendingReports { get; set; }

    public virtual DbSet<TrendingReportFilter> TrendingReportFilters { get; set; }

    public virtual DbSet<TrendingReportFiltersDssTracking> TrendingReportFiltersDssTrackings { get; set; }

    public virtual DbSet<TrendingReportTag> TrendingReportTags { get; set; }

    public virtual DbSet<TrendingReportTagsDssTracking> TrendingReportTagsDssTrackings { get; set; }

    public virtual DbSet<TrendingReportsDssTracking> TrendingReportsDssTrackings { get; set; }

    public virtual DbSet<TrendingReportsShared> TrendingReportsShareds { get; set; }

    public virtual DbSet<TrendingReportsSharedDssTracking> TrendingReportsSharedDssTrackings { get; set; }

    public virtual DbSet<TriggeredDataAlarm> TriggeredDataAlarms { get; set; }

    public virtual DbSet<TriggeredDataAlarmDssTracking> TriggeredDataAlarmDssTrackings { get; set; }

    public virtual DbSet<Uihistory> Uihistories { get; set; }

    public virtual DbSet<UserActivityLogging> UserActivityLoggings { get; set; }

    public virtual DbSet<UserActivityLoggingDssTracking> UserActivityLoggingDssTrackings { get; set; }

    public virtual DbSet<UserArea> UserAreas { get; set; }

    public virtual DbSet<UserAreasDssTracking> UserAreasDssTrackings { get; set; }

    public virtual DbSet<UserAsset> UserAssets { get; set; }

    public virtual DbSet<UserAssetsDssTracking> UserAssetsDssTrackings { get; set; }

    public virtual DbSet<UserControlSystemIntegratorM2m> UserControlSystemIntegratorM2ms { get; set; }

    public virtual DbSet<UserControlSystemIntegratorM2mDssTracking> UserControlSystemIntegratorM2mDssTrackings { get; set; }

    public virtual DbSet<UserCustomerM2m> UserCustomerM2ms { get; set; }

    public virtual DbSet<UserCustomerM2mDssTracking> UserCustomerM2mDssTrackings { get; set; }

    public virtual DbSet<UserDistributorM2m> UserDistributorM2ms { get; set; }

    public virtual DbSet<UserDistributorM2mDssTracking> UserDistributorM2mDssTrackings { get; set; }

    public virtual DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

    public virtual DbSet<UserRefreshTokenDssTracking> UserRefreshTokenDssTrackings { get; set; }

    public virtual DbSet<UserRoleM2m> UserRoleM2ms { get; set; }

    public virtual DbSet<UserRoleM2mDssTracking> UserRoleM2mDssTrackings { get; set; }

    public virtual DbSet<UserSiteM2m> UserSiteM2ms { get; set; }

    public virtual DbSet<UserSiteM2mDssTracking> UserSiteM2mDssTrackings { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<UserTypeDssTracking> UserTypeDssTrackings { get; set; }

    public virtual DbSet<UserUserTypeM2m> UserUserTypeM2ms { get; set; }

    public virtual DbSet<UserUserTypeM2mDssTracking> UserUserTypeM2mDssTrackings { get; set; }

    public virtual DbSet<Userdatabase> Userdatabases { get; set; }

    public virtual DbSet<Variable> Variables { get; set; }

    public virtual DbSet<VariableDssTracking> VariableDssTrackings { get; set; }

    public virtual DbSet<ViewLostTree> ViewLostTrees { get; set; }

    public virtual DbSet<ViewTobaccoWasteDate> ViewTobaccoWasteDates { get; set; }

    public virtual DbSet<ViewUnaccountable> ViewUnaccountables { get; set; }

    public virtual DbSet<ViewWasteTree> ViewWasteTrees { get; set; }

    public virtual DbSet<WhatIfResult> WhatIfResults { get; set; }

    public virtual DbSet<WhatIfResultsDssTracking> WhatIfResultsDssTrackings { get; set; }

    public virtual DbSet<WriteApiLog> WriteApiLogs { get; set; }

    public virtual DbSet<WriteApiLogDssTracking> WriteApiLogDssTrackings { get; set; }

    public virtual DbSet<WriteApiTableConfiguration> WriteApiTableConfigurations { get; set; }

    public virtual DbSet<WriteApiTableConfigurationDssTracking> WriteApiTableConfigurationDssTrackings { get; set; }

    public virtual DbSet<WriteBackLog> WriteBackLogs { get; set; }

    public virtual DbSet<WriteBackLogsDssTracking> WriteBackLogsDssTrackings { get; set; }

    public virtual DbSet<WriteBackParam> WriteBackParams { get; set; }

    public virtual DbSet<WriteBackParamsDssTracking> WriteBackParamsDssTrackings { get; set; }

    public virtual DbSet<WriteBackPropertiesDssTracking> WriteBackPropertiesDssTrackings { get; set; }

    public virtual DbSet<WriteBackProperty> WriteBackProperties { get; set; }

    public virtual DbSet<ZamilAlarmsView> ZamilAlarmsViews { get; set; }

    public virtual DbSet<ZdtTestSyncNewstagingZdt254Numeric> ZdtTestSyncNewstagingZdt254Numerics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=oc-modernization-blue.database.windows.net; Database= ocm-staging; User Id=octopus; Password=avanceon@786;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<AdxDataType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdxDataT__3214EC07A3486FCF");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("AdxDataTypes_dss_delete_trigger");
                    tb.HasTrigger("AdxDataTypes_dss_insert_trigger");
                    tb.HasTrigger("AdxDataTypes_dss_update_trigger");
                });

            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<AdxDataTypesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AdxDataTypes_dss_tracking");

            entity.ToTable("AdxDataTypes_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__agent__3213E83F117ABD55");

            entity.ToTable("agent", "dss");

            entity.HasIndex(e => new { e.Subscriptionid, e.Name }, "IX_Agent_SubId_Name").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IsOnPremise).HasColumnName("is_on_premise");
            entity.Property(e => e.Lastalivetime)
                .HasColumnType("datetime")
                .HasColumnName("lastalivetime");
            entity.Property(e => e.Name)
                .HasMaxLength(140)
                .HasColumnName("name");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(256)
                .HasColumnName("password_hash");
            entity.Property(e => e.PasswordSalt)
                .HasMaxLength(256)
                .HasColumnName("password_salt");
            entity.Property(e => e.State)
                .HasDefaultValueSql("((1))")
                .HasColumnName("state");
            entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");
            entity.Property(e => e.Version)
                .HasMaxLength(40)
                .HasColumnName("version");

            entity.HasOne(d => d.Subscription).WithMany(p => p.Agents)
                .HasForeignKey(d => d.Subscriptionid)
                .HasConstraintName("FK__agent__subscript");
        });

        modelBuilder.Entity<AgentInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__agent_in__3213E83F23400876");

            entity.ToTable("agent_instance", "dss");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Agentid).HasColumnName("agentid");
            entity.Property(e => e.Lastalivetime)
                .HasColumnType("datetime")
                .HasColumnName("lastalivetime");
            entity.Property(e => e.Version)
                .HasMaxLength(40)
                .HasColumnName("version");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentInstances)
                .HasForeignKey(d => d.Agentid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__agent_ins__agent");
        });

        modelBuilder.Entity<AgentVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__agent_ve__3214EC070DC16763");

            entity.ToTable("agent_version", "dss");

            entity.HasIndex(e => e.Version, "UQ__agent_ve__0F540134865180CA").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasMaxLength(200);
            entity.Property(e => e.ExpiresOn)
                .HasDefaultValueSql("('9999-12-31 23:59:59.997')")
                .HasColumnType("datetime");
            entity.Property(e => e.Version).HasMaxLength(50);
        });

        modelBuilder.Entity<AlarmEngineTime>(entity =>
        {
            entity.HasKey(e => e.AetId).HasName("PK__Alarm_En__103B5A9B46A0E16A");

            entity.ToTable("Alarm_Engine_Time", tb =>
                {
                    tb.HasTrigger("Alarm_Engine_Time_dss_delete_trigger");
                    tb.HasTrigger("Alarm_Engine_Time_dss_insert_trigger");
                    tb.HasTrigger("Alarm_Engine_Time_dss_update_trigger");
                });

            entity.Property(e => e.AetId).HasColumnName("AET_ID");
            entity.Property(e => e.ProcessTime).HasColumnType("datetime");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
        });

        modelBuilder.Entity<AlarmEngineTimeDssTracking>(entity =>
        {
            entity.HasKey(e => e.AetId).HasName("PK_DataSync.Alarm_Engine_Time_dss_tracking");

            entity.ToTable("Alarm_Engine_Time_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.AetId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.AetId)
                .ValueGeneratedNever()
                .HasColumnName("AET_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AlarmPriority>(entity =>
        {
            entity.HasKey(e => e.AlarmPriorityId).HasName("PK__ALARM_PR__3BEB414D8A0FCD3F");

            entity.ToTable("ALARM_PRIORITY", tb =>
                {
                    tb.HasTrigger("ALARM_PRIORITY_dss_delete_trigger");
                    tb.HasTrigger("ALARM_PRIORITY_dss_insert_trigger");
                    tb.HasTrigger("ALARM_PRIORITY_dss_update_trigger");
                });

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

        modelBuilder.Entity<AlarmPriorityDssTracking>(entity =>
        {
            entity.HasKey(e => e.AlarmPriorityId).HasName("PK_DataSync.ALARM_PRIORITY_dss_tracking");

            entity.ToTable("ALARM_PRIORITY_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.AlarmPriorityId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.AlarmPriorityId)
                .ValueGeneratedNever()
                .HasColumnName("AlarmPriority_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AlarmRecipient>(entity =>
        {
            entity.HasKey(e => e.ArId).HasName("PK__ALARM_RE__003ED5D24CB73CEA");

            entity.ToTable("ALARM_RECIPIENT", tb =>
                {
                    tb.HasTrigger("ALARM_RECIPIENT_dss_delete_trigger");
                    tb.HasTrigger("ALARM_RECIPIENT_dss_insert_trigger");
                    tb.HasTrigger("ALARM_RECIPIENT_dss_update_trigger");
                });

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

        modelBuilder.Entity<AlarmRecipientDssTracking>(entity =>
        {
            entity.HasKey(e => e.ArId).HasName("PK_DataSync.ALARM_RECIPIENT_dss_tracking");

            entity.ToTable("ALARM_RECIPIENT_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ArId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ArId)
                .ValueGeneratedNever()
                .HasColumnName("AR_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AlarmRecipientM2m>(entity =>
        {
            entity.HasKey(e => e.ArmId).HasName("PK__ALARM_RE__AD65A7952EF9E00D");

            entity.ToTable("ALARM_RECIPIENT_M2M", tb =>
                {
                    tb.HasTrigger("ALARM_RECIPIENT_M2M_dss_delete_trigger");
                    tb.HasTrigger("ALARM_RECIPIENT_M2M_dss_insert_trigger");
                    tb.HasTrigger("ALARM_RECIPIENT_M2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<AlarmRecipientM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.ArmId).HasName("PK_DataSync.ALARM_RECIPIENT_M2M_dss_tracking");

            entity.ToTable("ALARM_RECIPIENT_M2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ArmId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ArmId)
                .ValueGeneratedNever()
                .HasColumnName("ARM_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AlarmRunningHistory>(entity =>
        {
            entity.ToTable("AlarmRunningHistory", tb =>
                {
                    tb.HasTrigger("AlarmRunningHistory_dss_delete_trigger");
                    tb.HasTrigger("AlarmRunningHistory_dss_insert_trigger");
                    tb.HasTrigger("AlarmRunningHistory_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LastProcessedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlarmRunningHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AlarmRunningHistory_dss_tracking");

            entity.ToTable("AlarmRunningHistory_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AlarmState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__ALARM_ST__AF9338D7B6B81A72");

            entity.ToTable("ALARM_STATES", tb =>
                {
                    tb.HasTrigger("ALARM_STATES_dss_delete_trigger");
                    tb.HasTrigger("ALARM_STATES_dss_insert_trigger");
                    tb.HasTrigger("ALARM_STATES_dss_update_trigger");
                });

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

            entity.ToTable("ALARM_STATES_CONFIG", tb =>
                {
                    tb.HasTrigger("ALARM_STATES_CONFIG_dss_delete_trigger");
                    tb.HasTrigger("ALARM_STATES_CONFIG_dss_insert_trigger");
                    tb.HasTrigger("ALARM_STATES_CONFIG_dss_update_trigger");
                });

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

        modelBuilder.Entity<AlarmStatesConfigDssTracking>(entity =>
        {
            entity.HasKey(e => e.AstId).HasName("PK_DataSync.ALARM_STATES_CONFIG_dss_tracking");

            entity.ToTable("ALARM_STATES_CONFIG_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.AstId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.AstId)
                .ValueGeneratedNever()
                .HasColumnName("AST_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AlarmStatesDssTracking>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK_DataSync.ALARM_STATES_dss_tracking");

            entity.ToTable("ALARM_STATES_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.StateId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.StateId)
                .ValueGeneratedNever()
                .HasColumnName("State_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AlarmStatusAction>(entity =>
        {
            entity.HasKey(e => e.AsId).HasName("PK__AlarmSta__E871DE2FD67A92CB");

            entity.ToTable("AlarmStatus_Actions", tb =>
                {
                    tb.HasTrigger("AlarmStatus_Actions_dss_delete_trigger");
                    tb.HasTrigger("AlarmStatus_Actions_dss_insert_trigger");
                    tb.HasTrigger("AlarmStatus_Actions_dss_update_trigger");
                });

            entity.Property(e => e.AsId)
                .ValueGeneratedNever()
                .HasColumnName("AS_Id");
            entity.Property(e => e.AsTitle)
                .HasMaxLength(200)
                .HasColumnName("AS_Title");
        });

        modelBuilder.Entity<AlarmStatusActionsDssTracking>(entity =>
        {
            entity.HasKey(e => e.AsId).HasName("PK_DataSync.AlarmStatus_Actions_dss_tracking");

            entity.ToTable("AlarmStatus_Actions_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.AsId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.AsId)
                .ValueGeneratedNever()
                .HasColumnName("AS_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AlarmsNotification>(entity =>
        {
            entity.HasKey(e => e.AnId).HasName("PK__ALARMS_N__6D7E8AE12BDCF92F");

            entity.ToTable("ALARMS_NOTIFICATION", tb =>
                {
                    tb.HasTrigger("ALARMS_NOTIFICATION_dss_delete_trigger");
                    tb.HasTrigger("ALARMS_NOTIFICATION_dss_insert_trigger");
                    tb.HasTrigger("ALARMS_NOTIFICATION_dss_update_trigger");
                });

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

        modelBuilder.Entity<AlarmsNotificationDssTracking>(entity =>
        {
            entity.HasKey(e => e.AnId).HasName("PK_DataSync.ALARMS_NOTIFICATION_dss_tracking");

            entity.ToTable("ALARMS_NOTIFICATION_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.AnId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.AnId)
                .ValueGeneratedNever()
                .HasColumnName("AN_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AnomalyDataDssTracking>(entity =>
        {
            entity.HasKey(e => new { e.TimeStamp, e.TagName }).HasName("PK_DataSync.AnomalyData_dss_tracking");

            entity.ToTable("AnomalyData_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.TimeStamp, e.TagName }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TagName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AnomalyDatum>(entity =>
        {
            entity.HasKey(e => new { e.TimeStamp, e.TagName }).HasName("PK__AnomalyD__6CBF4DB25C092BC7");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("AnomalyData_dss_delete_trigger");
                    tb.HasTrigger("AnomalyData_dss_insert_trigger");
                    tb.HasTrigger("AnomalyData_dss_update_trigger");
                });

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

            entity.ToTable("AnomalyDetectionGroup", tb =>
                {
                    tb.HasTrigger("AnomalyDetectionGroup_dss_delete_trigger");
                    tb.HasTrigger("AnomalyDetectionGroup_dss_insert_trigger");
                    tb.HasTrigger("AnomalyDetectionGroup_dss_update_trigger");
                });

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

        modelBuilder.Entity<AnomalyDetectionGroupDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AnomalyDetectionGroup_dss_tracking");

            entity.ToTable("AnomalyDetectionGroup_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AnomalyDetectionGroupResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC07E7FE4480");

            entity.ToTable("AnomalyDetectionGroupResult", tb =>
                {
                    tb.HasTrigger("AnomalyDetectionGroupResult_dss_delete_trigger");
                    tb.HasTrigger("AnomalyDetectionGroupResult_dss_insert_trigger");
                    tb.HasTrigger("AnomalyDetectionGroupResult_dss_update_trigger");
                });

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnomalyDetectionGroupResultDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AnomalyDetectionGroupResult_dss_tracking");

            entity.ToTable("AnomalyDetectionGroupResult_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AnomalyDetectionGroupTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC070416F05F");

            entity.ToTable("AnomalyDetectionGroupTag", tb =>
                {
                    tb.HasTrigger("AnomalyDetectionGroupTag_dss_delete_trigger");
                    tb.HasTrigger("AnomalyDetectionGroupTag_dss_insert_trigger");
                    tb.HasTrigger("AnomalyDetectionGroupTag_dss_update_trigger");
                });

            entity.Property(e => e.TagType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnomalyDetectionGroupTagDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AnomalyDetectionGroupTag_dss_tracking");

            entity.ToTable("AnomalyDetectionGroupTag_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AnomalyDetectionMatrixTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC0710CFE911");

            entity.ToTable("AnomalyDetectionMatrixTable", tb =>
                {
                    tb.HasTrigger("AnomalyDetectionMatrixTable_dss_delete_trigger");
                    tb.HasTrigger("AnomalyDetectionMatrixTable_dss_insert_trigger");
                    tb.HasTrigger("AnomalyDetectionMatrixTable_dss_update_trigger");
                });

            entity.Property(e => e.DependentTagType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModelledTagType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnomalyDetectionMatrixTableDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AnomalyDetectionMatrixTable_dss_tracking");

            entity.ToTable("AnomalyDetectionMatrixTable_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AnomalyDetectionTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AnomalyD__3214EC279DDFFF10");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("AnomalyDetectionTags_dss_delete_trigger");
                    tb.HasTrigger("AnomalyDetectionTags_dss_insert_trigger");
                    tb.HasTrigger("AnomalyDetectionTags_dss_update_trigger");
                });

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

            entity.ToTable("AnomalyDetectionTagGroup", tb =>
                {
                    tb.HasTrigger("AnomalyDetectionTagGroup_dss_delete_trigger");
                    tb.HasTrigger("AnomalyDetectionTagGroup_dss_insert_trigger");
                    tb.HasTrigger("AnomalyDetectionTagGroup_dss_update_trigger");
                });

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

        modelBuilder.Entity<AnomalyDetectionTagGroupDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AnomalyDetectionTagGroup_dss_tracking");

            entity.ToTable("AnomalyDetectionTagGroup_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AnomalyDetectionTagResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07CEB29EAB");

            entity.ToTable("AnomalyDetectionTagResult", tb =>
                {
                    tb.HasTrigger("AnomalyDetectionTagResult_dss_delete_trigger");
                    tb.HasTrigger("AnomalyDetectionTagResult_dss_insert_trigger");
                    tb.HasTrigger("AnomalyDetectionTagResult_dss_update_trigger");
                });

            entity.Property(e => e.ExplainedVariance100).HasColumnName("Explained Variance(100)");
            entity.Property(e => e.Mae100).HasColumnName("MAE(100)");
            entity.Property(e => e.Mse).HasColumnName("MSE");
            entity.Property(e => e.NbCheck).HasColumnName("NB_check");
            entity.Property(e => e.Predictors).IsUnicode(false);
            entity.Property(e => e.R2Score100).HasColumnName("R2_Score(100)");
            entity.Property(e => e.RampCheck).HasColumnName("ramp_check");
            entity.Property(e => e.RampPercentage).HasColumnName("ramp_percentage");
            entity.Property(e => e.Rmse).HasColumnName("RMSE");
            entity.Property(e => e.Rsq100).HasColumnName("RSQ(100)");
            entity.Property(e => e.StabilityScore).HasColumnName("stability_score");
            entity.Property(e => e.StdError).HasColumnName("std_error");
            entity.Property(e => e.TagType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnomalyDetectionTagResultDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AnomalyDetectionTagResult_dss_tracking");

            entity.ToTable("AnomalyDetectionTagResult_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AnomalyDetectionTagsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AnomalyDetectionTags_dss_tracking");

            entity.ToTable("AnomalyDetectionTags_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ApiConfig>(entity =>
        {
            entity.ToTable("API_Configs", tb =>
                {
                    tb.HasTrigger("API_Configs_dss_delete_trigger");
                    tb.HasTrigger("API_Configs_dss_insert_trigger");
                    tb.HasTrigger("API_Configs_dss_update_trigger");
                });

            entity.HasIndex(e => e.SiteId, "UQ__API_Conf__B22FDBCBA7D1768A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConsumerGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("consumer_group");
            entity.Property(e => e.IsCreated).HasColumnName("is_created");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
        });

        modelBuilder.Entity<ApiConfigsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.API_Configs_dss_tracking");

            entity.ToTable("API_Configs_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ApxAssetsStatus>(entity =>
        {
            entity.ToTable("APxAssetsStatus", tb =>
                {
                    tb.HasTrigger("APxAssetsStatus_dss_delete_trigger");
                    tb.HasTrigger("APxAssetsStatus_dss_insert_trigger");
                    tb.HasTrigger("APxAssetsStatus_dss_update_trigger");
                });

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
        });

        modelBuilder.Entity<ApxAssetsStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.APxAssetsStatus_dss_tracking");

            entity.ToTable("APxAssetsStatus_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ApxHealthAlert>(entity =>
        {
            entity.ToTable("APxHealthAlerts", tb =>
                {
                    tb.HasTrigger("APxHealthAlerts_dss_delete_trigger");
                    tb.HasTrigger("APxHealthAlerts_dss_insert_trigger");
                    tb.HasTrigger("APxHealthAlerts_dss_update_trigger");
                });

            entity.Property(e => e.AlertAcknowledgedBy).HasMaxLength(50);
            entity.Property(e => e.AlertAcknowledgedOn).HasColumnType("datetime");
            entity.Property(e => e.AlertIgnoredBy).HasMaxLength(50);
            entity.Property(e => e.AlertIgnoredOn).HasColumnType("datetime");
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

            entity.ToTable("APxHealthAlertNotification", tb =>
                {
                    tb.HasTrigger("APxHealthAlertNotification_dss_delete_trigger");
                    tb.HasTrigger("APxHealthAlertNotification_dss_insert_trigger");
                    tb.HasTrigger("APxHealthAlertNotification_dss_update_trigger");
                });
        });

        modelBuilder.Entity<ApxHealthAlertNotificationDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.APxHealthAlertNotification_dss_tracking");

            entity.ToTable("APxHealthAlertNotification_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ApxHealthAlertTrend>(entity =>
        {
            entity.ToTable("APxHealthAlertTrends", tb =>
                {
                    tb.HasTrigger("APxHealthAlertTrends_dss_delete_trigger");
                    tb.HasTrigger("APxHealthAlertTrends_dss_insert_trigger");
                    tb.HasTrigger("APxHealthAlertTrends_dss_update_trigger");
                });

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Jsondata).HasColumnName("JSONData");
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterIdFK");
        });

        modelBuilder.Entity<ApxHealthAlertTrendsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.APxHealthAlertTrends_dss_tracking");

            entity.ToTable("APxHealthAlertTrends_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ApxHealthAlertsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.APxHealthAlerts_dss_tracking");

            entity.ToTable("APxHealthAlerts_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ApxHealthParameter>(entity =>
        {
            entity.ToTable("APxHealthParameters");

            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("AssetCategoryIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StepIdFk).HasColumnName("StepId_FK");
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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterIdFK");
            entity.Property(e => e.TagDescription).HasMaxLength(250);
            entity.Property(e => e.TagType)
                .HasMaxLength(20)
                .IsFixedLength();
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
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
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
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
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
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TagJsondata).HasColumnName("TagJSONData");
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
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

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.Property(e => e.AssetId).HasColumnName("Asset_Id");
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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsKpiactivated)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsKPIActivated");
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

        modelBuilder.Entity<AuditLogsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AuditLogs_dss_tracking");

            entity.ToTable("AuditLogs_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AutomationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Automati__3214EC27D7C925F3");

            entity.ToTable("Automation_Logs", tb =>
                {
                    tb.HasTrigger("Automation_Logs_dss_delete_trigger");
                    tb.HasTrigger("Automation_Logs_dss_insert_trigger");
                    tb.HasTrigger("Automation_Logs_dss_update_trigger");
                });

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

            entity.ToTable("Automation_Logs_Alter_Site", tb =>
                {
                    tb.HasTrigger("Automation_Logs_Alter_Site_dss_delete_trigger");
                    tb.HasTrigger("Automation_Logs_Alter_Site_dss_insert_trigger");
                    tb.HasTrigger("Automation_Logs_Alter_Site_dss_update_trigger");
                });

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

        modelBuilder.Entity<AutomationLogsAlterSiteDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Automation_Logs_Alter_Site_dss_tracking");

            entity.ToTable("Automation_Logs_Alter_Site_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AutomationLogsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Automation_Logs_dss_tracking");

            entity.ToTable("Automation_Logs_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AutomationLogsSitecreation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Automati__3214EC27CB44D1D4");

            entity.ToTable("Automation_Logs_Sitecreation", tb =>
                {
                    tb.HasTrigger("Automation_Logs_Sitecreation_dss_delete_trigger");
                    tb.HasTrigger("Automation_Logs_Sitecreation_dss_insert_trigger");
                    tb.HasTrigger("Automation_Logs_Sitecreation_dss_update_trigger");
                });

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

        modelBuilder.Entity<AutomationLogsSitecreationDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Automation_Logs_Sitecreation_dss_tracking");

            entity.ToTable("Automation_Logs_Sitecreation_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<AzureRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AzureReg__3214EC27C6EB4249");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("AzureRegions_dss_delete_trigger");
                    tb.HasTrigger("AzureRegions_dss_insert_trigger");
                    tb.HasTrigger("AzureRegions_dss_update_trigger");
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
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).IsUnicode(false);
        });

        modelBuilder.Entity<AzureRegionsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.AzureRegions_dss_tracking");

            entity.ToTable("AzureRegions_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BadUncertainAlarmsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bad_Unce__3214EC271E7118C2");

            entity.ToTable("Bad_Uncertain_Alarms_History", tb =>
                {
                    tb.HasTrigger("Bad_Uncertain_Alarms_History_dss_delete_trigger");
                    tb.HasTrigger("Bad_Uncertain_Alarms_History_dss_insert_trigger");
                    tb.HasTrigger("Bad_Uncertain_Alarms_History_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ReadingTime)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Reading_Time");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<BadUncertainAlarmsHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Bad_Uncertain_Alarms_History_dss_tracking");

            entity.ToTable("Bad_Uncertain_Alarms_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BatchJobQueryLanguage>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("BatchJobQueryLanguages_dss_delete_trigger");
                    tb.HasTrigger("BatchJobQueryLanguages_dss_insert_trigger");
                    tb.HasTrigger("BatchJobQueryLanguages_dss_update_trigger");
                });

            entity.HasIndex(e => e.LanguageName, "UQ_LanguageName").IsUnique();

            entity.Property(e => e.LanguageName).HasMaxLength(100);
        });

        modelBuilder.Entity<BatchJobQueryLanguagesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BatchJobQueryLanguages_dss_tracking");

            entity.ToTable("BatchJobQueryLanguages_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BatchJobTableColumn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BatchJob__3214EC07F69B49E6");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("BatchJobTableColumns_dss_delete_trigger");
                    tb.HasTrigger("BatchJobTableColumns_dss_insert_trigger");
                    tb.HasTrigger("BatchJobTableColumns_dss_update_trigger");
                });

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

        modelBuilder.Entity<BatchJobTableColumnsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BatchJobTableColumns_dss_tracking");

            entity.ToTable("BatchJobTableColumns_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BatchJobTriggerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BatchJob__3214EC079562095E");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("BatchJobTriggerTypes_dss_delete_trigger");
                    tb.HasTrigger("BatchJobTriggerTypes_dss_insert_trigger");
                    tb.HasTrigger("BatchJobTriggerTypes_dss_update_trigger");
                });

            entity.HasIndex(e => e.TriggerTypeName, "UQ__BatchJob__6247D22471D5F113").IsUnique();

            entity.Property(e => e.TriggerTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BatchJobTriggerTypesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BatchJobTriggerTypes_dss_tracking");

            entity.ToTable("BatchJobTriggerTypes_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BatchJobsDefinition>(entity =>
        {
            entity.ToTable("BatchJobsDefinition", tb =>
                {
                    tb.HasTrigger("BatchJobsDefinition_dss_delete_trigger");
                    tb.HasTrigger("BatchJobsDefinition_dss_insert_trigger");
                    tb.HasTrigger("BatchJobsDefinition_dss_update_trigger");
                });

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.TableName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);

            entity.HasOne(d => d.Language).WithMany(p => p.BatchJobsDefinitions)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_BatchJobsDefinition_Language");
        });

        modelBuilder.Entity<BatchJobsDefinitionDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BatchJobsDefinition_dss_tracking");

            entity.ToTable("BatchJobsDefinition_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BatchJobsScheduling>(entity =>
        {
            entity.HasKey(e => e.TriggerId);

            entity.ToTable("BatchJobsScheduling", tb =>
                {
                    tb.HasTrigger("BatchJobsScheduling_dss_delete_trigger");
                    tb.HasTrigger("BatchJobsScheduling_dss_insert_trigger");
                    tb.HasTrigger("BatchJobsScheduling_dss_update_trigger");
                });

            entity.Property(e => e.TriggerId).HasColumnName("Trigger_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.ExecuteNow).HasColumnName("Execute_Now");
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))")
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

        modelBuilder.Entity<BatchJobsSchedulingDssTracking>(entity =>
        {
            entity.HasKey(e => e.TriggerId).HasName("PK_DataSync.BatchJobsScheduling_dss_tracking");

            entity.ToTable("BatchJobsScheduling_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.TriggerId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.TriggerId)
                .ValueGeneratedNever()
                .HasColumnName("Trigger_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmActivitiesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BPM_Activities_dss_tracking");

            entity.ToTable("BPM_Activities_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmActivitiesTestDssTracking>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("PK_DataSync.BPM_Activities_test_dss_tracking");

            entity.ToTable("BPM_Activities_test_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ActivityId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ActivityId)
                .ValueGeneratedNever()
                .HasColumnName("activity_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BPM_Acti__482FBD6383648504");

            entity.ToTable("BPM_Activities", tb =>
                {
                    tb.HasTrigger("BPM_Activities_dss_delete_trigger");
                    tb.HasTrigger("BPM_Activities_dss_insert_trigger");
                    tb.HasTrigger("BPM_Activities_dss_update_trigger");
                });

            entity.HasIndex(e => e.ActivityGuid, "UQ_BPM_Activities_ActivityGuid").IsUnique();

            entity.Property(e => e.ActivityType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Published).HasDefaultValueSql("((0))");
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.Validate).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Bpm).WithMany(p => p.BpmActivities)
                .HasForeignKey(d => d.BpmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BPM_Activ__bpm_i__526A1CA5");

            entity.HasOne(d => d.Language).WithMany(p => p.BpmActivities)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_BPM_Activities_Language");
        });

        modelBuilder.Entity<BpmActivityDependenciesDssTracking>(entity =>
        {
            entity.HasKey(e => e.DependencyId).HasName("PK_DataSync.BPM_Activity_Dependencies_dss_tracking");

            entity.ToTable("BPM_Activity_Dependencies_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DependencyId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DependencyId)
                .ValueGeneratedNever()
                .HasColumnName("dependency_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmActivityDependenciesGuidDssTracking>(entity =>
        {
            entity.HasKey(e => e.DependencyId).HasName("PK_DataSync.BPM_Activity_Dependencies_GUID_dss_tracking");

            entity.ToTable("BPM_Activity_Dependencies_GUID_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DependencyId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DependencyId)
                .ValueGeneratedNever()
                .HasColumnName("dependency_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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

        modelBuilder.Entity<BpmActivityLevelsDssTracking>(entity =>
        {
            entity.HasKey(e => new { e.BpmId, e.ActivityId }).HasName("PK_DataSync.BPM_Activity_Levels_dss_tracking");

            entity.ToTable("BPM_Activity_Levels_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.BpmId, e.ActivityId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.BpmId).HasColumnName("bpm_id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmActivityLevelsGuidDssTracking>(entity =>
        {
            entity.HasKey(e => new { e.BpmId, e.ActivityId }).HasName("PK_DataSync.BPM_Activity_Levels_GUID_dss_tracking");

            entity.ToTable("BPM_Activity_Levels_GUID_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.BpmId, e.ActivityId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.BpmId).HasColumnName("bpm_id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmActivityLevelsTestingDssTracking>(entity =>
        {
            entity.HasKey(e => new { e.BpmId, e.ActivityId }).HasName("PK_DataSync.BPM_Activity_Levels_testing_dss_tracking");

            entity.ToTable("BPM_Activity_Levels_testing_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.BpmId, e.ActivityId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.BpmId).HasColumnName("bpm_id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmActivityMetadataDssTracking>(entity =>
        {
            entity.HasKey(e => e.MetadataId).HasName("PK_DataSync.BPM_Activity_Metadata_dss_tracking");

            entity.ToTable("BPM_Activity_Metadata_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.MetadataId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.MetadataId)
                .ValueGeneratedNever()
                .HasColumnName("metadata_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BPM_Jobs__181DF2FF65EBA7C4");

            entity.ToTable("BPM_Jobs", tb =>
                {
                    tb.HasTrigger("BPM_Jobs_dss_delete_trigger");
                    tb.HasTrigger("BPM_Jobs_dss_insert_trigger");
                    tb.HasTrigger("BPM_Jobs_dss_update_trigger");
                });

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

        modelBuilder.Entity<BpmJobsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BPM_Jobs_dss_tracking");

            entity.ToTable("BPM_Jobs_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmactivityQueriesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BPMActivityQueries_dss_tracking");

            entity.ToTable("BPMActivityQueries_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BpmjobsScheduling>(entity =>
        {
            entity.HasKey(e => e.TriggerId);

            entity.ToTable("BPMJobsScheduling");

            entity.Property(e => e.TriggerId).HasColumnName("Trigger_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.ExecuteNow).HasColumnName("Execute_Now");
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))")
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


        modelBuilder.Entity<BufferDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.buffer_dss_tracking");

            entity.ToTable("buffer_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BulkDeviceReplicationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BulkDevi__3214EC07614705EF");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("BulkDeviceReplicationLogs_dss_delete_trigger");
                    tb.HasTrigger("BulkDeviceReplicationLogs_dss_insert_trigger");
                    tb.HasTrigger("BulkDeviceReplicationLogs_dss_update_trigger");
                });

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeviceNameConvention).HasMaxLength(255);
            entity.Property(e => e.DeviceType).HasMaxLength(10);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("('In Progress')");
            entity.Property(e => e.TagnameConvention).HasMaxLength(100);
        });

        modelBuilder.Entity<BulkDeviceReplicationLogDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BulkDevi__3214EC0740779B44");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("BulkDeviceReplicationLogDevices_dss_delete_trigger");
                    tb.HasTrigger("BulkDeviceReplicationLogDevices_dss_insert_trigger");
                    tb.HasTrigger("BulkDeviceReplicationLogDevices_dss_update_trigger");
                });

            entity.Property(e => e.DeviceStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("('In Progress')");
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.Log).WithMany(p => p.BulkDeviceReplicationLogDevices)
                .HasForeignKey(d => d.LogId)
                .HasConstraintName("FK_BulkDeviceReplicationLogDevices_BulkDeviceReplicationLogs");
        });

        modelBuilder.Entity<BulkDeviceReplicationLogDevicesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BulkDeviceReplicationLogDevices_dss_tracking");

            entity.ToTable("BulkDeviceReplicationLogDevices_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<BulkDeviceReplicationLogsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.BulkDeviceReplicationLogs_dss_tracking");

            entity.ToTable("BulkDeviceReplicationLogs_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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
            entity.Property(e => e.Deadband).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FlowRate).HasColumnName("Flow_Rate");
            entity.Property(e => e.IsCounterTag).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsKpitag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsKPITag");
            entity.Property(e => e.IsTimerTag).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsTotalizer)
                .HasDefaultValueSql("((0))")
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

            entity.ToTable("Calculated_Tag_Targets", tb =>
                {
                    tb.HasTrigger("Calculated_Tag_Targets_dss_delete_trigger");
                    tb.HasTrigger("Calculated_Tag_Targets_dss_insert_trigger");
                    tb.HasTrigger("Calculated_Tag_Targets_dss_update_trigger");
                });

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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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
            entity.ToTable("Calculated_Tag_Target_Mon_Year", tb =>
                {
                    tb.HasTrigger("Calculated_Tag_Target_Mon_Year_dss_delete_trigger");
                    tb.HasTrigger("Calculated_Tag_Target_Mon_Year_dss_insert_trigger");
                    tb.HasTrigger("Calculated_Tag_Target_Mon_Year_dss_update_trigger");
                });

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

        modelBuilder.Entity<CalculatedTagTargetMonYearDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Calculated_Tag_Target_Mon_Year_dss_tracking");

            entity.ToTable("Calculated_Tag_Target_Mon_Year_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CalculatedTagTargetMonYearHistory>(entity =>
        {
            entity.ToTable("Calculated_Tag_Target_Mon_Year_History", tb =>
                {
                    tb.HasTrigger("Calculated_Tag_Target_Mon_Year_History_dss_delete_trigger");
                    tb.HasTrigger("Calculated_Tag_Target_Mon_Year_History_dss_insert_trigger");
                    tb.HasTrigger("Calculated_Tag_Target_Mon_Year_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<CalculatedTagTargetMonYearHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Calculated_Tag_Target_Mon_Year_History_dss_tracking");

            entity.ToTable("Calculated_Tag_Target_Mon_Year_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CalculatedTagTargetsDssTracking>(entity =>
        {
            entity.HasKey(e => e.TagTargetId).HasName("PK_DataSync.Calculated_Tag_Targets_dss_tracking");

            entity.ToTable("Calculated_Tag_Targets_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.TagTargetId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.TagTargetId)
                .ValueGeneratedNever()
                .HasColumnName("Tag_Target_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CalculatedTagTargetsHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_Calculated_Tag_Targets_History_1");

            entity.ToTable("Calculated_Tag_Targets_History", tb =>
                {
                    tb.HasTrigger("Calculated_Tag_Targets_History_dss_delete_trigger");
                    tb.HasTrigger("Calculated_Tag_Targets_History_dss_insert_trigger");
                    tb.HasTrigger("Calculated_Tag_Targets_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<CalculatedTagTargetsHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_DataSync.Calculated_Tag_Targets_History_dss_tracking");

            entity.ToTable("Calculated_Tag_Targets_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.HistoryId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.HistoryId)
                .ValueGeneratedNever()
                .HasColumnName("HistoryID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CalculatedTagsDssTracking>(entity =>
        {
            entity.HasKey(e => e.CTagId).HasName("PK_DataSync.Calculated_Tags_dss_tracking");

            entity.ToTable("Calculated_Tags_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CTagId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CTagId)
                .ValueGeneratedNever()
                .HasColumnName("C_Tag_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CalculatedTagsHistory>(entity =>
        {
            entity.HasKey(e => e.CTagId);

            entity.ToTable("Calculated_Tags_History", tb =>
                {
                    tb.HasTrigger("Calculated_Tags_History_dss_delete_trigger");
                    tb.HasTrigger("Calculated_Tags_History_dss_insert_trigger");
                    tb.HasTrigger("Calculated_Tags_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<CalculatedTagsHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.CTagId).HasName("PK_DataSync.Calculated_Tags_History_dss_tracking");

            entity.ToTable("Calculated_Tags_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CTagId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CTagId)
                .ValueGeneratedNever()
                .HasColumnName("C_Tag_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ChartType>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("ChartTypes_dss_delete_trigger");
                    tb.HasTrigger("ChartTypes_dss_insert_trigger");
                    tb.HasTrigger("ChartTypes_dss_update_trigger");
                });

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ChartTypesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ChartTypes_dss_tracking");

            entity.ToTable("ChartTypes_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ChatMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07DD62E304");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("ChatMessages_dss_delete_trigger");
                    tb.HasTrigger("ChatMessages_dss_insert_trigger");
                    tb.HasTrigger("ChatMessages_dss_update_trigger");
                });

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

        modelBuilder.Entity<ChatMessagesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ChatMessages_dss_tracking");

            entity.ToTable("ChatMessages_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ChatThread>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0796C1A767");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("ChatThreads_dss_delete_trigger");
                    tb.HasTrigger("ChatThreads_dss_insert_trigger");
                    tb.HasTrigger("ChatThreads_dss_update_trigger");
                });

            entity.HasIndex(e => e.OpenAithreadId, "UQ__tmp_ms_x__EA89CEDBCE5B7A59").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastMessageAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.OpenAithreadId)
                .HasMaxLength(100)
                .HasColumnName("OpenAIThreadId");
            entity.Property(e => e.UserId).HasMaxLength(450);
        });

        modelBuilder.Entity<ChatThreadsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ChatThreads_dss_tracking");

            entity.ToTable("ChatThreads_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__F2D21A9616A374C5");

            entity.ToTable("City", tb =>
                {
                    tb.HasTrigger("City_dss_delete_trigger");
                    tb.HasTrigger("City_dss_insert_trigger");
                    tb.HasTrigger("City_dss_update_trigger");
                });

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

        modelBuilder.Entity<CityDssTracking>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK_DataSync.City_dss_tracking");

            entity.ToTable("City_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CityId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CityId)
                .ValueGeneratedNever()
                .HasColumnName("CityID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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

        modelBuilder.Entity<ConditionalCalculationDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Conditional_Calculation_dss_tracking");

            entity.ToTable("Conditional_Calculation_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ConfigrationVersioning>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("Configration_Versioning", tb =>
                {
                    tb.HasTrigger("Configration_Versioning_dss_delete_trigger");
                    tb.HasTrigger("Configration_Versioning_dss_insert_trigger");
                    tb.HasTrigger("Configration_Versioning_dss_update_trigger");
                });

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

        modelBuilder.Entity<ConfigrationVersioningDssTracking>(entity =>
        {
            entity.HasKey(e => e.ConfigId).HasName("PK_DataSync.Configration_Versioning_dss_tracking");

            entity.ToTable("Configration_Versioning_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ConfigId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ConfigId)
                .ValueGeneratedNever()
                .HasColumnName("Config_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ConfigrationVersioningHistory>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("Configration_Versioning_History", tb =>
                {
                    tb.HasTrigger("Configration_Versioning_History_dss_delete_trigger");
                    tb.HasTrigger("Configration_Versioning_History_dss_insert_trigger");
                    tb.HasTrigger("Configration_Versioning_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<ConfigrationVersioningHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.ConfigId).HasName("PK_DataSync.Configration_Versioning_History_dss_tracking");

            entity.ToTable("Configration_Versioning_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ConfigId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ConfigId)
                .ValueGeneratedNever()
                .HasColumnName("Config_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__configur__3214EC071FBA6FD2");

            entity.ToTable("configuration", "dss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConfigKey).HasMaxLength(100);
            entity.Property(e => e.ConfigValue).HasMaxLength(256);
            entity.Property(e => e.LastModified)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ControlSystemIntegratorProductM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ControlS__3214EC273826B218");

            entity.ToTable("ControlSystemIntegratorProductM2M", tb =>
                {
                    tb.HasTrigger("ControlSystemIntegratorProductM2M_dss_delete_trigger");
                    tb.HasTrigger("ControlSystemIntegratorProductM2M_dss_insert_trigger");
                    tb.HasTrigger("ControlSystemIntegratorProductM2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<ControlSystemIntegratorProductM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ControlSystemIntegratorProductM2M_dss_tracking");

            entity.ToTable("ControlSystemIntegratorProductM2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CopyDataAlarmAction>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("COPY_PK__DATA_ALA__5D853E1A0C706C36");

            entity.ToTable("COPY_DATA_ALARM_ACTION", tb =>
                {
                    tb.HasTrigger("COPY_DATA_ALARM_ACTION_dss_delete_trigger");
                    tb.HasTrigger("COPY_DATA_ALARM_ACTION_dss_insert_trigger");
                    tb.HasTrigger("COPY_DATA_ALARM_ACTION_dss_update_trigger");
                });

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

        modelBuilder.Entity<CopyDataAlarmActionDssTracking>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("PK_DataSync.COPY_DATA_ALARM_ACTION_dss_tracking");

            entity.ToTable("COPY_DATA_ALARM_ACTION_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DatId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DatId)
                .ValueGeneratedNever()
                .HasColumnName("DAT_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country", tb =>
                {
                    tb.HasTrigger("Country_dss_delete_trigger");
                    tb.HasTrigger("Country_dss_insert_trigger");
                    tb.HasTrigger("Country_dss_update_trigger");
                });

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

            entity.ToTable("CountryCode", tb =>
                {
                    tb.HasTrigger("CountryCode_dss_delete_trigger");
                    tb.HasTrigger("CountryCode_dss_insert_trigger");
                    tb.HasTrigger("CountryCode_dss_update_trigger");
                });

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CountryCodeDssTracking>(entity =>
        {
            entity.HasKey(e => e.CodeId).HasName("PK_DataSync.CountryCode_dss_tracking");

            entity.ToTable("CountryCode_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CodeId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CodeId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CountryDssTracking>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK_DataSync.Country_dss_tracking");

            entity.ToTable("Country_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CountryId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CountryId)
                .ValueGeneratedNever()
                .HasColumnName("CountryID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CsvImportStatus>(entity =>
        {
            entity.ToTable("Csv_Import_Status", tb =>
                {
                    tb.HasTrigger("Csv_Import_Status_dss_delete_trigger");
                    tb.HasTrigger("Csv_Import_Status_dss_insert_trigger");
                    tb.HasTrigger("Csv_Import_Status_dss_update_trigger");
                });

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

        modelBuilder.Entity<CsvImportStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Csv_Import_Status_dss_tracking");

            entity.ToTable("Csv_Import_Status_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<CurveDataDssTracking>(entity =>
        {
            entity.HasKey(e => e.CurveId).HasName("PK_DataSync.Curve_Data_dss_tracking");

            entity.ToTable("Curve_Data_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CurveId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CurveId)
                .ValueGeneratedNever()
                .HasColumnName("Curve_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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
                .HasDefaultValueSql("((1))")
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
                .HasDefaultValueSql("((1))")
                .HasColumnName("isActive");
            entity.Property(e => e.Unit).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<CurveHeadersDssTracking>(entity =>
        {
            entity.HasKey(e => e.CurveHeaderId).HasName("PK_DataSync.Curve_Headers_dss_tracking");

            entity.ToTable("Curve_Headers_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CurveHeaderId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CurveHeaderId)
                .ValueGeneratedNever()
                .HasColumnName("Curve_Header_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer", tb =>
                {
                    tb.HasTrigger("Customer_dss_delete_trigger");
                    tb.HasTrigger("Customer_dss_insert_trigger");
                    tb.HasTrigger("Customer_dss_update_trigger");
                });

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

        modelBuilder.Entity<CustomerDssTracking>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_DataSync.Customer_dss_tracking");

            entity.ToTable("Customer_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CustomerId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("Customer_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DataAlarm>(entity =>
        {
            entity.HasKey(e => e.DataAlarmId).HasName("PK__DATA_ALA__F96AC127D41C6334");

            entity.ToTable("DATA_ALARM", tb =>
                {
                    tb.HasTrigger("DATA_ALARM_dss_delete_trigger");
                    tb.HasTrigger("DATA_ALARM_dss_insert_trigger");
                    tb.HasTrigger("DATA_ALARM_dss_update_trigger");
                });

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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

            entity.ToTable("DataAlarmAction", tb =>
                {
                    tb.HasTrigger("DataAlarmAction_dss_delete_trigger");
                    tb.HasTrigger("DataAlarmAction_dss_insert_trigger");
                    tb.HasTrigger("DataAlarmAction_dss_update_trigger");
                });

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

        modelBuilder.Entity<DataAlarmActionDssTracking>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("PK_DataSync.DataAlarmAction_dss_tracking");

            entity.ToTable("DataAlarmAction_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DatId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DatId)
                .ValueGeneratedNever()
                .HasColumnName("DAT_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DataAlarmActionHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DATA_ALA__3214EC27DEF495B7");

            entity.ToTable("DATA_ALARM_ACTION_HISTORY", tb =>
                {
                    tb.HasTrigger("DATA_ALARM_ACTION_HISTORY_dss_delete_trigger");
                    tb.HasTrigger("DATA_ALARM_ACTION_HISTORY_dss_insert_trigger");
                    tb.HasTrigger("DATA_ALARM_ACTION_HISTORY_dss_update_trigger");
                });

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

        modelBuilder.Entity<DataAlarmActionHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.DATA_ALARM_ACTION_HISTORY_dss_tracking");

            entity.ToTable("DATA_ALARM_ACTION_HISTORY_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DataAlarmDssTracking>(entity =>
        {
            entity.HasKey(e => e.DataAlarmId).HasName("PK_DataSync.DATA_ALARM_dss_tracking");

            entity.ToTable("DATA_ALARM_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DataAlarmId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DataAlarmId)
                .ValueGeneratedNever()
                .HasColumnName("DataAlarm_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DataAlarmState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__DATA_ALA__AF9338D73644AC38");

            entity.ToTable("DATA_ALARM_STATES", tb =>
                {
                    tb.HasTrigger("DATA_ALARM_STATES_dss_delete_trigger");
                    tb.HasTrigger("DATA_ALARM_STATES_dss_insert_trigger");
                    tb.HasTrigger("DATA_ALARM_STATES_dss_update_trigger");
                });

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
            entity.Property(e => e.AlarmPriorityId).HasColumnName("AlarmPriority_ID");
            entity.Property(e => e.AlarmProcessed)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Alarm_Processed");
            entity.Property(e => e.AsId)
                .HasDefaultValueSql("((2))")
                .HasColumnName("AS_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.StateId).HasColumnName("State_ID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<DependenciesMetrix>(entity =>
        {
            entity.HasKey(e => e.DmId);

            entity.ToTable("Dependencies_Metrix", tb =>
                {
                    tb.HasTrigger("Dependencies_Metrix_dss_delete_trigger");
                    tb.HasTrigger("Dependencies_Metrix_dss_insert_trigger");
                    tb.HasTrigger("Dependencies_Metrix_dss_update_trigger");
                });

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
                .IsRequired()
                .HasDefaultValueSql("((1))")
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

        modelBuilder.Entity<DependenciesMetrixDssTracking>(entity =>
        {
            entity.HasKey(e => e.DmId).HasName("PK_DataSync.Dependencies_Metrix_dss_tracking");

            entity.ToTable("Dependencies_Metrix_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DmId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DmId)
                .ValueGeneratedNever()
                .HasColumnName("DM_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DependenciesMetrixHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_Dependencies_Metrix_History_1");

            entity.ToTable("Dependencies_Metrix_History", tb =>
                {
                    tb.HasTrigger("Dependencies_Metrix_History_dss_delete_trigger");
                    tb.HasTrigger("Dependencies_Metrix_History_dss_insert_trigger");
                    tb.HasTrigger("Dependencies_Metrix_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<DependenciesMetrixHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_DataSync.Dependencies_Metrix_History_dss_tracking");

            entity.ToTable("Dependencies_Metrix_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.HistoryId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.HistoryId)
                .ValueGeneratedNever()
                .HasColumnName("HistoryID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DesignDataDssTracking>(entity =>
        {
            entity.HasKey(e => e.DesignDataId).HasName("PK_DataSync.Design_Data_dss_tracking");

            entity.ToTable("Design_Data_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DesignDataId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DesignDataId)
                .ValueGeneratedNever()
                .HasColumnName("Design_Data_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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
                .HasDefaultValueSql("((1))")
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
                .HasDefaultValueSql("((1))")
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
            entity.Property(e => e.Guid).HasColumnName("GUID");
            entity.Property(e => e.IoTedgeConnectionString).HasColumnName("IoTEdge_ConnectionString");
            entity.Property(e => e.IotconnectionString).HasColumnName("IOTConnectionString");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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
            entity.ToTable("Device_DL_Settings", tb =>
                {
                    tb.HasTrigger("Device_DL_Settings_dss_delete_trigger");
                    tb.HasTrigger("Device_DL_Settings_dss_insert_trigger");
                    tb.HasTrigger("Device_DL_Settings_dss_update_trigger");
                });

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

        modelBuilder.Entity<DeviceDlSettingsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Device_DL_Settings_dss_tracking");

            entity.ToTable("Device_DL_Settings_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DeviceModbusSetting>(entity =>
        {
            entity.ToTable("Device_Modbus_Settings", tb =>
                {
                    tb.HasTrigger("Device_Modbus_Settings_dss_delete_trigger");
                    tb.HasTrigger("Device_Modbus_Settings_dss_insert_trigger");
                    tb.HasTrigger("Device_Modbus_Settings_dss_update_trigger");
                });

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

        modelBuilder.Entity<DeviceModbusSettingsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Device_Modbus_Settings_dss_tracking");

            entity.ToTable("Device_Modbus_Settings_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DeviceOpcServerM2m>(entity =>
        {
            entity.ToTable("Device_OPC_Server_M2M", tb =>
                {
                    tb.HasTrigger("Device_OPC_Server_M2M_dss_delete_trigger");
                    tb.HasTrigger("Device_OPC_Server_M2M_dss_insert_trigger");
                    tb.HasTrigger("Device_OPC_Server_M2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<DeviceOpcServerM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Device_OPC_Server_M2M_dss_tracking");

            entity.ToTable("Device_OPC_Server_M2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DeviceOpcSetting>(entity =>
        {
            entity.ToTable("Device_OPC_Settings", tb =>
                {
                    tb.HasTrigger("Device_OPC_Settings_dss_delete_trigger");
                    tb.HasTrigger("Device_OPC_Settings_dss_insert_trigger");
                    tb.HasTrigger("Device_OPC_Settings_dss_update_trigger");
                });

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

        modelBuilder.Entity<DeviceOpcSettingsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Device_OPC_Settings_dss_tracking");

            entity.ToTable("Device_OPC_Settings_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DevicePlatform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Device_P__3214EC2797648D70");

            entity.ToTable("Device_Platform", tb =>
                {
                    tb.HasTrigger("Device_Platform_dss_delete_trigger");
                    tb.HasTrigger("Device_Platform_dss_insert_trigger");
                    tb.HasTrigger("Device_Platform_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<DevicePlatformDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Device_Platform_dss_tracking");

            entity.ToTable("Device_Platform_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DeviceTimeStampIdmapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DeviceTi__3214EC0723BBDC97");

            entity.ToTable("DeviceTimeStampIDMapping", tb =>
                {
                    tb.HasTrigger("DeviceTimeStampIDMapping_dss_delete_trigger");
                    tb.HasTrigger("DeviceTimeStampIDMapping_dss_insert_trigger");
                    tb.HasTrigger("DeviceTimeStampIDMapping_dss_update_trigger");
                });

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

        modelBuilder.Entity<DeviceTimeStampIdmappingDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.DeviceTimeStampIDMapping_dss_tracking");

            entity.ToTable("DeviceTimeStampIDMapping_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DeviceType>(entity =>
        {
            entity.ToTable("Device_Type", tb =>
                {
                    tb.HasTrigger("Device_Type_dss_delete_trigger");
                    tb.HasTrigger("Device_Type_dss_insert_trigger");
                    tb.HasTrigger("Device_Type_dss_update_trigger");
                });

            entity.Property(e => e.DeviceTypeId).HasColumnName("DeviceTypeID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<DeviceTypeDssTracking>(entity =>
        {
            entity.HasKey(e => e.DeviceTypeId).HasName("PK_DataSync.Device_Type_dss_tracking");

            entity.ToTable("Device_Type_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DeviceTypeId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DeviceTypeId)
                .ValueGeneratedNever()
                .HasColumnName("DeviceTypeID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DevicesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Devices_dss_tracking");

            entity.ToTable("Devices_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DevicesSitesM2m>(entity =>
        {
            entity.ToTable("Devices_SitesM2M", tb =>
                {
                    tb.HasTrigger("Devices_SitesM2M_dss_delete_trigger");
                    tb.HasTrigger("Devices_SitesM2M_dss_insert_trigger");
                    tb.HasTrigger("Devices_SitesM2M_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeviceId).HasColumnName("Device_ID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");
            entity.Property(e => e.SiteSpecificId).HasColumnName("Site_Specific_Id");
        });

        modelBuilder.Entity<DevicesSitesM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Devices_SitesM2M_dss_tracking");

            entity.ToTable("Devices_SitesM2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Distributor>(entity =>
        {
            entity.HasKey(e => e.DistributorId).HasName("PK__Distribu__FD1AEB9E2E6C7F74");

            entity.ToTable("Distributor", tb =>
                {
                    tb.HasTrigger("Distributor_dss_delete_trigger");
                    tb.HasTrigger("Distributor_dss_insert_trigger");
                    tb.HasTrigger("Distributor_dss_update_trigger");
                });

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

        modelBuilder.Entity<DistributorDssTracking>(entity =>
        {
            entity.HasKey(e => e.DistributorId).HasName("PK_DataSync.Distributor_dss_tracking");

            entity.ToTable("Distributor_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DistributorId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DistributorId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<DistributorProductM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Distribu__3214EC078580EF2F");

            entity.ToTable("DistributorProductM2M", tb =>
                {
                    tb.HasTrigger("DistributorProductM2M_dss_delete_trigger");
                    tb.HasTrigger("DistributorProductM2M_dss_insert_trigger");
                    tb.HasTrigger("DistributorProductM2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<DistributorProductM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.DistributorProductM2M_dss_tracking");

            entity.ToTable("DistributorProductM2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EdgeConfigurationTimeLine>(entity =>
        {
            entity.ToTable("EdgeConfigurationTimeLine", tb =>
                {
                    tb.HasTrigger("EdgeConfigurationTimeLine_dss_delete_trigger");
                    tb.HasTrigger("EdgeConfigurationTimeLine_dss_insert_trigger");
                    tb.HasTrigger("EdgeConfigurationTimeLine_dss_update_trigger");
                });

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<EdgeConfigurationTimeLineDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.EdgeConfigurationTimeLine_dss_tracking");

            entity.ToTable("EdgeConfigurationTimeLine_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EdgeDevice>(entity =>
        {
            entity.HasKey(e => e.EdId).HasName("PK__edge_dev__B9CE0418673252C2");

            entity.ToTable("edge_device", tb =>
                {
                    tb.HasTrigger("edge_device_dss_delete_trigger");
                    tb.HasTrigger("edge_device_dss_insert_trigger");
                    tb.HasTrigger("edge_device_dss_update_trigger");
                });

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

        modelBuilder.Entity<EdgeDeviceDssTracking>(entity =>
        {
            entity.HasKey(e => e.EdId).HasName("PK_DataSync.edge_device_dss_tracking");

            entity.ToTable("edge_device_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.EdId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.EdId)
                .ValueGeneratedNever()
                .HasColumnName("ED_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpAzureRelayConnectionDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Azur__3214EC07778A87F2");

            entity.ToTable("Enp_AzureRelayConnectionDetails", tb =>
                {
                    tb.HasTrigger("Enp_AzureRelayConnectionDetails_dss_delete_trigger");
                    tb.HasTrigger("Enp_AzureRelayConnectionDetails_dss_insert_trigger");
                    tb.HasTrigger("Enp_AzureRelayConnectionDetails_dss_update_trigger");
                });

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

        modelBuilder.Entity<EnpAzureRelayConnectionDetailsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_AzureRelayConnectionDetails_dss_tracking");

            entity.ToTable("Enp_AzureRelayConnectionDetails_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorApiUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Enp_Connector_Api_Url");

            entity.ToTable("Enp_Connector_Api_Urls", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Api_Urls_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Api_Urls_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Api_Urls_dss_update_trigger");
                });

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

        modelBuilder.Entity<EnpConnectorApiUrlsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Api_Urls_dss_tracking");

            entity.ToTable("Enp_Connector_Api_Urls_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorConnector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC07BAA66DCD");

            entity.ToTable("Enp_Connector_Connectors", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Connectors_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Connectors_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Connectors_dss_update_trigger");
                });

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.PortNumber).HasMaxLength(100);
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

            entity.ToTable("Enp_Connector_ConnectorType", tb =>
                {
                    tb.HasTrigger("Enp_Connector_ConnectorType_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_ConnectorType_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_ConnectorType_dss_update_trigger");
                });

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EnpConnectorConnectorTypeDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_ConnectorType_dss_tracking");

            entity.ToTable("Enp_Connector_ConnectorType_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorConnectorsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Connectors_dss_tracking");

            entity.ToTable("Enp_Connector_Connectors_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorDatatypeAzureSql>(entity =>
        {
            entity.ToTable("Enp_Connector_Datatype_AzureSql", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Datatype_AzureSql_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Datatype_AzureSql_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Datatype_AzureSql_dss_update_trigger");
                });

            entity.Property(e => e.DataType).HasMaxLength(50);
        });

        modelBuilder.Entity<EnpConnectorDatatypeAzureSqlDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Datatype_AzureSql_dss_tracking");

            entity.ToTable("Enp_Connector_Datatype_AzureSql_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorDatatypeInterimService>(entity =>
        {
            entity.ToTable("Enp_Connector_Datatype_InterimService", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Datatype_InterimService_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Datatype_InterimService_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Datatype_InterimService_dss_update_trigger");
                });

            entity.Property(e => e.DataType).HasMaxLength(50);
        });

        modelBuilder.Entity<EnpConnectorDatatypeInterimServiceDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Datatype_InterimService_dss_tracking");

            entity.ToTable("Enp_Connector_Datatype_InterimService_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorDatatypeSapHana>(entity =>
        {
            entity.ToTable("Enp_Connector_Datatype_SapHana", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Datatype_SapHana_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Datatype_SapHana_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Datatype_SapHana_dss_update_trigger");
                });

            entity.Property(e => e.DataType).HasMaxLength(50);
        });

        modelBuilder.Entity<EnpConnectorDatatypeSapHanaAzureSql>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC07F7BA0C22");

            entity.ToTable("Enp_Connector_Datatype_SapHana_AzureSql", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Datatype_SapHana_AzureSql_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Datatype_SapHana_AzureSql_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Datatype_SapHana_AzureSql_dss_update_trigger");
                });

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

        modelBuilder.Entity<EnpConnectorDatatypeSapHanaAzureSqlDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Datatype_SapHana_AzureSql_dss_tracking");

            entity.ToTable("Enp_Connector_Datatype_SapHana_AzureSql_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorDatatypeSapHanaDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Datatype_SapHana_dss_tracking");

            entity.ToTable("Enp_Connector_Datatype_SapHana_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorPipeline>(entity =>
        {
            entity.ToTable("Enp_Connector_Pipeline", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Pipeline_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_dss_update_trigger");
                });

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

        modelBuilder.Entity<EnpConnectorPipelineDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Pipeline_dss_tracking");

            entity.ToTable("Enp_Connector_Pipeline_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorPipelineMapping>(entity =>
        {
            entity.ToTable("Enp_Connector_Pipeline_Mapping", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Pipeline_Mapping_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_Mapping_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_Mapping_dss_update_trigger");
                });

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

        modelBuilder.Entity<EnpConnectorPipelineMappingDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Pipeline_Mapping_dss_tracking");

            entity.ToTable("Enp_Connector_Pipeline_Mapping_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorPipelineTrigger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC0710CD38ED");

            entity.ToTable("Enp_Connector_Pipeline_Trigger", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Pipeline_Trigger_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_Trigger_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_Trigger_dss_update_trigger");
                });

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Recurrence).HasMaxLength(255);
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

        modelBuilder.Entity<EnpConnectorPipelineTriggerDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Pipeline_Trigger_dss_tracking");

            entity.ToTable("Enp_Connector_Pipeline_Trigger_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorPipelineTriggerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enp_Conn__3214EC077045C3FB");

            entity.ToTable("Enp_Connector_Pipeline_TriggerType", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Pipeline_TriggerType_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_TriggerType_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_TriggerType_dss_update_trigger");
                });

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EnpConnectorPipelineTriggerTypeDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Pipeline_TriggerType_dss_tracking");

            entity.ToTable("Enp_Connector_Pipeline_TriggerType_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorPipelineWriteBehaviour>(entity =>
        {
            entity.ToTable("Enp_Connector_Pipeline_WriteBehaviour", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Pipeline_WriteBehaviour_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_WriteBehaviour_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_WriteBehaviour_dss_update_trigger");
                });

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EnpConnectorPipelineWriteBehaviourDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Pipeline_WriteBehaviour_dss_tracking");

            entity.ToTable("Enp_Connector_Pipeline_WriteBehaviour_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorPipelineWriteOption>(entity =>
        {
            entity.ToTable("Enp_Connector_Pipeline_WriteOption", tb =>
                {
                    tb.HasTrigger("Enp_Connector_Pipeline_WriteOption_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_WriteOption_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_Pipeline_WriteOption_dss_update_trigger");
                });

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EnpConnectorPipelineWriteOptionDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_Pipeline_WriteOption_dss_tracking");

            entity.ToTable("Enp_Connector_Pipeline_WriteOption_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnpConnectorSqlAutomation>(entity =>
        {
            entity.ToTable("Enp_Connector_SqlAutomation", tb =>
                {
                    tb.HasTrigger("Enp_Connector_SqlAutomation_dss_delete_trigger");
                    tb.HasTrigger("Enp_Connector_SqlAutomation_dss_insert_trigger");
                    tb.HasTrigger("Enp_Connector_SqlAutomation_dss_update_trigger");
                });

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

        modelBuilder.Entity<EnpConnectorSqlAutomationDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Enp_Connector_SqlAutomation_dss_tracking");

            entity.ToTable("Enp_Connector_SqlAutomation_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EnumType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EnumType__3214EC0750838047");

            entity.ToTable("EnumType", "dss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LastModified)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Events__FD6BEF84E1E5AC2B");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Events_dss_delete_trigger");
                    tb.HasTrigger("Events_dss_insert_trigger");
                    tb.HasTrigger("Events_dss_update_trigger");
                });

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

            entity.ToTable("EventCategory", tb =>
                {
                    tb.HasTrigger("EventCategory_dss_delete_trigger");
                    tb.HasTrigger("EventCategory_dss_insert_trigger");
                    tb.HasTrigger("EventCategory_dss_update_trigger");
                });

            entity.Property(e => e.EcategoryId)
                .ValueGeneratedNever()
                .HasColumnName("ECategory_ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(200)
                .HasColumnName("Category_Name");
        });

        modelBuilder.Entity<EventCategoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.EcategoryId).HasName("PK_DataSync.EventCategory_dss_tracking");

            entity.ToTable("EventCategory_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.EcategoryId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.EcategoryId)
                .ValueGeneratedNever()
                .HasColumnName("ECategory_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EventComponent>(entity =>
        {
            entity.HasKey(e => e.EcomponentId).HasName("PK__EventCom__91861D69B15E56D1");

            entity.ToTable("EventComponent", tb =>
                {
                    tb.HasTrigger("EventComponent_dss_delete_trigger");
                    tb.HasTrigger("EventComponent_dss_insert_trigger");
                    tb.HasTrigger("EventComponent_dss_update_trigger");
                });

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

        modelBuilder.Entity<EventComponentDssTracking>(entity =>
        {
            entity.HasKey(e => e.EcomponentId).HasName("PK_DataSync.EventComponent_dss_tracking");

            entity.ToTable("EventComponent_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.EcomponentId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.EcomponentId)
                .ValueGeneratedNever()
                .HasColumnName("EComponent_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EventComponentLookup>(entity =>
        {
            entity.HasKey(e => e.EcomponentId).HasName("PK__EventCom__91861D09208F80B3");

            entity.ToTable("EventComponentLookup", tb =>
                {
                    tb.HasTrigger("EventComponentLookup_dss_delete_trigger");
                    tb.HasTrigger("EventComponentLookup_dss_insert_trigger");
                    tb.HasTrigger("EventComponentLookup_dss_update_trigger");
                });

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

        modelBuilder.Entity<EventComponentLookupDssTracking>(entity =>
        {
            entity.HasKey(e => e.EcomponentId).HasName("PK_DataSync.EventComponentLookup_dss_tracking");

            entity.ToTable("EventComponentLookup_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.EcomponentId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.EcomponentId)
                .ValueGeneratedNever()
                .HasColumnName("EComponent_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<EventsDssTracking>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_DataSync.Events_dss_tracking");

            entity.ToTable("Events_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.EventId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("Event_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ExceptionLogging>(entity =>
        {
            entity.ToTable("Exception_Logging", tb =>
                {
                    tb.HasTrigger("Exception_Logging_dss_delete_trigger");
                    tb.HasTrigger("Exception_Logging_dss_insert_trigger");
                    tb.HasTrigger("Exception_Logging_dss_update_trigger");
                });

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

        modelBuilder.Entity<ExceptionLoggingDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Exception_Logging_dss_tracking");

            entity.ToTable("Exception_Logging_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Export5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("export (5)");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TagName).HasMaxLength(50);
        });

        modelBuilder.Entity<ExportPipeLine>(entity =>
        {
            entity.HasKey(e => e.PipeLineId).HasName("PK__ExportPi__81251D8F73607690");

            entity.ToTable("ExportPipeLine", tb =>
                {
                    tb.HasTrigger("ExportPipeLine_dss_delete_trigger");
                    tb.HasTrigger("ExportPipeLine_dss_insert_trigger");
                    tb.HasTrigger("ExportPipeLine_dss_update_trigger");
                });

            entity.Property(e => e.ConnectionHostName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataPointResolutionValueType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DatabaseName).HasMaxLength(200);
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

        modelBuilder.Entity<ExportPipeLineDssTracking>(entity =>
        {
            entity.HasKey(e => e.PipeLineId).HasName("PK_DataSync.ExportPipeLine_dss_tracking");

            entity.ToTable("ExportPipeLine_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.PipeLineId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.PipeLineId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ExportSiteLayOutStatus>(entity =>
        {
            entity.HasKey(e => e.SiteLayOutId);

            entity.ToTable("ExportSiteLayOutStatus", tb =>
                {
                    tb.HasTrigger("ExportSiteLayOutStatus_dss_delete_trigger");
                    tb.HasTrigger("ExportSiteLayOutStatus_dss_insert_trigger");
                    tb.HasTrigger("ExportSiteLayOutStatus_dss_update_trigger");
                });

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

        modelBuilder.Entity<ExportSiteLayOutStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.SiteLayOutId).HasName("PK_DataSync.ExportSiteLayOutStatus_dss_tracking");

            entity.ToTable("ExportSiteLayOutStatus_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SiteLayOutId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SiteLayOutId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ExportToExcelStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExportTo__3214EC0770AE464F");

            entity.ToTable("ExportToExcelStatus", tb =>
                {
                    tb.HasTrigger("ExportToExcelStatus_dss_delete_trigger");
                    tb.HasTrigger("ExportToExcelStatus_dss_insert_trigger");
                    tb.HasTrigger("ExportToExcelStatus_dss_update_trigger");
                });

            entity.Property(e => e.ExportedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OperationId).HasMaxLength(255);
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<ExportToExcelStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ExportToExcelStatus_dss_tracking");

            entity.ToTable("ExportToExcelStatus_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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

        modelBuilder.Entity<FastAlarm>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("FastAlarms_dss_delete_trigger");
                    tb.HasTrigger("FastAlarms_dss_insert_trigger");
                    tb.HasTrigger("FastAlarms_dss_update_trigger");
                });

            entity.Property(e => e.MappedName).HasMaxLength(100);
            entity.Property(e => e.TagType).HasMaxLength(50);
        });

        modelBuilder.Entity<FastAlarmsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.FastAlarms_dss_tracking");

            entity.ToTable("FastAlarms_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<FintechSiteShiftsConfiguration>(entity =>
        {
            entity.HasKey(e => e.FsId);

            entity.ToTable("Fintech_Site_ShiftsConfigurations", tb =>
                {
                    tb.HasTrigger("Fintech_Site_ShiftsConfigurations_dss_delete_trigger");
                    tb.HasTrigger("Fintech_Site_ShiftsConfigurations_dss_insert_trigger");
                    tb.HasTrigger("Fintech_Site_ShiftsConfigurations_dss_update_trigger");
                });

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

        modelBuilder.Entity<FintechSiteShiftsConfigurationsDssTracking>(entity =>
        {
            entity.HasKey(e => e.FsId).HasName("PK_DataSync.Fintech_Site_ShiftsConfigurations_dss_tracking");

            entity.ToTable("Fintech_Site_ShiftsConfigurations_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.FsId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.FsId)
                .ValueGeneratedNever()
                .HasColumnName("FS_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<FintechTankDelivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TDD");

            entity.ToTable("Fintech_TankDelivery", tb =>
                {
                    tb.HasTrigger("Fintech_TankDelivery_dss_delete_trigger");
                    tb.HasTrigger("Fintech_TankDelivery_dss_insert_trigger");
                    tb.HasTrigger("Fintech_TankDelivery_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateEnd)
                .HasColumnType("date")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasColumnType("date")
                .HasColumnName("date_start");
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

        modelBuilder.Entity<FintechTankDeliveryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Fintech_TankDelivery_dss_tracking");

            entity.ToTable("Fintech_TankDelivery_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<FintechTransactionstype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fintech___3214EC2707EA55C2");

            entity.ToTable("fintech_transactionstype", tb =>
                {
                    tb.HasTrigger("fintech_transactionstype_dss_delete_trigger");
                    tb.HasTrigger("fintech_transactionstype_dss_insert_trigger");
                    tb.HasTrigger("fintech_transactionstype_dss_update_trigger");
                });

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

        modelBuilder.Entity<FintechTransactionstypeDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.fintech_transactionstype_dss_tracking");

            entity.ToTable("fintech_transactionstype_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<FmLogin>(entity =>
        {
            entity.ToTable("FM_Login", tb =>
                {
                    tb.HasTrigger("FM_Login_dss_delete_trigger");
                    tb.HasTrigger("FM_Login_dss_insert_trigger");
                    tb.HasTrigger("FM_Login_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(10);
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(10);
        });

        modelBuilder.Entity<FmLoginDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.FM_Login_dss_tracking");

            entity.ToTable("FM_Login_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<FormatTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormatTa__3214EC27A3595AAC");

            entity.ToTable("FormatTable", tb =>
                {
                    tb.HasTrigger("FormatTable_dss_delete_trigger");
                    tb.HasTrigger("FormatTable_dss_insert_trigger");
                    tb.HasTrigger("FormatTable_dss_update_trigger");
                });

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

        modelBuilder.Entity<FormatTableDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.FormatTable_dss_tracking");

            entity.ToTable("FormatTable_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<FormulaDependenciesMetrix>(entity =>
        {
            entity.HasKey(e => e.FdmId).HasName("PK__Formula___527C2DA7750A68DC");

            entity.ToTable("Formula_Dependencies_Metrix", tb =>
                {
                    tb.HasTrigger("Formula_Dependencies_Metrix_dss_delete_trigger");
                    tb.HasTrigger("Formula_Dependencies_Metrix_dss_insert_trigger");
                    tb.HasTrigger("Formula_Dependencies_Metrix_dss_update_trigger");
                });

            entity.Property(e => e.FdmId).HasColumnName("FDM_Id");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FStatus).HasColumnName("F_status");
            entity.Property(e => e.FormulaId).HasColumnName("Formula_ID");
            entity.Property(e => e.FormulaPId).HasColumnName("Formula_P_ID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

        modelBuilder.Entity<FormulaDependenciesMetrixDssTracking>(entity =>
        {
            entity.HasKey(e => e.FdmId).HasName("PK_DataSync.Formula_Dependencies_Metrix_dss_tracking");

            entity.ToTable("Formula_Dependencies_Metrix_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.FdmId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.FdmId)
                .ValueGeneratedNever()
                .HasColumnName("FDM_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<FormulaLibrary>(entity =>
        {
            entity.HasKey(e => e.FormulaLibId);

            entity.ToTable("Formula_Library", tb =>
                {
                    tb.HasTrigger("Formula_Library_dss_delete_trigger");
                    tb.HasTrigger("Formula_Library_dss_insert_trigger");
                    tb.HasTrigger("Formula_Library_dss_update_trigger");
                });

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
                        j.ToTable("Asset_Lib_Formula_Lib_M_To_M", tb =>
                            {
                                tb.HasTrigger("Asset_Lib_Formula_Lib_M_To_M_dss_delete_trigger");
                                tb.HasTrigger("Asset_Lib_Formula_Lib_M_To_M_dss_insert_trigger");
                                tb.HasTrigger("Asset_Lib_Formula_Lib_M_To_M_dss_update_trigger");
                            });
                    });
        });

        modelBuilder.Entity<FormulaLibraryDssTracking>(entity =>
        {
            entity.HasKey(e => e.FormulaLibId).HasName("PK_DataSync.Formula_Library_dss_tracking");

            entity.ToTable("Formula_Library_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.FormulaLibId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.FormulaLibId)
                .ValueGeneratedNever()
                .HasColumnName("Formula_Lib_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<FormulaLibraryHistory>(entity =>
        {
            entity.HasKey(e => e.FormulaLibId);

            entity.ToTable("Formula_Library_History", tb =>
                {
                    tb.HasTrigger("Formula_Library_History_dss_delete_trigger");
                    tb.HasTrigger("Formula_Library_History_dss_insert_trigger");
                    tb.HasTrigger("Formula_Library_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<FormulaLibraryHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.FormulaLibId).HasName("PK_DataSync.Formula_Library_History_dss_tracking");

            entity.ToTable("Formula_Library_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.FormulaLibId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.FormulaLibId)
                .ValueGeneratedNever()
                .HasColumnName("Formula_Lib_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<HubcoNelManual>(entity =>
        {
            entity.HasKey(e => e.Date).HasName("PK__Hubco_NE__77387D068E7E4703");

            entity.ToTable("Hubco_NEL_manual", tb =>
                {
                    tb.HasTrigger("Hubco_NEL_manual_dss_delete_trigger");
                    tb.HasTrigger("Hubco_NEL_manual_dss_insert_trigger");
                    tb.HasTrigger("Hubco_NEL_manual_dss_update_trigger");
                });

            entity.HasIndex(e => e.Date, "UQ__Hubco_NE__77387D0797E7DB38").IsUnique();

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.CapacityFactor).HasColumnName("Capacity_Factor");
            entity.Property(e => e.FuelStockHfoTank1).HasColumnName("Fuel_Stock_HFO_Tank_1");
            entity.Property(e => e.FuelStockHfoTank2).HasColumnName("Fuel_Stock_HFO_Tank_2");
            entity.Property(e => e.FuelStockHfoTank3).HasColumnName("Fuel_Stock_HFO_Tank_3");
            entity.Property(e => e.ImportEnergy).HasColumnName("Import_Energy");
            entity.Property(e => e.InhouseConsumption).HasColumnName("Inhouse_Consumption");
            entity.Property(e => e.SolarGeneration).HasColumnName("Solar_Generation");
        });

        modelBuilder.Entity<HubcoNelManualDssTracking>(entity =>
        {
            entity.HasKey(e => e.Date).HasName("PK_DataSync.Hubco_NEL_manual_dss_tracking");

            entity.ToTable("Hubco_NEL_manual_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Date }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ImportFile>(entity =>
        {
            entity.HasKey(e => e.ImportId);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("ImportFiles_dss_delete_trigger");
                    tb.HasTrigger("ImportFiles_dss_insert_trigger");
                    tb.HasTrigger("ImportFiles_dss_update_trigger");
                });

            entity.Property(e => e.ImportId).HasColumnName("Import_Id");
            entity.Property(e => e.ImportBy).IsUnicode(false);
            entity.Property(e => e.ImportEndDate).HasColumnType("datetime");
            entity.Property(e => e.ImportStartDate).HasColumnType("datetime");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_Fk");
        });

        modelBuilder.Entity<ImportFileStatus>(entity =>
        {
            entity.HasKey(e => e.ImportStatusId);

            entity.ToTable("Import_File_Status", tb =>
                {
                    tb.HasTrigger("Import_File_Status_dss_delete_trigger");
                    tb.HasTrigger("Import_File_Status_dss_insert_trigger");
                    tb.HasTrigger("Import_File_Status_dss_update_trigger");
                });

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

        modelBuilder.Entity<ImportFileStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.ImportStatusId).HasName("PK_DataSync.Import_File_Status_dss_tracking");

            entity.ToTable("Import_File_Status_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ImportStatusId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ImportStatusId)
                .ValueGeneratedNever()
                .HasColumnName("Import_Status_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ImportFilesDssTracking>(entity =>
        {
            entity.HasKey(e => e.ImportId).HasName("PK_DataSync.ImportFiles_dss_tracking");

            entity.ToTable("ImportFiles_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ImportId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ImportId)
                .ValueGeneratedNever()
                .HasColumnName("Import_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<IndustryType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Industry__3214EC27A131C04C");

            entity.ToTable("Industry_Type", tb =>
                {
                    tb.HasTrigger("Industry_Type_dss_delete_trigger");
                    tb.HasTrigger("Industry_Type_dss_insert_trigger");
                    tb.HasTrigger("Industry_Type_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<IndustryTypeDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Industry_Type_dss_tracking");

            entity.ToTable("Industry_Type_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<IngestionStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingestio__3214EC07666271ED");

            entity.ToTable("IngestionStatus", tb =>
                {
                    tb.HasTrigger("IngestionStatus_dss_delete_trigger");
                    tb.HasTrigger("IngestionStatus_dss_insert_trigger");
                    tb.HasTrigger("IngestionStatus_dss_update_trigger");
                });

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CsvFileName).HasMaxLength(255);
            entity.Property(e => e.CurrentRange).HasMaxLength(255);
            entity.Property(e => e.DataRange).HasMaxLength(255);
            entity.Property(e => e.OperationId).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<IngestionStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.IngestionStatus_dss_tracking");

            entity.ToTable("IngestionStatus_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<IotDeviceMetric>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Iot_Devi__3214EC2762231470");

            entity.ToTable("Iot_Device_Metrics", tb =>
                {
                    tb.HasTrigger("Iot_Device_Metrics_dss_delete_trigger");
                    tb.HasTrigger("Iot_Device_Metrics_dss_insert_trigger");
                    tb.HasTrigger("Iot_Device_Metrics_dss_update_trigger");
                });

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

        modelBuilder.Entity<IotDeviceMetricsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Iot_Device_Metrics_dss_tracking");

            entity.ToTable("Iot_Device_Metrics_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__Job__056690C245081E03");

            entity.ToTable("Job", "TaskHosting");

            entity.HasIndex(e => e.IsCancelled, "index_job_iscancelled");

            entity.Property(e => e.JobId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InitialInsertTimeUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("InitialInsertTimeUTC");
        });

        modelBuilder.Entity<JobExecutionLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__JobExecu__9E2397E0069B7D6F");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("JobExecutionLogs_dss_delete_trigger");
                    tb.HasTrigger("JobExecutionLogs_dss_insert_trigger");
                    tb.HasTrigger("JobExecutionLogs_dss_update_trigger");
                });

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

        modelBuilder.Entity<JobExecutionLogsDssTracking>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_DataSync.JobExecutionLogs_dss_tracking");

            entity.ToTable("JobExecutionLogs_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.LogId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.LogId)
                .ValueGeneratedNever()
                .HasColumnName("log_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<KpiFormula>(entity =>
        {
            entity.HasKey(e => e.FId).HasName("PK__KPI_FORM__2C6EC7C385946F2B");

            entity.ToTable("KPI_FORMULA", tb =>
                {
                    tb.HasTrigger("KPI_FORMULA_dss_delete_trigger");
                    tb.HasTrigger("KPI_FORMULA_dss_insert_trigger");
                    tb.HasTrigger("KPI_FORMULA_dss_update_trigger");
                });

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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

        modelBuilder.Entity<KpiFormulaDssTracking>(entity =>
        {
            entity.HasKey(e => e.FId).HasName("PK_DataSync.KPI_FORMULA_dss_tracking");

            entity.ToTable("KPI_FORMULA_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.FId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.FId)
                .ValueGeneratedNever()
                .HasColumnName("F_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<KpiFormulaVariableM2M>(entity =>
        {
            entity.HasKey(e => e.FvM2mId).HasName("PK__KPI_FORM__919B9BD09BE6FAC3");

            entity.ToTable("KPI_FORMULA_VARIABLE_M_2_M", tb =>
                {
                    tb.HasTrigger("KPI_FORMULA_VARIABLE_M_2_M_dss_delete_trigger");
                    tb.HasTrigger("KPI_FORMULA_VARIABLE_M_2_M_dss_insert_trigger");
                    tb.HasTrigger("KPI_FORMULA_VARIABLE_M_2_M_dss_update_trigger");
                });

            entity.Property(e => e.FvM2mId).HasColumnName("FV_M2M_ID");
            entity.Property(e => e.FId).HasColumnName("F_ID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

        modelBuilder.Entity<KpiFormulaVariableM2MDssTracking>(entity =>
        {
            entity.HasKey(e => e.FvM2mId).HasName("PK_DataSync.KPI_FORMULA_VARIABLE_M_2_M_dss_tracking");

            entity.ToTable("KPI_FORMULA_VARIABLE_M_2_M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.FvM2mId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.FvM2mId)
                .ValueGeneratedNever()
                .HasColumnName("FV_M2M_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<KpiSFormulaAttachment>(entity =>
        {
            entity.HasKey(e => e.FaId).HasName("PK__KPI'S_FO__4C1ADB3BB9E7D98A");

            entity.ToTable("KPI'S_FORMULA_ATTACHMENT", tb =>
                {
                    tb.HasTrigger("KPI'S_FORMULA_ATTACHMENT_dss_delete_trigger");
                    tb.HasTrigger("KPI'S_FORMULA_ATTACHMENT_dss_insert_trigger");
                    tb.HasTrigger("KPI'S_FORMULA_ATTACHMENT_dss_update_trigger");
                });

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

        modelBuilder.Entity<KpiSFormulaAttachmentDssTracking>(entity =>
        {
            entity.HasKey(e => e.FaId).HasName("PK_DataSync.KPI'S_FORMULA_ATTACHMENT_dss_tracking");

            entity.ToTable("KPI'S_FORMULA_ATTACHMENT_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.FaId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.FaId)
                .ValueGeneratedNever()
                .HasColumnName("FA_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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
                .HasDefaultValueSql("((1))")
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
                .HasDefaultValueSql("((1))")
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

        modelBuilder.Entity<LogEventsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.LogEvents_dss_tracking");

            entity.ToTable("LogEvents_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ManualFixPoint>(entity =>
        {
            entity.HasKey(e => e.MfId);

            entity.ToTable("Manual_Fix_Points", tb =>
                {
                    tb.HasTrigger("Manual_Fix_Points_dss_delete_trigger");
                    tb.HasTrigger("Manual_Fix_Points_dss_insert_trigger");
                    tb.HasTrigger("Manual_Fix_Points_dss_update_trigger");
                });

            entity.Property(e => e.MfId).HasColumnName("MF_Id");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_Id_FK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("Created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_date");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

        modelBuilder.Entity<ManualFixPointsDssTracking>(entity =>
        {
            entity.HasKey(e => e.MfId).HasName("PK_DataSync.Manual_Fix_Points_dss_tracking");

            entity.ToTable("Manual_Fix_Points_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.MfId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.MfId)
                .ValueGeneratedNever()
                .HasColumnName("MF_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ManualFixPointsHistory>(entity =>
        {
            entity.HasKey(e => e.MfId);

            entity.ToTable("Manual_Fix_Points_History", tb =>
                {
                    tb.HasTrigger("Manual_Fix_Points_History_dss_delete_trigger");
                    tb.HasTrigger("Manual_Fix_Points_History_dss_insert_trigger");
                    tb.HasTrigger("Manual_Fix_Points_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<ManualFixPointsHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.MfId).HasName("PK_DataSync.Manual_Fix_Points_History_dss_tracking");

            entity.ToTable("Manual_Fix_Points_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.MfId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.MfId)
                .ValueGeneratedNever()
                .HasColumnName("MF_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<MessageQueue>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__MessageQ__C87C0C9C4F294516");

            entity.ToTable("MessageQueue", "TaskHosting");

            entity.HasIndex(e => new { e.QueueId, e.UpdateTimeUtc, e.InsertTimeUtc, e.ExecTimes, e.Version }, "index_messagequeue_getnextmessage");

            entity.HasIndex(e => new { e.QueueId, e.MessageType, e.UpdateTimeUtc, e.InsertTimeUtc, e.ExecTimes, e.Version }, "index_messagequeue_getnextmessagebytype");

            entity.HasIndex(e => e.JobId, "index_messagequeue_jobid");

            entity.Property(e => e.MessageId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InitialInsertTimeUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("InitialInsertTimeUTC");
            entity.Property(e => e.InsertTimeUtc)
                .HasColumnType("datetime")
                .HasColumnName("InsertTimeUTC");
            entity.Property(e => e.UpdateTimeUtc)
                .HasColumnType("datetime")
                .HasColumnName("UpdateTimeUTC");

            entity.HasOne(d => d.Job).WithMany(p => p.MessageQueues)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__MessageQu__JobId__669110E3");
        });

        modelBuilder.Entity<MetaInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MetaInfo__3214EC07DD28F661");

            entity.ToTable("MetaInformation", "dss");

            entity.Property(e => e.State)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VersionString)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('1.0.0.0')");
        });

        modelBuilder.Entity<MetaInformation1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MetaInfo__3214EC070AAB9A74");

            entity.ToTable("MetaInformation", "TaskHosting");

            entity.Property(e => e.State)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VersionString)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('1.0.0.0')");
        });

        modelBuilder.Entity<ModBusDeviceTagsImportStatus>(entity =>
        {
            entity.ToTable("ModBusDeviceTagsImportStatus", tb =>
                {
                    tb.HasTrigger("ModBusDeviceTagsImportStatus_dss_delete_trigger");
                    tb.HasTrigger("ModBusDeviceTagsImportStatus_dss_insert_trigger");
                    tb.HasTrigger("ModBusDeviceTagsImportStatus_dss_update_trigger");
                });

            entity.Property(e => e.ImportEndDate).HasColumnType("datetime");
            entity.Property(e => e.ImportStartDate).HasColumnType("datetime");

            entity.HasOne(d => d.DeviceIdFkNavigation).WithMany(p => p.ModBusDeviceTagsImportStatuses)
                .HasForeignKey(d => d.DeviceIdFk)
                .HasConstraintName("FK_ModBusDeviceTagsImportStatus_Devices");
        });

        modelBuilder.Entity<ModBusDeviceTagsImportStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ModBusDeviceTagsImportStatus_dss_tracking");

            entity.ToTable("ModBusDeviceTagsImportStatus_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ModelTrainingType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModelTra__3214EC0764E2B3E2");

            entity.ToTable("ModelTrainingType", tb =>
                {
                    tb.HasTrigger("ModelTrainingType_dss_delete_trigger");
                    tb.HasTrigger("ModelTrainingType_dss_insert_trigger");
                    tb.HasTrigger("ModelTrainingType_dss_update_trigger");
                });

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModelTrainingTypeDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ModelTrainingType_dss_tracking");

            entity.ToTable("ModelTrainingType_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Mtd>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("PK__MTD__B9DCB903EA33DB5F");

            entity.ToTable("MTD", tb =>
                {
                    tb.HasTrigger("MTD_dss_delete_trigger");
                    tb.HasTrigger("MTD_dss_insert_trigger");
                    tb.HasTrigger("MTD_dss_update_trigger");
                });

            entity.Property(e => e.SiteId)
                .ValueGeneratedNever()
                .HasColumnName("SiteID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MtdDssTracking>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("PK_DataSync.MTD_dss_tracking");

            entity.ToTable("MTD_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SiteId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SiteId)
                .ValueGeneratedNever()
                .HasColumnName("SiteID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<NotificationCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Notifica__19093A0B9F142D7B");

            entity.ToTable("NotificationCategory", tb =>
                {
                    tb.HasTrigger("NotificationCategory_dss_delete_trigger");
                    tb.HasTrigger("NotificationCategory_dss_insert_trigger");
                    tb.HasTrigger("NotificationCategory_dss_update_trigger");
                });

            entity.Property(e => e.CategoryName).IsUnicode(false);
        });

        modelBuilder.Entity<NotificationCategoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK_DataSync.NotificationCategory_dss_tracking");

            entity.ToTable("NotificationCategory_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CategoryId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CategoryId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<NotificationComponent>(entity =>
        {
            entity.HasKey(e => e.ComponentId).HasName("PK__Notifica__D79CF04EEC839B5B");

            entity.ToTable("NotificationComponent", tb =>
                {
                    tb.HasTrigger("NotificationComponent_dss_delete_trigger");
                    tb.HasTrigger("NotificationComponent_dss_insert_trigger");
                    tb.HasTrigger("NotificationComponent_dss_update_trigger");
                });

            entity.Property(e => e.ComponentName).IsUnicode(false);

            entity.HasOne(d => d.CategoryIdFkNavigation).WithMany(p => p.NotificationComponents)
                .HasForeignKey(d => d.CategoryIdFk)
                .HasConstraintName("FK_NotificationComponent.CategoryIdFk");
        });

        modelBuilder.Entity<NotificationComponentDssTracking>(entity =>
        {
            entity.HasKey(e => e.ComponentId).HasName("PK_DataSync.NotificationComponent_dss_tracking");

            entity.ToTable("NotificationComponent_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ComponentId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ComponentId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<NotificationEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Notifica__7944C81073765D5B");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("NotificationEvents_dss_delete_trigger");
                    tb.HasTrigger("NotificationEvents_dss_insert_trigger");
                    tb.HasTrigger("NotificationEvents_dss_update_trigger");
                });

            entity.Property(e => e.EventName).IsUnicode(false);

            entity.HasOne(d => d.ComponentIdFkNavigation).WithMany(p => p.NotificationEvents)
                .HasForeignKey(d => d.ComponentIdFk)
                .HasConstraintName("FK_NotificationEvents.ComponentIdFk");
        });

        modelBuilder.Entity<NotificationEventsConfigM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notifica__3214EC0722F57882");

            entity.ToTable("NotificationEventsConfigM2M", tb =>
                {
                    tb.HasTrigger("NotificationEventsConfigM2M_dss_delete_trigger");
                    tb.HasTrigger("NotificationEventsConfigM2M_dss_insert_trigger");
                    tb.HasTrigger("NotificationEventsConfigM2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<NotificationEventsConfigM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.NotificationEventsConfigM2M_dss_tracking");

            entity.ToTable("NotificationEventsConfigM2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<NotificationEventsDssTracking>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_DataSync.NotificationEvents_dss_tracking");

            entity.ToTable("NotificationEvents_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.EventId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.EventId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Nozzel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__nozzel__3213E83FC91C3254");

            entity.ToTable("nozzel", tb =>
                {
                    tb.HasTrigger("nozzel_dss_delete_trigger");
                    tb.HasTrigger("nozzel_dss_insert_trigger");
                    tb.HasTrigger("nozzel_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NozzelId).HasColumnName("NozzelID");
            entity.Property(e => e.PumpId).HasColumnName("PumpID");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.TankId).HasColumnName("TankID");
        });

        modelBuilder.Entity<NozzelDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.nozzel_dss_tracking");

            entity.ToTable("nozzel_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<NtwManualEntryCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NTW_Manu__3214EC271DDE4D65");

            entity.ToTable("NTW_Manual_Entry_Count", tb =>
                {
                    tb.HasTrigger("NTW_Manual_Entry_Count_dss_delete_trigger");
                    tb.HasTrigger("NTW_Manual_Entry_Count_dss_insert_trigger");
                    tb.HasTrigger("NTW_Manual_Entry_Count_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aycount).HasColumnName("AYcount");
            entity.Property(e => e.CbPmcount).HasColumnName("CbPMcount");
            entity.Property(e => e.Clcount).HasColumnName("CLcount");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Gfcount).HasColumnName("GFcount");
            entity.Property(e => e.Totalcount).HasColumnName("TOTALcount");
        });

        modelBuilder.Entity<NtwManualEntryCountDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.NTW_Manual_Entry_Count_dss_tracking");

            entity.ToTable("NTW_Manual_Entry_Count_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<NtwManualEntryExtra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NTW_Manu__3214EC2779C48B6F");

            entity.ToTable("NTW_Manual_Entry_Extra", tb =>
                {
                    tb.HasTrigger("NTW_Manual_Entry_Extra_dss_delete_trigger");
                    tb.HasTrigger("NTW_Manual_Entry_Extra_dss_insert_trigger");
                    tb.HasTrigger("NTW_Manual_Entry_Extra_dss_update_trigger");
                });

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

        modelBuilder.Entity<NtwManualEntryExtraDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.NTW_Manual_Entry_Extra_dss_tracking");

            entity.ToTable("NTW_Manual_Entry_Extra_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<NtwManualEntrySpecloss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NTW_Manu__3214EC279D5E704A");

            entity.ToTable("NTW_Manual_Entry_Specloss", tb =>
                {
                    tb.HasTrigger("NTW_Manual_Entry_Specloss_dss_delete_trigger");
                    tb.HasTrigger("NTW_Manual_Entry_Specloss_dss_insert_trigger");
                    tb.HasTrigger("NTW_Manual_Entry_Specloss_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ayloss).HasColumnName("AYloss");
            entity.Property(e => e.CbPmloss).HasColumnName("CbPMloss");
            entity.Property(e => e.Clloss).HasColumnName("CLloss");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Gfloss).HasColumnName("GFloss");
            entity.Property(e => e.Totalloss).HasColumnName("TOTALloss");
        });

        modelBuilder.Entity<NtwManualEntrySpeclossDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.NTW_Manual_Entry_Specloss_dss_tracking");

            entity.ToTable("NTW_Manual_Entry_Specloss_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OdlProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__ODL_Prod__B40CC6CD0BCCD98B");

            entity.ToTable("ODL_Product", tb =>
                {
                    tb.HasTrigger("ODL_Product_dss_delete_trigger");
                    tb.HasTrigger("ODL_Product_dss_insert_trigger");
                    tb.HasTrigger("ODL_Product_dss_update_trigger");
                });

            entity.Property(e => e.ProductName)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OdlProductDssTracking>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_DataSync.ODL_Product_dss_tracking");

            entity.ToTable("ODL_Product_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ProductId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OmniFintechSiteMapping>(entity =>
        {
            entity.ToTable("Omni_Fintech_SiteMapping", tb =>
                {
                    tb.HasTrigger("Omni_Fintech_SiteMapping_dss_delete_trigger");
                    tb.HasTrigger("Omni_Fintech_SiteMapping_dss_insert_trigger");
                    tb.HasTrigger("Omni_Fintech_SiteMapping_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FcSiteId).HasColumnName("FC_SiteID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OmniSiteId).HasColumnName("Omni_SiteID");
        });

        modelBuilder.Entity<OmniFintechSiteMappingDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Omni_Fintech_SiteMapping_dss_tracking");

            entity.ToTable("Omni_Fintech_SiteMapping_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OmniFintechTankMapping>(entity =>
        {
            entity.ToTable("Omni_Fintech_TankMapping", tb =>
                {
                    tb.HasTrigger("Omni_Fintech_TankMapping_dss_delete_trigger");
                    tb.HasTrigger("Omni_Fintech_TankMapping_dss_insert_trigger");
                    tb.HasTrigger("Omni_Fintech_TankMapping_dss_update_trigger");
                });

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

        modelBuilder.Entity<OmniFintechTankMappingDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Omni_Fintech_TankMapping_dss_tracking");

            entity.ToTable("Omni_Fintech_TankMapping_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpcQualityCode>(entity =>
        {
            entity.HasKey(e => e.ScId).HasName("PK__OPC_Qual__C402E57E7CC0BDC3");

            entity.ToTable("OPC_QualityCode", tb =>
                {
                    tb.HasTrigger("OPC_QualityCode_dss_delete_trigger");
                    tb.HasTrigger("OPC_QualityCode_dss_insert_trigger");
                    tb.HasTrigger("OPC_QualityCode_dss_update_trigger");
                });

            entity.Property(e => e.ScId).HasColumnName("SC_Id");
            entity.Property(e => e.ScTitle)
                .HasMaxLength(200)
                .HasColumnName("SC_Title");
        });

        modelBuilder.Entity<OpcQualityCodeDssTracking>(entity =>
        {
            entity.HasKey(e => e.ScId).HasName("PK_DataSync.OPC_QualityCode_dss_tracking");

            entity.ToTable("OPC_QualityCode_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ScId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ScId)
                .ValueGeneratedNever()
                .HasColumnName("SC_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpcQualityCodetType>(entity =>
        {
            entity.HasKey(e => e.SctId).HasName("PK__OPC_Qual__68F019D4E93C94AF");

            entity.ToTable("OPC_QualityCodetTypes", tb =>
                {
                    tb.HasTrigger("OPC_QualityCodetTypes_dss_delete_trigger");
                    tb.HasTrigger("OPC_QualityCodetTypes_dss_insert_trigger");
                    tb.HasTrigger("OPC_QualityCodetTypes_dss_update_trigger");
                });

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
            entity.ToTable("OPC_QualityCodetTypes_DATA_ALARM_M2M", tb =>
                {
                    tb.HasTrigger("OPC_QualityCodetTypes_DATA_ALARM_M2M_dss_delete_trigger");
                    tb.HasTrigger("OPC_QualityCodetTypes_DATA_ALARM_M2M_dss_insert_trigger");
                    tb.HasTrigger("OPC_QualityCodetTypes_DATA_ALARM_M2M_dss_update_trigger");
                });

            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

        modelBuilder.Entity<OpcQualityCodetTypesDataAlarmM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.OPC_QualityCodetTypes_DATA_ALARM_M2M_dss_tracking");

            entity.ToTable("OPC_QualityCodetTypes_DATA_ALARM_M2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpcQualityCodetTypesDssTracking>(entity =>
        {
            entity.HasKey(e => e.SctId).HasName("PK_DataSync.OPC_QualityCodetTypes_dss_tracking");

            entity.ToTable("OPC_QualityCodetTypes_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SctId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SctId)
                .ValueGeneratedNever()
                .HasColumnName("SCT_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpcServerConfig>(entity =>
        {
            entity.ToTable("OPC_Server_Config", tb =>
                {
                    tb.HasTrigger("OPC_Server_Config_dss_delete_trigger");
                    tb.HasTrigger("OPC_Server_Config_dss_insert_trigger");
                    tb.HasTrigger("OPC_Server_Config_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OpcPassword).HasColumnName("OPC_Password");
            entity.Property(e => e.OpcSecurity).HasColumnName("OPC_Security");
            entity.Property(e => e.OpcServerAddress).HasColumnName("OPC_Server_Address");
            entity.Property(e => e.OpcUsername).HasColumnName("OPC_Username");
        });

        modelBuilder.Entity<OpcServerConfigDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.OPC_Server_Config_dss_tracking");

            entity.ToTable("OPC_Server_Config_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpcSourceTag>(entity =>
        {
            entity.HasKey(e => e.SourceTagId);

            entity.ToTable("OPC_SourceTags", tb =>
                {
                    tb.HasTrigger("OPC_SourceTags_dss_delete_trigger");
                    tb.HasTrigger("OPC_SourceTags_dss_insert_trigger");
                    tb.HasTrigger("OPC_SourceTags_dss_update_trigger");
                });

            entity.HasIndex(e => new { e.SiteSpecificDeviceId, e.IsValid, e.SiteIdFk }, "nci_wi_OPC_SourceTags_734623396A398C3E5512104F768C298C");

            entity.Property(e => e.SourceTagId).HasColumnName("Source_Tag_Id");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DlTagId).HasColumnName("DL_Tag_Id");
            entity.Property(e => e.HeartBeatRate).HasColumnName("Heart_Beat_Rate");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsValid)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

            entity.ToTable("OPC_SourceTags_CM", tb =>
                {
                    tb.HasTrigger("OPC_SourceTags_CM_dss_delete_trigger");
                    tb.HasTrigger("OPC_SourceTags_CM_dss_insert_trigger");
                    tb.HasTrigger("OPC_SourceTags_CM_dss_update_trigger");
                });

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

        modelBuilder.Entity<OpcSourceTagsCmDssTracking>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_DataSync.OPC_SourceTags_CM_dss_tracking");

            entity.ToTable("OPC_SourceTags_CM_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.EventId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("Event_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpcSourceTagsDssTracking>(entity =>
        {
            entity.HasKey(e => e.SourceTagId).HasName("PK_DataSync.OPC_SourceTags_dss_tracking");

            entity.ToTable("OPC_SourceTags_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SourceTagId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SourceTagId)
                .ValueGeneratedNever()
                .HasColumnName("Source_Tag_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpcSourceTagsDummy>(entity =>
        {
            entity.HasKey(e => e.SourceTagId);

            entity.ToTable("OPC_SourceTags_Dummy", tb =>
                {
                    tb.HasTrigger("OPC_SourceTags_Dummy_dss_delete_trigger");
                    tb.HasTrigger("OPC_SourceTags_Dummy_dss_insert_trigger");
                    tb.HasTrigger("OPC_SourceTags_Dummy_dss_update_trigger");
                });

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

        modelBuilder.Entity<OpcSourceTagsDummyDssTracking>(entity =>
        {
            entity.HasKey(e => e.SourceTagId).HasName("PK_DataSync.OPC_SourceTags_Dummy_dss_tracking");

            entity.ToTable("OPC_SourceTags_Dummy_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SourceTagId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SourceTagId)
                .ValueGeneratedNever()
                .HasColumnName("Source_Tag_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpenAiconfigurationHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OpenAICo__3214EC07FE75A2B3");

            entity.ToTable("OpenAIConfigurationHistory", tb =>
                {
                    tb.HasTrigger("OpenAIConfigurationHistory_dss_delete_trigger");
                    tb.HasTrigger("OpenAIConfigurationHistory_dss_insert_trigger");
                    tb.HasTrigger("OpenAIConfigurationHistory_dss_update_trigger");
                });

            entity.Property(e => e.EventType).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<OpenAiconfigurationHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.OpenAIConfigurationHistory_dss_tracking");

            entity.ToTable("OpenAIConfigurationHistory_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OpenAifileHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07174B2466");

            entity.ToTable("OpenAIFileHistory", tb =>
                {
                    tb.HasTrigger("OpenAIFileHistory_dss_delete_trigger");
                    tb.HasTrigger("OpenAIFileHistory_dss_insert_trigger");
                    tb.HasTrigger("OpenAIFileHistory_dss_update_trigger");
                });

            entity.Property(e => e.FileId).HasMaxLength(255);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.FileSize).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<OpenAifileHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.OpenAIFileHistory_dss_tracking");

            entity.ToTable("OpenAIFileHistory_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<OutputTagDataDssTracking>(entity =>
        {
            entity.HasKey(e => e.OutputTagId).HasName("PK_DataSync.Output_Tag_Data_dss_tracking");

            entity.ToTable("Output_Tag_Data_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.OutputTagId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.OutputTagId)
                .ValueGeneratedNever()
                .HasColumnName("Output_Tag_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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
                .HasDefaultValueSql("((1))")
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
                .HasDefaultValueSql("((1))")
                .HasColumnName("isActive");
            entity.Property(e => e.ParameterDescription).HasColumnName("Parameter_Description");
            entity.Property(e => e.ParameterName).HasColumnName("Parameter_Name");
            entity.Property(e => e.Unit).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<OutputTagParametersDssTracking>(entity =>
        {
            entity.HasKey(e => e.OutputParameterId).HasName("PK_DataSync.Output_Tag_Parameters_dss_tracking");

            entity.ToTable("Output_Tag_Parameters_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.OutputParameterId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.OutputParameterId)
                .ValueGeneratedNever()
                .HasColumnName("Output_Parameter_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__Permissi__EFA6FB2F483EBB54");

            entity.ToTable("Permission", tb =>
                {
                    tb.HasTrigger("Permission_dss_delete_trigger");
                    tb.HasTrigger("Permission_dss_insert_trigger");
                    tb.HasTrigger("Permission_dss_update_trigger");
                });

            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("((1))")
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

        modelBuilder.Entity<PermissionCategoriesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.PermissionCategories_dss_tracking");

            entity.ToTable("PermissionCategories_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<PermissionCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permissi__3214EC27BBF9870F");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("PermissionCategories_dss_delete_trigger");
                    tb.HasTrigger("PermissionCategories_dss_insert_trigger");
                    tb.HasTrigger("PermissionCategories_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PermissionDssTracking>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK_DataSync.Permission_dss_tracking");

            entity.ToTable("Permission_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.PermissionId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.PermissionId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<PhysicalAssetPropertiesDssTracking>(entity =>
        {
            entity.HasKey(e => e.PapId).HasName("PK_DataSync.Physical_Asset_Properties_dss_tracking");

            entity.ToTable("Physical_Asset_Properties_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.PapId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.PapId)
                .ValueGeneratedNever()
                .HasColumnName("PAP_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<PhysicalAssetProperty>(entity =>
        {
            entity.HasKey(e => e.PapId);

            entity.ToTable("Physical_Asset_Properties", tb =>
                {
                    tb.HasTrigger("Physical_Asset_Properties_dss_delete_trigger");
                    tb.HasTrigger("Physical_Asset_Properties_dss_insert_trigger");
                    tb.HasTrigger("Physical_Asset_Properties_dss_update_trigger");
                });

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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.DataTypeIdFkNavigation).WithMany(p => p.PipeLineTags)
                .HasForeignKey(d => d.DataTypeIdFk)
                .HasConstraintName("FK_PipeLineTags_TagsDataType");

            entity.HasOne(d => d.PipeLine).WithMany(p => p.PipeLineTags)
                .HasForeignKey(d => d.PipeLineId)
                .HasConstraintName("FK_PipeLineTags_ExportPipeLine");
        });

        modelBuilder.Entity<PipeLineTagsDssTracking>(entity =>
        {
            entity.HasKey(e => e.PltagsId).HasName("PK_DataSync.PipeLineTags_dss_tracking");

            entity.ToTable("PipeLineTags_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.PltagsId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.PltagsId)
                .ValueGeneratedNever()
                .HasColumnName("PLtagsId");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<PlantSite>(entity =>
        {
            entity.HasKey(e => e.SiteId);

            entity.ToTable("Plant_Site", tb =>
                {
                    tb.HasTrigger("Plant_Site_dss_delete_trigger");
                    tb.HasTrigger("Plant_Site_dss_insert_trigger");
                    tb.HasTrigger("Plant_Site_dss_update_trigger");
                    tb.HasTrigger("insert_site_to_ReadApiLimiter_table");
                    tb.HasTrigger("trg_AddSiteToReadAPILimits_V1");
                    tb.HasTrigger("update_Site_Name_ReadApiLimiter_table");
                });

            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.AdxRegion)
                .HasMaxLength(200)
                .HasColumnName("adx_region");
            entity.Property(e => e.AutomationTableName).HasMaxLength(250);
            entity.Property(e => e.BulkConnectionStringStatus).HasDefaultValueSql("((0))");
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
            entity.Property(e => e.EhConnection).HasColumnName("EH_Connection");
            entity.Property(e => e.GeographicalLocation)
                .HasMaxLength(500)
                .HasColumnName("Geographical_Location");
            entity.Property(e => e.IndustryType).HasColumnName("Industry_Type");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
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

        modelBuilder.Entity<PlantSiteDssTracking>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("PK_DataSync.Plant_Site_dss_tracking");

            entity.ToTable("Plant_Site_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SiteId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SiteId)
                .ValueGeneratedNever()
                .HasColumnName("Site_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<PlantSiteEmailTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlantSit__3214EC278257941F");

            entity.ToTable("PlantSiteEmailTracking", tb =>
                {
                    tb.HasTrigger("PlantSiteEmailTracking_dss_delete_trigger");
                    tb.HasTrigger("PlantSiteEmailTracking_dss_insert_trigger");
                    tb.HasTrigger("PlantSiteEmailTracking_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmailSent).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsSiteCreated).HasDefaultValueSql("((0))");
            entity.Property(e => e.SiteIdFk).HasColumnName("SiteId_Fk");
        });

        modelBuilder.Entity<PlantSiteEmailTrackingDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.PlantSiteEmailTracking_dss_tracking");

            entity.ToTable("PlantSiteEmailTracking_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ProcessAlarm>(entity =>
        {
            entity.HasKey(e => e.ProcessAlarmId).HasName("PK__PROCESS___D0DE65633E3053E9");

            entity.ToTable("PROCESS_ALARM", tb =>
                {
                    tb.HasTrigger("PROCESS_ALARM_dss_delete_trigger");
                    tb.HasTrigger("PROCESS_ALARM_dss_insert_trigger");
                    tb.HasTrigger("PROCESS_ALARM_dss_update_trigger");
                });

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

        modelBuilder.Entity<ProcessAlarmDssTracking>(entity =>
        {
            entity.HasKey(e => e.ProcessAlarmId).HasName("PK_DataSync.PROCESS_ALARM_dss_tracking");

            entity.ToTable("PROCESS_ALARM_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ProcessAlarmId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ProcessAlarmId)
                .ValueGeneratedNever()
                .HasColumnName("ProcessAlarm_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__47027DF5CD41D750");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Products_dss_delete_trigger");
                    tb.HasTrigger("Products_dss_insert_trigger");
                    tb.HasTrigger("Products_dss_update_trigger");
                });

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("product_id");
            entity.Property(e => e.ProductName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("product_name");
        });

        modelBuilder.Entity<ProductsDssTracking>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_DataSync.Products_dss_tracking");

            entity.ToTable("Products_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.ProductId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("product_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ProvisionMarkerDss>(entity =>
        {
            entity.HasKey(e => new { e.OwnerScopeLocalId, e.ObjectId }).HasName("PK_DataSync.provision_marker_dss");

            entity.ToTable("provision_marker_dss", "DataSync");

            entity.Property(e => e.OwnerScopeLocalId).HasColumnName("owner_scope_local_id");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.ProvisionDatetime)
                .HasColumnType("datetime")
                .HasColumnName("provision_datetime");
            entity.Property(e => e.ProvisionLocalPeerKey).HasColumnName("provision_local_peer_key");
            entity.Property(e => e.ProvisionScopeLocalId).HasColumnName("provision_scope_local_id");
            entity.Property(e => e.ProvisionScopePeerKey).HasColumnName("provision_scope_peer_key");
            entity.Property(e => e.ProvisionScopePeerTimestamp).HasColumnName("provision_scope_peer_timestamp");
            entity.Property(e => e.ProvisionTimestamp).HasColumnName("provision_timestamp");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<Pump>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pumps__3213E83FDF14153D");

            entity.ToTable("pumps", tb =>
                {
                    tb.HasTrigger("pumps_dss_delete_trigger");
                    tb.HasTrigger("pumps_dss_insert_trigger");
                    tb.HasTrigger("pumps_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Pumpid).HasColumnName("pumpid");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.Tankid).HasColumnName("tankid");
        });

        modelBuilder.Entity<PumpsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.pumps_dss_tracking");

            entity.ToTable("pumps_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<QualityManualEntryFibexDataDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Quality_Manual_Entry_Fibex_Data_dss_tracking");

            entity.ToTable("Quality_Manual_Entry_Fibex_Data_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<QualityManualEntryFibexDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quality___3214EC2754693B1F");

            entity.ToTable("Quality_Manual_Entry_Fibex_Data", tb =>
                {
                    tb.HasTrigger("Quality_Manual_Entry_Fibex_Data_dss_delete_trigger");
                    tb.HasTrigger("Quality_Manual_Entry_Fibex_Data_dss_insert_trigger");
                    tb.HasTrigger("Quality_Manual_Entry_Fibex_Data_dss_update_trigger");
                });

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

            entity.ToTable("Quality_Manual_Entry_MoistureContent_FilledValue", tb =>
                {
                    tb.HasTrigger("Quality_Manual_Entry_MoistureContent_FilledValue_dss_delete_trigger");
                    tb.HasTrigger("Quality_Manual_Entry_MoistureContent_FilledValue_dss_insert_trigger");
                    tb.HasTrigger("Quality_Manual_Entry_MoistureContent_FilledValue_dss_update_trigger");
                });

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

        modelBuilder.Entity<QualityManualEntryMoistureContentFilledValueDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Quality_Manual_Entry_MoistureContent_FilledValue_dss_tracking");

            entity.ToTable("Quality_Manual_Entry_MoistureContent_FilledValue_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<QualityManualEntryNtw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quality___3214EC271F011A6E");

            entity.ToTable("Quality_Manual_Entry_NTW", tb =>
                {
                    tb.HasTrigger("Quality_Manual_Entry_NTW_dss_delete_trigger");
                    tb.HasTrigger("Quality_Manual_Entry_NTW_dss_insert_trigger");
                    tb.HasTrigger("Quality_Manual_Entry_NTW_dss_update_trigger");
                });

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

        modelBuilder.Entity<QualityManualEntryNtwDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Quality_Manual_Entry_NTW_dss_tracking");

            entity.ToTable("Quality_Manual_Entry_NTW_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<QualityManualNtwConstantValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quality___3214EC27944D77BE");

            entity.ToTable("Quality_Manual_NTW_Constant_Values", tb =>
                {
                    tb.HasTrigger("Quality_Manual_NTW_Constant_Values_dss_delete_trigger");
                    tb.HasTrigger("Quality_Manual_NTW_Constant_Values_dss_insert_trigger");
                    tb.HasTrigger("Quality_Manual_NTW_Constant_Values_dss_update_trigger");
                });

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

        modelBuilder.Entity<QualityManualNtwConstantValuesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Quality_Manual_NTW_Constant_Values_dss_tracking");

            entity.ToTable("Quality_Manual_NTW_Constant_Values_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RawTagTarget>(entity =>
        {
            entity.HasKey(e => e.RawTagTergetId);

            entity.ToTable("Raw_Tag_Targets", tb =>
                {
                    tb.HasTrigger("Raw_Tag_Targets_dss_delete_trigger");
                    tb.HasTrigger("Raw_Tag_Targets_dss_insert_trigger");
                    tb.HasTrigger("Raw_Tag_Targets_dss_update_trigger");
                });

            entity.Property(e => e.RawTagTergetId).HasColumnName("Raw_Tag_Terget_Id");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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
            entity.ToTable("Raw_Tag_Target_Mon_Year", tb =>
                {
                    tb.HasTrigger("Raw_Tag_Target_Mon_Year_dss_delete_trigger");
                    tb.HasTrigger("Raw_Tag_Target_Mon_Year_dss_insert_trigger");
                    tb.HasTrigger("Raw_Tag_Target_Mon_Year_dss_update_trigger");
                });

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

        modelBuilder.Entity<RawTagTargetMonYearDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Raw_Tag_Target_Mon_Year_dss_tracking");

            entity.ToTable("Raw_Tag_Target_Mon_Year_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RawTagTargetMonYearHistory>(entity =>
        {
            entity.ToTable("Raw_Tag_Target_Mon_Year_History", tb =>
                {
                    tb.HasTrigger("Raw_Tag_Target_Mon_Year_History_dss_delete_trigger");
                    tb.HasTrigger("Raw_Tag_Target_Mon_Year_History_dss_insert_trigger");
                    tb.HasTrigger("Raw_Tag_Target_Mon_Year_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<RawTagTargetMonYearHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Raw_Tag_Target_Mon_Year_History_dss_tracking");

            entity.ToTable("Raw_Tag_Target_Mon_Year_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RawTagTargetsDssTracking>(entity =>
        {
            entity.HasKey(e => e.RawTagTergetId).HasName("PK_DataSync.Raw_Tag_Targets_dss_tracking");

            entity.ToTable("Raw_Tag_Targets_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.RawTagTergetId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.RawTagTergetId)
                .ValueGeneratedNever()
                .HasColumnName("Raw_Tag_Terget_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RawTagsTargetsHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId);

            entity.ToTable("Raw_Tags_Targets_History", tb =>
                {
                    tb.HasTrigger("Raw_Tags_Targets_History_dss_delete_trigger");
                    tb.HasTrigger("Raw_Tags_Targets_History_dss_insert_trigger");
                    tb.HasTrigger("Raw_Tags_Targets_History_dss_update_trigger");
                });

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

        modelBuilder.Entity<RawTagsTargetsHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_DataSync.Raw_Tags_Targets_History_dss_tracking");

            entity.ToTable("Raw_Tags_Targets_History_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.HistoryId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.HistoryId)
                .ValueGeneratedNever()
                .HasColumnName("HistoryID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ReadApiLimiter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tagTypeS__3214EC078F93D270");

            entity.ToTable("ReadApiLimiter", tb =>
                {
                    tb.HasTrigger("ReadApiLimiter_dss_delete_trigger");
                    tb.HasTrigger("ReadApiLimiter_dss_insert_trigger");
                    tb.HasTrigger("ReadApiLimiter_dss_update_trigger");
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

        modelBuilder.Entity<ReadApiLimiterDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ReadApiLimiter_dss_tracking");

            entity.ToTable("ReadApiLimiter_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ReadApiLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__ReadApiL__5E5499A852704FF4");

            entity.ToTable("ReadApiLog", tb =>
                {
                    tb.HasTrigger("ReadApiLog_dss_delete_trigger");
                    tb.HasTrigger("ReadApiLog_dss_insert_trigger");
                    tb.HasTrigger("ReadApiLog_dss_update_trigger");
                });

            entity.HasIndex(e => new { e.SiteName, e.CustomerName, e.Timestamp }, "IX_ReadApiLog_Site_Cust_Time_SizeBytes");

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

        modelBuilder.Entity<ReadApiLogDssTracking>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_DataSync.ReadApiLog_dss_tracking");

            entity.ToTable("ReadApiLog_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.LogId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.LogId)
                .ValueGeneratedNever()
                .HasColumnName("LogID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ReadApilimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReadAPIL__3214EC07F3C73321");

            entity.ToTable("ReadAPILimits", tb =>
                {
                    tb.HasTrigger("ReadAPILimits_dss_delete_trigger");
                    tb.HasTrigger("ReadAPILimits_dss_insert_trigger");
                    tb.HasTrigger("ReadAPILimits_dss_update_trigger");
                });

            entity.HasIndex(e => new { e.CustomerName, e.SiteName, e.UserAccessLevel }, "UQ__ReadAPIL__B5CDE85A5D9E4119").IsUnique();

            entity.Property(e => e.CustomerName).HasMaxLength(255);
            entity.Property(e => e.SiteName).HasMaxLength(255);
        });

        modelBuilder.Entity<ReadApilimitsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.ReadAPILimits_dss_tracking");

            entity.ToTable("ReadAPILimits_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<ReadapiPayload>(entity =>
        {
            entity.HasKey(e => e.OrchestratorId).HasName("PK_orchestrator");

            entity.ToTable("readapi_payload", tb =>
                {
                    tb.HasTrigger("readapi_payload_dss_delete_trigger");
                    tb.HasTrigger("readapi_payload_dss_insert_trigger");
                    tb.HasTrigger("readapi_payload_dss_update_trigger");
                });

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

        modelBuilder.Entity<ReadapiPayloadDssTracking>(entity =>
        {
            entity.HasKey(e => e.OrchestratorId).HasName("PK_DataSync.readapi_payload_dss_tracking");

            entity.ToTable("readapi_payload_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.OrchestratorId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.OrchestratorId)
                .HasMaxLength(200)
                .HasColumnName("orchestrator_id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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
            entity.Property(e => e.Deadband).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.FlowRate).HasColumnName("Flow_Rate");
            entity.Property(e => e.HeartBeatRate).HasColumnName("Heart_Beat_Rate");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsCloudTotalizer)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Is_Cloud_Totalizer");
            entity.Property(e => e.IsGps)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsGPS");
            entity.Property(e => e.IsTTotalizer)
                .HasDefaultValueSql("((0))")
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

        modelBuilder.Entity<RealRawPointsDssTracking>(entity =>
        {
            entity.HasKey(e => e.RealTagId).HasName("PK_DataSync.Real_Raw_Points_dss_tracking");

            entity.ToTable("Real_Raw_Points_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.RealTagId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.RealTagId)
                .ValueGeneratedNever()
                .HasColumnName("Real_Tag_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RecipientGroup>(entity =>
        {
            entity.HasKey(e => e.GrId).HasName("PK__RECIPIEN__80CBC3229ED43CED");

            entity.ToTable("RECIPIENT_GROUP", tb =>
                {
                    tb.HasTrigger("RECIPIENT_GROUP_dss_delete_trigger");
                    tb.HasTrigger("RECIPIENT_GROUP_dss_insert_trigger");
                    tb.HasTrigger("RECIPIENT_GROUP_dss_update_trigger");
                });

            entity.Property(e => e.GrId).HasColumnName("GR_ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GrTitle)
                .HasMaxLength(200)
                .HasColumnName("GR_Title  ");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RecipientGroupDssTracking>(entity =>
        {
            entity.HasKey(e => e.GrId).HasName("PK_DataSync.RECIPIENT_GROUP_dss_tracking");

            entity.ToTable("RECIPIENT_GROUP_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.GrId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.GrId)
                .ValueGeneratedNever()
                .HasColumnName("GR_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RecipientGroupM2m>(entity =>
        {
            entity.HasKey(e => e.RgId).HasName("PK__RECIPIEN__C1DD87DE1EF72A24");

            entity.ToTable("RECIPIENT_GROUP_M2M", tb =>
                {
                    tb.HasTrigger("RECIPIENT_GROUP_M2M_dss_delete_trigger");
                    tb.HasTrigger("RECIPIENT_GROUP_M2M_dss_insert_trigger");
                    tb.HasTrigger("RECIPIENT_GROUP_M2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<RecipientGroupM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.RgId).HasName("PK_DataSync.RECIPIENT_GROUP_M2M_dss_tracking");

            entity.ToTable("RECIPIENT_GROUP_M2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.RgId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.RgId)
                .ValueGeneratedNever()
                .HasColumnName("RG_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RecipientsGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Recipien__149AF36A64B29D05");

            entity.ToTable("RecipientsGroup", tb =>
                {
                    tb.HasTrigger("RecipientsGroup_dss_delete_trigger");
                    tb.HasTrigger("RecipientsGroup_dss_insert_trigger");
                    tb.HasTrigger("RecipientsGroup_dss_update_trigger");
                });

            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupName).IsUnicode(false);
            entity.Property(e => e.SiId).HasColumnName("SI_ID");
            entity.Property(e => e.UpdatedBy).IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RecipientsGroupDssTracking>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_DataSync.RecipientsGroup_dss_tracking");

            entity.ToTable("RecipientsGroup_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.GroupId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.GroupId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RecipientsInfo>(entity =>
        {
            entity.HasKey(e => e.RecipientInfoId).HasName("PK__Recipien__9DBBE69BB75895AC");

            entity.ToTable("RecipientsInfo", tb =>
                {
                    tb.HasTrigger("RecipientsInfo_dss_delete_trigger");
                    tb.HasTrigger("RecipientsInfo_dss_insert_trigger");
                    tb.HasTrigger("RecipientsInfo_dss_update_trigger");
                });

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

        modelBuilder.Entity<RecipientsInfoDssTracking>(entity =>
        {
            entity.HasKey(e => e.RecipientInfoId).HasName("PK_DataSync.RecipientsInfo_dss_tracking");

            entity.ToTable("RecipientsInfo_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.RecipientInfoId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.RecipientInfoId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Region__ACD844433E6FD124");

            entity.ToTable("Region", tb =>
                {
                    tb.HasTrigger("Region_dss_delete_trigger");
                    tb.HasTrigger("Region_dss_insert_trigger");
                    tb.HasTrigger("Region_dss_update_trigger");
                });

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

        modelBuilder.Entity<RegionDssTracking>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK_DataSync.Region_dss_tracking");

            entity.ToTable("Region_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.RegionId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("RegionID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE1AA340A3D0");

            entity.ToTable("Role", tb =>
                {
                    tb.HasTrigger("Role_dss_delete_trigger");
                    tb.HasTrigger("Role_dss_insert_trigger");
                    tb.HasTrigger("Role_dss_update_trigger");
                });

            entity.Property(e => e.CreatedByUser).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsDefaultRole).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProductIdFk).HasColumnName("ProductId_Fk");
            entity.Property(e => e.RoleName).HasMaxLength(300);
            entity.Property(e => e.UpdatedByUser).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.ProductIdFkNavigation).WithMany(p => p.Roles)
                .HasForeignKey(d => d.ProductIdFk)
                .HasConstraintName("FK_RoleProduct");
        });

        modelBuilder.Entity<RoleDssTracking>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_DataSync.Role_dss_tracking");

            entity.ToTable("Role_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.RoleId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<RolePermissionM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RolePerm__3214EC27523A4355");

            entity.ToTable("RolePermissionM2M", tb =>
                {
                    tb.HasTrigger("RolePermissionM2M_dss_delete_trigger");
                    tb.HasTrigger("RolePermissionM2M_dss_insert_trigger");
                    tb.HasTrigger("RolePermissionM2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<RolePermissionM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.RolePermissionM2M_dss_tracking");

            entity.ToTable("RolePermissionM2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Scaleunitlimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__scaleuni__3214EC074049B34C");

            entity.ToTable("scaleunitlimits", "dss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LastModified)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__Schedule__9C8A5B49BE246E58");

            entity.ToTable("Schedule", "TaskHosting");
        });

        modelBuilder.Entity<ScheduleTask>(entity =>
        {
            entity.HasKey(e => e.SyncGroupId);

            entity.ToTable("ScheduleTask", "dss");

            entity.Property(e => e.SyncGroupId).ValueGeneratedNever();
            entity.Property(e => e.ExpirationTime).HasColumnType("datetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");

            entity.HasOne(d => d.SyncGroup).WithOne(p => p.ScheduleTask)
                .HasForeignKey<ScheduleTask>(d => d.SyncGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ScheduleT__SyncG");
        });

        modelBuilder.Entity<ScheduleTask1>(entity =>
        {
            entity.HasKey(e => e.ScheduleTaskId).HasName("PK__Schedule__8DAD173AE915855C");

            entity.ToTable("ScheduleTask", "TaskHosting");

            entity.HasIndex(e => e.MessageId, "ScheduleTask_MessageId_Index");

            entity.Property(e => e.ScheduleTaskId).ValueGeneratedNever();
            entity.Property(e => e.NextRunTime).HasColumnType("datetime");
            entity.Property(e => e.TaskName).HasMaxLength(128);

            entity.HasOne(d => d.ScheduleNavigation).WithMany(p => p.ScheduleTask1s)
                .HasForeignKey(d => d.Schedule)
                .HasConstraintName("FK__ScheduleT__Sched__710E9F56");
        });

        modelBuilder.Entity<SchemaInfoDss>(entity =>
        {
            entity.HasKey(e => new { e.SchemaMajorVersion, e.SchemaMinorVersion }).HasName("PK_DataSync.schema_info_dss");

            entity.ToTable("schema_info_dss", "DataSync");

            entity.Property(e => e.SchemaMajorVersion).HasColumnName("schema_major_version");
            entity.Property(e => e.SchemaMinorVersion).HasColumnName("schema_minor_version");
            entity.Property(e => e.SchemaExtendedInfo)
                .HasMaxLength(100)
                .HasColumnName("schema_extended_info");
        });

        modelBuilder.Entity<ScopeConfigDss>(entity =>
        {
            entity.HasKey(e => e.ConfigId).HasName("PK_DataSync.scope_config_dss");

            entity.ToTable("scope_config_dss", "DataSync");

            entity.Property(e => e.ConfigId)
                .ValueGeneratedNever()
                .HasColumnName("config_id");
            entity.Property(e => e.ConfigData)
                .HasColumnType("xml")
                .HasColumnName("config_data");
            entity.Property(e => e.ScopeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("scope_status");
        });

        modelBuilder.Entity<ScopeInfoDss>(entity =>
        {
            entity.HasKey(e => e.SyncScopeName).HasName("PK_DataSync.scope_info_dss");

            entity.ToTable("scope_info_dss", "DataSync");

            entity.Property(e => e.SyncScopeName)
                .HasMaxLength(100)
                .HasColumnName("sync_scope_name");
            entity.Property(e => e.ScopeConfigId).HasColumnName("scope_config_id");
            entity.Property(e => e.ScopeId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("scope_id");
            entity.Property(e => e.ScopeLocalId)
                .ValueGeneratedOnAdd()
                .HasColumnName("scope_local_id");
            entity.Property(e => e.ScopeRestoreCount).HasColumnName("scope_restore_count");
            entity.Property(e => e.ScopeSyncKnowledge).HasColumnName("scope_sync_knowledge");
            entity.Property(e => e.ScopeTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("scope_timestamp");
            entity.Property(e => e.ScopeTombstoneCleanupKnowledge).HasColumnName("scope_tombstone_cleanup_knowledge");
            entity.Property(e => e.ScopeUserComment).HasColumnName("scope_user_comment");
        });

        modelBuilder.Entity<SidefaultRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SIDefaul__3214EC27BA88ED66");

            entity.ToTable("SIDefaultRegion", tb =>
                {
                    tb.HasTrigger("SIDefaultRegion_dss_delete_trigger");
                    tb.HasTrigger("SIDefaultRegion_dss_insert_trigger");
                    tb.HasTrigger("SIDefaultRegion_dss_update_trigger");
                });

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

        modelBuilder.Entity<SidefaultRegionDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.SIDefaultRegion_dss_tracking");

            entity.ToTable("SIDefaultRegion_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SiteComponentConfiguration>(entity =>
        {
            entity.HasKey(e => e.SiteOpeId).HasName("PK__SiteComp__C818BC4E50BDC7FB");

            entity.ToTable("SiteComponentConfiguration", tb =>
                {
                    tb.HasTrigger("SiteComponentConfiguration_dss_delete_trigger");
                    tb.HasTrigger("SiteComponentConfiguration_dss_insert_trigger");
                    tb.HasTrigger("SiteComponentConfiguration_dss_update_trigger");
                });

            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.ComponentIdFkNavigation).WithMany(p => p.SiteComponentConfigurations)
                .HasForeignKey(d => d.ComponentIdFk)
                .HasConstraintName("FK_SiteComponentConfiguration.ComponentIdFk");
        });

        modelBuilder.Entity<SiteComponentConfigurationDssTracking>(entity =>
        {
            entity.HasKey(e => e.SiteOpeId).HasName("PK_DataSync.SiteComponentConfiguration_dss_tracking");

            entity.ToTable("SiteComponentConfiguration_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SiteOpeId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SiteOpeId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SiteEventsM2m>(entity =>
        {
            entity.HasKey(e => e.SiteEventId);

            entity.ToTable("SITE_Events_M2M", tb =>
                {
                    tb.HasTrigger("SITE_Events_M2M_dss_delete_trigger");
                    tb.HasTrigger("SITE_Events_M2M_dss_insert_trigger");
                    tb.HasTrigger("SITE_Events_M2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<SiteEventsM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.SiteEventId).HasName("PK_DataSync.SITE_Events_M2M_dss_tracking");

            entity.ToTable("SITE_Events_M2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SiteEventId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SiteEventId)
                .ValueGeneratedNever()
                .HasColumnName("SiteEventID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SiteOpcDefaultSetting>(entity =>
        {
            entity.ToTable("Site_OPC_DefaultSettings", tb =>
                {
                    tb.HasTrigger("Site_OPC_DefaultSettings_dss_delete_trigger");
                    tb.HasTrigger("Site_OPC_DefaultSettings_dss_insert_trigger");
                    tb.HasTrigger("Site_OPC_DefaultSettings_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceId).HasColumnName("Device_Id");
            entity.Property(e => e.HeartBeatRate).HasColumnName("Heart_Beat_Rate");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PublishRate).HasColumnName("Publish_Rate");
            entity.Property(e => e.ScanRate).HasColumnName("Scan_Rate");
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");
        });

        modelBuilder.Entity<SiteOpcDefaultSettingsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Site_OPC_DefaultSettings_dss_tracking");

            entity.ToTable("Site_OPC_DefaultSettings_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SiteRegionOne2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Site_Reg__3214EC2773E9ECB3");

            entity.ToTable("Site_Region_one2m", tb =>
                {
                    tb.HasTrigger("Site_Region_one2m_dss_delete_trigger");
                    tb.HasTrigger("Site_Region_one2m_dss_insert_trigger");
                    tb.HasTrigger("Site_Region_one2m_dss_update_trigger");
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

        modelBuilder.Entity<SiteRegionOne2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Site_Region_one2m_dss_tracking");

            entity.ToTable("Site_Region_one2m_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SourceTagImportStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SourceTa__3214EC27B4E54B0F");

            entity.ToTable("SourceTagImportStatus", tb =>
                {
                    tb.HasTrigger("SourceTagImportStatus_dss_delete_trigger");
                    tb.HasTrigger("SourceTagImportStatus_dss_insert_trigger");
                    tb.HasTrigger("SourceTagImportStatus_dss_update_trigger");
                });

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

        modelBuilder.Entity<SourceTagImportStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.SourceTagImportStatus_dss_tracking");

            entity.ToTable("SourceTagImportStatus_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SourceTagParameter>(entity =>
        {
            entity.HasKey(e => e.SourceTagParametersId).HasName("PK__Source_T__B8C66B6A13A6F271");

            entity.ToTable("Source_Tag_Parameters", tb =>
                {
                    tb.HasTrigger("Source_Tag_Parameters_dss_delete_trigger");
                    tb.HasTrigger("Source_Tag_Parameters_dss_insert_trigger");
                    tb.HasTrigger("Source_Tag_Parameters_dss_update_trigger");
                });

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

        modelBuilder.Entity<SourceTagParametersDssTracking>(entity =>
        {
            entity.HasKey(e => e.SourceTagParametersId).HasName("PK_DataSync.Source_Tag_Parameters_dss_tracking");

            entity.ToTable("Source_Tag_Parameters_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SourceTagParametersId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SourceTagParametersId)
                .ValueGeneratedNever()
                .HasColumnName("Source_Tag_Parameters_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__subscrip__3213E83FE6AF38A2");

            entity.ToTable("subscription", "dss");

            entity.HasIndex(e => e.Syncserveruniquename, "IX_SyncServerUniqueName")
                .IsUnique()
                .HasFilter("([syncserveruniquename] IS NOT NULL)");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Creationtime)
                .HasColumnType("datetime")
                .HasColumnName("creationtime");
            entity.Property(e => e.EnableDetailedProviderTracing).HasDefaultValueSql("((0))");
            entity.Property(e => e.Lastlogintime)
                .HasColumnType("datetime")
                .HasColumnName("lastlogintime");
            entity.Property(e => e.Name)
                .HasMaxLength(140)
                .HasColumnName("name");
            entity.Property(e => e.Policyid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("policyid");
            entity.Property(e => e.Subscriptionstate).HasColumnName("subscriptionstate");
            entity.Property(e => e.Syncserveruniquename)
                .HasMaxLength(256)
                .HasColumnName("syncserveruniquename");
            entity.Property(e => e.Tombstoneretentionperiodindays).HasColumnName("tombstoneretentionperiodindays");
            entity.Property(e => e.Version)
                .HasMaxLength(40)
                .HasColumnName("version");
        });

        modelBuilder.Entity<SubscriptionTag>(entity =>
        {
            entity.HasKey(e => e.SubId).HasName("PK__Subscrip__DFB18CAD0425DE1C");

            entity.ToTable("Subscription_Tags", tb =>
                {
                    tb.HasTrigger("Subscription_Tags_dss_delete_trigger");
                    tb.HasTrigger("Subscription_Tags_dss_insert_trigger");
                    tb.HasTrigger("Subscription_Tags_dss_update_trigger");
                });

            entity.Property(e => e.SubId).HasColumnName("Sub_ID");
            entity.Property(e => e.NoOfTags).HasColumnName("No_of_Tags");
            entity.Property(e => e.SubscriptionName)
                .HasMaxLength(200)
                .HasColumnName("Subscription_Name");
        });

        modelBuilder.Entity<SubscriptionTagsDssTracking>(entity =>
        {
            entity.HasKey(e => e.SubId).HasName("PK_DataSync.Subscription_Tags_dss_tracking");

            entity.ToTable("Subscription_Tags_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SubId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SubId)
                .ValueGeneratedNever()
                .HasColumnName("Sub_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SyncObjectDatum>(entity =>
        {
            entity.HasKey(e => new { e.ObjectId, e.DataType }).HasName("PK_SyncObjectExtInfo");

            entity.ToTable("SyncObjectData", "dss");

            entity.Property(e => e.CreatedTime).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.LastModified)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Syncgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__syncgrou__3213E83F7A7AD1E2");

            entity.ToTable("syncgroup", "dss");

            entity.HasIndex(e => e.HubMemberid, "index_syncgroup_hub_memberid");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ConflictResolutionPolicy).HasColumnName("conflict_resolution_policy");
            entity.Property(e => e.ConflictTableRetentionInDays).HasDefaultValueSql("((30))");
            entity.Property(e => e.HubMemberid).HasColumnName("hub_memberid");
            entity.Property(e => e.Hubhasdata).HasColumnName("hubhasdata");
            entity.Property(e => e.Lastupdatetime)
                .HasColumnType("datetime")
                .HasColumnName("lastupdatetime");
            entity.Property(e => e.Name)
                .HasMaxLength(140)
                .HasColumnName("name");
            entity.Property(e => e.Ocsschemadefinition).HasColumnName("ocsschemadefinition");
            entity.Property(e => e.SchemaDescription)
                .HasColumnType("xml")
                .HasColumnName("schema_description");
            entity.Property(e => e.State)
                .HasDefaultValueSql("((0))")
                .HasColumnName("state");
            entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");
            entity.Property(e => e.SyncEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("sync_enabled");
            entity.Property(e => e.SyncInterval).HasColumnName("sync_interval");

            entity.HasOne(d => d.HubMember).WithMany(p => p.Syncgroups)
                .HasForeignKey(d => d.HubMemberid)
                .HasConstraintName("FK__syncgroup__hub_m");

            entity.HasOne(d => d.Subscription).WithMany(p => p.Syncgroups)
                .HasForeignKey(d => d.Subscriptionid)
                .HasConstraintName("FK__syncgroup__subsc");
        });

        modelBuilder.Entity<Syncgroupmember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__syncgrou__3213E83F4FDABDD6");

            entity.ToTable("syncgroupmember", "dss");

            entity.HasIndex(e => new { e.Syncgroupid, e.Databaseid }, "IX_SyncGroupMember_SyncGroupId_DatabaseId").IsUnique();

            entity.HasIndex(e => e.Databaseid, "index_syncgroupmember_databaseid");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Databaseid).HasColumnName("databaseid");
            entity.Property(e => e.HubJobId).HasColumnName("hubJobId");
            entity.Property(e => e.Hubstate).HasColumnName("hubstate");
            entity.Property(e => e.HubstateLastupdated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("hubstate_lastupdated");
            entity.Property(e => e.JobId).HasColumnName("jobId");
            entity.Property(e => e.Lastsynctime)
                .HasColumnType("datetime")
                .HasColumnName("lastsynctime");
            entity.Property(e => e.LastsynctimeZerofailuresHub)
                .HasColumnType("datetime")
                .HasColumnName("lastsynctime_zerofailures_hub");
            entity.Property(e => e.LastsynctimeZerofailuresMember)
                .HasColumnType("datetime")
                .HasColumnName("lastsynctime_zerofailures_member");
            entity.Property(e => e.Memberhasdata).HasColumnName("memberhasdata");
            entity.Property(e => e.Memberstate).HasColumnName("memberstate");
            entity.Property(e => e.MemberstateLastupdated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("memberstate_lastupdated");
            entity.Property(e => e.Name)
                .HasMaxLength(140)
                .HasColumnName("name");
            entity.Property(e => e.Noinitsync).HasColumnName("noinitsync");
            entity.Property(e => e.Scopename)
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("scopename");
            entity.Property(e => e.Syncdirection).HasColumnName("syncdirection");
            entity.Property(e => e.Syncgroupid).HasColumnName("syncgroupid");

            entity.HasOne(d => d.Database).WithMany(p => p.Syncgroupmembers)
                .HasForeignKey(d => d.Databaseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__syncmember__datab");

            entity.HasOne(d => d.Syncgroup).WithMany(p => p.Syncgroupmembers)
                .HasForeignKey(d => d.Syncgroupid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__syncmember__syncg");
        });

        modelBuilder.Entity<SystemAlarmAction>(entity =>
        {
            entity.HasKey(e => e.SaaId).HasName("PK__SYSTEM_A__17D75666C8C7FB3E");

            entity.ToTable("SYSTEM_ALARM_ACTION", tb =>
                {
                    tb.HasTrigger("SYSTEM_ALARM_ACTION_dss_delete_trigger");
                    tb.HasTrigger("SYSTEM_ALARM_ACTION_dss_insert_trigger");
                    tb.HasTrigger("SYSTEM_ALARM_ACTION_dss_update_trigger");
                });

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

        modelBuilder.Entity<SystemAlarmActionDssTracking>(entity =>
        {
            entity.HasKey(e => e.SaaId).HasName("PK_DataSync.SYSTEM_ALARM_ACTION_dss_tracking");

            entity.ToTable("SYSTEM_ALARM_ACTION_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.SaaId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.SaaId)
                .ValueGeneratedNever()
                .HasColumnName("SAA_Id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SystemAlarmActionHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYSTEM_A__3214EC27D4E93BA8");

            entity.ToTable("SYSTEM_ALARM_ACTION_HISTORY", tb =>
                {
                    tb.HasTrigger("SYSTEM_ALARM_ACTION_HISTORY_dss_delete_trigger");
                    tb.HasTrigger("SYSTEM_ALARM_ACTION_HISTORY_dss_insert_trigger");
                    tb.HasTrigger("SYSTEM_ALARM_ACTION_HISTORY_dss_update_trigger");
                });

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

        modelBuilder.Entity<SystemAlarmActionHistoryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.SYSTEM_ALARM_ACTION_HISTORY_dss_tracking");

            entity.ToTable("SYSTEM_ALARM_ACTION_HISTORY_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<SystemIntegrator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__System_I__3214EC2751092BE9");

            entity.ToTable("System_Integrator", tb =>
                {
                    tb.HasTrigger("System_Integrator_dss_delete_trigger");
                    tb.HasTrigger("System_Integrator_dss_insert_trigger");
                    tb.HasTrigger("System_Integrator_dss_update_trigger");
                });

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

        modelBuilder.Entity<SystemIntegratorDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.System_Integrator_dss_tracking");

            entity.ToTable("System_Integrator_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TagLakeLastUpdate>(entity =>
        {
            entity.HasKey(e => e.TagUpdateId).HasName("PK__Tag_Lake__0226AC5B24BFB32A");

            entity.ToTable("Tag_Lake_Last_update");

            entity.Property(e => e.TagUpdateId).HasColumnName("Tag_Update_Id");
            entity.Property(e => e.CheckTime).HasColumnType("datetime");
            entity.Property(e => e.DeviceIdFk).HasColumnName("Device_Id_FK");
            entity.Property(e => e.IngestionTime).HasColumnName("Ingestion_Time");
            entity.Property(e => e.RMappedName)
                .HasMaxLength(10)
                .HasColumnName("R_Mapped_Name");
            entity.Property(e => e.RealTagIdFk).HasColumnName("Real_Tag_Id_FK");
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_id_FK");

            entity.HasOne(d => d.DeviceIdFkNavigation).WithMany(p => p.TagLakeLastUpdates)
                .HasForeignKey(d => d.DeviceIdFk)
                .HasConstraintName("FK__Tag_Lake___Devic__6E5DE68B");

            entity.HasOne(d => d.RealTagIdFkNavigation).WithMany(p => p.TagLakeLastUpdates)
                .HasForeignKey(d => d.RealTagIdFk)
                .HasConstraintName("FK__Tag_Lake___Real___6B8179E0");

            entity.HasOne(d => d.SiteIdFkNavigation).WithMany(p => p.TagLakeLastUpdates)
                .HasForeignKey(d => d.SiteIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tag_Lake___Site___6A8D55A7");
        });

        modelBuilder.Entity<TagType>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TagTypes_dss_delete_trigger");
                    tb.HasTrigger("TagTypes_dss_insert_trigger");
                    tb.HasTrigger("TagTypes_dss_update_trigger");
                });

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TagTypesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.TagTypes_dss_tracking");

            entity.ToTable("TagTypes_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TagsDataType>(entity =>
        {
            entity.HasKey(e => e.DataTypeId).HasName("PK_DataType");

            entity.ToTable("TagsDataType", tb =>
                {
                    tb.HasTrigger("TagsDataType_dss_delete_trigger");
                    tb.HasTrigger("TagsDataType_dss_insert_trigger");
                    tb.HasTrigger("TagsDataType_dss_update_trigger");
                });

            entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");
            entity.Property(e => e.TagTypeId).HasColumnName("TagTypeID");
        });

        modelBuilder.Entity<TagsDataTypeDssTracking>(entity =>
        {
            entity.HasKey(e => e.DataTypeId).HasName("PK_DataSync.TagsDataType_dss_tracking");

            entity.ToTable("TagsDataType_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.DataTypeId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.DataTypeId)
                .ValueGeneratedNever()
                .HasColumnName("DataTypeID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Tank>(entity =>
        {
            entity.HasKey(e => e.TankId).HasName("PK__Tank__97DE70057DC03B5A");

            entity.ToTable("Tank", tb =>
                {
                    tb.HasTrigger("Tank_dss_delete_trigger");
                    tb.HasTrigger("Tank_dss_insert_trigger");
                    tb.HasTrigger("Tank_dss_update_trigger");
                });

            entity.Property(e => e.TankId).HasColumnName("TankID");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ProdIdFk).HasColumnName("ProdID_FK");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
        });

        modelBuilder.Entity<TankDssTracking>(entity =>
        {
            entity.HasKey(e => e.TankId).HasName("PK_DataSync.Tank_dss_tracking");

            entity.ToTable("Tank_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.TankId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.TankId)
                .ValueGeneratedNever()
                .HasColumnName("TankID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TankStatusLive>(entity =>
        {
            entity.ToTable("TankStatusLive", tb =>
                {
                    tb.HasTrigger("TankStatusLive_dss_delete_trigger");
                    tb.HasTrigger("TankStatusLive_dss_insert_trigger");
                    tb.HasTrigger("TankStatusLive_dss_update_trigger");
                });

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

        modelBuilder.Entity<TankStatusLiveDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.TankStatusLive_dss_tracking");

            entity.ToTable("TankStatusLive_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });


        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblProdu__3214EC279C31C2C9");

            entity.ToTable("tblProduct", tb =>
                {
                    tb.HasTrigger("tblProduct_dss_delete_trigger");
                    tb.HasTrigger("tblProduct_dss_insert_trigger");
                    tb.HasTrigger("tblProduct_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.SiteIdFk).HasColumnName("Site_Id_Fk");
        });

        modelBuilder.Entity<TblProductDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.tblProduct_dss_tracking");

            entity.ToTable("tblProduct_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TblTankStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTankS__3214EC27080B0220");

            entity.ToTable("tblTankStatus", tb =>
                {
                    tb.HasTrigger("tblTankStatus_dss_delete_trigger");
                    tb.HasTrigger("tblTankStatus_dss_insert_trigger");
                    tb.HasTrigger("tblTankStatus_dss_update_trigger");
                });

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

        modelBuilder.Entity<TblTankStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.tblTankStatus_dss_tracking");

            entity.ToTable("tblTankStatus_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TblTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTrans__3214EC27E77CB9BC");

            entity.ToTable("tblTransactions", tb =>
                {
                    tb.HasTrigger("tblTransactions_dss_delete_trigger");
                    tb.HasTrigger("tblTransactions_dss_insert_trigger");
                    tb.HasTrigger("tblTransactions_dss_update_trigger");
                });

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

        modelBuilder.Entity<TblTransactionsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.tblTransactions_dss_tracking");

            entity.ToTable("tblTransactions_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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
            entity.ToTable("TestingTankStatus", tb =>
                {
                    tb.HasTrigger("TestingTankStatus_dss_delete_trigger");
                    tb.HasTrigger("TestingTankStatus_dss_insert_trigger");
                    tb.HasTrigger("TestingTankStatus_dss_update_trigger");
                });

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

        modelBuilder.Entity<TestingTankStatusDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.TestingTankStatus_dss_tracking");

            entity.ToTable("TestingTankStatus_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TimeBasedEntityAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TimeBase__3214EC0743C48D25");

            entity.ToTable("TimeBasedEntityAccess", tb =>
                {
                    tb.HasTrigger("TimeBasedEntityAccess_dss_delete_trigger");
                    tb.HasTrigger("TimeBasedEntityAccess_dss_insert_trigger");
                    tb.HasTrigger("TimeBasedEntityAccess_dss_update_trigger");
                    tb.HasTrigger("trgAfterAssigningTimeBasedAccess");
                    tb.HasTrigger("trgAfterUpdateTimeBasedAccess");
                });

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserTypeM2mFk).HasColumnName("UserTypeM2M_Fk");

            entity.HasOne(d => d.UserTypeM2mFkNavigation).WithMany(p => p.TimeBasedEntityAccesses)
                .HasForeignKey(d => d.UserTypeM2mFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTypeM2M");
        });

        modelBuilder.Entity<TimeBasedEntityAccessDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.TimeBasedEntityAccess_dss_tracking");

            entity.ToTable("TimeBasedEntityAccess_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TobaccoWasteConstantValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tobacco___3214EC27877A2F06");

            entity.ToTable("Tobacco_Waste_Constant_Values", tb =>
                {
                    tb.HasTrigger("Tobacco_Waste_Constant_Values_dss_delete_trigger");
                    tb.HasTrigger("Tobacco_Waste_Constant_Values_dss_insert_trigger");
                    tb.HasTrigger("Tobacco_Waste_Constant_Values_dss_update_trigger");
                });

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

        modelBuilder.Entity<TobaccoWasteConstantValuesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Tobacco_Waste_Constant_Values_dss_tracking");

            entity.ToTable("Tobacco_Waste_Constant_Values_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TobaccoWasteManualEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tobacco___3214EC273BF785D1");

            entity.ToTable("Tobacco_Waste_Manual_Entry", tb =>
                {
                    tb.HasTrigger("Tobacco_Waste_Manual_Entry_dss_delete_trigger");
                    tb.HasTrigger("Tobacco_Waste_Manual_Entry_dss_insert_trigger");
                    tb.HasTrigger("Tobacco_Waste_Manual_Entry_dss_update_trigger");
                });

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

        modelBuilder.Entity<TobaccoWasteManualEntryDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Tobacco_Waste_Manual_Entry_dss_tracking");

            entity.ToTable("Tobacco_Waste_Manual_Entry_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TrendingReport>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TrendingReports_dss_delete_trigger");
                    tb.HasTrigger("TrendingReports_dss_insert_trigger");
                    tb.HasTrigger("TrendingReports_dss_update_trigger");
                });

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
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TrendingReportFilters_dss_delete_trigger");
                    tb.HasTrigger("TrendingReportFilters_dss_insert_trigger");
                    tb.HasTrigger("TrendingReportFilters_dss_update_trigger");
                });

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Granularity).HasMaxLength(10);
            entity.Property(e => e.IsLocalTime).HasColumnName("isLocalTime");
            entity.Property(e => e.ReportIdFk).HasColumnName("ReportId_FK");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TrendingReportFiltersDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.TrendingReportFilters_dss_tracking");

            entity.ToTable("TrendingReportFilters_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TrendingReportTag>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TrendingReportTags_dss_delete_trigger");
                    tb.HasTrigger("TrendingReportTags_dss_insert_trigger");
                    tb.HasTrigger("TrendingReportTags_dss_update_trigger");
                });

            entity.Property(e => e.ReportIdFk).HasColumnName("ReportId_FK");
            entity.Property(e => e.TagIdFk).HasColumnName("TagId_FK");
            entity.Property(e => e.TagTypeIdFk).HasColumnName("TagTypeId_FK");
        });

        modelBuilder.Entity<TrendingReportTagsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.TrendingReportTags_dss_tracking");

            entity.ToTable("TrendingReportTags_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TrendingReportsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.TrendingReports_dss_tracking");

            entity.ToTable("TrendingReports_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TrendingReportsShared>(entity =>
        {
            entity.ToTable("TrendingReportsShared", tb =>
                {
                    tb.HasTrigger("TrendingReportsShared_dss_delete_trigger");
                    tb.HasTrigger("TrendingReportsShared_dss_insert_trigger");
                    tb.HasTrigger("TrendingReportsShared_dss_update_trigger");
                });

            entity.Property(e => e.ReportIdFk).HasColumnName("ReportId_FK");
            entity.Property(e => e.SharedBy).HasMaxLength(128);
            entity.Property(e => e.SharedDate).HasColumnType("datetime");
            entity.Property(e => e.SharedTo).HasMaxLength(128);
        });

        modelBuilder.Entity<TrendingReportsSharedDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.TrendingReportsShared_dss_tracking");

            entity.ToTable("TrendingReportsShared_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<TriggeredDataAlarm>(entity =>
        {
            entity.ToTable("Triggered_Data_Alarm", tb =>
                {
                    tb.HasTrigger("Triggered_Data_Alarm_dss_delete_trigger");
                    tb.HasTrigger("Triggered_Data_Alarm_dss_insert_trigger");
                    tb.HasTrigger("Triggered_Data_Alarm_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<TriggeredDataAlarmDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Triggered_Data_Alarm_dss_tracking");

            entity.ToTable("Triggered_Data_Alarm_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Uihistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UIHistory", "dss");

            entity.HasIndex(e => e.Agentid, "Idx_UIHistory_AgentId");

            entity.HasIndex(e => e.CompletionTime, "Idx_UIHistory_CompletionTime");

            entity.HasIndex(e => e.Databaseid, "Idx_UIHistory_DatabaseId");

            entity.HasIndex(e => e.Id, "Idx_UIHistory_Id");

            entity.HasIndex(e => e.Serverid, "Idx_UIHistory_ServerId").IsClustered();

            entity.HasIndex(e => e.SyncgroupId, "Idx_UIHistory_SyncgroupId");

            entity.Property(e => e.Agentid).HasColumnName("agentid");
            entity.Property(e => e.CompletionTime).HasColumnName("completionTime");
            entity.Property(e => e.Databaseid).HasColumnName("databaseid");
            entity.Property(e => e.DetailEnumId)
                .HasMaxLength(400)
                .HasColumnName("detailEnumId");
            entity.Property(e => e.DetailStringParameters).HasColumnName("detailStringParameters");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsWritable)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isWritable");
            entity.Property(e => e.RecordType).HasColumnName("recordType");
            entity.Property(e => e.Serverid).HasColumnName("serverid");
            entity.Property(e => e.SyncgroupId).HasColumnName("syncgroupId");
            entity.Property(e => e.TaskType).HasColumnName("taskType");
        });

        modelBuilder.Entity<UserActivityLogging>(entity =>
        {
            entity.ToTable("UserActivityLogging", tb =>
                {
                    tb.HasTrigger("UserActivityLogging_dss_delete_trigger");
                    tb.HasTrigger("UserActivityLogging_dss_insert_trigger");
                    tb.HasTrigger("UserActivityLogging_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserActivityLoggingDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.UserActivityLogging_dss_tracking");

            entity.ToTable("UserActivityLogging_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserArea>(entity =>
        {
            entity.ToTable("User_Areas", tb =>
                {
                    tb.HasTrigger("User_Areas_dss_delete_trigger");
                    tb.HasTrigger("User_Areas_dss_insert_trigger");
                    tb.HasTrigger("User_Areas_dss_update_trigger");
                });

            entity.Property(e => e.UserAreaId).HasColumnName("User_Area_ID");
            entity.Property(e => e.AreaIdFk).HasColumnName("Area_ID_Fk");
            entity.Property(e => e.UserIdFk)
                .HasMaxLength(128)
                .HasColumnName("User_ID_FK");
        });

        modelBuilder.Entity<UserAreasDssTracking>(entity =>
        {
            entity.HasKey(e => e.UserAreaId).HasName("PK_DataSync.User_Areas_dss_tracking");

            entity.ToTable("User_Areas_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.UserAreaId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.UserAreaId)
                .ValueGeneratedNever()
                .HasColumnName("User_Area_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserAsset>(entity =>
        {
            entity.ToTable("User_Assets", tb =>
                {
                    tb.HasTrigger("User_Assets_dss_delete_trigger");
                    tb.HasTrigger("User_Assets_dss_insert_trigger");
                    tb.HasTrigger("User_Assets_dss_update_trigger");
                });

            entity.Property(e => e.UserAssetId).HasColumnName("User_Asset_ID");
            entity.Property(e => e.AssetIdFk).HasColumnName("Asset_ID_FK");
            entity.Property(e => e.UserIdFk)
                .HasMaxLength(128)
                .HasColumnName("User_ID_FK");
        });

        modelBuilder.Entity<UserAssetsDssTracking>(entity =>
        {
            entity.HasKey(e => e.UserAssetId).HasName("PK_DataSync.User_Assets_dss_tracking");

            entity.ToTable("User_Assets_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.UserAssetId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.UserAssetId)
                .ValueGeneratedNever()
                .HasColumnName("User_Asset_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserControlSystemIntegratorM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserCont__3214EC2773403FB2");

            entity.ToTable("UserControlSystemIntegratorM2M", tb =>
                {
                    tb.HasTrigger("UserControlSystemIntegratorM2M_dss_delete_trigger");
                    tb.HasTrigger("UserControlSystemIntegratorM2M_dss_insert_trigger");
                    tb.HasTrigger("UserControlSystemIntegratorM2M_dss_update_trigger");
                    tb.HasTrigger("trgAfterAssigningSIAccess");
                    tb.HasTrigger("trgAfterSIAccessUpdate");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CsiidFk).HasColumnName("CSIId_Fk");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");
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

        modelBuilder.Entity<UserControlSystemIntegratorM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.UserControlSystemIntegratorM2M_dss_tracking");

            entity.ToTable("UserControlSystemIntegratorM2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserCustomerM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User_Cus__3214EC2784A8D0D0");

            entity.ToTable("User_Customer_M2M", tb =>
                {
                    tb.HasTrigger("User_Customer_M2M_dss_delete_trigger");
                    tb.HasTrigger("User_Customer_M2M_dss_insert_trigger");
                    tb.HasTrigger("User_Customer_M2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<UserCustomerM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.User_Customer_M2M_dss_tracking");

            entity.ToTable("User_Customer_M2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserDistributorM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserDist__3214EC27B675F985");

            entity.ToTable("UserDistributorM2M", tb =>
                {
                    tb.HasTrigger("UserDistributorM2M_dss_delete_trigger");
                    tb.HasTrigger("UserDistributorM2M_dss_insert_trigger");
                    tb.HasTrigger("UserDistributorM2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<UserDistributorM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.UserDistributorM2M_dss_tracking");

            entity.ToTable("UserDistributorM2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserRefreshToken>(entity =>
        {
            entity.ToTable("UserRefreshToken", tb =>
                {
                    tb.HasTrigger("UserRefreshToken_dss_delete_trigger");
                    tb.HasTrigger("UserRefreshToken_dss_insert_trigger");
                    tb.HasTrigger("UserRefreshToken_dss_update_trigger");
                });

            entity.Property(e => e.RefreshToken).HasMaxLength(100);
            entity.Property(e => e.TokenExpiry).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<UserRefreshTokenDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.UserRefreshToken_dss_tracking");

            entity.ToTable("UserRefreshToken_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserRoleM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC07AD58981D");

            entity.ToTable("UserRoleM2M", tb =>
                {
                    tb.HasTrigger("UserRoleM2M_dss_delete_trigger");
                    tb.HasTrigger("UserRoleM2M_dss_insert_trigger");
                    tb.HasTrigger("UserRoleM2M_dss_update_trigger");
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

        modelBuilder.Entity<UserRoleM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.UserRoleM2M_dss_tracking");

            entity.ToTable("UserRoleM2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserSiteM2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User_Sit__3214EC27F317C486");

            entity.ToTable("User_Site_M2M", tb =>
                {
                    tb.HasTrigger("User_Site_M2M_dss_delete_trigger");
                    tb.HasTrigger("User_Site_M2M_dss_insert_trigger");
                    tb.HasTrigger("User_Site_M2M_dss_update_trigger");
                });

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

        modelBuilder.Entity<UserSiteM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.User_Site_M2M_dss_tracking");

            entity.ToTable("User_Site_M2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.ToTable("UserType", tb =>
                {
                    tb.HasTrigger("UserType_dss_delete_trigger");
                    tb.HasTrigger("UserType_dss_insert_trigger");
                    tb.HasTrigger("UserType_dss_update_trigger");
                });

            entity.Property(e => e.UserType1).HasColumnName("UserType");
        });

        modelBuilder.Entity<UserTypeDssTracking>(entity =>
        {
            entity.HasKey(e => e.UserTypeId).HasName("PK_DataSync.UserType_dss_tracking");

            entity.ToTable("UserType_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.UserTypeId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.UserTypeId).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<UserUserTypeM2m>(entity =>
        {
            entity.ToTable("User_UserType_M2M", tb =>
                {
                    tb.HasTrigger("User_UserType_M2M_dss_delete_trigger");
                    tb.HasTrigger("User_UserType_M2M_dss_insert_trigger");
                    tb.HasTrigger("User_UserType_M2M_dss_update_trigger");
                    tb.HasTrigger("trgAfterAssigningOtherAccessLevels");
                    tb.HasTrigger("trgAfterOtherAccessLevelsUpdate");
                });

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<UserUserTypeM2mDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.User_UserType_M2M_dss_tracking");

            entity.ToTable("User_UserType_M2M_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Userdatabase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userdata__3213E83FDD0AD47D");

            entity.ToTable("userdatabase", "dss");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Agentid).HasColumnName("agentid");
            entity.Property(e => e.ConnectionString).HasColumnName("connection_string");
            entity.Property(e => e.Database)
                .HasMaxLength(256)
                .HasColumnName("database");
            entity.Property(e => e.DbSchema).HasColumnName("db_schema");
            entity.Property(e => e.IsOnPremise).HasColumnName("is_on_premise");
            entity.Property(e => e.JobId).HasColumnName("jobId");
            entity.Property(e => e.LastSchemaUpdated)
                .HasColumnType("datetime")
                .HasColumnName("last_schema_updated");
            entity.Property(e => e.LastTombstonecleanup)
                .HasColumnType("datetime")
                .HasColumnName("last_tombstonecleanup");
            entity.Property(e => e.Region)
                .HasMaxLength(256)
                .HasColumnName("region");
            entity.Property(e => e.Server)
                .HasMaxLength(256)
                .HasColumnName("server");
            entity.Property(e => e.SqlazureInfo)
                .HasColumnType("xml")
                .HasColumnName("sqlazure_info");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");

            entity.HasOne(d => d.Subscription).WithMany(p => p.Userdatabases)
                .HasForeignKey(d => d.Subscriptionid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__userdatab__subsc");
        });

        modelBuilder.Entity<Variable>(entity =>
        {
            entity.HasKey(e => e.VId).HasName("PK__VARIABLE__B35D77AC840AB39D");

            entity.ToTable("VARIABLE", tb =>
                {
                    tb.HasTrigger("VARIABLE_dss_delete_trigger");
                    tb.HasTrigger("VARIABLE_dss_insert_trigger");
                    tb.HasTrigger("VARIABLE_dss_update_trigger");
                });

            entity.Property(e => e.VId).HasColumnName("V_ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

        modelBuilder.Entity<VariableDssTracking>(entity =>
        {
            entity.HasKey(e => e.VId).HasName("PK_DataSync.VARIABLE_dss_tracking");

            entity.ToTable("VARIABLE_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.VId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.VId)
                .ValueGeneratedNever()
                .HasColumnName("V_ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
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

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("WhatIfResults_dss_delete_trigger");
                    tb.HasTrigger("WhatIfResults_dss_insert_trigger");
                    tb.HasTrigger("WhatIfResults_dss_update_trigger");
                });

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

        modelBuilder.Entity<WhatIfResultsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.WhatIfResults_dss_tracking");

            entity.ToTable("WhatIfResults_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<WriteApiLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteApi__3214EC273F62371F");

            entity.ToTable("WriteApiLog", tb =>
                {
                    tb.HasTrigger("WriteApiLog_dss_delete_trigger");
                    tb.HasTrigger("WriteApiLog_dss_insert_trigger");
                    tb.HasTrigger("WriteApiLog_dss_update_trigger");
                });

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

        modelBuilder.Entity<WriteApiLogDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.WriteApiLog_dss_tracking");

            entity.ToTable("WriteApiLog_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<WriteApiTableConfiguration>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__WriteApi__A4AE64B8C16FCF58");

            entity.ToTable("WriteApiTableConfiguration", tb =>
                {
                    tb.HasTrigger("WriteApiTableConfiguration_dss_delete_trigger");
                    tb.HasTrigger("WriteApiTableConfiguration_dss_insert_trigger");
                    tb.HasTrigger("WriteApiTableConfiguration_dss_update_trigger");
                });

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

        modelBuilder.Entity<WriteApiTableConfigurationDssTracking>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_DataSync.WriteApiTableConfiguration_dss_tracking");

            entity.ToTable("WriteApiTableConfiguration_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.CustomerId }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<WriteBackLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteBac__3213E83F3A0D8B8D");

            entity.ToTable("WriteBack_Logs", tb =>
                {
                    tb.HasTrigger("WriteBack_Logs_dss_delete_trigger");
                    tb.HasTrigger("WriteBack_Logs_dss_insert_trigger");
                    tb.HasTrigger("WriteBack_Logs_dss_update_trigger");
                });

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

        modelBuilder.Entity<WriteBackLogsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.WriteBack_Logs_dss_tracking");

            entity.ToTable("WriteBack_Logs_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<WriteBackParam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteBac__3213E83F6B28E14F");

            entity.ToTable("WriteBack_Params", tb =>
                {
                    tb.HasTrigger("WriteBack_Params_dss_delete_trigger");
                    tb.HasTrigger("WriteBack_Params_dss_insert_trigger");
                    tb.HasTrigger("WriteBack_Params_dss_update_trigger");
                });

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

        modelBuilder.Entity<WriteBackParamsDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.WriteBack_Params_dss_tracking");

            entity.ToTable("WriteBack_Params_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<WriteBackPropertiesDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.WriteBack_Properties_dss_tracking");

            entity.ToTable("WriteBack_Properties_dss_tracking", "DataSync");

            entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id }, "local_update_peer_timestamp_index");

            entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<WriteBackProperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WriteBac__3213E83F87754C51");

            entity.ToTable("WriteBack_Properties", tb =>
                {
                    tb.HasTrigger("WriteBack_Properties_dss_delete_trigger");
                    tb.HasTrigger("WriteBack_Properties_dss_insert_trigger");
                    tb.HasTrigger("WriteBack_Properties_dss_update_trigger");
                });

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
