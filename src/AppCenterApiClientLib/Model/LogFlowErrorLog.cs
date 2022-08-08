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
    /// Error log.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
        public partial class LogFlowErrorLog :  IEquatable<LogFlowErrorLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogFlowErrorLog" /> class.
        /// </summary>
        /// <param name="sessionId">Session ID. .</param>
        /// <param name="id">Error identifier..</param>
        /// <param name="appLaunchToffset">Corresponds to the number of milliseconds elapsed between the time the error occurred and the app was launched. .</param>
        public LogFlowErrorLog(Guid? sessionId = default(Guid?), Guid? id = default(Guid?), long? appLaunchToffset = default(long?))
        {
            this.SessionId = sessionId;
            this.Id = id;
            this.AppLaunchToffset = appLaunchToffset;
        }
        
        /// <summary>
        /// Session ID. 
        /// </summary>
        /// <value>Session ID. </value>
        [DataMember(Name="session_id", EmitDefaultValue=false)]
        public Guid? SessionId { get; set; }

        /// <summary>
        /// Error identifier.
        /// </summary>
        /// <value>Error identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Corresponds to the number of milliseconds elapsed between the time the error occurred and the app was launched. 
        /// </summary>
        /// <value>Corresponds to the number of milliseconds elapsed between the time the error occurred and the app was launched. </value>
        [DataMember(Name="app_launch_toffset", EmitDefaultValue=false)]
        public long? AppLaunchToffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogFlowErrorLog {\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AppLaunchToffset: ").Append(AppLaunchToffset).Append("\n");
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
            return this.Equals(input as LogFlowErrorLog);
        }

        /// <summary>
        /// Returns true if LogFlowErrorLog instances are equal
        /// </summary>
        /// <param name="input">Instance of LogFlowErrorLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogFlowErrorLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AppLaunchToffset == input.AppLaunchToffset ||
                    (this.AppLaunchToffset != null &&
                    this.AppLaunchToffset.Equals(input.AppLaunchToffset))
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
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AppLaunchToffset != null)
                    hashCode = hashCode * 59 + this.AppLaunchToffset.GetHashCode();
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
