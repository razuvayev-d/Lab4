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
        /// <summary>
        /// Создает экземпляр класса UbuntuSettings
        /// </summary>
        /// <returns>возвращает класс настроек операционной системы Ubuntu</returns>
        public IAbstractSettings GetSettings()
        {
            return new UbuntuSettings();
        }
    }
}
