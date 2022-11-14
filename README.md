# ReceiptManagerAPI
 
App created to work with Receipts. <br>

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
 
 ## Improvements
 *
App can be improved by adding tests for receipt service using in memory db.
