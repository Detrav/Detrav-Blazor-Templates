## Detrav Blazor Templates

Blazor template demonstrating the use of FluentUI Blazor across multiple platforms:

### Available Projects

- **Wasm (BlazorWasm)** — client-side implementation without interactivity. Interactivity is intentionally disabled due to performance issues causing UI freezes.
- **Web (BlazorServer)** — fully server-side application.
- **Maui** — native cross-platform app built with .NET MAUI.
- **Shared** — shared library containing common code used across all platforms.
- **Photino** — desktop application based on WebView using [Photino](https://github.com/tryphotino/photino.Blazor). Supports Windows, Linux and macOS.

### System Requirements (Photino)

According to official Photino documentation, the following dependencies are required:

- `libc6 (>= 2.31)`
- `gir1.2-gtk-3.0 (>= 3.24)`
- `libwebkit2gtk-4.1-0 (>= 2.42)`

> ⚠️ However, during testing it was found that at least `libc6 >= 2.38` is needed for successful execution.

### How to Use

This project was initially created for personal use. There are plans to turn it into a `dotnet new` template in the future, but for now, that's not available yet.

#### Installation:
```bash
git clone https://github.com/detrav/detrav-blazor-templates.git
```

After cloning, open the solution in your IDE and run the desired project.

