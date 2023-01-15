using _Utilities.Enums;

namespace PostModule.Application.Contract.CityApplication
{
    public class EditCityModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public CityStatus Status { get; set; }
    }
}
