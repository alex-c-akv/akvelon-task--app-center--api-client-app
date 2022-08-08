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
    /// Status Data from store
    /// </summary>
    [DataContract]
        public partial class ReleaseRealTimeStatusResponseStatus :  IEquatable<ReleaseRealTimeStatusResponseStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseRealTimeStatusResponseStatus" /> class.
        /// </summary>
        /// <param name="status">status from store.</param>
        /// <param name="storetype">store type.</param>
        /// <param name="track">track information from store.</param>
        /// <param name="version">version of the app from store.</param>
        public ReleaseRealTimeStatusResponseStatus(string status = default(string), string storetype = default(string), string track = default(string), string version = default(string))
        {
            this.Status = status;
            this.Storetype = storetype;
            this.Track = track;
            this.Version = version;
        }
        
        /// <summary>
        /// status from store
        /// </summary>
        /// <value>status from store</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// store type
        /// </summary>
        /// <value>store type</value>
        [DataMember(Name="storetype", EmitDefaultValue=false)]
        public string Storetype { get; set; }

        /// <summary>
        /// track information from store
        /// </summary>
        /// <value>track information from store</value>
        [DataMember(Name="track", EmitDefaultValue=false)]
        public string Track { get; set; }

        /// <summary>
        /// version of the app from store
        /// </summary>
        /// <value>version of the app from store</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseRealTimeStatusResponseStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Storetype: ").Append(Storetype).Append("\n");
            sb.Append("  Track: ").Append(Track).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as ReleaseRealTimeStatusResponseStatus);
        }

        /// <summary>
        /// Returns true if ReleaseRealTimeStatusResponseStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseRealTimeStatusResponseStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseRealTimeStatusResponseStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Storetype == input.Storetype ||
                    (this.Storetype != null &&
                    this.Storetype.Equals(input.Storetype))
                ) && 
                (
                    this.Track == input.Track ||
                    (this.Track != null &&
                    this.Track.Equals(input.Track))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Storetype != null)
                    hashCode = hashCode * 59 + this.Storetype.GetHashCode();
                if (this.Track != null)
                    hashCode = hashCode * 59 + this.Track.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
