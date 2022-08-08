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
    /// GetReleaseStatusResponse
    /// </summary>
    [DataContract]
        public partial class GetReleaseStatusResponse :  IEquatable<GetReleaseStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// The current upload status.
        /// </summary>
        /// <value>The current upload status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UploadStatusEnum
        {
            /// <summary>
            /// Enum UploadStarted for value: uploadStarted
            /// </summary>
            [EnumMember(Value = "uploadStarted")]
            UploadStarted = 1,
            /// <summary>
            /// Enum UploadFinished for value: uploadFinished
            /// </summary>
            [EnumMember(Value = "uploadFinished")]
            UploadFinished = 2,
            /// <summary>
            /// Enum ReadyToBePublished for value: readyToBePublished
            /// </summary>
            [EnumMember(Value = "readyToBePublished")]
            ReadyToBePublished = 3,
            /// <summary>
            /// Enum MalwareDetected for value: malwareDetected
            /// </summary>
            [EnumMember(Value = "malwareDetected")]
            MalwareDetected = 4,
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 5        }
        /// <summary>
        /// The current upload status.
        /// </summary>
        /// <value>The current upload status.</value>
        [DataMember(Name="upload_status", EmitDefaultValue=false)]
        public UploadStatusEnum UploadStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReleaseStatusResponse" /> class.
        /// </summary>
        /// <param name="id">The ID for the upload. (required).</param>
        /// <param name="uploadStatus">The current upload status. (required).</param>
        /// <param name="errorDetails">Details describing what went wrong processing the upload. Will only be set if status &#x3D; &#x27;error&#x27;..</param>
        /// <param name="releaseDistinctId">The distinct ID of the release. Will only be set when the status &#x3D; &#x27;readyToBePublished&#x27;..</param>
        /// <param name="releaseUrl">The URL of the release. Will only be set when the status &#x3D; &#x27;readyToBePublished&#x27;..</param>
        public GetReleaseStatusResponse(Guid? id = default(Guid?), UploadStatusEnum uploadStatus = default(UploadStatusEnum), string errorDetails = default(string), decimal? releaseDistinctId = default(decimal?), Object releaseUrl = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetReleaseStatusResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "uploadStatus" is required (not null)
            if (uploadStatus == null)
            {
                throw new InvalidDataException("uploadStatus is a required property for GetReleaseStatusResponse and cannot be null");
            }
            else
            {
                this.UploadStatus = uploadStatus;
            }
            this.ErrorDetails = errorDetails;
            this.ReleaseDistinctId = releaseDistinctId;
            this.ReleaseUrl = releaseUrl;
        }
        
        /// <summary>
        /// The ID for the upload.
        /// </summary>
        /// <value>The ID for the upload.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }


        /// <summary>
        /// Details describing what went wrong processing the upload. Will only be set if status &#x3D; &#x27;error&#x27;.
        /// </summary>
        /// <value>Details describing what went wrong processing the upload. Will only be set if status &#x3D; &#x27;error&#x27;.</value>
        [DataMember(Name="error_details", EmitDefaultValue=false)]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// The distinct ID of the release. Will only be set when the status &#x3D; &#x27;readyToBePublished&#x27;.
        /// </summary>
        /// <value>The distinct ID of the release. Will only be set when the status &#x3D; &#x27;readyToBePublished&#x27;.</value>
        [DataMember(Name="release_distinct_id", EmitDefaultValue=false)]
        public decimal? ReleaseDistinctId { get; set; }

        /// <summary>
        /// The URL of the release. Will only be set when the status &#x3D; &#x27;readyToBePublished&#x27;.
        /// </summary>
        /// <value>The URL of the release. Will only be set when the status &#x3D; &#x27;readyToBePublished&#x27;.</value>
        [DataMember(Name="release_url", EmitDefaultValue=false)]
        public Object ReleaseUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetReleaseStatusResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ReleaseDistinctId: ").Append(ReleaseDistinctId).Append("\n");
            sb.Append("  ReleaseUrl: ").Append(ReleaseUrl).Append("\n");
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
            return this.Equals(input as GetReleaseStatusResponse);
        }

        /// <summary>
        /// Returns true if GetReleaseStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetReleaseStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetReleaseStatusResponse input)
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
                    this.UploadStatus == input.UploadStatus ||
                    (this.UploadStatus != null &&
                    this.UploadStatus.Equals(input.UploadStatus))
                ) && 
                (
                    this.ErrorDetails == input.ErrorDetails ||
                    (this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(input.ErrorDetails))
                ) && 
                (
                    this.ReleaseDistinctId == input.ReleaseDistinctId ||
                    (this.ReleaseDistinctId != null &&
                    this.ReleaseDistinctId.Equals(input.ReleaseDistinctId))
                ) && 
                (
                    this.ReleaseUrl == input.ReleaseUrl ||
                    (this.ReleaseUrl != null &&
                    this.ReleaseUrl.Equals(input.ReleaseUrl))
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
                if (this.UploadStatus != null)
                    hashCode = hashCode * 59 + this.UploadStatus.GetHashCode();
                if (this.ErrorDetails != null)
                    hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                if (this.ReleaseDistinctId != null)
                    hashCode = hashCode * 59 + this.ReleaseDistinctId.GetHashCode();
                if (this.ReleaseUrl != null)
                    hashCode = hashCode * 59 + this.ReleaseUrl.GetHashCode();
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
