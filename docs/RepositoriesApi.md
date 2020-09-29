# SonaTypeNexusRepoApi.Api.RepositoriesApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRepositories1**](RepositoriesApi.md#getrepositories1) | **GET** /v1/repositories | List repositories


<a name="getrepositories1"></a>
# **GetRepositories1**
> List<RepositoryXO> GetRepositories1 ()

List repositories

### Example
```csharp
using System;
using System.Diagnostics;
using SonaTypeNexusRepoApi.Api;
using SonaTypeNexusRepoApi.Client;
using SonaTypeNexusRepoApi.Model;

namespace Example
{
    public class GetRepositories1Example
    {
        public void main()
        {
            var apiInstance = new RepositoriesApi();

            try
            {
                // List repositories
                List&lt;RepositoryXO&gt; result = apiInstance.GetRepositories1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.GetRepositories1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RepositoryXO>**](RepositoryXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

