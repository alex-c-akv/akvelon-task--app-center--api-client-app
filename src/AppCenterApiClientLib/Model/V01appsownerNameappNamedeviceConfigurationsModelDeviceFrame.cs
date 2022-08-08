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
    /// V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame
    /// </summary>
    [DataContract]
        public partial class V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame :  IEquatable<V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame" /> class.
        /// </summary>
        /// <param name="grid">grid.</param>
        /// <param name="full">full.</param>
        public V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame(V01appsownerNameappNamedeviceConfigurationsModelDeviceFrameGrid grid = default(V01appsownerNameappNamedeviceConfigurationsModelDeviceFrameGrid), V01appsownerNameappNamedeviceConfigurationsModelDeviceFrameGrid full = default(V01appsownerNameappNamedeviceConfigurationsModelDeviceFrameGrid))
        {
            this.Grid = grid;
            this.Full = full;
        }
        
        /// <summary>
        /// Gets or Sets Grid
        /// </summary>
        [DataMember(Name="grid", EmitDefaultValue=false)]
        public V01appsownerNameappNamedeviceConfigurationsModelDeviceFrameGrid Grid { get; set; }

        /// <summary>
        /// Gets or Sets Full
        /// </summary>
        [DataMember(Name="full", EmitDefaultValue=false)]
        public V01appsownerNameappNamedeviceConfigurationsModelDeviceFrameGrid Full { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame {\n");
            sb.Append("  Grid: ").Append(Grid).Append("\n");
            sb.Append("  Full: ").Append(Full).Append("\n");
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
            return this.Equals(input as V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame);
        }

        /// <summary>
        /// Returns true if V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame instances are equal
        /// </summary>
        /// <param name="input">Instance of V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01appsownerNameappNamedeviceConfigurationsModelDeviceFrame input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Grid == input.Grid ||
                    (this.Grid != null &&
                    this.Grid.Equals(input.Grid))
                ) && 
                (
                    this.Full == input.Full ||
                    (this.Full != null &&
                    this.Full.Equals(input.Full))
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
                if (this.Grid != null)
                    hashCode = hashCode * 59 + this.Grid.GetHashCode();
                if (this.Full != null)
                    hashCode = hashCode * 59 + this.Full.GetHashCode();
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
