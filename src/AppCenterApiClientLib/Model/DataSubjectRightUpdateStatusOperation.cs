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
    /// DataSubjectRightUpdateStatusOperation
    /// </summary>
    [DataContract]
        public partial class DataSubjectRightUpdateStatusOperation :  IEquatable<DataSubjectRightUpdateStatusOperation>, IValidatableObject
    {
        /// <summary>
        /// Operation status
        /// </summary>
        /// <value>Operation status</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum Created for value: Created
            /// </summary>
            [EnumMember(Value = "Created")]
            Created = 2,
            /// <summary>
            /// Enum Queued for value: Queued
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued = 3,
            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 4,
            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 5,
            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 6        }
        /// <summary>
        /// Operation status
        /// </summary>
        /// <value>Operation status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSubjectRightUpdateStatusOperation" /> class.
        /// </summary>
        /// <param name="requestId">Request identifier of the operation (required).</param>
        /// <param name="status">Operation status (required).</param>
        /// <param name="participantData">String field to be used by participant for any intermediate statuses or data they need to save.</param>
        public DataSubjectRightUpdateStatusOperation(string requestId = default(string), StatusEnum status = default(StatusEnum), string participantData = default(string))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for DataSubjectRightUpdateStatusOperation and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for DataSubjectRightUpdateStatusOperation and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.ParticipantData = participantData;
        }
        
        /// <summary>
        /// Request identifier of the operation
        /// </summary>
        /// <value>Request identifier of the operation</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }


        /// <summary>
        /// String field to be used by participant for any intermediate statuses or data they need to save
        /// </summary>
        /// <value>String field to be used by participant for any intermediate statuses or data they need to save</value>
        [DataMember(Name="participantData", EmitDefaultValue=false)]
        public string ParticipantData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSubjectRightUpdateStatusOperation {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ParticipantData: ").Append(ParticipantData).Append("\n");
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
            return this.Equals(input as DataSubjectRightUpdateStatusOperation);
        }

        /// <summary>
        /// Returns true if DataSubjectRightUpdateStatusOperation instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSubjectRightUpdateStatusOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSubjectRightUpdateStatusOperation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ParticipantData == input.ParticipantData ||
                    (this.ParticipantData != null &&
                    this.ParticipantData.Equals(input.ParticipantData))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ParticipantData != null)
                    hashCode = hashCode * 59 + this.ParticipantData.GetHashCode();
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
