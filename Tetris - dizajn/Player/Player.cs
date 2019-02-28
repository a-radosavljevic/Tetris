using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Player
{
    [Serializable]
    public class Player
    {
        #region Attributes
        private string name;

        [XmlElementAttribute("NAME")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        [XmlElementAttribute("SURNAME")]
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private int points;

        [XmlElementAttribute("POINTS")]
        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        #endregion

        #region Methods
        public Player()
        {

        }

        public Player(string name, string surname, int points, DateTime date)
        {
            this.name = name;
            this.surname = surname;
            this.points = points;
            this.date = date;
        }
        #endregion
    }
}
