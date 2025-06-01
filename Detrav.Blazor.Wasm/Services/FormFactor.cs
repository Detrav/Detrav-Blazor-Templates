using Detrav.Blazor.Shared.Services;
using System;

namespace Detrav.Blazor.Wasm.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetFormFactor()
        {
            return "WebAssembly";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
