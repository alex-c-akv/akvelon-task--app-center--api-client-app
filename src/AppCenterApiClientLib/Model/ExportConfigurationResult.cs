/* 
 * App Center Client
 *
 * Microsoft Visual Studio App Center API
 *
 * OpenAPI spec version: v0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AppCenterApiClientLib.Client.SwaggerDateConverter;

namespace AppCenterApiClientLib.Model
{
    /// <summary>
    /// Export configuration result
    /// </summary>
    [DataContract]
        public partial class ExportConfigurationResult :  IEquatable<ExportConfigurationResult>, IValidatableObject
    {
        /// <summary>
        /// Target resource type of export configuration
        /// </summary>
        /// <value>Target resource type of export configuration</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ExportTypeEnum
        {
            /// <summary>
            /// Enum BlobStorage for value: BlobStorage
            /// </summary>
            [EnumMember(Value = "BlobStorage")]
            BlobStorage = 1,
            /// <summary>
            /// Enum AppInsights for value: AppInsights
            /// </summary>
            [EnumMember(Value = "AppInsights")]
            AppInsights = 2        }
        /// <summary>
        /// Target resource type of export configuration
        /// </summary>
        /// <value>Target resource type of export configuration</value>
        [DataMember(Name="export_type", EmitDefaultValue=false)]
        public ExportTypeEnum ExportType { get; set; }
        /// <summary>
        /// Defines ExportEntities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ExportEntitiesEnum
        {
            /// <summary>
            /// Enum Crashes for value: crashes
            /// </summary>
            [EnumMember(Value = "crashes")]
            Crashes = 1,
            /// <summary>
            /// Enum Errors for value: errors
            /// </summary>
            [EnumMember(Value = "errors")]
            Errors = 2,
            /// <summary>
            /// Enum Attachments for value: attachments
            /// </summary>
            [EnumMember(Value = "attachments")]
            Attachments = 3,
            /// <summary>
            /// Enum Nologs for value: no_logs
            /// </summary>
            [EnumMember(Value = "no_logs")]
            Nologs = 4        }
        /// <summary>
        /// Gets or Sets ExportEntities
        /// </summary>
        [DataMember(Name="export_entities", EmitDefaultValue=false)]
        public List<ExportEntitiesEnum> ExportEntities { get; set; }
        /// <summary>
        /// State of the export job
        /// </summary>
        /// <value>State of the export job</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
        {
            /// <summary>
            /// Enum Enabled for value: Enabled
            /// </summary>
            [EnumMember(Value = "Enabled")]
            Enabled = 1,
            /// <summary>
            /// Enum Disabled for value: Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled = 2,
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 3,
            /// <summary>
            /// Enum Deleted for value: Deleted
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted = 4,
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 5        }
        /// <summary>
        /// State of the export job
        /// </summary>
        /// <value>State of the export job</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportConfigurationResult" /> class.
        /// </summary>
        /// <param name="id">Export configuration id (required).</param>
        /// <param name="exportType">Target resource type of export configuration (required).</param>
        /// <param name="creationTime">Creation time in ISO 8601 format (required).</param>
        /// <param name="lastRunTime">Latest time in ISO 8601 format when export completed successfully.</param>
        /// <param name="exportEntities">exportEntities.</param>
        /// <param name="state">State of the export job (required).</param>
        /// <param name="stateInfo">Additional information about export configuration state.</param>
        /// <param name="resourceGroup">resource group for the storage account/App Insights resource.</param>
        /// <param name="resourceName">Storage accout or Appinsights resource name.</param>
        /// <param name="exportConfiguration">exportConfiguration.</param>
        public ExportConfigurationResult(string id = default(string), ExportTypeEnum exportType = default(ExportTypeEnum), string creationTime = default(string), string lastRunTime = default(string), List<ExportEntitiesEnum> exportEntities = default(List<ExportEntitiesEnum>), StateEnum state = default(StateEnum), string stateInfo = default(string), string resourceGroup = default(string), string resourceName = default(string), ExportConfigurationResultExportConfiguration exportConfiguration = default(ExportConfigurationResultExportConfiguration))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ExportConfigurationResult and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "exportType" is required (not null)
            if (exportType == null)
            {
                throw new InvalidDataException("exportType is a required property for ExportConfigurationResult and cannot be null");
            }
            else
            {
                this.ExportType = exportType;
            }
            // to ensure "creationTime" is required (not null)
            if (creationTime == null)
            {
                throw new InvalidDataException("creationTime is a required property for ExportConfigurationResult and cannot be null");
            }
            else
            {
                this.CreationTime = creationTime;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for ExportConfigurationResult and cannot be null");
            }
            else
            {
                this.State = state;
            }
            this.LastRunTime = lastRunTime;
            this.ExportEntities = exportEntities;
            this.StateInfo = stateInfo;
            this.ResourceGroup = resourceGroup;
            this.ResourceName = resourceName;
            this.ExportConfiguration = exportConfiguration;
        }
        
        /// <summary>
        /// Export configuration id
        /// </summary>
        /// <value>Export configuration id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Creation time in ISO 8601 format
        /// </summary>
        /// <value>Creation time in ISO 8601 format</value>
        [DataMember(Name="creation_time", EmitDefaultValue=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Latest time in ISO 8601 format when export completed successfully
        /// </summary>
        /// <value>Latest time in ISO 8601 format when export completed successfully</value>
        [DataMember(Name="last_run_time", EmitDefaultValue=false)]
        public string LastRunTime { get; set; }



        /// <summary>
        /// Additional information about export configuration state
        /// </summary>
        /// <value>Additional information about export configuration state</value>
        [DataMember(Name="state_info", EmitDefaultValue=false)]
        public string StateInfo { get; set; }

        /// <summary>
        /// resource group for the storage account/App Insights resource
        /// </summary>
        /// <value>resource group for the storage account/App Insights resource</value>
        [DataMember(Name="resource_group", EmitDefaultValue=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Storage accout or Appinsights resource name
        /// </summary>
        /// <value>Storage accout or Appinsights resource name</value>
        [DataMember(Name="resource_name", EmitDefaultValue=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or Sets ExportConfiguration
        /// </summary>
        [DataMember(Name="export_configuration", EmitDefaultValue=false)]
        public ExportConfigurationResultExportConfiguration ExportConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportConfigurationResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExportType: ").Append(ExportType).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastRunTime: ").Append(LastRunTime).Append("\n");
            sb.Append("  ExportEntities: ").Append(ExportEntities).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateInfo: ").Append(StateInfo).Append("\n");
            sb.Append("  ResourceGroup: ").Append(ResourceGroup).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  ExportConfiguration: ").Append(ExportConfiguration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportConfigurationResult);
        }

        /// <summary>
        /// Returns true if ExportConfigurationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportConfigurationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportConfigurationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExportType == input.ExportType ||
                    (this.ExportType != null &&
                    this.ExportType.Equals(input.ExportType))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.LastRunTime == input.LastRunTime ||
                    (this.LastRunTime != null &&
                    this.LastRunTime.Equals(input.LastRunTime))
                ) && 
                (
                    this.ExportEntities == input.ExportEntities ||
                    this.ExportEntities != null &&
                    input.ExportEntities != null &&
                    this.ExportEntities.SequenceEqual(input.ExportEntities)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StateInfo == input.StateInfo ||
                    (this.StateInfo != null &&
                    this.StateInfo.Equals(input.StateInfo))
                ) && 
                (
                    this.ResourceGroup == input.ResourceGroup ||
                    (this.ResourceGroup != null &&
                    this.ResourceGroup.Equals(input.ResourceGroup))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.ExportConfiguration == input.ExportConfiguration ||
                    (this.ExportConfiguration != null &&
                    this.ExportConfiguration.Equals(input.ExportConfiguration))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExportType != null)
                    hashCode = hashCode * 59 + this.ExportType.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastRunTime != null)
                    hashCode = hashCode * 59 + this.LastRunTime.GetHashCode();
                if (this.ExportEntities != null)
                    hashCode = hashCode * 59 + this.ExportEntities.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateInfo != null)
                    hashCode = hashCode * 59 + this.StateInfo.GetHashCode();
                if (this.ResourceGroup != null)
                    hashCode = hashCode * 59 + this.ResourceGroup.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ExportConfiguration != null)
                    hashCode = hashCode * 59 + this.ExportConfiguration.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
