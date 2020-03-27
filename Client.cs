using System;

namespace Lab4
{
    /// <summary>
    /// Класс клиента
    /// </summary>
    class Client
    {
        /// <summary>
        /// Выборщик операционной системы     
        /// </summary
        /// <param name="os">Название операционной системы </param>
        public static void Elector(string os)
        {                     
            switch (os)
            {
                case "Ubuntu":
                    OSSet(new UbuntuCustomizer());
                    break;
                case "Mac":
                    OSSet(new MacCustomizer());
                    break;
                case "Windows":
                    OSSet(new WindowsCustomizer());
                    break;
                default:
                    throw new ArgumentException("Проверьте правильность введенной ОС");         
                    break;
            }
            Console.ReadLine();
        }

        
        static void OSSet(IAbstractCustomizer customizer)
        {
            var Settings = customizer.GetSettings();

            Settings.SetSettings1();
            Settings.SetSettings2();
            Settings.SetSettings3();
            Settings.SetSettings4();
            Settings.SetSettings5();
            Settings.SetSettings6();
            Settings.SetSettings7();
            Settings.SetSettings8();
            Settings.SetSettings9();
            Settings.SetSettings10();
        }
    }



}
