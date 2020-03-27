using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    /// <summary>
    /// Настройщик Mac OS
    /// </summary>
    public class MacCustomizer : IAbstractCustomizer
    {
        public IAbstractSettings GetSettings()
        {
            return new MacSettings();
        }
    }
}
