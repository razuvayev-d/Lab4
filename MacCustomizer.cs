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
        /// <summary>
        /// Создает экземпляр класса MacSettings
        /// </summary>
        /// <returns>возвращает класс настроек операционной системы Ubuntu</returns>
        public IAbstractSettings GetSettings()
        {
            return new MacSettings();
        }
    }
}
