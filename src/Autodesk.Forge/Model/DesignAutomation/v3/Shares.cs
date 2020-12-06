/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk�s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model.DesignAutomation.v3
{
    /// <summary>
    /// ( response only ).
    /// </summary>
    [DataContract]
    [Obsolete("Please use NuGet package Autodesk.Forge.DesignAutomation instead")]
    public partial class Shares :  IEquatable<Shares>
    {
        /// <summary>
        /// The type of the share (\"Activity\", \"App\",).
        /// </summary>
        /// <value>The type of the share (\"Activity\", \"App\",).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Activity for "activity"
            /// </summary>
            [EnumMember(Value = "activity")]
            Activity,
            
            /// <summary>
            /// Enum App for "app"
            /// </summary>
            [EnumMember(Value = "app")]
            App
        }

        /// <summary>
        /// The type of the share (\"Activity\", \"App\",).
        /// </summary>
        /// <value>The type of the share (\"Activity\", \"App\",).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shares" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Shares() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shares" /> class.
        /// </summary>
        /// <param name="Id">The name alias id with the owner stripped ex: CoolApp+Prod. (required).</param>
        /// <param name="Receiver">The Receiver of the shared alias. (required).</param>
        /// <param name="Type">The type of the share (\&quot;Activity\&quot;, \&quot;App\&quot;,). (required).</param>
        public Shares(string Id = null, string Receiver = null, TypeEnum? Type = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Shares and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Receiver" is required (not null)
            if (Receiver == null)
            {
                throw new InvalidDataException("Receiver is a required property for Shares and cannot be null");
            }
            else
            {
                this.Receiver = Receiver;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Shares and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
        }
        
        /// <summary>
        /// The name alias id with the owner stripped ex: CoolApp+Prod.
        /// </summary>
        /// <value>The name alias id with the owner stripped ex: CoolApp+Prod.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The Receiver of the shared alias.
        /// </summary>
        /// <value>The Receiver of the shared alias.</value>
        [DataMember(Name="receiver", EmitDefaultValue=false)]
        public string Receiver { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shares {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Shares);
        }

        /// <summary>
        /// Returns true if Shares instances are equal
        /// </summary>
        /// <param name="other">Instance of Shares to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shares other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Receiver == other.Receiver ||
                    this.Receiver != null &&
                    this.Receiver.Equals(other.Receiver)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Receiver != null)
                    hash = hash * 59 + this.Receiver.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }
    }

}

