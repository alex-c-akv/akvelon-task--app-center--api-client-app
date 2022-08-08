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
    /// Response for getting a list of releases in a distribution group
    /// </summary>
    [DataContract]
        public partial class DistributionGroupRelease :  IEquatable<DistributionGroupRelease>, IValidatableObject
    {
        /// <summary>
        /// The release&#x27;s origin
        /// </summary>
        /// <value>The release&#x27;s origin</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OriginEnum
        {
            /// <summary>
            /// Enum Hockeyapp for value: hockeyapp
            /// </summary>
            [EnumMember(Value = "hockeyapp")]
            Hockeyapp = 1,
            /// <summary>
            /// Enum Appcenter for value: appcenter
            /// </summary>
            [EnumMember(Value = "appcenter")]
            Appcenter = 2        }
        /// <summary>
        /// The release&#x27;s origin
        /// </summary>
        /// <value>The release&#x27;s origin</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum? Origin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionGroupRelease" /> class.
        /// </summary>
        /// <param name="id">ID identifying this unique release. (required).</param>
        /// <param name="version">The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml.  (required).</param>
        /// <param name="origin">The release&#x27;s origin.</param>
        /// <param name="shortVersion">The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml.  (required).</param>
        /// <param name="mandatoryUpdate">A boolean which determines whether the release is a mandatory update or not. (required).</param>
        /// <param name="uploadedAt">UTC time in ISO 8601 format of the uploaded time. (required).</param>
        /// <param name="enabled">This value determines the whether a release currently is enabled or disabled. (required).</param>
        /// <param name="isExternalBuild">This value determines if a release is external or not..</param>
        public DistributionGroupRelease(int? id = default(int?), string version = default(string), OriginEnum? origin = default(OriginEnum?), string shortVersion = default(string), bool? mandatoryUpdate = default(bool?), string uploadedAt = default(string), bool? enabled = default(bool?), bool? isExternalBuild = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DistributionGroupRelease and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for DistributionGroupRelease and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            // to ensure "shortVersion" is required (not null)
            if (shortVersion == null)
            {
                throw new InvalidDataException("shortVersion is a required property for DistributionGroupRelease and cannot be null");
            }
            else
            {
                this.ShortVersion = shortVersion;
            }
            // to ensure "mandatoryUpdate" is required (not null)
            if (mandatoryUpdate == null)
            {
                throw new InvalidDataException("mandatoryUpdate is a required property for DistributionGroupRelease and cannot be null");
            }
            else
            {
                this.MandatoryUpdate = mandatoryUpdate;
            }
            // to ensure "uploadedAt" is required (not null)
            if (uploadedAt == null)
            {
                throw new InvalidDataException("uploadedAt is a required property for DistributionGroupRelease and cannot be null");
            }
            else
            {
                this.UploadedAt = uploadedAt;
            }
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for DistributionGroupRelease and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            this.Origin = origin;
            this.IsExternalBuild = isExternalBuild;
        }
        
        /// <summary>
        /// ID identifying this unique release.
        /// </summary>
        /// <value>ID identifying this unique release.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml. 
        /// </summary>
        /// <value>The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml. </value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }


        /// <summary>
        /// The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml. 
        /// </summary>
        /// <value>The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml. </value>
        [DataMember(Name="short_version", EmitDefaultValue=false)]
        public string ShortVersion { get; set; }

        /// <summary>
        /// A boolean which determines whether the release is a mandatory update or not.
        /// </summary>
        /// <value>A boolean which determines whether the release is a mandatory update or not.</value>
        [DataMember(Name="mandatory_update", EmitDefaultValue=false)]
        public bool? MandatoryUpdate { get; set; }

        /// <summary>
        /// UTC time in ISO 8601 format of the uploaded time.
        /// </summary>
        /// <value>UTC time in ISO 8601 format of the uploaded time.</value>
        [DataMember(Name="uploaded_at", EmitDefaultValue=false)]
        public string UploadedAt { get; set; }

        /// <summary>
        /// This value determines the whether a release currently is enabled or disabled.
        /// </summary>
        /// <value>This value determines the whether a release currently is enabled or disabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This value determines if a release is external or not.
        /// </summary>
        /// <value>This value determines if a release is external or not.</value>
        [DataMember(Name="is_external_build", EmitDefaultValue=false)]
        public bool? IsExternalBuild { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionGroupRelease {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  ShortVersion: ").Append(ShortVersion).Append("\n");
            sb.Append("  MandatoryUpdate: ").Append(MandatoryUpdate).Append("\n");
            sb.Append("  UploadedAt: ").Append(UploadedAt).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IsExternalBuild: ").Append(IsExternalBuild).Append("\n");
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
            return this.Equals(input as DistributionGroupRelease);
        }

        /// <summary>
        /// Returns true if DistributionGroupRelease instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionGroupRelease to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionGroupRelease input)
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
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.ShortVersion == input.ShortVersion ||
                    (this.ShortVersion != null &&
                    this.ShortVersion.Equals(input.ShortVersion))
                ) && 
                (
                    this.MandatoryUpdate == input.MandatoryUpdate ||
                    (this.MandatoryUpdate != null &&
                    this.MandatoryUpdate.Equals(input.MandatoryUpdate))
                ) && 
                (
                    this.UploadedAt == input.UploadedAt ||
                    (this.UploadedAt != null &&
                    this.UploadedAt.Equals(input.UploadedAt))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.IsExternalBuild == input.IsExternalBuild ||
                    (this.IsExternalBuild != null &&
                    this.IsExternalBuild.Equals(input.IsExternalBuild))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.ShortVersion != null)
                    hashCode = hashCode * 59 + this.ShortVersion.GetHashCode();
                if (this.MandatoryUpdate != null)
                    hashCode = hashCode * 59 + this.MandatoryUpdate.GetHashCode();
                if (this.UploadedAt != null)
                    hashCode = hashCode * 59 + this.UploadedAt.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.IsExternalBuild != null)
                    hashCode = hashCode * 59 + this.IsExternalBuild.GetHashCode();
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
