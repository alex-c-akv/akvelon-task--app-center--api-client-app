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
    /// Destination
    /// </summary>
    [DataContract]
        public partial class Destination :  IEquatable<Destination>, IValidatableObject
    {
        /// <summary>
        /// Destination can be either store or group.
        /// </summary>
        /// <value>Destination can be either store or group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DestinationTypeEnum
        {
            /// <summary>
            /// Enum Group for value: group
            /// </summary>
            [EnumMember(Value = "group")]
            Group = 1,
            /// <summary>
            /// Enum Store for value: store
            /// </summary>
            [EnumMember(Value = "store")]
            Store = 2,
            /// <summary>
            /// Enum Tester for value: tester
            /// </summary>
            [EnumMember(Value = "tester")]
            Tester = 3        }
        /// <summary>
        /// Destination can be either store or group.
        /// </summary>
        /// <value>Destination can be either store or group.</value>
        [DataMember(Name="destination_type", EmitDefaultValue=false)]
        public DestinationTypeEnum? DestinationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Destination" /> class.
        /// </summary>
        /// <param name="isLatest">Is the containing release the latest one in this distribution store..</param>
        /// <param name="name">Name of a distribution group / distribution store. The release will be associated with this distribution group or store. If the distribution group / store doesn&#x27;t exist a 400 is returned. If both distribution group / store name and id are passed, the id is taking precedence..</param>
        /// <param name="id">Id of a distribution group / store. The release will be associated with this distribution group / store. If the distribution group / store doesn&#x27;t exist a 400 is returned. If both distribution group / store name and id are passed, the id is taking precedence..</param>
        /// <param name="destinationType">Destination can be either store or group..</param>
        /// <param name="displayName">Display name for the group or tester.</param>
        public Destination(bool? isLatest = default(bool?), string name = default(string), string id = default(string), DestinationTypeEnum? destinationType = default(DestinationTypeEnum?), string displayName = default(string))
        {
            this.IsLatest = isLatest;
            this.Name = name;
            this.Id = id;
            this.DestinationType = destinationType;
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// Is the containing release the latest one in this distribution store.
        /// </summary>
        /// <value>Is the containing release the latest one in this distribution store.</value>
        [DataMember(Name="is_latest", EmitDefaultValue=false)]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// Name of a distribution group / distribution store. The release will be associated with this distribution group or store. If the distribution group / store doesn&#x27;t exist a 400 is returned. If both distribution group / store name and id are passed, the id is taking precedence.
        /// </summary>
        /// <value>Name of a distribution group / distribution store. The release will be associated with this distribution group or store. If the distribution group / store doesn&#x27;t exist a 400 is returned. If both distribution group / store name and id are passed, the id is taking precedence.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Id of a distribution group / store. The release will be associated with this distribution group / store. If the distribution group / store doesn&#x27;t exist a 400 is returned. If both distribution group / store name and id are passed, the id is taking precedence.
        /// </summary>
        /// <value>Id of a distribution group / store. The release will be associated with this distribution group / store. If the distribution group / store doesn&#x27;t exist a 400 is returned. If both distribution group / store name and id are passed, the id is taking precedence.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Display name for the group or tester
        /// </summary>
        /// <value>Display name for the group or tester</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Destination {\n");
            sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as Destination);
        }

        /// <summary>
        /// Returns true if Destination instances are equal
        /// </summary>
        /// <param name="input">Instance of Destination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Destination input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsLatest == input.IsLatest ||
                    (this.IsLatest != null &&
                    this.IsLatest.Equals(input.IsLatest))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.IsLatest != null)
                    hashCode = hashCode * 59 + this.IsLatest.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
