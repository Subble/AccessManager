using Subble.Core;
using Subble.Core.Plugin;
using System.Collections.Generic;
using Subble.Core.Config;

namespace AccessManager
{
    public class Plugin : ISubblePlugin
    {
        public IPluginInfo Info
            => new PluginInfo();

        public SemVersion Version
            => new SemVersion(0, 1, 0);

        public long LoadPriority => 6;

        public IEnumerable<Dependency> Dependencies
            => new[] {
                new Dependency(typeof(IConfigManager), (0,1,0))
            };

        public bool Initialize(ISubbleHost host)
        {
            if (host is null)
                return false;

            return true;
        }
    }
}
