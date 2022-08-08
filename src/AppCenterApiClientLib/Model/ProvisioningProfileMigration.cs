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
    /// Describes the migration schema for a provisioning profile defined in HockeyApp.
    /// </summary>
    [DataContract]
        public partial class ProvisioningProfileMigration :  IEquatable<ProvisioningProfileMigration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningProfileMigration" /> class.
        /// </summary>
        /// <param name="name">The name of the provisioning profile. (required).</param>
        /// <param name="bundleId">The bundle/application identifier. (required).</param>
        /// <param name="teamIdentifier">The team identifier. (required).</param>
        /// <param name="type">The type of provisoning profile. (required).</param>
        /// <param name="isAppex">A boolean value that indicates whether the provisioning profile represents an app extension. (required).</param>
        /// <param name="expiredAt">The provisioning profile&#x27;s expiration date in RFC 3339 format, i.e. 2017-07-21T17:32:28Z..</param>
        /// <param name="udids">A list of UDIDs of provisioned devices..</param>
        /// <param name="url">A provisioning profile URL that indicates where to download it from..</param>
        public ProvisioningProfileMigration(string name = default(string), string bundleId = default(string), string teamIdentifier = default(string), int? type = default(int?), bool? isAppex = default(bool?), string expiredAt = default(string), List<string> udids = default(List<string>), string url = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProvisioningProfileMigration and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "bundleId" is required (not null)
            if (bundleId == null)
            {
                throw new InvalidDataException("bundleId is a required property for ProvisioningProfileMigration and cannot be null");
            }
            else
            {
                this.BundleId = bundleId;
            }
            // to ensure "teamIdentifier" is required (not null)
            if (teamIdentifier == null)
            {
                throw new InvalidDataException("teamIdentifier is a required property for ProvisioningProfileMigration and cannot be null");
            }
            else
            {
                this.TeamIdentifier = teamIdentifier;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ProvisioningProfileMigration and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "isAppex" is required (not null)
            if (isAppex == null)
            {
                throw new InvalidDataException("isAppex is a required property for ProvisioningProfileMigration and cannot be null");
            }
            else
            {
                this.IsAppex = isAppex;
            }
            this.ExpiredAt = expiredAt;
            this.Udids = udids;
            this.Url = url;
        }
        
        /// <summary>
        /// The name of the provisioning profile.
        /// </summary>
        /// <value>The name of the provisioning profile.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The bundle/application identifier.
        /// </summary>
        /// <value>The bundle/application identifier.</value>
        [DataMember(Name="bundle_id", EmitDefaultValue=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// The team identifier.
        /// </summary>
        /// <value>The team identifier.</value>
        [DataMember(Name="team_identifier", EmitDefaultValue=false)]
        public string TeamIdentifier { get; set; }

        /// <summary>
        /// The type of provisoning profile.
        /// </summary>
        /// <value>The type of provisoning profile.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// A boolean value that indicates whether the provisioning profile represents an app extension.
        /// </summary>
        /// <value>A boolean value that indicates whether the provisioning profile represents an app extension.</value>
        [DataMember(Name="is_appex", EmitDefaultValue=false)]
        public bool? IsAppex { get; set; }

        /// <summary>
        /// The provisioning profile&#x27;s expiration date in RFC 3339 format, i.e. 2017-07-21T17:32:28Z.
        /// </summary>
        /// <value>The provisioning profile&#x27;s expiration date in RFC 3339 format, i.e. 2017-07-21T17:32:28Z.</value>
        [DataMember(Name="expired_at", EmitDefaultValue=false)]
        public string ExpiredAt { get; set; }

        /// <summary>
        /// A list of UDIDs of provisioned devices.
        /// </summary>
        /// <value>A list of UDIDs of provisioned devices.</value>
        [DataMember(Name="udids", EmitDefaultValue=false)]
        public List<string> Udids { get; set; }

        /// <summary>
        /// A provisioning profile URL that indicates where to download it from.
        /// </summary>
        /// <value>A provisioning profile URL that indicates where to download it from.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvisioningProfileMigration {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  TeamIdentifier: ").Append(TeamIdentifier).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsAppex: ").Append(IsAppex).Append("\n");
            sb.Append("  ExpiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  Udids: ").Append(Udids).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ProvisioningProfileMigration);
        }

        /// <summary>
        /// Returns true if ProvisioningProfileMigration instances are equal
        /// </summary>
        /// <param name="input">Instance of ProvisioningProfileMigration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProvisioningProfileMigration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.TeamIdentifier == input.TeamIdentifier ||
                    (this.TeamIdentifier != null &&
                    this.TeamIdentifier.Equals(input.TeamIdentifier))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsAppex == input.IsAppex ||
                    (this.IsAppex != null &&
                    this.IsAppex.Equals(input.IsAppex))
                ) && 
                (
                    this.ExpiredAt == input.ExpiredAt ||
                    (this.ExpiredAt != null &&
                    this.ExpiredAt.Equals(input.ExpiredAt))
                ) && 
                (
                    this.Udids == input.Udids ||
                    this.Udids != null &&
                    input.Udids != null &&
                    this.Udids.SequenceEqual(input.Udids)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BundleId != null)
                    hashCode = hashCode * 59 + this.BundleId.GetHashCode();
                if (this.TeamIdentifier != null)
                    hashCode = hashCode * 59 + this.TeamIdentifier.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsAppex != null)
                    hashCode = hashCode * 59 + this.IsAppex.GetHashCode();
                if (this.ExpiredAt != null)
                    hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
                if (this.Udids != null)
                    hashCode = hashCode * 59 + this.Udids.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
