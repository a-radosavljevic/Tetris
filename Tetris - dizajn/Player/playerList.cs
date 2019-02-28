using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Player
{
    public class playerList
    {
        private List<Player> players;

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public playerList()
        {
            players = new List<Player>();
        }

        private static playerList list = null;

        public static playerList List
        {
            get
            {
                if (list == null)
                    list = new playerList();
                return list;
            }
        }

        private void sort()
        {
            int i, j, k;
            for (i = 0; i < players.Count - 1; i++)
            {
                k = i;
                for (j = i + 1; j < players.Count; j++)
                    if (players[k].Points < players[j].Points)
                        k = j;
                if (k != i)
                {
                    int p = players[k].Points;
                    players[k].Points = players[i].Points;
                    players[i].Points = p;
                }
            }
        }

        public bool add(Player p)
        {
            players.Add(p);
            sort();
            return true;
        }

        public void save(string p)
        {
            TextWriter xtw = null;
            try
            {
                xtw = new StreamWriter(p);
                XmlSerializer sr = CreateOverrider();
                sr.Serialize(xtw, this);
            }
            catch
            {

            }
            finally
            {
                xtw.Close();
            }
        }

        private static XmlSerializer CreateOverrider()
        {
            XmlAttributeOverrides xOver = new XmlAttributeOverrides();
            XmlAttributes attrs = new XmlAttributes();

            attrs.XmlIgnore = false;
            xOver.Add(typeof(Player), "NAME", attrs);
            attrs.XmlIgnore = false;
            attrs.XmlElements.Add(new XmlElementAttribute("SURNAME"));
            xOver.Add(typeof(playerList), "OTVORENA", attrs);

            XmlSerializer xSer = new XmlSerializer(typeof(playerList), xOver);
            return xSer;
        }
    }
}
