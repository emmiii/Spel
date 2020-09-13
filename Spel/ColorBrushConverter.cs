using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace Spel
{
    public class ColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {

            var choices = (ColorChoices)value;

            switch (choices) {
                case ColorChoices.BLUE:
                    return new SolidColorBrush(Colors.Blue);
                case ColorChoices.YELLOW:
                    return new SolidColorBrush(Colors.Yellow);
                case ColorChoices.GREEN:
                    return new SolidColorBrush(Colors.Green);
                case ColorChoices.BROWN:
                    return new SolidColorBrush(Colors.Brown);
                case ColorChoices.RED:
                    return new SolidColorBrush(Colors.Red);
                case ColorChoices.PURPLE:
                    return new SolidColorBrush(Colors.Purple);
            }
            return new SolidColorBrush(Colors.White); // Grundfärg
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            //vi konverterar inte en färg till ett värde igen
            //kanske sen?
            throw new NotImplementedException();
        }
    }
}
