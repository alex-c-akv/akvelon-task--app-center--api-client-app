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
    /// InlineResponse20076
    /// </summary>
    [DataContract]
        public partial class InlineResponse20076 :  IEquatable<InlineResponse20076>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20076" /> class.
        /// </summary>
        /// <param name="averageSessionsPerUser">Average seesion per user..</param>
        /// <param name="previousAverageSessionsPerUser">Previous average session per user..</param>
        /// <param name="totalCount">Total session per device count..</param>
        /// <param name="previousTotalCount">Previous total count..</param>
        /// <param name="sessionsPerUser">The session count for each interval per device..</param>
        public InlineResponse20076(double? averageSessionsPerUser = default(double?), double? previousAverageSessionsPerUser = default(double?), long? totalCount = default(long?), long? previousTotalCount = default(long?), List<SessionsPerDeviceSessionsPerUser> sessionsPerUser = default(List<SessionsPerDeviceSessionsPerUser>))
        {
            this.AverageSessionsPerUser = averageSessionsPerUser;
            this.PreviousAverageSessionsPerUser = previousAverageSessionsPerUser;
            this.TotalCount = totalCount;
            this.PreviousTotalCount = previousTotalCount;
            this.SessionsPerUser = sessionsPerUser;
        }
        
        /// <summary>
        /// Average seesion per user.
        /// </summary>
        /// <value>Average seesion per user.</value>
        [DataMember(Name="average_sessions_per_user", EmitDefaultValue=false)]
        public double? AverageSessionsPerUser { get; set; }

        /// <summary>
        /// Previous average session per user.
        /// </summary>
        /// <value>Previous average session per user.</value>
        [DataMember(Name="previous_average_sessions_per_user", EmitDefaultValue=false)]
        public double? PreviousAverageSessionsPerUser { get; set; }

        /// <summary>
        /// Total session per device count.
        /// </summary>
        /// <value>Total session per device count.</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// Previous total count.
        /// </summary>
        /// <value>Previous total count.</value>
        [DataMember(Name="previous_total_count", EmitDefaultValue=false)]
        public long? PreviousTotalCount { get; set; }

        /// <summary>
        /// The session count for each interval per device.
        /// </summary>
        /// <value>The session count for each interval per device.</value>
        [DataMember(Name="sessions_per_user", EmitDefaultValue=false)]
        public List<SessionsPerDeviceSessionsPerUser> SessionsPerUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20076 {\n");
            sb.Append("  AverageSessionsPerUser: ").Append(AverageSessionsPerUser).Append("\n");
            sb.Append("  PreviousAverageSessionsPerUser: ").Append(PreviousAverageSessionsPerUser).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  PreviousTotalCount: ").Append(PreviousTotalCount).Append("\n");
            sb.Append("  SessionsPerUser: ").Append(SessionsPerUser).Append("\n");
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
            return this.Equals(input as InlineResponse20076);
        }

        /// <summary>
        /// Returns true if InlineResponse20076 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20076 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20076 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AverageSessionsPerUser == input.AverageSessionsPerUser ||
                    (this.AverageSessionsPerUser != null &&
                    this.AverageSessionsPerUser.Equals(input.AverageSessionsPerUser))
                ) && 
                (
                    this.PreviousAverageSessionsPerUser == input.PreviousAverageSessionsPerUser ||
                    (this.PreviousAverageSessionsPerUser != null &&
                    this.PreviousAverageSessionsPerUser.Equals(input.PreviousAverageSessionsPerUser))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.PreviousTotalCount == input.PreviousTotalCount ||
                    (this.PreviousTotalCount != null &&
                    this.PreviousTotalCount.Equals(input.PreviousTotalCount))
                ) && 
                (
                    this.SessionsPerUser == input.SessionsPerUser ||
                    this.SessionsPerUser != null &&
                    input.SessionsPerUser != null &&
                    this.SessionsPerUser.SequenceEqual(input.SessionsPerUser)
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
                if (this.AverageSessionsPerUser != null)
                    hashCode = hashCode * 59 + this.AverageSessionsPerUser.GetHashCode();
                if (this.PreviousAverageSessionsPerUser != null)
                    hashCode = hashCode * 59 + this.PreviousAverageSessionsPerUser.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.PreviousTotalCount != null)
                    hashCode = hashCode * 59 + this.PreviousTotalCount.GetHashCode();
                if (this.SessionsPerUser != null)
                    hashCode = hashCode * 59 + this.SessionsPerUser.GetHashCode();
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
