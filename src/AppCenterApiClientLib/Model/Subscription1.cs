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
    /// Subscription information
    /// </summary>
    [DataContract]
        public partial class Subscription1 :  IEquatable<Subscription1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription1" /> class.
        /// </summary>
        /// <param name="startsAt">The date the subscription began.</param>
        /// <param name="endsAt">The date the subscription will end or ended.</param>
        /// <param name="daysLeft">The number of days left in the subscription.</param>
        /// <param name="tier">tier.</param>
        /// <param name="active">Is the subscription currently active?.</param>
        /// <param name="id">Id of the subscription.</param>
        /// <param name="concurrentDevicesLimit">Customer limits on concurrent devices.</param>
        /// <param name="runningDevices">Current device concurrency utilization.</param>
        public Subscription1(string startsAt = default(string), string endsAt = default(string), decimal? daysLeft = default(decimal?), SubscriptionTier tier = default(SubscriptionTier), bool? active = default(bool?), Guid? id = default(Guid?), int? concurrentDevicesLimit = default(int?), int? runningDevices = default(int?))
        {
            this.StartsAt = startsAt;
            this.EndsAt = endsAt;
            this.DaysLeft = daysLeft;
            this.Tier = tier;
            this.Active = active;
            this.Id = id;
            this.ConcurrentDevicesLimit = concurrentDevicesLimit;
            this.RunningDevices = runningDevices;
        }
        
        /// <summary>
        /// The date the subscription began
        /// </summary>
        /// <value>The date the subscription began</value>
        [DataMember(Name="startsAt", EmitDefaultValue=false)]
        public string StartsAt { get; set; }

        /// <summary>
        /// The date the subscription will end or ended
        /// </summary>
        /// <value>The date the subscription will end or ended</value>
        [DataMember(Name="endsAt", EmitDefaultValue=false)]
        public string EndsAt { get; set; }

        /// <summary>
        /// The number of days left in the subscription
        /// </summary>
        /// <value>The number of days left in the subscription</value>
        [DataMember(Name="daysLeft", EmitDefaultValue=false)]
        public decimal? DaysLeft { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public SubscriptionTier Tier { get; set; }

        /// <summary>
        /// Is the subscription currently active?
        /// </summary>
        /// <value>Is the subscription currently active?</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Id of the subscription
        /// </summary>
        /// <value>Id of the subscription</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Customer limits on concurrent devices
        /// </summary>
        /// <value>Customer limits on concurrent devices</value>
        [DataMember(Name="concurrentDevicesLimit", EmitDefaultValue=false)]
        public int? ConcurrentDevicesLimit { get; set; }

        /// <summary>
        /// Current device concurrency utilization
        /// </summary>
        /// <value>Current device concurrency utilization</value>
        [DataMember(Name="runningDevices", EmitDefaultValue=false)]
        public int? RunningDevices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription1 {\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  EndsAt: ").Append(EndsAt).Append("\n");
            sb.Append("  DaysLeft: ").Append(DaysLeft).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConcurrentDevicesLimit: ").Append(ConcurrentDevicesLimit).Append("\n");
            sb.Append("  RunningDevices: ").Append(RunningDevices).Append("\n");
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
            return this.Equals(input as Subscription1);
        }

        /// <summary>
        /// Returns true if Subscription1 instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscription1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartsAt == input.StartsAt ||
                    (this.StartsAt != null &&
                    this.StartsAt.Equals(input.StartsAt))
                ) && 
                (
                    this.EndsAt == input.EndsAt ||
                    (this.EndsAt != null &&
                    this.EndsAt.Equals(input.EndsAt))
                ) && 
                (
                    this.DaysLeft == input.DaysLeft ||
                    (this.DaysLeft != null &&
                    this.DaysLeft.Equals(input.DaysLeft))
                ) && 
                (
                    this.Tier == input.Tier ||
                    (this.Tier != null &&
                    this.Tier.Equals(input.Tier))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ConcurrentDevicesLimit == input.ConcurrentDevicesLimit ||
                    (this.ConcurrentDevicesLimit != null &&
                    this.ConcurrentDevicesLimit.Equals(input.ConcurrentDevicesLimit))
                ) && 
                (
                    this.RunningDevices == input.RunningDevices ||
                    (this.RunningDevices != null &&
                    this.RunningDevices.Equals(input.RunningDevices))
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
                if (this.StartsAt != null)
                    hashCode = hashCode * 59 + this.StartsAt.GetHashCode();
                if (this.EndsAt != null)
                    hashCode = hashCode * 59 + this.EndsAt.GetHashCode();
                if (this.DaysLeft != null)
                    hashCode = hashCode * 59 + this.DaysLeft.GetHashCode();
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ConcurrentDevicesLimit != null)
                    hashCode = hashCode * 59 + this.ConcurrentDevicesLimit.GetHashCode();
                if (this.RunningDevices != null)
                    hashCode = hashCode * 59 + this.RunningDevices.GetHashCode();
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
