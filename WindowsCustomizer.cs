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
        /// <summary>
        /// Создает экземпляр класса WindowsSettings
        /// </summary>
        /// <returns>возвращает класс настроек операционной системы Windows</returns>
        public IAbstractSettings GetSettings()
        {
            return new WindowsSettings();
        }

    }
}
