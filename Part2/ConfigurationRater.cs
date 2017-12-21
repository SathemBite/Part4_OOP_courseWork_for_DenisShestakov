using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Part2
{
    class ConfigurationRater
    {
        DataGridView dGV;
        DataGridViewRowCollection rows;

        public ConfigurationRater(DataGridView dGV)
        {
            this.dGV = dGV;
            this.rows = dGV.Rows;
        }

        public void SaveToFile()
        {
            StreamWriter sw = new StreamWriter(@"out.txt");
            sw.Write(FindBestConfigurations());
            sw.Close();
        }

        public string FindBestConfigurations()
        {
            LinkedList<Configuration> configurations = new LinkedList<Configuration>();
            int j;

            for (int i = 0; i < rows.Count - 1; i++)
            {
                configurations.AddLast(new Configuration(i + 1, GetAttributeVals(rows[i])));
            }

            int confRem1 = configurations.Count();
            for (int i = 0; i < confRem1; i++)
            {
                int confRem2 = configurations.Count() - 1;
                Configuration c1 = configurations.First();
                configurations.RemoveFirst();

                for (j = 0; j < confRem2; j++)
                {
                    Configuration c2 = configurations.First();
                    ParetoClass relation = c1.GetParClassRelation(c2);
                    if (relation == ParetoClass.NON_INFERIOR)
                    {
                        confRem1--;
                        CycleShift(ref configurations);
                    }
                    else
                    {
                        if (relation == ParetoClass.DOMINANT)
                        {
                            configurations.RemoveFirst();
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (j == confRem2)
                {
                    configurations.AddLast(c1);
                }
            }


            IEnumerable<Configuration> resultConf = configurations.OrderBy(conf => conf.Id);
            string result = "";
            ParetoClass paretoClass = resultConf.Count() == 1 ? ParetoClass.DOMINANT : ParetoClass.NON_INFERIOR;
            foreach (Configuration conf in resultConf)
            {
                conf.ParetoClass = paretoClass;
                result += conf;
            }

            return result;
        }

        private void CycleShift(ref LinkedList<Configuration> objects)
        {
            Configuration o = objects.First();
            objects.RemoveFirst();
            objects.AddLast(o);
        }



        private int[] GetAttributeVals(DataGridViewRow row)
        {
            int[] paramVals = new int[4];

            for (int i = 1; i <= 4; i++)
            {
                if (row.Cells[i].Value == null)
                {
                    return null;
                }
                paramVals[i - 1] = int.Parse((string)(row.Cells[i].Value));
            }

            return paramVals;
        }

        public void LoadControlExample()
        {
            rows.Clear();
            AddRow(1, 100, 80, 50, 60);
            AddRow(2, 90, 70, 60, 50);
            AddRow(3, 80, 50, 40, 40);
            AddRow(4, 100, 60, 70, 30);
            AddRow(5, 70, 80, 80, 70);
            AddRow(6, 70, 60, 80, 50);
            AddRow(7, 90, 40, 70, 60);
            AddRow(8, 80, 50, 60, 40);
            AddRow(9, 80, 70, 30, 70);
            AddRow(10, 60, 80, 40, 50);

        }

        private void AddRow(int ind, int col1, int col2, int col3, int col4)
        {
            this.dGV.Rows.Add(
                ind.ToString(),
                col1.ToString(),
                col2.ToString(),
                col3.ToString(),
                col4.ToString()
                );
        }
    }
}
