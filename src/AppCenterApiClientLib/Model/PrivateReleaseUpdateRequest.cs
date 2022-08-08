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
    /// A request containing information for updating a release.
    /// </summary>
    [DataContract]
        public partial class PrivateReleaseUpdateRequest :  IEquatable<PrivateReleaseUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// The store publishing status.
        /// </summary>
        /// <value>The store publishing status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PublishingStatusEnum
        {
            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 1,
            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 2,
            /// <summary>
            /// Enum Submitted for value: submitted
            /// </summary>
            [EnumMember(Value = "submitted")]
            Submitted = 3,
            /// <summary>
            /// Enum Timeout for value: timeout
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout = 4        }
        /// <summary>
        /// The store publishing status.
        /// </summary>
        /// <value>The store publishing status.</value>
        [DataMember(Name="publishing_status", EmitDefaultValue=false)]
        public PublishingStatusEnum? PublishingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateReleaseUpdateRequest" /> class.
        /// </summary>
        /// <param name="publishingStatus">The store publishing status..</param>
        public PrivateReleaseUpdateRequest(PublishingStatusEnum? publishingStatus = default(PublishingStatusEnum?))
        {
            this.PublishingStatus = publishingStatus;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateReleaseUpdateRequest {\n");
            sb.Append("  PublishingStatus: ").Append(PublishingStatus).Append("\n");
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
            return this.Equals(input as PrivateReleaseUpdateRequest);
        }

        /// <summary>
        /// Returns true if PrivateReleaseUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivateReleaseUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateReleaseUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublishingStatus == input.PublishingStatus ||
                    (this.PublishingStatus != null &&
                    this.PublishingStatus.Equals(input.PublishingStatus))
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
                if (this.PublishingStatus != null)
                    hashCode = hashCode * 59 + this.PublishingStatus.GetHashCode();
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
