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
    /// GenericLogContainerDiagnostics
    /// </summary>
    [DataContract]
        public partial class GenericLogContainerDiagnostics :  IEquatable<GenericLogContainerDiagnostics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericLogContainerDiagnostics" /> class.
        /// </summary>
        /// <param name="exceededMaxLimit">indicates if the number of available logs are more than the max allowed return limit(100)..</param>
        /// <param name="lastReceivedLogTimestamp">the timestamp of the last log received. This value can be used as the start time parameter in the consecutive API call..</param>
        /// <param name="logs">the list of logs (required).</param>
        public GenericLogContainerDiagnostics(bool? exceededMaxLimit = default(bool?), DateTime? lastReceivedLogTimestamp = default(DateTime?), List<GenericLogContainerDiagnosticsLogs> logs = default(List<GenericLogContainerDiagnosticsLogs>))
        {
            // to ensure "logs" is required (not null)
            if (logs == null)
            {
                throw new InvalidDataException("logs is a required property for GenericLogContainerDiagnostics and cannot be null");
            }
            else
            {
                this.Logs = logs;
            }
            this.ExceededMaxLimit = exceededMaxLimit;
            this.LastReceivedLogTimestamp = lastReceivedLogTimestamp;
        }
        
        /// <summary>
        /// indicates if the number of available logs are more than the max allowed return limit(100).
        /// </summary>
        /// <value>indicates if the number of available logs are more than the max allowed return limit(100).</value>
        [DataMember(Name="exceeded_max_limit", EmitDefaultValue=false)]
        public bool? ExceededMaxLimit { get; set; }

        /// <summary>
        /// the timestamp of the last log received. This value can be used as the start time parameter in the consecutive API call.
        /// </summary>
        /// <value>the timestamp of the last log received. This value can be used as the start time parameter in the consecutive API call.</value>
        [DataMember(Name="last_received_log_timestamp", EmitDefaultValue=false)]
        public DateTime? LastReceivedLogTimestamp { get; set; }

        /// <summary>
        /// the list of logs
        /// </summary>
        /// <value>the list of logs</value>
        [DataMember(Name="logs", EmitDefaultValue=false)]
        public List<GenericLogContainerDiagnosticsLogs> Logs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericLogContainerDiagnostics {\n");
            sb.Append("  ExceededMaxLimit: ").Append(ExceededMaxLimit).Append("\n");
            sb.Append("  LastReceivedLogTimestamp: ").Append(LastReceivedLogTimestamp).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
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
            return this.Equals(input as GenericLogContainerDiagnostics);
        }

        /// <summary>
        /// Returns true if GenericLogContainerDiagnostics instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericLogContainerDiagnostics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericLogContainerDiagnostics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExceededMaxLimit == input.ExceededMaxLimit ||
                    (this.ExceededMaxLimit != null &&
                    this.ExceededMaxLimit.Equals(input.ExceededMaxLimit))
                ) && 
                (
                    this.LastReceivedLogTimestamp == input.LastReceivedLogTimestamp ||
                    (this.LastReceivedLogTimestamp != null &&
                    this.LastReceivedLogTimestamp.Equals(input.LastReceivedLogTimestamp))
                ) && 
                (
                    this.Logs == input.Logs ||
                    this.Logs != null &&
                    input.Logs != null &&
                    this.Logs.SequenceEqual(input.Logs)
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
                if (this.ExceededMaxLimit != null)
                    hashCode = hashCode * 59 + this.ExceededMaxLimit.GetHashCode();
                if (this.LastReceivedLogTimestamp != null)
                    hashCode = hashCode * 59 + this.LastReceivedLogTimestamp.GetHashCode();
                if (this.Logs != null)
                    hashCode = hashCode * 59 + this.Logs.GetHashCode();
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
