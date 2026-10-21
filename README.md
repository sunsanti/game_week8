# Game Week 8 – Plane & Scene Management

Bài tập tuần 8 môn **Lập trình Game**: tạo scene, quản lý scene và điều khiển luồng game trong Unity.

## Nội dung

Máy bay tự bay về phía trước. Khi chạm vào bức tường (trigger), game hiện popup với 2 lựa chọn:

- **Enter** – chuyển sang `_Scene_1`
- **Restart** – tải lại `_Scene_0` để chơi lại

## Scripts

| File | Chức năng |
|------|-----------|
| `Assets/AirplaneController.cs` | Di chuyển máy bay ngược hướng `transform.forward` (theo hướng mũi của model) với tốc độ `speed` (mặc định 10) |
| `Assets/Scripts/LevelTrigger.cs` | Bắt `OnTriggerEnter` với object có tag `Player` và hiện `GameMenu` |
| `Assets/Scripts/GameManager.cs` | Ẩn popup khi bắt đầu, đặt nội dung chữ, xử lý nút `NextScene()` / `RestartScene()` |

## Scenes

Cả 2 scene đã được thêm vào **Build Settings**:

1. `Assets/Scenes/_Scene_0.unity` – màn chơi chính
2. `Assets/Scenes/_Scene_1.unity` – màn tiếp theo

## Yêu cầu

- Unity **6000.4.5f1** (Unity 6)
- Universal Render Pipeline (URP)
- TextMesh Pro, uGUI

## Cách chạy

```bash
git clone https://github.com/sunsanti/game_week8.git
```

1. Mở **Unity Hub** → **Add** → chọn thư mục `game_week8`.
2. Mở scene `Assets/Scenes/_Scene_0.unity`.
3. Nhấn **Play**.

## Tác giả

[@sunsanti](https://github.com/sunsanti)
