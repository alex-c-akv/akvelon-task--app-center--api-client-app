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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AppCenterApiClientLib.Client.SwaggerDateConverter;

namespace AppCenterApiClientLib.Model
{
    /// <summary>
    /// LogDiagnostics
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
        public partial class LogDiagnostics :  IEquatable<LogDiagnostics>, IValidatableObject
    {
        /// <summary>
        /// Log type. 
        /// </summary>
        /// <value>Log type. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Event for value: event
            /// </summary>
            [EnumMember(Value = "event")]
            Event = 1,
            /// <summary>
            /// Enum Page for value: page
            /// </summary>
            [EnumMember(Value = "page")]
            Page = 2,
            /// <summary>
            /// Enum Startsession for value: start_session
            /// </summary>
            [EnumMember(Value = "start_session")]
            Startsession = 3,
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 4,
            /// <summary>
            /// Enum Pushinstallation for value: push_installation
            /// </summary>
            [EnumMember(Value = "push_installation")]
            Pushinstallation = 5,
            /// <summary>
            /// Enum Startservice for value: start_service
            /// </summary>
            [EnumMember(Value = "start_service")]
            Startservice = 6,
            /// <summary>
            /// Enum Customproperties for value: custom_properties
            /// </summary>
            [EnumMember(Value = "custom_properties")]
            Customproperties = 7        }
        /// <summary>
        /// Log type. 
        /// </summary>
        /// <value>Log type. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogDiagnostics" /> class.
        /// </summary>
        /// <param name="type">Log type.  (required).</param>
        /// <param name="timestamp">Log creation timestamp.  (required).</param>
        /// <param name="installId">Install ID.  (required).</param>
        /// <param name="device">device (required).</param>
        public LogDiagnostics(TypeEnum type = default(TypeEnum), DateTime? timestamp = default(DateTime?), Guid? installId = default(Guid?), LogContainerDevice device = default(LogContainerDevice))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LogDiagnostics and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for LogDiagnostics and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "installId" is required (not null)
            if (installId == null)
            {
                throw new InvalidDataException("installId is a required property for LogDiagnostics and cannot be null");
            }
            else
            {
                this.InstallId = installId;
            }
            // to ensure "device" is required (not null)
            if (device == null)
            {
                throw new InvalidDataException("device is a required property for LogDiagnostics and cannot be null");
            }
            else
            {
                this.Device = device;
            }
        }
        

        /// <summary>
        /// Log creation timestamp. 
        /// </summary>
        /// <value>Log creation timestamp. </value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Install ID. 
        /// </summary>
        /// <value>Install ID. </value>
        [DataMember(Name="install_id", EmitDefaultValue=false)]
        public Guid? InstallId { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public LogContainerDevice Device { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogDiagnostics {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  InstallId: ").Append(InstallId).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
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
            return this.Equals(input as LogDiagnostics);
        }

        /// <summary>
        /// Returns true if LogDiagnostics instances are equal
        /// </summary>
        /// <param name="input">Instance of LogDiagnostics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogDiagnostics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.InstallId == input.InstallId ||
                    (this.InstallId != null &&
                    this.InstallId.Equals(input.InstallId))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.InstallId != null)
                    hashCode = hashCode * 59 + this.InstallId.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
