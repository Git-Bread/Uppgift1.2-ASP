using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ConversionModel
    {
        private double value;

        [Required(ErrorMessage = "Value is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Value should probaly be a positive number")]
        public double Value
        {
            get => value;
            set
            {
                this.value = value;
                ConvertedValue = Math.Round(value * 3.28084, 2);
            }
        }

        public double ConvertedValue { get; set; }
    }

    public class ConversionModelSpeed
    {
        private double value;

        [Required(ErrorMessage = "Value is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Value should probaly be a positive number")]
        public double Value
        {
            get => value;
            set
            {
                this.value = value;
                ConvertedValue = Math.Round(value * 0.621371, 2);
            }
        }

        public double ConvertedValue { get; set; }
    }
}