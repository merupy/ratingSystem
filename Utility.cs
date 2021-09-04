using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratingSystem
{
    class Utility
    {
        public static void writeCriteria(string criteria) // creating text file for criteria
        {
            StreamWriter streamWriter = new StreamWriter(Review.criteriaFile, true);
            streamWriter.WriteLine(criteria);
            streamWriter.Close();  
        }

        public static List<string>ReadCriteria() // reading criteria file 
        {
            StreamReader streamReader = new StreamReader("criteria.txt");
            List<string> criterias = new List<string>();
            string dataRead = streamReader.ReadLine();
            while (dataRead != null)
            {

                criterias.Add(dataRead);
                dataRead = streamReader.ReadLine();
            }
            streamReader.Close();
            return criterias;
        }

        public static void  writeReview(Review cReview) // creating text file for customer review
        {
            string Customerdata = JsonConvert.SerializeObject(cReview, Formatting.None);
            StreamWriter streamWriter = new StreamWriter(cReview.customerReview, true);
            streamWriter.WriteLine(Customerdata);
            streamWriter.Close();
        }

        public static List<string> Criterias() // reading customer review 
        {
            StreamReader streamReader = new StreamReader("criteria.txt");
            List<string> Criterias = new List<string>();
            string line = streamReader.ReadLine();
            while (line != null)
            {
                Criterias.Add(line);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            return Criterias;
        }

        public List<Review> feedback() // 
        {

            StreamReader streamReader = new StreamReader("review.txt");
            List<Review> review = new List<Review>();
            string line = streamReader.ReadLine();
            while (line != null)
            {
                Review creview = (Review)JsonConvert.DeserializeObject<Review>(line);
                review.Add(creview);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            return review;
        }

        public static DataTable ConvertToDataTable(List<Review> review) // showing all the customer review in table form
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(Review));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                if (prop.Name != "CustomerRating")
                {
                    table.Columns.Add(prop.Name);
                }

            }
            foreach (Review item in review)
            {
                foreach (KeyValuePair<string, int> Ratings in item.CustomerRating)
                {
                    if (table.Columns.Contains(Ratings.Key)==false)
                    {
                        table.Columns.Add(Ratings.Key);
                    }
                }

            }


            if (review != null)
            {
                foreach (Review item in review)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                    {
                        if (prop.Name != "CustomerRating")
                        {
                            row[prop.Name] = prop.GetValue(item);
                        }
                        else
                        {
                            foreach (KeyValuePair<string, int> entry in item.CustomerRating)
                            {
                                row[entry.Key] = entry.Value;
                            }
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            return table;

        }

        public static Dictionary<string, int> Chart(List<Review> review) // showing chart of criteria ratings 
        {
            Dictionary<string, int> cData = new Dictionary<string, int>();
            Dictionary<string, int> DataFinal = new Dictionary<string, int>();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(Review));

            if (review != null)
            {
                foreach (Review item in review)
                {
                    foreach (PropertyDescriptor p in properties)
                    {
                        if (p.Name == "CustomerRating")
                        {
                            foreach (KeyValuePair<string, int> entry in item.CustomerRating)
                            {
                                if (cData.ContainsKey(entry.Key))
                                {
                                    int newVal = cData[entry.Key];
                                    cData[entry.Key] = newVal + entry.Value;
                                }
                                else
                                {
                                    cData.Add(entry.Key, entry.Value);
                                }
                            }
                        }
                    }

                }

                foreach (KeyValuePair<string, int> entry in cData)
                {
                    DataFinal.Add(entry.Key, entry.Value / cData.Count);
                }
            }
            return DataFinal;
        }
        public static List<Review> SortByDate(List<Review> review) // bubbleshort algorithm implementation 
        {
            Review temp;
            for (int j = 0; j <= review.Count - 2; j++)
            {
                for (int i = 0; i <= review.Count - 2; i++)
                {
                    if (review[i].datetime > review[i + 1].datetime)
                    {
                        temp = review[i + 1];
                        review[i + 1] = review[i];
                        review[i] = temp;
                    }
                }
            }
            return review;
        }
    }
}
