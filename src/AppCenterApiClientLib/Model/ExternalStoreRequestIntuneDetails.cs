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
    /// ExternalStoreRequestIntuneDetails
    /// </summary>
    [DataContract]
        public partial class ExternalStoreRequestIntuneDetails :  IEquatable<ExternalStoreRequestIntuneDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStoreRequestIntuneDetails" /> class.
        /// </summary>
        /// <param name="secretJson">secretJson.</param>
        /// <param name="targetAudience">targetAudience.</param>
        /// <param name="appCategory">appCategory.</param>
        /// <param name="tenantId">tenant id of the intune store.</param>
        public ExternalStoreRequestIntuneDetails(V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson secretJson = default(V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson), V01appsownerNameappNamedistributionStoresIntuneDetails1TargetAudience targetAudience = default(V01appsownerNameappNamedistributionStoresIntuneDetails1TargetAudience), V01appsownerNameappNamedistributionStoresIntuneDetails1AppCategory appCategory = default(V01appsownerNameappNamedistributionStoresIntuneDetails1AppCategory), string tenantId = default(string))
        {
            this.SecretJson = secretJson;
            this.TargetAudience = targetAudience;
            this.AppCategory = appCategory;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Gets or Sets SecretJson
        /// </summary>
        [DataMember(Name="secret_json", EmitDefaultValue=false)]
        public V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson SecretJson { get; set; }

        /// <summary>
        /// Gets or Sets TargetAudience
        /// </summary>
        [DataMember(Name="target_audience", EmitDefaultValue=false)]
        public V01appsownerNameappNamedistributionStoresIntuneDetails1TargetAudience TargetAudience { get; set; }

        /// <summary>
        /// Gets or Sets AppCategory
        /// </summary>
        [DataMember(Name="app_category", EmitDefaultValue=false)]
        public V01appsownerNameappNamedistributionStoresIntuneDetails1AppCategory AppCategory { get; set; }

        /// <summary>
        /// tenant id of the intune store
        /// </summary>
        /// <value>tenant id of the intune store</value>
        [DataMember(Name="tenant_id", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalStoreRequestIntuneDetails {\n");
            sb.Append("  SecretJson: ").Append(SecretJson).Append("\n");
            sb.Append("  TargetAudience: ").Append(TargetAudience).Append("\n");
            sb.Append("  AppCategory: ").Append(AppCategory).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as ExternalStoreRequestIntuneDetails);
        }

        /// <summary>
        /// Returns true if ExternalStoreRequestIntuneDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalStoreRequestIntuneDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalStoreRequestIntuneDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecretJson == input.SecretJson ||
                    (this.SecretJson != null &&
                    this.SecretJson.Equals(input.SecretJson))
                ) && 
                (
                    this.TargetAudience == input.TargetAudience ||
                    (this.TargetAudience != null &&
                    this.TargetAudience.Equals(input.TargetAudience))
                ) && 
                (
                    this.AppCategory == input.AppCategory ||
                    (this.AppCategory != null &&
                    this.AppCategory.Equals(input.AppCategory))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.SecretJson != null)
                    hashCode = hashCode * 59 + this.SecretJson.GetHashCode();
                if (this.TargetAudience != null)
                    hashCode = hashCode * 59 + this.TargetAudience.GetHashCode();
                if (this.AppCategory != null)
                    hashCode = hashCode * 59 + this.AppCategory.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
