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

namespace SonaTypeNexusRepoApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILifecycleApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Bounce lifecycle phase
        /// </summary>
        /// <remarks>
        /// Re-runs all phases from the given phase to the current phase
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to bounce (optional)</param>
        /// <returns></returns>
        void Bounce (string body = null);

        /// <summary>
        /// Bounce lifecycle phase
        /// </summary>
        /// <remarks>
        /// Re-runs all phases from the given phase to the current phase
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to bounce (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BounceWithHttpInfo (string body = null);
        /// <summary>
        /// Get current lifecycle phase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string GetPhase ();

        /// <summary>
        /// Get current lifecycle phase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetPhaseWithHttpInfo ();
        /// <summary>
        /// Move to new lifecycle phase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to move to (optional)</param>
        /// <returns></returns>
        void SetPhase (string body = null);

        /// <summary>
        /// Move to new lifecycle phase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to move to (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SetPhaseWithHttpInfo (string body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Bounce lifecycle phase
        /// </summary>
        /// <remarks>
        /// Re-runs all phases from the given phase to the current phase
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to bounce (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BounceAsync (string body = null);

        /// <summary>
        /// Bounce lifecycle phase
        /// </summary>
        /// <remarks>
        /// Re-runs all phases from the given phase to the current phase
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to bounce (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BounceAsyncWithHttpInfo (string body = null);
        /// <summary>
        /// Get current lifecycle phase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetPhaseAsync ();

        /// <summary>
        /// Get current lifecycle phase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetPhaseAsyncWithHttpInfo ();
        /// <summary>
        /// Move to new lifecycle phase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to move to (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SetPhaseAsync (string body = null);

        /// <summary>
        /// Move to new lifecycle phase
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to move to (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SetPhaseAsyncWithHttpInfo (string body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LifecycleApi : ILifecycleApi
    {
        private SonaTypeNexusRepoApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LifecycleApi(String basePath)
        {
            this.Configuration = new SonaTypeNexusRepoApi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SonaTypeNexusRepoApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LifecycleApi(SonaTypeNexusRepoApi.Client.Configuration configuration = null)
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
        /// Bounce lifecycle phase Re-runs all phases from the given phase to the current phase
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to bounce (optional)</param>
        /// <returns></returns>
        public void Bounce (string body = null)
        {
             BounceWithHttpInfo(body);
        }

        /// <summary>
        /// Bounce lifecycle phase Re-runs all phases from the given phase to the current phase
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to bounce (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> BounceWithHttpInfo (string body = null)
        {

            var localVarPath = "/v1/lifecycle/bounce";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Bounce", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Bounce lifecycle phase Re-runs all phases from the given phase to the current phase
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to bounce (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BounceAsync (string body = null)
        {
             await BounceAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Bounce lifecycle phase Re-runs all phases from the given phase to the current phase
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to bounce (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> BounceAsyncWithHttpInfo (string body = null)
        {

            var localVarPath = "/v1/lifecycle/bounce";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Bounce", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get current lifecycle phase 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string GetPhase ()
        {
             ApiResponse<string> localVarResponse = GetPhaseWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current lifecycle phase 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetPhaseWithHttpInfo ()
        {

            var localVarPath = "/v1/lifecycle/phase";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain"
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
                Exception exception = ExceptionFactory("GetPhase", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Get current lifecycle phase 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetPhaseAsync ()
        {
             ApiResponse<string> localVarResponse = await GetPhaseAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current lifecycle phase 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetPhaseAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/lifecycle/phase";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain"
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
                Exception exception = ExceptionFactory("GetPhase", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Move to new lifecycle phase 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to move to (optional)</param>
        /// <returns></returns>
        public void SetPhase (string body = null)
        {
             SetPhaseWithHttpInfo(body);
        }

        /// <summary>
        /// Move to new lifecycle phase 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to move to (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SetPhaseWithHttpInfo (string body = null)
        {

            var localVarPath = "/v1/lifecycle/phase";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetPhase", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Move to new lifecycle phase 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to move to (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SetPhaseAsync (string body = null)
        {
             await SetPhaseAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Move to new lifecycle phase 
        /// </summary>
        /// <exception cref="SonaTypeNexusRepoApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The phase to move to (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SetPhaseAsyncWithHttpInfo (string body = null)
        {

            var localVarPath = "/v1/lifecycle/phase";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetPhase", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
