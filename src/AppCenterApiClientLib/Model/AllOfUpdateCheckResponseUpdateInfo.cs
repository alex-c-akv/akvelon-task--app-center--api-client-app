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
    /// AllOfUpdateCheckResponseUpdateInfo
    /// </summary>
    [DataContract]
        public partial class AllOfUpdateCheckResponseUpdateInfo :  IEquatable<AllOfUpdateCheckResponseUpdateInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfUpdateCheckResponseUpdateInfo" /> class.
        /// </summary>
        /// <param name="downloadUrl">downloadUrl.</param>
        /// <param name="isAvailable">isAvailable.</param>
        /// <param name="packageSize">packageSize.</param>
        /// <param name="shouldRunBinaryVersion">shouldRunBinaryVersion.</param>
        /// <param name="updateAppVersion">updateAppVersion.</param>
        /// <param name="packageHash">packageHash.</param>
        /// <param name="label">label.</param>
        public AllOfUpdateCheckResponseUpdateInfo(string downloadUrl = default(string), bool? isAvailable = default(bool?), decimal? packageSize = default(decimal?), bool? shouldRunBinaryVersion = default(bool?), bool? updateAppVersion = default(bool?), string packageHash = default(string), string label = default(string))
        {
            this.DownloadUrl = downloadUrl;
            this.IsAvailable = isAvailable;
            this.PackageSize = packageSize;
            this.ShouldRunBinaryVersion = shouldRunBinaryVersion;
            this.UpdateAppVersion = updateAppVersion;
            this.PackageHash = packageHash;
            this.Label = label;
        }
        
        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="download_url", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or Sets IsAvailable
        /// </summary>
        [DataMember(Name="is_available", EmitDefaultValue=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Gets or Sets PackageSize
        /// </summary>
        [DataMember(Name="package_size", EmitDefaultValue=false)]
        public decimal? PackageSize { get; set; }

        /// <summary>
        /// Gets or Sets ShouldRunBinaryVersion
        /// </summary>
        [DataMember(Name="should_run_binary_version", EmitDefaultValue=false)]
        public bool? ShouldRunBinaryVersion { get; set; }

        /// <summary>
        /// Gets or Sets UpdateAppVersion
        /// </summary>
        [DataMember(Name="update_app_version", EmitDefaultValue=false)]
        public bool? UpdateAppVersion { get; set; }

        /// <summary>
        /// Gets or Sets PackageHash
        /// </summary>
        [DataMember(Name="package_hash", EmitDefaultValue=false)]
        public string PackageHash { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfUpdateCheckResponseUpdateInfo {\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  PackageSize: ").Append(PackageSize).Append("\n");
            sb.Append("  ShouldRunBinaryVersion: ").Append(ShouldRunBinaryVersion).Append("\n");
            sb.Append("  UpdateAppVersion: ").Append(UpdateAppVersion).Append("\n");
            sb.Append("  PackageHash: ").Append(PackageHash).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as AllOfUpdateCheckResponseUpdateInfo);
        }

        /// <summary>
        /// Returns true if AllOfUpdateCheckResponseUpdateInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfUpdateCheckResponseUpdateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfUpdateCheckResponseUpdateInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DownloadUrl == input.DownloadUrl ||
                    (this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(input.DownloadUrl))
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    (this.IsAvailable != null &&
                    this.IsAvailable.Equals(input.IsAvailable))
                ) && 
                (
                    this.PackageSize == input.PackageSize ||
                    (this.PackageSize != null &&
                    this.PackageSize.Equals(input.PackageSize))
                ) && 
                (
                    this.ShouldRunBinaryVersion == input.ShouldRunBinaryVersion ||
                    (this.ShouldRunBinaryVersion != null &&
                    this.ShouldRunBinaryVersion.Equals(input.ShouldRunBinaryVersion))
                ) && 
                (
                    this.UpdateAppVersion == input.UpdateAppVersion ||
                    (this.UpdateAppVersion != null &&
                    this.UpdateAppVersion.Equals(input.UpdateAppVersion))
                ) && 
                (
                    this.PackageHash == input.PackageHash ||
                    (this.PackageHash != null &&
                    this.PackageHash.Equals(input.PackageHash))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.DownloadUrl != null)
                    hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                if (this.IsAvailable != null)
                    hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.PackageSize != null)
                    hashCode = hashCode * 59 + this.PackageSize.GetHashCode();
                if (this.ShouldRunBinaryVersion != null)
                    hashCode = hashCode * 59 + this.ShouldRunBinaryVersion.GetHashCode();
                if (this.UpdateAppVersion != null)
                    hashCode = hashCode * 59 + this.UpdateAppVersion.GetHashCode();
                if (this.PackageHash != null)
                    hashCode = hashCode * 59 + this.PackageHash.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
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
