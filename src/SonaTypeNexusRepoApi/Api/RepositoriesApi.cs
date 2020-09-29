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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SonaTypeNexusRepoApi.Client;
using SonaTypeNexusRepoApi.Model;

namespace SonaTypeNexusRepoApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRepositoriesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List repositories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RepositoryXO&gt;</returns>
        List<RepositoryXO> GetRepositories1 ();

        /// <summary>
        /// List repositories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RepositoryXO&gt;</returns>
        ApiResponse<List<RepositoryXO>> GetRepositories1WithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List repositories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RepositoryXO&gt;</returns>
        System.Threading.Tasks.Task<List<RepositoryXO>> GetRepositories1Async ();

        /// <summary>
        /// List repositories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RepositoryXO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RepositoryXO>>> GetRepositories1AsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RepositoriesApi : IRepositoriesApi
    {
        private SonaTypeNexusRepoApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RepositoriesApi(String basePath)
        {
            this.Configuration = new SonaTypeNexusRepoApi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SonaTypeNexusRepoApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoriesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RepositoriesApi(SonaTypeNexusRepoApi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = SonaTypeNexusRepoApi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SonaTypeNexusRepoApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SonaTypeNexusRepoApi.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SonaTypeNexusRepoApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// List repositories 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RepositoryXO&gt;</returns>
        public List<RepositoryXO> GetRepositories1 ()
        {
             ApiResponse<List<RepositoryXO>> localVarResponse = GetRepositories1WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List repositories 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RepositoryXO&gt;</returns>
        public ApiResponse< List<RepositoryXO> > GetRepositories1WithHttpInfo ()
        {

            var localVarPath = "/v1/repositories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRepositories1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RepositoryXO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RepositoryXO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RepositoryXO>)));
        }

        /// <summary>
        /// List repositories 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RepositoryXO&gt;</returns>
        public async System.Threading.Tasks.Task<List<RepositoryXO>> GetRepositories1Async ()
        {
             ApiResponse<List<RepositoryXO>> localVarResponse = await GetRepositories1AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List repositories 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RepositoryXO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RepositoryXO>>> GetRepositories1AsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/repositories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRepositories1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RepositoryXO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RepositoryXO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RepositoryXO>)));
        }

    }
}