# Org.Ducksms.Api.CreditApi

All URIs are relative to *https://ducksms.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreditBalance**](CreditApi.md#creditbalance) | **GET** /api/v1/credits/balance | Credit Balance
[**CreditHistory**](CreditApi.md#credithistory) | **GET** /api/v1/credits/history | Credit History



## CreditBalance

> CreditBalance CreditBalance ()

Credit Balance

Get available credit balance

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class CreditBalanceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi(Configuration.Default);

            try
            {
                // Credit Balance
                CreditBalance result = apiInstance.CreditBalance();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CreditApi.CreditBalance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**CreditBalance**](CreditBalance.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get available credit balance |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreditHistory

> CreditHistory CreditHistory (int? page = null, string filterType = null, int? filterSmsSmsid = null)

Credit History

Get all credit history

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class CreditHistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi(Configuration.Default);
            var page = 1;  // int? | Page number (optional) 
            var filterType = credit;  // string | Filter by credit type (optional) 
            var filterSmsSmsid = 1009771270;  // int? | Filter by sms id (optional) 

            try
            {
                // Credit History
                CreditHistory result = apiInstance.CreditHistory(page, filterType, filterSmsSmsid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CreditApi.CreditHistory: " + e.Message );
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
 **filterType** | **string**| Filter by credit type | [optional] 
 **filterSmsSmsid** | **int?**| Filter by sms id | [optional] 

### Return type

[**CreditHistory**](CreditHistory.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List all the credit history |  * X-Pagination-Count - Total data count <br>  * X-Pagination-Page - Pagination page number <br>  * X-Pagination-Limit - Pagination limit per page <br>  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **404** | No data found |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

