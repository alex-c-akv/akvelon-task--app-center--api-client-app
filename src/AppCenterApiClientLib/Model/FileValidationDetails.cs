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
    /// Additional details required for file validation
    /// </summary>
    [DataContract]
        public partial class FileValidationDetails :  IEquatable<FileValidationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileValidationDetails" /> class.
        /// </summary>
        /// <param name="p12password">p12password (required).</param>
        /// <param name="certificateUploadId">certificateUploadId.</param>
        public FileValidationDetails(string p12password = default(string), string certificateUploadId = default(string))
        {
            // to ensure "p12password" is required (not null)
            if (p12password == null)
            {
                throw new InvalidDataException("p12password is a required property for FileValidationDetails and cannot be null");
            }
            else
            {
                this.P12password = p12password;
            }
            this.CertificateUploadId = certificateUploadId;
        }
        
        /// <summary>
        /// Gets or Sets P12password
        /// </summary>
        [DataMember(Name="p12password", EmitDefaultValue=false)]
        public string P12password { get; set; }

        /// <summary>
        /// Gets or Sets CertificateUploadId
        /// </summary>
        [DataMember(Name="certificateUploadId", EmitDefaultValue=false)]
        public string CertificateUploadId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileValidationDetails {\n");
            sb.Append("  P12password: ").Append(P12password).Append("\n");
            sb.Append("  CertificateUploadId: ").Append(CertificateUploadId).Append("\n");
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
            return this.Equals(input as FileValidationDetails);
        }

        /// <summary>
        /// Returns true if FileValidationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FileValidationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileValidationDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.P12password == input.P12password ||
                    (this.P12password != null &&
                    this.P12password.Equals(input.P12password))
                ) && 
                (
                    this.CertificateUploadId == input.CertificateUploadId ||
                    (this.CertificateUploadId != null &&
                    this.CertificateUploadId.Equals(input.CertificateUploadId))
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
                if (this.P12password != null)
                    hashCode = hashCode * 59 + this.P12password.GetHashCode();
                if (this.CertificateUploadId != null)
                    hashCode = hashCode * 59 + this.CertificateUploadId.GetHashCode();
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
