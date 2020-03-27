using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    /// <summary>
    /// Настройщик Ubuntu
    /// </summary>
    public class UbuntuCustomizer : IAbstractCustomizer
    {
        public IAbstractSettings GetSettings()
        {
            return new UbuntuSettings();
        }
    }
}
