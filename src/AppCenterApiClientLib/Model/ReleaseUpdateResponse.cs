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
    /// Response for updating a release
    /// </summary>
    [DataContract]
        public partial class ReleaseUpdateResponse :  IEquatable<ReleaseUpdateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseUpdateResponse" /> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="mandatoryUpdate">mandatoryUpdate.</param>
        /// <param name="releaseNotes">releaseNotes.</param>
        /// <param name="provisioningStatusUrl">provisioningStatusUrl.</param>
        /// <param name="destinations">destinations.</param>
        public ReleaseUpdateResponse(bool? enabled = default(bool?), bool? mandatoryUpdate = default(bool?), string releaseNotes = default(string), string provisioningStatusUrl = default(string), List<ReleaseUpdateResponseDestinations> destinations = default(List<ReleaseUpdateResponseDestinations>))
        {
            this.Enabled = enabled;
            this.MandatoryUpdate = mandatoryUpdate;
            this.ReleaseNotes = releaseNotes;
            this.ProvisioningStatusUrl = provisioningStatusUrl;
            this.Destinations = destinations;
        }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets MandatoryUpdate
        /// </summary>
        [DataMember(Name="mandatory_update", EmitDefaultValue=false)]
        public bool? MandatoryUpdate { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseNotes
        /// </summary>
        [DataMember(Name="release_notes", EmitDefaultValue=false)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Gets or Sets ProvisioningStatusUrl
        /// </summary>
        [DataMember(Name="provisioning_status_url", EmitDefaultValue=false)]
        public string ProvisioningStatusUrl { get; set; }

        /// <summary>
        /// Gets or Sets Destinations
        /// </summary>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<ReleaseUpdateResponseDestinations> Destinations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseUpdateResponse {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MandatoryUpdate: ").Append(MandatoryUpdate).Append("\n");
            sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
            sb.Append("  ProvisioningStatusUrl: ").Append(ProvisioningStatusUrl).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
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
            return this.Equals(input as ReleaseUpdateResponse);
        }

        /// <summary>
        /// Returns true if ReleaseUpdateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseUpdateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.MandatoryUpdate == input.MandatoryUpdate ||
                    (this.MandatoryUpdate != null &&
                    this.MandatoryUpdate.Equals(input.MandatoryUpdate))
                ) && 
                (
                    this.ReleaseNotes == input.ReleaseNotes ||
                    (this.ReleaseNotes != null &&
                    this.ReleaseNotes.Equals(input.ReleaseNotes))
                ) && 
                (
                    this.ProvisioningStatusUrl == input.ProvisioningStatusUrl ||
                    (this.ProvisioningStatusUrl != null &&
                    this.ProvisioningStatusUrl.Equals(input.ProvisioningStatusUrl))
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.MandatoryUpdate != null)
                    hashCode = hashCode * 59 + this.MandatoryUpdate.GetHashCode();
                if (this.ReleaseNotes != null)
                    hashCode = hashCode * 59 + this.ReleaseNotes.GetHashCode();
                if (this.ProvisioningStatusUrl != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatusUrl.GetHashCode();
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
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
