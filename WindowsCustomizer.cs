using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    /// <summary>
    /// Настройщик Windows
    /// </summary>
    public class WindowsCustomizer : IAbstractCustomizer
    {
        public IAbstractSettings GetSettings()
        {
            return new WindowsSettings();
        }

    }
}
