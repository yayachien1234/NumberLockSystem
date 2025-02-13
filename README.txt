# 數字密碼鎖

這是一個簡單的數字密碼鎖應用程式。使用者可以通過點擊按鈕來改變數字，並在解鎖時對比隨機產生的密碼。程式會提供解鎖成功或錯誤提示，並顯示正確的密碼或提示錯誤位置。

## 功能

1. **數字操作**：
   - 程式開始時，所有數字初始化為 0，並隨機生成一組密碼。
   - 點擊任一數字按鈕時，數字會增加 1，並在 9 之後回到 0。

2. **解鎖**：
   - 按下「解鎖」按鈕，檢查目前數字組合是否匹配隨機密碼。
   - 若匹配，顯示「解鎖成功」訊息。
   - 若不匹配，顯示「猜對 x 個位置」，並可選擇重試或取消。
     - 重試會關閉提示訊息並回到數字操作介面。
     - 取消則會顯示正確的密碼。

## 視窗訊息提示

- **解鎖成功**：
  - 標題：成功
  - 圖示：Asterisk
  - 按鈕：OK

- **解鎖失敗**：
  - 標題：失敗
  - 圖示：Error
  - 按鈕：RetryCancel
  - 當按下取消時，顯示正確密碼的 MessageBox。