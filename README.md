# ReceiptManagerAPI
 
App created to work with Receipts. <br>

## App functionality: <br>
 This API has these endpoints for Receipt:
  * Create receipt : POST /addReceipt<br>
   * Request example
   ![image](https://user-images.githubusercontent.com/108615436/201788562-ab1afeaf-7819-49ee-8fdb-3064ed24c088.png)

 | Parameter      | Type          | Rule                               |
 | -------------  | ------------- | -----------------------------------|
 | id             | string        | don't change id                    |
 | name           | string        |you can change it to your item name |

 * Get receipt by id : GEt /receiptController/getReceiptById<br>
  
 | Parameter      | Type          | Rule                               |
 | -------------  | ------------- | -----------------------------------|
 | id             | id        | write your receipt id                    |
 
User can :<br>
 1) Create receipt. Dont change Id in body, just change "string" to your item, like "chocolate" <br> 
 2) Get receipt by id. Input receipt Id not item Id.<br> 
 3) Get receipt by time range. Input time like: 2022-11-15T00:50:31.4598472+03:00 (or copy time from created receipt)<br> 
 4) Get receipt by item name. Input item name<br> 
 5) Delete receipt by id. Input receipt Id not item Id.<br> 

App can be improved by adding tests for receipt service using in memory db.
