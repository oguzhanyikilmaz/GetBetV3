using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Core.Helpers
{
    public static class CHelper
    {
        /// <summary>
        /// DataTable nesnesini HTML'e çevirir.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ConvertDataTableToHTML(DataTable dt)
        {
            string html = "<table>";
            //add header row
            html += "<tr>";
            for (int i = 0; i < dt.Columns.Count; i++)
                html += "<td>" + dt.Columns[i].ColumnName + "</td>";
            html += "</tr>";
            //add rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html += "<tr>";
                for (int j = 0; j < dt.Columns.Count; j++)
                    html += "<td>" + dt.Rows[i][j].ToString() + "</td>";
                html += "</tr>";
            }
            html += "</table>";
            return html;
        }

        /// <summary>
        /// Mail gönderilecek adresleri çeker.
        /// </summary>
        /// <returns></returns>
        public static List<string> MailToAdresses()
        {
            List<string> adresses = new List<string>();

            adresses.Add("berkaybadur5@gmail.com");
            adresses.Add("tmkemaldikici@hotmail.com");
            adresses.Add("mahmutakpinarmkn@outlook.com");
            adresses.Add("oguzhanyklmz27@gmail.com");

            return adresses;
        }
    }
}
