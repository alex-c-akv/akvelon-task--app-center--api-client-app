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
    /// URL that can be used to check the status of the update devices operation and the updated profiles.
    /// </summary>
    [DataContract]
        public partial class UpdateResignStatusResponse :  IEquatable<UpdateResignStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResignStatusResponse" /> class.
        /// </summary>
        /// <param name="status">The status. (required).</param>
        /// <param name="profilesZipBase64">A zip of the updated provisioning profiles. Base64 encoded..</param>
        public UpdateResignStatusResponse(string status = default(string), string profilesZipBase64 = default(string))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for UpdateResignStatusResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.ProfilesZipBase64 = profilesZipBase64;
        }
        
        /// <summary>
        /// The status.
        /// </summary>
        /// <value>The status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// A zip of the updated provisioning profiles. Base64 encoded.
        /// </summary>
        /// <value>A zip of the updated provisioning profiles. Base64 encoded.</value>
        [DataMember(Name="profiles_zip_base64", EmitDefaultValue=false)]
        public string ProfilesZipBase64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateResignStatusResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ProfilesZipBase64: ").Append(ProfilesZipBase64).Append("\n");
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
            return this.Equals(input as UpdateResignStatusResponse);
        }

        /// <summary>
        /// Returns true if UpdateResignStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateResignStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateResignStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ProfilesZipBase64 == input.ProfilesZipBase64 ||
                    (this.ProfilesZipBase64 != null &&
                    this.ProfilesZipBase64.Equals(input.ProfilesZipBase64))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ProfilesZipBase64 != null)
                    hashCode = hashCode * 59 + this.ProfilesZipBase64.GetHashCode();
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
