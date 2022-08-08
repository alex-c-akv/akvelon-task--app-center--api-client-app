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
    /// LegacyAppListResponseApps
    /// </summary>
    [DataContract]
        public partial class LegacyAppListResponseApps :  IEquatable<LegacyAppListResponseApps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyAppListResponseApps" /> class.
        /// </summary>
        /// <param name="name">The app name..</param>
        /// <param name="collaborators">collaborators.</param>
        /// <param name="deployments">deployments.</param>
        public LegacyAppListResponseApps(string name = default(string), Dictionary<string, LegacyAppListResponseCollaborators> collaborators = default(Dictionary<string, LegacyAppListResponseCollaborators>), List<string> deployments = default(List<string>))
        {
            this.Name = name;
            this.Collaborators = collaborators;
            this.Deployments = deployments;
        }
        
        /// <summary>
        /// The app name.
        /// </summary>
        /// <value>The app name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Collaborators
        /// </summary>
        [DataMember(Name="collaborators", EmitDefaultValue=false)]
        public Dictionary<string, LegacyAppListResponseCollaborators> Collaborators { get; set; }

        /// <summary>
        /// Gets or Sets Deployments
        /// </summary>
        [DataMember(Name="deployments", EmitDefaultValue=false)]
        public List<string> Deployments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegacyAppListResponseApps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Collaborators: ").Append(Collaborators).Append("\n");
            sb.Append("  Deployments: ").Append(Deployments).Append("\n");
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
            return this.Equals(input as LegacyAppListResponseApps);
        }

        /// <summary>
        /// Returns true if LegacyAppListResponseApps instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyAppListResponseApps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyAppListResponseApps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Collaborators == input.Collaborators ||
                    this.Collaborators != null &&
                    input.Collaborators != null &&
                    this.Collaborators.SequenceEqual(input.Collaborators)
                ) && 
                (
                    this.Deployments == input.Deployments ||
                    this.Deployments != null &&
                    input.Deployments != null &&
                    this.Deployments.SequenceEqual(input.Deployments)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Collaborators != null)
                    hashCode = hashCode * 59 + this.Collaborators.GetHashCode();
                if (this.Deployments != null)
                    hashCode = hashCode * 59 + this.Deployments.GetHashCode();
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
