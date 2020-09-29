/* 
 * Nexus Repository Manager REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.26.1-02
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
using SwaggerDateConverter = SonaTypeNexusRepoApi.Client.SwaggerDateConverter;

namespace SonaTypeNexusRepoApi.Model
{
    /// <summary>
    /// CleanupPolicyAttributes
    /// </summary>
    [DataContract]
    public partial class CleanupPolicyAttributes :  IEquatable<CleanupPolicyAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleanupPolicyAttributes" /> class.
        /// </summary>
        /// <param name="policyNames">Components that match any of the applied policies will be deleted.</param>
        public CleanupPolicyAttributes(List<string> policyNames = default(List<string>))
        {
            this.PolicyNames = policyNames;
        }
        
        /// <summary>
        /// Components that match any of the applied policies will be deleted
        /// </summary>
        /// <value>Components that match any of the applied policies will be deleted</value>
        [DataMember(Name="policyNames", EmitDefaultValue=false)]
        public List<string> PolicyNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleanupPolicyAttributes {\n");
            sb.Append("  PolicyNames: ").Append(PolicyNames).Append("\n");
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
            return this.Equals(input as CleanupPolicyAttributes);
        }

        /// <summary>
        /// Returns true if CleanupPolicyAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of CleanupPolicyAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleanupPolicyAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyNames == input.PolicyNames ||
                    this.PolicyNames != null &&
                    this.PolicyNames.SequenceEqual(input.PolicyNames)
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
                if (this.PolicyNames != null)
                    hashCode = hashCode * 59 + this.PolicyNames.GetHashCode();
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
