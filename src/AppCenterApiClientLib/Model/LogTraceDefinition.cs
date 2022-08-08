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
    /// LogTraceDefinition
    /// </summary>
    [DataContract]
        public partial class LogTraceDefinition :  IEquatable<LogTraceDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogTraceDefinition" /> class.
        /// </summary>
        /// <param name="appSecret">appSecret (required).</param>
        /// <param name="installId">installId.</param>
        /// <param name="expiration">expiration.</param>
        public LogTraceDefinition(string appSecret = default(string), string installId = default(string), DateTime? expiration = default(DateTime?))
        {
            // to ensure "appSecret" is required (not null)
            if (appSecret == null)
            {
                throw new InvalidDataException("appSecret is a required property for LogTraceDefinition and cannot be null");
            }
            else
            {
                this.AppSecret = appSecret;
            }
            this.InstallId = installId;
            this.Expiration = expiration;
        }
        
        /// <summary>
        /// Gets or Sets AppSecret
        /// </summary>
        [DataMember(Name="app_secret", EmitDefaultValue=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// Gets or Sets InstallId
        /// </summary>
        [DataMember(Name="install_id", EmitDefaultValue=false)]
        public string InstallId { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogTraceDefinition {\n");
            sb.Append("  AppSecret: ").Append(AppSecret).Append("\n");
            sb.Append("  InstallId: ").Append(InstallId).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(input as LogTraceDefinition);
        }

        /// <summary>
        /// Returns true if LogTraceDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of LogTraceDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogTraceDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppSecret == input.AppSecret ||
                    (this.AppSecret != null &&
                    this.AppSecret.Equals(input.AppSecret))
                ) && 
                (
                    this.InstallId == input.InstallId ||
                    (this.InstallId != null &&
                    this.InstallId.Equals(input.InstallId))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
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
                if (this.AppSecret != null)
                    hashCode = hashCode * 59 + this.AppSecret.GetHashCode();
                if (this.InstallId != null)
                    hashCode = hashCode * 59 + this.InstallId.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
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