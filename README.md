# ✈️ Plane Simulation - Lập Trình Game (Week 8)

> **Môn học**: Lập Trình Game (Game Development)  
> **Chủ đề tuần 8**: Scene Creation, Management & Game Flow Control  
> **Unity Version**: `6000.4.5f1` (Unity 6)  
> **Render Pipeline**: Universal Render Pipeline (URP)

---

## 📖 Giới thiệu Dự án

Dự án mô phỏng điều khiển máy bay và cơ chế quản lý cảnh trong game (Scene Management):
- Điều khiển đối tượng máy bay bay thẳng về phía trước theo thời gian thực (`AirplaneController`).
- Phát hiện va chạm thông qua vùng kích hoạt Trigger (`LevelTrigger`) để dừng/hiển thị hộp thoại kết thúc hoặc chuyển màn.
- Giao diện người dùng (UI Canvas với TextMesh Pro): Cho phép người chơi nhấn **Enter** để chuyển sang cảnh tiếp theo hoặc **Restart** để chơi lại từ đầu (`GameManager`).
- Quản lý và chuyển đổi qua lại giữa các Scene (`_Scene_0` và `_Scene_1`).

---

## 🛠️ Công nghệ & Yêu cầu hệ thống

- **Engine**: Unity 6 (`6000.4.5f1` hoặc mới hơn)
- **Render Pipeline**: Universal Render Pipeline (URP)
- **UI System**: Unity UI (uGUI) & TextMesh Pro
- **Hệ điều hành**: Windows 10/11, macOS hoặc Linux

---

## 📂 Cấu trúc Thư mục Chính

```text
game_week8/
├── Assets/
│   ├── AirplaneController.cs       # Điều khiển chuyển động bay của phi cơ
│   ├── Scenes/
│   │   ├── _Scene_0.unity          # Cảnh mở đầu / Gameplay chính
│   │   └── _Scene_1.unity          # Cảnh tiếp theo sau khi hoàn thành
│   ├── Scripts/
│   │   ├── GameManager.cs          # Quản lý giao diện, Next Scene & Restart
│   │   └── LevelTrigger.cs         # Bắt va chạm Trigger để hiển thị Game Menu
│   ├── Settings/                   # Thiết lập cấu hình URP
│   └── TextMesh Pro/               # Tài nguyên font chữ và shader TextMesh Pro
├── Packages/
│   ├── manifest.json
│   └── packages-lock.json
├── ProjectSettings/                # Cài đặt cấu hình dự án Unity
├── .gitignore                      # Bộ lọc bỏ thư mục tạm thời của Unity
└── README.md
```

---

## 🎮 Cách chạy dự án

1. **Clone mã nguồn**:
   ```bash
   git clone https://github.com/sunsanti/game_week8.git
   ```
2. **Mở dự án trong Unity Hub**:
   - Mở **Unity Hub** -> Chọn **Add** -> Trỏ vào thư mục dự án vừa tải về.
   - Đảm bảo chọn Unity Editor phiên bản `6000.4.5f1` (Unity 6).
3. **Mở Scene và Chơi**:
   - Trong cửa sổ **Project**, điều hướng tới: `Assets/Scenes/_Scene_0.unity`.
   - Nhấn nút **Play (▶️)** để bắt đầu trải nghiệm game.

---

## 👨‍💻 Tác giả

- **GitHub**: [@sunsanti](https://github.com/sunsanti)
- Dự án phục vụ cho bài tập môn học Lập trình Game - Week 8.
