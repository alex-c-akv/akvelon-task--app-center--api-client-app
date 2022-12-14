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
    /// Configuration for export to Blob Storage with customer linked subscription.
    /// </summary>
    [DataContract]
        public partial class ExportConfigurationBlobStorageLinkedSubscription :  IEquatable<ExportConfigurationBlobStorageLinkedSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportConfigurationBlobStorageLinkedSubscription" /> class.
        /// </summary>
        /// <param name="subscriptionId">Id of customer subscription linked in App Center.</param>
        public ExportConfigurationBlobStorageLinkedSubscription(string subscriptionId = default(string))
        {
            this.SubscriptionId = subscriptionId;
        }
        
        /// <summary>
        /// Id of customer subscription linked in App Center
        /// </summary>
        /// <value>Id of customer subscription linked in App Center</value>
        [DataMember(Name="subscription_id", EmitDefaultValue=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportConfigurationBlobStorageLinkedSubscription {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
            return this.Equals(input as ExportConfigurationBlobStorageLinkedSubscription);
        }

        /// <summary>
        /// Returns true if ExportConfigurationBlobStorageLinkedSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportConfigurationBlobStorageLinkedSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportConfigurationBlobStorageLinkedSubscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
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
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
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
