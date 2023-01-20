# Org.Ducksms.Api.SmsScheduleApi

All URIs are relative to *https://ducksms.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelSmsSchedule**](SmsScheduleApi.md#cancelsmsschedule) | **DELETE** /api/v1/sms/scheduled/{id} | Cancel Sms Schedule
[**ListSmsSchedule**](SmsScheduleApi.md#listsmsschedule) | **GET** /api/v1/sms/scheduled | List Sms Schedule



## CancelSmsSchedule

> CancelSmsSchedule CancelSmsSchedule (string id)

Cancel Sms Schedule

Cancel existing sms schedule

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class CancelSmsScheduleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SmsScheduleApi(Configuration.Default);
            var id = id_example;  // string | 

            try
            {
                // Cancel Sms Schedule
                CancelSmsSchedule result = apiInstance.CancelSmsSchedule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SmsScheduleApi.CancelSmsSchedule: " + e.Message );
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

[**CancelSmsSchedule**](CancelSmsSchedule.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cancel existing sms schedule |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **404** | No data found |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSmsSchedule

> ListSmsSchedule ListSmsSchedule (int? page = null, string filterSenderName = null, string filterType = null, string filterMessageType = null, string filterStatus = null)

List Sms Schedule

List all the sms schedule

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class ListSmsScheduleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SmsScheduleApi(Configuration.Default);
            var page = 1;  // int? | Page number (optional) 
            var filterSenderName = DUCKSMS;  // string | Filter by sender id name (optional) 
            var filterType = quick;  // string | Filter by sms type (optional) 
            var filterMessageType = ascii;  // string | Filter by sms message type (optional) 
            var filterStatus = pending;  // string | Filter by sms status (optional) 

            try
            {
                // List Sms Schedule
                ListSmsSchedule result = apiInstance.ListSmsSchedule(page, filterSenderName, filterType, filterMessageType, filterStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SmsScheduleApi.ListSmsSchedule: " + e.Message );
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
 **filterSenderName** | **string**| Filter by sender id name | [optional] 
 **filterType** | **string**| Filter by sms type | [optional] 
 **filterMessageType** | **string**| Filter by sms message type | [optional] 
 **filterStatus** | **string**| Filter by sms status | [optional] 

### Return type

[**ListSmsSchedule**](ListSmsSchedule.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List all the sms schedule |  * X-Pagination-Count - Total data count <br>  * X-Pagination-Page - Pagination page number <br>  * X-Pagination-Limit - Pagination limit per page <br>  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **404** | No data found |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

