## Overview
這是一個基於 Unity 的混合實境（Mixed Reality, MR）應用範例，實現了透過 Meta Quest 裝置中的 Passthrough Camera 擷取畫面，結合 Unity Sentis 執行物件辨識模型（YOLO），並以即時 3D 框線與 UI 呈現辨識結果。此範例展示如何整合鏡頭影像串流、AI 推論、2D/3D UI 同步渲染以及空間對齊技術於 MR 環境中。
## Syetem Architecture
- PassthroughCamera：取得 Quest 裝置即時影像並顯示。
- Unity Sentis：載入並執行 YOLO 模型，輸出辨識框與標籤。
- UI 管理器群（DetectionUiMenuManager / DetectionUiTextWritter / DetectionUiBlinkText / SentisInferenceUiManager）：負責初始化畫面、文字動畫與辨識資訊顯示。
- 3D 標記系統（DetectionSpawnMarkerAnim / EnvironmentRayCastSampleManager）：將辨識結果轉換為空間標記（如class 名稱）。
- 控制流程（DetectionManager）：綜合調度推論流程、UI 更新與使用者互動（如 A 鍵觸發標記）。
