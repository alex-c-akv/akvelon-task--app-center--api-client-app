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
    /// CodePushReleaseMetric
    /// </summary>
    [DataContract]
        public partial class CodePushReleaseMetric :  IEquatable<CodePushReleaseMetric>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodePushReleaseMetric" /> class.
        /// </summary>
        /// <param name="label">label (required).</param>
        /// <param name="active">active (required).</param>
        /// <param name="downloaded">downloaded.</param>
        /// <param name="failed">failed.</param>
        /// <param name="installed">installed.</param>
        public CodePushReleaseMetric(string label = default(string), int? active = default(int?), int? downloaded = default(int?), int? failed = default(int?), int? installed = default(int?))
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new InvalidDataException("label is a required property for CodePushReleaseMetric and cannot be null");
            }
            else
            {
                this.Label = label;
            }
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for CodePushReleaseMetric and cannot be null");
            }
            else
            {
                this.Active = active;
            }
            this.Downloaded = downloaded;
            this.Failed = failed;
            this.Installed = installed;
        }
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public int? Active { get; set; }

        /// <summary>
        /// Gets or Sets Downloaded
        /// </summary>
        [DataMember(Name="downloaded", EmitDefaultValue=false)]
        public int? Downloaded { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public int? Failed { get; set; }

        /// <summary>
        /// Gets or Sets Installed
        /// </summary>
        [DataMember(Name="installed", EmitDefaultValue=false)]
        public int? Installed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodePushReleaseMetric {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Downloaded: ").Append(Downloaded).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Installed: ").Append(Installed).Append("\n");
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
            return this.Equals(input as CodePushReleaseMetric);
        }

        /// <summary>
        /// Returns true if CodePushReleaseMetric instances are equal
        /// </summary>
        /// <param name="input">Instance of CodePushReleaseMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodePushReleaseMetric input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Downloaded == input.Downloaded ||
                    (this.Downloaded != null &&
                    this.Downloaded.Equals(input.Downloaded))
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.Installed == input.Installed ||
                    (this.Installed != null &&
                    this.Installed.Equals(input.Installed))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Downloaded != null)
                    hashCode = hashCode * 59 + this.Downloaded.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Installed != null)
                    hashCode = hashCode * 59 + this.Installed.GetHashCode();
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
