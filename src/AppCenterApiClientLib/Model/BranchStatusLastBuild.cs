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
    /// BranchStatusLastBuild
    /// </summary>
    [DataContract]
        public partial class BranchStatusLastBuild :  IEquatable<BranchStatusLastBuild>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchStatusLastBuild" /> class.
        /// </summary>
        /// <param name="id">The build ID (required).</param>
        /// <param name="buildNumber">The build number (required).</param>
        /// <param name="queueTime">The time the build was queued (required).</param>
        /// <param name="startTime">The time the build was started.</param>
        /// <param name="finishTime">The time the build was finished.</param>
        /// <param name="lastChangedDate">The time the build status was last changed.</param>
        /// <param name="status">The build status (required).</param>
        /// <param name="result">The build result (required).</param>
        /// <param name="sourceBranch">The source branch name (required).</param>
        /// <param name="sourceVersion">The source SHA (required).</param>
        public BranchStatusLastBuild(int? id = default(int?), string buildNumber = default(string), string queueTime = default(string), string startTime = default(string), string finishTime = default(string), string lastChangedDate = default(string), string status = default(string), string result = default(string), string sourceBranch = default(string), string sourceVersion = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BranchStatusLastBuild and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "buildNumber" is required (not null)
            if (buildNumber == null)
            {
                throw new InvalidDataException("buildNumber is a required property for BranchStatusLastBuild and cannot be null");
            }
            else
            {
                this.BuildNumber = buildNumber;
            }
            // to ensure "queueTime" is required (not null)
            if (queueTime == null)
            {
                throw new InvalidDataException("queueTime is a required property for BranchStatusLastBuild and cannot be null");
            }
            else
            {
                this.QueueTime = queueTime;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for BranchStatusLastBuild and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "result" is required (not null)
            if (result == null)
            {
                throw new InvalidDataException("result is a required property for BranchStatusLastBuild and cannot be null");
            }
            else
            {
                this.Result = result;
            }
            // to ensure "sourceBranch" is required (not null)
            if (sourceBranch == null)
            {
                throw new InvalidDataException("sourceBranch is a required property for BranchStatusLastBuild and cannot be null");
            }
            else
            {
                this.SourceBranch = sourceBranch;
            }
            // to ensure "sourceVersion" is required (not null)
            if (sourceVersion == null)
            {
                throw new InvalidDataException("sourceVersion is a required property for BranchStatusLastBuild and cannot be null");
            }
            else
            {
                this.SourceVersion = sourceVersion;
            }
            this.StartTime = startTime;
            this.FinishTime = finishTime;
            this.LastChangedDate = lastChangedDate;
        }
        
        /// <summary>
        /// The build ID
        /// </summary>
        /// <value>The build ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The build number
        /// </summary>
        /// <value>The build number</value>
        [DataMember(Name="buildNumber", EmitDefaultValue=false)]
        public string BuildNumber { get; set; }

        /// <summary>
        /// The time the build was queued
        /// </summary>
        /// <value>The time the build was queued</value>
        [DataMember(Name="queueTime", EmitDefaultValue=false)]
        public string QueueTime { get; set; }

        /// <summary>
        /// The time the build was started
        /// </summary>
        /// <value>The time the build was started</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The time the build was finished
        /// </summary>
        /// <value>The time the build was finished</value>
        [DataMember(Name="finishTime", EmitDefaultValue=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// The time the build status was last changed
        /// </summary>
        /// <value>The time the build status was last changed</value>
        [DataMember(Name="lastChangedDate", EmitDefaultValue=false)]
        public string LastChangedDate { get; set; }

        /// <summary>
        /// The build status
        /// </summary>
        /// <value>The build status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The build result
        /// </summary>
        /// <value>The build result</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// The source branch name
        /// </summary>
        /// <value>The source branch name</value>
        [DataMember(Name="sourceBranch", EmitDefaultValue=false)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// The source SHA
        /// </summary>
        /// <value>The source SHA</value>
        [DataMember(Name="sourceVersion", EmitDefaultValue=false)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchStatusLastBuild {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  QueueTime: ").Append(QueueTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  FinishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  LastChangedDate: ").Append(LastChangedDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  SourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  SourceVersion: ").Append(SourceVersion).Append("\n");
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
            return this.Equals(input as BranchStatusLastBuild);
        }

        /// <summary>
        /// Returns true if BranchStatusLastBuild instances are equal
        /// </summary>
        /// <param name="input">Instance of BranchStatusLastBuild to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BranchStatusLastBuild input)
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
                    this.BuildNumber == input.BuildNumber ||
                    (this.BuildNumber != null &&
                    this.BuildNumber.Equals(input.BuildNumber))
                ) && 
                (
                    this.QueueTime == input.QueueTime ||
                    (this.QueueTime != null &&
                    this.QueueTime.Equals(input.QueueTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.FinishTime == input.FinishTime ||
                    (this.FinishTime != null &&
                    this.FinishTime.Equals(input.FinishTime))
                ) && 
                (
                    this.LastChangedDate == input.LastChangedDate ||
                    (this.LastChangedDate != null &&
                    this.LastChangedDate.Equals(input.LastChangedDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.SourceBranch == input.SourceBranch ||
                    (this.SourceBranch != null &&
                    this.SourceBranch.Equals(input.SourceBranch))
                ) && 
                (
                    this.SourceVersion == input.SourceVersion ||
                    (this.SourceVersion != null &&
                    this.SourceVersion.Equals(input.SourceVersion))
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
                if (this.BuildNumber != null)
                    hashCode = hashCode * 59 + this.BuildNumber.GetHashCode();
                if (this.QueueTime != null)
                    hashCode = hashCode * 59 + this.QueueTime.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null)
                    hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.LastChangedDate != null)
                    hashCode = hashCode * 59 + this.LastChangedDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.SourceBranch != null)
                    hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.SourceVersion != null)
                    hashCode = hashCode * 59 + this.SourceVersion.GetHashCode();
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
