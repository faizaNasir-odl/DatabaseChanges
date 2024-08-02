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

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<CalculatedTag> CalculatedTags { get; set; }

    public virtual DbSet<ConditionalCalculation> ConditionalCalculations { get; set; }

    public virtual DbSet<CurveDatum> CurveData { get; set; }

    public virtual DbSet<CurveHeader> CurveHeaders { get; set; }

    public virtual DbSet<DataAlarmStatesConfig> DataAlarmStatesConfigs { get; set; }

    public virtual DbSet<DesignDatum> DesignData { get; set; }

    public virtual DbSet<DesignParameter> DesignParameters { get; set; }

    public virtual DbSet<KpieIpTagsDatum> KpieIpTagsData { get; set; }

    public virtual DbSet<KpieIpTagsParameter> KpieIpTagsParameters { get; set; }

    public virtual DbSet<OutputTagDatum> OutputTagData { get; set; }

    public virtual DbSet<OutputTagParameter> OutputTagParameters { get; set; }

    public virtual DbSet<PipeLineTag> PipeLineTags { get; set; }

    public virtual DbSet<RealRawPoint> RealRawPoints { get; set; }

    public virtual DbSet<TriggeredDataAlarmAction> TriggeredDataAlarmActions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= oc-modernization.database.windows.net; Database= ocm-staging; User Id=octopus; Password=avanceon@786;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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

        modelBuilder.Entity<PipeLineTag>(entity =>
        {
            entity.HasKey(e => e.PltagsId).HasName("PK__PipeLine__79D01BEF2D10AC27");

            entity.Property(e => e.PltagsId).HasColumnName("PLtagsId");
            entity.Property(e => e.DataTypeIdFk).HasColumnName("DataTypeID_FK");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
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

            entity.HasOne(d => d.AssetIdFkNavigation).WithMany(p => p.RealRawPoints)
                .HasForeignKey(d => d.AssetIdFk)
                .HasConstraintName("FK_Real_Raw_Points_Assets");
        });

        modelBuilder.Entity<TriggeredDataAlarmAction>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("TRIGGERED_PK__DATA_ALA__5D853E1A0C706C36");

            entity.ToTable("TRIGGERED_DATA_ALARM_ACTION", tb => tb.HasTrigger("InsertTriggeredAlarmDataUsingStoredProc"));

            entity.Property(e => e.DatId).HasColumnName("DAT_ID");
            entity.Property(e => e.ActionEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActionPerformedBy).HasMaxLength(128);
            entity.Property(e => e.ActionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AsId).HasColumnName("AS_Id");
            entity.Property(e => e.AstId).HasColumnName("AST_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrentValue)
                .HasMaxLength(100)
                .HasColumnName("Current_Value");
            entity.Property(e => e.DataAlarmActionGuid)
                .HasMaxLength(128)
                .HasColumnName("DataAlarmActionGUID");
            entity.Property(e => e.DataAlarmId).HasColumnName("DataAlarm_ID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ReadingTime)
                .HasColumnType("datetime")
                .HasColumnName("Reading_Time");
            entity.Property(e => e.SetPoint).HasMaxLength(100);
            entity.Property(e => e.StateId).HasColumnName("State_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
