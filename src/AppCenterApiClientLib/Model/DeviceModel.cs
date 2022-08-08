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
    /// DeviceModel
    /// </summary>
    [DataContract]
        public partial class DeviceModel :  IEquatable<DeviceModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="model">model.</param>
        /// <param name="platform">platform.</param>
        /// <param name="dimensions">dimensions.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="releaseDate">releaseDate.</param>
        /// <param name="formFactor">formFactor.</param>
        /// <param name="screenSize">screenSize.</param>
        /// <param name="cpu">cpu.</param>
        /// <param name="memory">memory.</param>
        /// <param name="screenRotation">screenRotation.</param>
        /// <param name="deviceFrame">deviceFrame.</param>
        /// <param name="availabilityCount">availabilityCount.</param>
        public DeviceModel(string name = default(string), string manufacturer = default(string), string model = default(string), string platform = default(string), V01appsownerNameappNamedeviceConfigurationsModelDimensions dimensions = default(V01appsownerNameappNamedeviceConfigurationsModelDimensions), V01appsownerNameappNamedeviceConfigurationsModelResolution resolution = default(V01appsownerNameappNamedeviceConfigurationsModelResolution), string releaseDate = default(string), string formFactor = default(string), V01appsownerNameappNamedeviceConfigurationsModelScreenSize screenSize = default(V01appsownerNameappNamedeviceConfigurationsModelScreenSize), V01appsownerNameappNamedeviceConfigurationsModelCpu cpu = default(V01appsownerNameappNamedeviceConfigurationsModelCpu), V01appsownerNameappNamedeviceConfigurationsModelMemory memory = default(V01appsownerNameappNamedeviceConfigurationsModelMemory), decimal? screenRotation = default(decimal?), DeviceConfigurationModelDeviceFrame deviceFrame = default(DeviceConfigurationModelDeviceFrame), decimal? availabilityCount = default(decimal?))
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Platform = platform;
            this.Dimensions = dimensions;
            this.Resolution = resolution;
            this.ReleaseDate = releaseDate;
            this.FormFactor = formFactor;
            this.ScreenSize = screenSize;
            this.Cpu = cpu;
            this.Memory = memory;
            this.ScreenRotation = screenRotation;
            this.DeviceFrame = deviceFrame;
            this.AvailabilityCount = availabilityCount;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name="manufacturer", EmitDefaultValue=false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public V01appsownerNameappNamedeviceConfigurationsModelDimensions Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public V01appsownerNameappNamedeviceConfigurationsModelResolution Resolution { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseDate
        /// </summary>
        [DataMember(Name="releaseDate", EmitDefaultValue=false)]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Gets or Sets FormFactor
        /// </summary>
        [DataMember(Name="formFactor", EmitDefaultValue=false)]
        public string FormFactor { get; set; }

        /// <summary>
        /// Gets or Sets ScreenSize
        /// </summary>
        [DataMember(Name="screenSize", EmitDefaultValue=false)]
        public V01appsownerNameappNamedeviceConfigurationsModelScreenSize ScreenSize { get; set; }

        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name="cpu", EmitDefaultValue=false)]
        public V01appsownerNameappNamedeviceConfigurationsModelCpu Cpu { get; set; }

        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name="memory", EmitDefaultValue=false)]
        public V01appsownerNameappNamedeviceConfigurationsModelMemory Memory { get; set; }

        /// <summary>
        /// Gets or Sets ScreenRotation
        /// </summary>
        [DataMember(Name="screenRotation", EmitDefaultValue=false)]
        public decimal? ScreenRotation { get; set; }

        /// <summary>
        /// Gets or Sets DeviceFrame
        /// </summary>
        [DataMember(Name="deviceFrame", EmitDefaultValue=false)]
        public DeviceConfigurationModelDeviceFrame DeviceFrame { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityCount
        /// </summary>
        [DataMember(Name="availabilityCount", EmitDefaultValue=false)]
        public decimal? AvailabilityCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  FormFactor: ").Append(FormFactor).Append("\n");
            sb.Append("  ScreenSize: ").Append(ScreenSize).Append("\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  ScreenRotation: ").Append(ScreenRotation).Append("\n");
            sb.Append("  DeviceFrame: ").Append(DeviceFrame).Append("\n");
            sb.Append("  AvailabilityCount: ").Append(AvailabilityCount).Append("\n");
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
            return this.Equals(input as DeviceModel);
        }

        /// <summary>
        /// Returns true if DeviceModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceModel input)
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
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.ReleaseDate == input.ReleaseDate ||
                    (this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(input.ReleaseDate))
                ) && 
                (
                    this.FormFactor == input.FormFactor ||
                    (this.FormFactor != null &&
                    this.FormFactor.Equals(input.FormFactor))
                ) && 
                (
                    this.ScreenSize == input.ScreenSize ||
                    (this.ScreenSize != null &&
                    this.ScreenSize.Equals(input.ScreenSize))
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
                ) && 
                (
                    this.ScreenRotation == input.ScreenRotation ||
                    (this.ScreenRotation != null &&
                    this.ScreenRotation.Equals(input.ScreenRotation))
                ) && 
                (
                    this.DeviceFrame == input.DeviceFrame ||
                    (this.DeviceFrame != null &&
                    this.DeviceFrame.Equals(input.DeviceFrame))
                ) && 
                (
                    this.AvailabilityCount == input.AvailabilityCount ||
                    (this.AvailabilityCount != null &&
                    this.AvailabilityCount.Equals(input.AvailabilityCount))
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
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.ReleaseDate != null)
                    hashCode = hashCode * 59 + this.ReleaseDate.GetHashCode();
                if (this.FormFactor != null)
                    hashCode = hashCode * 59 + this.FormFactor.GetHashCode();
                if (this.ScreenSize != null)
                    hashCode = hashCode * 59 + this.ScreenSize.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Memory != null)
                    hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.ScreenRotation != null)
                    hashCode = hashCode * 59 + this.ScreenRotation.GetHashCode();
                if (this.DeviceFrame != null)
                    hashCode = hashCode * 59 + this.DeviceFrame.GetHashCode();
                if (this.AvailabilityCount != null)
                    hashCode = hashCode * 59 + this.AvailabilityCount.GetHashCode();
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
