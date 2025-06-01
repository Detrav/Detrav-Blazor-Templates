using Detrav.Blazor.Shared.Services;
using System;

namespace Detrav.Blazor.Photino.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetFormFactor()
        {
            return "Photino";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
