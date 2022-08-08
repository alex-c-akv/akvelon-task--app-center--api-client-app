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
    /// LegacyCodePushRelease
    /// </summary>
    [DataContract]
        public partial class LegacyCodePushRelease :  IEquatable<LegacyCodePushRelease>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyCodePushRelease" /> class.
        /// </summary>
        /// <param name="appVersion">The version of the release.</param>
        /// <param name="isDisabled">Flag used to determine if release is disabled.</param>
        /// <param name="isMandatory">Flag used to determine if release is mandatory.</param>
        /// <param name="rollout">Percentage (out of 100) that release is deployed to.</param>
        /// <param name="blobUrl">Location (URL) of release package.</param>
        /// <param name="size">Size of release package.</param>
        /// <param name="releaseMethod">Method used to deploy release.</param>
        /// <param name="uploadTime">Release upload time as epoch Unix timestamp.</param>
        /// <param name="label">Release label (aka release name).</param>
        /// <param name="releasedByUserId">User ID that triggered most recent release.</param>
        /// <param name="manifestBlobUrl">The URL location of the package&#x27;s manifest file..</param>
        /// <param name="diffPackageMap">Object containing URL and size of changed package hashes contained in the release.</param>
        public LegacyCodePushRelease(string appVersion = default(string), bool? isDisabled = default(bool?), bool? isMandatory = default(bool?), int? rollout = default(int?), string blobUrl = default(string), int? size = default(int?), string releaseMethod = default(string), int? uploadTime = default(int?), string label = default(string), string releasedByUserId = default(string), string manifestBlobUrl = default(string), Object diffPackageMap = default(Object))
        {
            this.AppVersion = appVersion;
            this.IsDisabled = isDisabled;
            this.IsMandatory = isMandatory;
            this.Rollout = rollout;
            this.BlobUrl = blobUrl;
            this.Size = size;
            this.ReleaseMethod = releaseMethod;
            this.UploadTime = uploadTime;
            this.Label = label;
            this.ReleasedByUserId = releasedByUserId;
            this.ManifestBlobUrl = manifestBlobUrl;
            this.DiffPackageMap = diffPackageMap;
        }
        
        /// <summary>
        /// The version of the release
        /// </summary>
        /// <value>The version of the release</value>
        [DataMember(Name="appVersion", EmitDefaultValue=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Flag used to determine if release is disabled
        /// </summary>
        /// <value>Flag used to determine if release is disabled</value>
        [DataMember(Name="isDisabled", EmitDefaultValue=false)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Flag used to determine if release is mandatory
        /// </summary>
        /// <value>Flag used to determine if release is mandatory</value>
        [DataMember(Name="isMandatory", EmitDefaultValue=false)]
        public bool? IsMandatory { get; set; }

        /// <summary>
        /// Percentage (out of 100) that release is deployed to
        /// </summary>
        /// <value>Percentage (out of 100) that release is deployed to</value>
        [DataMember(Name="rollout", EmitDefaultValue=false)]
        public int? Rollout { get; set; }

        /// <summary>
        /// Location (URL) of release package
        /// </summary>
        /// <value>Location (URL) of release package</value>
        [DataMember(Name="blobUrl", EmitDefaultValue=false)]
        public string BlobUrl { get; set; }

        /// <summary>
        /// Size of release package
        /// </summary>
        /// <value>Size of release package</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Method used to deploy release
        /// </summary>
        /// <value>Method used to deploy release</value>
        [DataMember(Name="releaseMethod", EmitDefaultValue=false)]
        public string ReleaseMethod { get; set; }

        /// <summary>
        /// Release upload time as epoch Unix timestamp
        /// </summary>
        /// <value>Release upload time as epoch Unix timestamp</value>
        [DataMember(Name="uploadTime", EmitDefaultValue=false)]
        public int? UploadTime { get; set; }

        /// <summary>
        /// Release label (aka release name)
        /// </summary>
        /// <value>Release label (aka release name)</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// User ID that triggered most recent release
        /// </summary>
        /// <value>User ID that triggered most recent release</value>
        [DataMember(Name="releasedByUserId", EmitDefaultValue=false)]
        public string ReleasedByUserId { get; set; }

        /// <summary>
        /// The URL location of the package&#x27;s manifest file.
        /// </summary>
        /// <value>The URL location of the package&#x27;s manifest file.</value>
        [DataMember(Name="manifestBlobUrl", EmitDefaultValue=false)]
        public string ManifestBlobUrl { get; set; }

        /// <summary>
        /// Object containing URL and size of changed package hashes contained in the release
        /// </summary>
        /// <value>Object containing URL and size of changed package hashes contained in the release</value>
        [DataMember(Name="diffPackageMap", EmitDefaultValue=false)]
        public Object DiffPackageMap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegacyCodePushRelease {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  IsMandatory: ").Append(IsMandatory).Append("\n");
            sb.Append("  Rollout: ").Append(Rollout).Append("\n");
            sb.Append("  BlobUrl: ").Append(BlobUrl).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ReleaseMethod: ").Append(ReleaseMethod).Append("\n");
            sb.Append("  UploadTime: ").Append(UploadTime).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ReleasedByUserId: ").Append(ReleasedByUserId).Append("\n");
            sb.Append("  ManifestBlobUrl: ").Append(ManifestBlobUrl).Append("\n");
            sb.Append("  DiffPackageMap: ").Append(DiffPackageMap).Append("\n");
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
            return this.Equals(input as LegacyCodePushRelease);
        }

        /// <summary>
        /// Returns true if LegacyCodePushRelease instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyCodePushRelease to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyCodePushRelease input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    (this.IsDisabled != null &&
                    this.IsDisabled.Equals(input.IsDisabled))
                ) && 
                (
                    this.IsMandatory == input.IsMandatory ||
                    (this.IsMandatory != null &&
                    this.IsMandatory.Equals(input.IsMandatory))
                ) && 
                (
                    this.Rollout == input.Rollout ||
                    (this.Rollout != null &&
                    this.Rollout.Equals(input.Rollout))
                ) && 
                (
                    this.BlobUrl == input.BlobUrl ||
                    (this.BlobUrl != null &&
                    this.BlobUrl.Equals(input.BlobUrl))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ReleaseMethod == input.ReleaseMethod ||
                    (this.ReleaseMethod != null &&
                    this.ReleaseMethod.Equals(input.ReleaseMethod))
                ) && 
                (
                    this.UploadTime == input.UploadTime ||
                    (this.UploadTime != null &&
                    this.UploadTime.Equals(input.UploadTime))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.ReleasedByUserId == input.ReleasedByUserId ||
                    (this.ReleasedByUserId != null &&
                    this.ReleasedByUserId.Equals(input.ReleasedByUserId))
                ) && 
                (
                    this.ManifestBlobUrl == input.ManifestBlobUrl ||
                    (this.ManifestBlobUrl != null &&
                    this.ManifestBlobUrl.Equals(input.ManifestBlobUrl))
                ) && 
                (
                    this.DiffPackageMap == input.DiffPackageMap ||
                    (this.DiffPackageMap != null &&
                    this.DiffPackageMap.Equals(input.DiffPackageMap))
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
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.IsDisabled != null)
                    hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
                if (this.IsMandatory != null)
                    hashCode = hashCode * 59 + this.IsMandatory.GetHashCode();
                if (this.Rollout != null)
                    hashCode = hashCode * 59 + this.Rollout.GetHashCode();
                if (this.BlobUrl != null)
                    hashCode = hashCode * 59 + this.BlobUrl.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ReleaseMethod != null)
                    hashCode = hashCode * 59 + this.ReleaseMethod.GetHashCode();
                if (this.UploadTime != null)
                    hashCode = hashCode * 59 + this.UploadTime.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.ReleasedByUserId != null)
                    hashCode = hashCode * 59 + this.ReleasedByUserId.GetHashCode();
                if (this.ManifestBlobUrl != null)
                    hashCode = hashCode * 59 + this.ManifestBlobUrl.GetHashCode();
                if (this.DiffPackageMap != null)
                    hashCode = hashCode * 59 + this.DiffPackageMap.GetHashCode();
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
