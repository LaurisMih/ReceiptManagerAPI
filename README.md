# ReceiptManagerAPI
 
App created to work with Receipts. <br>
## How to start: 
1) Clone or or download it as a .zip file and unarchive it. Choose ReceiptManager.sln in ReceiptManager folder<br>
![image](https://user-images.githubusercontent.com/108615436/201790907-ae41c018-5bf6-4bf3-8862-d12932f23629.png)<br>
![image](https://user-images.githubusercontent.com/108615436/201791028-727bc933-8f17-4fdd-8478-d04f90347f12.png)


2) In Visual Studio choose ReceiptManager and run without debugging
![image](https://user-images.githubusercontent.com/108615436/201791121-e160b400-f109-4777-b19f-dd6dc4e16793.png)

3) Work with endpoints(keep project running to send requests)
![image](https://user-images.githubusercontent.com/108615436/201791187-57ff2d10-3d83-4149-aa17-d1d0542c1e3c.png)

## App functionality: <br>
 This API has these endpoints for Receipt:
  * Create receipt : POST /addReceipt<br>
     * Request example<br>
   ![image](https://user-images.githubusercontent.com/108615436/201788562-ab1afeaf-7819-49ee-8fdb-3064ed24c088.png)

 | Parameter      | Type          | Rule                               |
 | -------------  | ------------- | -----------------------------------|
 | id             | string        | don't change id                    |
 | name           | string        |you can change it to your item name |

 * Get receipt by id : GET /receiptController/getReceiptById<br>
 
 | Parameter      | Type          | Rule                               |
 | -------------  | ------------- | -----------------------------------|
 | id             | id        | write your receipt id                    |
 
  * Get receipt by time range: GET receiptController/getReceiptsByTimeRange<br>
    * Input time example:  2022-11-15T00:50:31.4598472+03:00
   
 | Parameter      | Type          | Rule                               |
 | -------------  | ------------- | -----------------------------------|
 | timeStart           | DateTime       | write time lower bound               |     
  | timeEnd            | DateTime        | write your upper bound               |   
  
  * Get all receipts : GET /receiptController/getAllReceipts<br>

 * Get receipt by item name : GET /receiptController/filterReceiptByItemName<br>
 
 | Parameter      | Type          | Rule                               |
 | -------------  | ------------- | -----------------------------------|
 | itemName             | string        | write your item name                    |
 
 * Deletel receipt by id : DELETE /receiptController/{id}<br>
 ## Techonoligies used
 * ASP.NET Core Web API;
* Entity Framework;
* MSTest tests;
 ## Improvements
 * App can be improved by adding tests for receipt service using in memory db.<br>
 * Add delete all receipts method. <br>
 * Get receipt by item id. <br>

