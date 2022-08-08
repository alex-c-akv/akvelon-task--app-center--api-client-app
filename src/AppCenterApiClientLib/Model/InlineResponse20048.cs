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
    /// InlineResponse20048
    /// </summary>
    [DataContract]
        public partial class InlineResponse20048 :  IEquatable<InlineResponse20048>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20048" /> class.
        /// </summary>
        /// <param name="appId">appId.</param>
        /// <param name="errorGroupId">errorGroupId.</param>
        /// <param name="errorId">errorId.</param>
        /// <param name="errorsDeleted">errorsDeleted.</param>
        /// <param name="attachmentsDeleted">attachmentsDeleted.</param>
        /// <param name="blobsSucceeded">blobsSucceeded.</param>
        /// <param name="blobsFailed">blobsFailed.</param>
        public InlineResponse20048(string appId = default(string), string errorGroupId = default(string), string errorId = default(string), int? errorsDeleted = default(int?), int? attachmentsDeleted = default(int?), int? blobsSucceeded = default(int?), int? blobsFailed = default(int?))
        {
            this.AppId = appId;
            this.ErrorGroupId = errorGroupId;
            this.ErrorId = errorId;
            this.ErrorsDeleted = errorsDeleted;
            this.AttachmentsDeleted = attachmentsDeleted;
            this.BlobsSucceeded = blobsSucceeded;
            this.BlobsFailed = blobsFailed;
        }
        
        /// <summary>
        /// Gets or Sets AppId
        /// </summary>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorGroupId
        /// </summary>
        [DataMember(Name="errorGroupId", EmitDefaultValue=false)]
        public string ErrorGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorId
        /// </summary>
        [DataMember(Name="errorId", EmitDefaultValue=false)]
        public string ErrorId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorsDeleted
        /// </summary>
        [DataMember(Name="errorsDeleted", EmitDefaultValue=false)]
        public int? ErrorsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentsDeleted
        /// </summary>
        [DataMember(Name="attachmentsDeleted", EmitDefaultValue=false)]
        public int? AttachmentsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets BlobsSucceeded
        /// </summary>
        [DataMember(Name="blobsSucceeded", EmitDefaultValue=false)]
        public int? BlobsSucceeded { get; set; }

        /// <summary>
        /// Gets or Sets BlobsFailed
        /// </summary>
        [DataMember(Name="blobsFailed", EmitDefaultValue=false)]
        public int? BlobsFailed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20048 {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  ErrorGroupId: ").Append(ErrorGroupId).Append("\n");
            sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
            sb.Append("  ErrorsDeleted: ").Append(ErrorsDeleted).Append("\n");
            sb.Append("  AttachmentsDeleted: ").Append(AttachmentsDeleted).Append("\n");
            sb.Append("  BlobsSucceeded: ").Append(BlobsSucceeded).Append("\n");
            sb.Append("  BlobsFailed: ").Append(BlobsFailed).Append("\n");
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
            return this.Equals(input as InlineResponse20048);
        }

        /// <summary>
        /// Returns true if InlineResponse20048 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20048 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20048 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.ErrorGroupId == input.ErrorGroupId ||
                    (this.ErrorGroupId != null &&
                    this.ErrorGroupId.Equals(input.ErrorGroupId))
                ) && 
                (
                    this.ErrorId == input.ErrorId ||
                    (this.ErrorId != null &&
                    this.ErrorId.Equals(input.ErrorId))
                ) && 
                (
                    this.ErrorsDeleted == input.ErrorsDeleted ||
                    (this.ErrorsDeleted != null &&
                    this.ErrorsDeleted.Equals(input.ErrorsDeleted))
                ) && 
                (
                    this.AttachmentsDeleted == input.AttachmentsDeleted ||
                    (this.AttachmentsDeleted != null &&
                    this.AttachmentsDeleted.Equals(input.AttachmentsDeleted))
                ) && 
                (
                    this.BlobsSucceeded == input.BlobsSucceeded ||
                    (this.BlobsSucceeded != null &&
                    this.BlobsSucceeded.Equals(input.BlobsSucceeded))
                ) && 
                (
                    this.BlobsFailed == input.BlobsFailed ||
                    (this.BlobsFailed != null &&
                    this.BlobsFailed.Equals(input.BlobsFailed))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ErrorGroupId != null)
                    hashCode = hashCode * 59 + this.ErrorGroupId.GetHashCode();
                if (this.ErrorId != null)
                    hashCode = hashCode * 59 + this.ErrorId.GetHashCode();
                if (this.ErrorsDeleted != null)
                    hashCode = hashCode * 59 + this.ErrorsDeleted.GetHashCode();
                if (this.AttachmentsDeleted != null)
                    hashCode = hashCode * 59 + this.AttachmentsDeleted.GetHashCode();
                if (this.BlobsSucceeded != null)
                    hashCode = hashCode * 59 + this.BlobsSucceeded.GetHashCode();
                if (this.BlobsFailed != null)
                    hashCode = hashCode * 59 + this.BlobsFailed.GetHashCode();
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