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
    /// CreateReleaseUploadResponse
    /// </summary>
    [DataContract]
        public partial class CreateReleaseUploadResponse :  IEquatable<CreateReleaseUploadResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReleaseUploadResponse" /> class.
        /// </summary>
        /// <param name="id">The ID for the newly created upload. It is going to be required later in the process. (required).</param>
        /// <param name="uploadDomain">The URL domain used to upload the release. (required).</param>
        /// <param name="token">The access token used for upload permissions. (required).</param>
        /// <param name="urlEncodedToken">The access token used for upload permissions (URL encoded to use as a single query parameter). (required).</param>
        /// <param name="packageAssetId">The associated asset ID in the file management service associated with this uploaded. (required).</param>
        public CreateReleaseUploadResponse(Guid? id = default(Guid?), string uploadDomain = default(string), string token = default(string), string urlEncodedToken = default(string), Guid? packageAssetId = default(Guid?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CreateReleaseUploadResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "uploadDomain" is required (not null)
            if (uploadDomain == null)
            {
                throw new InvalidDataException("uploadDomain is a required property for CreateReleaseUploadResponse and cannot be null");
            }
            else
            {
                this.UploadDomain = uploadDomain;
            }
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new InvalidDataException("token is a required property for CreateReleaseUploadResponse and cannot be null");
            }
            else
            {
                this.Token = token;
            }
            // to ensure "urlEncodedToken" is required (not null)
            if (urlEncodedToken == null)
            {
                throw new InvalidDataException("urlEncodedToken is a required property for CreateReleaseUploadResponse and cannot be null");
            }
            else
            {
                this.UrlEncodedToken = urlEncodedToken;
            }
            // to ensure "packageAssetId" is required (not null)
            if (packageAssetId == null)
            {
                throw new InvalidDataException("packageAssetId is a required property for CreateReleaseUploadResponse and cannot be null");
            }
            else
            {
                this.PackageAssetId = packageAssetId;
            }
        }
        
        /// <summary>
        /// The ID for the newly created upload. It is going to be required later in the process.
        /// </summary>
        /// <value>The ID for the newly created upload. It is going to be required later in the process.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The URL domain used to upload the release.
        /// </summary>
        /// <value>The URL domain used to upload the release.</value>
        [DataMember(Name="upload_domain", EmitDefaultValue=false)]
        public string UploadDomain { get; set; }

        /// <summary>
        /// The access token used for upload permissions.
        /// </summary>
        /// <value>The access token used for upload permissions.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// The access token used for upload permissions (URL encoded to use as a single query parameter).
        /// </summary>
        /// <value>The access token used for upload permissions (URL encoded to use as a single query parameter).</value>
        [DataMember(Name="url_encoded_token", EmitDefaultValue=false)]
        public string UrlEncodedToken { get; set; }

        /// <summary>
        /// The associated asset ID in the file management service associated with this uploaded.
        /// </summary>
        /// <value>The associated asset ID in the file management service associated with this uploaded.</value>
        [DataMember(Name="package_asset_id", EmitDefaultValue=false)]
        public Guid? PackageAssetId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReleaseUploadResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UploadDomain: ").Append(UploadDomain).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UrlEncodedToken: ").Append(UrlEncodedToken).Append("\n");
            sb.Append("  PackageAssetId: ").Append(PackageAssetId).Append("\n");
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
            return this.Equals(input as CreateReleaseUploadResponse);
        }

        /// <summary>
        /// Returns true if CreateReleaseUploadResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateReleaseUploadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReleaseUploadResponse input)
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
                    this.UploadDomain == input.UploadDomain ||
                    (this.UploadDomain != null &&
                    this.UploadDomain.Equals(input.UploadDomain))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.UrlEncodedToken == input.UrlEncodedToken ||
                    (this.UrlEncodedToken != null &&
                    this.UrlEncodedToken.Equals(input.UrlEncodedToken))
                ) && 
                (
                    this.PackageAssetId == input.PackageAssetId ||
                    (this.PackageAssetId != null &&
                    this.PackageAssetId.Equals(input.PackageAssetId))
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
                if (this.UploadDomain != null)
                    hashCode = hashCode * 59 + this.UploadDomain.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.UrlEncodedToken != null)
                    hashCode = hashCode * 59 + this.UrlEncodedToken.GetHashCode();
                if (this.PackageAssetId != null)
                    hashCode = hashCode * 59 + this.PackageAssetId.GetHashCode();
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
