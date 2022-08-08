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
    /// OrgDistributionGroupDetailsResponse
    /// </summary>
    [DataContract]
        public partial class OrgDistributionGroupDetailsResponse :  IEquatable<OrgDistributionGroupDetailsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgDistributionGroupDetailsResponse" /> class.
        /// </summary>
        /// <param name="totalAppsCount">The count of apps associated with this distribution group.</param>
        /// <param name="totalUsersCount">The count of users in the distribution group.</param>
        /// <param name="apps">The apps associated with the distribution group.</param>
        public OrgDistributionGroupDetailsResponse(decimal? totalAppsCount = default(decimal?), decimal? totalUsersCount = default(decimal?), List<Object> apps = default(List<Object>))
        {
            this.TotalAppsCount = totalAppsCount;
            this.TotalUsersCount = totalUsersCount;
            this.Apps = apps;
        }
        
        /// <summary>
        /// The count of apps associated with this distribution group
        /// </summary>
        /// <value>The count of apps associated with this distribution group</value>
        [DataMember(Name="total_apps_count", EmitDefaultValue=false)]
        public decimal? TotalAppsCount { get; set; }

        /// <summary>
        /// The count of users in the distribution group
        /// </summary>
        /// <value>The count of users in the distribution group</value>
        [DataMember(Name="total_users_count", EmitDefaultValue=false)]
        public decimal? TotalUsersCount { get; set; }

        /// <summary>
        /// The apps associated with the distribution group
        /// </summary>
        /// <value>The apps associated with the distribution group</value>
        [DataMember(Name="apps", EmitDefaultValue=false)]
        public List<Object> Apps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgDistributionGroupDetailsResponse {\n");
            sb.Append("  TotalAppsCount: ").Append(TotalAppsCount).Append("\n");
            sb.Append("  TotalUsersCount: ").Append(TotalUsersCount).Append("\n");
            sb.Append("  Apps: ").Append(Apps).Append("\n");
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
            return this.Equals(input as OrgDistributionGroupDetailsResponse);
        }

        /// <summary>
        /// Returns true if OrgDistributionGroupDetailsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrgDistributionGroupDetailsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgDistributionGroupDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalAppsCount == input.TotalAppsCount ||
                    (this.TotalAppsCount != null &&
                    this.TotalAppsCount.Equals(input.TotalAppsCount))
                ) && 
                (
                    this.TotalUsersCount == input.TotalUsersCount ||
                    (this.TotalUsersCount != null &&
                    this.TotalUsersCount.Equals(input.TotalUsersCount))
                ) && 
                (
                    this.Apps == input.Apps ||
                    this.Apps != null &&
                    input.Apps != null &&
                    this.Apps.SequenceEqual(input.Apps)
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
                if (this.TotalAppsCount != null)
                    hashCode = hashCode * 59 + this.TotalAppsCount.GetHashCode();
                if (this.TotalUsersCount != null)
                    hashCode = hashCode * 59 + this.TotalUsersCount.GetHashCode();
                if (this.Apps != null)
                    hashCode = hashCode * 59 + this.Apps.GetHashCode();
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