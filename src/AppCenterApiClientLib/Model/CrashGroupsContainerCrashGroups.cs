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
    /// CrashGroupsContainerCrashGroups
    /// </summary>
    [DataContract]
        public partial class CrashGroupsContainerCrashGroups :  IEquatable<CrashGroupsContainerCrashGroups>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,
            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,
            /// <summary>
            /// Enum Ignored for value: ignored
            /// </summary>
            [EnumMember(Value = "ignored")]
            Ignored = 3        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashGroupsContainerCrashGroups" /> class.
        /// </summary>
        /// <param name="crashGroupId">crashGroupId (required).</param>
        /// <param name="newCrashGroupId">newCrashGroupId (required).</param>
        /// <param name="displayId">displayId (required).</param>
        /// <param name="appVersion">appVersion (required).</param>
        /// <param name="build">build (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="count">count (required).</param>
        /// <param name="impactedUsers">impactedUsers.</param>
        /// <param name="firstOccurrence">firstOccurrence (required).</param>
        /// <param name="lastOccurrence">lastOccurrence (required).</param>
        /// <param name="exception">exception.</param>
        /// <param name="crashReason">crashReason (required).</param>
        /// <param name="reasonFrame">reasonFrame.</param>
        /// <param name="fatal">Crash or handled exception (required).</param>
        /// <param name="annotation">annotation (required).</param>
        public CrashGroupsContainerCrashGroups(string crashGroupId = default(string), string newCrashGroupId = default(string), string displayId = default(string), string appVersion = default(string), string build = default(string), StatusEnum status = default(StatusEnum), int? count = default(int?), int? impactedUsers = default(int?), DateTime? firstOccurrence = default(DateTime?), DateTime? lastOccurrence = default(DateTime?), string exception = default(string), string crashReason = default(string), CrashGroupsContainerReasonFrame reasonFrame = default(CrashGroupsContainerReasonFrame), bool? fatal = default(bool?), string annotation = default(string))
        {
            // to ensure "crashGroupId" is required (not null)
            if (crashGroupId == null)
            {
                throw new InvalidDataException("crashGroupId is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.CrashGroupId = crashGroupId;
            }
            // to ensure "newCrashGroupId" is required (not null)
            if (newCrashGroupId == null)
            {
                throw new InvalidDataException("newCrashGroupId is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.NewCrashGroupId = newCrashGroupId;
            }
            // to ensure "displayId" is required (not null)
            if (displayId == null)
            {
                throw new InvalidDataException("displayId is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.DisplayId = displayId;
            }
            // to ensure "appVersion" is required (not null)
            if (appVersion == null)
            {
                throw new InvalidDataException("appVersion is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.AppVersion = appVersion;
            }
            // to ensure "build" is required (not null)
            if (build == null)
            {
                throw new InvalidDataException("build is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.Build = build;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "count" is required (not null)
            if (count == null)
            {
                throw new InvalidDataException("count is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.Count = count;
            }
            // to ensure "firstOccurrence" is required (not null)
            if (firstOccurrence == null)
            {
                throw new InvalidDataException("firstOccurrence is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.FirstOccurrence = firstOccurrence;
            }
            // to ensure "lastOccurrence" is required (not null)
            if (lastOccurrence == null)
            {
                throw new InvalidDataException("lastOccurrence is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.LastOccurrence = lastOccurrence;
            }
            // to ensure "crashReason" is required (not null)
            if (crashReason == null)
            {
                throw new InvalidDataException("crashReason is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.CrashReason = crashReason;
            }
            // to ensure "fatal" is required (not null)
            if (fatal == null)
            {
                throw new InvalidDataException("fatal is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.Fatal = fatal;
            }
            // to ensure "annotation" is required (not null)
            if (annotation == null)
            {
                throw new InvalidDataException("annotation is a required property for CrashGroupsContainerCrashGroups and cannot be null");
            }
            else
            {
                this.Annotation = annotation;
            }
            this.ImpactedUsers = impactedUsers;
            this.Exception = exception;
            this.ReasonFrame = reasonFrame;
        }
        
        /// <summary>
        /// Gets or Sets CrashGroupId
        /// </summary>
        [DataMember(Name="crash_group_id", EmitDefaultValue=false)]
        public string CrashGroupId { get; set; }

        /// <summary>
        /// Gets or Sets NewCrashGroupId
        /// </summary>
        [DataMember(Name="new_crash_group_id", EmitDefaultValue=false)]
        public string NewCrashGroupId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayId
        /// </summary>
        [DataMember(Name="display_id", EmitDefaultValue=false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name="app_version", EmitDefaultValue=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public string Build { get; set; }


        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets ImpactedUsers
        /// </summary>
        [DataMember(Name="impacted_users", EmitDefaultValue=false)]
        public int? ImpactedUsers { get; set; }

        /// <summary>
        /// Gets or Sets FirstOccurrence
        /// </summary>
        [DataMember(Name="first_occurrence", EmitDefaultValue=false)]
        public DateTime? FirstOccurrence { get; set; }

        /// <summary>
        /// Gets or Sets LastOccurrence
        /// </summary>
        [DataMember(Name="last_occurrence", EmitDefaultValue=false)]
        public DateTime? LastOccurrence { get; set; }

        /// <summary>
        /// Gets or Sets AppCenterException
        /// </summary>
        [DataMember(Name="exception", EmitDefaultValue=false)]
        public string Exception { get; set; }

        /// <summary>
        /// Gets or Sets CrashReason
        /// </summary>
        [DataMember(Name="crash_reason", EmitDefaultValue=false)]
        public string CrashReason { get; set; }

        /// <summary>
        /// Gets or Sets ReasonFrame
        /// </summary>
        [DataMember(Name="reason_frame", EmitDefaultValue=false)]
        public CrashGroupsContainerReasonFrame ReasonFrame { get; set; }

        /// <summary>
        /// Crash or handled exception
        /// </summary>
        /// <value>Crash or handled exception</value>
        [DataMember(Name="fatal", EmitDefaultValue=false)]
        public bool? Fatal { get; set; }

        /// <summary>
        /// Gets or Sets Annotation
        /// </summary>
        [DataMember(Name="annotation", EmitDefaultValue=false)]
        public string Annotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashGroupsContainerCrashGroups {\n");
            sb.Append("  CrashGroupId: ").Append(CrashGroupId).Append("\n");
            sb.Append("  NewCrashGroupId: ").Append(NewCrashGroupId).Append("\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  ImpactedUsers: ").Append(ImpactedUsers).Append("\n");
            sb.Append("  FirstOccurrence: ").Append(FirstOccurrence).Append("\n");
            sb.Append("  LastOccurrence: ").Append(LastOccurrence).Append("\n");
            sb.Append("  AppCenterException: ").Append(Exception).Append("\n");
            sb.Append("  CrashReason: ").Append(CrashReason).Append("\n");
            sb.Append("  ReasonFrame: ").Append(ReasonFrame).Append("\n");
            sb.Append("  Fatal: ").Append(Fatal).Append("\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
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
            return this.Equals(input as CrashGroupsContainerCrashGroups);
        }

        /// <summary>
        /// Returns true if CrashGroupsContainerCrashGroups instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashGroupsContainerCrashGroups to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashGroupsContainerCrashGroups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CrashGroupId == input.CrashGroupId ||
                    (this.CrashGroupId != null &&
                    this.CrashGroupId.Equals(input.CrashGroupId))
                ) && 
                (
                    this.NewCrashGroupId == input.NewCrashGroupId ||
                    (this.NewCrashGroupId != null &&
                    this.NewCrashGroupId.Equals(input.NewCrashGroupId))
                ) && 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.ImpactedUsers == input.ImpactedUsers ||
                    (this.ImpactedUsers != null &&
                    this.ImpactedUsers.Equals(input.ImpactedUsers))
                ) && 
                (
                    this.FirstOccurrence == input.FirstOccurrence ||
                    (this.FirstOccurrence != null &&
                    this.FirstOccurrence.Equals(input.FirstOccurrence))
                ) && 
                (
                    this.LastOccurrence == input.LastOccurrence ||
                    (this.LastOccurrence != null &&
                    this.LastOccurrence.Equals(input.LastOccurrence))
                ) && 
                (
                    this.Exception == input.Exception ||
                    (this.Exception != null &&
                    this.Exception.Equals(input.Exception))
                ) && 
                (
                    this.CrashReason == input.CrashReason ||
                    (this.CrashReason != null &&
                    this.CrashReason.Equals(input.CrashReason))
                ) && 
                (
                    this.ReasonFrame == input.ReasonFrame ||
                    (this.ReasonFrame != null &&
                    this.ReasonFrame.Equals(input.ReasonFrame))
                ) && 
                (
                    this.Fatal == input.Fatal ||
                    (this.Fatal != null &&
                    this.Fatal.Equals(input.Fatal))
                ) && 
                (
                    this.Annotation == input.Annotation ||
                    (this.Annotation != null &&
                    this.Annotation.Equals(input.Annotation))
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
                if (this.CrashGroupId != null)
                    hashCode = hashCode * 59 + this.CrashGroupId.GetHashCode();
                if (this.NewCrashGroupId != null)
                    hashCode = hashCode * 59 + this.NewCrashGroupId.GetHashCode();
                if (this.DisplayId != null)
                    hashCode = hashCode * 59 + this.DisplayId.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ImpactedUsers != null)
                    hashCode = hashCode * 59 + this.ImpactedUsers.GetHashCode();
                if (this.FirstOccurrence != null)
                    hashCode = hashCode * 59 + this.FirstOccurrence.GetHashCode();
                if (this.LastOccurrence != null)
                    hashCode = hashCode * 59 + this.LastOccurrence.GetHashCode();
                if (this.Exception != null)
                    hashCode = hashCode * 59 + this.Exception.GetHashCode();
                if (this.CrashReason != null)
                    hashCode = hashCode * 59 + this.CrashReason.GetHashCode();
                if (this.ReasonFrame != null)
                    hashCode = hashCode * 59 + this.ReasonFrame.GetHashCode();
                if (this.Fatal != null)
                    hashCode = hashCode * 59 + this.Fatal.GetHashCode();
                if (this.Annotation != null)
                    hashCode = hashCode * 59 + this.Annotation.GetHashCode();
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
