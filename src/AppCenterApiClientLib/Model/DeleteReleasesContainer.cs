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
    /// DeleteReleasesContainer
    /// </summary>
    [DataContract]
        public partial class DeleteReleasesContainer :  IEquatable<DeleteReleasesContainer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteReleasesContainer" /> class.
        /// </summary>
        /// <param name="releases">releases (required).</param>
        public DeleteReleasesContainer(List<DeleteReleasesContainerReleases> releases = default(List<DeleteReleasesContainerReleases>))
        {
            // to ensure "releases" is required (not null)
            if (releases == null)
            {
                throw new InvalidDataException("releases is a required property for DeleteReleasesContainer and cannot be null");
            }
            else
            {
                this.Releases = releases;
            }
        }
        
        /// <summary>
        /// Gets or Sets Releases
        /// </summary>
        [DataMember(Name="releases", EmitDefaultValue=false)]
        public List<DeleteReleasesContainerReleases> Releases { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteReleasesContainer {\n");
            sb.Append("  Releases: ").Append(Releases).Append("\n");
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
            return this.Equals(input as DeleteReleasesContainer);
        }

        /// <summary>
        /// Returns true if DeleteReleasesContainer instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteReleasesContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteReleasesContainer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Releases == input.Releases ||
                    this.Releases != null &&
                    input.Releases != null &&
                    this.Releases.SequenceEqual(input.Releases)
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
                if (this.Releases != null)
                    hashCode = hashCode * 59 + this.Releases.GetHashCode();
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
