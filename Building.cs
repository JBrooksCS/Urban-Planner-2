using System;

namespace Urban_Planner
{
    public class Building{
        //CONSTRUCTOR
        public Building(string address){
            _address = address;
        }
        //Fields
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        //Properties
        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Volume {
            get{
                return (Width * Depth * (Stories * 3));
            }
        }
        //Methods
        public void Construct(){
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string buyerName){
            _owner = buyerName;
        }
        public string GetLocation(){
            return _address;
        }
        public string GetDateConstructed(){
            string buildDate = _dateConstructed.ToString();
            return buildDate;
        }
        public string GetOwner(){
            return _owner;
        }



    }
}