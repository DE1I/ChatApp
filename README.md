# Yaply 🔥

Yaply is a messaging app that goes beyond the typical chat client. Instead of static message threads, Yaply drops users into **Campgrounds** — cozy, 2-bit pixel-art spaces with proximity-based voice and text chat, shared music, and fully customizable themes.

Gather round the fire, walk up to a friend to start talking, drop a song in the queue, and make the space your own.

---

## 👋 About This Project

Yaply is a solo passion project built by me as a way to actually learn ASP.NET MVC by doing, rather than just reading docs or following tutorials. I'm just new with MVC so
expect things to be rough around the edges in places, well, that's kind of the point. If you're also learning MVC and want to follow along, poke through the code, or suggest improvements, you're welcome to.

---

## ✨ Features

- **Campgrounds** — themed 2-bit rooms where users can walk around, talk, and hang out together in a shared space.
- **Proximity Chat** — voice and text volume/visibility scale based on how close your avatar is to others in a Campground.
- **The Firepit** — a persistent central gathering spot in every Campground.
- **Campfire Playlist** — a shared, synced music queue that everyone in a Campground can add to and listen to together.
- **Camp Status** — live presence that shows what you're actually doing (sitting, walking, AFK) instead of a plain online/offline indicator.
- **Custom Theming** — personalize the look of your account, groups, and private messages.
- **Smoke Signals** — activity and notification feed.
- **Who's Camping** — see which Campground your friends are currently hanging out in.

---

## 🛠️ Tech Stack

- **Backend:** ASP.NET MVC (.NET)
- **Real-time communication:** SignalR
- **Voice transport:** WebRTC (signaled via SignalR)
- **Database:** Entity Framework Core + SQL Server
- **Caching / Presence / SignalR backplane:** Redis
- **Frontend:** HTML5 Canvas / CSS grid for pixel-art room rendering, JavaScript

---

## 📁 Project Structure

```
Yaply/
├── Controllers/          # MVC controllers (auth, rooms, profile, themes)
├── Hubs/                 # SignalR hubs (RoomHub, MusicHub, PresenceHub)
├── Models/                # EF Core entities (Campground, RoomObject, User, Theme)
├── Views/                 # Razor views
├── wwwroot/
│   ├── js/                # Client-side room rendering, SignalR client logic
│   ├── css/                # Themes and styling
│   └── assets/             # Pixel-art sprites, sounds, icons
├── Services/               # Background services (room cleanup, fire-dimming logic, etc.)
└── appsettings.json
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version matching this project)
- SQL Server (LocalDB is fine for development)
- Redis (for local multi-instance testing of SignalR presence)
- Visual Studio 2022+ (recommended) or VS Code

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/yaply.git
   cd yaply
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Configure your connection strings**

   Update `appsettings.json` with your local SQL Server and Redis connection strings:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Yaply;Trusted_Connection=True;",
       "Redis": "localhost:6379"
     }
   }
   ```

4. **Apply database migrations**
   ```bash
   dotnet ef database update
   ```

5. **Run the app**
   ```bash
   dotnet run
   ```

   Or launch directly from Visual Studio with **F5**.

---

## 🗺️ Roadmap

- [ ] User-created custom Campgrounds
- [ ] Fire Keeper (DJ) role and queue controls
- [ ] Noticeboard (pinned messages/corkboard)
- [ ] Expanded avatar customization
- [ ] Mobile-friendly room rendering

---

## 🤝 Contributing

Contributions are welcome! Please open an issue to discuss any major changes before submitting a pull request.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE) — update this section based on the license you choose.
