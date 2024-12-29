using System;

namespace RosterManager
{
    public class Player
    {
        private string _name;
        private string _position;
        private int _jerseyNumber;
        private int _age;

        public Player(string name, string position, int jerseyNumber, int age)
        {
            this._name = name;
            this._position = position;
            this._jerseyNumber = jerseyNumber;
            this._age = age;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }
        public int JerseyNumber
        {
            get { return this._jerseyNumber; }
            set { this._jerseyNumber = value; }
        }
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
    }
}