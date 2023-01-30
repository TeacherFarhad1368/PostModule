using _Utilities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.PostEntity
{
    public class Post : BaseEntity<int>
    {
        public string Title { get; private set; }
        public string Status { get; private set; }
        public string? Description { get; private set; }
        public int TehranPricePlus { get; private set; }
        public int StateCenterPricePlus { get; private set; }
        public int CityPricePlus { get; private set; }
        public int InsideStatePricePlus { get; private set; }
        public int StateClosePricePlus { get; private set; }
        public int StateNonClosePricePlus { get; private set; }
        public bool Active { get; private set; }
        public bool InsideCity { get; private set; }
        public bool OutSideCity { get; private set; }
        public List<PostPrice> PostPrices { get; set; }
        public Post(string title, string status, int tehranPricePlus, 
            int stateCenterPricePlus, int cityPricePlus, int insideStatePricePlus,
            int stateClosePricePlus, int stateNonClosePricePlus, string description)
        {
            Title = title;
            Status = status;
            TehranPricePlus = tehranPricePlus;
            StateCenterPricePlus = stateCenterPricePlus;
            CityPricePlus = cityPricePlus;
            InsideStatePricePlus = insideStatePricePlus;
            StateClosePricePlus = stateClosePricePlus;
            StateNonClosePricePlus = stateNonClosePricePlus;
            Active = true;
            InsideCity = true;
            OutSideCity = true;
            Description = description;
        }
        public void Edit(string title, string status, int tehranPricePlus,
            int stateCenterPricePlus, int cityPricePlus, int insideStatePricePlus,
            int stateClosePricePlus, int stateNonClosePricePlus, string description)
        {
            Title = title;
            Status = status;
            TehranPricePlus = tehranPricePlus;
            StateCenterPricePlus = stateCenterPricePlus;
            CityPricePlus = cityPricePlus;
            InsideStatePricePlus = insideStatePricePlus;
            StateClosePricePlus = stateClosePricePlus;
            StateNonClosePricePlus = stateNonClosePricePlus;
            Description = description;
        }
        public void ActivationChange()
        {
            if (Active) Active = false;
            else Active = true;
        }
        public void InsideCityChange()
        {
            if (InsideCity) InsideCity = false;
            else InsideCity = true;
        }
        public void OutSideCityChange()
        {
            if (OutSideCity) OutSideCity = false;
            else OutSideCity = true;
        }
    }
}
