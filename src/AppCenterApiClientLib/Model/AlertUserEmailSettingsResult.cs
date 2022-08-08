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
    /// Alerting Default Email Settings of the user
    /// </summary>
    [DataContract]
        public partial class AlertUserEmailSettingsResult :  IEquatable<AlertUserEmailSettingsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertUserEmailSettingsResult" /> class.
        /// </summary>
        /// <param name="eTag">The ETag of the entity.</param>
        /// <param name="enabled">Allows to forcefully disable emails on app or user level (required).</param>
        /// <param name="userId">The unique id (UUID) of the user.</param>
        /// <param name="settings">The settings the user has for the app (required).</param>
        public AlertUserEmailSettingsResult(string eTag = default(string), bool? enabled = default(bool?), string userId = default(string), List<AlertEmailSettingsSettings> settings = default(List<AlertEmailSettingsSettings>))
        {
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for AlertUserEmailSettingsResult and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new InvalidDataException("settings is a required property for AlertUserEmailSettingsResult and cannot be null");
            }
            else
            {
                this.Settings = settings;
            }
            this.ETag = eTag;
            this.UserId = userId;
        }
        
        /// <summary>
        /// The ETag of the entity
        /// </summary>
        /// <value>The ETag of the entity</value>
        [DataMember(Name="eTag", EmitDefaultValue=false)]
        public string ETag { get; set; }

        /// <summary>
        /// Allows to forcefully disable emails on app or user level
        /// </summary>
        /// <value>Allows to forcefully disable emails on app or user level</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The unique id (UUID) of the user
        /// </summary>
        /// <value>The unique id (UUID) of the user</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The settings the user has for the app
        /// </summary>
        /// <value>The settings the user has for the app</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public List<AlertEmailSettingsSettings> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertUserEmailSettingsResult {\n");
            sb.Append("  ETag: ").Append(ETag).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as AlertUserEmailSettingsResult);
        }

        /// <summary>
        /// Returns true if AlertUserEmailSettingsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertUserEmailSettingsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertUserEmailSettingsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ETag == input.ETag ||
                    (this.ETag != null &&
                    this.ETag.Equals(input.ETag))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
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
                if (this.ETag != null)
                    hashCode = hashCode * 59 + this.ETag.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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
