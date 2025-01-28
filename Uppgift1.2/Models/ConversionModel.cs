using System.ComponentModel.DataAnnotations;

//model for converting two values
namespace Models
{
    //standard distance conversion
    public class ConversionModel
    {
        private double value;

        //some error handling, mostly for fun
        [Required(ErrorMessage = "Value is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Value should probaly be a positive number")]

        //get and set for value, also sets the converted value
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

    //speed conversion, duplicate of first with small changes
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