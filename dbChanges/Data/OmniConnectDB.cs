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

    public virtual DbSet<ApxHealthAlert> ApxHealthAlerts { get; set; }

    public virtual DbSet<ApxHealthAlertTrend> ApxHealthAlertTrends { get; set; }

    public virtual DbSet<ApxHealthParameter> ApxHealthParameters { get; set; }

    public virtual DbSet<ApxHealthParameterValue> ApxHealthParameterValues { get; set; }

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

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<CalculatedTag> CalculatedTags { get; set; }

    public virtual DbSet<ConditionalCalculation> ConditionalCalculations { get; set; }

    public virtual DbSet<CurveDatum> CurveData { get; set; }

    public virtual DbSet<CurveHeader> CurveHeaders { get; set; }

    public virtual DbSet<DataAlarmStatesConfig> DataAlarmStatesConfigs { get; set; }

    public virtual DbSet<DesignDatum> DesignData { get; set; }

    public virtual DbSet<DesignParameter> DesignParameters { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<KpieIpTagsDatum> KpieIpTagsData { get; set; }

    public virtual DbSet<KpieIpTagsParameter> KpieIpTagsParameters { get; set; }

    public virtual DbSet<LogDetail> LogDetails { get; set; }

    public virtual DbSet<LogEvent> LogEvents { get; set; }

    public virtual DbSet<OutputTagDatum> OutputTagData { get; set; }

    public virtual DbSet<OutputTagParameter> OutputTagParameters { get; set; }

    public virtual DbSet<PipeLineTag> PipeLineTags { get; set; }

    public virtual DbSet<RealRawPoint> RealRawPoints { get; set; }

    public virtual DbSet<SiteEventsM2m> SiteEventsM2ms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=oc-modernization-blue.database.windows.net; Database= ocm-staging; User Id=octopus; Password=avanceon@786;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApxHealthAlert>(entity =>
        {
            entity.ToTable("APxHealthAlerts");

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

        modelBuilder.Entity<ApxHealthAlertTrend>(entity =>
        {
            entity.ToTable("APxHealthAlertTrends");

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Jsondata).HasColumnName("JSONData");
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterIdFK");
        });

        modelBuilder.Entity<ApxHealthParameter>(entity =>
        {
            entity.ToTable("APxHealthParameters", tb =>
                {
                    tb.HasTrigger("APxHealthParameters_dss_delete_trigger");
                    tb.HasTrigger("APxHealthParameters_dss_insert_trigger");
                    tb.HasTrigger("APxHealthParameters_dss_update_trigger");
                });

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
            entity.Property(e => e.TextType).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxHealthParameterValue>(entity =>
        {
            entity.ToTable("APxHealthParameterValues", tb =>
                {
                    tb.HasTrigger("APxHealthParameterValues_dss_delete_trigger");
                    tb.HasTrigger("APxHealthParameterValues_dss_insert_trigger");
                    tb.HasTrigger("APxHealthParameterValues_dss_update_trigger");
                });

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.ConstValue).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterIdFK");
            entity.Property(e => e.TagDescription).HasMaxLength(250);
            entity.Property(e => e.TagType).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxHealthTagGroup>(entity =>
        {
            entity.ToTable("APxHealthTagGroups", tb =>
                {
                    tb.HasTrigger("APxHealthTagGroups_dss_delete_trigger");
                    tb.HasTrigger("APxHealthTagGroups_dss_insert_trigger");
                    tb.HasTrigger("APxHealthTagGroups_dss_update_trigger");
                });

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
            entity.ToTable("APxHealthTagGroupStatuses", tb =>
                {
                    tb.HasTrigger("APxHealthTagGroupStatuses_dss_delete_trigger");
                    tb.HasTrigger("APxHealthTagGroupStatuses_dss_insert_trigger");
                    tb.HasTrigger("APxHealthTagGroupStatuses_dss_update_trigger");
                });

            entity.Property(e => e.ApxHealthGroupIdFk).HasColumnName("APxHealthGroupIdFK");
            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.OperatingTime).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(20);
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
            entity.ToTable("APxParameters", tb =>
                {
                    tb.HasTrigger("APxParameters_dss_delete_trigger");
                    tb.HasTrigger("APxParameters_dss_insert_trigger");
                    tb.HasTrigger("APxParameters_dss_update_trigger");
                });

            entity.Property(e => e.ParameterCategoryIdFk).HasColumnName("ParameterCategoryId_FK");
            entity.Property(e => e.ParameterName).HasMaxLength(250);
        });

        modelBuilder.Entity<ApxParameterCategory>(entity =>
        {
            entity.ToTable("APxParameterCategories", tb =>
                {
                    tb.HasTrigger("APxParameterCategories_dss_delete_trigger");
                    tb.HasTrigger("APxParameterCategories_dss_insert_trigger");
                    tb.HasTrigger("APxParameterCategories_dss_update_trigger");
                });

            entity.Property(e => e.AssetCategoryIdFk).HasColumnName("AssetCategoryId_FK");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.InsightType).HasMaxLength(250);
            entity.Property(e => e.Section).HasMaxLength(250);
            entity.Property(e => e.StepName).HasMaxLength(250);
        });

        modelBuilder.Entity<ApxParameterOutputMapping>(entity =>
        {
            entity.ToTable("APxParameterOutputMapping", tb =>
                {
                    tb.HasTrigger("APxParameterOutputMapping_dss_delete_trigger");
                    tb.HasTrigger("APxParameterOutputMapping_dss_insert_trigger");
                    tb.HasTrigger("APxParameterOutputMapping_dss_update_trigger");
                });

            entity.Property(e => e.OutputTagParameterIdFk).HasColumnName("OutputTagParameterId_FK");
            entity.Property(e => e.ParameterIdFk).HasColumnName("ParameterId_FK");
        });

        modelBuilder.Entity<ApxStepsHeader>(entity =>
        {
            entity.ToTable("APxStepsHeaders", tb =>
                {
                    tb.HasTrigger("APxStepsHeaders_dss_delete_trigger");
                    tb.HasTrigger("APxStepsHeaders_dss_insert_trigger");
                    tb.HasTrigger("APxStepsHeaders_dss_update_trigger");
                });

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
            entity.ToTable("APxTemplateSteps", tb =>
                {
                    tb.HasTrigger("APxTemplateSteps_dss_delete_trigger");
                    tb.HasTrigger("APxTemplateSteps_dss_insert_trigger");
                    tb.HasTrigger("APxTemplateSteps_dss_update_trigger");
                });

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
            entity.ToTable("APxTwinModel", tb =>
                {
                    tb.HasTrigger("APxTwinModel_dss_delete_trigger");
                    tb.HasTrigger("APxTwinModel_dss_insert_trigger");
                    tb.HasTrigger("APxTwinModel_dss_update_trigger");
                });

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetIdFK");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsModelActivating).HasDefaultValueSql("((0))");
            entity.Property(e => e.ResultJson).HasColumnName("ResultJSON");
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApxWhatIfInput>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WhatIf_InputData");

            entity.ToTable("APxWhatIf_Input", tb =>
                {
                    tb.HasTrigger("APxWhatIf_Input_dss_delete_trigger");
                    tb.HasTrigger("APxWhatIf_Input_dss_insert_trigger");
                    tb.HasTrigger("APxWhatIf_Input_dss_update_trigger");
                });

            entity.Property(e => e.AssetIdFk).HasColumnName("AssetId_Fk");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Section).HasMaxLength(100);
            entity.Property(e => e.WhatIfInputData).HasColumnName("WhatIf_InputData");
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Assets_dss_delete_trigger");
                    tb.HasTrigger("Assets_dss_insert_trigger");
                    tb.HasTrigger("Assets_dss_update_trigger");
                });

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
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsApxHealthActivated)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsAPxHealthActivated");
            entity.Property(e => e.IsApxHealthActivating)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsAPxHealthActivating");
            entity.Property(e => e.IsKpiactivated)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsKPIActivated");
            entity.Property(e => e.IsKpiactivating)
                .HasDefaultValueSql("((0))")
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

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("AuditLogs_dss_delete_trigger");
                    tb.HasTrigger("AuditLogs_dss_insert_trigger");
                    tb.HasTrigger("AuditLogs_dss_update_trigger");
                });

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

        modelBuilder.Entity<CalculatedTag>(entity =>
        {
            entity.HasKey(e => e.CTagId);

            entity.ToTable("Calculated_Tags", tb =>
                {
                    tb.HasTrigger("Calculated_Tags_dss_delete_trigger");
                    tb.HasTrigger("Calculated_Tags_dss_insert_trigger");
                    tb.HasTrigger("Calculated_Tags_dss_update_trigger");
                });

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

        modelBuilder.Entity<ConditionalCalculation>(entity =>
        {
            entity.ToTable("Conditional_Calculation", tb =>
                {
                    tb.HasTrigger("Conditional_Calculation_dss_delete_trigger");
                    tb.HasTrigger("Conditional_Calculation_dss_insert_trigger");
                    tb.HasTrigger("Conditional_Calculation_dss_update_trigger");
                });

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

        modelBuilder.Entity<CurveDatum>(entity =>
        {
            entity.HasKey(e => e.CurveId);

            entity.ToTable("Curve_Data", tb =>
                {
                    tb.HasTrigger("Curve_Data_dss_delete_trigger");
                    tb.HasTrigger("Curve_Data_dss_insert_trigger");
                    tb.HasTrigger("Curve_Data_dss_update_trigger");
                });

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
            entity.ToTable("Curve_Headers", tb =>
                {
                    tb.HasTrigger("Curve_Headers_dss_delete_trigger");
                    tb.HasTrigger("Curve_Headers_dss_insert_trigger");
                    tb.HasTrigger("Curve_Headers_dss_update_trigger");
                });

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

        modelBuilder.Entity<DataAlarmStatesConfig>(entity =>
        {
            entity.HasKey(e => e.AstId).HasName("PK__dATA_ALA__F974947821766E91");

            entity.ToTable("DATA_ALARM_STATES_CONFIG", tb =>
                {
                    tb.HasTrigger("DATA_ALARM_STATES_CONFIG_dss_delete_trigger");
                    tb.HasTrigger("DATA_ALARM_STATES_CONFIG_dss_insert_trigger");
                    tb.HasTrigger("DATA_ALARM_STATES_CONFIG_dss_update_trigger");
                });

            entity.HasIndex(e => e.AsId, "nci_wi_DATA_ALARM_STATES_CONFIG_94CE207B337340A1D8A7B8E6FC30E755");

            entity.Property(e => e.AstId).HasColumnName("AST_ID");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AlarmDuration).HasDefaultValueSql("((24))");
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

        modelBuilder.Entity<DesignDatum>(entity =>
        {
            entity.HasKey(e => e.DesignDataId);

            entity.ToTable("Design_Data", tb =>
                {
                    tb.HasTrigger("Design_Data_dss_delete_trigger");
                    tb.HasTrigger("Design_Data_dss_insert_trigger");
                    tb.HasTrigger("Design_Data_dss_update_trigger");
                });

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
            entity.ToTable("Design_Parameters", tb =>
                {
                    tb.HasTrigger("Design_Parameters_dss_delete_trigger");
                    tb.HasTrigger("Design_Parameters_dss_insert_trigger");
                    tb.HasTrigger("Design_Parameters_dss_update_trigger");
                });

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
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Devices_dss_delete_trigger");
                    tb.HasTrigger("Devices_dss_insert_trigger");
                    tb.HasTrigger("Devices_dss_update_trigger");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CertificationExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DevicePlatform).HasColumnName("Device_Platform");
            entity.Property(e => e.DeviceTypeIdFk).HasColumnName("DeviceTypeID_Fk");
            entity.Property(e => e.FormatIdfk).HasColumnName("FormatIDFk");
            entity.Property(e => e.Guid).HasColumnName("GUID");
            entity.Property(e => e.IoTedgeConnectionString).HasColumnName("IoTEdge_ConnectionString");
            entity.Property(e => e.IotconnectionString).HasColumnName("IOTConnectionString");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("Event_Id");
            entity.Property(e => e.EcomponentId).HasColumnName("EComponent_ID");
            entity.Property(e => e.EventName).HasMaxLength(200);
        });

        modelBuilder.Entity<KpieIpTagsDatum>(entity =>
        {
            entity.HasKey(e => e.TagDataId).HasName("PK_KPIE_Tags_Data");

            entity.ToTable("KPIE_IP_Tags_Data", tb =>
                {
                    tb.HasTrigger("KPIE_IP_Tags_Data_dss_delete_trigger");
                    tb.HasTrigger("KPIE_IP_Tags_Data_dss_insert_trigger");
                    tb.HasTrigger("KPIE_IP_Tags_Data_dss_update_trigger");
                });

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

            entity.ToTable("KPIE_IP_Tags_Parameters", tb =>
                {
                    tb.HasTrigger("KPIE_IP_Tags_Parameters_dss_delete_trigger");
                    tb.HasTrigger("KPIE_IP_Tags_Parameters_dss_insert_trigger");
                    tb.HasTrigger("KPIE_IP_Tags_Parameters_dss_update_trigger");
                });

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
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("LogDetails_dss_delete_trigger");
                    tb.HasTrigger("LogDetails_dss_insert_trigger");
                    tb.HasTrigger("LogDetails_dss_update_trigger");
                });

            entity.Property(e => e.LogIdFk).HasColumnName("LogId_FK");
        });

        modelBuilder.Entity<LogEvent>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("LogEvents_dss_delete_trigger");
                    tb.HasTrigger("LogEvents_dss_insert_trigger");
                    tb.HasTrigger("LogEvents_dss_update_trigger");
                });

            entity.Property(e => e.EventDescription).HasMaxLength(200);
            entity.Property(e => e.EventName).HasMaxLength(100);
        });

        modelBuilder.Entity<OutputTagDatum>(entity =>
        {
            entity.HasKey(e => e.OutputTagId);

            entity.ToTable("Output_Tag_Data", tb =>
                {
                    tb.HasTrigger("Output_Tag_Data_dss_delete_trigger");
                    tb.HasTrigger("Output_Tag_Data_dss_insert_trigger");
                    tb.HasTrigger("Output_Tag_Data_dss_update_trigger");
                });

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

            entity.ToTable("Output_Tag_Parameters", tb =>
                {
                    tb.HasTrigger("Output_Tag_Parameters_dss_delete_trigger");
                    tb.HasTrigger("Output_Tag_Parameters_dss_insert_trigger");
                    tb.HasTrigger("Output_Tag_Parameters_dss_update_trigger");
                });

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

        modelBuilder.Entity<PipeLineTag>(entity =>
        {
            entity.HasKey(e => e.PltagsId).HasName("PK__PipeLine__79D01BEF2D10AC27");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("PipeLineTags_dss_delete_trigger");
                    tb.HasTrigger("PipeLineTags_dss_insert_trigger");
                    tb.HasTrigger("PipeLineTags_dss_update_trigger");
                });

            entity.Property(e => e.PltagsId).HasColumnName("PLtagsId");
            entity.Property(e => e.DataTypeIdFk).HasColumnName("DataTypeID_FK");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<RealRawPoint>(entity =>
        {
            entity.HasKey(e => e.RealTagId);

            entity.ToTable("Real_Raw_Points", tb =>
                {
                    tb.HasTrigger("Real_Raw_Points_dss_delete_trigger");
                    tb.HasTrigger("Real_Raw_Points_dss_insert_trigger");
                    tb.HasTrigger("Real_Raw_Points_dss_update_trigger");
                });

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

            entity.HasOne(d => d.Event).WithMany(p => p.SiteEventsM2ms)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_SITE_Events_M2M.Event_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
