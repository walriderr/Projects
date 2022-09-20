using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Linq;

namespace Project05_v3
{
    public class GetInfo
    {
        List<Vacationer> vacationersList = new List<Vacationer>();

        public List<Vacationer> GetVacationers()
        {
            ReadXml();

            return vacationersList;
        }

        public void ReadXml()
        {
            if (File.Exists("Vacationer.xml"))
            {
                XDocument xdoc = XDocument.Load("Vacationer.xml");
                foreach (XElement dir in xdoc.Element("Vacationers").Elements("Vacationer"))
                {
                    Vacationer vacationer = new Vacationer
                    {
                        fio = dir.Attribute("fio").Value,
                        education = dir.Element("education").Value,
                        city = dir.Element("city").Value,
                        socialStatus = dir.Element("socialStatus").Value,
                        income = Convert.ToInt32(dir.Element("income").Value),
                        place = dir.Element("place").Value,
                        age = Convert.ToInt32(dir.Element("age").Value),
                        year = Convert.ToInt32(dir.Element("year").Value),
                        mouth = Convert.ToInt32(dir.Element("mouth").Value),
                        day = Convert.ToInt32(dir.Element("day").Value),
                        durationRest = Convert.ToInt32(dir.Element("durationRest").Value),
                        amountSpent = Convert.ToDouble(dir.Element("amountSpent").Value)
                    };
                    vacationersList.Add(vacationer);
                }
            }
            else
            {
                MessageBox.Show("Отсутствует база данных!");
            }
        }
    }
}
