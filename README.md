# ReceiptManagerAPI
 
App created to work with Receipts. <br>

User can :<br>
 1) Create receipt. Dont change Id in body, just change "string" to your item, like "chocolate" <br> 
 2) Get receipt by id. Input receipt Id not item Id.<br> 
 3) Get receipt by time range. Input time like: 2022-11-15T00:50:31.4598472+03:00 (or copy time from created receipt)<br> 
 4) Get receipt by item name. Input item name<br> 
 5) Delete receipt by id. Input receipt Id not item Id.<br> 

App can be improved by adding tests for receipt service using in memory db.
