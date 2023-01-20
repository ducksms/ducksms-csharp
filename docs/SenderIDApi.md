# Org.Ducksms.Api.SenderIDApi

All URIs are relative to *https://ducksms.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSender**](SenderIDApi.md#createsender) | **POST** /api/v1/senders | Create a Sender ID
[**DeleteSender**](SenderIDApi.md#deletesender) | **DELETE** /api/v1/senders/{id} | Delete a Sender ID
[**GetSender**](SenderIDApi.md#getsender) | **GET** /api/v1/senders/{id} | Get a single Sender ID
[**ListSender**](SenderIDApi.md#listsender) | **GET** /api/v1/senders | List Sender ID
[**UpdateSender**](SenderIDApi.md#updatesender) | **POST** /api/v1/senders/{id} | Update a Sender ID



## CreateSender

> CreatedSender CreateSender (Sender sender = null)

Create a Sender ID

Create a new sender id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class CreateSenderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SenderIDApi(Configuration.Default);
            var sender = new Sender(); // Sender | Create a new sender (optional) 

            try
            {
                // Create a Sender ID
                CreatedSender result = apiInstance.CreateSender(sender);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SenderIDApi.CreateSender: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sender** | [**Sender**](Sender.md)| Create a new sender | [optional] 

### Return type

[**CreatedSender**](CreatedSender.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Sender ID created |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **422** | Validation errors |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSender

> DeletedSender DeleteSender (string id)

Delete a Sender ID

Delete an existing sender id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class DeleteSenderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SenderIDApi(Configuration.Default);
            var id = id_example;  // string | 

            try
            {
                // Delete a Sender ID
                DeletedSender result = apiInstance.DeleteSender(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SenderIDApi.DeleteSender: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**DeletedSender**](DeletedSender.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sender deleted |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **404** | No data found |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSender

> GetSender GetSender (string id)

Get a single Sender ID

Get details on a single sender id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class GetSenderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SenderIDApi(Configuration.Default);
            var id = id_example;  // string | 

            try
            {
                // Get a single Sender ID
                GetSender result = apiInstance.GetSender(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SenderIDApi.GetSender: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**GetSender**](GetSender.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get details on a single sender |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **404** | No data found |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSender

> ListSender ListSender (int? page = null, string filterName = null, string filterStatus = null)

List Sender ID

List all the senders

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class ListSenderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SenderIDApi(Configuration.Default);
            var page = 1;  // int? | Page number (optional) 
            var filterName = DUCKSMS;  // string | Filter by sender name (optional) 
            var filterStatus = active;  // string | Filter by sender status (optional) 

            try
            {
                // List Sender ID
                ListSender result = apiInstance.ListSender(page, filterName, filterStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SenderIDApi.ListSender: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number | [optional] 
 **filterName** | **string**| Filter by sender name | [optional] 
 **filterStatus** | **string**| Filter by sender status | [optional] 

### Return type

[**ListSender**](ListSender.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List all the senders |  * X-Pagination-Count - Total data count <br>  * X-Pagination-Page - Pagination page number <br>  * X-Pagination-Limit - Pagination limit per page <br>  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **404** | No data found |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSender

> UpdatedSender UpdateSender (string id, Sender sender = null)

Update a Sender ID

Update an existing sender id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class UpdateSenderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SenderIDApi(Configuration.Default);
            var id = id_example;  // string | 
            var sender = new Sender(); // Sender | Update an existing sender id (optional) 

            try
            {
                // Update a Sender ID
                UpdatedSender result = apiInstance.UpdateSender(id, sender);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SenderIDApi.UpdateSender: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **sender** | [**Sender**](Sender.md)| Update an existing sender id | [optional] 

### Return type

[**UpdatedSender**](UpdatedSender.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sender updated |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **404** | No data found |  -  |
| **422** | Validation errors |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

