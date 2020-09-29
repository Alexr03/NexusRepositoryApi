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
    /// RubyGemsProxyRepositoryApiRequest
    /// </summary>
    [DataContract]
    public partial class RubyGemsProxyRepositoryApiRequest :  IEquatable<RubyGemsProxyRepositoryApiRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RubyGemsProxyRepositoryApiRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RubyGemsProxyRepositoryApiRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RubyGemsProxyRepositoryApiRequest" /> class.
        /// </summary>
        /// <param name="name">A unique identifier for this repository (required).</param>
        /// <param name="online">Whether this repository accepts incoming requests (required).</param>
        /// <param name="storage">storage (required).</param>
        /// <param name="cleanup">cleanup.</param>
        /// <param name="proxy">proxy (required).</param>
        /// <param name="negativeCache">negativeCache (required).</param>
        /// <param name="httpClient">httpClient (required).</param>
        /// <param name="routingRule">routingRule.</param>
        public RubyGemsProxyRepositoryApiRequest(string name = default(string), bool? online = default(bool?), StorageAttributes storage = default(StorageAttributes), CleanupPolicyAttributes cleanup = default(CleanupPolicyAttributes), ProxyAttributes proxy = default(ProxyAttributes), NegativeCacheAttributes negativeCache = default(NegativeCacheAttributes), HttpClientAttributes httpClient = default(HttpClientAttributes), string routingRule = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RubyGemsProxyRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "online" is required (not null)
            if (online == null)
            {
                throw new InvalidDataException("online is a required property for RubyGemsProxyRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Online = online;
            }
            // to ensure "storage" is required (not null)
            if (storage == null)
            {
                throw new InvalidDataException("storage is a required property for RubyGemsProxyRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Storage = storage;
            }
            // to ensure "proxy" is required (not null)
            if (proxy == null)
            {
                throw new InvalidDataException("proxy is a required property for RubyGemsProxyRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Proxy = proxy;
            }
            // to ensure "negativeCache" is required (not null)
            if (negativeCache == null)
            {
                throw new InvalidDataException("negativeCache is a required property for RubyGemsProxyRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.NegativeCache = negativeCache;
            }
            // to ensure "httpClient" is required (not null)
            if (httpClient == null)
            {
                throw new InvalidDataException("httpClient is a required property for RubyGemsProxyRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.HttpClient = httpClient;
            }
            this.Cleanup = cleanup;
            this.RoutingRule = routingRule;
        }
        
        /// <summary>
        /// A unique identifier for this repository
        /// </summary>
        /// <value>A unique identifier for this repository</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether this repository accepts incoming requests
        /// </summary>
        /// <value>Whether this repository accepts incoming requests</value>
        [DataMember(Name="online", EmitDefaultValue=false)]
        public bool? Online { get; set; }

        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public StorageAttributes Storage { get; set; }

        /// <summary>
        /// Gets or Sets Cleanup
        /// </summary>
        [DataMember(Name="cleanup", EmitDefaultValue=false)]
        public CleanupPolicyAttributes Cleanup { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name="proxy", EmitDefaultValue=false)]
        public ProxyAttributes Proxy { get; set; }

        /// <summary>
        /// Gets or Sets NegativeCache
        /// </summary>
        [DataMember(Name="negativeCache", EmitDefaultValue=false)]
        public NegativeCacheAttributes NegativeCache { get; set; }

        /// <summary>
        /// Gets or Sets HttpClient
        /// </summary>
        [DataMember(Name="httpClient", EmitDefaultValue=false)]
        public HttpClientAttributes HttpClient { get; set; }

        /// <summary>
        /// Gets or Sets RoutingRule
        /// </summary>
        [DataMember(Name="routingRule", EmitDefaultValue=false)]
        public string RoutingRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RubyGemsProxyRepositoryApiRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  Cleanup: ").Append(Cleanup).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  NegativeCache: ").Append(NegativeCache).Append("\n");
            sb.Append("  HttpClient: ").Append(HttpClient).Append("\n");
            sb.Append("  RoutingRule: ").Append(RoutingRule).Append("\n");
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
            return this.Equals(input as RubyGemsProxyRepositoryApiRequest);
        }

        /// <summary>
        /// Returns true if RubyGemsProxyRepositoryApiRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RubyGemsProxyRepositoryApiRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RubyGemsProxyRepositoryApiRequest input)
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
                    this.Online == input.Online ||
                    (this.Online != null &&
                    this.Online.Equals(input.Online))
                ) && 
                (
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
                ) && 
                (
                    this.Cleanup == input.Cleanup ||
                    (this.Cleanup != null &&
                    this.Cleanup.Equals(input.Cleanup))
                ) && 
                (
                    this.Proxy == input.Proxy ||
                    (this.Proxy != null &&
                    this.Proxy.Equals(input.Proxy))
                ) && 
                (
                    this.NegativeCache == input.NegativeCache ||
                    (this.NegativeCache != null &&
                    this.NegativeCache.Equals(input.NegativeCache))
                ) && 
                (
                    this.HttpClient == input.HttpClient ||
                    (this.HttpClient != null &&
                    this.HttpClient.Equals(input.HttpClient))
                ) && 
                (
                    this.RoutingRule == input.RoutingRule ||
                    (this.RoutingRule != null &&
                    this.RoutingRule.Equals(input.RoutingRule))
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
                if (this.Online != null)
                    hashCode = hashCode * 59 + this.Online.GetHashCode();
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.Cleanup != null)
                    hashCode = hashCode * 59 + this.Cleanup.GetHashCode();
                if (this.Proxy != null)
                    hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.NegativeCache != null)
                    hashCode = hashCode * 59 + this.NegativeCache.GetHashCode();
                if (this.HttpClient != null)
                    hashCode = hashCode * 59 + this.HttpClient.GetHashCode();
                if (this.RoutingRule != null)
                    hashCode = hashCode * 59 + this.RoutingRule.GetHashCode();
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
            // Name (string) pattern
            Regex regexName = new Regex(@"^[a-zA-Z0-9\\-]{1}[a-zA-Z0-9_\\-\\.]*$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            yield break;
        }
    }

}
