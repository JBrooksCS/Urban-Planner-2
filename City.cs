using System;
using System.Collections.Generic;


namespace Urban_Planner
{
    public class City
    {
        //Constructor
        public City(string cityName)
        {
            _name = cityName;
        }
        //Fields
        private string _name;
        private string _mayor;
        private DateTime _dateEstablished;
        private List<Building> _listOfBuildings = new List<Building>();
        //Properties
        public List<Building> Buildings
        {
            get { return _listOfBuildings; }
        }
        //Methods
        public void addBuilding(Building buildingObject){
            _listOfBuildings.Add(buildingObject);
        }
    }
}