# Org.Ducksms.Api.SmsApi

All URIs are relative to *https://ducksms.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SmsSend**](SmsApi.md#smssend) | **POST** /api/v1/sms/send | Send Sms



## SmsSend

> PreviewSmsSend SmsSend (SmsSchema smsSchema = null)

Send Sms

Create a new sms

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.Ducksms.Api;
using Org.Ducksms.Client;
using Org.Ducksms.Model;

namespace Example
{
    public class SmsSendExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://ducksms.com";
            // Configure HTTP bearer authorization: BearerToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SmsApi(Configuration.Default);
            var smsSchema = new SmsSchema(); // SmsSchema | Create a new sms (optional) 

            try
            {
                // Send Sms
                PreviewSmsSend result = apiInstance.SmsSend(smsSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SmsApi.SmsSend: " + e.Message );
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
 **smsSchema** | [**SmsSchema**](SmsSchema.md)| Create a new sms | [optional] 

### Return type

[**PreviewSmsSend**](PreviewSmsSend.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sms preview |  -  |
| **201** | Sms created |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthenticated |  -  |
| **422** | Validation errors |  -  |
| **500** | Server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

